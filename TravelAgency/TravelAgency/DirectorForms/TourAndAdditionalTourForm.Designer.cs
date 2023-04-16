namespace TravelAgency
{
    partial class TourAndAdditionalTourForm
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
            this.newTourL = new System.Windows.Forms.Label();
            this.editTourL = new System.Windows.Forms.Label();
            this.allAddTourL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allTourL = new System.Windows.Forms.Label();
            this.editAddTourL = new System.Windows.Forms.Label();
            this.createAddTourL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1867, 2);
            this.label1.TabIndex = 0;
            // 
            // newTourL
            // 
            this.newTourL.AutoSize = true;
            this.newTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTourL.Location = new System.Drawing.Point(161, 42);
            this.newTourL.Name = "newTourL";
            this.newTourL.Size = new System.Drawing.Size(170, 36);
            this.newTourL.TabIndex = 1;
            this.newTourL.Text = "Створити тур";
            this.newTourL.Click += new System.EventHandler(this.newEmployeeL_Click);
            // 
            // editTourL
            // 
            this.editTourL.AutoSize = true;
            this.editTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTourL.Location = new System.Drawing.Point(391, 42);
            this.editTourL.Name = "editTourL";
            this.editTourL.Size = new System.Drawing.Size(154, 36);
            this.editTourL.TabIndex = 2;
            this.editTourL.Text = "Змінити тур";
            this.editTourL.Click += new System.EventHandler(this.editEmployeeL_Click);
            // 
            // allAddTourL
            // 
            this.allAddTourL.AutoSize = true;
            this.allAddTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allAddTourL.Location = new System.Drawing.Point(614, 42);
            this.allAddTourL.Name = "allAddTourL";
            this.allAddTourL.Size = new System.Drawing.Size(229, 36);
            this.allAddTourL.TabIndex = 3;
            this.allAddTourL.Text = "Усі додаткові тури";
            this.allAddTourL.Click += new System.EventHandler(this.showEmployeeL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1867, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allTourL
            // 
            this.allTourL.AutoSize = true;
            this.allTourL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTourL.Location = new System.Drawing.Point(12, 42);
            this.allTourL.Name = "allTourL";
            this.allTourL.Size = new System.Drawing.Size(108, 36);
            this.allTourL.TabIndex = 6;
            this.allTourL.Text = "Усі тури";
            this.allTourL.Click += new System.EventHandler(this.allStaffL_Click);
            // 
            // editAddTourL
            // 
            this.editAddTourL.AutoSize = true;
            this.editAddTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editAddTourL.Location = new System.Drawing.Point(1284, 42);
            this.editAddTourL.Name = "editAddTourL";
            this.editAddTourL.Size = new System.Drawing.Size(300, 36);
            this.editAddTourL.TabIndex = 7;
            this.editAddTourL.Text = "Змінити додатковий тур";
            this.editAddTourL.Click += new System.EventHandler(this.editAddTourL_Click);
            // 
            // createAddTourL
            // 
            this.createAddTourL.AutoSize = true;
            this.createAddTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAddTourL.Location = new System.Drawing.Point(894, 42);
            this.createAddTourL.Name = "createAddTourL";
            this.createAddTourL.Size = new System.Drawing.Size(316, 36);
            this.createAddTourL.TabIndex = 8;
            this.createAddTourL.Text = "Створити додатковий тур";
            this.createAddTourL.Click += new System.EventHandler(this.createAddTourL_Click);
            // 
            // TourAndAdditionalTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1862, 1080);
            this.Controls.Add(this.createAddTourL);
            this.Controls.Add(this.allTourL);
            this.Controls.Add(this.editAddTourL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.allAddTourL);
            this.Controls.Add(this.editTourL);
            this.Controls.Add(this.newTourL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TourAndAdditionalTourForm";
            this.Text = "HumanResoucesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newTourL;
        private System.Windows.Forms.Label editTourL;
        private System.Windows.Forms.Label allAddTourL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allTourL;
        private System.Windows.Forms.Label editAddTourL;
        private System.Windows.Forms.Label createAddTourL;
    }
}