using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews;

namespace TravelAgency
{
    public partial class ClientPanel : Form, IViewClientPanel
    {
        private List<Label> menu = new List<Label>();
        public ClientPanel()
        {
            InitializeComponent();

            allClientsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allClientsL);
            menu.Add(addClientL);

        }
        #region --- Interface ---

        public event EventHandler AddClient;
        public event EventHandler ShowListOfCLient;

        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Hide();
        }
        public void addOnPanelForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
        }

        public void OpenWindow()
        {
            allClientsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addClientL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
        
        public void ChangeStyle(string text)
        {
            foreach(Label control in menu)
            {
                if (control.Text == text)
                {
                    control.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
                }
                else
                {
                    control.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
                }
            }
        }
        #endregion

        private void allSalariesL_Click(object sender, EventArgs e)
        {
            allClientsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addClientL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowListOfCLient?.Invoke(this, EventArgs.Empty);
        }

        private void addClientL_Click(object sender, EventArgs e)
        {
            addClientL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allClientsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);


            AddClient?.Invoke(this, EventArgs.Empty);
        }
    }
}
