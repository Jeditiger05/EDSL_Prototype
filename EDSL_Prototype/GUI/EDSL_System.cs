using EDSL_Prototype.DAL;
using EDSL_Prototype.GUI;
using EDSL_Prototype.Handlers;
using EDSL_Prototype.Models;
using System;
using System.Windows.Forms;

namespace EDSL_Prototype
{
    public partial class EDSL_System : Form
    {
        EDSL_Results resultGUI;
        EDSL_SelectDates selectDatesGUI;
        private Season season;

        public EDSL_System()
        {
            InitializeComponent();
            pnl_System.BringToFront();
            btn_SelectDates.Enabled = false;
            DAFunctions.LoadData();
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
            SeasonHandler.SaveSeasonDates();
            MessageBox.Show("Season Dates have been Saved");
            
        }

        private void btn_ViewSeasonDates_Click(object sender, EventArgs e)
        {
            season = SeasonHandler.ViewSeasonDates(data_Grid_View_SeasonDates, txt_SeasonName.Text);
            if(season != null)
            {
                btn_SelectDates.Enabled = true;
            }
        }

        private void btn_NewDates_Click(object sender, EventArgs e)
        {
            season = SeasonHandler.GenerateSeasonDates(txt_SeasonName.Text, date_Picker_StartDate.Value, 
            data_Grid_View_SeasonDates, Convert.ToInt32(num_Rounds.Value));
            if(season != null)
            btn_SelectDates.Enabled = true;
        }

        private void btn_SelectDates_Click(object sender, EventArgs e)
        {
            this.selectDatesGUI = new EDSL_SelectDates(this, txt_SeasonName.Text);
            selectDatesGUI.Show();
        }

        private void btn_CreateDraw_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(SeasonHandler.CreateDivisionDraw("A Division")[0].GameList[0].AwayTeam);
            EDSL_Draw drawGUI = new EDSL_Draw();
            drawGUI.Show();
            SeasonHandler.CreateDivisionDraw(cbo_Division.Text);
        }

        private void btn_ViewDraw_Click(object sender, EventArgs e)
        {
            
        }
    }
}
