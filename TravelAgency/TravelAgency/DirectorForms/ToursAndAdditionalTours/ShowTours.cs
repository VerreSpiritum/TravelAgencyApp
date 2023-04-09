using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency
{
    public partial class ShowTours : Form, IViewShowTours
    {
        public ShowTours()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            if(ListOfTours.Rows.Count != 0)
                AddToTable();
            
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public int ID { get; set; }
        public DataTable ListOfTours { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteTour;
        public event EventHandler EditTour;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in ListOfTours.Rows) 
            {
                DateTime date = Convert.ToDateTime(row[3]);
                tourInfoTable.Rows.Add(row[0], row[1], row[2], date.Year, row[4], row[5], row[6], row[7], row[8], row[9], row[10]);
            }
        }

        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tourInfoTable.Columns["deleteTour"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    ID = (Int32)tourInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteTour?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tourInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.ColumnIndex == tourInfoTable.Columns["editTour"].Index && e.RowIndex >= 0)
            {
                ID = (Int32)tourInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditTour?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
