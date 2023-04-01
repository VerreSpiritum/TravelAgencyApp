using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class ShowStaff : Form, IViewListOfAllStaff
    {
        public ShowStaff()
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

        public int TalonNum { get; set; }
        public DataTable staffInfo { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteEmployee;
        public event EventHandler EditEmployee;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in staffInfo.Rows) 
            {
                DateTime birthDate = Convert.ToDateTime(row["Дата народження"]);
                DateTime startDate = Convert.ToDateTime(row["Дата народження"]);

                staffInfoTable.Rows.Add(row["№"], row["ФІО"], row["Посада"], row["Стать"], birthDate.ToString("dd/MM/yyyy"), startDate.ToString("dd/MM/yyyy"), row["Зарплатня"], row["Номер телефону"]);
            }
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == staffInfoTable.Columns["deleteEmployee"].Index && e.RowIndex >= 0)
            {
                TalonNum = (Int32)staffInfoTable.Rows[e.RowIndex].Cells[0].Value;
                DeleteEmployee?.Invoke(this, EventArgs.Empty);
                if (CheckError == 1)
                {
                    MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staffInfoTable.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(e.ColumnIndex == staffInfoTable.Columns["editEmployee"].Index && e.RowIndex >= 0)
            {
                TalonNum = (Int32)staffInfoTable.Rows[e.RowIndex].Cells[0].Value;

                EditEmployee?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
