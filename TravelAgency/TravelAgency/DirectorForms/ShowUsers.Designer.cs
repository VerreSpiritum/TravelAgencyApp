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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userInfoTable = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.editEmployee = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteEmployee = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.userPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoTable
            // 
            this.userInfoTable.AllowUserToAddRows = false;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.userInfoTable.BackgroundColor = System.Drawing.Color.White;
            this.userInfoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInfoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userInfoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Franklin Gothic Book", 20F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.userInfoTable.ColumnHeadersHeight = 70;
            this.userInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Password,
            this.AddUser,
            this.editEmployee,
            this.deleteEmployee});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userInfoTable.DefaultCellStyle = dataGridViewCellStyle33;
            this.userInfoTable.GridColor = System.Drawing.Color.White;
            this.userInfoTable.Location = new System.Drawing.Point(0, 0);
            this.userInfoTable.Name = "userInfoTable";
            this.userInfoTable.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.userInfoTable.RowHeadersWidth = 51;
            this.userInfoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.userInfoTable.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.userInfoTable.RowTemplate.Height = 50;
            this.userInfoTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInfoTable.Size = new System.Drawing.Size(720, 998);
            this.userInfoTable.TabIndex = 0;
            this.userInfoTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInfoTable_CellContentClick);
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
            // Password
            // 
            this.Password.HeaderText = "Пароль";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 200;
            // 
            // AddUser
            // 
            this.AddUser.HeaderText = "";
            this.AddUser.Image = global::TravelAgency.Properties.Resources.add_user;
            this.AddUser.MinimumWidth = 6;
            this.AddUser.Name = "AddUser";
            this.AddUser.ReadOnly = true;
            this.AddUser.Width = 24;
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
            this.userPanel.Size = new System.Drawing.Size(735, 974);
            this.userPanel.TabIndex = 1;
            // 
            // ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1538, 998);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewImageColumn AddUser;
        private System.Windows.Forms.DataGridViewImageColumn editEmployee;
        private System.Windows.Forms.DataGridViewImageColumn deleteEmployee;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel userPanel;
    }
}