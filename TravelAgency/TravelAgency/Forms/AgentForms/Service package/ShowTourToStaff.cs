using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency
{
    public partial class ShowTourToStaff : Form, IViewShowTourToStaff
    {
        private DataTable table= new DataTable();
        public ShowTourToStaff()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm(DataTable dt)
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTable(dt);

            table = dt;

            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        #endregion

        private void AddToTable(DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                DateTime dateTime = (DateTime)row[9];

                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], dateTime.ToShortDateString(), row[10], row[11], row[13], row[14], row[15]);
                tourName.Items.Add(row[1]);
            }
            tourName.Texts = OperatorName.Texts = TypeOfTour.Texts = "Усі";
            tourName.Items.Add("Усі");
            OperatorName.Items.Add("Усі");
            TypeOfTour.Items.Add("Усі");
            List<string> oper = new List<string>() { "Anex", "Join UPI", "TUI", "Coral Travel", "Pegas Touristik", "TEZ Tour", "TPG", "Компас" };
            List<string> typeOfTour = new List<string>() { "Весільний", "Екотур", "Екстремальний", "Гастро-тур", "Індивідуальний", "Тур Україною",
                "Гірськолижний", "Круїз", "Тур вихідного дня", "Сімейний", "Відпочинок"};
            OperatorName.Items.AddRange(oper.ToArray());
            TypeOfTour.Items.AddRange(typeOfTour.ToArray());
        }

        private void tourName_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void UpdateTable()
        {
            string query = "";
            query += tourName.Texts != "Усі" ? query == "" ? " name LIKE '" + tourName.Texts +"' ": "AND name LIKE '" + tourName.Texts + "' " : string.Empty;
            query += OperatorName.Texts != "Усі" ? query == "" ? " operator LIKE '" + OperatorName.Texts + "' " : "AND operator LIKE '" + OperatorName.Texts + "' " : string.Empty;
            query += TypeOfTour.Texts != "Усі" ? query ==""? " type_of_tour LIKE '" + TypeOfTour.Texts + "' ": "AND type_of_tour LIKE '" + TypeOfTour.Texts + "' " : string.Empty;

            DataRow[] filteredRows = table.Select(query);


            tour.Rows.Clear();

            foreach (DataRow row in filteredRows)
            {
                DateTime dateTime = (DateTime)row[9];

                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], dateTime.ToShortDateString(), row[10], row[11], row[13], row[14], row[15]);
            }
        }

        private void OperatorName_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void TypeOfTour_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Відкрити посилання на фотографії?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int ID = (int)tour.Rows[e.RowIndex].Cells[0].Value;
                    string link = string.Empty;
                    foreach (DataRow row in table.Rows)
                    {
                        if ((int)row[0] == ID)
                            link = row[10].ToString();
                    }
                    if (!string.IsNullOrEmpty(link))
                    {
                        try
                        {
                            Process.Start(link);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Відкрити посилання не вдалося!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }
    }
}
