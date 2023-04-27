namespace TravelAgency
{
    partial class AgentMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentMainPage));
            this.MenuPB = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Label();
            this.personalInfoL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Label();
            this.clientsL = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.ordersL = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPB
            // 
            this.MenuPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPB.BackColor = System.Drawing.Color.Transparent;
            this.MenuPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPB.BackgroundImage")));
            this.MenuPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPB.Location = new System.Drawing.Point(-2, 0);
            this.MenuPB.Name = "MenuPB";
            this.MenuPB.Size = new System.Drawing.Size(274, 925);
            this.MenuPB.TabIndex = 0;
            this.MenuPB.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.BackColor = System.Drawing.Color.Turquoise;
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.Location = new System.Drawing.Point(19, 814);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 86);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            this.exitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_Event);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exit_Event);
            this.exitBtn.MouseHover += new System.EventHandler(this.exit_Event);
            this.exitBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_Event);
            // 
            // line
            // 
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.line.Location = new System.Drawing.Point(0, 91);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(272, 2);
            this.line.TabIndex = 3;
            // 
            // personalInfoL
            // 
            this.personalInfoL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.personalInfoL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalInfoL.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInfoL.ForeColor = System.Drawing.Color.White;
            this.personalInfoL.Location = new System.Drawing.Point(12, 129);
            this.personalInfoL.Name = "personalInfoL";
            this.personalInfoL.Size = new System.Drawing.Size(254, 87);
            this.personalInfoL.TabIndex = 5;
            this.personalInfoL.Text = "Особиста інформація";
            this.personalInfoL.Click += new System.EventHandler(this.personalInfoL_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 978);
            this.panel1.TabIndex = 8;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.Location = new System.Drawing.Point(12, 227);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(184, 2);
            this.line1.TabIndex = 9;
            // 
            // clientsL
            // 
            this.clientsL.AutoSize = true;
            this.clientsL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.clientsL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsL.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsL.ForeColor = System.Drawing.Color.White;
            this.clientsL.Location = new System.Drawing.Point(12, 279);
            this.clientsL.Name = "clientsL";
            this.clientsL.Size = new System.Drawing.Size(125, 38);
            this.clientsL.TabIndex = 10;
            this.clientsL.Text = "Клієнти";
            this.clientsL.Click += new System.EventHandler(this.clientsL_Click);
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.Location = new System.Drawing.Point(12, 322);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(120, 2);
            this.line2.TabIndex = 11;
            // 
            // ordersL
            // 
            this.ordersL.AutoSize = true;
            this.ordersL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ordersL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersL.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersL.ForeColor = System.Drawing.Color.White;
            this.ordersL.Location = new System.Drawing.Point(12, 373);
            this.ordersL.Name = "ordersL";
            this.ordersL.Size = new System.Drawing.Size(194, 38);
            this.ordersL.TabIndex = 12;
            this.ordersL.Text = "Замовлення";
            this.ordersL.Click += new System.EventHandler(this.ordersL_Click);
            // 
            // line3
            // 
            this.line3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line3.BackColor = System.Drawing.Color.Transparent;
            this.line3.Location = new System.Drawing.Point(12, 420);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(194, 2);
            this.line3.TabIndex = 13;
            // 
            // AgentMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 922);
            this.ControlBox = false;
            this.Controls.Add(this.line3);
            this.Controls.Add(this.ordersL);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.clientsL);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personalInfoL);
            this.Controls.Add(this.line);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.MenuPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelAgency";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MenuPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuPB;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label personalInfoL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label clientsL;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label ordersL;
        private System.Windows.Forms.Label line3;
    }
}