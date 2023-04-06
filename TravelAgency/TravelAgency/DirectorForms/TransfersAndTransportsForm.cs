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
    public partial class TransferAndTransportsForm : Form, IViewTransportAndTransfersForm
    {
        private List<Label> menu = new List<Label>();
        public TransferAndTransportsForm()
        {
            InitializeComponent();

            allTransportsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allTransportsL);
            menu.Add(editTransportL);
            menu.Add(newTransportL);


        }
        #region --- Interface ---
        public event EventHandler OpenFormEditTransports;
        public event EventHandler OpenFormToShowTransfers;
        public event EventHandler OpenFormCreateNewTransport;
        public event EventHandler OpenFormShowTransports;
        public event EventHandler OpenFormEditTransfers;
        public event EventHandler OpenFormCreateTransfers;


        public void ChangeStyle(string text)
        {
            foreach (Label control in menu)
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
        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Hide();
        }
        public void OpenWindow()
        {
            allTransportsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editTransportL.Font = showEmployeeL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
        public void addOnPanelForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
        }
        #endregion
        
        private void newTransportL_Click(object sender, EventArgs e)
        {
            newTransportL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addTransferL.Font = editTransferL.Font = editTransportL.Font = showEmployeeL.Font = allTransportsL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormCreateNewTransport?.Invoke(this, EventArgs.Empty);

        }

        private void editTransportL_Click(object sender, EventArgs e)
        {
            editTransportL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addTransferL.Font = editTransferL.Font = newTransportL.Font = showEmployeeL.Font = allTransportsL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormEditTransports?.Invoke(this, EventArgs.Empty);
        }

        private void showTransfersL_Click(object sender, EventArgs e)
        {
            showEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addTransferL.Font = editTransferL.Font = newTransportL.Font = editTransportL.Font = allTransportsL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormToShowTransfers?.Invoke(this, EventArgs.Empty);
        }

        private void allTransportsL_Click(object sender, EventArgs e)
        {
            allTransportsL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addTransferL.Font = editTransferL.Font = newTransportL.Font = showEmployeeL.Font = editTransportL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormShowTransports?.Invoke(this, EventArgs.Empty);
        }

        private void addTransferL_Click(object sender, EventArgs e)
        {
            addTransferL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editTransferL.Font = newTransportL.Font = showEmployeeL.Font = editTransportL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormCreateTransfers?.Invoke(this, EventArgs.Empty);

        }

        private void editTransferL_Click(object sender, EventArgs e)
        {
            editTransferL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            addTransferL.Font = newTransportL.Font = showEmployeeL.Font = editTransportL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormEditTransfers?.Invoke(this, EventArgs.Empty);
        }
    }
}
