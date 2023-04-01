using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Presenter;
using Npgsql;
using System.Windows.Forms;

namespace TravelAgency.Controllers
{
    internal class ApplicationController
    {
        private PresenterAuthorizationForm authorizationForm;
        private PresenterDirectorMainPage directorMainForm;
        private PresenterHumanResourcesForm humanResourcesForm;
        private PresenterCreateNewStaff createNewStaff;
        private PresenterEditEmployee editEmployeeForm;
        private PresenterListOfAllStaff listOfAllStaff;
        private PresenterShowUsers listOfAllUsers;
        private PresenterEditUser editUser;

        ModelAuthorizationForm modelAuthorizationForm = new ModelAuthorizationForm();
        ModelDirectorMainPage modelDirectorMainForm = new ModelDirectorMainPage();
        ModelHumanResourcesForm modelHumanResourcesForm = new ModelHumanResourcesForm();
        ModelCreateNewStaff modelCreateNewStaff = new ModelCreateNewStaff();
        ModelEditEmployee modelEditEmployee = new ModelEditEmployee();
        ModelListOfAllStaff modelListOfAllStaff;
        ModelShowUsers modelListOfAllUsers;
        ModelEditUser modelEditUser;

        private HumanResourcesForm humanResources = new HumanResourcesForm();
        private CreateNewStaff createNewStaffForm = new CreateNewStaff();
        private EditEmployee editEmployee = new EditEmployee();
        private ShowStaff showStaff;
        private ShowUsers showUsers;
        private EditUser editUserForm;

        private bool checkOpenPackageServices = false;


        private List<Form> OpenedForms = new List<Form>();


        public ApplicationController(Authorization form)
        {
            authorizationForm = new PresenterAuthorizationForm(form, modelAuthorizationForm);
            directorMainForm = new PresenterDirectorMainPage(new DirectorMainPage(), modelDirectorMainForm);
            humanResourcesForm = new PresenterHumanResourcesForm(humanResources, modelHumanResourcesForm);
            createNewStaff = new PresenterCreateNewStaff(createNewStaffForm, modelCreateNewStaff);
            editEmployeeForm = new PresenterEditEmployee(editEmployee, modelEditEmployee);

            authorizationForm.openDirectorForm += AuthorizationForm_openDirectorForm;

            directorMainForm.OpenHumanResourcesForm += DirectorMainForm_OpenHumanResourcesForm;
            directorMainForm.OpenServicePackageForm += DirectorMainForm_ServicePackage;

            humanResourcesForm.OpenFormToCreateNewStaff += HumanResourcesForm_OpenFormToCreateNewStaff;
            humanResourcesForm.OpenFormToEditEmployee += HumanResourcesForm_OpenFormToEditEmployee;
            humanResourcesForm.OpenFormToShowUsers += HumanResourcesForm_OpenFormToShowUsers;
            humanResourcesForm.OpenFormToShowAllStaff += HumanResourcesForm_OpenFormToShowAllStaff;   
        }


        #region --- Director ---
        
        
        private void ChangeMenu(string name)
        {
            humanResources.ChangeStyle(name);
        }

        public NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = authorizationForm.getConnection();
            return connection;
        }

        private void ListOfAllUsers_OpenEditorToChangeUserInfo(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editUserForm))
            {
                editUserForm = new EditUser();
                modelEditUser = new ModelEditUser(GetConnection());

                editUser = new PresenterEditUser(modelEditUser, editUserForm);
                listOfAllUsers.AddFormOnPanel(editUserForm);
                editUser.Show();

                OpenedForms.Add(editUserForm);
            }
        }
        private void ListOfAllStaff_OpenFormToEditEmployee(object sender, EventArgs e)
        {
            int talonNum = listOfAllStaff.talonNum;
            CloseOpenedFormInResourcesForm(editEmployee);
            editEmployee = new EditEmployee();
            editEmployeeForm = new PresenterEditEmployee(editEmployee, modelEditEmployee);
            editEmployeeForm.connection = GetConnection();
            humanResourcesForm.AddOnPanelForm(editEmployee);
            ChangeMenu("Редагувати співробітника");
            editEmployeeForm.Show(talonNum);

            OpenedForms.Add(editEmployee);
        }
        

        private void OpenListOfAllStaff()
        {
            showStaff = new ShowStaff();
            modelListOfAllStaff = new ModelListOfAllStaff(GetConnection());
            listOfAllStaff = new PresenterListOfAllStaff(modelListOfAllStaff, showStaff);
            humanResourcesForm.AddOnPanelForm(showStaff);
            listOfAllStaff.Show(modelListOfAllStaff.GetInfoAboutStaff());
            ListOfAllStaffEvent(listOfAllStaff);

            OpenedForms.Add(showStaff);
        }
        private void OpenListOfAllUsers()
        {
            showUsers = new ShowUsers();
            modelListOfAllUsers = new ModelShowUsers(GetConnection());
            listOfAllUsers = new PresenterShowUsers(modelListOfAllUsers, showUsers);
            humanResourcesForm.AddOnPanelForm(showUsers);
            listOfAllUsers.Show();
            ListOfAllUsersEvent(listOfAllUsers);

            OpenedForms.Add(showUsers);
        }

        #region --- Opened from Human Resources Form ---
        private void HumanResourcesForm_OpenFormToShowUsers(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showUsers))
            {
                CloseOpenedFormInResourcesForm(showUsers);
                OpenListOfAllUsers();
            }
        }
        private void HumanResourcesForm_OpenFormToEditEmployee(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editEmployee))
            {
                CloseOpenedFormInResourcesForm(editEmployee);
                editEmployee = new EditEmployee();
                editEmployeeForm = new PresenterEditEmployee(editEmployee, modelEditEmployee);
                editEmployeeForm.connection = GetConnection();
                humanResourcesForm.AddOnPanelForm(editEmployee);
                editEmployeeForm.Show();

                OpenedForms.Add(editEmployee);
            }
        }
        private void HumanResourcesForm_OpenFormToShowAllStaff(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showStaff))
            {
                CloseOpenedFormInResourcesForm(showStaff);
                OpenListOfAllStaff();
            }
        }
        private void HumanResourcesForm_OpenFormToCreateNewStaff(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createNewStaffForm))
            {
                CloseOpenedFormInResourcesForm(createNewStaffForm);
                createNewStaffForm = new CreateNewStaff();
                createNewStaff = new PresenterCreateNewStaff(createNewStaffForm, modelCreateNewStaff);
                createNewStaff.connection = GetConnection();
                humanResourcesForm.AddOnPanelForm(createNewStaffForm);
                createNewStaff.Show();

                OpenedForms.Add(createNewStaffForm);
            }
        }
        #endregion
        #region --- Close opened forms ---
        private void CloseOpenedFormInResourcesForm()
        {
            if (OpenedForms.Contains(createNewStaffForm))
            {
                createNewStaff.Close();

                OpenedForms.Remove(createNewStaffForm);
            }
            else if (OpenedForms.Contains(showUsers))
            {
                listOfAllUsers.Close();
                OpenedForms.Remove(showUsers);
            }
            else if (OpenedForms.Contains(editEmployee))
            {
                editEmployee.Close();
                OpenedForms.Remove(editEmployee);
            }
            else if (OpenedForms.Contains(showStaff))
            {
                listOfAllStaff.Close();
                OpenedForms.Remove(showStaff);
            }
        }
        private void CloseOpenedFormInResourcesForm(Form senderCheck)//если хотим открыть, то не закрываем а пропускаем
        {
            if (OpenedForms.Contains(createNewStaffForm) && senderCheck != createNewStaffForm)
            {
                createNewStaff.Close();

                OpenedForms.Remove(createNewStaffForm);
            }
            else if (OpenedForms.Contains(showUsers) && senderCheck != showUsers)
            {
                listOfAllUsers.Close();
                OpenedForms.Remove(showUsers);
            }
            else if (OpenedForms.Contains(editEmployee) && senderCheck != editEmployee)
            {
                editEmployee.Close();
                OpenedForms.Remove(editEmployee);
            }
            else if (OpenedForms.Contains(showStaff) && senderCheck != showStaff)
            {
                listOfAllStaff.Close();
                OpenedForms.Remove(showStaff);
            }
        }
        #endregion
        #region --- Methods with list of all forms event ---
        private void ListOfAllStaffEvent(PresenterListOfAllStaff presenter)
        {
            presenter.OpenFormToEditEmployee += ListOfAllStaff_OpenFormToEditEmployee;
        }
        private void ListOfAllUsersEvent(PresenterShowUsers presenter)
        {
            listOfAllUsers.OpenEditorToChangeUserInfo += ListOfAllUsers_OpenEditorToChangeUserInfo;
        }
        #endregion
        #region --- Opened from Main menu ---
        private void DirectorMainForm_ServicePackage(object sender, EventArgs e)
        {
            if (!checkOpenPackageServices)
            {
                CloseOpenedFormInResourcesForm();
                humanResourcesForm.Close();

                OpenedForms.Remove(humanResources);
                checkOpenPackageServices = true;
            }
        }
        private void DirectorMainForm_OpenHumanResourcesForm(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(humanResources))
            {
                humanResources.OpenWindow();
                humanResourcesForm.Show();

                OpenListOfAllStaff();

                OpenedForms.Add(humanResources);
                checkOpenPackageServices = false;
            }
        }
        #endregion

        #endregion


        private void AuthorizationForm_openDirectorForm(object sender, EventArgs e)
        {
            authorizationForm.Close();
            directorMainForm.Show();

            directorMainForm.AddOnPanelHumanResources(humanResources);
            humanResources.OpenWindow();
            humanResourcesForm.Show();

            OpenedForms.Add(humanResources);

            OpenListOfAllStaff();
        }

        public void Run()
        {
            authorizationForm.Run();
        }

    }
}

