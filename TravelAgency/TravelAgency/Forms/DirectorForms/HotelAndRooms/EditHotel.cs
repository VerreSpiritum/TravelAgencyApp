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
    public partial class EditHotel : Form, IViewEditHotel
    {
        private List<string> facility = new List<string>();
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private bool load = true;

        public EditHotel()
        {
            InitializeComponent();
            CreateNewBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");
            searchBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");

        }

        #region --- Реализация интерфейса ---
        public List<string> Facilities { get => facility; set => facility = value; }
        public List<int> IDhotel { get; set; }
        public DataTable facilites { get; set; }
        public List<string> cities { get; set; }

        public int ID { get; set; }
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
            
            ShowOrHide(true);
            for (int i = 0; i < IDhotel.Count; i++)
                listWithHotelNum.Items.Add(IDhotel[i].ToString());

            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler EditHotels;
        public event EventHandler SearchHotel;


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
            facility.Clear();
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

                EditHotels?.Invoke(this, EventArgs.Empty);
                facility.Clear();
                if (!String.IsNullOrEmpty(Error))
                    MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Успішно змінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowOrHide(true);
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
                    facility.Add(radioButtons[i].Text);
            }
        }

        private void ShowOrHide(bool hide)
        {
            if (hide)
            {
                foreach (Control control in this.Controls)
                {
                    if (control != listWithHotelNum && control != searchBtn && control != label8)
                        control.Visible = false;
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control != listWithHotelNum && control != searchBtn && control != label8)
                        control.Visible = true;
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(listWithHotelNum.Texts))
            {
                ID = int.Parse(listWithHotelNum.Texts);
                SearchHotel?.Invoke(this, EventArgs.Empty);

                ShowOrHide(false);
                AddInfo();
            }
            else
                MessageBox.Show("Оберіть, будь ласка, тур", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AddInfo()
        {
            hotelName.Texts = Name;
            hotelCategory.Texts = Category;
            city.Texts = City;
            locationInCity.Texts = Location;
            photoHotel.Texts = Photo;
            checkIn.Texts = CheckIn;
            checkOut.Texts = CheckOut;

            for(int i = 0; i < Facilities.Count; i++)
            {
                for(int j = 0; j < radioButtons.Count; j++)
                {
                    if (radioButtons[j].Text == Facilities[i])
                        radioButtons[j].Checked = true;
                }
            }
        }
        private void listWithHotelNum_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                if (ID > 0)
                {
                    if (MessageBox.Show("Якщо ви зараз змінете номер, ваші зміни не будут збережені!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        ShowOrHide(true);
                    }
                }
            }
            else
                load = false;
        }
    }
}
