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
    public partial class HumanResoucesForm : Form, IViewHumanResoucesForm
    {
        public event EventHandler OpenFormCreateNewStaff;

        public HumanResoucesForm()
        {
            InitializeComponent();

            newEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
        }

        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Hide();
        }
        public void addOnPanelCreateNewStaff(CreateNewStaff form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
        }
        
        private void newEmployeeL_Click(object sender, EventArgs e)
        {
            newEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = deleteEmployeeL.Font = newUserL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
            
            if(OpenFormCreateNewStaff!= null)
            {
                OpenFormCreateNewStaff(this, EventArgs.Empty);
            }
        
        }

        private void editEmployeeL_Click(object sender, EventArgs e)
        {
            editEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newEmployeeL.Font = deleteEmployeeL.Font = newUserL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }

        private void deleteEmployeeL_Click(object sender, EventArgs e)
        {
            deleteEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = newEmployeeL.Font = newUserL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }

        private void newUserL_Click(object sender, EventArgs e)
        {
            newUserL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = deleteEmployeeL.Font = editEmployeeL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
    }
}
