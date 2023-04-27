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
    public partial class AgentMainPage : Form, IViewAgentMainPage
    {
        public bool humanResourcesOpen { get => humanResourcesOpen; set => humanResourcesOpen = value; }
       
        public AgentMainPage()
        {
            InitializeComponent();
            exitBtn.Parent = MenuPB;
            personalInfoL.Parent = clientsL.Parent = ordersL.Parent = ServicePacket.Parent = MenuPB;

            line1.Parent = line2.Parent = line3.Parent = line4.Parent = MenuPB;

            line1.BackColor = Color.White;
            line2.BackColor = line3.BackColor = line4.BackColor = Color.Transparent;
            exitBtn.BackColor = personalInfoL.BackColor = clientsL.BackColor = ordersL.BackColor = ServicePacket.BackColor = Color.Transparent;
        }
       
        public event EventHandler OpenPersonalInfoForm;
        public event EventHandler OpenClientForm;
        public event EventHandler OpenOrdersPanel;
        public event EventHandler CloseConnection;
        public event EventHandler OpenPanelToShowServices;

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

        private void personalInfoL_Click(object sender, EventArgs e)
        {
            line1.BackColor = Color.White;
            line2.BackColor = line3.BackColor = line4.BackColor = Color.Transparent;

            OpenPersonalInfoForm?.Invoke(this, EventArgs.Empty);
        }
        private void clientsL_Click(object sender, EventArgs e)
        {
            line2.BackColor = Color.White;
            line1.BackColor = line3.BackColor = line4.BackColor = Color.Transparent;

            OpenClientForm?.Invoke(this, EventArgs.Empty);
        }
        public void addOnPanel(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panel1.Controls.Add(form);
        }

        private void exit_Event(object sender, EventArgs e)
        {
            exitBtn.Cursor = Cursors.Hand;
        }

        private void ordersL_Click(object sender, EventArgs e)
        {
            line3.BackColor = Color.White;
            line1.BackColor = line2.BackColor = line4.BackColor = Color.Transparent;

            OpenOrdersPanel?.Invoke(this, EventArgs.Empty);
        }

        private void ServicePacket_Click(object sender, EventArgs e)
        {
            line4.BackColor = Color.White;
            line1.BackColor = line2.BackColor = line3.BackColor = Color.Transparent;

            OpenPanelToShowServices?.Invoke(this, EventArgs.Empty);
        }
    }
}
