using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vpProj
{
    public partial class DataReportsForm : Form
    {
        public DataReportsForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            f1.Show();
            this.Close();
        }

        private void btnAllValid_Click(object sender, EventArgs e)
        {
            try
            {
                ValidMembershipsReportForm F = new ValidMembershipsReportForm();
                DataSet1TableAdapters.MembershipsTableAdapter memb = new DataSet1TableAdapters.MembershipsTableAdapter();
                DataTable dt = new DataTable();
                dt = memb.GetValidMembsDT();
                validMembershipsReport cr = new validMembershipsReport();
                cr.SetDataSource(dt);
                F.crystalReportViewer1.ReportSource = cr;
                F.crystalReportViewer1.Refresh();
                F.Show();
                //this.Hide();

            }
            catch (Exception err)
            {
                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnCntSumInYear_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataSet1TableAdapters.DataTableYearQueryTableAdapter CntYear = new DataSet1TableAdapters.DataTableYearQueryTableAdapter();

                dt = CntYear.GetDataYearCntSumDT(int.Parse(txtYear.Text));
                
                CntSumInYearReport cr = new CntSumInYearReport();
                cr.SetDataSource(dt);
                ((CrystalDecisions.CrystalReports.Engine.TextObject)cr.Section2.ReportObjects["txtTitle"]).Text = String.Format( "Number of Memberships in {0} and their Total Price", int.Parse(txtYear.Text));
                CntInYearSumForm F = new CntInYearSumForm();
                F.crystalReportViewer1.ReportSource = cr;
                F.crystalReportViewer1.Refresh();
                F.Show();

            }
            catch (Exception err)
            {
                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnUnpaidMemberShips_Click(object sender, EventArgs e)
        {
            try
            {

                ValidMembershipsReportForm F = new ValidMembershipsReportForm();
                DataSet1TableAdapters.MembershipsTableAdapter memb = new DataSet1TableAdapters.MembershipsTableAdapter();
                DataTable dt = new DataTable();
                dt = memb.unpaidDT();
                validMembershipsReport cr = new validMembershipsReport();
                cr.SetDataSource(dt);
                ((CrystalDecisions.CrystalReports.Engine.TextObject)cr.Section2.ReportObjects["txtTitle"]).Text = "All Unpaid Memberships";
                F.crystalReportViewer1.ReportSource = cr;
                F.crystalReportViewer1.Refresh();
                F.Show();
            }
            catch (Exception err)
            {
                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error"); 
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string helpMessage = String.Format("Fields:\nYear: A number representing a valid year.\n\nButton Descriptions :\n\n-All valid memberships: Shows a report with all valid memberships.\nA valid membership is one that has already started (the current date is greater than the start date), hasn't ended yet, and hasn't been canceled.\n\n-All unpaid memberships: shows a report with all memberships that haven't been paid for yet.\n\n-Count of Memberships in ... : shows a report with the count of all memberships that were in a specific year (the end or start date are in that year) , based on the value entered in the Year field.\nThe Year field must be filled out to enable the button.");
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);


        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtYear, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (txtYear.Text == "" || (Convert.ToInt16(txtYear.Text) < 1971 || Convert.ToInt16(txtYear.Text) > Convert.ToInt16(DateTime.Now.Year))) 
            {
                btnCntSumInYear.Enabled = false;
                errorProvider1.SetError(txtYear, "Enter a valid year (1971 - Current Year)");
            }
            else
            {
                errorProvider1.Clear();
                btnCntSumInYear.Enabled = true;
            }
        }
    }
}
