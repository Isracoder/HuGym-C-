using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vpProj
{
    public partial class mainForm : Form
    {
        
        //DataSet1TableAdapters.EmpTableAdapter EMP = new DataSet1TableAdapters.EmpTableAdapter();
        //DataSet1TableAdapters.DataTable1TableAdapter ALL = new DataSet1TableAdapters.DataTable1TableAdapter();
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnEmpData_Click(object sender, EventArgs e)
        {
            EmpDataForm empdataForm = new EmpDataForm();
            this.Hide();
            empdataForm.ShowDialog();
            //this.Show();

        }

        private void btnMemData_Click(object sender, EventArgs e)
        {
            MemberDataForm membdataForm = new MemberDataForm();
            this.Hide();
            membdataForm.ShowDialog();
            //this.Show();
        }
        

        private void btnPaymentsRefunds_Click(object sender, EventArgs e)
        {
            PaymentsRefundsForm f = new PaymentsRefundsForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDataReports_Click(object sender, EventArgs e)
        {
            DataReportsForm f = new DataReportsForm();
            this.Hide();
            f.ShowDialog();
            //this.Show();
        }

        private void btnNewMembership_Click(object sender, EventArgs e)
        {
            MembershipForm membshipForm = new MembershipForm();
            this.Close();
            membshipForm.Show();
            //this.Show();
        }
    }
}
