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
    public partial class HumanResourcesForm : Form, IViewHumanResoucesForm
    {

        public HumanResourcesForm()
        {
            InitializeComponent();

            newEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
        }
        #region --- Interface ---
        public event EventHandler OpenFormEditEmployee;
        public event EventHandler OpenFormDeleteEmployee;
        public event EventHandler OpenFormCreateNewStaff;
        public event EventHandler OpenFormCreateNewUser;
        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }
        
        public void addOnPanelCreateNewStaff(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
        }
        #endregion
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

            if (OpenFormEditEmployee != null)
                OpenFormEditEmployee(this, EventArgs.Empty);
        }

        private void deleteEmployeeL_Click(object sender, EventArgs e)
        {
            deleteEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = newEmployeeL.Font = newUserL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
            
            if(OpenFormDeleteEmployee != null) 
                OpenFormDeleteEmployee(this,EventArgs.Empty);
        }

        private void newUserL_Click(object sender, EventArgs e)
        {
            newUserL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = deleteEmployeeL.Font = editEmployeeL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            if (OpenFormCreateNewUser != null)
                OpenFormCreateNewUser(this, EventArgs.Empty);
        }
    }
}
