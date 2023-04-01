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
        private List<Label> menu = new List<Label>();
        public HumanResourcesForm()
        {
            InitializeComponent();

            allStaffL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allStaffL);
            menu.Add(editEmployeeL);
            menu.Add(newUserL);
            menu.Add(newEmployeeL);


        }
        #region --- Interface ---
        public event EventHandler OpenFormEditEmployee;
        public event EventHandler OpenFormToShowUsers;
        public event EventHandler OpenFormCreateNewStaff;
        public event EventHandler OpenFormCreateNewUser;
        public event EventHandler OpenFormShowStaff;

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
            allStaffL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = showEmployeeL.Font = newUserL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
        public void addOnPanelForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
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
        
        private void newEmployeeL_Click(object sender, EventArgs e)
        {
            newEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editEmployeeL.Font = showEmployeeL.Font = newUserL.Font = allStaffL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormCreateNewStaff?.Invoke(this, EventArgs.Empty);

        }

        private void editEmployeeL_Click(object sender, EventArgs e)
        {
            editEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newEmployeeL.Font = showEmployeeL.Font = newUserL.Font = allStaffL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormEditEmployee?.Invoke(this, EventArgs.Empty);
        }

        private void showEmployeeL_Click(object sender, EventArgs e)
        {
            showEmployeeL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newEmployeeL.Font = editEmployeeL.Font = newUserL.Font = allStaffL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormToShowUsers?.Invoke(this, EventArgs.Empty);
        }

        private void newUserL_Click(object sender, EventArgs e)
        {
            newUserL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newEmployeeL.Font = showEmployeeL.Font = editEmployeeL.Font =  allStaffL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormCreateNewUser?.Invoke(this, EventArgs.Empty);
        }

        private void allStaffL_Click(object sender, EventArgs e)
        {
            allStaffL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newEmployeeL.Font = showEmployeeL.Font = editEmployeeL.Font = newUserL.Font =  new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            OpenFormShowStaff?.Invoke(this, EventArgs.Empty);
        }
    }
}
