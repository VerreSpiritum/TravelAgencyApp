using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency
{
    public partial class ShowAddTourToStaff : Form, IViewShowAddTourToStaff
    {
        DataTable table = new DataTable();
        public ShowAddTourToStaff()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm(DataTable dt)
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTable(dt);
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public int TalonNum { get; set; }
        public DataTable staffInfo { get; set; }
        public int CheckError { get; set; }

        #endregion

        private void AddToTable(DataTable dt)
        {
            table = dt;
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTime = (DateTime)row[7];

                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], dateTime.ToShortDateString(), row[8], row[9], row[11], row[12], row[13]);
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
        private void UpdateTable()
        {
            string query = "";
            query += tourName.Texts != "Усі" ? query == "" ? " name LIKE '" + tourName.Texts + "' " : "AND name LIKE '" + tourName.Texts + "' " : string.Empty;
            query += OperatorName.Texts != "Усі" ? query == "" ? " operator LIKE '" + OperatorName.Texts + "' " : "AND operator LIKE '" + OperatorName.Texts + "' " : string.Empty;
            query += TypeOfTour.Texts != "Усі" ? query == "" ? " type_of_tour LIKE '" + TypeOfTour.Texts + "' " : "AND type_of_tour LIKE '" + TypeOfTour.Texts + "' " : string.Empty;

            DataRow[] filteredRows = table.Select(query);


            tour.Rows.Clear();

            foreach (DataRow row in filteredRows)
            {
                DateTime dateTime = (DateTime)row[7];

                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], dateTime.ToShortDateString(), row[8], row[9], row[11], row[12], row[13]);
            }
        }

        private void tourName_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
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
            if(result == DialogResult.Yes)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int ID = (int)tour.Rows[e.RowIndex].Cells[0].Value;
                    string link = string.Empty;
                    foreach(DataRow row  in table.Rows)
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
                        catch(Exception) 
                        {
                           MessageBox.Show("Відкрити посилання не вдалося!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }
    }
}
