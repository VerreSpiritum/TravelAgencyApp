namespace TravelAgency
{
    partial class EditTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTransport));
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createTransportB = new TravelAgency.Design.RoundedButton();
            this.linkPhotoTB = new TravelAgency.Design.CustomTextBox();
            this.ShortInfoTB = new TravelAgency.Design.CustomTextBox();
            this.CountOfSeatsTB = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.ReleaseDateTB = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.nameTB = new TravelAgency.Design.CustomTextBox();
            this.searchTransportB = new TravelAgency.Design.RoundedButton();
            this.TransportNumTB = new TravelAgency.Design.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1077, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1077, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 43);
            this.label2.TabIndex = 30;
            this.label2.Text = "Рік випуску";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1077, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 43);
            this.label3.TabIndex = 31;
            this.label3.Text = "Кількість місць";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 43);
            this.label4.TabIndex = 35;
            this.label4.Text = "Коротка інформація";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 687);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 43);
            this.label5.TabIndex = 37;
            this.label5.Text = "Лінк на фотографії";
            // 
            // createTransportB
            // 
            this.createTransportB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createTransportB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createTransportB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createTransportB.BorderRadius = 12;
            this.createTransportB.BorderSize = 0;
            this.createTransportB.FlatAppearance.BorderSize = 0;
            this.createTransportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTransportB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTransportB.ForeColor = System.Drawing.Color.White;
            this.createTransportB.Location = new System.Drawing.Point(1293, 763);
            this.createTransportB.Name = "createTransportB";
            this.createTransportB.Size = new System.Drawing.Size(269, 106);
            this.createTransportB.TabIndex = 48;
            this.createTransportB.Text = "Змінити транспорт";
            this.createTransportB.TextColor = System.Drawing.Color.White;
            this.createTransportB.UseVisualStyleBackColor = false;
            this.createTransportB.Click += new System.EventHandler(this.editTransportB_Click);
            // 
            // linkPhotoTB
            // 
            this.linkPhotoTB.BackColor = System.Drawing.Color.White;
            this.linkPhotoTB.BorderColor = System.Drawing.Color.Black;
            this.linkPhotoTB.BorderRadius = 0;
            this.linkPhotoTB.BorderSize = 1;
            this.linkPhotoTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.linkPhotoTB.IsPasswordChar = false;
            this.linkPhotoTB.IsPlaceHolder = false;
            this.linkPhotoTB.Location = new System.Drawing.Point(45, 739);
            this.linkPhotoTB.Multiline = false;
            this.linkPhotoTB.Name = "linkPhotoTB";
            this.linkPhotoTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.linkPhotoTB.PasswordChar = false;
            this.linkPhotoTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.linkPhotoTB.PlaceHolderText = "";
            this.linkPhotoTB.Size = new System.Drawing.Size(363, 58);
            this.linkPhotoTB.TabIndex = 36;
            this.linkPhotoTB.Texts = "";
            this.linkPhotoTB.UnderlineStyle = false;
            this.linkPhotoTB._TextChanged += new System.EventHandler(this.linkPhotoTB__TextChanged);
            // 
            // ShortInfoTB
            // 
            this.ShortInfoTB.BackColor = System.Drawing.Color.White;
            this.ShortInfoTB.BorderColor = System.Drawing.Color.Black;
            this.ShortInfoTB.BorderRadius = 0;
            this.ShortInfoTB.BorderSize = 1;
            this.ShortInfoTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.ShortInfoTB.IsPasswordChar = false;
            this.ShortInfoTB.IsPlaceHolder = false;
            this.ShortInfoTB.Location = new System.Drawing.Point(45, 246);
            this.ShortInfoTB.Multiline = true;
            this.ShortInfoTB.Name = "ShortInfoTB";
            this.ShortInfoTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.ShortInfoTB.PasswordChar = false;
            this.ShortInfoTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.ShortInfoTB.PlaceHolderText = "";
            this.ShortInfoTB.Size = new System.Drawing.Size(363, 390);
            this.ShortInfoTB.TabIndex = 34;
            this.ShortInfoTB.Texts = "";
            this.ShortInfoTB.UnderlineStyle = false;
            this.ShortInfoTB._TextChanged += new System.EventHandler(this.ShortInfoTB__TextChanged);
            // 
            // CountOfSeatsTB
            // 
            this.CountOfSeatsTB.BackColor = System.Drawing.Color.White;
            this.CountOfSeatsTB.BorderColor = System.Drawing.Color.Black;
            this.CountOfSeatsTB.BorderRadius = 0;
            this.CountOfSeatsTB.BorderSize = 1;
            this.CountOfSeatsTB.IsPasswordChar = false;
            this.CountOfSeatsTB.IsPlaceHolder = false;
            this.CountOfSeatsTB.Location = new System.Drawing.Point(1085, 411);
            this.CountOfSeatsTB.Mask = "00";
            this.CountOfSeatsTB.Multiline = false;
            this.CountOfSeatsTB.Name = "CountOfSeatsTB";
            this.CountOfSeatsTB.PasswordChar = false;
            this.CountOfSeatsTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CountOfSeatsTB.PlaceHolderText = "";
            this.CountOfSeatsTB.Size = new System.Drawing.Size(169, 58);
            this.CountOfSeatsTB.TabIndex = 33;
            this.CountOfSeatsTB.Texts = "";
            this.CountOfSeatsTB.UnderlineStyle = false;
            // 
            // ReleaseDateTB
            // 
            this.ReleaseDateTB.BackColor = System.Drawing.Color.White;
            this.ReleaseDateTB.BorderColor = System.Drawing.Color.Black;
            this.ReleaseDateTB.BorderRadius = 0;
            this.ReleaseDateTB.BorderSize = 1;
            this.ReleaseDateTB.IsPasswordChar = false;
            this.ReleaseDateTB.IsPlaceHolder = false;
            this.ReleaseDateTB.Location = new System.Drawing.Point(1085, 548);
            this.ReleaseDateTB.Mask = "0000";
            this.ReleaseDateTB.Multiline = false;
            this.ReleaseDateTB.Name = "ReleaseDateTB";
            this.ReleaseDateTB.PasswordChar = false;
            this.ReleaseDateTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.ReleaseDateTB.PlaceHolderText = "";
            this.ReleaseDateTB.Size = new System.Drawing.Size(169, 58);
            this.ReleaseDateTB.TabIndex = 32;
            this.ReleaseDateTB.Texts = "";
            this.ReleaseDateTB.UnderlineStyle = false;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.BorderColor = System.Drawing.Color.Black;
            this.nameTB.BorderRadius = 0;
            this.nameTB.BorderSize = 1;
            this.nameTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16F);
            this.nameTB.IsPasswordChar = false;
            this.nameTB.IsPlaceHolder = false;
            this.nameTB.Location = new System.Drawing.Point(1073, 246);
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.nameTB.PasswordChar = false;
            this.nameTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nameTB.PlaceHolderText = "";
            this.nameTB.Size = new System.Drawing.Size(363, 58);
            this.nameTB.TabIndex = 28;
            this.nameTB.Texts = "";
            this.nameTB.UnderlineStyle = false;
            this.nameTB._TextChanged += new System.EventHandler(this.nameTB__TextChanged);
            // 
            // searchTransportB
            // 
            this.searchTransportB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTransportB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTransportB.BorderColor = System.Drawing.Color.Transparent;
            this.searchTransportB.BorderRadius = 12;
            this.searchTransportB.BorderSize = 1;
            this.searchTransportB.FlatAppearance.BorderSize = 0;
            this.searchTransportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTransportB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTransportB.ForeColor = System.Drawing.Color.White;
            this.searchTransportB.Location = new System.Drawing.Point(464, 104);
            this.searchTransportB.Name = "searchTransportB";
            this.searchTransportB.Size = new System.Drawing.Size(132, 72);
            this.searchTransportB.TabIndex = 51;
            this.searchTransportB.Text = "Пошук";
            this.searchTransportB.TextColor = System.Drawing.Color.White;
            this.searchTransportB.UseVisualStyleBackColor = false;
            this.searchTransportB.Click += new System.EventHandler(this.searchTransportB_Click);
            // 
            // TransportNumTB
            // 
            this.TransportNumTB.BackColor = System.Drawing.Color.White;
            this.TransportNumTB.BorderColor = System.Drawing.Color.Black;
            this.TransportNumTB.BorderRadius = 0;
            this.TransportNumTB.BorderSize = 1;
            this.TransportNumTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransportNumTB.IsPasswordChar = false;
            this.TransportNumTB.IsPlaceHolder = false;
            this.TransportNumTB.Location = new System.Drawing.Point(57, 118);
            this.TransportNumTB.Multiline = false;
            this.TransportNumTB.Name = "TransportNumTB";
            this.TransportNumTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TransportNumTB.PasswordChar = false;
            this.TransportNumTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.TransportNumTB.PlaceHolderText = "";
            this.TransportNumTB.Size = new System.Drawing.Size(344, 49);
            this.TransportNumTB.TabIndex = 50;
            this.TransportNumTB.Texts = "";
            this.TransportNumTB.UnderlineStyle = false;
            this.TransportNumTB._TextChanged += new System.EventHandler(this.TransportNumTB__TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 49);
            this.label6.TabIndex = 49;
            this.label6.Text = "Номер транспорта";
            // 
            // EditTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1646, 992);
            this.Controls.Add(this.searchTransportB);
            this.Controls.Add(this.TransportNumTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createTransportB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkPhotoTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShortInfoTB);
            this.Controls.Add(this.CountOfSeatsTB);
            this.Controls.Add(this.ReleaseDateTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.errorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTransport";
            this.Text = "CreateNewStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private Design.CustomTextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Design.CustomMaskedTextBoxDate ReleaseDateTB;
        private Design.CustomMaskedTextBoxDate CountOfSeatsTB;
        private Design.CustomTextBox ShortInfoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Design.CustomTextBox linkPhotoTB;
        private Design.RoundedButton createTransportB;
        private Design.RoundedButton searchTransportB;
        private Design.CustomTextBox TransportNumTB;
        private System.Windows.Forms.Label label6;
    }
}