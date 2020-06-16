using EDSL_Prototype.DAL;
using EDSL_Prototype.Handlers;
using EDSL_Prototype.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDSL_Prototype
{
    public partial class EDSL_System : Form
    {
        EDSL_Results resultGUI;
        EDSL_SelectDates selectDatesGUI;
        public EDSL_System()
        {
            InitializeComponent();
            pnl_System.BringToFront();
            btn_SelectDates.Enabled = false;
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            this.resultGUI = new EDSL_Results(this);
            this.Hide();
            resultGUI.Show();
        }

        private void EDSL_System_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_Season_Click(object sender, EventArgs e)
        {
            lbl_SeasonAdmin.Text = "Season Admin";
        }

        private void btn_SaveSeasonDates_Click(object sender, EventArgs e)
        {
            SeasonHandler.SaveSeasonDates(txt_SeasonName.Text);
            MessageBox.Show("Season Dates have been Saved");
        }

        private void btn_ViewSeasonDates_Click(object sender, EventArgs e)
        {
            SeasonHandler.GenerateSeasonDates(txt_SeasonName.Text, date_Picker_StartDate.Value, data_Grid_View_SeasonDates, Convert.ToInt32(num_Rounds.Value));
            btn_SelectDates.Enabled = true;
        }

        private void btn_SelectDates_Click(object sender, EventArgs e)
        {
            this.selectDatesGUI = new EDSL_SelectDates(this, txt_SeasonName.Text);
            this.Hide();
            selectDatesGUI.Show();
        }


    }
}
