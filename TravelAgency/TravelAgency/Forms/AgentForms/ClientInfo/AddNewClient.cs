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
using TravelAgency.Views.AgentViews.ClientPanel;

namespace TravelAgency
{
    public partial class AddNewClient : Form, IViewAddNewClient
    {
        private string name;
        private string secondName;
        private string surname;
        private string phoneNum;
        private string birthDate;
        private string gender;
        private string email;
        private string identCode;
        private string registryEntryNum;
        private string passportNum;
        private string resultOfAdding;

        public AddNewClient()
        {
            InitializeComponent();
            
            nameL.ForeColor = surnameL.ForeColor = secondNameL.ForeColor = ColorTranslator.FromHtml("#7B7B7B");
            createNewStaffB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
        }
        #region --- Interface ---
        public string Name
        {
            get => name;
        }
        public string SecondName
        {
            get => secondName;
        }
        public string Surname
        {
            get => surname;
        }
        public string PhoneNumber
        {
            get => phoneNum;
        }
        public string BirthDate
        {
            get => birthDate;
        }
        public string Gender
        {
            get => gender;
        }
        public string Email
        {
            get => email;
        }
        public string IdentCode
        {
            get => identCode;
        }
        public string RegistryEntryNum
        {
            get => registryEntryNum;
        }
        public string PassportNumber
        {
            get => passportNum;
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
            identCode = idCode.Text;
            registryEntryNum = PassportNum.Text;
            passportNum = RegistryNum.Text;
            email = emailAdress.Text;



            if (CheckAndInsert())
            {
                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(secondName) && !String.IsNullOrEmpty(surname) && !String.IsNullOrEmpty(phoneNum) 
                    && !String.IsNullOrEmpty(birthDate) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(gender) && !String.IsNullOrEmpty(passportNum) && 
                    !String.IsNullOrEmpty(identCode) && !String.IsNullOrEmpty(RegistryEntryNum))
                {
                    sendInfo?.Invoke(this, EventArgs.Empty);
                    if(String.IsNullOrEmpty(resultOfAdding))
                        MessageBox.Show("Успішно додано!", "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
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
           
            if (Convert.ToInt32(DateTime.Now.Year - birthDateDT.Value.Year) < 18)
            {
                MessageBox.Show("Вкажіть дату народження старше 18 років!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                birthDate = birthDateDT.Text;
            }

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

        private void idCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            identCode = idCode.Text;
        }

        private void RegistryNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            registryEntryNum = RegistryNum.Text;
        }

        private void PassportNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            passportNum = PassportNum.Text; 
        }

        private void emailAdress_TextChanged(object sender, EventArgs e)
        {
            email = emailAdress.Text;
        }
    }
}
