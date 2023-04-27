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
    public partial class ShowClients : Form, IViewListOfAllClients
    {
        public ShowClients()
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
        public DataTable clientInfo { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteCustomer;
        #endregion

        private void AddToTable()
        {
            foreach(DataRow row in clientInfo.Rows)
            {
                clientInfoTable.Rows.Add(row.ItemArray);
            }
        }

        private void clientInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clientInfoTable.Columns["deleteEmployee"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    TalonNum = (Int32)clientInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteCustomer?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clientInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
