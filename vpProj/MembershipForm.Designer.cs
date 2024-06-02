namespace vpProj
{
    partial class MembershipForm
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
            this.txtMmbrId = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtMbshpId = new System.Windows.Forms.TextBox();
            this.btnAddMembshp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chckGym = new System.Windows.Forms.CheckBox();
            this.grpMmbshpDetails = new System.Windows.Forms.GroupBox();
            this.chckPool = new System.Windows.Forms.CheckBox();
            this.chkSauna = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chckSteam = new System.Windows.Forms.CheckBox();
            this.chckMassages = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pckrStartDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrHelp = new System.Windows.Forms.PictureBox();
            this.grpMmbshpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(464, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Payment made";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(464, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Member ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(464, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Membership ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMmbrId
            // 
            this.txtMmbrId.Location = new System.Drawing.Point(643, 203);
            this.txtMmbrId.Name = "txtMmbrId";
            this.txtMmbrId.Size = new System.Drawing.Size(149, 26);
            this.txtMmbrId.TabIndex = 1;
            this.txtMmbrId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMmbrId_KeyPress);
            this.txtMmbrId.Leave += new System.EventHandler(this.txtMmbrId_Leave);
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(643, 275);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(149, 26);
            this.txtPaid.TabIndex = 2;
            this.txtPaid.Leave += new System.EventHandler(this.txtPaid_Leave);
            // 
            // txtMbshpId
            // 
            this.txtMbshpId.Location = new System.Drawing.Point(643, 131);
            this.txtMbshpId.Name = "txtMbshpId";
            this.txtMbshpId.Size = new System.Drawing.Size(149, 26);
            this.txtMbshpId.TabIndex = 0;
            this.txtMbshpId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMbshpId_KeyPress);
            this.txtMbshpId.Leave += new System.EventHandler(this.txtMbshpId_Leave);
            // 
            // btnAddMembshp
            // 
            this.btnAddMembshp.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddMembshp.Enabled = false;
            this.btnAddMembshp.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembshp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddMembshp.Location = new System.Drawing.Point(96, 119);
            this.btnAddMembshp.Name = "btnAddMembshp";
            this.btnAddMembshp.Size = new System.Drawing.Size(350, 38);
            this.btnAddMembshp.TabIndex = 5;
            this.btnAddMembshp.Text = "Add Membership";
            this.btnAddMembshp.UseVisualStyleBackColor = false;
            this.btnAddMembshp.Click += new System.EventHandler(this.btnAddMembshp_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(88, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 22;
            this.label1.Text = "Membership Mangement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chckGym
            // 
            this.chckGym.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chckGym.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.chckGym.ForeColor = System.Drawing.Color.Linen;
            this.chckGym.Location = new System.Drawing.Point(18, 38);
            this.chckGym.Name = "chckGym";
            this.chckGym.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chckGym.Size = new System.Drawing.Size(199, 38);
            this.chckGym.TabIndex = 0;
            this.chckGym.Text = "Gym ($500)";
            this.chckGym.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckGym.UseVisualStyleBackColor = false;
            this.chckGym.CheckedChanged += new System.EventHandler(this.chckGym_CheckedChanged);
            // 
            // grpMmbshpDetails
            // 
            this.grpMmbshpDetails.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.grpMmbshpDetails.Controls.Add(this.chckPool);
            this.grpMmbshpDetails.Controls.Add(this.chkSauna);
            this.grpMmbshpDetails.Controls.Add(this.checkBox2);
            this.grpMmbshpDetails.Controls.Add(this.chckSteam);
            this.grpMmbshpDetails.Controls.Add(this.chckMassages);
            this.grpMmbshpDetails.Controls.Add(this.chckGym);
            this.grpMmbshpDetails.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.grpMmbshpDetails.ForeColor = System.Drawing.Color.Linen;
            this.grpMmbshpDetails.Location = new System.Drawing.Point(96, 326);
            this.grpMmbshpDetails.Name = "grpMmbshpDetails";
            this.grpMmbshpDetails.Size = new System.Drawing.Size(696, 127);
            this.grpMmbshpDetails.TabIndex = 3;
            this.grpMmbshpDetails.TabStop = false;
            this.grpMmbshpDetails.Text = "Membership Details";
            this.grpMmbshpDetails.Leave += new System.EventHandler(this.grpMmbshpDetails_Leave);
            // 
            // chckPool
            // 
            this.chckPool.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chckPool.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.chckPool.ForeColor = System.Drawing.Color.Linen;
            this.chckPool.Location = new System.Drawing.Point(18, 74);
            this.chckPool.Name = "chckPool";
            this.chckPool.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chckPool.Size = new System.Drawing.Size(199, 38);
            this.chckPool.TabIndex = 3;
            this.chckPool.Text = "Pool Access ($500)";
            this.chckPool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckPool.UseVisualStyleBackColor = false;
            this.chckPool.CheckedChanged += new System.EventHandler(this.chckPool_CheckedChanged);
            // 
            // chkSauna
            // 
            this.chkSauna.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chkSauna.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.chkSauna.ForeColor = System.Drawing.Color.Linen;
            this.chkSauna.Location = new System.Drawing.Point(221, 38);
            this.chkSauna.Name = "chkSauna";
            this.chkSauna.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chkSauna.Size = new System.Drawing.Size(199, 38);
            this.chkSauna.TabIndex = 1;
            this.chkSauna.Text = "Sauna ($300)";
            this.chkSauna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSauna.UseVisualStyleBackColor = false;
            this.chkSauna.CheckedChanged += new System.EventHandler(this.chkSauna_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.checkBox2.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.checkBox2.ForeColor = System.Drawing.Color.Linen;
            this.checkBox2.Location = new System.Drawing.Point(219, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(199, 38);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "Sauna ($300)";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // chckSteam
            // 
            this.chckSteam.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chckSteam.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.chckSteam.ForeColor = System.Drawing.Color.Linen;
            this.chckSteam.Location = new System.Drawing.Point(221, 74);
            this.chckSteam.Name = "chckSteam";
            this.chckSteam.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chckSteam.Size = new System.Drawing.Size(199, 38);
            this.chckSteam.TabIndex = 4;
            this.chckSteam.Text = "Steam Room ($300)";
            this.chckSteam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckSteam.UseVisualStyleBackColor = false;
            this.chckSteam.CheckedChanged += new System.EventHandler(this.chckSteam_CheckedChanged);
            // 
            // chckMassages
            // 
            this.chckMassages.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chckMassages.Font = new System.Drawing.Font("Urdu Typesetting", 9F);
            this.chckMassages.ForeColor = System.Drawing.Color.Linen;
            this.chckMassages.Location = new System.Drawing.Point(439, 41);
            this.chckMassages.Name = "chckMassages";
            this.chckMassages.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chckMassages.Size = new System.Drawing.Size(199, 38);
            this.chckMassages.TabIndex = 2;
            this.chckMassages.Text = "Massages ($500)";
            this.chckMassages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckMassages.UseVisualStyleBackColor = false;
            this.chckMassages.CheckedChanged += new System.EventHandler(this.chckMassages_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Linen;
            this.label5.Location = new System.Drawing.Point(99, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 38);
            this.label5.TabIndex = 44;
            this.label5.Text = "Total price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(278, 275);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(149, 26);
            this.txtTotalPrice.TabIndex = 43;
            this.txtTotalPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Linen;
            this.label6.Location = new System.Drawing.Point(99, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 38);
            this.label6.TabIndex = 45;
            this.label6.Text = "Start Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pckrStartDate
            // 
            this.pckrStartDate.CustomFormat = "yyyy-MM-dd";
            this.pckrStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckrStartDate.Location = new System.Drawing.Point(278, 198);
            this.pckrStartDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.pckrStartDate.MinDate = new System.DateTime(1971, 1, 1, 0, 0, 0, 0);
            this.pckrStartDate.Name = "pckrStartDate";
            this.pckrStartDate.Size = new System.Drawing.Size(149, 26);
            this.pckrStartDate.TabIndex = 4;
            this.pckrStartDate.Value = new System.DateTime(2024, 5, 25, 23, 59, 59, 0);
            this.pckrStartDate.ValueChanged += new System.EventHandler(this.pckrStartDate_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::vpProj.Properties.Resources.back2;
            this.pictureBox1.Location = new System.Drawing.Point(30, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctrHelp
            // 
            this.pctrHelp.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pctrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrHelp.Image = global::vpProj.Properties.Resources.helpIcon;
            this.pctrHelp.Location = new System.Drawing.Point(812, 24);
            this.pctrHelp.Name = "pctrHelp";
            this.pctrHelp.Size = new System.Drawing.Size(52, 44);
            this.pctrHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHelp.TabIndex = 46;
            this.pctrHelp.TabStop = false;
            this.pctrHelp.Click += new System.EventHandler(this.pctrHelp_Click);
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(899, 514);
            this.Controls.Add(this.pctrHelp);
            this.Controls.Add(this.pckrStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.grpMmbshpDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMmbrId);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtMbshpId);
            this.Controls.Add(this.btnAddMembshp);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MembershipForm";
            this.Text = "MembershipForm";
            this.grpMmbshpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMmbrId;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtMbshpId;
        private System.Windows.Forms.Button btnAddMembshp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chckGym;
        private System.Windows.Forms.GroupBox grpMmbshpDetails;
        private System.Windows.Forms.CheckBox chckPool;
        private System.Windows.Forms.CheckBox chkSauna;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chckSteam;
        private System.Windows.Forms.CheckBox chckMassages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pckrStartDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pctrHelp;
    }
}