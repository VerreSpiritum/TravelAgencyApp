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
    internal class PresenterRatingsPanel
    {
        IViewRatingPanel view;

        public event EventHandler tourRating;
        public event EventHandler AgecyPopylarity;

        public PresenterRatingsPanel(IViewRatingPanel view)
        {
            this.view = view;

            view.tourRating += View_tourRating;
            view.AgecyPopylarity += View_AgecyPopylarity;
        }

        private void View_AgecyPopylarity(object sender, EventArgs e)
        {
            AgecyPopylarity?.Invoke(this, EventArgs.Empty);
        }

        private void View_tourRating(object sender, EventArgs e)
        {
            tourRating?.Invoke(this, EventArgs.Empty);
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
