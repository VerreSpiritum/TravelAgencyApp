namespace TravelAgency
{
    partial class ShowUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.userPanel = new System.Windows.Forms.Panel();
            this.createUserB = new TravelAgency.Design.RoundedButton();
            this.talonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editEmployee = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteEmployee = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoTable
            // 
            this.userInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.userInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.userInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Franklin Gothic Book", 20F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.userInfoTable.ColumnHeadersHeight = 70;
            this.userInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talonID,
            this.Login,
            this.editEmployee,
            this.deleteEmployee});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userInfoTable.DefaultCellStyle = dataGridViewCellStyle13;
            this.userInfoTable.GridColor = System.Drawing.Color.White;
            this.userInfoTable.Location = new System.Drawing.Point(0, 0);
            this.userInfoTable.Name = "userInfoTable";
            this.userInfoTable.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.userInfoTable.RowHeadersWidth = 51;
            this.userInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.userInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.userInfoTable.RowTemplate.Height = 50;
            this.userInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInfoTable.Size = new System.Drawing.Size(720, 998);
            this.userInfoTable.TabIndex = 0;
            this.userInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInfoTable_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "1";
            this.dataGridViewImageColumn1.Image = global::TravelAgency.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
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
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::TravelAgency.Properties.Resources.delete;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 24;
            // 
            // userPanel
            // 
            this.userPanel.Location = new System.Drawing.Point(791, 12);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(735, 510);
            this.userPanel.TabIndex = 1;
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
            this.createUserB.Location = new System.Drawing.Point(1384, 810);
            this.createUserB.Name = "createUserB";
            this.createUserB.Size = new System.Drawing.Size(315, 98);
            this.createUserB.TabIndex = 48;
            this.createUserB.Text = "Додати нового користувача";
            this.createUserB.TextColor = System.Drawing.Color.White;
            this.createUserB.UseVisualStyleBackColor = false;
            this.createUserB.Click += new System.EventHandler(this.createUserB_Click);
            // 
            // talonID
            // 
            this.talonID.HeaderText = "№";
            this.talonID.MinimumWidth = 6;
            this.talonID.Name = "talonID";
            this.talonID.ReadOnly = true;
            this.talonID.Width = 200;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логін";
            this.Login.MinimumWidth = 6;
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Login.Width = 200;
            // 
            // editEmployee
            // 
            this.editEmployee.HeaderText = "";
            this.editEmployee.Image = global::TravelAgency.Properties.Resources.edit;
            this.editEmployee.MinimumWidth = 6;
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.ReadOnly = true;
            this.editEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editEmployee.Width = 24;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.HeaderText = "";
            this.deleteEmployee.Image = global::TravelAgency.Properties.Resources.delete;
            this.deleteEmployee.MinimumWidth = 6;
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.ReadOnly = true;
            this.deleteEmployee.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteEmployee.Width = 24;
            // 
            // ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1711, 975);
            this.Controls.Add(this.createUserB);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.userInfoTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.userInfoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userInfoTable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel userPanel;
        private Design.RoundedButton createUserB;
        private System.Windows.Forms.DataGridViewTextBoxColumn talonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewImageColumn editEmployee;
        private System.Windows.Forms.DataGridViewImageColumn deleteEmployee;
    }
}