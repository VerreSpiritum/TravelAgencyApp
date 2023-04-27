using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency
{
    public partial class ShowHotelsToStaff : Form, IViewShowHotelsToStaff
    {
        public DataTable table;
        public ShowHotelsToStaff()
        {
            InitializeComponent();
            Period.Height = 62;
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

        #endregion

        private void AddToTable(DataTable dt)
        {
            table = dt;

            foreach (DataRow row in dt.Rows)
            { 
                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
                
            }
            List<string> categories = new List<string> { "Мотель", "Туристський клас", "Стандратний клас", "Комфортний клас", "Перший клас", "Люкс" };
            List<string> categoriesR = new List<string> { "Одномісний", "Двомісний", "Тримісний", "Чотиримісний", "З ліжком розміру qeen-size", "Королівський номер", "Номер твін", "Голлівудський номер Твін", "Двомісний з окремими двомісними ліжками", "Студія", "Напівлюкс", "Президентський номер", "Апартаменти",
            "Суміжний номер", "Номер з ліжком Мерфі", "Доступний номер", "Номер з виходом до басейну", "Вілла", "Кімната для курців" };
            
            List<string> mealsType = new List<string> { "Без харчування (OR)", "Тільки сніданок (BB)", "Сніданок + вечеря (HB/FB)", "Все включено (AL)", "Ультра все включено (UAL)" };
            hotelCategory.Items.AddRange(categories.ToArray());
            Room.Items.AddRange(categoriesR.ToArray());
            Meal.Items.AddRange(mealsType.ToArray());
            
            Room.Items.Add("Усі");
            Meal.Items.Add("Усі");
            hotelCategory.Items.Add("Усі");
            Room.Texts = Meal.Texts = hotelCategory.Texts = "Усі";
        }
        private void UpdateTable()
        {
            
            string query = "";
            query += hotelCategory.Texts != "Усі" ? query == "" ? $"{table.Columns[1].ColumnName} LIKE '" + hotelCategory.Texts + "' " : $"AND {table.Columns[1].ColumnName} LIKE '" + hotelCategory.Texts + "' " : string.Empty;
            query += Room.Texts != "Усі" ? query == "" ? $"{table.Columns[4].ColumnName} operator LIKE '" + Room.Texts + "' " : $"AND {table.Columns[4].ColumnName} LIKE '" + Room.Texts + "' " : string.Empty;
            query += Meal.Texts != "Усі" ? query == "" ? $"{table.Columns[5].ColumnName} LIKE '" + Meal.Texts + "' " : $"AND {table.Columns[5].ColumnName} LIKE '" + Meal.Texts + "' " : string.Empty;
            query += Period.Text != "  .  .     -   .  ." ? query == "" ? $"{table.Columns[6].ColumnName} LIKE '" + Period.Text + "' " : $"AND {table.Columns[6].ColumnName} LIKE '" + Period.Text + "' " : string.Empty;


            DataRow[] filteredRows = table.Select(query);


            tour.Rows.Clear();

            foreach (DataRow row in filteredRows)
            {
                tour.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9]);
            }
        }
        private void staffInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void hotelCategory_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void Room_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void Meal_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
        private void Period_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        private void Period_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 8)
                {
                    DataGridViewCell cell = tour.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    try
                    {
                        Clipboard.SetText(cell.Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Інформацію скопійовано!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
