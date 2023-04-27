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
    public partial class ShowHotels : Form, IViewShowHotels
    {
        public ShowHotels()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            if(ListOfHotels.Rows.Count != 0)
                AddToTable();
            
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public int ID { get; set; }
        public DataTable ListOfHotels { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteHotel;
        public event EventHandler EditHotel;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in ListOfHotels.Rows) 
            {
                hotelInfoTable.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }

        private void hotelInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == hotelInfoTable.Columns["deleteHotel"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    ID = (Int32)hotelInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteHotel?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hotelInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.ColumnIndex == hotelInfoTable.Columns["editHotel"].Index && e.RowIndex >= 0)
            {
                ID = (Int32)hotelInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditHotel?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
