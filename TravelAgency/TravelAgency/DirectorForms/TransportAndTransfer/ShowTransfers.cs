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
    public partial class ShowTransfers : Form, IViewShowTransfers
    {
        public ShowTransfers()
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
        public DataTable TransfersInfo { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteTransfer;
        public event EventHandler EditTransfer;

        #endregion

        private void AddToTable()
        {
            if (TransfersInfo != null)
            {
                foreach (DataRow row in TransfersInfo.Rows)
                {
                    transferInfoTable.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                }
            }
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == transferInfoTable.Columns["deleteTransfer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    IdT = (Int32)transferInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteTransfer?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        transferInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.ColumnIndex == transferInfoTable.Columns["editTransfer"].Index && e.RowIndex >= 0)
            {
                IdT = (Int32)transferInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditTransfer?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
