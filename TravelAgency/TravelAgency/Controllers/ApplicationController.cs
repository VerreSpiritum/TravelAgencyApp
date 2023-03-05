using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Presenter;
using Npgsql;

namespace TravelAgency.Controllers
{
    internal class ApplicationController
    {
        public PresenterAutorizationForm autorizationForm { get; set; }
        public PresenterDirectorMainPage directorMainForm;
        public PresenterHumanResoucesForm humanResoucesForm;
        public PresenterCreateNewStaff createNewStaff;

        ModelAutorizationForm modelAutorizationForm = new ModelAutorizationForm();
        ModelDirectorMainPage modelDirectorMainForm = new ModelDirectorMainPage();
        ModelHumanResoucesForm modelHumanResoucesForm = new ModelHumanResoucesForm();
        ModelCreateNewStaff modelCreateNewStaff = new ModelCreateNewStaff();

        private HumanResoucesForm HumanResoucesForm = new HumanResoucesForm();
        private CreateNewStaff CreateNewStaffForm = new CreateNewStaff();
        private bool checkOpenHumanResoucesForm = false;
        private bool checkOpenCreateNewStaffForm = false;


        public ApplicationController(Autorization form) 
        {
            autorizationForm = new PresenterAutorizationForm(form, modelAutorizationForm);
            directorMainForm = new PresenterDirectorMainPage(new DirectorMainPage(), modelDirectorMainForm);
            humanResoucesForm = new PresenterHumanResoucesForm(HumanResoucesForm, modelHumanResoucesForm);
            createNewStaff = new PresenterCreateNewStaff(CreateNewStaffForm, modelCreateNewStaff);
            
            autorizationForm.openDirectorForm += AutorizationForm_openDirectorForm;

            directorMainForm.OpenHumanResoucesForm += DirectorMainForm_OpenHumanResoucesForm;
            directorMainForm.OpenServicePackageForm += DirectorMainForm_ServicePackage;

            humanResoucesForm.OpenFormToCreateNewStaff += HumanResoucesForm_OpenFormToCreateNewStaff;
            createNewStaff.getConnection += CreateNewStaff_getConnection;
        }

        private void CreateNewStaff_getConnection(object sender, EventArgs e)
        {
            NpgsqlConnection connection = autorizationForm.getConnection();
            createNewStaff.connection = connection;
        }

        private void DirectorMainForm_ServicePackage(object sender, EventArgs e)
        {
            if (checkOpenHumanResoucesForm)
            {
                humanResoucesForm.Close();
                checkOpenHumanResoucesForm= false;
            }
        }

        private void HumanResoucesForm_OpenFormToCreateNewStaff(object sender, EventArgs e)
        {
            if(!checkOpenCreateNewStaffForm)
            {
                humanResoucesForm.AddOnPanelCreateNewStaff(CreateNewStaffForm);
                createNewStaff.Show();
            }
        }

        private void DirectorMainForm_OpenHumanResoucesForm(object sender, EventArgs e)
        {
            if (!checkOpenHumanResoucesForm)
            {
                directorMainForm.AddOnPanelHumanResources(HumanResoucesForm);
                humanResoucesForm.Show();
            }
        }

        private void AutorizationForm_openDirectorForm(object sender, EventArgs e)
        { 
            autorizationForm.Close();
            directorMainForm.Show();
            directorMainForm.AddOnPanelHumanResources(HumanResoucesForm);
            humanResoucesForm.Show();
            checkOpenHumanResoucesForm = true;
            humanResoucesForm.AddOnPanelCreateNewStaff(CreateNewStaffForm);
            createNewStaff.Show();
        }

        

        public void Run()
        {
            autorizationForm.Run();
        }
    }
}
