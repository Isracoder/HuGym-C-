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
    public partial class MembershipForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vpProj;Integrated Security=True");
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void btnAddMembshp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand("select * from Memberships where MembershipID=@id", con);
                checkCmd.Parameters.AddWithValue("@id", int.Parse(txtMbshpId.Text));
                SqlDataReader dr = checkCmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    dr.Close();
                    checkCmd = new SqlCommand("select max(MembershipID) from Memberships", con);
                    int mx = Convert.ToInt16(checkCmd.ExecuteScalar());
                    MessageBox.Show(String.Format("That membership ID is already taken , please try {0}", mx + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else {

                    dr.Close();
                    SqlCommand cmd = new SqlCommand("Insert into Memberships values(@ID, @MemberID,@startDate , @endDate ,@paid ,  @price , @canceled)", con);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(txtMbshpId.Text));
                    cmd.Parameters.AddWithValue("@MemberID", txtMmbrId.Text);
                    cmd.Parameters.AddWithValue("@startDate", pckrStartDate.Text);
                    cmd.Parameters.AddWithValue("@endDate", pckrStartDate.Value.AddYears(1).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@price", txtTotalPrice.Text);
                    cmd.Parameters.AddWithValue("@paid", txtPaid.Text == "" ? "No" : txtPaid.Text);
                    cmd.Parameters.AddWithValue("@canceled", "No");
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Membership Added Successfully!", "Success");
                    else MessageBox.Show("Something went wrong!", "Error");
                }

                con.Close();
               

            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            f1.Show();
            this.Close();
        }

        private void pckrStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkSauna_CheckedChanged(object sender, EventArgs e)
        {
            int originalValue = txtTotalPrice.Text == "" ? 0 : Convert.ToInt16(txtTotalPrice.Text);
            if (chkSauna.Checked)
            {
                txtTotalPrice.Text = (originalValue + 300 ).ToString();
            }
            else
            {
                txtTotalPrice.Text = (originalValue - 300).ToString();
            }
        }

        private void chckSteam_CheckedChanged(object sender, EventArgs e)
        {
            int originalValue = txtTotalPrice.Text == "" ? 0 : Convert.ToInt16(txtTotalPrice.Text);
            if (chckSteam.Checked)
            {
                txtTotalPrice.Text = (originalValue + 300).ToString();
            }
            else
            {
                txtTotalPrice.Text = (originalValue - 300).ToString();
            }
        }

        private void chckMassages_CheckedChanged(object sender, EventArgs e)
        {
            int originalValue = txtTotalPrice.Text == "" ? 0 : Convert.ToInt16(txtTotalPrice.Text);
            if (chckMassages.Checked)
            {
                txtTotalPrice.Text = (originalValue+ 500).ToString();
            }
            else
            {
                txtTotalPrice.Text = (originalValue - 500).ToString();
            }
        }

        private void chckGym_CheckedChanged(object sender, EventArgs e)
        {
            int originalValue = txtTotalPrice.Text == "" ? 0 : Convert.ToInt16(txtTotalPrice.Text);
            
            if (chckGym.Checked)
            {
                txtTotalPrice.Text = (originalValue + 500).ToString();
            }
            else
            {
                txtTotalPrice.Text = (originalValue - 500).ToString();
            }
        }

        private void chckPool_CheckedChanged(object sender, EventArgs e)
        {
            int originalValue = txtTotalPrice.Text == "" ? 0 : Convert.ToInt16(txtTotalPrice.Text);
            if (chckPool.Checked)
            {
                txtTotalPrice.Text = (originalValue + 500).ToString();
            }
            else
            {
                txtTotalPrice.Text = (originalValue - 500).ToString();
            }
        }

        private void txtMbshpId_Leave(object sender, EventArgs e)
        {
            if (txtMbshpId.Text == "")
            {
                txtMbshpId.Focus();
                errorProvider1.SetError(txtMbshpId, "Please enter an ID");
            }
            else
            {
                errorProvider1.Clear();
              

            }
            filledEnableAdd();
        }

        private void txtMbshpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMbshpId, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtMmbrId_Leave(object sender, EventArgs e)
        {
            if (txtMmbrId.Text == "")
            {
                txtMmbrId.Focus();
                errorProvider1.SetError(txtMmbrId, "Please enter an ID");
            }
            else
            {
                errorProvider1.Clear();

            }
            filledEnableAdd();

        }

        private void txtMmbrId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMmbrId, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
            
        }

        private void txtPaid_Leave(object sender, EventArgs e)
        {
            txtPaid.Text = txtPaid.Text.Trim(' ');
            if (!(txtPaid.Text == "Yes" || txtPaid.Text == "No" || txtPaid.Text == ""))
            {
                txtPaid.Focus();
                errorProvider1.SetError(txtPaid, "Please enter either Yes,No, or leave this field empty");
            }
            else
            {
                errorProvider1.Clear();

            }
            filledEnableAdd();
        }

        void filledEnableAdd()
        {
            if (txtMbshpId.Text != "" && txtMmbrId.Text != "" && txtTotalPrice.Text != "0")
            {

                btnAddMembshp.Enabled = true;
                btnAddMembshp.Cursor = Cursors.Hand;
            }
            else
            {
                btnAddMembshp.Enabled = false;
                btnAddMembshp.Cursor = Cursors.Default;
            }
        }

        private void grpMmbshpDetails_Leave(object sender, EventArgs e)
        {
            if (nothingSelected())
            {
                errorProvider1.SetError(grpMmbshpDetails, "Please select a gym service");
            }
            else
            {
                errorProvider1.Clear();
            }
            filledEnableAdd();
        }
        bool nothingSelected()
        {
            if (chckGym.Checked || chckMassages.Checked || chckPool.Checked || chckSteam.Checked || chkSauna.Checked) return false;
            return true;
        }

        private void pctrHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = String.Format("Fields:\nMember ID: A unique number referring to a specific gym member.\nMembership ID: A unique number referring to a specific membership.\nTotal Price : A number represnting the sum of the price of all services included in the membership.\nPayment made : A field representing whether the membership was paid for or not.Valid values are ('Yes','No') or an empty value, which means that the membership hasn't been paid.\nStart Date : The chosen start date for the membership in 'year-month-day' format.The end date for the membership is automatically calculated to be one year after the start date.\nMembership Details: All service options that can be included in the membership, each with its price next to it.\n\nButton Descriptions :\n\n-Add Membership : creates a new membership based on entered fields and saves it.\nTo Enable the button all fields must be filled out except the Payment made field, and at least one service must be checked.");
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}



// delete is redundant , prefer cancelation
/*
private void btnDelMembshp_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from Memberships where MembershipID=@id", con);
        cmd.Parameters.AddWithValue("@id", txtMbshpId.Text);
        DialogResult R = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (R == DialogResult.Yes)
        {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deletion complete");
        }


        con.Close();
    }
    catch (Exception err)
    {

        string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
        MessageBox.Show(error, "Error");
    }
}
*/

