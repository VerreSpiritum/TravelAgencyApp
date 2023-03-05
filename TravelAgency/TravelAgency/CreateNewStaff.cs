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
        private string salary;
        private string post;

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
            get { return name; }
            set { name = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                post = value;
            }
        }
        public event EventHandler sendInfo;

        public void CloseForm()
        {
            this.Hide();
        }

        public void ShowForm()
        {
            this.Show();
        }
        #endregion

        private void createNewStaffB_Click(object sender, EventArgs e)
        {
            phoneNum = phoneNumber.Texts;
            salary = salaryMTB.Texts;
            startDate = startDateDT.Text;
            post = postTB.Texts;
            
            if (!String.IsNullOrEmpty(name) || !String.IsNullOrEmpty(secondName) || !String.IsNullOrEmpty(surname) || !String.IsNullOrEmpty(phoneNum)
                || !String.IsNullOrEmpty(birthDate) || !String.IsNullOrEmpty(startDate) || !String.IsNullOrEmpty(gender) || !String.IsNullOrEmpty(salary)
                || !String.IsNullOrEmpty(post))
            {
                if (sendInfo != null)
                {
                    sendInfo(this, EventArgs.Empty);
                }
                
            }
            else
            {
                errorLabel.Text = "Заповніть усі поля!";
            }
            
        }

        private void nameTB__TextChanged(object sender, EventArgs e)
        {
            if(nameTB.Texts.All(Char.IsLetter))
                name = nameTB.Texts;
        }
        private void secondNameTB_TextChanged(object sender, EventArgs e)
        {
            if (secondNameTB.Texts.All(Char.IsLetter))
                secondName = secondNameTB.Texts;
        }
        private void surnameTB_TextChanged(object sender, EventArgs args)
        {
            if (surnameTB.Texts.All(Char.IsLetter))
                surname = surnameTB.Texts;
        }
        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            phoneNum = phoneNumber.Texts;
        }
        private void birthDateDT_ValueChanged(object sender, EventArgs e)
        {
            birthDate = birthDateDT.Text;
        }
        private void startDateDT_ValueChanged(object sender, EventArgs e)
        {
            startDate = startDateDT.Text;
        }
        private void femaleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRB.Checked)
            {
                gender = "Ж";
            }
        }
        private void maleRB_CheckedChanged(object sender, EventArgs e)
        {
            if(maleRB.Checked)
            {
                gender = "Ч";
            }
        }
        private void postTB__TextChanged(object sender, EventArgs e)
        {
            if (postTB.Texts.All(Char.IsLetter))
                post = postTB.Texts;
        }
        private void salaryMTB__TextChanged(object sender, EventArgs e)
        {
            salary = salaryMTB.Texts;
        }
    }
}
