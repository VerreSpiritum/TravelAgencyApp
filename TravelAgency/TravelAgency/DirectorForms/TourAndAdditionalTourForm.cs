using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Director.DirectorView;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class TourAndAdditionalTourForm : Form, IViewTourAndAdditionalTour
    {
        private List<Label> menu = new List<Label>();
        public TourAndAdditionalTourForm()
        {
            InitializeComponent();

            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allTourL);
            menu.Add(editTourL);
            menu.Add(newTourL);


        }
        #region --- Interface ---

        public event EventHandler ShowAllTours;
        public event EventHandler EditTour;
        public event EventHandler CreateTour;
        public event EventHandler ShowAllAddTours;
        public event EventHandler EditAddTour;
        public event EventHandler CreateAddTour;

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
            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editTourL.Font = allAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
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
            newTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editTourL.Font = allAddTourL.Font = allTourL.Font = editAddTourL.Font = createAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);


            CreateTour?.Invoke(this, EventArgs.Empty);
        }

        private void editEmployeeL_Click(object sender, EventArgs e)
        {
            editTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newTourL.Font = allAddTourL.Font = allTourL.Font = editAddTourL.Font = createAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            EditTour?.Invoke(this, EventArgs.Empty);
        }

        private void showEmployeeL_Click(object sender, EventArgs e)
        {
            allAddTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newTourL.Font = editTourL.Font = allTourL.Font = editAddTourL.Font = createAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowAllAddTours?.Invoke(this, EventArgs.Empty);
        }

        private void allStaffL_Click(object sender, EventArgs e)
        {
            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newTourL.Font = allAddTourL.Font = editTourL.Font = editAddTourL.Font = createAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowAllTours?.Invoke(this, EventArgs.Empty);
        }

        private void createAddTourL_Click(object sender, EventArgs e)
        {
            createAddTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allTourL.Font = newTourL.Font = allAddTourL.Font = editTourL.Font = editAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        
            CreateAddTour?.Invoke(this, EventArgs.Empty);
        }

        private void editAddTourL_Click(object sender, EventArgs e)
        {
            editAddTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allTourL.Font = newTourL.Font = allAddTourL.Font = editTourL.Font = createAddTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
            
            EditAddTour?.Invoke(this, EventArgs.Empty);
        }
    }
}
