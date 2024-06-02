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
    public partial class MemberDataForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vpProj;Integrated Security=True");
        public MemberDataForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            f1.Show();
            this.Close();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Members where MembID=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtMembId.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    dr.Close();
                    cmd = new SqlCommand("select max(MembID) from Members", con);
                    int mx = Convert.ToInt16(cmd.ExecuteScalar());
                    MessageBox.Show(String.Format("That ID is already taken , please try {0}", mx + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    dr.Close();
                    SqlCommand insertCmd = new SqlCommand("Insert into Members values(@ID, @Name, @Email , @Phone)", con);
                    insertCmd.Parameters.AddWithValue("@ID", int.Parse(txtMembId.Text));
                    insertCmd.Parameters.AddWithValue("@Name", txtMembName.Text);
                    insertCmd.Parameters.AddWithValue("@Email", txtMembEmail.Text);
                    insertCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    int a = insertCmd.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Gym member Added Successfully!", "Success");
                    else MessageBox.Show("Something went wrong!", "Error");

                }

            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.Message);
                MessageBox.Show(error, "Error");
            }
            con.Close();
        }
        private void btnGetMember_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select MembName, MembEmail , MembEmergencyPhone from Members where MembID=@id", con);
                cmd.Parameters.AddWithValue("id", txtMembId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    txtMembName.Text = dr[0].ToString();
                    txtMembEmail.Text = dr[1].ToString();
                    txtPhone.Text = dr[2].ToString();

                }
                else
                {
                    MessageBox.Show("The gym member with that id wasn't found");
                }

                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

        private void btnDelMember_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Members where MembID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtMembId.Text);
                DialogResult R = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0) MessageBox.Show("Deletion complete");
                    else MessageBox.Show("Something went wrong when trying to delete.\nPlease make sure entered fields are valid.");
                }


                con.Close();
                
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }

        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                DialogResult R = MessageBox.Show("Are you sure you want to update ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.No) return;
                SqlCommand cmd = new SqlCommand("select MembName, MembEmail, MembEmergencyPhone from Members where MembID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtMembId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    dr.Close();
                    cmd = new SqlCommand("update Members set MembName=@n,MembEmail=@E  , MembEmergencyPhone=@p where MembID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtMembId.Text);
                    cmd.Parameters.AddWithValue("@n", txtMembName.Text != "" ? txtMembName.Text : dr[0].ToString());
                    cmd.Parameters.AddWithValue("@E", txtMembEmail.Text != "" ? txtMembEmail.Text : dr[1].ToString());
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text != "" ? txtPhone.Text : dr[2].ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member information updated");
                }
                else
                {
                    MessageBox.Show("The member with that id wasn't found");
                }

                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
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

        private void txtMembId_Leave(object sender, EventArgs e)
        {
            if (txtMembId.Text == "")
            {
                txtMembId.Focus();
                btnDelMember.Enabled = false;
                btnGetMember.Enabled = false;
                errorProvider1.SetError(txtMembId, "Please enter an ID");
            }
            else
            {
                errorProvider1.Clear();
                btnDelMember.Enabled = true;
                btnGetMember.Enabled = true;

            }
            filledEnableAdding();
            filledEnableEditing();
        }
        void filledEnableAdding()
        {
            if (txtMembId.Text != "" && txtMembName.Text != "" && txtMembEmail.Text != "" && txtPhone.Text != "")
                btnAddMember.Enabled = true;
            else btnAddMember.Enabled = false;

        }
        void filledEnableEditing()
        {
            if (txtMembId.Text != "" && (txtMembName.Text != "" || txtMembEmail.Text != "" || txtPhone.Text != ""))
                btnEditMember.Enabled = true;
            else btnEditMember.Enabled = false;

        }

        private void txtMembName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMembName, "Accept only english or arabic letters");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


        private void txtMembEmail_Leave(object sender, EventArgs e)
        {
            if (txtMembEmail.Text == "")
            {
                txtMembEmail.Focus();
                errorProvider1.SetError(txtMembEmail, "Please enter an email");
            }
            else
            {
                errorProvider1.Clear();

            }
            filledEnableAdding();
            filledEnableEditing();
        }

        private void txtMembName_Leave(object sender, EventArgs e)
        {
            txtMembName.Text = txtMembName.Text.Trim(' ');
            if (txtMembName.Text == "")
            {
                txtMembName.Focus();
                errorProvider1.SetError(txtMembName, "Please enter a name");
                btnMembByName.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnMembByName.Enabled = true;
            }
            filledEnableAdding();
            filledEnableEditing();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPhone, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Please enter an emergency contact phone number");
            }
            else
            {
                errorProvider1.Clear();

            }
            filledEnableAdding();
            filledEnableEditing();
        }

        private void pctrHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = String.Format("Fields:\nID: A unique number referring to a specific member.\nName: The name of the member.\nEmail: The email address of the member.\nEmergency phone contact:The number to contact in case of an emergency concerning a gym member.\n\nButton Descriptions :\n\n-Add Member : creates and adds a new Member to the database.\nTo Enable the button All Fields must be filled out.\n\n-Delete Member: deletes a member based on his specific Id.\nThe ID field must be filled out to enable the button.\n\n-Edit Member details: edits the details of a specific member based on Id.\nThe Id field and at least one other field must be filled out to enable the button.\nThe fields that aren't entered will not be changed in the database.\n\n-Get Members by name: retrieves all members with a name containing the value entered into the Name field.\nThe name field must be filled out for this button to be enabled.\n\n-Get Member: retrieves the information of a specific member based on Id.\nThe Id field must be filled out to enable the button.");
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnMembByName_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Members where MembName like @name ", con);
                cmd.Parameters.AddWithValue("@name", "%" +  txtMembName.Text + "%" );
               
                SqlDataAdapter dp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dataGridView1.RowCount < 2) MessageBox.Show("There were no members with a similar name");
                
                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
        }

       
    }
}
