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
            
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTable();
            this.Show();
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


        public event EventHandler DeleteUser;
        public event EventHandler EditUser;
        public event EventHandler CreateUser;

        #endregion

        private void AddToTable()
        {
            
            userInfoTable.Rows.Add( "Agent", "dsfgdfsg");

            //foreach (DataRow row in staffInfo.Rows) 
            //{
            //    DateTime birthDate = Convert.ToDateTime(row["Дата народження"]);
            //    DateTime startDate = Convert.ToDateTime(row["Дата народження"]);

            //    staffInfoTable.Rows.Add(row["№"], row["ФІО"], row["Посада"], row["Стать"], birthDate.ToString("dd/MM/yyyy"), startDate.ToString("dd/MM/yyyy"), row["Зарплатня"], row["Номер телефону"]);
            //}
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == userInfoTable.Columns["deleteEmployee"].Index && e.RowIndex >= 0)
            {
                //TalonNum = (Int32)staffInfoTable.Rows[e.RowIndex].Cells[0].Value;
                DeleteUser?.Invoke(this, EventArgs.Empty);
                if (CheckError == 1)
                {
                    MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userInfoTable.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(e.ColumnIndex == userInfoTable.Columns["editEmployee"].Index && e.RowIndex >= 0)
            {
                LoginToAccess = (string)userInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditUser?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
