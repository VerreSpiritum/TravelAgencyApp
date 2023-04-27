namespace TravelAgency
{
    partial class ConcludedContracts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBtn = new TravelAgency.Design.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.staffInfoTable = new System.Windows.Forms.DataGridView();
            this.IdStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfContracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBtn.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchBtn.BorderRadius = 12;
            this.SearchBtn.BorderSize = 0;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(791, 40);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(215, 78);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Сгенерувати";
            this.SearchBtn.TextColor = System.Drawing.Color.White;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(356, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кінець періоду";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Початок періоду";
            // 
            // end
            // 
            this.end.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.end.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.end.Location = new System.Drawing.Point(362, 50);
            this.end.MinimumSize = new System.Drawing.Size(4, 55);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(297, 55);
            this.end.TabIndex = 8;
            // 
            // start
            // 
            this.start.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.start.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(11, 50);
            this.start.MinimumSize = new System.Drawing.Size(4, 55);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(297, 55);
            this.start.TabIndex = 7;
            // 
            // staffInfoTable
            // 
            this.staffInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.staffInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.staffInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.staffInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.staffInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffInfoTable.ColumnHeadersHeight = 80;
            this.staffInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStaff,
            this.Name,
            this.CountOfContracts,
            this.sum,
            this.StartDate,
            this.EndDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInfoTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.staffInfoTable.GridColor = System.Drawing.Color.White;
            this.staffInfoTable.Location = new System.Drawing.Point(-1, 147);
            this.staffInfoTable.Name = "staffInfoTable";
            this.staffInfoTable.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.staffInfoTable.RowHeadersWidth = 51;
            this.staffInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.staffInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.staffInfoTable.RowTemplate.Height = 50;
            this.staffInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.staffInfoTable.Size = new System.Drawing.Size(1431, 840);
            this.staffInfoTable.TabIndex = 6;
            this.staffInfoTable.Visible = false;
            // 
            // IdStaff
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdStaff.HeaderText = "№";
            this.IdStaff.MinimumWidth = 6;
            this.IdStaff.Name = "IdStaff";
            this.IdStaff.ReadOnly = true;
            this.IdStaff.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdStaff.Width = 60;
            // 
            // Name
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Name.DefaultCellStyle = dataGridViewCellStyle4;
            this.Name.HeaderText = "ПІБ";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name.Width = 350;
            // 
            // CountOfContracts
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CountOfContracts.DefaultCellStyle = dataGridViewCellStyle5;
            this.CountOfContracts.HeaderText = "Кількість контрактів";
            this.CountOfContracts.MinimumWidth = 6;
            this.CountOfContracts.Name = "CountOfContracts";
            this.CountOfContracts.ReadOnly = true;
            this.CountOfContracts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountOfContracts.Width = 150;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сума";
            this.sum.MinimumWidth = 6;
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Width = 125;
            // 
            // StartDate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.StartDate.HeaderText = "З";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDate.Width = 150;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "По";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 150;
            // 
            // ConcludedContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 998);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.staffInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "ConcludedContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AllSalaries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Design.RoundedButton SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DataGridView staffInfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}