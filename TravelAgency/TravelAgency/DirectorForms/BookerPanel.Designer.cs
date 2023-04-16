namespace TravelAgency
{
    partial class BookerPanel
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
            this.paymentStaytmentL = new System.Windows.Forms.Label();
            this.concludedContractsL = new System.Windows.Forms.Label();
            this.profitL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allSalariesL = new System.Windows.Forms.Label();
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
            // paymentStaytmentL
            // 
            this.paymentStaytmentL.AutoSize = true;
            this.paymentStaytmentL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentStaytmentL.Location = new System.Drawing.Point(185, 42);
            this.paymentStaytmentL.Name = "paymentStaytmentL";
            this.paymentStaytmentL.Size = new System.Drawing.Size(241, 36);
            this.paymentStaytmentL.TabIndex = 1;
            this.paymentStaytmentL.Text = "Платіжна відомість";
            this.paymentStaytmentL.Click += new System.EventHandler(this.paymentStaytmentL_Click);
            // 
            // concludedContractsL
            // 
            this.concludedContractsL.AutoSize = true;
            this.concludedContractsL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.concludedContractsL.Location = new System.Drawing.Point(491, 42);
            this.concludedContractsL.Name = "concludedContractsL";
            this.concludedContractsL.Size = new System.Drawing.Size(236, 36);
            this.concludedContractsL.TabIndex = 2;
            this.concludedContractsL.Text = "Укладені конракти";
            this.concludedContractsL.Click += new System.EventHandler(this.concludedContractsL_Click);
            // 
            // profitL
            // 
            this.profitL.AutoSize = true;
            this.profitL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profitL.Location = new System.Drawing.Point(792, 42);
            this.profitL.Name = "profitL";
            this.profitL.Size = new System.Drawing.Size(128, 36);
            this.profitL.TabIndex = 3;
            this.profitL.Text = "Прибуток";
            this.profitL.Click += new System.EventHandler(this.profitL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allSalariesL
            // 
            this.allSalariesL.AutoSize = true;
            this.allSalariesL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allSalariesL.Location = new System.Drawing.Point(12, 42);
            this.allSalariesL.Name = "allSalariesL";
            this.allSalariesL.Size = new System.Drawing.Size(128, 36);
            this.allSalariesL.TabIndex = 6;
            this.allSalariesL.Text = "Зарплати";
            this.allSalariesL.Click += new System.EventHandler(this.allSalariesL_Click);
            // 
            // BookerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 1080);
            this.Controls.Add(this.allSalariesL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.profitL);
            this.Controls.Add(this.concludedContractsL);
            this.Controls.Add(this.paymentStaytmentL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookerPanel";
            this.Text = "BookerPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paymentStaytmentL;
        private System.Windows.Forms.Label concludedContractsL;
        private System.Windows.Forms.Label profitL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allSalariesL;
    }
}