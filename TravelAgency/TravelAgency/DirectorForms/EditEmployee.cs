using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class EditEmployee : Form, IViewEditEmployee
    {
        private bool checkShowEmployeeInfo;
        private Dictionary<string, object> _employee = new Dictionary<string, object>();

        public EditEmployee()
        {
            InitializeComponent();
            searchEmployeeB.BackColor = saveChangesB.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }
        #region --- Interface ---
        
        public void ShowForm()
        {
            if (IsFromTable)
            {
                ShowInfo();
                AcceptButton = saveChangesB;
            }
            else
                AcceptButton = searchEmployeeB;
            this.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler GetInfo;
        public event EventHandler UpdateInfo;

        public Dictionary<String, Object> InfoToUpdate { get => _employee;}
        public bool talonNumFind { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string PhoneNumber { get; set; }
        public int TalonNum { get; set; }
        public bool IsFromTable { get; set; }

        #endregion

        private void searchEmployeeB_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(talonNumTB.Texts))
            {
                MessageBox.Show("Введіть будь ласка талонний номер співробітника!", "Помилка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.TryParse(talonNumTB.Texts, out int res))
            {
                TalonNum = res;
                GetInfo?.Invoke(this, EventArgs.Empty);
                if (talonNumFind)
                {
                    ShowInfo();
                }
                else
                {
                    if (checkShowEmployeeInfo)
                        HideInfo();
                    MessageBox.Show("Співробітника з таким номер не знайдено", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                if (checkShowEmployeeInfo)
                    HideInfo();
                MessageBox.Show("Невірний формат вводу, лише цифри!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void ShowInfo()
        {   
            SetLastInfo();
            label8.Visible = label7.Visible = label6.Visible = label4.Visible = label3.Visible = saveChangesB.Visible =
                nameTB.Visible = secondNameTB.Visible = surnameTB.Visible = phoneNumber.Visible = femaleRB.Visible = maleRB.Visible =
                postTB.Visible = salaryMTB.Visible = true;
            checkShowEmployeeInfo = true;
        }
        private void HideInfo()
        {
            label8.Visible = label7.Visible = label6.Visible = label4.Visible = label3.Visible = saveChangesB.Visible =
                nameTB.Visible = secondNameTB.Visible = surnameTB.Visible = phoneNumber.Visible = femaleRB.Visible = maleRB.Visible =
                postTB.Visible = salaryMTB.Visible = false;
            checkShowEmployeeInfo = false;
        }
        private void SetLastInfo()
        {
 
            if(IsFromTable)
            {
                talonNumTB.Texts = TalonNum.ToString();
            }
            nameTB.Texts = Name;
            secondNameTB.Texts = Patronymic;
            surnameTB.Texts = Surname;
            postTB.Texts = Position;
            if (Gender == "Ж")
            {
                femaleRB.Checked = true;
                maleRB.Checked = false;
            }
            else
            {
                femaleRB.Checked = false;
                maleRB.Checked = true;
            }

            salaryMTB.Texts = Convert.ToString(Salary);
            phoneNumber.Texts = PhoneNumber;
            

        }

        private bool CheckAndInsert()
        {
            int temp = int.Parse(salaryMTB.Texts) >= 3500 ? int.Parse(salaryMTB.Texts) : 0;
            string genderTemp;

            if (!phoneNumber.Texts.Equals(PhoneNumber))
                InfoToUpdate.Add("phone_number", phoneNumber.Texts);
            if(!Salary.Equals(temp))
                InfoToUpdate.Add("salary", temp);
            if (!Position.Equals(postTB.Texts))
                InfoToUpdate.Add("position", postTB.Texts);
            if (femaleRB.Checked)
                genderTemp = "Ж";
            else
                genderTemp = "Ч";
            if (!genderTemp.Equals(Gender))
                InfoToUpdate.Add("sex", genderTemp);

            return true;
        }
        private void NameTB__TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Texts.All(Char.IsLetter))
            {
                if (InfoToUpdate.ContainsKey("name"))
                {
                    InfoToUpdate["name"] = nameTB.Texts;
                }
                else
                {
                    InfoToUpdate.Add("name", nameTB.Texts);
                }
            }
            else
                Name = null;
        }
        private void SecondNameTB_TextChanged(object sender, EventArgs e)
        {
            if (secondNameTB.Texts.All(Char.IsLetter))
            {
                if(InfoToUpdate.ContainsKey("patronymic"))
                {
                    InfoToUpdate["patronymic"] = secondNameTB.Texts;
                }
                else
                {
                    InfoToUpdate.Add("patronymic", secondNameTB.Texts);
                }
            }
            else
                Patronymic = null;
        }
        private void surnameTB_TextChanged(object sender, EventArgs args)
        {
            if (surnameTB.Texts.All(Char.IsLetter))
            {
                if (InfoToUpdate.ContainsKey("surname"))
                {
                    InfoToUpdate["surname"] = surnameTB.Texts;
                }
                else
                {
                    InfoToUpdate.Add("surname", surnameTB.Texts);
                }
            }
            else
                Surname = null;
        }

        private void saveChangesB_Click(object sender, EventArgs e)
        {
            if (CheckAndInsert())
            {
                if (!String.IsNullOrEmpty(nameTB.Texts) && !String.IsNullOrEmpty(secondNameTB.Texts) && !String.IsNullOrEmpty(surnameTB.Texts) && !String.IsNullOrEmpty(phoneNumber.Texts)
                    && !String.IsNullOrEmpty(Gender) && Int32.Parse(salaryMTB.Texts) >= 3500 && !String.IsNullOrEmpty(Position))
                {
                    UpdateInfo?.Invoke(this, EventArgs.Empty);
                    _employee.Clear();
                    //MessageBox.Show(resultOfAdding, "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Заповніть правильно усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
