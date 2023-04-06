namespace TravelAgency
{
    partial class CreateNewStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewStaff));
            this.label1 = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.secondNameL = new System.Windows.Forms.Label();
            this.surnameL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.salaryMTB = new TravelAgency.Design.CustomMaskedTextBox();
            this.postTB = new TravelAgency.Design.CustomTextBox();
            this.startDateDT = new TravelAgency.Design.CustomDate();
            this.createNewStaffB = new TravelAgency.Design.RoundedButton();
            this.maleRB = new TravelAgency.Design.CustomRadioButton();
            this.femaleRB = new TravelAgency.Design.CustomRadioButton();
            this.birthDateDT = new TravelAgency.Design.CustomDate();
            this.surnameTB = new TravelAgency.Design.CustomTextBox();
            this.secondNameTB = new TravelAgency.Design.CustomTextBox();
            this.nameTB = new TravelAgency.Design.CustomTextBox();
            this.phoneNumber = new TravelAgency.Design.CustomMaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Повне ім\'я";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(53, 146);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(60, 36);
            this.nameL.TabIndex = 4;
            this.nameL.Text = "Ім\'я";
            // 
            // secondNameL
            // 
            this.secondNameL.AutoSize = true;
            this.secondNameL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameL.Location = new System.Drawing.Point(660, 147);
            this.secondNameL.Name = "secondNameL";
            this.secondNameL.Size = new System.Drawing.Size(157, 36);
            this.secondNameL.TabIndex = 5;
            this.secondNameL.Text = "По-батькові";
            // 
            // surnameL
            // 
            this.surnameL.AutoSize = true;
            this.surnameL.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameL.Location = new System.Drawing.Point(1252, 147);
            this.surnameL.Name = "surnameL";
            this.surnameL.Size = new System.Drawing.Size(133, 36);
            this.surnameL.TabIndex = 6;
            this.surnameL.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 49);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата народження";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1249, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 49);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стать";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(645, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 49);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер телефону";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 49);
            this.label5.TabIndex = 21;
            this.label5.Text = "Дата початку роботи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(657, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 49);
            this.label6.TabIndex = 22;
            this.label6.Text = "Посада";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1249, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 49);
            this.label7.TabIndex = 23;
            this.label7.Text = "Зарплатня";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(659, 868);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 38);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryMTB
            // 
            this.salaryMTB.BackColor = System.Drawing.Color.White;
            this.salaryMTB.BorderColor = System.Drawing.Color.Black;
            this.salaryMTB.BorderRadius = 12;
            this.salaryMTB.BorderSize = 1;
            this.salaryMTB.IsPasswordChar = false;
            this.salaryMTB.IsPlaceHolder = false;
            this.salaryMTB.Location = new System.Drawing.Point(1258, 590);
            this.salaryMTB.Mask = "00000 ";
            this.salaryMTB.Multiline = false;
            this.salaryMTB.Name = "salaryMTB";
            this.salaryMTB.PasswordChar = false;
            this.salaryMTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.salaryMTB.PlaceHolderText = "";
            this.salaryMTB.Size = new System.Drawing.Size(281, 48);
            this.salaryMTB.TabIndex = 26;
            this.salaryMTB.Texts = "3500  ";
            this.salaryMTB.UnderlineStyle = false;
            // 
            // postTB
            // 
            this.postTB.BackColor = System.Drawing.Color.White;
            this.postTB.BorderColor = System.Drawing.Color.Black;
            this.postTB.BorderRadius = 12;
            this.postTB.BorderSize = 1;
            this.postTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postTB.IsPasswordChar = false;
            this.postTB.IsPlaceHolder = false;
            this.postTB.Location = new System.Drawing.Point(666, 590);
            this.postTB.Multiline = false;
            this.postTB.Name = "postTB";
            this.postTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.postTB.PasswordChar = false;
            this.postTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.postTB.PlaceHolderText = "";
            this.postTB.Size = new System.Drawing.Size(263, 47);
            this.postTB.TabIndex = 25;
            this.postTB.Texts = "Агент";
            this.postTB.UnderlineStyle = false;
            // 
            // startDateDT
            // 
            this.startDateDT.BorderColor = System.Drawing.Color.Black;
            this.startDateDT.BorderRadius = 12;
            this.startDateDT.BorderSize = 1;
            this.startDateDT.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDT.Location = new System.Drawing.Point(59, 590);
            this.startDateDT.MinimumSize = new System.Drawing.Size(4, 46);
            this.startDateDT.Name = "startDateDT";
            this.startDateDT.Size = new System.Drawing.Size(299, 46);
            this.startDateDT.SkinColor = System.Drawing.Color.White;
            this.startDateDT.TabIndex = 24;
            this.startDateDT.TextColor = System.Drawing.Color.Black;
            // 
            // createNewStaffB
            // 
            this.createNewStaffB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createNewStaffB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createNewStaffB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createNewStaffB.BorderRadius = 12;
            this.createNewStaffB.BorderSize = 0;
            this.createNewStaffB.FlatAppearance.BorderSize = 0;
            this.createNewStaffB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewStaffB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewStaffB.ForeColor = System.Drawing.Color.White;
            this.createNewStaffB.Location = new System.Drawing.Point(1312, 769);
            this.createNewStaffB.Name = "createNewStaffB";
            this.createNewStaffB.Size = new System.Drawing.Size(227, 105);
            this.createNewStaffB.TabIndex = 19;
            this.createNewStaffB.Text = "Створити співробітника";
            this.createNewStaffB.TextColor = System.Drawing.Color.White;
            this.createNewStaffB.UseVisualStyleBackColor = false;
            this.createNewStaffB.Click += new System.EventHandler(this.createNewStaffB_Click);
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.maleRB.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleRB.Location = new System.Drawing.Point(1269, 369);
            this.maleRB.MinimumSize = new System.Drawing.Size(0, 46);
            this.maleRB.Name = "maleRB";
            this.maleRB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.maleRB.Size = new System.Drawing.Size(120, 46);
            this.maleRB.TabIndex = 18;
            this.maleRB.Text = "Чоловік";
            this.maleRB.UnCheckedColor = System.Drawing.Color.Black;
            this.maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.Checked = true;
            this.femaleRB.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.femaleRB.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleRB.Location = new System.Drawing.Point(1269, 317);
            this.femaleRB.MinimumSize = new System.Drawing.Size(0, 46);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.femaleRB.Size = new System.Drawing.Size(102, 46);
            this.femaleRB.TabIndex = 17;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Жінка";
            this.femaleRB.UnCheckedColor = System.Drawing.Color.Black;
            this.femaleRB.UseVisualStyleBackColor = true;
            // 
            // birthDateDT
            // 
            this.birthDateDT.BorderColor = System.Drawing.Color.Black;
            this.birthDateDT.BorderRadius = 12;
            this.birthDateDT.BorderSize = 1;
            this.birthDateDT.CalendarFont = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.birthDateDT.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDT.Location = new System.Drawing.Point(53, 342);
            this.birthDateDT.MinimumSize = new System.Drawing.Size(4, 46);
            this.birthDateDT.Name = "birthDateDT";
            this.birthDateDT.Size = new System.Drawing.Size(305, 46);
            this.birthDateDT.SkinColor = System.Drawing.Color.White;
            this.birthDateDT.TabIndex = 16;
            this.birthDateDT.TextColor = System.Drawing.Color.Black;
            // 
            // surnameTB
            // 
            this.surnameTB.BackColor = System.Drawing.Color.White;
            this.surnameTB.BorderColor = System.Drawing.Color.Black;
            this.surnameTB.BorderRadius = 12;
            this.surnameTB.BorderSize = 1;
            this.surnameTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.surnameTB.IsPasswordChar = false;
            this.surnameTB.IsPlaceHolder = false;
            this.surnameTB.Location = new System.Drawing.Point(1258, 96);
            this.surnameTB.Multiline = false;
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.surnameTB.PasswordChar = false;
            this.surnameTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.surnameTB.PlaceHolderText = "";
            this.surnameTB.Size = new System.Drawing.Size(263, 47);
            this.surnameTB.TabIndex = 15;
            this.surnameTB.Texts = "";
            this.surnameTB.UnderlineStyle = false;
            this.surnameTB._TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // secondNameTB
            // 
            this.secondNameTB.BackColor = System.Drawing.Color.White;
            this.secondNameTB.BorderColor = System.Drawing.Color.Black;
            this.secondNameTB.BorderRadius = 12;
            this.secondNameTB.BorderSize = 1;
            this.secondNameTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.secondNameTB.IsPasswordChar = false;
            this.secondNameTB.IsPlaceHolder = false;
            this.secondNameTB.Location = new System.Drawing.Point(654, 97);
            this.secondNameTB.Multiline = false;
            this.secondNameTB.Name = "secondNameTB";
            this.secondNameTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.secondNameTB.PasswordChar = false;
            this.secondNameTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.secondNameTB.PlaceHolderText = "";
            this.secondNameTB.Size = new System.Drawing.Size(263, 46);
            this.secondNameTB.TabIndex = 1;
            this.secondNameTB.Texts = "";
            this.secondNameTB.UnderlineStyle = false;
            this.secondNameTB._TextChanged += new System.EventHandler(this.secondNameTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.BorderColor = System.Drawing.Color.Black;
            this.nameTB.BorderRadius = 12;
            this.nameTB.BorderSize = 1;
            this.nameTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.nameTB.IsPasswordChar = false;
            this.nameTB.IsPlaceHolder = false;
            this.nameTB.Location = new System.Drawing.Point(53, 96);
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.nameTB.PasswordChar = false;
            this.nameTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nameTB.PlaceHolderText = "";
            this.nameTB.Size = new System.Drawing.Size(263, 46);
            this.nameTB.TabIndex = 0;
            this.nameTB.Texts = "";
            this.nameTB.UnderlineStyle = false;
            this.nameTB._TextChanged += new System.EventHandler(this.nameTB__TextChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.White;
            this.phoneNumber.BorderColor = System.Drawing.Color.Black;
            this.phoneNumber.BorderRadius = 12;
            this.phoneNumber.BorderSize = 1;
            this.phoneNumber.IsPasswordChar = false;
            this.phoneNumber.IsPlaceHolder = false;
            this.phoneNumber.Location = new System.Drawing.Point(654, 342);
            this.phoneNumber.Mask = "+38 (000) 000-00-00";
            this.phoneNumber.Multiline = false;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.PasswordChar = false;
            this.phoneNumber.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber.PlaceHolderText = "";
            this.phoneNumber.Size = new System.Drawing.Size(281, 46);
            this.phoneNumber.TabIndex = 20;
            this.phoneNumber.Texts = "+38 (   )    -  -";
            this.phoneNumber.UnderlineStyle = false;
            // 
            // CreateNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1646, 992);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.salaryMTB);
            this.Controls.Add(this.postTB);
            this.Controls.Add(this.startDateDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.createNewStaffB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.birthDateDT);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameL);
            this.Controls.Add(this.secondNameL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondNameTB);
            this.Controls.Add(this.nameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewStaff";
            this.Text = "CreateNewStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.CustomTextBox nameTB;
        private Design.CustomTextBox secondNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label secondNameL;
        private System.Windows.Forms.Label surnameL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Design.CustomTextBox surnameTB;
        private Design.CustomDate birthDateDT;
        private Design.CustomRadioButton femaleRB;
        private Design.CustomRadioButton maleRB;
        private Design.RoundedButton createNewStaffB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Design.CustomDate startDateDT;
        private Design.CustomTextBox postTB;
        private Design.CustomMaskedTextBox salaryMTB;
        private System.Windows.Forms.Label errorLabel;
        private Design.CustomMaskedTextBox phoneNumber;
    }
}