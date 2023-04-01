using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterListOfAllStaff
    {
        public ModelListOfAllStaff model;
        public IViewListOfAllStaff view;

        public event EventHandler OpenFormToEditEmployee;
        public int talonNum { get; set; }

        public PresenterListOfAllStaff(ModelListOfAllStaff model, IViewListOfAllStaff view)
        {
            this.model = model; 
            this.view = view;

            view.DeleteEmployee += View_DeleteEmployee;
            view.EditEmployee += View_EditEmployee;
        }

        private void View_EditEmployee(object sender, EventArgs e)
        {
            talonNum = view.TalonNum;
            OpenFormToEditEmployee?.Invoke(this, EventArgs.Empty);
        }

        private void View_DeleteEmployee(object sender, EventArgs e)
        {
            if (model.DeleteEmployee(view.TalonNum) == 1)
            {
                view.CheckError = 1;
            }
        }

        public void Show(DataTable dt)
        {
            view.staffInfo = dt;
            view.ShowForm();
        }

        public void Close()
        {
            view.CloseForm();
        }

    }
}
