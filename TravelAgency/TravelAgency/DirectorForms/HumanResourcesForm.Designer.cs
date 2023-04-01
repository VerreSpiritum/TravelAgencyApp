namespace TravelAgency
{
    partial class HumanResourcesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.newEmployeeL = new System.Windows.Forms.Label();
            this.editEmployeeL = new System.Windows.Forms.Label();
            this.showEmployeeL = new System.Windows.Forms.Label();
            this.newUserL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allStaffL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1718, 2);
            this.label1.TabIndex = 0;
            // 
            // newEmployeeL
            // 
            this.newEmployeeL.AutoSize = true;
            this.newEmployeeL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newEmployeeL.Location = new System.Drawing.Point(244, 42);
            this.newEmployeeL.Name = "newEmployeeL";
            this.newEmployeeL.Size = new System.Drawing.Size(253, 36);
            this.newEmployeeL.TabIndex = 1;
            this.newEmployeeL.Text = "Новий співробітник";
            this.newEmployeeL.Click += new System.EventHandler(this.newEmployeeL_Click);
            // 
            // editEmployeeL
            // 
            this.editEmployeeL.AutoSize = true;
            this.editEmployeeL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEmployeeL.Location = new System.Drawing.Point(556, 42);
            this.editEmployeeL.Name = "editEmployeeL";
            this.editEmployeeL.Size = new System.Drawing.Size(326, 36);
            this.editEmployeeL.TabIndex = 2;
            this.editEmployeeL.Text = "Редагувати співробітника";
            this.editEmployeeL.Click += new System.EventHandler(this.editEmployeeL_Click);
            // 
            // showEmployeeL
            // 
            this.showEmployeeL.AutoSize = true;
            this.showEmployeeL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showEmployeeL.Location = new System.Drawing.Point(948, 42);
            this.showEmployeeL.Name = "showEmployeeL";
            this.showEmployeeL.Size = new System.Drawing.Size(163, 36);
            this.showEmployeeL.TabIndex = 3;
            this.showEmployeeL.Text = "Користувачі";
            this.showEmployeeL.Click += new System.EventHandler(this.showEmployeeL_Click);
            // 
            // newUserL
            // 
            this.newUserL.AutoSize = true;
            this.newUserL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserL.Location = new System.Drawing.Point(1180, 42);
            this.newUserL.Name = "newUserL";
            this.newUserL.Size = new System.Drawing.Size(216, 36);
            this.newUserL.TabIndex = 4;
            this.newUserL.Text = "Обліковий запис\r\n";
            this.newUserL.Click += new System.EventHandler(this.newUserL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allStaffL
            // 
            this.allStaffL.AutoSize = true;
            this.allStaffL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allStaffL.Location = new System.Drawing.Point(12, 42);
            this.allStaffL.Name = "allStaffL";
            this.allStaffL.Size = new System.Drawing.Size(189, 36);
            this.allStaffL.TabIndex = 6;
            this.allStaffL.Text = "Співробітники";
            this.allStaffL.Click += new System.EventHandler(this.allStaffL_Click);
            // 
            // HumanResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 1080);
            this.Controls.Add(this.allStaffL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.newUserL);
            this.Controls.Add(this.showEmployeeL);
            this.Controls.Add(this.editEmployeeL);
            this.Controls.Add(this.newEmployeeL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HumanResourcesForm";
            this.Text = "HumanResoucesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newEmployeeL;
        private System.Windows.Forms.Label editEmployeeL;
        private System.Windows.Forms.Label showEmployeeL;
        private System.Windows.Forms.Label newUserL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allStaffL;
    }
}