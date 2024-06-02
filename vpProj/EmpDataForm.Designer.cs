namespace vpProj
{
    partial class EmpDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrHelp = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmpsByName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Employee Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetEmp
            // 
            this.btnGetEmp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGetEmp.Enabled = false;
            this.btnGetEmp.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEmp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGetEmp.Location = new System.Drawing.Point(95, 340);
            this.btnGetEmp.Name = "btnGetEmp";
            this.btnGetEmp.Size = new System.Drawing.Size(350, 38);
            this.btnGetEmp.TabIndex = 7;
            this.btnGetEmp.Text = "Get Employee Details";
            this.btnGetEmp.UseVisualStyleBackColor = false;
            this.btnGetEmp.Click += new System.EventHandler(this.btnGetEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEditEmp.Enabled = false;
            this.btnEditEmp.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEditEmp.Location = new System.Drawing.Point(95, 230);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(350, 38);
            this.btnEditEmp.TabIndex = 8;
            this.btnEditEmp.Text = "Edit Employee";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDelEmp.Enabled = false;
            this.btnDelEmp.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEmp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelEmp.Location = new System.Drawing.Point(95, 175);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(350, 38);
            this.btnDelEmp.TabIndex = 9;
            this.btnDelEmp.Text = "Delete Employee";
            this.btnDelEmp.UseVisualStyleBackColor = false;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddEmp.Enabled = false;
            this.btnAddEmp.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddEmp.Location = new System.Drawing.Point(95, 120);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(350, 38);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(649, 136);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(149, 26);
            this.txtEmpId.TabIndex = 0;
            this.txtEmpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpId_KeyPress);
            this.txtEmpId.Leave += new System.EventHandler(this.txtEmpId_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(650, 352);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(649, 280);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(149, 26);
            this.txtEmpEmail.TabIndex = 2;
            this.txtEmpEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpEmail_KeyPress);
            this.txtEmpEmail.Leave += new System.EventHandler(this.txtEmpEmail_Leave);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(649, 208);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(149, 26);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpName_KeyPress);
            this.txtEmpName.Leave += new System.EventHandler(this.txtEmpName_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(470, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(470, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(470, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 38);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(470, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "Phone ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::vpProj.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctrHelp
            // 
            this.pctrHelp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pctrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrHelp.Image = global::vpProj.Properties.Resources.helpIcon;
            this.pctrHelp.Location = new System.Drawing.Point(811, 28);
            this.pctrHelp.Name = "pctrHelp";
            this.pctrHelp.Size = new System.Drawing.Size(52, 44);
            this.pctrHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHelp.TabIndex = 47;
            this.pctrHelp.TabStop = false;
            this.pctrHelp.Click += new System.EventHandler(this.pctrHelp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(700, 151);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnEmpsByName
            // 
            this.btnEmpsByName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEmpsByName.Enabled = false;
            this.btnEmpsByName.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpsByName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEmpsByName.Location = new System.Drawing.Point(95, 285);
            this.btnEmpsByName.Name = "btnEmpsByName";
            this.btnEmpsByName.Size = new System.Drawing.Size(350, 38);
            this.btnEmpsByName.TabIndex = 51;
            this.btnEmpsByName.Text = "Get Employees by name";
            this.btnEmpsByName.UseVisualStyleBackColor = false;
            this.btnEmpsByName.Click += new System.EventHandler(this.btnEmpsByName_Click);
            // 
            // EmpDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.btnEmpsByName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pctrHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.btnGetEmp);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmpDataForm";
            this.Text = "EmpDataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpDataForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnDelEmp;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pctrHelp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmpsByName;
    }
}