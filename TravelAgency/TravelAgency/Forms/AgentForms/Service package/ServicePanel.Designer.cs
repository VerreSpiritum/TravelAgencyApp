namespace TravelAgency
{
    partial class ServicePanel
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
            this.allAddTourL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allTourL = new System.Windows.Forms.Label();
            this.hotelInfo = new System.Windows.Forms.Label();
            this.TransferInfoL = new System.Windows.Forms.Label();
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
            // allAddTourL
            // 
            this.allAddTourL.AutoSize = true;
            this.allAddTourL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allAddTourL.Location = new System.Drawing.Point(153, 42);
            this.allAddTourL.Name = "allAddTourL";
            this.allAddTourL.Size = new System.Drawing.Size(193, 36);
            this.allAddTourL.TabIndex = 1;
            this.allAddTourL.Text = "Додаткові тури";
            this.allAddTourL.Click += new System.EventHandler(this.allAddTourL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allTourL
            // 
            this.allTourL.AutoSize = true;
            this.allTourL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTourL.Location = new System.Drawing.Point(12, 42);
            this.allTourL.Name = "allTourL";
            this.allTourL.Size = new System.Drawing.Size(70, 36);
            this.allTourL.TabIndex = 6;
            this.allTourL.Text = "Тури";
            this.allTourL.Click += new System.EventHandler(this.allTourL_Click);
            // 
            // hotelInfo
            // 
            this.hotelInfo.AutoSize = true;
            this.hotelInfo.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInfo.Location = new System.Drawing.Point(456, 42);
            this.hotelInfo.Name = "hotelInfo";
            this.hotelInfo.Size = new System.Drawing.Size(85, 36);
            this.hotelInfo.TabIndex = 7;
            this.hotelInfo.Text = "Готелі";
            this.hotelInfo.Click += new System.EventHandler(this.hotelInfo_Click);
            // 
            // TransferInfoL
            // 
            this.TransferInfoL.AutoSize = true;
            this.TransferInfoL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferInfoL.Location = new System.Drawing.Point(662, 42);
            this.TransferInfoL.Name = "TransferInfoL";
            this.TransferInfoL.Size = new System.Drawing.Size(150, 36);
            this.TransferInfoL.TabIndex = 8;
            this.TransferInfoL.Text = "Трансфери";
            this.TransferInfoL.Click += new System.EventHandler(this.TransferInfoL_Click);
            // 
            // ServicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 1080);
            this.Controls.Add(this.TransferInfoL);
            this.Controls.Add(this.hotelInfo);
            this.Controls.Add(this.allTourL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.allAddTourL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicePanel";
            this.Text = "BookerPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allAddTourL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allTourL;
        private System.Windows.Forms.Label hotelInfo;
        private System.Windows.Forms.Label TransferInfoL;
    }
}