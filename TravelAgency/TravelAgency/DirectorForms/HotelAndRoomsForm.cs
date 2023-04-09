using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Director.DirectorView;
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class HotelAndRoomsForm : Form, IViewHotel
    {
        private List<Label> menu = new List<Label>();
        public HotelAndRoomsForm()
        {
            InitializeComponent();

            allHotelL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allHotelL);
            menu.Add(editHotelL);
            menu.Add(newHotelL);


        }
        #region --- Interface ---

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
            allHotelL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editHotelL.Font = allHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
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
            newHotelL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            editHotelL.Font = allHotelRoomL.Font = allHotelL.Font = newHotelRoomL.Font = editHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            //OpenFormCreateNewStaff?.Invoke(this, EventArgs.Empty);

        }

        private void editEmployeeL_Click(object sender, EventArgs e)
        {
            editHotelL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newHotelL.Font = allHotelRoomL.Font = allHotelL.Font = newHotelRoomL.Font = editHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            //OpenFormEditEmployee?.Invoke(this, EventArgs.Empty);
        }

        private void showEmployeeL_Click(object sender, EventArgs e)
        {
            allHotelRoomL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newHotelL.Font = editHotelL.Font = allHotelL.Font = newHotelRoomL.Font = editHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            //OpenFormToShowUsers?.Invoke(this, EventArgs.Empty);
        }

        private void allStaffL_Click(object sender, EventArgs e)
        {
            allHotelL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newHotelL.Font = allHotelRoomL.Font = editHotelL.Font = newHotelRoomL.Font = editHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            //OpenFormShowStaff?.Invoke(this, EventArgs.Empty);
        }

        private void newHotelRoomL_Click(object sender, EventArgs e)
        {
            newHotelRoomL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newHotelL.Font = allHotelRoomL.Font = editHotelL.Font = allHotelL.Font = editHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }

        private void editHotelRoomL_Click(object sender, EventArgs e)
        {
            editHotelRoomL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            newHotelL.Font = allHotelRoomL.Font = editHotelL.Font = newHotelRoomL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
    }
}
