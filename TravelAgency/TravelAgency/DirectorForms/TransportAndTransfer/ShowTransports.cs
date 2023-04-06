using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency
{
    public partial class ShowTransports : Form, IViewShowTransports
    {
        public ShowTransports()
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

        public int IdT { get; set; }
        public DataTable TransportInfo { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteTransport;
        public event EventHandler EditTransport;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in TransportInfo.Rows) 
            {
                DateTime date = Convert.ToDateTime(row[3]);
                transportInfoTable.Rows.Add(row[0], row[1], row[2], date.Year, row[4], row[5], row[6]);
            }
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == transportInfoTable.Columns["deleteTransport"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    IdT = (Int32)transportInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteTransport?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transportInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.ColumnIndex == transportInfoTable.Columns["editTransport"].Index && e.RowIndex >= 0)
            {
                IdT = (Int32)transportInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditTransport?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
