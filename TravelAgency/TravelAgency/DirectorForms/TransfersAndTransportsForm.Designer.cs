namespace TravelAgency
{
    partial class TransferAndTransportsForm
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
            this.newTransportL = new System.Windows.Forms.Label();
            this.editTransportL = new System.Windows.Forms.Label();
            this.showEmployeeL = new System.Windows.Forms.Label();
            this.panelToWork = new System.Windows.Forms.Panel();
            this.allTransportsL = new System.Windows.Forms.Label();
            this.addTransferL = new System.Windows.Forms.Label();
            this.editTransferL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1722, 2);
            this.label1.TabIndex = 0;
            // 
            // newTransportL
            // 
            this.newTransportL.AutoSize = true;
            this.newTransportL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTransportL.Location = new System.Drawing.Point(256, 42);
            this.newTransportL.Name = "newTransportL";
            this.newTransportL.Size = new System.Drawing.Size(230, 36);
            this.newTransportL.TabIndex = 1;
            this.newTransportL.Text = "Додати транспорт";
            this.newTransportL.Click += new System.EventHandler(this.newTransportL_Click);
            // 
            // editTransportL
            // 
            this.editTransportL.AutoSize = true;
            this.editTransportL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTransportL.Location = new System.Drawing.Point(546, 42);
            this.editTransportL.Name = "editTransportL";
            this.editTransportL.Size = new System.Drawing.Size(281, 36);
            this.editTransportL.TabIndex = 2;
            this.editTransportL.Text = "Редагувати транспорт";
            this.editTransportL.Click += new System.EventHandler(this.editTransportL_Click);
            // 
            // showEmployeeL
            // 
            this.showEmployeeL.AutoSize = true;
            this.showEmployeeL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showEmployeeL.Location = new System.Drawing.Point(898, 42);
            this.showEmployeeL.Name = "showEmployeeL";
            this.showEmployeeL.Size = new System.Drawing.Size(150, 36);
            this.showEmployeeL.TabIndex = 3;
            this.showEmployeeL.Text = "Трансфери";
            this.showEmployeeL.Click += new System.EventHandler(this.showTransfersL_Click);
            // 
            // panelToWork
            // 
            this.panelToWork.Location = new System.Drawing.Point(0, 94);
            this.panelToWork.Name = "panelToWork";
            this.panelToWork.Size = new System.Drawing.Size(1718, 986);
            this.panelToWork.TabIndex = 5;
            // 
            // allTransportsL
            // 
            this.allTransportsL.AutoSize = true;
            this.allTransportsL.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTransportsL.Location = new System.Drawing.Point(12, 42);
            this.allTransportsL.Name = "allTransportsL";
            this.allTransportsL.Size = new System.Drawing.Size(194, 36);
            this.allTransportsL.TabIndex = 6;
            this.allTransportsL.Text = "Усі транспорти";
            this.allTransportsL.Click += new System.EventHandler(this.allTransportsL_Click);
            // 
            // addTransferL
            // 
            this.addTransferL.AutoSize = true;
            this.addTransferL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTransferL.Location = new System.Drawing.Point(1118, 42);
            this.addTransferL.Name = "addTransferL";
            this.addTransferL.Size = new System.Drawing.Size(223, 36);
            this.addTransferL.TabIndex = 7;
            this.addTransferL.Text = "Додати трансфер";
            this.addTransferL.Click += new System.EventHandler(this.addTransferL_Click);
            // 
            // editTransferL
            // 
            this.editTransferL.AutoSize = true;
            this.editTransferL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTransferL.Location = new System.Drawing.Point(1411, 42);
            this.editTransferL.Name = "editTransferL";
            this.editTransferL.Size = new System.Drawing.Size(274, 36);
            this.editTransferL.TabIndex = 8;
            this.editTransferL.Text = "Редагувати трансфер";
            this.editTransferL.Click += new System.EventHandler(this.editTransferL_Click);
            // 
            // TransferAndTransportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1717, 1080);
            this.Controls.Add(this.editTransferL);
            this.Controls.Add(this.addTransferL);
            this.Controls.Add(this.allTransportsL);
            this.Controls.Add(this.panelToWork);
            this.Controls.Add(this.showEmployeeL);
            this.Controls.Add(this.editTransportL);
            this.Controls.Add(this.newTransportL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferAndTransportsForm";
            this.Text = "HumanResoucesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newTransportL;
        private System.Windows.Forms.Label editTransportL;
        private System.Windows.Forms.Label showEmployeeL;
        private System.Windows.Forms.Panel panelToWork;
        private System.Windows.Forms.Label allTransportsL;
        private System.Windows.Forms.Label addTransferL;
        private System.Windows.Forms.Label editTransferL;
    }
}