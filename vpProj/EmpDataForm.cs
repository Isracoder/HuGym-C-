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
    public partial class EmpDataForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=vpProj;Integrated Security=True");
        public EmpDataForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            f1.Show();
            this.Hide();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees where EmpID=@id", con);
                cmd.Parameters.AddWithValue("@id",int.Parse(txtEmpId.Text));
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    dr.Close();
                    cmd = new SqlCommand("select max(EmpID) from Employees", con);
                    int mx =  Convert.ToInt16(cmd.ExecuteScalar());
                    MessageBox.Show(String.Format("That ID is already taken , please try {0}" , mx+1), "Error", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    

                }
                else
                {
                    dr.Close();
                    SqlCommand insertCmd = new SqlCommand("Insert into Employees values(@ID, @Name, @Email , @Phone)", con);
                    insertCmd.Parameters.AddWithValue("@ID", int.Parse(txtEmpId.Text));
                    insertCmd.Parameters.AddWithValue("@Name", txtEmpName.Text);
                    insertCmd.Parameters.AddWithValue("@Email", txtEmpEmail.Text);
                    insertCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    int a = insertCmd.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Employee Added Successfully!", "Success");
                    else MessageBox.Show("Something went wrong!", "Error");

                }
                
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}\n{1}\n{2}\n{3}", err.ToString() , err.Message , err.GetBaseException() , err.Source);
                MessageBox.Show(error, "Error");
            }
            con.Close();

        }

        private void btnGetEmp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select EmpName, EmpEmail , EmpPhone from Employees where EmpID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    txtEmpName.Text = dr[0].ToString();
                    txtEmpEmail.Text = dr[1].ToString();
                    txtPhone.Text = dr[2].ToString();

                }
                else
                {
                    MessageBox.Show("The employee with that id wasn't found");
                }

                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString() );
                MessageBox.Show(error, "Error");
            }
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            try
            {
                  con.Open();
                  SqlCommand cmd = new SqlCommand("delete from Employees where EmpID=@id", con);
                  cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                  DialogResult R=  MessageBox.Show("Are you sure ?","Warning" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                  if (R ==DialogResult.Yes)
                  {
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                        MessageBox.Show("Deletion complete");
                    else MessageBox.Show("Something went wrong when trying to delete that employee", "Error");
                    
                  }
                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }

        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DialogResult R = MessageBox.Show("Are you sure you want to update ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.No) return;
                SqlCommand cmd = new SqlCommand("select EmpName, EmpEmail , EmpPhone from Employees where EmpID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    dr.Read();
                    dr.Close();
                    cmd = new SqlCommand("update Employees set EmpName=@n,EmpEmail=@E  , EmpPhone=@p where EmpID=@id", con);
                    cmd.Parameters.AddWithValue("@id", txtEmpId.Text);
                    cmd.Parameters.AddWithValue("@n", txtEmpName.Text != "" ? txtEmpName.Text : dr[0].ToString());
                    cmd.Parameters.AddWithValue("@E", txtEmpEmail.Text != "" ?txtEmpEmail.Text: dr[1].ToString());
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text != "" ?txtPhone.Text : dr[2].ToString() );
                    cmd.ExecuteNonQuery();
                     MessageBox.Show("Employee information updated");
                }
                else
                {
                    MessageBox.Show("The employee with that id wasn't found");
                }
                
                con.Close();
            }
            catch (Exception err)
            {

                string error = String.Format("Something went wrong!! \n{0}", err.GetType().ToString());
                MessageBox.Show(error, "Error");
            }
            
        }

        private void EmpDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && !(e.KeyChar == ' '))
            {
                e.Handled = true;
                errorProvider1.SetError(txtEmpName, "Accept only english or arabic letters");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmpName_Leave(object sender, EventArgs e)
        {
            txtEmpName.Text =  txtEmpName.Text.Trim(' ');
            if (txtEmpName.Text == "")
            {
                txtEmpName.Focus();
                errorProvider1.SetError(txtEmpName, "Please enter a name");
                btnEmpsByName.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnEmpsByName.Enabled = true;

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
                errorProvider1.SetError(txtPhone, "Please enter a phone number");
            }
            else
            {
                errorProvider1.Clear();
               
            }
            filledEnableAdding();
            filledEnableEditing();
        }

        void filledEnableAdding()
        {
            if (txtEmpEmail.Text != "" && txtEmpId.Text != "" && txtEmpName.Text != "" && txtPhone.Text != "")
            {
                btnAddEmp.Enabled = true;

            }
            else btnAddEmp.Enabled = false;
        }
        void filledEnableEditing()
        {
            if (txtEmpId.Text != "" && (txtEmpEmail.Text != "" || txtEmpName.Text != "" || txtPhone.Text != ""))
                btnEditEmp.Enabled = true;
            else btnEditEmp.Enabled = false;
        }
       

        private void txtEmpId_Leave(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                txtEmpId.Focus();
                btnDelEmp.Enabled = false;
                btnGetEmp.Enabled = false;
                errorProvider1.SetError(txtEmpId, "Please enter an ID");
            }
            else
            {
                errorProvider1.Clear();
                btnDelEmp.Enabled = true;
                btnGetEmp.Enabled = true;
                
            }
            filledEnableAdding();
            filledEnableEditing();
        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                errorProvider1.SetError(txtEmpId, "Accept only digits");
            }
            else
            {
                errorProvider1.Clear();
                
            }
        }

        private void txtEmpEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmpEmail.Text == "")
            {
                txtEmpEmail.Focus();
                errorProvider1.SetError(txtEmpEmail, "Please enter an email");
            }
            else
            {
                errorProvider1.Clear();
                
            }
            filledEnableAdding();
            filledEnableEditing();
        }

        private void txtEmpEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pctrHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = String.Format("Fields:\nID: A unique number referring to a specific employee.\nName: The name of the employee.\nEmail: The email address of the employee.\nPhone:The employee phone number.\n\nButton Descriptions :\n\n-Add Employee : creates and adds a new employee to the database.\nTo Enable the button All Fields must be filled out.\n\n-Delete Employee: deletes an employee based on his specific Id.\nThe ID field must be filled out to enable the button.\n\n-Edit Employee details: edits the details of a specific employee based on Id.\nThe Id field and at least one other field must be filled out to enable the button.\nThe fields that aren't entered will not be changed in the database.\n\n-Get Employees by name: retrieves all employees with a name containing the value entered into the Name field.\nThe name field must be filled out for this button to be enabled.\n\n-Get Employee: retrieves the information of a specific employee based on Id.\nThe Id field must be filled out to enable the button.");
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnEmpsByName_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees where EmpName like @name ", con);
                cmd.Parameters.AddWithValue("@name", "%" + txtEmpName.Text + "%");

                SqlDataAdapter dp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dataGridView1.RowCount < 2) MessageBox.Show("There were no Employees with a similar name");

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
