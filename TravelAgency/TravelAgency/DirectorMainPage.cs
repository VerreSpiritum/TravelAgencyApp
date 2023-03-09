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

namespace TravelAgency
{
    public partial class DirectorMainPage : Form, IViewDirectorMainPage
    {
        public bool humanResourcesOpen { get => humanResourcesOpen; set => humanResourcesOpen = value; }
       
        public DirectorMainPage()
        {
            InitializeComponent();
            exitBtn.Parent = MenuPB;
            agentL.Parent = MenuPB;
            service_package.Parent = MenuPB;
            line1.Parent = MenuPB;
            line2.Parent = MenuPB;

            line1.BackColor = Color.White;
            exitBtn.BackColor = Color.Transparent;
            agentL.BackColor = Color.Transparent;
            service_package.BackColor = Color.Transparent;
        }
       
        public event EventHandler OpenHumanResoucesForm;
        public event EventHandler OpenServicePackageForm;
        public event EventHandler CloseConnection;

        public void ShowForm()
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CloseConnection != null)
                CloseConnection(this, EventArgs.Empty);
            Application.Exit();
        }

        private async void agentL_Click(object sender, EventArgs e)
        {
            line1.BackColor = Color.White;
            line2.BackColor = Color.Transparent;
            await Task.Delay(1000);

            if(OpenHumanResoucesForm != null)
                OpenHumanResoucesForm(this, EventArgs.Empty);
        }

        public void addOnPanelHumanResources(HumanResourcesForm form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panel1.Controls.Add(form);
        }

        private async void service_package_Click(object sender, EventArgs e)
        {
            line1.BackColor = Color.Transparent;
            line2.BackColor = Color.White;
            await Task.Delay(1000);

            if (OpenServicePackageForm != null)
                OpenServicePackageForm(this, EventArgs.Empty);
        }
        private void exit_Event(object sender, EventArgs e)
        {
            exitBtn.Cursor = Cursors.Hand;
        }

    }
}
