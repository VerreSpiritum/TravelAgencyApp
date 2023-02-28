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
            
        }

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
            get { return StartDate; }
            set { StartDate = value; }
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
        public void CloseForm()
        {
            this.Hide();
        }

        public void ShowForm()
        {
            this.Show();
        }

       
    }
}
