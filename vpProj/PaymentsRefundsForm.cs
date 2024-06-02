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
    public partial class PaymentsRefundsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vpProj;Integrated Security=True");
        public PaymentsRefundsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            //f();
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult R = MessageBox.Show("Do You want to set this membership as Paid?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R != DialogResult.Yes) return;
                con.Open();
                SqlCommand cmd = new SqlCommand("update Memberships set Paid=@paid  where MembershipId=@id", con);
                cmd.Parameters.AddWithValue("@id", txtMembershipId.Text);
                cmd.Parameters.AddWithValue("@paid", "Yes");
                
                int r =  cmd.ExecuteNonQuery();
                if (r > 0) MessageBox.Show("Membership information updated");
                else MessageBox.Show("There was no membership found with that Id");
                
                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnGetMembership_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select MemberId , Paid , Price , Canceled from Memberships where MembershipID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtMembershipId.Text);
                 cmd.ExecuteNonQuery();
               
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    dataGridView1.DataSource = dt;
                
                if (dataGridView1.RowCount < 2)MessageBox.Show("The membership with that id wasn't found");
                

                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
               
                DialogResult R = MessageBox.Show("Are you sure you want to cancel this membership and get a partial refund?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    SqlCommand hasPaidcmd = new SqlCommand("select Paid , Price , endDate , canceled from Memberships where MembershipID=@id", con);
                    hasPaidcmd.Parameters.AddWithValue("@id", txtMembershipId.Text);
                    SqlDataReader dr = hasPaidcmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                            
                        dr.Read();
                        string paid = dr[0].ToString();
                        string price = dr[1].ToString();
                        DateTime end = Convert.ToDateTime(dr[2].ToString());
                        string canceled = dr[3].ToString();
                        if (end < DateTime.Now || canceled == "Yes")
                        {
                            MessageBox.Show("You can't cancel a membership that has already ended or been canceled!" , "Notice" , MessageBoxButtons.OK);
                        }
                        else
                        {
                            dr.Close();
                            SqlCommand cmd = new SqlCommand("update Memberships set canceled=@cancel  where MembershipID=@id", con);
                            cmd.Parameters.AddWithValue("@id", txtMembershipId.Text);
                            cmd.Parameters.AddWithValue("@cancel", "Yes");
                            int r = cmd.ExecuteNonQuery();
                            string msg = String.Format("Membership canceled.Since you {0} paid, you get a {1}% refund of the {2} price.", paid == "Yes" ? "have" : "haven't", paid == "Yes" ? "50" : "0", price);
                            MessageBox.Show(msg);
                            
                        }
                    }
                    else MessageBox.Show("There was no Membership found with that ID");
                }


                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnGetMembershipsOfMember_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Memberships where MemberId=@id", con);
                cmd.Parameters.AddWithValue("@id", txtMembId.Text);
 
                

                    SqlDataAdapter dp = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dataGridView1.RowCount < 2) MessageBox.Show("There were no memberships found for a member with that Id");
                
          
                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void txtMembershipId_Leave(object sender, EventArgs e)
        {
            
            if (txtMembershipId.Text == "")
            {
                txtMembershipId.Focus();
                errorProvider1.SetError(txtMembershipId, "Please enter an ID");
                btnGetMembership.Enabled = false;
                btnPay.Enabled = false;
                btnRefund.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnGetMembership.Enabled = true;
                btnPay.Enabled = true;
                btnRefund.Enabled = true;

            }

        }

        private void txtMembershipId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMembershipId, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtMembId_Leave(object sender, EventArgs e)
        {
            if (txtMembId.Text == "")
            {
                txtMembId.Focus();
                errorProvider1.SetError(txtMembId, "Please enter an ID");
                btnGetMembershipsOfMember.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnGetMembershipsOfMember.Enabled = true;
            }


        }

        private void txtMembId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMembId, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string helpMessage = String.Format("Fields:\nMember ID: A unique number referring to a specific gym member.\nMembership ID: A unique number referring to a specific membership.\n\nButton Descriptions :\n\n-Get Membership by ID: gets all information regarding a specific membership based on its membership ID.\nTo Enable the button the membership Id field must be filled out.\n\n-Get all memberships of member: gets information of all memberships that belong to a specific gym member based on the member Id.\nThe member ID field must be filled out to enable the button.\n\n-Cancel and Refund: cancels a membership based on its membership ID ,if the membership was paid for the system notifies that a partial refund may be claimed in person.\nThe membership Id field must be filled out to enable this button.\n\n-Pay For membership: sets a membership as paid based on the specific membership Id.\nThe membership Id field must be filled out to enable the button.");
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
