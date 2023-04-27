namespace TravelAgency
{
    partial class ShowAddTour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tourInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateOfTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferIs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitiesIncludedInTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editTour = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteTour = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tourInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tourInfoTable
            // 
            this.tourInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tourInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.tourInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tourInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tourInfoTable.ColumnHeadersHeight = 70;
            this.tourInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tourInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransport,
            this.NameTour,
            this.OperTour,
            this.StartDateOfTour,
            this.DepartureCity,
            this.CountOfPeople,
            this.TransferIs,
            this.Cost,
            this.CitiesIncludedInTour,
            this.editTour,
            this.deleteTour});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourInfoTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.tourInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tourInfoTable.GridColor = System.Drawing.Color.White;
            this.tourInfoTable.Location = new System.Drawing.Point(0, 0);
            this.tourInfoTable.Name = "tourInfoTable";
            this.tourInfoTable.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tourInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tourInfoTable.RowHeadersWidth = 51;
            this.tourInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tourInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.tourInfoTable.RowTemplate.Height = 50;
            this.tourInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tourInfoTable.Size = new System.Drawing.Size(1429, 998);
            this.tourInfoTable.TabIndex = 0;
            this.tourInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInfoTable_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "1";
            this.dataGridViewImageColumn1.Image = global::TravelAgency.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "2";
            this.dataGridViewImageColumn2.Image = global::TravelAgency.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // IdTransport
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdTransport.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdTransport.HeaderText = "№";
            this.IdTransport.MinimumWidth = 6;
            this.IdTransport.Name = "IdTransport";
            this.IdTransport.ReadOnly = true;
            this.IdTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdTransport.Width = 35;
            // 
            // NameTour
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameTour.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameTour.HeaderText = "Назва туру";
            this.NameTour.MinimumWidth = 6;
            this.NameTour.Name = "NameTour";
            this.NameTour.ReadOnly = true;
            this.NameTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameTour.Width = 150;
            // 
            // OperTour
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperTour.DefaultCellStyle = dataGridViewCellStyle5;
            this.OperTour.HeaderText = "Оператор туру";
            this.OperTour.MinimumWidth = 6;
            this.OperTour.Name = "OperTour";
            this.OperTour.ReadOnly = true;
            this.OperTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OperTour.Width = 125;
            // 
            // StartDateOfTour
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StartDateOfTour.DefaultCellStyle = dataGridViewCellStyle6;
            this.StartDateOfTour.HeaderText = "Дата початку";
            this.StartDateOfTour.MinimumWidth = 6;
            this.StartDateOfTour.Name = "StartDateOfTour";
            this.StartDateOfTour.ReadOnly = true;
            this.StartDateOfTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDateOfTour.Width = 125;
            // 
            // DepartureCity
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DepartureCity.DefaultCellStyle = dataGridViewCellStyle7;
            this.DepartureCity.HeaderText = "Місто відправки";
            this.DepartureCity.MinimumWidth = 6;
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.ReadOnly = true;
            this.DepartureCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartureCity.Width = 150;
            // 
            // CountOfPeople
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountOfPeople.DefaultCellStyle = dataGridViewCellStyle8;
            this.CountOfPeople.HeaderText = "Кількість людей";
            this.CountOfPeople.MinimumWidth = 6;
            this.CountOfPeople.Name = "CountOfPeople";
            this.CountOfPeople.ReadOnly = true;
            this.CountOfPeople.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountOfPeople.Width = 125;
            // 
            // TransferIs
            // 
            this.TransferIs.HeaderText = "Трансфер";
            this.TransferIs.MinimumWidth = 6;
            this.TransferIs.Name = "TransferIs";
            this.TransferIs.ReadOnly = true;
            this.TransferIs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransferIs.Width = 110;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Ціна";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cost.Width = 75;
            // 
            // CitiesIncludedInTour
            // 
            this.CitiesIncludedInTour.HeaderText = "Включені міста";
            this.CitiesIncludedInTour.MinimumWidth = 6;
            this.CitiesIncludedInTour.Name = "CitiesIncludedInTour";
            this.CitiesIncludedInTour.ReadOnly = true;
            this.CitiesIncludedInTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CitiesIncludedInTour.Width = 200;
            // 
            // editTour
            // 
            this.editTour.HeaderText = "";
            this.editTour.Image = global::TravelAgency.Properties.Resources.edit;
            this.editTour.MinimumWidth = 6;
            this.editTour.Name = "editTour";
            this.editTour.ReadOnly = true;
            this.editTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editTour.Width = 24;
            // 
            // deleteTour
            // 
            this.deleteTour.HeaderText = "";
            this.deleteTour.Image = global::TravelAgency.Properties.Resources.delete;
            this.deleteTour.MinimumWidth = 6;
            this.deleteTour.Name = "deleteTour";
            this.deleteTour.ReadOnly = true;
            this.deleteTour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteTour.Width = 24;
            // 
            // ShowAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 998);
            this.Controls.Add(this.tourInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAddTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tourInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tourInfoTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateOfTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferIs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitiesIncludedInTour;
        private System.Windows.Forms.DataGridViewImageColumn editTour;
        private System.Windows.Forms.DataGridViewImageColumn deleteTour;
    }
}