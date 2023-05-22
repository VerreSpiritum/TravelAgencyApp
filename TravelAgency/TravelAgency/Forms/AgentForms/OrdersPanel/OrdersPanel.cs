using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Booking;
using TravelAgency.Views.DirectorViews;

namespace TravelAgency
{
    public partial class OrdersPanel : Form, IViewOrdersPanel
    {
        private List<Label> menu = new List<Label>();
        public OrdersPanel()
        {
            InitializeComponent();

            allBookingsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allBookingsL);
            menu.Add(allContractsL);
            menu.Add(viewContractL);
            menu.Add(createBookL);

        }
        #region --- Interface ---
        public event EventHandler ShowAllBookings;
        public event EventHandler ShowContracts;
        public event EventHandler ViewAllContract;
        public event EventHandler CreateNewBook;

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
            allBookingsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allContractsL.Font = viewContractL.Font = createBookL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
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

        private void allBookingsL_Click(object sender, EventArgs e)
        {
            allBookingsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allContractsL.Font = viewContractL.Font = createBookL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowAllBookings?.Invoke(this, EventArgs.Empty);
        }

        private void allContractsL_Click(object sender, EventArgs e)
        {
            allContractsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allBookingsL.Font = viewContractL.Font = createBookL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowContracts?.Invoke(this, EventArgs.Empty);
        }

        private void createBookL_Click(object sender, EventArgs e)
        {
            createBookL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allBookingsL.Font = viewContractL.Font = allContractsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular); 
            
            CreateNewBook?.Invoke(this, EventArgs.Empty);
        }

        private void viewContractL_Click(object sender, EventArgs e)
        {
            viewContractL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allBookingsL.Font = allContractsL.Font = createBookL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular); 
            
            ViewAllContract?.Invoke(this, EventArgs.Empty);
        }
    }
}
