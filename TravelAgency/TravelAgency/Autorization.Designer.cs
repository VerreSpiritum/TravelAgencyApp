namespace TravelAgency
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.companylabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorMess = new System.Windows.Forms.Label();
            this.loginTB = new TravelAgency.Design.CustomTextBox();
            this.passwordTB = new TravelAgency.Design.CustomTextBox();
            this.ConnectingBtn = new TravelAgency.Design.RoundedButton();
            this.SuspendLayout();
            // 
            // companylabel
            // 
            this.companylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companylabel.AutoSize = true;
            this.companylabel.BackColor = System.Drawing.Color.Transparent;
            this.companylabel.Font = new System.Drawing.Font("Papyrus", 13F);
            this.companylabel.ForeColor = System.Drawing.Color.White;
            this.companylabel.Location = new System.Drawing.Point(370, 0);
            this.companylabel.Name = "companylabel";
            this.companylabel.Size = new System.Drawing.Size(156, 34);
            this.companylabel.TabIndex = 3;
            this.companylabel.Text = "TravelAgency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вхід у систему";
            // 
            // ErrorMess
            // 
            this.ErrorMess.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMess.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMess.ForeColor = System.Drawing.Color.Red;
            this.ErrorMess.Location = new System.Drawing.Point(114, 488);
            this.ErrorMess.Name = "ErrorMess";
            this.ErrorMess.Size = new System.Drawing.Size(304, 25);
            this.ErrorMess.TabIndex = 11;
            this.ErrorMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTB
            // 
            this.loginTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTB.BackColor = System.Drawing.Color.White;
            this.loginTB.BorderColor = System.Drawing.Color.White;
            this.loginTB.BorderRadius = 12;
            this.loginTB.BorderSize = 2;
            this.loginTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.IsPasswordChar = false;
            this.loginTB.IsPlaceHolder = true;
            this.loginTB.Location = new System.Drawing.Point(114, 251);
            this.loginTB.Multiline = false;
            this.loginTB.Name = "loginTB";
            this.loginTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.loginTB.PasswordChar = false;
            this.loginTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.loginTB.PlaceHolderText = "Логін";
            this.loginTB.Size = new System.Drawing.Size(304, 47);
            this.loginTB.TabIndex = 10;
            this.loginTB.Texts = "";
            this.loginTB.UnderlineStyle = true;
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderColor = System.Drawing.Color.White;
            this.passwordTB.BorderRadius = 12;
            this.passwordTB.BorderSize = 2;
            this.passwordTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.IsPasswordChar = true;
            this.passwordTB.IsPlaceHolder = true;
            this.passwordTB.Location = new System.Drawing.Point(114, 328);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTB.PasswordChar = true;
            this.passwordTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.passwordTB.PlaceHolderText = "Пароль";
            this.passwordTB.Size = new System.Drawing.Size(302, 47);
            this.passwordTB.TabIndex = 9;
            this.passwordTB.Texts = "";
            this.passwordTB.UnderlineStyle = true;
            // 
            // ConnectingBtn
            // 
            this.ConnectingBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ConnectingBtn.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.ConnectingBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ConnectingBtn.BorderRadius = 23;
            this.ConnectingBtn.BorderSize = 0;
            this.ConnectingBtn.FlatAppearance.BorderSize = 0;
            this.ConnectingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectingBtn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectingBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectingBtn.Location = new System.Drawing.Point(179, 427);
            this.ConnectingBtn.Name = "ConnectingBtn";
            this.ConnectingBtn.Size = new System.Drawing.Size(165, 55);
            this.ConnectingBtn.TabIndex = 5;
            this.ConnectingBtn.Text = "Вхід";
            this.ConnectingBtn.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ConnectingBtn.UseVisualStyleBackColor = false;
            this.ConnectingBtn.Click += new System.EventHandler(this.ConnectingBtn_Click);
            this.ConnectingBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConnectingBtn_MouseHoverDown);
            this.ConnectingBtn.MouseLeave += new System.EventHandler(this.ConnectingBtn_MouseLeave);
            this.ConnectingBtn.MouseHover += new System.EventHandler(this.ConnectingBtn_MouseHoverDown);
            // 
            // Autorization
            // 
            this.AcceptButton = this.ConnectingBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 612);
            this.Controls.Add(this.ErrorMess);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.ConnectingBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.companylabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Autorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label companylabel;
        private System.Windows.Forms.Label label2;
        private Design.RoundedButton ConnectingBtn;
        private Design.CustomTextBox passwordTB;
        private Design.CustomTextBox loginTB;
        private System.Windows.Forms.Label ErrorMess;
    }
}

