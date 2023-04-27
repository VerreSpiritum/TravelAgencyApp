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
    public partial class EditRoom : Form, IViewEditRoom
    {
        private List<string> facility = new List<string>();
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private bool load = true;

        public EditRoom()
        {
            InitializeComponent();
            CreateNewBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");
            searchBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");

            startD.MinDate = DateTime.Now.AddDays(2);
            endD.MinDate = DateTime.Now.AddDays(3);
        }

        #region --- Реализация интерфейса ---
        public List<string> Facilities { get => facility; set => facility = value; }
        public List<string> Hotel { get; set; }
        public DataTable facilites { get; set; }
        public List<string> idRoom { get; set; }

        public string Name { get; set; }
        public string RoomGrade { get; set; }
        public string Meals { get; set; }
        public string Info { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }
        public string Period { get; set; }

        public int ID { get; set; }

        public string Error { get; set; }

        public void ShowForm()
        {
            AddFacilities();
            List<string> categories = new List<string> { "Одномісний", "Двомісний", "Тримісний", "Чотиримісний", "З ліжком розміру qeen-size", "Королівський номер", "Номер твін", "Голлівудський номер Твін", "Двомісний з окремими двомісними ліжками", "Студія", "Напівлюкс", "Президентський номер", "Апартаменти",
            "Суміжний номер", "Номер з ліжком Мерфі", "Доступний номер", "Номер з виходом до басейну", "Вілла", "Кімната для курців" };
            roomsGrade.Items.AddRange(categories.ToArray());
            roomsGrade.Texts = "Одномісний";
            List<string> mealsType = new List<string> { "Без харчування (OR)", "Тільки сніданок (BB)", "Сніданок + вечеря (HB/FB)", "Все включено (AL)", "Ультра все включено (UAL)" };
            hotelName.Items.AddRange(Hotel.ToArray());
            meals.Items.AddRange(mealsType.ToArray());
            meals.Texts = "Без харчування (OR)";
            if(idRoom.Count > 0)
                listWithHotelAndRoom.Items.AddRange(idRoom.ToArray());

            ShowOrHide(true);
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler CreateRoom;
        public event EventHandler SearchRoom;
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
            string period = "";
            if (startD.Value > endD.Value)
            {
                MessageBox.Show("Введіть дати правильно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (startD.Checked && endD.Checked)
                {
                    DateTime temp = startD.Value;
                    period = $"{temp.Day}.{temp.Month}.{temp.Year} - ";
                    temp = endD.Value;
                    period += $"{temp.Day}.{temp.Month}.{temp.Year}";
                }

                if (!String.IsNullOrEmpty(hotelName.Texts) && !String.IsNullOrEmpty(roomsGrade.Texts)
                    && !String.IsNullOrEmpty(meals.Texts) && !String.IsNullOrEmpty(photoRoom.Texts)
                    && !String.IsNullOrEmpty(infoRoom.Texts))
                {
                    Name = hotelName.Texts;
                    RoomGrade = roomsGrade.Texts;
                    Meals = meals.Texts;
                    Photo = photoRoom.Texts;
                    Info = infoRoom.Texts;
                    Period = period;
                    Price = Convert.ToInt32(price.Texts);

                    CreateRoom?.Invoke(this, EventArgs.Empty);
                    Facilities.Clear();
                    if (!String.IsNullOrEmpty(Error))
                        MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hotelName.Texts = photoRoom.Texts = infoRoom.Texts = "";
                        startD.Value = startD.MinDate;
                        meals.Texts = "Без харчування (OR)";
                        roomsGrade.Texts = "Одномісний";
                        endD.Value = endD.MinDate;
                        ShowOrHide(true);
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
        }

        private void InsertFacilities()
        {
            Facilities.Clear();

            for(int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i].Checked)
                    Facilities.Add(radioButtons[i].Text);
            }
        }

        private void CreateNewRoom_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Facilities.Clear();

            if (!String.IsNullOrEmpty(listWithHotelAndRoom.Texts))
            {
                string[] splitArr = listWithHotelAndRoom.Texts.Split(' ');
                ID = int.Parse(splitArr.Last<string>());
                SearchRoom?.Invoke(this, EventArgs.Empty);

                ShowOrHide(false);
                AddInfo();
            }
            else
                MessageBox.Show("Оберіть, будь ласка, тур", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AddInfo()
        {
            string[] hotels = listWithHotelAndRoom.Texts.Split(' ');

            hotelName.Texts = hotels.First();
            roomsGrade.Texts = RoomGrade;
            meals.Texts = Meals;
            photoRoom.Texts = Photo;
            infoRoom.Texts = Info;

            string[] dates = Period.Split(' ');
            startD.Value = Convert.ToDateTime(dates.First());
            endD.Value = Convert.ToDateTime(dates.Last());
            price.Texts = Price.ToString();

            for (int j = 0; j < radioButtons.Count; j++)
            {
                radioButtons[j].Checked = false;
            }

            for (int i = 0; i < Facilities.Count; i++)
            {
                for (int j = 0; j < radioButtons.Count; j++)
                {
                    if (radioButtons[j].Text == Facilities[i])
                        radioButtons[j].Checked = true;
                }
            }
        }

        private void listWithHotelAndRoom_OnSelectedIndexChanged(object sender, EventArgs e)
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

        private void ShowOrHide(bool hide)
        {
            if (hide)
            {
                foreach (Control control in this.Controls)
                {
                    if (control != listWithHotelAndRoom && control != searchBtn && control != label9)
                        control.Visible = false;
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control != listWithHotelAndRoom && control != searchBtn && control != label9)
                        control.Visible = true;
                }
            }
        }
    }
}
