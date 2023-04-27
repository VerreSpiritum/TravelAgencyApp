namespace TravelAgency
{
    partial class ShowHotels
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
            this.hotelInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationInCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Settelments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferIs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editHotel = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteHotel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotelInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelInfoTable
            // 
            this.hotelInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hotelInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.hotelInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hotelInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hotelInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.hotelInfoTable.ColumnHeadersHeight = 70;
            this.hotelInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.hotelInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransport,
            this.NameHotel,
            this.Category,
            this.City,
            this.LocationInCity,
            this.Settelments,
            this.TransferIs,
            this.Photos,
            this.editHotel,
            this.deleteHotel});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelInfoTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.hotelInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotelInfoTable.GridColor = System.Drawing.Color.White;
            this.hotelInfoTable.Location = new System.Drawing.Point(0, 0);
            this.hotelInfoTable.Name = "hotelInfoTable";
            this.hotelInfoTable.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotelInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.hotelInfoTable.RowHeadersWidth = 51;
            this.hotelInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.hotelInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.hotelInfoTable.RowTemplate.Height = 50;
            this.hotelInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hotelInfoTable.Size = new System.Drawing.Size(1429, 998);
            this.hotelInfoTable.TabIndex = 0;
            this.hotelInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotelInfoTable_CellContentClick);
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
            // NameHotel
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameHotel.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameHotel.HeaderText = "Назва готелю";
            this.NameHotel.MinimumWidth = 6;
            this.NameHotel.Name = "NameHotel";
            this.NameHotel.ReadOnly = true;
            this.NameHotel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameHotel.Width = 200;
            // 
            // Category
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Category.DefaultCellStyle = dataGridViewCellStyle5;
            this.Category.HeaderText = "Категорія";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Category.Width = 125;
            // 
            // City
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.City.DefaultCellStyle = dataGridViewCellStyle6;
            this.City.HeaderText = "Місто";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.City.Width = 170;
            // 
            // LocationInCity
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LocationInCity.DefaultCellStyle = dataGridViewCellStyle7;
            this.LocationInCity.HeaderText = "Адреса";
            this.LocationInCity.MinimumWidth = 6;
            this.LocationInCity.Name = "LocationInCity";
            this.LocationInCity.ReadOnly = true;
            this.LocationInCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationInCity.Width = 150;
            // 
            // Settelments
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Settelments.DefaultCellStyle = dataGridViewCellStyle8;
            this.Settelments.HeaderText = "Поселення";
            this.Settelments.MinimumWidth = 6;
            this.Settelments.Name = "Settelments";
            this.Settelments.ReadOnly = true;
            this.Settelments.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Settelments.Width = 150;
            // 
            // TransferIs
            // 
            this.TransferIs.HeaderText = "Зручності";
            this.TransferIs.MinimumWidth = 6;
            this.TransferIs.Name = "TransferIs";
            this.TransferIs.ReadOnly = true;
            this.TransferIs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransferIs.Width = 200;
            // 
            // Photos
            // 
            this.Photos.HeaderText = "Фото";
            this.Photos.MinimumWidth = 6;
            this.Photos.Name = "Photos";
            this.Photos.ReadOnly = true;
            this.Photos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Photos.Width = 150;
            // 
            // editHotel
            // 
            this.editHotel.HeaderText = "";
            this.editHotel.Image = global::TravelAgency.Properties.Resources.edit;
            this.editHotel.MinimumWidth = 6;
            this.editHotel.Name = "editHotel";
            this.editHotel.ReadOnly = true;
            this.editHotel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editHotel.Width = 24;
            // 
            // deleteHotel
            // 
            this.deleteHotel.HeaderText = "";
            this.deleteHotel.Image = global::TravelAgency.Properties.Resources.delete;
            this.deleteHotel.MinimumWidth = 6;
            this.deleteHotel.Name = "deleteHotel";
            this.deleteHotel.ReadOnly = true;
            this.deleteHotel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteHotel.Width = 24;
            // 
            // ShowHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 998);
            this.Controls.Add(this.hotelInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.hotelInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hotelInfoTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationInCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Settelments;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferIs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photos;
        private System.Windows.Forms.DataGridViewImageColumn editHotel;
        private System.Windows.Forms.DataGridViewImageColumn deleteHotel;
    }
}