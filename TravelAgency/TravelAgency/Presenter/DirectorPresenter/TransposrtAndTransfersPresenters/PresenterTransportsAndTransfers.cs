using System;
using TravelAgency.Models;
using TravelAgency.Views;
using System.Windows.Forms;

namespace TravelAgency.Presenter
{
    internal class PresenterTransportsAndTransfers
    {
        IViewTransportAndTransfersForm view;
        ModelTransportAndTransfersForm model;

        public event EventHandler OpenFormEditTransports;
        public event EventHandler OpenFormToShowTransfers;
        public event EventHandler OpenFormCreateNewTransport;
        public event EventHandler OpenFormShowTransports;
        public event EventHandler OpenFormCreateNewTransfers;
        public event EventHandler OpenFormEditTransfers;

        public PresenterTransportsAndTransfers(IViewTransportAndTransfersForm view, ModelTransportAndTransfersForm model)
        {
            this.view = view;
            this.model = model;

            view.OpenFormCreateNewTransport += View_OpenFormCreateNewTransport;
            view.OpenFormEditTransports += View_OpenFormEditTransport;
            view.OpenFormToShowTransfers += View_OpenFormToShowTransfers;
            view.OpenFormShowTransports += View_OpenFormShowTransport;
            view.OpenFormCreateTransfers += View_OpenFormCreateTransfers;
            view.OpenFormEditTransfers += View_OpenFormEditTransfers;
        }

        private void View_OpenFormEditTransfers(object sender, EventArgs e)
        {
            OpenFormEditTransfers?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormCreateTransfers(object sender, EventArgs e)
        {
            OpenFormCreateNewTransfers?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormShowTransport(object sender, EventArgs e)
        {
            OpenFormShowTransports?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormToShowTransfers(object sender, EventArgs e)
        {
            OpenFormToShowTransfers?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormEditTransport(object sender, EventArgs e)
        {
            OpenFormEditTransports?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormCreateNewTransport(object sender, EventArgs e)
        {
            OpenFormCreateNewTransport?.Invoke(this, EventArgs.Empty);
        }

        public void OpenWindow()
        {
            view.OpenWindow();
        }
        public void ChangeStyle(string text)
        {
            view.ChangeStyle(text);
        }
        public void Show() 
        {
            view.ShowForm();
        }
        
        public void Close()
        {
            view.CloseForm();
        }
        public void AddOnPanelForm(Form form)
        {
            view.addOnPanelForm(form);
        }
    }
}
