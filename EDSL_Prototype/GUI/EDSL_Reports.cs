using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDSL_Prototype.GUI
{
    public partial class EDSL_Reports : Form
    {
        EDSL_System systemGUI;
        public EDSL_Reports(EDSL_System systemGUI)
        {
            InitializeComponent();
            this.systemGUI = systemGUI;
        }

        private void btn_DrawReport_Click(object sender, EventArgs e)
        {
            pic_Reports.Load("draw.JPG");
            pic_Reports.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_LadderReport_Click(object sender, EventArgs e)
        {
            pic_Reports.Load("ladder.JPG");
            pic_Reports.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_GroundsReport_Click(object sender, EventArgs e)
        {
            pic_Reports.Load("grounds.JPG");
            pic_Reports.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_PrintReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report Printed");
        }

        private void EDSL_Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            systemGUI.Show();
        }

        private void cbo_SelectSeason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_SelectDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Results_Click(object sender, EventArgs e)
        {

        }

        private void btn_Season_Click(object sender, EventArgs e)
        {
            this.Dispose();
            systemGUI.Show();
        }
    }
}
