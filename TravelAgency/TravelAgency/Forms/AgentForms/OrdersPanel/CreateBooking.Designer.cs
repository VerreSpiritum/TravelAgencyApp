using System.ComponentModel;

namespace TravelAgency
{
    partial class CreateBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pTours = new System.Windows.Forms.Panel();
            this.CTour = new TravelAgency.Design.CustomComboBox();
            this.pAddTour = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.addTour = new TravelAgency.Design.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.contractInfoTable = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.whatIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.createNewBookB = new TravelAgency.Design.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CClient = new TravelAgency.Design.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.to_where = new System.Windows.Forms.Label();
            this.from_where = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toWhere = new System.Windows.Forms.Label();
            this.fromWhere = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.transferA = new TravelAgency.Design.CustomComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pTours.SuspendLayout();
            this.pAddTour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть тур:";
            // 
            // pTours
            // 
            this.pTours.Controls.Add(this.CTour);
            this.pTours.Controls.Add(this.label1);
            this.pTours.Location = new System.Drawing.Point(37, 310);
            this.pTours.Name = "pTours";
            this.pTours.Size = new System.Drawing.Size(444, 181);
            this.pTours.TabIndex = 1;
            // 
            // CTour
            // 
            this.CTour.BackColor = System.Drawing.Color.White;
            this.CTour.BorderColor = System.Drawing.Color.Black;
            this.CTour.BorderSize = 0;
            this.CTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CTour.ForeColor = System.Drawing.Color.Black;
            this.CTour.IconColor = System.Drawing.Color.Black;
            this.CTour.ListBackColor = System.Drawing.Color.White;
            this.CTour.ListTextColor = System.Drawing.Color.DimGray;
            this.CTour.Location = new System.Drawing.Point(31, 97);
            this.CTour.MinimumSize = new System.Drawing.Size(200, 30);
            this.CTour.Name = "CTour";
            this.CTour.Size = new System.Drawing.Size(385, 59);
            this.CTour.TabIndex = 1;
            this.CTour.Texts = "";
            // 
            // pAddTour
            // 
            this.pAddTour.Controls.Add(this.label11);
            this.pAddTour.Controls.Add(this.addTour);
            this.pAddTour.Controls.Add(this.label2);
            this.pAddTour.Location = new System.Drawing.Point(37, 591);
            this.pAddTour.Name = "pAddTour";
            this.pAddTour.Size = new System.Drawing.Size(444, 181);
            this.pAddTour.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(31, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 36);
            this.label11.TabIndex = 50;
            this.label11.Text = "Оберіть додатковий тур:";
            // 
            // addTour
            // 
            this.addTour.BackColor = System.Drawing.Color.White;
            this.addTour.BorderColor = System.Drawing.Color.Black;
            this.addTour.BorderSize = 0;
            this.addTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.addTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addTour.ForeColor = System.Drawing.Color.Black;
            this.addTour.IconColor = System.Drawing.Color.Black;
            this.addTour.ListBackColor = System.Drawing.Color.White;
            this.addTour.ListTextColor = System.Drawing.Color.DimGray;
            this.addTour.Location = new System.Drawing.Point(31, 97);
            this.addTour.MinimumSize = new System.Drawing.Size(200, 30);
            this.addTour.Name = "addTour";
            this.addTour.Size = new System.Drawing.Size(385, 59);
            this.addTour.TabIndex = 1;
            this.addTour.Texts = "";
            this.addTour.OnSelectedIndexChanged += new System.EventHandler(this.addTour_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.contractInfoTable);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(636, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 754);
            this.panel2.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "Оберіть готель:";
            // 
            // contractInfoTable
            // 
            this.contractInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contractInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.contractInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.contractInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contractInfoTable.ColumnHeadersHeight = 100;
            this.contractInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.contractInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.No, this.NameEmployee, this.whatIt });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contractInfoTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.contractInfoTable.GridColor = System.Drawing.Color.White;
            this.contractInfoTable.Location = new System.Drawing.Point(3, 75);
            this.contractInfoTable.Name = "contractInfoTable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.contractInfoTable.RowHeadersWidth = 51;
            this.contractInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.contractInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.contractInfoTable.RowTemplate.Height = 50;
            this.contractInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contractInfoTable.Size = new System.Drawing.Size(660, 676);
            this.contractInfoTable.TabIndex = 49;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.HeaderText = "Місто";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.No.Width = 94;
            // 
            // NameEmployee
            // 
            this.NameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameEmployee.HeaderText = "Можливий готель";
            this.NameEmployee.MinimumWidth = 6;
            this.NameEmployee.Name = "NameEmployee";
            this.NameEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NameEmployee.Width = 197;
            // 
            // whatIt
            // 
            this.whatIt.HeaderText = "";
            this.whatIt.Name = "whatIt";
            this.whatIt.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 36);
            this.label3.TabIndex = 0;
            // 
            // createNewBookB
            // 
            this.createNewBookB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createNewBookB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createNewBookB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createNewBookB.BorderRadius = 12;
            this.createNewBookB.BorderSize = 0;
            this.createNewBookB.FlatAppearance.BorderSize = 0;
            this.createNewBookB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewBookB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createNewBookB.ForeColor = System.Drawing.Color.White;
            this.createNewBookB.Location = new System.Drawing.Point(1365, 756);
            this.createNewBookB.Name = "createNewBookB";
            this.createNewBookB.Size = new System.Drawing.Size(292, 105);
            this.createNewBookB.TabIndex = 51;
            this.createNewBookB.Text = "Додати бронь";
            this.createNewBookB.TextColor = System.Drawing.Color.White;
            this.createNewBookB.UseVisualStyleBackColor = false;
            this.createNewBookB.Click += new System.EventHandler(this.createNewBookB_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(37, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 181);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(24, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 36);
            this.label8.TabIndex = 2;
            this.label8.Text = "Клієнт:";
            // 
            // CClient
            // 
            this.CClient.BackColor = System.Drawing.Color.White;
            this.CClient.BorderColor = System.Drawing.Color.Black;
            this.CClient.BorderSize = 0;
            this.CClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CClient.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CClient.ForeColor = System.Drawing.Color.Black;
            this.CClient.IconColor = System.Drawing.Color.Black;
            this.CClient.ListBackColor = System.Drawing.Color.White;
            this.CClient.ListTextColor = System.Drawing.Color.DimGray;
            this.CClient.Location = new System.Drawing.Point(31, 97);
            this.CClient.MinimumSize = new System.Drawing.Size(200, 30);
            this.CClient.Name = "CClient";
            this.CClient.Size = new System.Drawing.Size(385, 59);
            this.CClient.TabIndex = 1;
            this.CClient.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 36);
            this.label4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.to_where);
            this.panel3.Controls.Add(this.from_where);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.toWhere);
            this.panel3.Controls.Add(this.fromWhere);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.transferA);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1325, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 635);
            this.panel3.TabIndex = 2;
            // 
            // to_where
            // 
            this.to_where.AutoSize = true;
            this.to_where.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to_where.Location = new System.Drawing.Point(24, 438);
            this.to_where.Name = "to_where";
            this.to_where.Size = new System.Drawing.Size(0, 36);
            this.to_where.TabIndex = 54;
            // 
            // from_where
            // 
            this.from_where.AutoSize = true;
            this.from_where.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from_where.Location = new System.Drawing.Point(24, 268);
            this.from_where.Name = "from_where";
            this.from_where.Size = new System.Drawing.Size(0, 36);
            this.from_where.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(24, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 36);
            this.label13.TabIndex = 52;
            this.label13.Text = "Куди:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(24, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 36);
            this.label12.TabIndex = 51;
            this.label12.Text = "Звідки:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(24, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 36);
            this.label10.TabIndex = 50;
            this.label10.Text = "Оберіть трансфер:";
            // 
            // toWhere
            // 
            this.toWhere.AutoSize = true;
            this.toWhere.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toWhere.Location = new System.Drawing.Point(24, 402);
            this.toWhere.Name = "toWhere";
            this.toWhere.Size = new System.Drawing.Size(0, 36);
            this.toWhere.TabIndex = 5;
            // 
            // fromWhere
            // 
            this.fromWhere.AutoSize = true;
            this.fromWhere.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromWhere.Location = new System.Drawing.Point(24, 254);
            this.fromWhere.Name = "fromWhere";
            this.fromWhere.Size = new System.Drawing.Size(0, 36);
            this.fromWhere.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 36);
            this.label7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 2;
            // 
            // transferA
            // 
            this.transferA.BackColor = System.Drawing.Color.White;
            this.transferA.BorderColor = System.Drawing.Color.Black;
            this.transferA.BorderSize = 0;
            this.transferA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.transferA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.transferA.ForeColor = System.Drawing.Color.Black;
            this.transferA.IconColor = System.Drawing.Color.Black;
            this.transferA.ListBackColor = System.Drawing.Color.White;
            this.transferA.ListTextColor = System.Drawing.Color.DimGray;
            this.transferA.Location = new System.Drawing.Point(24, 86);
            this.transferA.MinimumSize = new System.Drawing.Size(200, 30);
            this.transferA.Name = "transferA";
            this.transferA.Size = new System.Drawing.Size(322, 59);
            this.transferA.TabIndex = 1;
            this.transferA.Texts = "";
            this.transferA.OnSelectedIndexChanged += new System.EventHandler(this.transferA_OnSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 36);
            this.label5.TabIndex = 0;
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 873);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createNewBookB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pAddTour);
            this.Controls.Add(this.pTours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CreateBooking";
            this.pTours.ResumeLayout(false);
            this.pTours.PerformLayout();
            this.pAddTour.ResumeLayout(false);
            this.pAddTour.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractInfoTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label from_where;
        private System.Windows.Forms.Label to_where;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;

        private TravelAgency.Design.CustomComboBox transferA;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fromWhere;
        private System.Windows.Forms.Label toWhere;

        private System.Windows.Forms.Panel panel1;
        private TravelAgency.Design.CustomComboBox CClient;
        private System.Windows.Forms.Label label4;

        private TravelAgency.Design.RoundedButton createNewBookB;

        private System.Windows.Forms.DataGridViewTextBoxColumn whatIt;

        private TravelAgency.Design.CustomComboBox CTour;

        private System.Windows.Forms.DataGridView contractInfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameEmployee;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel pAddTour;
        private TravelAgency.Design.CustomComboBox addTour;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTours;

        #endregion
    }
}