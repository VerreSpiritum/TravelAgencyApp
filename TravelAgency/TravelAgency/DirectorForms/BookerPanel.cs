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
    public partial class BookerPanel : Form, IViewBookerPanel
    {
        private List<Label> menu = new List<Label>();
        public BookerPanel()
        {
            InitializeComponent();

            allSalariesL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allSalariesL);
            menu.Add(concludedContractsL);
            menu.Add(paymentStaytmentL);
            menu.Add(profitL);

        }
        #region --- Interface ---

        public event EventHandler AllSalaries;
        public event EventHandler ConcludedContracts;
        public event EventHandler PaymentStaytment;
        public event EventHandler ProfitOfAgency;

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
            allSalariesL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            concludedContractsL.Font = profitL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
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
            allSalariesL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            paymentStaytmentL.Font = profitL.Font = concludedContractsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            AllSalaries?.Invoke(this, EventArgs.Empty);
        }

        private void paymentStaytmentL_Click(object sender, EventArgs e)
        {
            paymentStaytmentL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allSalariesL.Font = profitL.Font = concludedContractsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            PaymentStaytment?.Invoke(this, EventArgs.Empty);
        }

        private void concludedContractsL_Click(object sender, EventArgs e)
        {
            concludedContractsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allSalariesL.Font = profitL.Font = paymentStaytmentL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ConcludedContracts?.Invoke(this, EventArgs.Empty);
        }

        private void profitL_Click(object sender, EventArgs e)
        {
            profitL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allSalariesL.Font = paymentStaytmentL.Font = concludedContractsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ProfitOfAgency?.Invoke(this, EventArgs.Empty);
        }
    }
}
