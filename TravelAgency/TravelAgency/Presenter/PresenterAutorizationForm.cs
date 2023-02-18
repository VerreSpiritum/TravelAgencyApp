using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;



namespace TravelAgency.Presenter
{
    internal class PresenterAutorizationForm
    {
        private ModelAutorizationForm model = new ModelAutorizationForm();
        private IViewAutorizationForm viewAutorizationForm;

        public event EventHandler openDirectorForm;

        public PresenterAutorizationForm(IViewAutorizationForm v, ModelAutorizationForm m)
        {
            viewAutorizationForm = v;
            model = m;

            viewAutorizationForm.ConnectToDB += ViewAutorizationForm_ConnectToDB;
        }

        private void ViewAutorizationForm_ConnectToDB(object sender, EventArgs e)
        {
            model.Login = viewAutorizationForm.Login;
            model.Password = viewAutorizationForm.Password;

            if (!string.IsNullOrEmpty(model.Login) && !string.IsNullOrEmpty(model.Password)) 
            {
                string error = model.ConnectingToDB();
                if(!string.IsNullOrEmpty(error))
                {
                    viewAutorizationForm.ErrorMessage(error);
                }
                else
                {
                    if (openDirectorForm != null)
                        openDirectorForm(sender, EventArgs.Empty);
                }
            }
        }
        public void Close()
        {
            viewAutorizationForm.CloseForm();
        }
        public void Run()
        {
            viewAutorizationForm.Run();
        }
    }
}
