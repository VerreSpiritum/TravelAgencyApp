using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency
{
    public partial class ShowBooking : Form, IViewShowBookings
    {
        public ShowBooking()
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
        public DataTable bookingInfo { get; set; }
        public int CheckError { get; set; }

        public event EventHandler DeleteBooking;
        public event EventHandler AddContract;

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in bookingInfo.Rows) 
            {
                if (!emailCB.Items.Contains(row[2]))
                    emailCB.Items.Add(row[2]);
                bookingInfoTable.Rows.Add(row.ItemArray);
            }
            emailCB.Items.Add("Усе");
            emailCB.Texts = "Усе";
            contractCB.Items.Add("Є");
            contractCB.Items.Add("Немає");
            contractCB.Items.Add("Усе");
            contractCB.Texts = "Усе";


        }

        private void bookingInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bookingInfoTable.Columns["deleteEmployee"].Index && e.RowIndex >= 0)
            {
                if (bookingInfoTable.Rows[e.RowIndex].Cells[7].Value.Equals("Є"))
                    MessageBox.Show("Видалення неможливе! Бронювання вже було оформлено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Підтвердити видалення", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        TalonNum = (Int32)bookingInfoTable.Rows[e.RowIndex].Cells[0].Value;
                        DeleteBooking?.Invoke(this, EventArgs.Empty);
                        if (CheckError == 1)
                        {
                            MessageBox.Show("Успішно видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bookingInfoTable.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Виникла помилка під час видалення!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (e.ColumnIndex == bookingInfoTable.Columns["editEmployee"].Index && e.RowIndex >= 0)
            {
                TalonNum = (Int32)bookingInfoTable.Rows[e.RowIndex].Cells[0].Value;
                AddContract?.Invoke(this, EventArgs.Empty);
            }
        }

        private void emailCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void contractCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable()
        {
            bookingInfoTable.Rows.Clear();
            if(emailCB.Texts != "Усе" || contractCB.Texts != "Усе")
            {

                if(emailCB.Texts != "Усе" && contractCB.Texts != "Усе")
                {
                    foreach (DataRow row in bookingInfo.Rows)
                    {
                        if (row[2].Equals(emailCB.Texts) && row[7].Equals(contractCB.Texts))
                            bookingInfoTable.Rows.Add(row.ItemArray);
                    }
                }
                else if(emailCB.Texts != "Усе" && contractCB.Texts == "Усе")
                {
                    foreach (DataRow row in bookingInfo.Rows)
                    {
                        if (row[2].Equals(emailCB.Texts))
                            bookingInfoTable.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    foreach (DataRow row in bookingInfo.Rows)
                    {
                        if (row[7].Equals(contractCB.Texts))
                            bookingInfoTable.Rows.Add(row.ItemArray);
                    }
                }
            }
            else
            {
                foreach (DataRow row in bookingInfo.Rows)
                {
                    bookingInfoTable.Rows.Add(row.ItemArray);
                }
            }
        }
    }
}
