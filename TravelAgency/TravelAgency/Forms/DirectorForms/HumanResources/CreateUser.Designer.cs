namespace TravelAgency
{
    partial class CreateUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTB = new TravelAgency.Design.CustomTextBox();
            this.loginTB = new TravelAgency.Design.CustomTextBox();
            this.createUserB = new TravelAgency.Design.RoundedButton();
            this.showPasswordCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Талонний номер";
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
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.White;
            this.passwordTB.BorderColor = System.Drawing.Color.Black;
            this.passwordTB.BorderRadius = 0;
            this.passwordTB.BorderSize = 1;
            this.passwordTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.passwordTB.IsPasswordChar = true;
            this.passwordTB.IsPlaceHolder = false;
            this.passwordTB.Location = new System.Drawing.Point(51, 247);
            this.passwordTB.Multiline = false;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.passwordTB.PasswordChar = true;
            this.passwordTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.passwordTB.PlaceHolderText = "";
            this.passwordTB.Size = new System.Drawing.Size(263, 46);
            this.passwordTB.TabIndex = 49;
            this.passwordTB.Texts = "";
            this.passwordTB.UnderlineStyle = false;
            this.passwordTB._TextChanged += new System.EventHandler(this.passwordTB__TextChanged);
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.White;
            this.loginTB.BorderColor = System.Drawing.Color.Black;
            this.loginTB.BorderRadius = 0;
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
            this.loginTB._TextChanged += new System.EventHandler(this.talonNumTB_TextChanges);
            // 
            // createUserB
            // 
            this.createUserB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createUserB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createUserB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createUserB.BorderRadius = 12;
            this.createUserB.BorderSize = 0;
            this.createUserB.FlatAppearance.BorderSize = 0;
            this.createUserB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createUserB.ForeColor = System.Drawing.Color.White;
            this.createUserB.Location = new System.Drawing.Point(400, 301);
            this.createUserB.Name = "createUserB";
            this.createUserB.Size = new System.Drawing.Size(213, 95);
            this.createUserB.TabIndex = 47;
            this.createUserB.Text = "Створити користувача";
            this.createUserB.TextColor = System.Drawing.Color.White;
            this.createUserB.UseVisualStyleBackColor = false;
            this.createUserB.Click += new System.EventHandler(this.createUserB_Click);
            // 
            // showPasswordCheck
            // 
            this.showPasswordCheck.AutoSize = true;
            this.showPasswordCheck.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordCheck.Location = new System.Drawing.Point(51, 311);
            this.showPasswordCheck.Name = "showPasswordCheck";
            this.showPasswordCheck.Size = new System.Drawing.Size(155, 25);
            this.showPasswordCheck.TabIndex = 51;
            this.showPasswordCheck.Text = "Показати пароль";
            this.showPasswordCheck.UseVisualStyleBackColor = true;
            this.showPasswordCheck.CheckedChanged += new System.EventHandler(this.showPasswordCheck_CheckedChanged);
            // 
            // CreateUser
            // 
            this.AcceptButton = this.createUserB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 643);
            this.Controls.Add(this.showPasswordCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.createUserB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateUser";
            this.Text = "EditEmloyee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Design.RoundedButton createUserB;
        private Design.CustomTextBox passwordTB;
        private System.Windows.Forms.Label label2;
        private Design.CustomTextBox loginTB;
        private System.Windows.Forms.CheckBox showPasswordCheck;
    }
}