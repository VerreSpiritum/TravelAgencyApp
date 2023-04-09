using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Director.DirectorView;

namespace TravelAgency.Presenter.DirectorPresenter
{
    internal class PresenterHotelAndRooms
    {
        IViewHotel view;

        public PresenterHotelAndRooms(IViewHotel view)
        {
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
