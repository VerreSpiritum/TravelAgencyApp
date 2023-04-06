using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class ShowUsers : Form, IViewShowUsers
    {
        public ShowUsers()
        {
            InitializeComponent();
            createUserB.BackColor = ColorTranslator.FromHtml("#006C79");
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Show();
        }
        public void RefreshTable()
        {
            userInfoTable.Rows.Clear();
            AddToTable();
        }
        public void CloseForm()
        {
            this.Close();
        }
        public void addOnPanelForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            form.Dock = DockStyle.Fill;
            userPanel.Controls.Add(form);
        }
        

        public DataTable userInfo { get; set; }
        public int CheckError { get; set; }
        public string LoginToAccess { get; set; }
        public int TalonNum { get; set; }


        public event EventHandler DeleteUser;
        public event EventHandler EditUser;
        public event EventHandler CreateUser;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in userInfo.Rows) 
            {
                userInfoTable.Rows.Add(row["№"], row["Логін"]);
            }
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == userInfoTable.Columns["deleteEmployee"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {   
                    TalonNum = (Int32)userInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteUser?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }  
            }
            else if(e.ColumnIndex == userInfoTable.Columns["editEmployee"].Index && e.RowIndex >= 0)
            {
                LoginToAccess = (string)userInfoTable.Rows[e.RowIndex].Cells[1].Value;
                EditUser?.Invoke(this, EventArgs.Empty);
            }
        }

        private void createUserB_Click(object sender, EventArgs e)
        {
            CreateUser?.Invoke(this, EventArgs.Empty);
        }
    }
}
