using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
    public partial class EditUser : Form, IViewEditUsers
    {
        private bool checkShowEmployeeInfo;
        private Dictionary<string, object> _employee = new Dictionary<string, object>();

        public EditUser()
        {
            InitializeComponent();
            saveChangesB.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }
        #region --- Interface ---
        
        public void ShowForm(string login)
        {
            loginTB.Texts = login;
            Login = login;
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler GetInfo;
        public event EventHandler UpdateInfo;
        public event EventHandler CloseWindow;

        public string Login { get; set; }
        public string Password { get; set; }
        #endregion

        private void searchEmployeeB_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(loginTB.Texts))
            {
                MessageBox.Show("Введіть будь ласка талонний номер співробітника!", "Помилка!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.TryParse(loginTB.Texts, out int res))
            {
                
                GetInfo?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if (checkShowEmployeeInfo)
                    //HideInfo();
                MessageBox.Show("Невірний формат вводу, лише цифри!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
           
        }

        private void saveChangesB_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Password))
            {
                UpdateInfo?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Зміни збережено!", "Зміна паролю", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passwordTB.BorderColor = Color.Black;
                CloseWindow?.Invoke(this, EventArgs.Empty);

            }
            else
            {
                passwordTB.BorderColor = Color.Red;
                MessageBox.Show("Заповніть поле паролю!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheck.Checked)
            {
                passwordTB.PasswordChar = false;
            }
            else
            {
                passwordTB.PasswordChar = true;
            }
        }

        private void passwordTB__TextChanged(object sender, EventArgs e)
        {
            Password = passwordTB.Texts;
        }


        //private void SetLastInfo()
        //{

        //    if(IsFromTable)
        //    {
        //        loginTB.Texts = TalonNum.ToString();
        //    }
        //    passwordTB.Texts = Name;
        //    secondNameTB.Texts = Patronymic;
        //    surnameTB.Texts = Surname;
        //    postTB.Texts = Position;
        //    if (Gender == "Ж")
        //    {
        //        femaleRB.Checked = true;
        //        maleRB.Checked = false;
        //    }
        //    else
        //    {
        //        femaleRB.Checked = false;
        //        maleRB.Checked = true;
        //    }

        //    salaryMTB.Texts = Convert.ToString(Salary);
        //    phoneNumber.Texts = PhoneNumber;


        //}

        //private bool CheckAndInsert()
        //{
        //    int temp = int.Parse(salaryMTB.Texts) >= 3500 ? int.Parse(salaryMTB.Texts) : 0;
        //    string genderTemp;

        //    if (!phoneNumber.Texts.Equals(PhoneNumber))
        //        InfoToUpdate.Add("phone_number", phoneNumber.Texts);
        //    if(!Salary.Equals(temp))
        //        InfoToUpdate.Add("salary", temp);
        //    if (!Position.Equals(postTB.Texts))
        //        InfoToUpdate.Add("position", postTB.Texts);
        //    if (femaleRB.Checked)
        //        genderTemp = "Ж";
        //    else
        //        genderTemp = "Ч";
        //    if (!genderTemp.Equals(Gender))
        //        InfoToUpdate.Add("sex", genderTemp);

        //    return true;
        //}
        //private void NameTB__TextChanged(object sender, EventArgs e)
        //{
        //    if (passwordTB.Texts.All(Char.IsLetter) && Name.Equals(passwordTB.Texts))
        //    {
        //        InfoToUpdate.Add("name", passwordTB.Texts);
        //    }
        //    else
        //        Name = null;
        //}
        //private void SecondNameTB_TextChanged(object sender, EventArgs e)
        //{
        //    if (secondNameTB.Texts.All(Char.IsLetter) && Patronymic.Equals(secondNameTB.Texts))
        //        InfoToUpdate.Add("patronymic", secondNameTB.Texts);
        //    else
        //        Patronymic = null;
        //}
        //private void surnameTB_TextChanged(object sender, EventArgs args)
        //{
        //    if (surnameTB.Texts.All(Char.IsLetter) && Surname.Equals(surnameTB.Texts))
        //        InfoToUpdate.Add("surname", surnameTB.Texts);
        //    else
        //        Surname = null;
        //}

        //private void saveChangesB_Click(object sender, EventArgs e)
        //{
        //    if (CheckAndInsert())
        //    {
        //        if (!String.IsNullOrEmpty(passwordTB.Texts) && !String.IsNullOrEmpty(secondNameTB.Texts) && !String.IsNullOrEmpty(surnameTB.Texts) && !String.IsNullOrEmpty(phoneNumber.Texts)
        //            && !String.IsNullOrEmpty(Gender) && Int32.Parse(salaryMTB.Texts) >= 3500 && !String.IsNullOrEmpty(Position))
        //        {
        //            UpdateInfo?.Invoke(this, EventArgs.Empty);
        //            _employee.Clear();
        //            //MessageBox.Show(resultOfAdding, "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Заповніть правильно усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //}
    }
}
