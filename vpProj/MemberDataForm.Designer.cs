namespace vpProj
{
    partial class MemberDataForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMembName = new System.Windows.Forms.TextBox();
            this.txtMembEmail = new System.Windows.Forms.TextBox();
            this.txtMembId = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnDelMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnGetMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pctrHelp = new System.Windows.Forms.PictureBox();
            this.btnMembByName = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(471, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 38);
            this.label4.TabIndex = 31;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(471, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 30;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(471, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMembName
            // 
            this.txtMembName.Location = new System.Drawing.Point(650, 208);
            this.txtMembName.Name = "txtMembName";
            this.txtMembName.Size = new System.Drawing.Size(149, 26);
            this.txtMembName.TabIndex = 1;
            this.txtMembName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembName_KeyPress);
            this.txtMembName.Leave += new System.EventHandler(this.txtMembName_Leave);
            // 
            // txtMembEmail
            // 
            this.txtMembEmail.Location = new System.Drawing.Point(650, 280);
            this.txtMembEmail.Name = "txtMembEmail";
            this.txtMembEmail.Size = new System.Drawing.Size(149, 26);
            this.txtMembEmail.TabIndex = 2;
            this.txtMembEmail.Leave += new System.EventHandler(this.txtMembEmail_Leave);
            // 
            // txtMembId
            // 
            this.txtMembId.Location = new System.Drawing.Point(650, 136);
            this.txtMembId.Name = "txtMembId";
            this.txtMembId.Size = new System.Drawing.Size(149, 26);
            this.txtMembId.TabIndex = 0;

            this.txtMembId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembId_KeyPress);
            this.txtMembId.Leave += new System.EventHandler(this.txtMembId_Leave);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddMember.Enabled = false;
            this.btnAddMember.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddMember.Location = new System.Drawing.Point(98, 120);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(350, 38);
            this.btnAddMember.TabIndex = 24;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDelMember
            // 
            this.btnDelMember.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDelMember.Enabled = false;
            this.btnDelMember.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMember.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDelMember.Location = new System.Drawing.Point(98, 175);
            this.btnDelMember.Name = "btnDelMember";
            this.btnDelMember.Size = new System.Drawing.Size(350, 38);
            this.btnDelMember.TabIndex = 23;
            this.btnDelMember.Text = "Delete Member";
            this.btnDelMember.UseVisualStyleBackColor = false;
            this.btnDelMember.Click += new System.EventHandler(this.btnDelMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEditMember.Enabled = false;
            this.btnEditMember.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEditMember.Location = new System.Drawing.Point(98, 230);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(350, 38);
            this.btnEditMember.TabIndex = 22;
            this.btnEditMember.Text = "Edit Member";
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnGetMember
            // 
            this.btnGetMember.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGetMember.Enabled = false;
            this.btnGetMember.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMember.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGetMember.Location = new System.Drawing.Point(98, 340);
            this.btnGetMember.Name = "btnGetMember";
            this.btnGetMember.Size = new System.Drawing.Size(283, 38);
            this.btnGetMember.TabIndex = 21;
            this.btnGetMember.Text = "Get Member Details";
            this.btnGetMember.UseVisualStyleBackColor = false;
            this.btnGetMember.Click += new System.EventHandler(this.btnGetMember_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "Edit Member Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::vpProj.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(651, 352);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.labelPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelPhone.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Linen;
            this.labelPhone.Location = new System.Drawing.Point(385, 340);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(239, 38);
            this.labelPhone.TabIndex = 32;
            this.labelPhone.Text = "Emergency contact number";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pctrHelp
            // 
            this.pctrHelp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pctrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrHelp.Image = global::vpProj.Properties.Resources.helpIcon;
            this.pctrHelp.Location = new System.Drawing.Point(812, 28);
            this.pctrHelp.Name = "pctrHelp";
            this.pctrHelp.Size = new System.Drawing.Size(52, 44);
            this.pctrHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHelp.TabIndex = 47;
            this.pctrHelp.TabStop = false;
            this.pctrHelp.Click += new System.EventHandler(this.pctrHelp_Click);
            // 
            // btnMembByName
            // 
            this.btnMembByName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMembByName.Enabled = false;
            this.btnMembByName.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembByName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMembByName.Location = new System.Drawing.Point(98, 285);
            this.btnMembByName.Name = "btnMembByName";
            this.btnMembByName.Size = new System.Drawing.Size(350, 38);
            this.btnMembByName.TabIndex = 48;
            this.btnMembByName.Text = "Get Members by name";
            this.btnMembByName.UseVisualStyleBackColor = false;
            this.btnMembByName.Click += new System.EventHandler(this.btnMembByName_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(700, 151);
            this.dataGridView1.TabIndex = 49;
            // 
            // MemberDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMembByName);
            this.Controls.Add(this.pctrHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMembName);
            this.Controls.Add(this.txtMembEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMembId);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnDelMember);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.btnGetMember);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MemberDataForm";
            this.Text = "MemberDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMembName;
        private System.Windows.Forms.TextBox txtMembEmail;
        private System.Windows.Forms.TextBox txtMembId;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnDelMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnGetMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pctrHelp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMembByName;
    }
}