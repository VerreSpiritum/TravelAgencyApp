using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews.HotelAndRooms;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency
{
    public partial class CreateNewHotel : Form, IViewCreateHotel
    {
        private List<string> facility = new List<string>();
        private List<CheckBox> radioButtons = new List<CheckBox>();

        public CreateNewHotel()
        {
            InitializeComponent();
            CreateNewBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }

        #region --- Реализация интерфейса ---
        public List<string> Facilities { get => facility; set => facility = value; }
        public DataTable facilites { get; set; }
        public List<string> cities { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Photo { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Error { get; set; }

        public void ShowForm()
        {
            AddFacilities();
            List<string> categories = new List<string> { "Мотель", "Туристський клас", "Стандратний клас", "Комфортний клас", "Перший клас", "Люкс" };
            hotelCategory.Items.AddRange(categories.ToArray());
            hotelCategory.Texts = "Мотель";
            city.Items.AddRange(cities.ToArray());
            city.Texts = "Одеса";

            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler CreateHotel;
        #endregion
        private void AddFacilities()
        {
            CheckBox radioButton;
            if (facilites != null)
            {
                foreach (DataRow row in facilites.Rows)
                {
                    radioButton = new CheckBox();
                    radioButton.Text = row[1].ToString();
                    radioButtons.Add(radioButton);
                }
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    radioButtons[i].Font = new Font("Franklin Gothic Book", 20);
                    radioButtons[i].ForeColor = Color.Black;
                    radioButtons[i].Size = new Size(250, 35);
                    radioButtons[i].Visible = true;
                    radioButtons[i].FlatStyle = FlatStyle.Popup;
                    panel1.Controls.Add(radioButtons[i]);
                    //this.Controls.Add(radioButtons[i]);
                }
            }
        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {
            InsertFacilities();
            if(!String.IsNullOrEmpty(hotelName.Texts) && !String.IsNullOrEmpty(hotelCategory.Texts)
                && !String.IsNullOrEmpty(city.Texts) && !String.IsNullOrEmpty(locationInCity.Texts)
                && !String.IsNullOrEmpty(photoHotel.Texts) && !String.IsNullOrEmpty(checkIn.Texts)
                && !String.IsNullOrEmpty(checkOut.Texts)) 
            {
                Name = hotelName.Texts;
                Category = hotelCategory.Texts;
                City = city.Texts;
                Location = locationInCity.Texts;
                Photo = photoHotel.Texts;
                CheckIn = checkIn.Texts;
                CheckOut = checkOut.Texts;

                CreateHotel?.Invoke(this, EventArgs.Empty);
                Facilities.Clear();
                if (!String.IsNullOrEmpty(Error))
                    MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hotelName.Texts = locationInCity.Texts = photoHotel.Texts = checkIn.Texts = checkOut.Texts = "";
                    for (int i = 0; i < radioButtons.Count; i++)
                    {
                        if (radioButtons[i].Checked)
                            radioButtons[i].Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі поля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertFacilities()
        {
            for(int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked)
                    Facilities.Add(radioButtons[i].Text);
            }
        }
    }
}
