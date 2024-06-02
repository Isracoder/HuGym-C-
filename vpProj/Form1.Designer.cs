namespace vpProj
{
    partial class mainForm
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
            this.btnEmpData = new System.Windows.Forms.Button();
            this.btnNewMembership = new System.Windows.Forms.Button();
            this.btnManageMemberships = new System.Windows.Forms.Button();
            this.btnDataReports = new System.Windows.Forms.Button();
            this.btnMemData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpData
            // 
            this.btnEmpData.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEmpData.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEmpData.Location = new System.Drawing.Point(18, 165);
            this.btnEmpData.Name = "btnEmpData";
            this.btnEmpData.Size = new System.Drawing.Size(350, 38);
            this.btnEmpData.TabIndex = 0;
            this.btnEmpData.Text = "Manage Employee Data";
            this.btnEmpData.UseVisualStyleBackColor = false;
            this.btnEmpData.Click += new System.EventHandler(this.btnEmpData_Click);
            // 
            // btnNewMembership
            // 
            this.btnNewMembership.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNewMembership.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMembership.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNewMembership.Location = new System.Drawing.Point(18, 236);
            this.btnNewMembership.Name = "btnNewMembership";
            this.btnNewMembership.Size = new System.Drawing.Size(718, 38);
            this.btnNewMembership.TabIndex = 1;
            this.btnNewMembership.Text = "Create a new Membership";
            this.btnNewMembership.UseVisualStyleBackColor = false;
            this.btnNewMembership.Click += new System.EventHandler(this.btnNewMembership_Click);
            // 
            // btnManageMemberships
            // 
            this.btnManageMemberships.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnManageMemberships.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMemberships.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnManageMemberships.Location = new System.Drawing.Point(18, 298);
            this.btnManageMemberships.Name = "btnManageMemberships";
            this.btnManageMemberships.Size = new System.Drawing.Size(350, 38);
            this.btnManageMemberships.TabIndex = 2;
            this.btnManageMemberships.Text = "Manage Membership Data";
            this.btnManageMemberships.UseVisualStyleBackColor = false;
            this.btnManageMemberships.Click += new System.EventHandler(this.btnPaymentsRefunds_Click);
            // 
            // btnDataReports
            // 
            this.btnDataReports.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDataReports.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataReports.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDataReports.Location = new System.Drawing.Point(386, 298);
            this.btnDataReports.Name = "btnDataReports";
            this.btnDataReports.Size = new System.Drawing.Size(350, 38);
            this.btnDataReports.TabIndex = 3;
            this.btnDataReports.Text = "Data reports";
            this.btnDataReports.UseVisualStyleBackColor = false;
            this.btnDataReports.Click += new System.EventHandler(this.btnDataReports_Click);
            // 
            // btnMemData
            // 
            this.btnMemData.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMemData.Font = new System.Drawing.Font("Simplified Arabic Fixed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMemData.Location = new System.Drawing.Point(386, 165);
            this.btnMemData.Name = "btnMemData";
            this.btnMemData.Size = new System.Drawing.Size(350, 38);
            this.btnMemData.TabIndex = 4;
            this.btnMemData.Text = "Manage Member Data";
            this.btnMemData.UseVisualStyleBackColor = false;
            this.btnMemData.Click += new System.EventHandler(this.btnMemData_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yellowtail", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the Hebron University Gym !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(759, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMemData);
            this.Controls.Add(this.btnDataReports);
            this.Controls.Add(this.btnManageMemberships);
            this.Controls.Add(this.btnNewMembership);
            this.Controls.Add(this.btnEmpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "HU Gym";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpData;
        private System.Windows.Forms.Button btnNewMembership;
        private System.Windows.Forms.Button btnManageMemberships;
        private System.Windows.Forms.Button btnDataReports;
        private System.Windows.Forms.Button btnMemData;
        private System.Windows.Forms.Label label1;
    }
}

