using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterEditUser
    {
        public ModelEditUser model;
        public IViewEditUsers view;

        public PresenterEditUser(ModelEditUser model, IViewEditUsers view)
        {
            this.model = model;
            this.view = view;

        
        }

        public void Show()
        {
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
