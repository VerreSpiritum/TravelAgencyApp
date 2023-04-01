using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;



namespace TravelAgency.Presenter
{
    internal class PresenterAuthorizationForm
    {
        private ModelAuthorizationForm model = new ModelAuthorizationForm();
        private IViewAutorizationForm viewAutorizationForm;
        private NpgsqlConnection connection;
        public event EventHandler openDirectorForm;

        public PresenterAuthorizationForm(IViewAutorizationForm v, ModelAuthorizationForm m)
        {
            viewAutorizationForm = v;
            model = m;

            viewAutorizationForm.ConnectToDB += ViewAutorizationForm_ConnectToDB;
        }

        private void ViewAutorizationForm_ConnectToDB(object sender, EventArgs e)
        {
            model.Login = viewAutorizationForm.Login;
            model.Password = viewAutorizationForm.Password;

            if (!string.IsNullOrEmpty(model.Login) && !string.IsNullOrEmpty(model.Password) && model.Login.ToLower() != "postgres") 
            {
                model.ConnectingToDB();
                string error = model.Error;
                if(!string.IsNullOrEmpty(error))
                {
                    viewAutorizationForm.ErrorMessage(error);
                }
                else
                {
                    connection = model.Connection;
                    if (openDirectorForm != null)
                        openDirectorForm(sender, EventArgs.Empty);
                }
            }
            else
            {
                viewAutorizationForm.ErrorMessage("Перевірте правильність заповнення полів!");
            }
        }
        public NpgsqlConnection getConnection()
        {
            return connection;
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
