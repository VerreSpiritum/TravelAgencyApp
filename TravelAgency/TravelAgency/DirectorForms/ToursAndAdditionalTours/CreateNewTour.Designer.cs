namespace TravelAgency
{
    partial class CreateNewTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTour));
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartDateD = new System.Windows.Forms.DateTimePicker();
            this.endDateD = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tourCityInfoTable = new System.Windows.Forms.DataGridView();
            this.cityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CostM = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.book = new TravelAgency.Design.TestComboBox();
            this.transfer = new TravelAgency.Design.TestComboBox();
            this.CountOfPeople = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.childrenCount = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.TypeOfTour = new TravelAgency.Design.TestComboBox();
            this.Operators = new TravelAgency.Design.TestComboBox();
            this.AddCity = new TravelAgency.Design.RoundedButton();
            this.Cities = new TravelAgency.Design.TestComboBox();
            this.availableCity = new TravelAgency.Design.TestComboBox();
            this.linkPhotoTB = new TravelAgency.Design.CustomTextBox();
            this.nameTB = new TravelAgency.Design.CustomTextBox();
            this.createTransportB = new TravelAgency.Design.RoundedButton();
            this.ClearTable = new TravelAgency.Design.RoundedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.countOfTour = new TravelAgency.Design.CustomMaskedTextBoxDate();
            ((System.ComponentModel.ISupportInitialize)(this.tourCityInfoTable)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(558, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 30;
            this.label2.Text = "Оператор";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 38);
            this.label5.TabIndex = 37;
            this.label5.Text = "Лінк на фотографії";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 38);
            this.label3.TabIndex = 54;
            this.label3.Text = "Тип туру";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 38);
            this.label4.TabIndex = 56;
            this.label4.Text = "Дата відправки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(558, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 38);
            this.label6.TabIndex = 57;
            this.label6.Text = "Місто відправки";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(970, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 687);
            this.label7.TabIndex = 59;
            this.label7.Text = "label7";
            // 
            // StartDateD
            // 
            this.StartDateD.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateD.Location = new System.Drawing.Point(1346, 119);
            this.StartDateD.MinimumSize = new System.Drawing.Size(231, 46);
            this.StartDateD.Name = "StartDateD";
            this.StartDateD.Size = new System.Drawing.Size(296, 46);
            this.StartDateD.TabIndex = 64;
            // 
            // endDateD
            // 
            this.endDateD.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateD.Location = new System.Drawing.Point(1346, 195);
            this.endDateD.MinimumSize = new System.Drawing.Size(231, 46);
            this.endDateD.Name = "endDateD";
            this.endDateD.Size = new System.Drawing.Size(296, 46);
            this.endDateD.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1074, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 36);
            this.label10.TabIndex = 66;
            this.label10.Text = "Місто";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1074, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 36);
            this.label11.TabIndex = 67;
            this.label11.Text = "Дата почтаку";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1074, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 36);
            this.label12.TabIndex = 68;
            this.label12.Text = "Дата кінця";
            // 
            // tourCityInfoTable
            // 
            this.tourCityInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourCityInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tourCityInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.tourCityInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourCityInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tourCityInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourCityInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tourCityInfoTable.ColumnHeadersHeight = 70;
            this.tourCityInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tourCityInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityName,
            this.StartD,
            this.EndD});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tourCityInfoTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.tourCityInfoTable.GridColor = System.Drawing.Color.White;
            this.tourCityInfoTable.Location = new System.Drawing.Point(1035, 337);
            this.tourCityInfoTable.Name = "tourCityInfoTable";
            this.tourCityInfoTable.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourCityInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tourCityInfoTable.RowHeadersWidth = 51;
            this.tourCityInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tourCityInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tourCityInfoTable.RowTemplate.Height = 50;
            this.tourCityInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tourCityInfoTable.Size = new System.Drawing.Size(607, 316);
            this.tourCityInfoTable.TabIndex = 70;
            this.tourCityInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tourCityInfoTable_CellContentClick);
            // 
            // cityName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityName.DefaultCellStyle = dataGridViewCellStyle3;
            this.cityName.HeaderText = "Місто";
            this.cityName.MinimumWidth = 6;
            this.cityName.Name = "cityName";
            this.cityName.ReadOnly = true;
            this.cityName.Width = 125;
            // 
            // StartD
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartD.DefaultCellStyle = dataGridViewCellStyle4;
            this.StartD.HeaderText = "Початок";
            this.StartD.MinimumWidth = 6;
            this.StartD.Name = "StartD";
            this.StartD.ReadOnly = true;
            this.StartD.Width = 125;
            // 
            // EndD
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndD.DefaultCellStyle = dataGridViewCellStyle5;
            this.EndD.HeaderText = "Кінець";
            this.EndD.MinimumWidth = 6;
            this.EndD.Name = "EndD";
            this.EndD.ReadOnly = true;
            this.EndD.Width = 125;
            // 
            // flightDate
            // 
            this.flightDate.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightDate.Location = new System.Drawing.Point(57, 370);
            this.flightDate.MinimumSize = new System.Drawing.Size(231, 58);
            this.flightDate.Name = "flightDate";
            this.flightDate.Size = new System.Drawing.Size(298, 58);
            this.flightDate.TabIndex = 73;
            this.flightDate.ValueChanged += new System.EventHandler(this.flightDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(558, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 38);
            this.label8.TabIndex = 76;
            this.label8.Text = "Кількість дітей";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(558, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 38);
            this.label13.TabIndex = 77;
            this.label13.Text = "Кількість дорослих";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(50, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 38);
            this.label14.TabIndex = 78;
            this.label14.Text = "Трансфер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(559, 615);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(336, 38);
            this.label15.TabIndex = 80;
            this.label15.Text = "Попереднє бронювання";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(49, 797);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 43);
            this.label17.TabIndex = 84;
            this.label17.Text = "Вартість";
            // 
            // CostM
            // 
            this.CostM.BackColor = System.Drawing.Color.White;
            this.CostM.BorderColor = System.Drawing.Color.Black;
            this.CostM.BorderRadius = 0;
            this.CostM.BorderSize = 1;
            this.CostM.IsPasswordChar = false;
            this.CostM.IsPlaceHolder = false;
            this.CostM.Location = new System.Drawing.Point(57, 868);
            this.CostM.Mask = "00000";
            this.CostM.Multiline = false;
            this.CostM.Name = "CostM";
            this.CostM.PasswordChar = false;
            this.CostM.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CostM.PlaceHolderText = "";
            this.CostM.Size = new System.Drawing.Size(144, 58);
            this.CostM.TabIndex = 83;
            this.CostM.Texts = "";
            this.CostM.UnderlineStyle = false;
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.White;
            this.book.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.book.BorderRadius = 12;
            this.book.BorderSize = 0;
            this.book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.book.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.book.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book.ForeColor = System.Drawing.Color.Black;
            this.book.IconColor = System.Drawing.Color.Black;
            this.book.ListBackColor = System.Drawing.Color.White;
            this.book.ListTextColor = System.Drawing.Color.Black;
            this.book.Location = new System.Drawing.Point(566, 673);
            this.book.MinimumSize = new System.Drawing.Size(200, 30);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(200, 58);
            this.book.TabIndex = 81;
            this.book.Texts = "";
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.White;
            this.transfer.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.transfer.BorderRadius = 12;
            this.transfer.BorderSize = 0;
            this.transfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.transfer.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfer.ForeColor = System.Drawing.Color.Black;
            this.transfer.IconColor = System.Drawing.Color.Black;
            this.transfer.ListBackColor = System.Drawing.Color.White;
            this.transfer.ListTextColor = System.Drawing.Color.Black;
            this.transfer.Location = new System.Drawing.Point(57, 673);
            this.transfer.MinimumSize = new System.Drawing.Size(200, 30);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(200, 58);
            this.transfer.TabIndex = 79;
            this.transfer.Texts = "";
            // 
            // CountOfPeople
            // 
            this.CountOfPeople.BackColor = System.Drawing.Color.White;
            this.CountOfPeople.BorderColor = System.Drawing.Color.Black;
            this.CountOfPeople.BorderRadius = 0;
            this.CountOfPeople.BorderSize = 1;
            this.CountOfPeople.IsPasswordChar = false;
            this.CountOfPeople.IsPlaceHolder = false;
            this.CountOfPeople.Location = new System.Drawing.Point(566, 521);
            this.CountOfPeople.Mask = "0000";
            this.CountOfPeople.Multiline = false;
            this.CountOfPeople.Name = "CountOfPeople";
            this.CountOfPeople.PasswordChar = false;
            this.CountOfPeople.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CountOfPeople.PlaceHolderText = "";
            this.CountOfPeople.Size = new System.Drawing.Size(144, 58);
            this.CountOfPeople.TabIndex = 75;
            this.CountOfPeople.Texts = "";
            this.CountOfPeople.UnderlineStyle = false;
            // 
            // childrenCount
            // 
            this.childrenCount.BackColor = System.Drawing.Color.White;
            this.childrenCount.BorderColor = System.Drawing.Color.Black;
            this.childrenCount.BorderRadius = 0;
            this.childrenCount.BorderSize = 1;
            this.childrenCount.IsPasswordChar = false;
            this.childrenCount.IsPlaceHolder = false;
            this.childrenCount.Location = new System.Drawing.Point(566, 370);
            this.childrenCount.Mask = "0000";
            this.childrenCount.Multiline = false;
            this.childrenCount.Name = "childrenCount";
            this.childrenCount.PasswordChar = false;
            this.childrenCount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.childrenCount.PlaceHolderText = "";
            this.childrenCount.Size = new System.Drawing.Size(144, 58);
            this.childrenCount.TabIndex = 74;
            this.childrenCount.Texts = "";
            this.childrenCount.UnderlineStyle = false;
            // 
            // TypeOfTour
            // 
            this.TypeOfTour.BackColor = System.Drawing.Color.White;
            this.TypeOfTour.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TypeOfTour.BorderRadius = 12;
            this.TypeOfTour.BorderSize = 0;
            this.TypeOfTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeOfTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.TypeOfTour.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfTour.ForeColor = System.Drawing.Color.Black;
            this.TypeOfTour.IconColor = System.Drawing.Color.Black;
            this.TypeOfTour.ListBackColor = System.Drawing.Color.White;
            this.TypeOfTour.ListTextColor = System.Drawing.Color.Black;
            this.TypeOfTour.Location = new System.Drawing.Point(57, 229);
            this.TypeOfTour.MinimumSize = new System.Drawing.Size(200, 30);
            this.TypeOfTour.Name = "TypeOfTour";
            this.TypeOfTour.Size = new System.Drawing.Size(353, 58);
            this.TypeOfTour.TabIndex = 72;
            this.TypeOfTour.Texts = "";
            // 
            // Operators
            // 
            this.Operators.BackColor = System.Drawing.Color.White;
            this.Operators.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Operators.BorderRadius = 12;
            this.Operators.BorderSize = 0;
            this.Operators.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Operators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Operators.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Operators.ForeColor = System.Drawing.Color.Black;
            this.Operators.IconColor = System.Drawing.Color.Black;
            this.Operators.ListBackColor = System.Drawing.Color.White;
            this.Operators.ListTextColor = System.Drawing.Color.Black;
            this.Operators.Location = new System.Drawing.Point(566, 78);
            this.Operators.MinimumSize = new System.Drawing.Size(200, 30);
            this.Operators.Name = "Operators";
            this.Operators.Size = new System.Drawing.Size(353, 58);
            this.Operators.TabIndex = 71;
            this.Operators.Texts = "";
            // 
            // AddCity
            // 
            this.AddCity.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddCity.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.AddCity.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddCity.BorderRadius = 12;
            this.AddCity.BorderSize = 0;
            this.AddCity.FlatAppearance.BorderSize = 0;
            this.AddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCity.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCity.ForeColor = System.Drawing.Color.White;
            this.AddCity.Location = new System.Drawing.Point(1517, 274);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(172, 56);
            this.AddCity.TabIndex = 69;
            this.AddCity.Text = "Додати місто";
            this.AddCity.TextColor = System.Drawing.Color.White;
            this.AddCity.UseVisualStyleBackColor = false;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // Cities
            // 
            this.Cities.BackColor = System.Drawing.Color.White;
            this.Cities.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Cities.BorderRadius = 12;
            this.Cities.BorderSize = 0;
            this.Cities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.Cities.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cities.ForeColor = System.Drawing.Color.Black;
            this.Cities.IconColor = System.Drawing.Color.Black;
            this.Cities.ListBackColor = System.Drawing.Color.White;
            this.Cities.ListTextColor = System.Drawing.Color.Black;
            this.Cities.Location = new System.Drawing.Point(1346, 40);
            this.Cities.MinimumSize = new System.Drawing.Size(200, 30);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(296, 49);
            this.Cities.TabIndex = 62;
            this.Cities.Texts = "";
            // 
            // availableCity
            // 
            this.availableCity.BackColor = System.Drawing.Color.White;
            this.availableCity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.availableCity.BorderRadius = 12;
            this.availableCity.BorderSize = 0;
            this.availableCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.availableCity.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availableCity.ForeColor = System.Drawing.Color.Black;
            this.availableCity.IconColor = System.Drawing.Color.Black;
            this.availableCity.ListBackColor = System.Drawing.Color.White;
            this.availableCity.ListTextColor = System.Drawing.Color.Black;
            this.availableCity.Location = new System.Drawing.Point(566, 229);
            this.availableCity.MinimumSize = new System.Drawing.Size(200, 30);
            this.availableCity.Name = "availableCity";
            this.availableCity.Size = new System.Drawing.Size(353, 58);
            this.availableCity.TabIndex = 58;
            this.availableCity.Texts = "";
            // 
            // linkPhotoTB
            // 
            this.linkPhotoTB.BackColor = System.Drawing.Color.White;
            this.linkPhotoTB.BorderColor = System.Drawing.Color.Black;
            this.linkPhotoTB.BorderRadius = 0;
            this.linkPhotoTB.BorderSize = 1;
            this.linkPhotoTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkPhotoTB.IsPasswordChar = false;
            this.linkPhotoTB.IsPlaceHolder = false;
            this.linkPhotoTB.Location = new System.Drawing.Point(57, 521);
            this.linkPhotoTB.Multiline = false;
            this.linkPhotoTB.Name = "linkPhotoTB";
            this.linkPhotoTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.linkPhotoTB.PasswordChar = false;
            this.linkPhotoTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.linkPhotoTB.PlaceHolderText = "";
            this.linkPhotoTB.Size = new System.Drawing.Size(353, 58);
            this.linkPhotoTB.TabIndex = 51;
            this.linkPhotoTB.Texts = "";
            this.linkPhotoTB.UnderlineStyle = false;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.White;
            this.nameTB.BorderColor = System.Drawing.Color.Black;
            this.nameTB.BorderRadius = 1;
            this.nameTB.BorderSize = 1;
            this.nameTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.IsPasswordChar = false;
            this.nameTB.IsPlaceHolder = false;
            this.nameTB.Location = new System.Drawing.Point(57, 78);
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTB.PasswordChar = false;
            this.nameTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nameTB.PlaceHolderText = "";
            this.nameTB.Size = new System.Drawing.Size(353, 58);
            this.nameTB.TabIndex = 50;
            this.nameTB.Texts = "";
            this.nameTB.UnderlineStyle = false;
            this.nameTB._TextChanged += new System.EventHandler(this.nameTB__TextChanged);
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
            this.createTransportB.Location = new System.Drawing.Point(1437, 800);
            this.createTransportB.Name = "createTransportB";
            this.createTransportB.Size = new System.Drawing.Size(269, 106);
            this.createTransportB.TabIndex = 48;
            this.createTransportB.Text = "Створити транспорт";
            this.createTransportB.TextColor = System.Drawing.Color.White;
            this.createTransportB.UseVisualStyleBackColor = false;
            this.createTransportB.Click += new System.EventHandler(this.createTransportB_Click);
            // 
            // ClearTable
            // 
            this.ClearTable.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClearTable.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ClearTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ClearTable.BorderRadius = 12;
            this.ClearTable.BorderSize = 0;
            this.ClearTable.FlatAppearance.BorderSize = 0;
            this.ClearTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearTable.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTable.ForeColor = System.Drawing.Color.White;
            this.ClearTable.Location = new System.Drawing.Point(1517, 659);
            this.ClearTable.Name = "ClearTable";
            this.ClearTable.Size = new System.Drawing.Size(172, 56);
            this.ClearTable.TabIndex = 85;
            this.ClearTable.Text = "Очистити";
            this.ClearTable.TextColor = System.Drawing.Color.White;
            this.ClearTable.UseVisualStyleBackColor = false;
            this.ClearTable.Click += new System.EventHandler(this.ClearTable_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(558, 763);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 38);
            this.label9.TabIndex = 87;
            this.label9.Text = "Кількість турів";
            // 
            // countOfTour
            // 
            this.countOfTour.BackColor = System.Drawing.Color.White;
            this.countOfTour.BorderColor = System.Drawing.Color.Black;
            this.countOfTour.BorderRadius = 0;
            this.countOfTour.BorderSize = 1;
            this.countOfTour.IsPasswordChar = false;
            this.countOfTour.IsPlaceHolder = false;
            this.countOfTour.Location = new System.Drawing.Point(566, 827);
            this.countOfTour.Mask = "0000";
            this.countOfTour.Multiline = false;
            this.countOfTour.Name = "countOfTour";
            this.countOfTour.PasswordChar = false;
            this.countOfTour.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.countOfTour.PlaceHolderText = "";
            this.countOfTour.Size = new System.Drawing.Size(144, 58);
            this.countOfTour.TabIndex = 86;
            this.countOfTour.Texts = "";
            this.countOfTour.UnderlineStyle = false;
            // 
            // CreateNewTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1786, 992);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.countOfTour);
            this.Controls.Add(this.ClearTable);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CostM);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CountOfPeople);
            this.Controls.Add(this.childrenCount);
            this.Controls.Add(this.flightDate);
            this.Controls.Add(this.TypeOfTour);
            this.Controls.Add(this.Operators);
            this.Controls.Add(this.tourCityInfoTable);
            this.Controls.Add(this.AddCity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endDateD);
            this.Controls.Add(this.StartDateD);
            this.Controls.Add(this.Cities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.availableCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkPhotoTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.createTransportB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewTour";
            this.Text = "CreateNewStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tourCityInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private Design.RoundedButton createTransportB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Design.CustomTextBox nameTB;
        private Design.CustomTextBox linkPhotoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Design.TestComboBox availableCity;
        private System.Windows.Forms.Label label7;
        private Design.TestComboBox Cities;
        private System.Windows.Forms.DateTimePicker StartDateD;
        private System.Windows.Forms.DateTimePicker endDateD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Design.RoundedButton AddCity;
        private System.Windows.Forms.DataGridView tourCityInfoTable;
        private Design.TestComboBox Operators;
        private Design.TestComboBox TypeOfTour;
        private System.Windows.Forms.DateTimePicker flightDate;
        private Design.CustomMaskedTextBoxDate childrenCount;
        private Design.CustomMaskedTextBoxDate CountOfPeople;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Design.TestComboBox transfer;
        private Design.TestComboBox book;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private Design.CustomMaskedTextBoxDate CostM;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndD;
        private Design.RoundedButton ClearTable;
        private System.Windows.Forms.Label label9;
        private Design.CustomMaskedTextBoxDate countOfTour;
    }
}