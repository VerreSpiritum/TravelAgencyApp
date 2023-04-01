using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class CreateNewStaff : Form, IViewCreateNewStaff
    {
        private string name;
        private string secondName;
        private string surname;
        private string phoneNum;
        private string birthDate;
        private string gender;
        private string startDate;
        private int salary;
        private string post;
        private string resultOfAdding;

        public CreateNewStaff()
        {
            InitializeComponent();
            
            nameL.ForeColor = surnameL.ForeColor = secondNameL.ForeColor = ColorTranslator.FromHtml("#7B7B7B");
            createNewStaffB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            startDateDT.MinDate = DateTime.Now;
        }
        #region --- Interface ---
        public string Name
        {
            get => name; set => name = value;
        }
        public string SecondName
        {
            get => secondName; set => secondName = value;
        }
        public string Surname
        {
            get => surname; set => surname = value;
        }
        public string PhoneNumber
        {
            get => phoneNum; set => phoneNum = value;
        }
        public string BirthDate
        {
            get => birthDate; set => birthDate = value;
        }
        public string Gender
        {
            get => gender; set => gender = value;
        }
        public string StartDate
        {
            get => startDate; set => startDate = value;
        }
        public int Salary
        {
            get => salary; set => salary = value;
        }
        public string Post
        {
            get => post; set => post = value;
        }
        public string ResultOfAdding { get => resultOfAdding; set => resultOfAdding = value; }
        public event EventHandler sendInfo;

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            
            this.Show();
        }
        #endregion

        private void createNewStaffB_Click(object sender, EventArgs e)
        {
            if (CheckAndInsert())
            {
                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(secondName) && !String.IsNullOrEmpty(surname) && !String.IsNullOrEmpty(phoneNum) 
                    && !String.IsNullOrEmpty(birthDate) && !String.IsNullOrEmpty(startDate) && !String.IsNullOrEmpty(gender) && salary >= 3500 && !String.IsNullOrEmpty(post))
                {
                    sendInfo?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(resultOfAdding, "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Заповніть правильно усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool CheckAndInsert()
        {
            phoneNum = phoneNumber.Texts;
            salary = int.Parse(salaryMTB.Texts) >= 3500 ? int.Parse(salaryMTB.Texts) : 0;
            startDate = startDateDT.Text;

            if (Convert.ToInt32(DateTime.Now.Year - birthDateDT.Value.Year) < 18)
            {
                MessageBox.Show("Вкажіть дату народження старше 18 років!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                birthDate = birthDateDT.Text;
            }
            post = postTB.Texts;
            if (femaleRB.Checked)
                gender = "Ж";
            else
                gender = "Ч";

            return true;
        }
        private void nameTB__TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Texts.All(Char.IsLetter))
                name = nameTB.Texts;
            else
                name = null;
        }
        private void secondNameTB_TextChanged(object sender, EventArgs e)
        {
            if (secondNameTB.Texts.All(Char.IsLetter))
                secondName = secondNameTB.Texts;
            else
                secondName = null;
        }
        private void surnameTB_TextChanged(object sender, EventArgs args)
        {
            if (surnameTB.Texts.All(Char.IsLetter))
                surname = surnameTB.Texts;
            else
                surname = null;
        }
        
    }
}
