using EDSL_Prototype.DAL;
using EDSL_Prototype.Handlers;
using EDSL_Prototype.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EDSL_Prototype
{
    public partial class EDSL_SelectDates : Form
    {
        EDSL_System systemGUI;
        private static Season season;
        string seasonName;
        DateTimePicker dtp = new DateTimePicker();
        Rectangle rect;
        public EDSL_SelectDates(EDSL_System systemGUI, string seasonName)
        {
            this.systemGUI = systemGUI;
            this.seasonName = seasonName;
            InitializeComponent();
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            season = DAFunctions.ReadSeason(seasonName);
            SeasonHandler.FillGridd(grid, season);

            grid.Columns[1].Width = 200;
            grid.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Long;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            grid.Columns[2].Selected = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rect = grid.GetCellDisplayRectangle(1, e.RowIndex, true);
            dtp.Size = new Size(rect.Width, rect.Height);
            dtp.Location = new Point(rect.X, rect.Y);
            dtp.Visible = true;

        }

        private void dtp_TextChange(object sender, EventArgs e)
        {
            grid.CurrentCell.Value = dtp.Text.ToString();
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void EDSL_SelectDates_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.systemGUI.Show();
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentCell.ColumnIndex == 1)
            {
                grid.CurrentCell.Value = dtp.Text.ToString();
                season.SeasonDates[grid.CurrentCell.RowIndex] = dtp.Value;
                dtp.Value = DateTime.Now;
            }
        }

        private void btn_AddRound_Click(object sender, EventArgs e)
        {
            season.SeasonDates.Add(DateTime.Now);
            RefreshGrid();
        }

        private void btn_RemoveRound_Click(object sender, EventArgs e)
        {
            season.SeasonDates.RemoveAt(grid.CurrentCell.RowIndex);
            RefreshGrid();
        }
    }
}
