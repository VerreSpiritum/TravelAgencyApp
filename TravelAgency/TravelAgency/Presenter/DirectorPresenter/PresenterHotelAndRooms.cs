using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Director.DirectorView;
using TravelAgency.Views.DirectorViews;

namespace TravelAgency.Presenter.DirectorPresenter
{
    internal class PresenterHotelAndRooms
    {
        IViewHotel view;

        public event EventHandler ShowHotel;
        public event EventHandler CreateHotel;
        public event EventHandler EditHotel;
        public event EventHandler ShowRoom;
        public event EventHandler CreateRoom;
        public event EventHandler EditRooms;

        public PresenterHotelAndRooms(IViewHotel view)
        {
            this.view = view;
            view.ShowHotels += View_ShowHotels;
            view.EditHotel += View_EditHotel;
            view.CreateHotel += View_CreateHotel;
            view.ShowRoom += View_ShowRoom;
            view.CreateRoom += View_CreateRoom;
            view.EditRooms += View_EditRooms;
        }

        private void View_EditRooms(object sender, EventArgs e)
        {
            EditRooms?.Invoke(this, new EventArgs());
        }

        private void View_CreateRoom(object sender, EventArgs e)
        {
            CreateRoom?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowRoom(object sender, EventArgs e)
        {
            ShowRoom?.Invoke(this, EventArgs.Empty);
        }

        private void View_CreateHotel(object sender, EventArgs e)
        {
            CreateHotel?.Invoke(this, EventArgs.Empty);
        }

        private void View_EditHotel(object sender, EventArgs e)
        {
            EditHotel?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowHotels(object sender, EventArgs e)
        {
            ShowHotel?.Invoke(this, EventArgs.Empty);
        }
        public void AddOnPanel(Form form)
        {
            view.addOnPanelForm(form);
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
