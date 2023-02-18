using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views;
using System.Drawing.Text;
using System.ComponentModel.Design;
using Npgsql;

namespace TravelAgency
{
    public partial class Autorization : Form, IViewAutorizationForm
    {
        public Autorization()
        {
            InitializeComponent();
            
        }
        private string login ="", password ="";
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        

        public event EventHandler ConnectToDB;

        public void Run()
        {
            Application.Run(this);
        }
        public void ErrorMessage(string error)
        {
            ErrorMess.Text = error;
        }
        public void CloseForm()
        {
            this.Hide();
        }
        private void Autorization_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#2893A0");
            ConnectingBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");
            ConnectingBtn.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
        }

        private void ConnectingBtn_MouseHoverDown(object sender, EventArgs e)
        {
            ConnectingBtn.Cursor = Cursors.Hand;
        }

        private void ConnectingBtn_MouseLeave(object sender, EventArgs e)
        {
            ConnectingBtn.Cursor = Cursors.Default;
        }

        private void ConnectingBtn_MouseClick(object sender, MouseEventArgs e)
        {
            ConnectingBtn.Cursor = Cursors.WaitCursor;
        }
        
        private void ConnectingBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            loginTB.Enabled = passwordTB.Enabled = false;
            login = loginTB.Texts; password = passwordTB.Texts;
            if(login != "" && password != "")
            {
                
                if(ConnectToDB != null)
                    ConnectToDB(this, EventArgs.Empty);
            }
            else
            {
                ErrorMess.Text = "Не всі поля заповнено!";
            }
            loginTB.Enabled = passwordTB.Enabled = true;
            this.Cursor = Cursors.Default;
        }
    }
}
