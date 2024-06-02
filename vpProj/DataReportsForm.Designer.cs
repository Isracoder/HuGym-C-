namespace vpProj
{
    partial class DataReportsForm
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
            this.btnAllValid = new System.Windows.Forms.Button();
            this.btnUnpaidMemberShips = new System.Windows.Forms.Button();
            this.btnCntSumInYear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Display Data Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAllValid
            // 
            this.btnAllValid.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAllValid.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllValid.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAllValid.Location = new System.Drawing.Point(151, 131);
            this.btnAllValid.Name = "btnAllValid";
            this.btnAllValid.Size = new System.Drawing.Size(592, 63);
            this.btnAllValid.TabIndex = 14;
            this.btnAllValid.Text = "All Valid Memberships";
            this.btnAllValid.UseVisualStyleBackColor = false;
            this.btnAllValid.Click += new System.EventHandler(this.btnAllValid_Click);
            // 
            // btnUnpaidMemberShips
            // 
            this.btnUnpaidMemberShips.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUnpaidMemberShips.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpaidMemberShips.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUnpaidMemberShips.Location = new System.Drawing.Point(151, 233);
            this.btnUnpaidMemberShips.Name = "btnUnpaidMemberShips";
            this.btnUnpaidMemberShips.Size = new System.Drawing.Size(592, 63);
            this.btnUnpaidMemberShips.TabIndex = 13;
            this.btnUnpaidMemberShips.Text = "All Unpaid Memberships";
            this.btnUnpaidMemberShips.UseVisualStyleBackColor = false;
            this.btnUnpaidMemberShips.Click += new System.EventHandler(this.btnUnpaidMemberShips_Click);
            // 
            // btnCntSumInYear
            // 
            this.btnCntSumInYear.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCntSumInYear.Enabled = false;
            this.btnCntSumInYear.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCntSumInYear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCntSumInYear.Location = new System.Drawing.Point(151, 335);
            this.btnCntSumInYear.Name = "btnCntSumInYear";
            this.btnCntSumInYear.Size = new System.Drawing.Size(592, 63);
            this.btnCntSumInYear.TabIndex = 12;
            this.btnCntSumInYear.Text = "Count of Memberships in a specific year and total costs";
            this.btnCntSumInYear.UseVisualStyleBackColor = false;
            this.btnCntSumInYear.Click += new System.EventHandler(this.btnCntSumInYear_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(283, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(462, 456);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(149, 26);
            this.txtYear.TabIndex = 16;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::vpProj.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(30, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::vpProj.Properties.Resources.helpIcon;
            this.pictureBox2.Location = new System.Drawing.Point(812, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DataReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnAllValid);
            this.Controls.Add(this.btnUnpaidMemberShips);
            this.Controls.Add(this.btnCntSumInYear);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DataReportsForm";
            this.Text = "DataReports";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllValid;
        private System.Windows.Forms.Button btnUnpaidMemberShips;
        private System.Windows.Forms.Button btnCntSumInYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}