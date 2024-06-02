namespace vpProj
{
    partial class PaymentsRefundsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMembId = new System.Windows.Forms.TextBox();
            this.txtMembershipId = new System.Windows.Forms.TextBox();
            this.btnGetMembership = new System.Windows.Forms.Button();
            this.btnGetMembershipsOfMember = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(100, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 45;
            this.label3.Text = "Member ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(458, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Membership ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMembId
            // 
            this.txtMembId.Location = new System.Drawing.Point(279, 322);
            this.txtMembId.Name = "txtMembId";
            this.txtMembId.Size = new System.Drawing.Size(149, 26);
            this.txtMembId.TabIndex = 1;
            this.txtMembId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembId_KeyPress);
            this.txtMembId.Leave += new System.EventHandler(this.txtMembId_Leave);
            // 
            // txtMembershipId
            // 
            this.txtMembershipId.Location = new System.Drawing.Point(637, 322);
            this.txtMembershipId.Name = "txtMembershipId";
            this.txtMembershipId.Size = new System.Drawing.Size(149, 26);
            this.txtMembershipId.TabIndex = 0;
            this.txtMembershipId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembershipId_KeyPress);
            this.txtMembershipId.Leave += new System.EventHandler(this.txtMembershipId_Leave);
            // 
            // btnGetMembership
            // 
            this.btnGetMembership.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGetMembership.Enabled = false;
            this.btnGetMembership.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMembership.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGetMembership.Location = new System.Drawing.Point(97, 109);
            this.btnGetMembership.Name = "btnGetMembership";
            this.btnGetMembership.Size = new System.Drawing.Size(686, 40);
            this.btnGetMembership.TabIndex = 5;
            this.btnGetMembership.Text = "Get membership by ID";
            this.btnGetMembership.UseVisualStyleBackColor = false;
            this.btnGetMembership.Click += new System.EventHandler(this.btnGetMembership_Click);
            // 
            // btnGetMembershipsOfMember
            // 
            this.btnGetMembershipsOfMember.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGetMembershipsOfMember.Enabled = false;
            this.btnGetMembershipsOfMember.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetMembershipsOfMember.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGetMembershipsOfMember.Location = new System.Drawing.Point(97, 173);
            this.btnGetMembershipsOfMember.Name = "btnGetMembershipsOfMember";
            this.btnGetMembershipsOfMember.Size = new System.Drawing.Size(686, 40);
            this.btnGetMembershipsOfMember.TabIndex = 6;
            this.btnGetMembershipsOfMember.Text = "Get all memberships of member";
            this.btnGetMembershipsOfMember.UseVisualStyleBackColor = false;
            this.btnGetMembershipsOfMember.Click += new System.EventHandler(this.btnGetMembershipsOfMember_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnPay.Enabled = false;
            this.btnPay.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPay.Location = new System.Drawing.Point(453, 237);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(330, 40);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay For Membership";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRefund.Enabled = false;
            this.btnRefund.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRefund.Location = new System.Drawing.Point(97, 237);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(330, 40);
            this.btnRefund.TabIndex = 8;
            this.btnRefund.Text = "Cancel and Refund ";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Payments and Refunds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::vpProj.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(22, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(686, 162);
            this.dataGridView1.TabIndex = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::vpProj.Properties.Resources.helpIcon;
            this.pictureBox2.Location = new System.Drawing.Point(804, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PaymentsRefundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMembId);
            this.Controls.Add(this.txtMembershipId);
            this.Controls.Add(this.btnGetMembership);
            this.Controls.Add(this.btnGetMembershipsOfMember);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PaymentsRefundsForm";
            this.Text = "PaymentsRefundsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMembId;
        private System.Windows.Forms.TextBox txtMembershipId;
        private System.Windows.Forms.Button btnGetMembership;
        private System.Windows.Forms.Button btnGetMembershipsOfMember;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}