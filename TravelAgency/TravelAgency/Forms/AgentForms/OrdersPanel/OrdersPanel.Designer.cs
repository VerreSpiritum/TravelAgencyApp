namespace TravelAgency
{
    partial class OrdersPanel
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
            this.allContractsL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allBookingsL = new System.Windows.Forms.Label();
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
            // allContractsL
            // 
            this.allContractsL.AutoSize = true;
            this.allContractsL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allContractsL.Location = new System.Drawing.Point(259, 42);
            this.allContractsL.Name = "allContractsL";
            this.allContractsL.Size = new System.Drawing.Size(141, 36);
            this.allContractsL.TabIndex = 1;
            this.allContractsL.Text = "Контракти";
            this.allContractsL.Click += new System.EventHandler(this.allContractsL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allBookingsL
            // 
            this.allBookingsL.AutoSize = true;
            this.allBookingsL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allBookingsL.Location = new System.Drawing.Point(12, 42);
            this.allBookingsL.Name = "allBookingsL";
            this.allBookingsL.Size = new System.Drawing.Size(174, 36);
            this.allBookingsL.TabIndex = 6;
            this.allBookingsL.Text = "Бронювання";
            this.allBookingsL.Click += new System.EventHandler(this.allBookingsL_Click);
            // 
            // OrdersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 1080);
            this.Controls.Add(this.allBookingsL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.allContractsL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersPanel";
            this.Text = "BookerPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allContractsL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allBookingsL;
    }
}