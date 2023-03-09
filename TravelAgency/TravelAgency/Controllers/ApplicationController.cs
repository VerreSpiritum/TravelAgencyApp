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
        public PresenterAuthorizationForm authorizationForm;
        public PresenterDirectorMainPage directorMainForm;
        public PresenterHumanResourcesForm humanResourcesForm;
        public PresenterCreateNewStaff createNewStaff;

        ModelAuthorizationForm modelAuthorizationForm = new ModelAuthorizationForm();
        ModelDirectorMainPage modelDirectorMainForm = new ModelDirectorMainPage();
        ModelHumanResourcesForm modelHumanResourcesForm = new ModelHumanResourcesForm();
        ModelCreateNewStaff modelCreateNewStaff = new ModelCreateNewStaff();

        private HumanResourcesForm HumanResourcesForm = new HumanResourcesForm();
        private CreateNewStaff CreateNewStaffForm = new CreateNewStaff();
        private bool checkOpenHumanResourcesForm = false;
        private bool checkOpenCreateNewStaffForm = false;


        public ApplicationController(Authorization form)
        {
            authorizationForm = new PresenterAuthorizationForm(form, modelAuthorizationForm);
            directorMainForm = new PresenterDirectorMainPage(new DirectorMainPage(), modelDirectorMainForm);
            humanResourcesForm = new PresenterHumanResourcesForm(HumanResourcesForm, modelHumanResourcesForm);
            createNewStaff = new PresenterCreateNewStaff(CreateNewStaffForm, modelCreateNewStaff);

            authorizationForm.openDirectorForm += AuthorizationForm_openDirectorForm;

            directorMainForm.OpenHumanResoucesForm += DirectorMainForm_OpenHumanResourcesForm;
            directorMainForm.OpenServicePackageForm += DirectorMainForm_ServicePackage;

            humanResourcesForm.OpenFormToCreateNewStaff += HumanResourcesForm_OpenFormToCreateNewStaff;
            createNewStaff.getConnection += CreateNewStaff_getConnection;
        }

        private void CreateNewStaff_getConnection(object sender, EventArgs e)
        {
            NpgsqlConnection connection = authorizationForm.getConnection();
            createNewStaff.connection = connection;
        }

        private void DirectorMainForm_ServicePackage(object sender, EventArgs e)
        {
            if (checkOpenHumanResourcesForm)
            {
                humanResourcesForm.Close();
                checkOpenHumanResourcesForm = false;
            }
        }

        private void HumanResourcesForm_OpenFormToCreateNewStaff(object sender, EventArgs e)
        {
            if (!checkOpenCreateNewStaffForm)
            {
                CreateNewStaffForm = new CreateNewStaff();
                createNewStaff = new PresenterCreateNewStaff(CreateNewStaffForm, modelCreateNewStaff);
                humanResourcesForm.AddOnPanelCreateNewStaff(CreateNewStaffForm);
                createNewStaff.Show();

                checkOpenCreateNewStaffForm = true;
                checkOpenHumanResourcesForm = false;
            }
        }

        private void DirectorMainForm_OpenHumanResourcesForm(object sender, EventArgs e)
        {
            if (!checkOpenHumanResourcesForm)
            {
                HumanResourcesForm = new HumanResourcesForm();
                humanResourcesForm = new PresenterHumanResourcesForm(HumanResourcesForm, modelHumanResourcesForm);
                directorMainForm.AddOnPanelHumanResources(HumanResourcesForm);
                humanResourcesForm.Show();
                CreateNewStaffForm = new CreateNewStaff();
                createNewStaff = new PresenterCreateNewStaff(CreateNewStaffForm, modelCreateNewStaff);
                humanResourcesForm.AddOnPanelCreateNewStaff(CreateNewStaffForm);
                createNewStaff.Show();

                checkOpenHumanResourcesForm = true;
                checkOpenCreateNewStaffForm = false;
            }
        }

        private void AuthorizationForm_openDirectorForm(object sender, EventArgs e)
        {
            authorizationForm.Close();
            directorMainForm.Show();
            directorMainForm.AddOnPanelHumanResources(HumanResourcesForm);
            humanResourcesForm.Show();
            checkOpenHumanResourcesForm = true;
            humanResourcesForm.AddOnPanelCreateNewStaff(CreateNewStaffForm);
            createNewStaff.Show();
        }



        public void Run()
        {
            authorizationForm.Run();
        }
    }
}

