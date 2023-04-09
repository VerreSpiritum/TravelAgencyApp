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
            tour.Parent = MenuPB;
            HotelInfo.Parent = MenuPB;

            line1.Parent = MenuPB;
            line2.Parent = MenuPB;
            line3.Parent = MenuPB;
            line4.Parent = MenuPB;

            line1.BackColor = Color.White;
            exitBtn.BackColor = Color.Transparent;
            agentL.BackColor = Color.Transparent;
            service_package.BackColor = Color.Transparent;
            tour.BackColor = Color.Transparent;
            HotelInfo.BackColor = Color.Transparent;
        }
       
        public event EventHandler OpenHumanResourcesForm;
        public event EventHandler OpenTransportsAndTransfersForm;
        public event EventHandler OpenTourAddTourForm;
        public event EventHandler OpenHotelInfoForm;
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
            line2.BackColor = line3.BackColor = line4.BackColor = Color.Transparent;
            await Task.Delay(1000);

            OpenHumanResourcesForm?.Invoke(this, EventArgs.Empty);
        }

        public void addOnPanel(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panel1.Controls.Add(form);
        }

        private async void service_package_Click(object sender, EventArgs e)
        {
            line2.BackColor = Color.White;
            line1.BackColor = line3.BackColor = line4.BackColor = Color.Transparent;
            await Task.Delay(1000);

            OpenTransportsAndTransfersForm?.Invoke(this, EventArgs.Empty);
        }
        private void exit_Event(object sender, EventArgs e)
        {
            exitBtn.Cursor = Cursors.Hand;
        }

        private void MenuPB_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tour_Click(object sender, EventArgs e)
        {
            line3.BackColor = Color.White;
            line1.BackColor = line2.BackColor = line4.BackColor = Color.Transparent;
            
            OpenTourAddTourForm?.Invoke(this, EventArgs.Empty);
        }

        private void HotelInfo_Click(object sender, EventArgs e)
        {
            line4.BackColor = Color.White;
            line1.BackColor = line3.BackColor = line2.BackColor = Color.Transparent;
            
            OpenHotelInfoForm?.Invoke(this, EventArgs.Empty);
        }
    }
}
