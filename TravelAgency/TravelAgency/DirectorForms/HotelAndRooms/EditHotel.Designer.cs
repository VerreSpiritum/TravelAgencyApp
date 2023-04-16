namespace TravelAgency
{
    partial class EditHotel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.photoHotel = new TravelAgency.Design.CustomTextBox();
            this.city = new TravelAgency.Design.CustomComboBox();
            this.locationInCity = new TravelAgency.Design.CustomTextBox();
            this.hotelCategory = new TravelAgency.Design.CustomComboBox();
            this.hotelName = new TravelAgency.Design.CustomTextBox();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateNewBtn = new TravelAgency.Design.RoundedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.checkIn = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.checkOut = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.searchBtn = new TravelAgency.Design.RoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.listWithHotelNum = new TravelAgency.Design.TestComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Назва готелю";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(533, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Категорія";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(533, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адреса";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 10;
            this.label4.Text = "Місто";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фото готелю";
            // 
            // photoHotel
            // 
            this.photoHotel.BackColor = System.Drawing.Color.White;
            this.photoHotel.BorderColor = System.Drawing.Color.Black;
            this.photoHotel.BorderRadius = 0;
            this.photoHotel.BorderSize = 1;
            this.photoHotel.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoHotel.IsPasswordChar = false;
            this.photoHotel.IsPlaceHolder = false;
            this.photoHotel.Location = new System.Drawing.Point(56, 594);
            this.photoHotel.Multiline = false;
            this.photoHotel.Name = "photoHotel";
            this.photoHotel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.photoHotel.PasswordChar = false;
            this.photoHotel.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.photoHotel.PlaceHolderText = "";
            this.photoHotel.Size = new System.Drawing.Size(351, 65);
            this.photoHotel.TabIndex = 5;
            this.photoHotel.Texts = "";
            this.photoHotel.UnderlineStyle = false;
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.BorderColor = System.Drawing.Color.Black;
            this.city.BorderSize = 0;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.city.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.ForeColor = System.Drawing.Color.Black;
            this.city.IconColor = System.Drawing.Color.Black;
            this.city.ListBackColor = System.Drawing.Color.White;
            this.city.ListTextColor = System.Drawing.Color.DimGray;
            this.city.Location = new System.Drawing.Point(56, 403);
            this.city.MinimumSize = new System.Drawing.Size(200, 30);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(351, 65);
            this.city.TabIndex = 4;
            this.city.Texts = "";
            // 
            // locationInCity
            // 
            this.locationInCity.BackColor = System.Drawing.Color.White;
            this.locationInCity.BorderColor = System.Drawing.Color.Black;
            this.locationInCity.BorderRadius = 0;
            this.locationInCity.BorderSize = 1;
            this.locationInCity.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationInCity.IsPasswordChar = false;
            this.locationInCity.IsPlaceHolder = false;
            this.locationInCity.Location = new System.Drawing.Point(539, 403);
            this.locationInCity.Multiline = false;
            this.locationInCity.Name = "locationInCity";
            this.locationInCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.locationInCity.PasswordChar = false;
            this.locationInCity.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.locationInCity.PlaceHolderText = "";
            this.locationInCity.Size = new System.Drawing.Size(351, 65);
            this.locationInCity.TabIndex = 3;
            this.locationInCity.Texts = "";
            this.locationInCity.UnderlineStyle = false;
            // 
            // hotelCategory
            // 
            this.hotelCategory.BackColor = System.Drawing.Color.White;
            this.hotelCategory.BorderColor = System.Drawing.Color.Black;
            this.hotelCategory.BorderSize = 0;
            this.hotelCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.hotelCategory.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelCategory.ForeColor = System.Drawing.Color.Black;
            this.hotelCategory.IconColor = System.Drawing.Color.Black;
            this.hotelCategory.ListBackColor = System.Drawing.Color.White;
            this.hotelCategory.ListTextColor = System.Drawing.Color.DimGray;
            this.hotelCategory.Location = new System.Drawing.Point(539, 221);
            this.hotelCategory.MinimumSize = new System.Drawing.Size(200, 30);
            this.hotelCategory.Name = "hotelCategory";
            this.hotelCategory.Size = new System.Drawing.Size(351, 65);
            this.hotelCategory.TabIndex = 1;
            this.hotelCategory.Texts = "";
            // 
            // hotelName
            // 
            this.hotelName.BackColor = System.Drawing.Color.White;
            this.hotelName.BorderColor = System.Drawing.Color.Black;
            this.hotelName.BorderRadius = 0;
            this.hotelName.BorderSize = 1;
            this.hotelName.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelName.IsPasswordChar = false;
            this.hotelName.IsPlaceHolder = false;
            this.hotelName.Location = new System.Drawing.Point(56, 221);
            this.hotelName.Multiline = false;
            this.hotelName.Name = "hotelName";
            this.hotelName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.hotelName.PasswordChar = false;
            this.hotelName.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.hotelName.PlaceHolderText = "";
            this.hotelName.Size = new System.Drawing.Size(351, 65);
            this.hotelName.TabIndex = 0;
            this.hotelName.Texts = "";
            this.hotelName.UnderlineStyle = false;
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(984, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 479);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(532, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 38);
            this.label7.TabIndex = 15;
            this.label7.Text = "Поселення";
            // 
            // CreateNewBtn
            // 
            this.CreateNewBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateNewBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.CreateNewBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreateNewBtn.BorderRadius = 12;
            this.CreateNewBtn.BorderSize = 0;
            this.CreateNewBtn.FlatAppearance.BorderSize = 0;
            this.CreateNewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateNewBtn.ForeColor = System.Drawing.Color.White;
            this.CreateNewBtn.Location = new System.Drawing.Point(1392, 811);
            this.CreateNewBtn.Name = "CreateNewBtn";
            this.CreateNewBtn.Size = new System.Drawing.Size(253, 116);
            this.CreateNewBtn.TabIndex = 19;
            this.CreateNewBtn.Text = "Додати готель";
            this.CreateNewBtn.TextColor = System.Drawing.Color.White;
            this.CreateNewBtn.UseVisualStyleBackColor = false;
            this.CreateNewBtn.Click += new System.EventHandler(this.CreateNewBtn_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(714, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 38);
            this.label6.TabIndex = 20;
            this.label6.Text = "Виселення";
            // 
            // checkIn
            // 
            this.checkIn.BackColor = System.Drawing.Color.White;
            this.checkIn.BorderColor = System.Drawing.Color.Black;
            this.checkIn.BorderRadius = 0;
            this.checkIn.BorderSize = 1;
            this.checkIn.IsPasswordChar = false;
            this.checkIn.IsPlaceHolder = false;
            this.checkIn.Location = new System.Drawing.Point(539, 594);
            this.checkIn.Mask = "00:00";
            this.checkIn.Multiline = false;
            this.checkIn.Name = "checkIn";
            this.checkIn.PasswordChar = false;
            this.checkIn.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.checkIn.PlaceHolderText = "";
            this.checkIn.Size = new System.Drawing.Size(134, 65);
            this.checkIn.TabIndex = 21;
            this.checkIn.Texts = "  :";
            this.checkIn.UnderlineStyle = false;
            // 
            // checkOut
            // 
            this.checkOut.BackColor = System.Drawing.Color.White;
            this.checkOut.BorderColor = System.Drawing.Color.Black;
            this.checkOut.BorderRadius = 0;
            this.checkOut.BorderSize = 1;
            this.checkOut.IsPasswordChar = false;
            this.checkOut.IsPlaceHolder = false;
            this.checkOut.Location = new System.Drawing.Point(721, 594);
            this.checkOut.Mask = "00:00";
            this.checkOut.Multiline = false;
            this.checkOut.Name = "checkOut";
            this.checkOut.PasswordChar = false;
            this.checkOut.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.checkOut.PlaceHolderText = "";
            this.checkOut.Size = new System.Drawing.Size(134, 65);
            this.checkOut.TabIndex = 22;
            this.checkOut.Texts = "  :";
            this.checkOut.UnderlineStyle = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 12;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(540, 84);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(194, 65);
            this.searchBtn.TabIndex = 91;
            this.searchBtn.Text = "Пошук";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(52, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 38);
            this.label8.TabIndex = 90;
            this.label8.Text = "Оберіть готель для зміни";
            // 
            // listWithHotelNum
            // 
            this.listWithHotelNum.BackColor = System.Drawing.Color.White;
            this.listWithHotelNum.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.listWithHotelNum.BorderRadius = 12;
            this.listWithHotelNum.BorderSize = 0;
            this.listWithHotelNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listWithHotelNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.listWithHotelNum.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listWithHotelNum.ForeColor = System.Drawing.Color.Black;
            this.listWithHotelNum.IconColor = System.Drawing.Color.Black;
            this.listWithHotelNum.ListBackColor = System.Drawing.Color.White;
            this.listWithHotelNum.ListTextColor = System.Drawing.Color.Black;
            this.listWithHotelNum.Location = new System.Drawing.Point(59, 84);
            this.listWithHotelNum.MinimumSize = new System.Drawing.Size(200, 30);
            this.listWithHotelNum.Name = "listWithHotelNum";
            this.listWithHotelNum.Size = new System.Drawing.Size(213, 65);
            this.listWithHotelNum.TabIndex = 89;
            this.listWithHotelNum.Texts = "";
            this.listWithHotelNum.OnSelectedIndexChanged += new System.EventHandler(this.listWithHotelNum_OnSelectedIndexChanged);
            // 
            // EditHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1657, 998);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listWithHotelNum);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateNewBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoHotel);
            this.Controls.Add(this.city);
            this.Controls.Add(this.locationInCity);
            this.Controls.Add(this.hotelCategory);
            this.Controls.Add(this.hotelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Design.CustomTextBox hotelName;
        private Design.CustomComboBox hotelCategory;
        private Design.CustomTextBox locationInCity;
        private Design.CustomComboBox city;
        private Design.CustomTextBox photoHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel panel1;
        private System.Windows.Forms.Label label7;
        private Design.RoundedButton CreateNewBtn;
        private System.Windows.Forms.Label label6;
        private Design.CustomMaskedTextBoxDate checkIn;
        private Design.CustomMaskedTextBoxDate checkOut;
        private Design.RoundedButton searchBtn;
        private System.Windows.Forms.Label label8;
        private Design.TestComboBox listWithHotelNum;
    }
}