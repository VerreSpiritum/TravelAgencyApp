using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Design;
using TravelAgency.Views;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency
{
    public partial class CreateNewTour: Form, IViewCreateNewTour
    {
        private string name;
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private List<string> facility = new List<string>();
        private DataTable city_in_tour = new DataTable();
        private Dictionary<string, object> infoToAdd = new Dictionary<string, object>();
        private DateTime LastValue = DateTime.Today;
        public CreateNewTour()
        {
            InitializeComponent();
            
            //.ForeColor = surnameL.ForeColor = secondNameL.ForeColor = ColorTranslator.FromHtml("#7B7B7B");
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8"); 
            AddCity.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            ClearTable.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");

            city_in_tour.Columns.Add("cityName", typeof(string));
            city_in_tour.Columns.Add("startD", typeof(DateTime));
            city_in_tour.Columns.Add("endD", typeof(DateTime));


            flightDate.MinDate = StartDateD.MinDate = endDateD.MinDate = DateTime.Today;
        }
        #region --- Interface ---

        public List<string> DepCity { get; set; }
        public List<string> CitiesToVisit { get; set; }
        public string Error { get; set; }

        public Dictionary<string, object> InfoToAdd { get => infoToAdd; }
        public DataTable cityInTour { get => city_in_tour; }

        public event EventHandler CreateTour;
        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            availableCity.Items.AddRange(DepCity.ToArray());
            Cities.Items.AddRange(CitiesToVisit.ToArray());
            Cities.Texts = "Одеса";
            availableCity.Texts = "Одеса";

            AddInfo();
            this.Show();
        }
        #endregion
        public void AddFacilities()
        {
            
        }
        private void AddInfo()
        {
            List<string> oper = new List<string>() { "Anex", "Join UPI", "TUI", "Coral Travel", "Pegas Touristik", "TEZ Tour", "TPG", "Компас" };
            List<string> typeOfTour = new List<string>() { "Весільний", "Екотур", "Екстремальний", "Гастро-тур", "Індивідуальний", "Тур Україною",
                "Гірськолижний", "Круїз", "Тур вихідного дня", "Сімейний", "Відпочинок"};
            List<string> orTB = new List<string>() { "Є", "Немає" }; 
            Operators.Items.AddRange(oper.ToArray());
            Operators.Texts = oper[0];
            TypeOfTour.Items.AddRange(typeOfTour.ToArray());
            TypeOfTour.Texts = typeOfTour[0];
            transfer.Items.AddRange(orTB.ToArray());
            book.Items.AddRange(orTB.ToArray());
            transfer.Texts = book.Texts = orTB[0];

            
        }
        private void nameTB__TextChanged(object sender, EventArgs e)
        {
            Name = nameTB.Texts;
            if (nameTB.Texts == null)
                nameTB.BorderColor = Color.Red;
            else
                nameTB.BorderColor = Color.Black;
        }

        private void flightDate_ValueChanged(object sender, EventArgs e)
        {
            if (tourCityInfoTable.Rows.Count == 0)
            {
                DateTime date = new DateTime(flightDate.Value.Year, flightDate.Value.Month, flightDate.Value.Day);
                if (date > StartDateD.Value)
                {
                    StartDateD.MaxDate = date;
                    StartDateD.Value = date;
                    StartDateD.MinDate = date;
                }
                else
                {
                    StartDateD.MinDate = date;
                    StartDateD.Value = date;
                    StartDateD.MaxDate = date; 
                }
                endDateD.MinDate = date;
                LastValue = flightDate.Value;
            }
            else
            {
                MessageBox.Show("Видаліть міста з минулими датами для зміни", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flightDate.Value = LastValue;
            }

        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            bool checkExcist = false;
            if (String.IsNullOrEmpty(Cities.Texts))
                MessageBox.Show("Оберіть місто!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (DataRow row in city_in_tour.Rows)
                {
                    if (row["cityName"] == Cities.Texts)
                    {
                        checkExcist = true;

                    }
                }
                if (!checkExcist)
                {

                    object[] arr = new object[3];
                    arr[0] = Cities.Texts;
                    arr[1] = $"{StartDateD.Value.Day}/{StartDateD.Value.Month}/{StartDateD.Value.Year}";
                    arr[2] = $"{endDateD.Value.Day}/{endDateD.Value.Month}/{endDateD.Value.Year}";
                    city_in_tour.Rows.Add(arr);
                    tourCityInfoTable.Rows.Add(arr);

                    Cities.Texts = "";
                    DateTime date = new DateTime(9998, 12, 31);
                    StartDateD.MaxDate = date;
                    StartDateD.MinDate = new DateTime(endDateD.Value.Year, endDateD.Value.Month, endDateD.Value.Day + 1);
                    endDateD.MinDate = StartDateD.MinDate;

                }
                else
                {
                    MessageBox.Show("Це місто вже є у турі!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tourCityInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            StartDateD.MinDate = flightDate.Value;
          
            endDateD.MinDate = flightDate.Value;
            StartDateD.MaxDate = flightDate.Value;
            city_in_tour.Clear();
            tourCityInfoTable.Rows.Clear();
        }

        private void createTransportB_Click(object sender, EventArgs e)
        {
            string date = flightDate.Value.Date.Day + "." + flightDate.Value.Date.Month + "." + flightDate.Value.Date.Year;


            if(!String.IsNullOrEmpty(nameTB.Texts) && !String.IsNullOrEmpty(Operators.Texts) && !String.IsNullOrEmpty(TypeOfTour.Texts)
                && !String.IsNullOrEmpty(availableCity.Texts) && !String.IsNullOrEmpty(date)
                && !String.IsNullOrEmpty(transfer.Texts) && !String.IsNullOrEmpty(linkPhotoTB.Texts) && !String.IsNullOrEmpty(CountOfPeople.Texts)
                && !String.IsNullOrEmpty(book.Texts) && !String.IsNullOrEmpty(CostM.Texts) && int.Parse(CostM.Texts) > 0 && !String.IsNullOrEmpty(countOfTour.Texts) 
                && int.Parse(countOfTour.Texts) > 0)
            {
                if (tourCityInfoTable.Rows.Count == 0)
                {
                    MessageBox.Show("Додайте міста для відвідування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (int.Parse(CountOfPeople.Texts) > 0)
                    {
                        infoToAdd.Add("Name", nameTB.Texts);
                        infoToAdd.Add("TypeOfTour", TypeOfTour.Texts);
                        infoToAdd.Add("Operator", Operators.Texts);
                        infoToAdd.Add("Date_of_departure", date);
                        int i = 0; DateTime firstDate = new DateTime(2023, 01, 01); DateTime lastDate = new DateTime(2023, 01, 01);
                        foreach (DataRow row in city_in_tour.Rows)
                        {
                            if (city_in_tour.Rows.Count > 1)
                            {
                                if (i == 0)
                                {
                                    firstDate = (DateTime)row["startD"];
                                }
                                else if (i == tourCityInfoTable.Rows.Count-1)
                                {
                                    lastDate = (DateTime)row["endD"];
                                }
                            }
                            else
                            {
                                lastDate = (DateTime)row["endD"];
                                firstDate = (DateTime)row["startD"];
                            }
                            i++;
                        }
                        TimeSpan interval = lastDate.Subtract(firstDate);
                        infoToAdd.Add("CountOfNights", $"{interval.Days + 1}");
                        int countChildren = 0;
                        if (!String.IsNullOrEmpty(childrenCount.Texts))
                            countChildren = int.Parse(childrenCount.Texts);
                        infoToAdd.Add("CountOfChildren", countChildren);
                        infoToAdd.Add("Transfer", transfer.Texts);
                        infoToAdd.Add("Booking", book.Texts);
                        infoToAdd.Add("Photos", linkPhotoTB.Texts);
                        infoToAdd.Add("Price", int.Parse(CostM.Texts));
                        infoToAdd.Add("CountOfAvailTour", int.Parse(countOfTour.Texts));
                        infoToAdd.Add("numberOfAdd", int.Parse(CountOfPeople.Texts));
                        
                        CreateTour?.Invoke(this, EventArgs.Empty);
                        if (!String.IsNullOrEmpty(Error))
                        {
                            MessageBox.Show(Error, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            infoToAdd.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tourCityInfoTable.Rows.Clear();
                            city_in_tour.Rows.Clear(); 
                            
                            childrenCount.Texts = String.Empty;
                            linkPhotoTB.Texts = String.Empty;
                            CostM.Texts = String.Empty;
                            countOfTour.Texts = String.Empty;
                            CountOfPeople.Texts = String.Empty;
                            flightDate.MinDate = StartDateD.MinDate = endDateD.MinDate = DateTime.Today;
                            flightDate.Value = flightDate.MinDate;
                            
                            nameTB.Texts = String.Empty;
                            if (tourCityInfoTable.Rows.Count == 0)
                            {
                                DateTime temp = new DateTime(flightDate.Value.Year, flightDate.Value.Month, flightDate.Value.Day);
                                if (temp > StartDateD.Value)
                                {
                                    StartDateD.MaxDate = temp;
                                    StartDateD.Value = temp;
                                    StartDateD.MinDate = temp;
                                }
                                else
                                {
                                    StartDateD.MinDate = temp;
                                    StartDateD.Value = temp;
                                    StartDateD.MaxDate = temp; 
                                }
                                endDateD.MinDate = temp;
                            } 
                            

                        }
                        infoToAdd.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Вкажіть кількість дорослих", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть поля правильно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
