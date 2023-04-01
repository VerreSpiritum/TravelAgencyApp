namespace TravelAgency
{
    partial class EditUser
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
            this.saveChangesB = new TravelAgency.Design.RoundedButton();
            this.passwordTB = new TravelAgency.Design.CustomTextBox();
            this.loginTB = new TravelAgency.Design.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // saveChangesB
            // 
            this.saveChangesB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveChangesB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.saveChangesB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveChangesB.BorderRadius = 12;
            this.saveChangesB.BorderSize = 0;
            this.saveChangesB.FlatAppearance.BorderSize = 0;
            this.saveChangesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesB.ForeColor = System.Drawing.Color.White;
            this.saveChangesB.Location = new System.Drawing.Point(423, 301);
            this.saveChangesB.Name = "saveChangesB";
            this.saveChangesB.Size = new System.Drawing.Size(199, 95);
            this.saveChangesB.TabIndex = 47;
            this.saveChangesB.Text = "Зберегти зміни";
            this.saveChangesB.TextColor = System.Drawing.Color.White;
            this.saveChangesB.UseVisualStyleBackColor = false;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderColor = System.Drawing.Color.Black;
            this.passwordTB.BorderRadius = 12;
            this.passwordTB.BorderSize = 1;
            this.passwordTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.passwordTB.IsPasswordChar = false;
            this.passwordTB.IsPlaceHolder = false;
            this.passwordTB.Location = new System.Drawing.Point(51, 247);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.passwordTB.PasswordChar = false;
            this.passwordTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.passwordTB.PlaceHolderText = "";
            this.passwordTB.Size = new System.Drawing.Size(263, 46);
            this.passwordTB.TabIndex = 49;
            this.passwordTB.Texts = "";
            this.passwordTB.UnderlineStyle = false;
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.White;
            this.loginTB.BorderColor = System.Drawing.Color.Black;
            this.loginTB.BorderRadius = 12;
            this.loginTB.BorderSize = 1;
            this.loginTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.loginTB.IsPasswordChar = false;
            this.loginTB.IsPlaceHolder = false;
            this.loginTB.Location = new System.Drawing.Point(51, 108);
            this.loginTB.Multiline = false;
            this.loginTB.Name = "loginTB";
            this.loginTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.loginTB.PasswordChar = false;
            this.loginTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.loginTB.PlaceHolderText = "";
            this.loginTB.Size = new System.Drawing.Size(263, 46);
            this.loginTB.TabIndex = 48;
            this.loginTB.Texts = "";
            this.loginTB.UnderlineStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 49);
            this.label2.TabIndex = 50;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.saveChangesB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.Text = "EditEmloyee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Design.RoundedButton saveChangesB;
        private Design.CustomTextBox passwordTB;
        private Design.CustomTextBox loginTB;
        private System.Windows.Forms.Label label2;
    }
}