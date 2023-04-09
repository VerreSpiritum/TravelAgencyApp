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
using TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Presenter.DirectorPresenter;
using TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;

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
        private PresenterCreateUser createUser;
        private PresenterTransportsAndTransfers transportAndTransferPresenter;
        private PresenterShowTransport showTransportsPresenter;
        private PresenterCreateNewTransport createNewTransportPresenter;
        private PresenterEditTransport EditTransportPresenter;
        private PresenterShowTransfers ShowTransfersPresenter;
        private PresenterCreateTransfer CreateTransfersPresenter;
        private PresenterEditTransfer _PresenterEditTransfer;
        private PresenterTourAndAdditionalTour _PresenterTourAndAdditionalTour;
        private PresenterHotelAndRooms _PresenterHotelAndRooms;
        private PresenterShowTours _PresenterShowTours;
        private PresenterShowAddTours _PresenterShowAddTours;
        private PresenterCreateNewTour _PresenterCreateNewTour;
        private PresenterCreateNewAddTour _PresenterCreateNewAddTour;


        ModelAuthorizationForm modelAuthorizationForm = new ModelAuthorizationForm();
        ModelDirectorMainPage modelDirectorMainForm = new ModelDirectorMainPage();
        ModelHumanResourcesForm modelHumanResourcesForm = new ModelHumanResourcesForm();
        ModelCreateNewStaff modelCreateNewStaff = new ModelCreateNewStaff();
        ModelEditEmployee modelEditEmployee = new ModelEditEmployee();
        ModelListOfAllStaff modelListOfAllStaff;
        ModelShowUsers modelListOfAllUsers;
        ModelEditUser modelEditUser;
        ModelCreateUser modelCreateUser;
        ModelTransportAndTransfersForm ModelTransportAndTransfers;
        ModelShowTransports ModelShowTransports;
        ModelCreateNewTransport modelCreateNewTransport;
        ModelEditTransports EditTransportModel;
        ModelShowTransfers ShowTransfersModel;
        ModelCreateNewTransfer CreateNewTransferModel;
        ModelEditTransfer EditTransferModel;
        ModelShowTours _ModelShowTours;
        ModelShowAddTours _ModelShowAddTours;
        ModelCreateNewTour _ModelCreateNewTour;
        ModelCreateNewAddTour _ModelCreateNewAddTour;


        private HumanResourcesForm humanResources = new HumanResourcesForm();
        private CreateNewStaff createNewStaffForm = new CreateNewStaff();
        private EditEmployee editEmployee = new EditEmployee();
        private ShowStaff showStaff;
        private ShowUsers showUsers;
        private EditUser editUserForm;
        private CreateUser createUserForm;
        private TransferAndTransportsForm transferAndTransportsForm;
        private ShowTransports ShowTransportsForm;
        private CreateNewTransport CreateNewTransportForm;
        private EditTransport EditTransportForm;
        private ShowTransfers ShowTransfersForm;
        private CreateNewTransfer CreateNewTransferForm;
        private EditTransfer EditTransferForm;
        private TourAndAdditionalTourForm tourAndAdditionalTourForm;
        private HotelAndRoomsForm hotelAndRoomsForm;
        private ShowTours showAllTourForm;
        private ShowAddTour showAllAddTourForm;
        private CreateNewTour createNewTour;
        private CreateNewAddTour createNewAddTour;


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
            directorMainForm.OpenTransportsAndTransfersForm += DirectorMainForm_TransportsAndTransfers;
            directorMainForm.OpenTourAddTourForm += DirectorMainForm_OpenTourAddTourForm;
            directorMainForm.OpenHotelInfoForm += DirectorMainForm_OpenHotelInfoForm;

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

        #region --- Human Resources Form ---
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

        private void ListOfAllStaffEvent(PresenterListOfAllStaff presenter)
        {
            presenter.OpenFormToEditEmployee += ListOfAllStaff_OpenFormToEditEmployee;
        }
        private void ListOfAllUsersEvent(PresenterShowUsers presenter)
        {
            listOfAllUsers.OpenEditorToChangeUserInfo += ListOfAllUsers_OpenEditorToChangeUserInfo;
            listOfAllUsers.OpenWindowToCreateUser += ListOfAllUsers_OpenWindowToCreateUser;
        }
        private void ListOfChangeUserEvent(PresenterEditUser presenter)
        {
            presenter.EditUserEvent += ListOfChangeUser_EditUserEvent;
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
        private void ListOfAllUsers_OpenEditorToChangeUserInfo(object sender, EventArgs e)
        {
            if (OpenedForms.Contains(createUserForm))
            {
                createUserForm.Close();
                OpenedForms.Remove(createUserForm);
            }
            if (OpenedForms.Contains(editUserForm))
            {
                editUserForm.Close();
                OpenedForms.Remove(editUserForm);

            }
            editUserForm = new EditUser();
            modelEditUser = new ModelEditUser(GetConnection());

            editUser = new PresenterEditUser(modelEditUser, editUserForm);
            ListOfChangeUserEvent(editUser);
            if (editUserForm.IsDisposed)
            {
                int a = 0;
            }
            listOfAllUsers.AddFormOnPanel(editUserForm);
            editUser.Show(listOfAllUsers.Login);

            OpenedForms.Add(editUserForm);
        }
        private void ListOfAllUsers_OpenWindowToCreateUser(object sender, EventArgs e)
        {
            if (OpenedForms.Contains(editUserForm))
            {
                editUserForm.Close();
                OpenedForms.Remove(editUserForm);
            }
            if (!OpenedForms.Contains(createUserForm))
            {
                createUserForm = new CreateUser();
                modelCreateUser = new ModelCreateUser(GetConnection());

                createUser = new PresenterCreateUser(modelCreateUser, createUserForm);
                ListOfCreateUserEvent(createUser);
                listOfAllUsers.AddFormOnPanel(createUserForm);
                createUser.Show();

                OpenedForms.Add(createUserForm);
            }
        }
        private void ListOfCreateUserEvent(PresenterCreateUser createUser)
        {
            createUser.CloseWindow += ListOfCreateUser_CreateUserEvent;
            createUser.RefreshTable += CreateUser_RefreshTable;
        }

        private void CreateUser_RefreshTable(object sender, EventArgs e)
        {
            listOfAllUsers.RefreshTable();
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
        private void ListOfCreateUser_CreateUserEvent(object sender, EventArgs e)
        {
            createUser.Close();
            OpenedForms.Remove(createUserForm);
        }
        private void ListOfChangeUser_EditUserEvent(object sender, EventArgs e)
        {
            editUser.Close();
            OpenedForms.Remove(editUserForm);
        }

        #endregion
        #region --- Close opened forms ---

        //Human Resources forms
        private void CloseOpenedFormInResourcesForm()
        {
            if (OpenedForms.Contains(createNewStaffForm))
            {
                createNewStaff.Close();

                OpenedForms.Remove(createNewStaffForm);
            }
            else if (OpenedForms.Contains(showUsers))
            {
                if (OpenedForms.Contains(editEmployee))
                {
                    editEmployee.Close();
                    OpenedForms.Remove(editEmployee);
                }
                else if (OpenedForms.Contains(createUserForm))
                {
                    createUser.Close();
                    OpenedForms.Remove(createUserForm);

                }
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
                if(OpenedForms.Contains(editEmployee))
                {
                    editEmployee.Close();
                    OpenedForms.Remove(editEmployee);
                }
                else if(OpenedForms.Contains(createUserForm)) 
                {
                    createUser.Close();
                    OpenedForms.Remove(createUserForm);

                }
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

        //Transport forms
        private void CloseOpenedFormInTransportsForm()
        {
            if (OpenedForms.Contains(ShowTransportsForm))
            {
                ShowTransportsForm.Close();

                OpenedForms.Remove(ShowTransportsForm);
            }
            else if (OpenedForms.Contains(CreateNewTransportForm))
            {
                createNewTransportPresenter.Close();
                OpenedForms.Remove(CreateNewTransportForm);
            }
            else if(OpenedForms.Contains(EditTransportForm))
            {
                EditTransportPresenter.Close();
                OpenedForms.Remove(EditTransportForm);
            }
            else if (OpenedForms.Contains(ShowTransfersForm))
            {
                ShowTransfersPresenter.Close();
                OpenedForms.Remove(ShowTransfersForm);
            }
            else if (OpenedForms.Contains(CreateNewTransferForm))
            {
                CreateTransfersPresenter.Close();
                OpenedForms.Remove(CreateNewTransferForm);
            }
            else if(OpenedForms.Contains(EditTransferForm))
            {
                _PresenterEditTransfer.Close();
                OpenedForms.Remove(EditTransferForm);
            }
        }
        private void CloseOpenedFormInTransportsForm(Form senderCheck)//если хотим открыть, то не закрываем а пропускаем
        {
            if (OpenedForms.Contains(ShowTransportsForm) && senderCheck != ShowTransportsForm)
            {
                showTransportsPresenter.Close();

                OpenedForms.Remove(ShowTransportsForm);
            }
            else if (OpenedForms.Contains(CreateNewTransportForm) && senderCheck != CreateNewTransportForm)
            {
                createNewTransportPresenter.Close();
                OpenedForms.Remove(CreateNewTransportForm);
            }
            else if (OpenedForms.Contains(EditTransportForm) && senderCheck != EditTransportForm)
            {
                EditTransportPresenter.Close();
                OpenedForms.Remove(EditTransportForm);
            }
            else if(OpenedForms.Contains(ShowTransfersForm) && senderCheck != ShowTransfersForm)
            {
                ShowTransfersPresenter.Close();
                OpenedForms.Remove(ShowTransfersForm);
            }
            else if (OpenedForms.Contains(CreateNewTransferForm) && senderCheck != CreateNewTransferForm)
            {
                CreateTransfersPresenter.Close();
                OpenedForms.Remove(CreateNewTransferForm);
            }
            else if (OpenedForms.Contains(EditTransferForm) && senderCheck != EditTransferForm)
            {
                _PresenterEditTransfer.Close();
                OpenedForms.Remove(EditTransferForm);
            }
        }

        //Tour and Additional tour forms
        private void CloseOpenedFormInTourAndAdditionalTour()
        {
            if(OpenedForms.Contains(showAllTourForm))
            {
                _PresenterShowTours.Close();
                OpenedForms.Remove(showAllTourForm);
            }
            else if(OpenedForms.Contains(showAllAddTourForm))
            {
                _PresenterShowAddTours.Close();
                OpenedForms.Remove(showAllAddTourForm);
            }
            else if(OpenedForms.Contains(createNewTour))
            {
                _PresenterCreateNewTour.Close();
                OpenedForms.Remove(createNewTour);
            }
            else if (OpenedForms.Contains(createNewAddTour))
            {
                _PresenterCreateNewAddTour.Close();
                OpenedForms.Remove(createNewAddTour);
            }
        }
        private void CloseOpenedFormInTourAndAdditionalTour(Form senderCheck)
        {
            if (OpenedForms.Contains(showAllTourForm) && senderCheck == showAllTourForm)
            {
                _PresenterShowTours.Close();
                OpenedForms.Remove(showAllTourForm);
            }
            else if (OpenedForms.Contains(showAllAddTourForm) && senderCheck == showAllAddTourForm)
            {
                _PresenterShowAddTours.Close();
                OpenedForms.Remove(showAllAddTourForm);
            }
            else if (OpenedForms.Contains(createNewTour) && senderCheck == createNewTour)
            {
                _PresenterCreateNewTour.Close();
                OpenedForms.Remove(createNewTour);
            }
            else if (OpenedForms.Contains(createNewAddTour) && senderCheck == createNewAddTour)
            {
                _PresenterCreateNewAddTour.Close();
                OpenedForms.Remove(createNewAddTour);
            }
        }

        //Hotel and rooms
        private void CloseOpenedFormInHotelAndRoomsTour()
        { }
        private void CloseOpenedFormInHotelAndRoomsTour(Form senderCheck)
        { }
        #endregion
        #region --- Transport and Transfers ---

        private void TransportAndTransfers_OpenFormShowTransports(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(ShowTransportsForm))
            {
                CloseOpenedFormInTransportsForm(ShowTransportsForm);
                ShowTransportsForm = new ShowTransports();
                ModelShowTransports = new ModelShowTransports(GetConnection());
                showTransportsPresenter = new PresenterShowTransport(ShowTransportsForm, ModelShowTransports);
                transportAndTransferPresenter.AddOnPanelForm(ShowTransportsForm);
                showTransportsPresenter.Show();
                ListOfAllShowTransportsEvent(showTransportsPresenter);

                OpenedForms.Add(ShowTransportsForm);
            }
        }
        private void TransportAndTransfers_OpenFormCreateNewTransport(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(CreateNewTransportForm))
            {
                CloseOpenedFormInTransportsForm(CreateNewTransportForm);
                CreateNewTransportForm = new CreateNewTransport();
                modelCreateNewTransport = new ModelCreateNewTransport(GetConnection());
                createNewTransportPresenter = new PresenterCreateNewTransport(modelCreateNewTransport, CreateNewTransportForm);
                transportAndTransferPresenter.AddOnPanelForm(CreateNewTransportForm);
                createNewTransportPresenter.Show();
                ListOfAllCreateNewTransportEvent(createNewTransportPresenter);

                OpenedForms.Add(CreateNewTransportForm);
            }
        }
        private void TransportAndTransfers_OpenFormEditTransports(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(EditTransportForm))
            {
                CloseOpenedFormInTransportsForm(EditTransportForm);
                EditTransportForm = new EditTransport();
                EditTransportModel = new ModelEditTransports(GetConnection());
                EditTransportPresenter = new PresenterEditTransport(EditTransportModel, EditTransportForm);
                transportAndTransferPresenter.AddOnPanelForm(EditTransportForm);
                EditTransportPresenter.Show();
                ListOfAllShowTransportsEvent(showTransportsPresenter);

                OpenedForms.Add(EditTransportForm);
            }
        }
        private void TransportAndTransfers_OpenFormToShowTransfers(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(ShowTransfersForm))
            {
                CloseOpenedFormInTransportsForm(ShowTransfersForm);
                ShowTransfersForm = new ShowTransfers();
                ShowTransfersModel = new ModelShowTransfers(GetConnection());
                ShowTransfersPresenter = new PresenterShowTransfers(ShowTransfersModel, ShowTransfersForm);
                transportAndTransferPresenter.AddOnPanelForm(ShowTransfersForm);
                ShowTransfersPresenter.Show();
                ListOfAllShowTransfersEvent(ShowTransfersPresenter);
                OpenedForms.Add(ShowTransfersForm);
            }
        }
        private void TransportAndTransfers_OpenFormCreateNewTransfers(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(CreateNewTransferForm))
            {
                CloseOpenedFormInTransportsForm(CreateNewTransferForm);
                CreateNewTransferForm = new CreateNewTransfer();
                CreateNewTransferModel = new ModelCreateNewTransfer(GetConnection());
                CreateTransfersPresenter = new PresenterCreateTransfer(CreateNewTransferModel, CreateNewTransferForm);
                transportAndTransferPresenter.AddOnPanelForm(CreateNewTransferForm);
                CreateTransfersPresenter.Show();
                //ListOfAllShowTransfersEvent(ShowTransfersPresenter);
                OpenedForms.Add(CreateNewTransferForm);
            }
        }
        
        private void Presenter_OpenFormEditTransfers(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(EditTransferForm))
            {
                CloseOpenedFormInTransportsForm(EditTransferForm);
                EditTransferForm = new EditTransfer();
                EditTransferModel = new ModelEditTransfer(GetConnection());
                _PresenterEditTransfer = new PresenterEditTransfer(EditTransferForm, EditTransferModel);
                CreateNewTransferForm = new CreateNewTransfer();
                CreateNewTransferModel = new ModelCreateNewTransfer(GetConnection());
                CreateTransfersPresenter = new PresenterCreateTransfer(CreateNewTransferModel, CreateNewTransferForm);
                transportAndTransferPresenter.AddOnPanelForm(EditTransferForm);
                _PresenterEditTransfer.Show();
                //ListOfAllShowTransfersEvent(ShowTransfersPresenter);
                OpenedForms.Add(EditTransferForm);
            }
        }
        private void ListOfAllShowTransfersEvent(PresenterShowTransfers presenter)
        {
            presenter.EditTransfer += ListOfAllShowTransfersEvent_EditTransfer;
        }
        private void ListOfAllShowTransfersEvent_EditTransfer(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(EditTransferForm))
            {
                CloseOpenedFormInTransportsForm(EditTransferForm);
                EditTransferForm = new EditTransfer();
                EditTransferModel = new ModelEditTransfer(GetConnection());
                _PresenterEditTransfer = new PresenterEditTransfer(EditTransferForm, EditTransferModel);
                transportAndTransferPresenter.ChangeStyle("Редагувати трансфер");
                transportAndTransferPresenter.AddOnPanelForm(EditTransferForm);
                _PresenterEditTransfer.Show(ShowTransfersPresenter.ID);
                //ListOfAllShowTransfersEvent(ShowTransfersPresenter);
                OpenedForms.Add(EditTransferForm);
            }
        }
        private void ListOfAllCreateNewTransportEvent(PresenterCreateNewTransport presenter)
        {

        }
        private void ListOfAllShowTransportsEvent(PresenterShowTransport presenter)
        {
            presenter.OpenFormToEdit += ListOfAllShowTransportsEvent_OpenFormToEdit;
        }
        private void ListOfAllShowTransportsEvent_OpenFormToEdit(object sender, EventArgs e)
        {
            int talonNum = showTransportsPresenter.ID;
            CloseOpenedFormInTransportsForm(ShowTransportsForm);
            EditTransportForm = new EditTransport();
            EditTransportModel = new ModelEditTransports(GetConnection());
            EditTransportPresenter = new PresenterEditTransport(EditTransportModel, EditTransportForm);
            transportAndTransferPresenter.AddOnPanelForm(EditTransportForm);
            transportAndTransferPresenter.ChangeStyle("Редагувати транспорт");
            EditTransportPresenter.Show(talonNum);

            OpenedForms.Remove(ShowTransportsForm);
            OpenedForms.Add(EditTransportForm);
        }

        #endregion
        #region --- Tours and Additional tours ---
        private void Presenter_ShowAllTours(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(showAllTourForm))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                showAllTourForm = new ShowTours();
                _ModelShowTours = new ModelShowTours(GetConnection());
                _PresenterShowTours = new PresenterShowTours(showAllTourForm, _ModelShowTours);
                _PresenterTourAndAdditionalTour.AddOnPanel(showAllTourForm);

                _PresenterShowTours.Show();
                OpenedForms.Add(showAllTourForm);
            }
        }
        private void Presenter_ShowAllAddTours(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showAllAddTourForm))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                showAllAddTourForm = new ShowAddTour();
                _ModelShowAddTours = new ModelShowAddTours(GetConnection());
                _PresenterShowAddTours = new PresenterShowAddTours(showAllAddTourForm, _ModelShowAddTours);
                _PresenterTourAndAdditionalTour.AddOnPanel(showAllAddTourForm);

                _PresenterShowAddTours.Show();
                OpenedForms.Add(showAllAddTourForm);
            }
        }
        private void Presenter_CreateTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createNewTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                createNewTour = new CreateNewTour();
                _ModelCreateNewTour = new ModelCreateNewTour(GetConnection());
                _PresenterCreateNewTour = new PresenterCreateNewTour(createNewTour, _ModelCreateNewTour);

                _PresenterTourAndAdditionalTour.AddOnPanel(createNewTour);

                _PresenterCreateNewTour.Show();

                OpenedForms.Add(createNewTour);
            }
        }
        private void Presenter_CreateAddTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createNewAddTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                createNewAddTour = new CreateNewAddTour();
                _ModelCreateNewAddTour = new ModelCreateNewAddTour(GetConnection());
                _PresenterCreateNewAddTour = new PresenterCreateNewAddTour(createNewAddTour, _ModelCreateNewAddTour);

                _PresenterTourAndAdditionalTour.AddOnPanel(createNewAddTour);

                _PresenterCreateNewAddTour.Show();

                OpenedForms.Add(createNewAddTour);
            }
        }
        #endregion

        #region --- Opened from Main menu ---

        private void DirectorMainForm_OpenHumanResourcesForm(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(humanResources))
            {
                CloseOpenedFormsFromMainMenu();
                humanResources.OpenWindow();
                humanResourcesForm.Show();

                OpenListOfAllStaff();
                OpenedForms.Add(humanResources);
            }
            
        }
        private void DirectorMainForm_TransportsAndTransfers(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(transferAndTransportsForm))
            {
                CloseOpenedFormsFromMainMenu();

                transferAndTransportsForm = new TransferAndTransportsForm();
                ModelTransportAndTransfers = new ModelTransportAndTransfersForm();

                transportAndTransferPresenter = new PresenterTransportsAndTransfers(transferAndTransportsForm, ModelTransportAndTransfers);
                ListOfAllTransportsAndTransfersEvent(transportAndTransferPresenter);
                directorMainForm.AddOnPanel(transferAndTransportsForm);
                transportAndTransferPresenter.Show();

                ShowTransportsForm = new ShowTransports();
                ModelShowTransports = new ModelShowTransports(GetConnection());
                showTransportsPresenter = new PresenterShowTransport(ShowTransportsForm, ModelShowTransports);
                
                transportAndTransferPresenter.AddOnPanelForm(ShowTransportsForm);
                showTransportsPresenter.Show();
                ListOfAllShowTransportsEvent(showTransportsPresenter);

                OpenedForms.Add(ShowTransportsForm);
                OpenedForms.Add(transferAndTransportsForm);
            }
        }
        
        private void ListOfAllTransportsAndTransfersEvent(PresenterTransportsAndTransfers presenter)
        {
            presenter.OpenFormShowTransports += TransportAndTransfers_OpenFormShowTransports;
            presenter.OpenFormCreateNewTransport += TransportAndTransfers_OpenFormCreateNewTransport;
            presenter.OpenFormEditTransports += TransportAndTransfers_OpenFormEditTransports;
            presenter.OpenFormToShowTransfers += TransportAndTransfers_OpenFormToShowTransfers;
            presenter.OpenFormCreateNewTransfers += TransportAndTransfers_OpenFormCreateNewTransfers;
            presenter.OpenFormEditTransfers += Presenter_OpenFormEditTransfers;
        }
        private void ListOfAllTourAndAdditionalTourEvent(PresenterTourAndAdditionalTour presenter)
        {
            presenter.ShowAllTours += Presenter_ShowAllTours;
            presenter.ShowAllAddTours += Presenter_ShowAllAddTours;
            presenter.CreateTour += Presenter_CreateTour;
            presenter.CreateAddTour += Presenter_CreateAddTour;
        }

        

        private void ListOfAllHotelEvent(PresenterHotelAndRooms presenter)
        { }

        private void CloseOpenedFormsFromMainMenu()
        {
            if (OpenedForms.Contains(transferAndTransportsForm))
            {
                CloseOpenedFormInTransportsForm();
                transportAndTransferPresenter.Close();
                OpenedForms.Remove(transferAndTransportsForm);
            }
            if (OpenedForms.Contains(humanResources))
            {
                CloseOpenedFormInResourcesForm();
                humanResourcesForm.Close();
                OpenedForms.Remove(humanResources);
            }
            if(OpenedForms.Contains(tourAndAdditionalTourForm))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                _PresenterTourAndAdditionalTour.Close();
                OpenedForms.Remove(tourAndAdditionalTourForm);
            }
            if (OpenedForms.Contains(hotelAndRoomsForm))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                _PresenterHotelAndRooms.Close();
                OpenedForms.Remove(hotelAndRoomsForm);
            }
        }
        
        private void DirectorMainForm_OpenHotelInfoForm(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(hotelAndRoomsForm))
            {
                CloseOpenedFormsFromMainMenu();

                hotelAndRoomsForm = new HotelAndRoomsForm();
                _PresenterHotelAndRooms = new PresenterHotelAndRooms(hotelAndRoomsForm);
                ListOfAllHotelEvent(_PresenterHotelAndRooms);
                directorMainForm.AddOnPanel(hotelAndRoomsForm);
                _PresenterHotelAndRooms.Show();

                OpenedForms.Add(hotelAndRoomsForm);
            }
        }
        private void DirectorMainForm_OpenTourAddTourForm(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(tourAndAdditionalTourForm))
            {
                CloseOpenedFormsFromMainMenu();

                tourAndAdditionalTourForm = new TourAndAdditionalTourForm();
                _PresenterTourAndAdditionalTour = new PresenterTourAndAdditionalTour(tourAndAdditionalTourForm);
                ListOfAllTourAndAdditionalTourEvent(_PresenterTourAndAdditionalTour);

                directorMainForm.AddOnPanel(tourAndAdditionalTourForm);

                showAllTourForm = new ShowTours();
                _ModelShowTours = new ModelShowTours(GetConnection());
                _PresenterShowTours = new PresenterShowTours(showAllTourForm, _ModelShowTours);
                _PresenterTourAndAdditionalTour.AddOnPanel(showAllTourForm);

                _PresenterTourAndAdditionalTour.Show();
                _PresenterShowTours.Show();

                OpenedForms.Add(showAllTourForm);
                OpenedForms.Add(tourAndAdditionalTourForm);
            }
        }
        #endregion

        #endregion

        private void AuthorizationForm_openDirectorForm(object sender, EventArgs e)
        {
            authorizationForm.Close();
            directorMainForm.Show();

            directorMainForm.AddOnPanel(humanResources);
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

