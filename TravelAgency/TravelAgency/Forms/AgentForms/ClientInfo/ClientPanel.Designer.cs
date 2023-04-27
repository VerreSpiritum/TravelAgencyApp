namespace TravelAgency
{
    partial class ClientPanel
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
            this.addClientL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allClientsL = new System.Windows.Forms.Label();
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
            // addClientL
            // 
            this.addClientL.AutoSize = true;
            this.addClientL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientL.Location = new System.Drawing.Point(185, 42);
            this.addClientL.Name = "addClientL";
            this.addClientL.Size = new System.Drawing.Size(191, 36);
            this.addClientL.TabIndex = 1;
            this.addClientL.Text = "Додати клієнта";
            this.addClientL.Click += new System.EventHandler(this.addClientL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allClientsL
            // 
            this.allClientsL.AutoSize = true;
            this.allClientsL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allClientsL.Location = new System.Drawing.Point(12, 42);
            this.allClientsL.Name = "allClientsL";
            this.allClientsL.Size = new System.Drawing.Size(105, 36);
            this.allClientsL.TabIndex = 6;
            this.allClientsL.Text = "Клієнти";
            this.allClientsL.Click += new System.EventHandler(this.allSalariesL_Click);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 1080);
            this.Controls.Add(this.allClientsL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.addClientL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientPanel";
            this.Text = "BookerPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addClientL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allClientsL;
    }
}