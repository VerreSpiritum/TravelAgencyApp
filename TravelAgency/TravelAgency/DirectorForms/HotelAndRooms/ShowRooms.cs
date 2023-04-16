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
    public partial class ShowRooms : Form, IViewShowRooms
    {
        public ShowRooms()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            if(ListOfRooms.Rows.Count != 0)
                AddToTable();
            
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public int ID { get; set; }
        public DataTable ListOfRooms { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteRoom;
        public event EventHandler EditRoom;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in ListOfRooms.Rows) 
            {
                roomInfoTable.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }

        private void roomInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == roomInfoTable.Columns["deleteRoom"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(result == DialogResult.OK)
                {
                    ID = (Int32)roomInfoTable.Rows[e.RowIndex].Cells[0].Value;
                    DeleteRoom?.Invoke(this, EventArgs.Empty);
                    if (CheckError == 1)
                    {
                        MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        roomInfoTable.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(e.ColumnIndex == roomInfoTable.Columns["editRoom"].Index && e.RowIndex >= 0)
            {
                ID = (Int32)roomInfoTable.Rows[e.RowIndex].Cells[0].Value;
                EditRoom?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
