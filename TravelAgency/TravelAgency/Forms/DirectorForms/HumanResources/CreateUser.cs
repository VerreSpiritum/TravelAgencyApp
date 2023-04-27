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
    public partial class CreateUser : Form, IViewCreateUsers
    {
        private bool checkShowEmployeeInfo;
        private Dictionary<string, object> _employee = new Dictionary<string, object>();

        public CreateUser()
        {
            InitializeComponent();
            createUserB.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }
        #region --- Interface ---
        
        public void ShowForm()
        {
            this.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler UpdateInfo;
        public event EventHandler CanClose;

        public string ErrorMess { get; set; }
        public string Password { get; set; }
        public int TalonNum { get; set; }
        #endregion

        private void talonNumTB_TextChanges(object sender, EventArgs e)
        {
            
            if(int.TryParse(loginTB.Texts, out int res))
            {

                TalonNum = res;
            }
            else
            {
                TalonNum = 0;
            }    
        }

        private void createUserB_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginTB.Texts))
            {
                MessageBox.Show("Введіть будь ласка талонний номер співробітника!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TalonNum > 0 && !String.IsNullOrEmpty(Password))
                {
                    UpdateInfo?.Invoke(this, EventArgs.Empty);
                    if (String.IsNullOrEmpty(ErrorMess))
                    {
                        MessageBox.Show("Нового користувача додано", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CanClose?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show(ErrorMess, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Виникла помилка!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void passwordTB__TextChanged(object sender, EventArgs e)
        {
            Password = passwordTB.Texts;
        }

        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheck.Checked)
            {
                passwordTB.PasswordChar = false;
            }
            else
            {
                passwordTB.PasswordChar = true ;
            }
        }
    }
}
