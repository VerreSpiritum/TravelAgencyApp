namespace TravelAgency
{
    partial class ShowTransports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transportInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoAboutTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotosTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransportFacilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editTransport = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteTransport = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transportInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // transportInfoTable
            // 
            this.transportInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transportInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.transportInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transportInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.transportInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transportInfoTable.ColumnHeadersHeight = 70;
            this.transportInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transportInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransport,
            this.NameTransport,
            this.InfoAboutTransport,
            this.YearOfProduction,
            this.CountOfSeats,
            this.PhotosTransport,
            this.TransportFacilities,
            this.editTransport,
            this.deleteTransport});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transportInfoTable.DefaultCellStyle = dataGridViewCellStyle10;
            this.transportInfoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transportInfoTable.GridColor = System.Drawing.Color.White;
            this.transportInfoTable.Location = new System.Drawing.Point(0, 0);
            this.transportInfoTable.Name = "transportInfoTable";
            this.transportInfoTable.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transportInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.transportInfoTable.RowHeadersWidth = 51;
            this.transportInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.transportInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.transportInfoTable.RowTemplate.Height = 50;
            this.transportInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transportInfoTable.Size = new System.Drawing.Size(1294, 998);
            this.transportInfoTable.TabIndex = 0;
            this.transportInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInfoTable_CellContentClick);
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
            this.IdTransport.Width = 60;
            // 
            // NameTransport
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameTransport.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameTransport.HeaderText = "Назва транспорта";
            this.NameTransport.MinimumWidth = 6;
            this.NameTransport.Name = "NameTransport";
            this.NameTransport.ReadOnly = true;
            this.NameTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameTransport.Width = 200;
            // 
            // InfoAboutTransport
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InfoAboutTransport.DefaultCellStyle = dataGridViewCellStyle5;
            this.InfoAboutTransport.HeaderText = "Коротка інформація";
            this.InfoAboutTransport.MinimumWidth = 6;
            this.InfoAboutTransport.Name = "InfoAboutTransport";
            this.InfoAboutTransport.ReadOnly = true;
            this.InfoAboutTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoAboutTransport.Width = 150;
            // 
            // YearOfProduction
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.YearOfProduction.DefaultCellStyle = dataGridViewCellStyle6;
            this.YearOfProduction.HeaderText = "Рік випуску";
            this.YearOfProduction.MinimumWidth = 6;
            this.YearOfProduction.Name = "YearOfProduction";
            this.YearOfProduction.ReadOnly = true;
            this.YearOfProduction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YearOfProduction.Width = 125;
            // 
            // CountOfSeats
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountOfSeats.DefaultCellStyle = dataGridViewCellStyle7;
            this.CountOfSeats.HeaderText = "Кількість місць";
            this.CountOfSeats.MinimumWidth = 6;
            this.CountOfSeats.Name = "CountOfSeats";
            this.CountOfSeats.ReadOnly = true;
            this.CountOfSeats.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountOfSeats.Width = 150;
            // 
            // PhotosTransport
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhotosTransport.DefaultCellStyle = dataGridViewCellStyle8;
            this.PhotosTransport.HeaderText = "Фото транспорту";
            this.PhotosTransport.MinimumWidth = 6;
            this.PhotosTransport.Name = "PhotosTransport";
            this.PhotosTransport.ReadOnly = true;
            this.PhotosTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PhotosTransport.Width = 250;
            // 
            // TransportFacilities
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TransportFacilities.DefaultCellStyle = dataGridViewCellStyle9;
            this.TransportFacilities.HeaderText = "Зручності";
            this.TransportFacilities.MinimumWidth = 6;
            this.TransportFacilities.Name = "TransportFacilities";
            this.TransportFacilities.ReadOnly = true;
            this.TransportFacilities.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TransportFacilities.Width = 139;
            // 
            // editTransport
            // 
            this.editTransport.HeaderText = "";
            this.editTransport.Image = global::TravelAgency.Properties.Resources.edit;
            this.editTransport.MinimumWidth = 6;
            this.editTransport.Name = "editTransport";
            this.editTransport.ReadOnly = true;
            this.editTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editTransport.Width = 24;
            // 
            // deleteTransport
            // 
            this.deleteTransport.HeaderText = "";
            this.deleteTransport.Image = global::TravelAgency.Properties.Resources.delete;
            this.deleteTransport.MinimumWidth = 6;
            this.deleteTransport.Name = "deleteTransport";
            this.deleteTransport.ReadOnly = true;
            this.deleteTransport.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteTransport.Width = 24;
            // 
            // ShowTransports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 998);
            this.Controls.Add(this.transportInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowTransports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.transportInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transportInfoTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoAboutTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotosTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransportFacilities;
        private System.Windows.Forms.DataGridViewImageColumn editTransport;
        private System.Windows.Forms.DataGridViewImageColumn deleteTransport;
    }
}