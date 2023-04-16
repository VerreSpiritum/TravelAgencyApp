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
    internal class PresenterBookerPanel
    {
        IViewBookerPanel view;
        public event EventHandler AllSalaries;
        public event EventHandler ConcludedContracts;
        public event EventHandler PaymentStaytment;
        public event EventHandler ProfitOfAgency;

        public PresenterBookerPanel(IViewBookerPanel view)
        {
            this.view = view;

            view.AllSalaries += View_AllSalaries;
            view.ConcludedContracts += View_ConcludedContracts;
            view.PaymentStaytment += View_PaymentStaytment;
            view.ProfitOfAgency += View_ProfitOfAgency;
        }

        private void View_ProfitOfAgency(object sender, EventArgs e)
        {
            ProfitOfAgency?.Invoke(this, EventArgs.Empty);
        }

        private void View_PaymentStaytment(object sender, EventArgs e)
        {
            PaymentStaytment?.Invoke(this, EventArgs.Empty);
        }

        private void View_ConcludedContracts(object sender, EventArgs e)
        {
            ConcludedContracts?.Invoke(this, EventArgs.Empty);
        }

        private void View_AllSalaries(object sender, EventArgs e)
        {
            AllSalaries?.Invoke(this, EventArgs.Empty);
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
