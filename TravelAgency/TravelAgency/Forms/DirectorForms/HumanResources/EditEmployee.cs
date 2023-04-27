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
        private bool checkName;
        private bool checkSurname;
        private bool checkPatronymic;

        private Dictionary<string, object> _employee = new Dictionary<string, object>();

        public EditEmployee()
        {
            InitializeComponent();
            searchEmployeeB.BackColor = saveChangesB.BackColor = ColorTranslator.FromHtml("#5AACB8");
            checkName = checkSurname = checkPatronymic = true;
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

        public int CheckUpdate { get; set; }

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
            label8.Visible = label6.Visible = label4.Visible = label3.Visible = saveChangesB.Visible =
                nameTB.Visible = secondNameTB.Visible = surnameTB.Visible = phoneNumber.Visible = femaleRB.Visible = maleRB.Visible =
                postTB.Visible = true;
            checkShowEmployeeInfo = true;
        }
        private void HideInfo()
        {
            label8.Visible = label6.Visible = label4.Visible = label3.Visible = saveChangesB.Visible =
                nameTB.Visible = secondNameTB.Visible = surnameTB.Visible = phoneNumber.Visible = femaleRB.Visible = maleRB.Visible =
                postTB.Visible = false;
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

            phoneNumber.Texts = PhoneNumber;
            

        }

        private bool CheckAndInsert()
        {
            string genderTemp;

            if (!phoneNumber.Texts.Equals(PhoneNumber))
            {
                if(InfoToUpdate.ContainsKey("phone_number"))
                {
                    InfoToUpdate["phone_number"] = phoneNumber.Texts;
                }
                else
                {
                    InfoToUpdate.Add("phone_number", phoneNumber.Texts);
                }

            }
       
            if (!Position.Equals(postTB.Texts))
            {
                if(InfoToUpdate.ContainsKey("position"))
                {
                    InfoToUpdate["position"] = postTB.Texts;
                }
                else
                {
                    InfoToUpdate.Add("position", postTB.Texts);
                }
            }    
            if (femaleRB.Checked)
                genderTemp = "Ж";
            else
                genderTemp = "Ч";
            if (!genderTemp.Equals(Gender))
            {
                if(InfoToUpdate.ContainsKey("sex"))
                {
                    InfoToUpdate["sex"] = genderTemp;
                }
                else
                {
                    InfoToUpdate.Add("sex", genderTemp);
                }
            }

            return true;
        }
        private void NameTB__TextChanged(object sender, EventArgs e)
        {
            if (!checkName)
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
                    nameTB.BorderColor = Color.Black;
                }
                else
                {
                    Name = null;
                    nameTB.BorderColor = Color.Red;
                }
            }
            else
                checkName = false;
        }
        private void SecondNameTB_TextChanged(object sender, EventArgs e)
        {
            if (!checkPatronymic)
            {
                if (secondNameTB.Texts.All(Char.IsLetter))
                {
                    if (InfoToUpdate.ContainsKey("patronymic"))
                    {
                        InfoToUpdate["patronymic"] = secondNameTB.Texts;
                    }
                    else
                    {
                        InfoToUpdate.Add("patronymic", secondNameTB.Texts);
                    }
                    secondNameTB.BorderColor = Color.Black;

                }
                else
                {
                    Patronymic = null;
                    secondNameTB.BorderColor = Color.Red;
                }
            }
            else
            {
                checkPatronymic = false;
            }
        }
        private void surnameTB_TextChanged(object sender, EventArgs args)
        {
            if (!checkSurname)
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
                    surnameTB.BorderColor = Color.Black;
                }
                else
                {
                    Surname = null;
                    surnameTB.BorderColor = Color.Red;
                }
            }
            else
            {
                checkSurname = false;
            }
        }

        private void saveChangesB_Click(object sender, EventArgs e)
        {
            if (CheckAndInsert())
            {
                if (_employee.Count == 0)
                {
                    MessageBox.Show($"Немає нових даних для внесення змін!", "Оновити дані", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {


                    if (!String.IsNullOrEmpty(nameTB.Texts) && !String.IsNullOrEmpty(secondNameTB.Texts) && !String.IsNullOrEmpty(surnameTB.Texts) && !String.IsNullOrEmpty(phoneNumber.Texts)
                        && !String.IsNullOrEmpty(Gender) && !String.IsNullOrEmpty(Position))
                    {
                        if (nameTB.Texts.All(Char.IsLetter) && secondNameTB.Texts.All(Char.IsLetter) && surnameTB.Texts.All(Char.IsLetter) && postTB.Texts.All(Char.IsLetter))
                        {
                            UpdateInfo?.Invoke(this, EventArgs.Empty);
                            if (CheckUpdate == 1)
                            {
                                _employee.Clear();
                                MessageBox.Show($"Дані про агента {TalonNum} змінено!", "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Виникла помилка при змінах інформації агента {TalonNum}!", "Результат роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _employee.Clear();
                                SetLastInfo();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Заповніть правильно усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заповніть правильно усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
