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
using TravelAgency.Models.DirectorModels.HotelsAndRooms;
using TravelAgency.Presenter.DirectorPresenter.Booker_panel;
using TravelAgency.Models.DirectorModels.Booker_panel;
using TravelAgency.Presenter.AgentPresenter;
using TravelAgency.Models.AgentModels;
using TravelAgency.Presenter.AgentPresenter.ClientPanel;
using TravelAgency.Models.AgentModels.ClientInfo;
using TravelAgency.Presenter.AgentPresenter.OrdersPanel;
using TravelAgency.Models.AgentModels.BookingsPanel;
using TravelAgency.Forms.AgentForms.OrdersPanel;
using TravelAgency.Presenter.AgentPresenter.ServicePanel;
using System.ComponentModel.Design;
using TravelAgency.Models.AgentModels.ServicePanel;

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
        private PresenterShowHotels _PresenterShowHotels;
        private PresenterEditTour _PresenterEditTour;
        private PresenterEditAddTour _PresenterEditAddTour;
        private PresenterCreateHotel _PresenterCreateHotel;
        private PresenterEditHotel _PresenterEditHotel;
        private PresenterShowRooms _PresenterShowRooms;
        private PresenterCreateRoom _PresenterCreateRoom;
        private PresenterEditRoom _PresenterEditRoom;
        private PresenterBookerPanel _PresenterBookerPanel;
        private PresenterAllSalaries _PresenterAllSalaries;
        private PresenterPaymentStaytment _PresenterPaymentStatment;
        private PresenterConcludedContract _PresenterConcludedContract;
        private PresenterProfit _PresenterProfit;
        private PresenterRatingsPanel _PresenterRatingsPanel;
        private PresenterPopularityOfAgency _PresenterPopularityOfAgency;
        private PresenterTourRating _PresenterTourRating;
        private PresenterAgentMainPage _PresenterAgentMainPage;
        private PresenterPersonalInfo _PresenterPersonalInfo;
        private PresenterClientPanel _PresenterClientPanel;
        private PresenterListOfAllClients _PresenterListOfAllClients;
        private PresenterCreateNewClient _PresenterCreateNewClient;
        private PresenterOrdersPanel _PresenterOrdersPanel;
        private PresenterShowBooking _PresenterShowBooking;
        private PresenterCreateContract _PresenterCreateContract;
        private PresenterServicePanel _PresenterServicePanel;
        private PresenterShowTourToStaff _PresenterShowTourToStaff;
        private PresenterShowAddTourToStaff _PresenterShowAddTourToStaff;
        private PresenterShowHotelToStaff _PresenterShowHotelToStaff;
        private PresenterShowTransferToStaff _PresenterShowTransfersToStaff;

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
        ModelShowHotels _ModelShowHotels;
        ModelEditTour _ModelEditTour;
        ModelEditAddTour _ModelEditAddTour;
        ModelCreateHotel _ModelCreateHotel;
        ModelEditHotel _ModelEditHotel;
        ModelShowRooms _ModelShowRooms;
        ModelCreateRoom _ModelCreateRoom;
        ModelEditRoom _ModelEditRoom;
        ModelAllSalaries _ModelAllSalaries;
        ModelPaymentStaytment _ModelPaymentStaytment;
        ModelConcludedContract _ModelConcludedContract;
        ModelProfit _ModelProfit;
        ModelTourRating _ModelTourRating;
        ModelPopularityOfAgency _ModelPopularityOfAgency;
        ModelPersonalInfo _ModelPersonalInfo;
        ModelAgentMainForm _ModelAgentMainForm;
        ModelListOfAllClients _ModelListOfAllClients;
        ModelAddNewClient _ModelAddNewClient;
        ModelShowBookings _ModelShowBookings;
        ModelCreateContract _ModelCreateContract;
        ModelShowHotelToStaff _ModelShowHotelToStaff;
        ModelShowTourToStaff _ModelShowTourToStaff;
        ModelShowAddTourToStaff _ModelShowAddTourToStaff;
        ModelShowTransferToStaff _ModelShowTransferToStaff;

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
        private ShowHotels showHotels;
        private EditTour editTour;
        private EditAddTour editAddTour;
        private CreateNewHotel createNewHotel;
        private EditHotel editHotel;
        private ShowRooms showRooms;
        private CreateNewRoom createNewRoom;
        private EditRoom editRoom;
        private BookerPanel bookerPanel;
        private AllSalaryOfStaff allSalaries;
        private PaymentStaytment paymentStaytment;
        private ConcludedContracts concludedContracts;
        private ProfitForm profitForm;
        private RatingsPanel ratingsPanel;
        private PopularityOfAgency popularityOfAgency;
        private TourRating tourRating;
        private AgentMainPage agentMainPage;
        private PersonalInfo personalInfo;
        private ClientPanel clientPanel;
        private ShowClients showClients;
        private AddNewClient addNewClient;
        private OrdersPanel ordersPanel;
        private ShowBooking showBooking;
        private CreateContract createContract;
        private ServicePanel servicePanel;
        private ShowAddTourToStaff showAddTourToStaff;
        private ShowTourToStaff showTourToStaff;
        private ShowHotelsToStaff showHotelsToStaff;
        private ShowTransferToStaff showTransferToStaff;

        private List<Form> OpenedForms = new List<Form>();

        private int AgentTalonNum;

        public ApplicationController(Authorization form)
        {
            authorizationForm = new PresenterAuthorizationForm(form, modelAuthorizationForm);
            directorMainForm = new PresenterDirectorMainPage(new DirectorMainPage(), modelDirectorMainForm);
            humanResourcesForm = new PresenterHumanResourcesForm(humanResources, modelHumanResourcesForm);
            createNewStaff = new PresenterCreateNewStaff(createNewStaffForm, modelCreateNewStaff);
            editEmployeeForm = new PresenterEditEmployee(editEmployee, modelEditEmployee);

            authorizationForm.openDirectorForm += AuthorizationForm_openDirectorForm;
            authorizationForm.openAgentForm += AuthorizationForm_openAgentForm;
            directorMainForm.OpenHumanResourcesForm += DirectorMainForm_OpenHumanResourcesForm;
            directorMainForm.OpenTransportsAndTransfersForm += DirectorMainForm_TransportsAndTransfers;
            directorMainForm.OpenTourAddTourForm += DirectorMainForm_OpenTourAddTourForm;
            directorMainForm.OpenHotelInfoForm += DirectorMainForm_OpenHotelInfoForm;
            directorMainForm.OpenBookerForm += DirectorMainForm_OpenBookerForm;
            directorMainForm.OpenRatingsFrom += DirectorMainForm_OpenRatingsFrom;

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
            else if (OpenedForms.Contains(showHotels))
            {
                _PresenterShowHotels.Close();
                OpenedForms.Remove(showHotels);
            }
            else if (OpenedForms.Contains(editTour))
            {
                _PresenterEditTour.Close();
                OpenedForms.Remove(editTour);
            }
            else if (OpenedForms.Contains(editAddTour))
            {
                _PresenterEditAddTour.Close();
                OpenedForms.Remove(editAddTour);
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
            else if (OpenedForms.Contains(editTour) && senderCheck == editTour)
            {
                _PresenterEditTour.Close();
                OpenedForms.Remove(editTour);
            }
            else if (OpenedForms.Contains(editAddTour) && senderCheck == editAddTour)
            {
                _PresenterEditAddTour.Close();
                OpenedForms.Remove(editAddTour);
            }

        }

        //Hotel and rooms
        private void CloseOpenedFormInHotelAndRoomsTour()
        {
            if (OpenedForms.Contains(showHotels))
            {
                _PresenterShowHotels.Close();
                OpenedForms.Remove(showHotels);
            }
            else if (OpenedForms.Contains(createNewHotel))
            {
                _PresenterCreateHotel.Close();
                OpenedForms.Remove(createNewHotel);
            }
            else if (OpenedForms.Contains(editHotel))
            {
                _PresenterEditHotel.Close();
                OpenedForms.Remove(editHotel);
            }
            else if (OpenedForms.Contains(showRooms))
            {
                _PresenterShowRooms.Close();
                OpenedForms.Remove(showRooms);
            }
            else if (OpenedForms.Contains(createNewRoom))
            {
                _PresenterCreateRoom.Close();
                OpenedForms.Remove(createNewRoom);
            }
            else if (OpenedForms.Contains(editRoom))
            {
                _PresenterEditRoom.Close();
                OpenedForms.Remove(editRoom);
            }
        }
        private void CloseOpenedFormInHotelAndRoomsTour(Form senderCheck)
        {
            if (OpenedForms.Contains(showHotels) && senderCheck == showHotels)
            {
                _PresenterShowHotels.Close();
                OpenedForms.Remove(showHotels);
            }
            else if (OpenedForms.Contains(createNewHotel) && senderCheck == createNewHotel)
            {
                _PresenterCreateHotel.Close();
                OpenedForms.Remove(createNewHotel);
            }
        }

        //Boker panel
        private void CloseOpenedFormInBookerPanel()
        {
            if (OpenedForms.Contains(allSalaries))
            {
                _PresenterAllSalaries.Close();
                OpenedForms.Remove(allSalaries);
            }
            else if (OpenedForms.Contains(paymentStaytment))
            {
                _PresenterPaymentStatment.Close();
                OpenedForms.Remove(paymentStaytment);
            }
            else if (OpenedForms.Contains(concludedContracts))
            {
                _PresenterConcludedContract.Close();
                OpenedForms.Remove(concludedContracts);
            }
            else if(OpenedForms.Contains(profitForm))
            {
                _PresenterProfit.Close();
                OpenedForms.Remove(profitForm);
            }
        }

        //Rating
        private void CloseOpenedInRatingsPanel()
        {
            if (OpenedForms.Contains(tourRating))
            {
                _PresenterTourRating.Close();
                OpenedForms.Remove(tourRating);
            }
            else if (OpenedForms.Contains(popularityOfAgency))
            {
                _PresenterPopularityOfAgency.Close();
                OpenedForms.Remove(popularityOfAgency);
            }
        }
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
                _PresenterShowTours.EditTour += _PresenterShowTours_EditTour;
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
                _PresenterShowAddTours.EditTour += _PresenterShowAddTours_EditTour;
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
        private void Presenter_EditTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                editTour = new EditTour();
                _ModelEditTour = new ModelEditTour(GetConnection());
                _PresenterEditTour = new PresenterEditTour(editTour, _ModelEditTour);

                _PresenterTourAndAdditionalTour.AddOnPanel(editTour);

                _PresenterEditTour.Show();

                OpenedForms.Add(editTour);
            }
        }
        private void Presenter_EditAddTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editAddTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                editAddTour = new EditAddTour();
                _ModelEditAddTour = new ModelEditAddTour(GetConnection());
                _PresenterEditAddTour = new PresenterEditAddTour(editAddTour, _ModelEditAddTour);

                _PresenterTourAndAdditionalTour.AddOnPanel(editAddTour);

                _PresenterEditAddTour.Show();

                OpenedForms.Add(editAddTour);
            }
        }

        private void _PresenterShowAddTours_EditTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editAddTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                editAddTour = new EditAddTour();
                _ModelEditAddTour = new ModelEditAddTour(GetConnection());
                _PresenterEditAddTour = new PresenterEditAddTour(editAddTour, _ModelEditAddTour);

                _PresenterTourAndAdditionalTour.ChangeStyle("Змінити додатковий тур");
                _PresenterTourAndAdditionalTour.AddOnPanel(editAddTour);

                _PresenterEditAddTour.Show(_PresenterShowAddTours.ID);

                OpenedForms.Add(editAddTour);
            }
        }
        private void _PresenterShowTours_EditTour(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editTour))
            {
                CloseOpenedFormInTourAndAdditionalTour();
                editTour = new EditTour();
                _ModelEditTour = new ModelEditTour(GetConnection());
                _PresenterEditTour = new PresenterEditTour(editTour, _ModelEditTour);

                _PresenterTourAndAdditionalTour.ChangeStyle("Змінити тур");
                _PresenterTourAndAdditionalTour.AddOnPanel(editTour);

                _PresenterEditTour.Show(_PresenterShowTours.ID);

                OpenedForms.Add(editTour);
            }
        }
        #endregion
        #region --- Hotels and rooms ---
        private void Presenter_ShowHotel(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showHotels))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                showHotels = new ShowHotels();
                _ModelShowHotels = new ModelShowHotels(GetConnection());
                _PresenterShowHotels = new PresenterShowHotels(showHotels, _ModelShowHotels);
                _PresenterHotelAndRooms.AddOnPanel(showHotels);

                _PresenterShowHotels.Show();

                OpenedForms.Add(showHotels);
            }
        }
        private void Presenter_CreateRoom(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createNewRoom))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                createNewRoom = new CreateNewRoom();
                _ModelCreateRoom = new ModelCreateRoom(GetConnection());
                _PresenterCreateRoom = new PresenterCreateRoom(createNewRoom, _ModelCreateRoom);
                _PresenterHotelAndRooms.AddOnPanel(createNewRoom);

                _PresenterCreateRoom.Show();

                OpenedForms.Add(createNewRoom);
            }
        }
        private void Presenter_EditRoom(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editRoom))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                editRoom = new EditRoom();
                _ModelEditRoom = new ModelEditRoom(GetConnection());
                _PresenterEditRoom = new PresenterEditRoom(editRoom, _ModelEditRoom);
               
                _PresenterHotelAndRooms.AddOnPanel(editRoom);
                _PresenterEditRoom.Show();

                OpenedForms.Add(editRoom);
            }
        }
        private void Presenter_CreateHotel(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createNewHotel))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                createNewHotel = new CreateNewHotel();
                _ModelCreateHotel = new ModelCreateHotel(GetConnection());
                _PresenterCreateHotel = new PresenterCreateHotel(createNewHotel, _ModelCreateHotel);
                _PresenterHotelAndRooms.AddOnPanel(createNewHotel);

                _PresenterCreateHotel.Show();

                OpenedForms.Add(createNewHotel);
            }
        }
        private void Presenter_EditHotel(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(editHotel))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                editHotel = new EditHotel();
                _ModelEditHotel = new ModelEditHotel(GetConnection());
                _PresenterEditHotel = new PresenterEditHotel(editHotel, _ModelEditHotel);
                _PresenterHotelAndRooms.AddOnPanel(editHotel);

                _PresenterEditHotel.Show();

                OpenedForms.Add(editHotel);
            }
        }
        private void Presenter_ShowRoom(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showRooms))
            {
                CloseOpenedFormInHotelAndRoomsTour();
                showRooms = new ShowRooms();
                _ModelShowRooms = new ModelShowRooms(GetConnection());
                _PresenterShowRooms = new PresenterShowRooms(showRooms, _ModelShowRooms);
                _PresenterHotelAndRooms.AddOnPanel(showRooms);

                _PresenterShowRooms.Show();

                OpenedForms.Add(showRooms);
            }
        }
        #endregion
        #region --- Booker ---
        private void Presenter_ConcludedContracts(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(concludedContracts))
            {
                CloseOpenedFormInBookerPanel();
                concludedContracts = new ConcludedContracts();
                _ModelConcludedContract = new ModelConcludedContract(GetConnection());
                _PresenterConcludedContract = new PresenterConcludedContract(_ModelConcludedContract, concludedContracts);
                _PresenterBookerPanel.AddOnPanel(concludedContracts);

                _PresenterConcludedContract.Show();
                OpenedForms.Add(concludedContracts);
            }
        }
        private void Presenter_PaymentStaytment(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(paymentStaytment))
            {
                CloseOpenedFormInBookerPanel();
                paymentStaytment = new PaymentStaytment();
                _ModelPaymentStaytment = new ModelPaymentStaytment(GetConnection());
                _PresenterPaymentStatment = new PresenterPaymentStaytment(_ModelPaymentStaytment, paymentStaytment);
                _PresenterBookerPanel.AddOnPanel(paymentStaytment);

                _PresenterPaymentStatment.Show();
                OpenedForms.Add(paymentStaytment);
            }
        }
        private void Presenter_AllSalaries(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(allSalaries))
            {
                CloseOpenedFormInBookerPanel();
                allSalaries = new AllSalaryOfStaff();
                _ModelAllSalaries = new ModelAllSalaries(GetConnection());
                _PresenterAllSalaries = new PresenterAllSalaries(_ModelAllSalaries, allSalaries);
                _PresenterBookerPanel.AddOnPanel(allSalaries);

                _PresenterAllSalaries.Show();

                OpenedForms.Add(allSalaries);
            }
        }
        private void Presenter_ProfitOfAgency(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(profitForm))
            {
                CloseOpenedFormInBookerPanel();
                profitForm = new ProfitForm();
                _ModelProfit = new ModelProfit(GetConnection());
                _PresenterProfit = new PresenterProfit(_ModelProfit, profitForm);
                _PresenterBookerPanel.AddOnPanel(profitForm);

                _PresenterProfit.Show();

                OpenedForms.Add(profitForm);
            }
        }

        #endregion
        #region --- Ratings ---
        private void Presenter_AgecyPopylarity(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(popularityOfAgency))
            {
                CloseOpenedInRatingsPanel();
                popularityOfAgency = new PopularityOfAgency();
                _ModelPopularityOfAgency = new ModelPopularityOfAgency(GetConnection());
                _PresenterPopularityOfAgency = new PresenterPopularityOfAgency(_ModelPopularityOfAgency, popularityOfAgency);
                _PresenterRatingsPanel.AddOnPanel(popularityOfAgency);

                _PresenterPopularityOfAgency.Show();
                OpenedForms.Add(popularityOfAgency);
            }
        }

        private void Presenter_tourRating(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(tourRating))
            {
                CloseOpenedInRatingsPanel();
                tourRating = new TourRating();
                _ModelTourRating = new ModelTourRating(GetConnection());
                _PresenterTourRating = new PresenterTourRating(_ModelTourRating, tourRating);
                _PresenterRatingsPanel.AddOnPanel(tourRating);

                _PresenterTourRating.Show();
                OpenedForms.Add(tourRating);
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
            presenter.EditTour += Presenter_EditTour;
            presenter.EditAddTour += Presenter_EditAddTour;
        }
        private void ListOfAllHotelEvent(PresenterHotelAndRooms presenter)
        {
            presenter.ShowHotel += Presenter_ShowHotel;
            presenter.CreateHotel += Presenter_CreateHotel;
            presenter.EditHotel += Presenter_EditHotel;
            presenter.ShowRoom += Presenter_ShowRoom;
            presenter.CreateRoom += Presenter_CreateRoom;
            presenter.EditRooms += Presenter_EditRoom;
        }
        private void ListOfAllBokerPanelEvent(PresenterBookerPanel presenter)
        {
            presenter.AllSalaries += Presenter_AllSalaries;
            presenter.ConcludedContracts += Presenter_ConcludedContracts;
            presenter.PaymentStaytment += Presenter_PaymentStaytment;
            presenter.ProfitOfAgency += Presenter_ProfitOfAgency;
        }
        private void ListOfAllRatingsPanelEvent(PresenterRatingsPanel presenter)
        {
            presenter.tourRating += Presenter_tourRating;
            presenter.AgecyPopylarity += Presenter_AgecyPopylarity;
        }


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
            if(OpenedForms.Contains(bookerPanel))
            {
                CloseOpenedFormInBookerPanel();
                _PresenterBookerPanel.Close();
                OpenedForms.Remove(bookerPanel);
            }
            if(OpenedForms.Contains(ratingsPanel))
            {
                CloseOpenedInRatingsPanel();
                _PresenterRatingsPanel.Close();
                OpenedForms.Remove(ratingsPanel);
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
                
                showHotels = new ShowHotels();
                _ModelShowHotels = new ModelShowHotels(GetConnection());
                _PresenterShowHotels = new PresenterShowHotels(showHotels, _ModelShowHotels);
                
                _PresenterHotelAndRooms.AddOnPanel(showHotels);
                
                _PresenterHotelAndRooms.Show();
                _PresenterShowHotels.Show();

                OpenedForms.Add(showHotels);
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
                _PresenterShowTours.EditTour += _PresenterShowTours_EditTour;
                _PresenterTourAndAdditionalTour.AddOnPanel(showAllTourForm);

                _PresenterTourAndAdditionalTour.Show();
                _PresenterShowTours.Show();

                OpenedForms.Add(showAllTourForm);
                OpenedForms.Add(tourAndAdditionalTourForm);
            }
        }
        private void DirectorMainForm_OpenBookerForm(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(tourAndAdditionalTourForm))
            {
                CloseOpenedFormsFromMainMenu();

                bookerPanel = new BookerPanel();
                _PresenterBookerPanel = new PresenterBookerPanel(bookerPanel);
                ListOfAllBokerPanelEvent(_PresenterBookerPanel);

                directorMainForm.AddOnPanel(bookerPanel);
                allSalaries = new AllSalaryOfStaff();
                _ModelAllSalaries = new ModelAllSalaries(GetConnection());
                _PresenterAllSalaries = new PresenterAllSalaries(_ModelAllSalaries, allSalaries);
                _PresenterBookerPanel.AddOnPanel(allSalaries);


                OpenedForms.Add(allSalaries);
                OpenedForms.Add(bookerPanel);

                _PresenterBookerPanel.Show();
                _PresenterAllSalaries.Show();

            }
        }
        private void DirectorMainForm_OpenRatingsFrom(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(ratingsPanel))
            {
                CloseOpenedFormsFromMainMenu();

                ratingsPanel = new RatingsPanel();
                _PresenterRatingsPanel = new PresenterRatingsPanel(ratingsPanel);
                ListOfAllRatingsPanelEvent(_PresenterRatingsPanel);
                directorMainForm.AddOnPanel(ratingsPanel);
                
                tourRating = new TourRating();
                _ModelTourRating = new ModelTourRating(GetConnection());
                _PresenterTourRating = new PresenterTourRating(_ModelTourRating, tourRating);
                _PresenterRatingsPanel.AddOnPanel(tourRating);

                OpenedForms.Add(ratingsPanel);
                OpenedForms.Add(tourRating);

                _PresenterRatingsPanel.Show();
                _PresenterTourRating.Show();

            }
        }
        #endregion

        #endregion
        #region --- Agent ---

        private void ListOfAllClientPanelEvent(PresenterClientPanel presenter)
        {
            presenter.AddClient += Presenter_AddClient;
            presenter.ShowListOfCLient += Presenter_ShowListOfCLient;
        }
        private void ListOfAllOrdersPanelEvent(PresenterOrdersPanel presenter)
        {
            presenter.ShowAllBookings += Presenter_ShowAllBookings;
            presenter.ShowAllContracts += Presenter_ShowAllContracts;
            
        }
        private void ListOfAllServicePanelEvent(PresenterServicePanel presenter)
        {
            presenter.ShowTour += Presenter_ShowTour;
            presenter.ShowAddTour += Presenter_ShowAddTour;
            presenter.ShowHotel += Presenter_ShowHotels;
            presenter.ShowTransfer += Presenter_ShowTransfer;
        }

        private void Presenter_ShowTransfer(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(showTransferToStaff))
            {
                CloseOpenedFormsInServicePanel();
                
                showTransferToStaff = new ShowTransferToStaff();
                _ModelShowTransferToStaff = new ModelShowTransferToStaff(GetConnection());
                _PresenterShowTransfersToStaff = new PresenterShowTransferToStaff(showTransferToStaff, _ModelShowTransferToStaff);

                _PresenterServicePanel.AddOnPanel(showTransferToStaff);
                _PresenterShowTransfersToStaff.Show();

                OpenedForms.Add(showTransferToStaff);
            }
        }

        private void Presenter_ShowHotels(object sender, EventArgs e)
        {
            CloseOpenedFormsInServicePanel();

            showHotelsToStaff = new ShowHotelsToStaff();
            _ModelShowHotelToStaff = new ModelShowHotelToStaff(GetConnection());
            _PresenterShowHotelToStaff = new PresenterShowHotelToStaff(showHotelsToStaff, _ModelShowHotelToStaff);

            _PresenterServicePanel.AddOnPanel(showHotelsToStaff);
            _PresenterShowHotelToStaff.Show();

            OpenedForms.Add(showHotelsToStaff);
        }

        private void Presenter_ShowAddTour(object sender, EventArgs e)
        {
            CloseOpenedFormsInServicePanel();

            showAddTourToStaff = new ShowAddTourToStaff();
            _ModelShowAddTourToStaff = new ModelShowAddTourToStaff(GetConnection());
            _PresenterShowAddTourToStaff = new PresenterShowAddTourToStaff(showAddTourToStaff, _ModelShowAddTourToStaff);

            _PresenterServicePanel.AddOnPanel(showAddTourToStaff);
            _PresenterShowAddTourToStaff.Show();

            OpenedForms.Add(showAddTourToStaff);
        }
        private void Presenter_ShowTour(object sender, EventArgs e)
        {
            CloseOpenedFormsInServicePanel();

            showTourToStaff = new ShowTourToStaff();
            _ModelShowTourToStaff = new ModelShowTourToStaff(GetConnection());
            _PresenterShowTourToStaff = new PresenterShowTourToStaff(showTourToStaff, _ModelShowTourToStaff);

            _PresenterServicePanel.AddOnPanel(showTourToStaff);
            _PresenterShowTourToStaff.Show();

            OpenedForms.Add(showTourToStaff);
        }
        
        private void AgentMainPage_OpenPersonalInfo(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(personalInfo))
            {
                CloseOpenedFormsInAgentMainForm();
                personalInfo = new PersonalInfo();
                _ModelPersonalInfo = new ModelPersonalInfo(GetConnection());
                _PresenterPersonalInfo = new PresenterPersonalInfo(_ModelPersonalInfo, personalInfo);

                _PresenterAgentMainPage.AddOnPanel(personalInfo);
                _PresenterPersonalInfo.Show(AgentTalonNum);

                OpenedForms.Add(personalInfo);
            }
        }
   
        private void AgentMainPage_OpenClientForm(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(clientPanel))
            {
                CloseOpenedFormsInAgentMainForm();
                clientPanel = new ClientPanel();
                _PresenterClientPanel = new PresenterClientPanel(clientPanel);
                
                _PresenterAgentMainPage.AddOnPanel(clientPanel);
                showClients = new ShowClients();
                _ModelListOfAllClients = new ModelListOfAllClients(GetConnection());
                _PresenterListOfAllClients = new PresenterListOfAllClients(_ModelListOfAllClients, showClients);
                ListOfAllClientPanelEvent(_PresenterClientPanel);
                _PresenterClientPanel.AddOnPanel(showClients);

                _PresenterClientPanel.Show();
                _PresenterListOfAllClients.Show();

                OpenedForms.Add(showClients);
                OpenedForms.Add(clientPanel);
            }
        }
        private void Presenter_ShowListOfCLient(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showClients))
            {
                CloseOpenedFormsInClientForm();
                
                showClients = new ShowClients();
                _ModelListOfAllClients = new ModelListOfAllClients(GetConnection());
                _PresenterListOfAllClients = new PresenterListOfAllClients(_ModelListOfAllClients, showClients);
                ListOfAllClientPanelEvent(_PresenterClientPanel);
                _PresenterClientPanel.AddOnPanel(showClients);

                _PresenterListOfAllClients.Show();

                OpenedForms.Add(showClients);
            }
        }
        private void Presenter_AddClient(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(addNewClient))
            {
                CloseOpenedFormsInClientForm();

                addNewClient = new AddNewClient();
                _ModelAddNewClient = new ModelAddNewClient(GetConnection());
                _PresenterCreateNewClient = new PresenterCreateNewClient(_ModelAddNewClient, addNewClient);

                _PresenterClientPanel.AddOnPanel(addNewClient);
                _PresenterCreateNewClient.Show();

                OpenedForms.Add(addNewClient);
            }
        }
        
        private void AgentMainPage_OpenOrdersPanel(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(ordersPanel))
            {
                CloseOpenedFormsInAgentMainForm();
                ordersPanel = new OrdersPanel();
                _PresenterOrdersPanel = new PresenterOrdersPanel(ordersPanel);
                ListOfAllOrdersPanelEvent(_PresenterOrdersPanel);

                showBooking = new ShowBooking();
                _ModelShowBookings = new ModelShowBookings(GetConnection());
                _PresenterShowBooking = new PresenterShowBooking(_ModelShowBookings, showBooking);

                _PresenterAgentMainPage.AddOnPanel(ordersPanel);
                _PresenterOrdersPanel.AddOnPanel(showBooking);

                _PresenterOrdersPanel.Show();
                _PresenterShowBooking.Show();


                OpenedForms.Add(showBooking);
                OpenedForms.Add(ordersPanel);
            }
        }
        private void Presenter_ShowAllContracts(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(createContract))
            {
                CloseOpenedFormsInOrdersPanel();
                createContract = new CreateContract();
                _ModelCreateContract = new ModelCreateContract(GetConnection(), AgentTalonNum);
                _PresenterCreateContract = new PresenterCreateContract(createContract, _ModelCreateContract);

                _PresenterOrdersPanel.AddOnPanel(createContract);
                _PresenterCreateContract.Show();
                OpenedForms.Add(createContract);
            }
        }
        private void Presenter_ShowAllBookings(object sender, EventArgs e)
        {
            if (!OpenedForms.Contains(showBooking))
            {
                CloseOpenedFormsInOrdersPanel();
                showBooking = new ShowBooking();
                _ModelShowBookings = new ModelShowBookings(GetConnection());
                _PresenterShowBooking = new PresenterShowBooking(_ModelShowBookings, showBooking);

                _PresenterOrdersPanel.AddOnPanel(showBooking);
                _PresenterShowBooking.Show();
                OpenedForms.Add(showBooking);
            }
        }

        private void AgentMainPage_OpenServicesPanel(object sender, EventArgs e)
        {
            if(!OpenedForms.Contains(servicePanel))
            {
                CloseOpenedFormsInAgentMainForm();
                servicePanel = new ServicePanel();
                _PresenterServicePanel = new PresenterServicePanel(servicePanel);

                showTourToStaff = new ShowTourToStaff();
                _ModelShowTourToStaff = new ModelShowTourToStaff(GetConnection());
                _PresenterShowTourToStaff = new PresenterShowTourToStaff(showTourToStaff, _ModelShowTourToStaff);
                ListOfAllServicePanelEvent(_PresenterServicePanel);

                _PresenterAgentMainPage.AddOnPanel(servicePanel);
                _PresenterServicePanel.AddOnPanel(showTourToStaff);

                _PresenterServicePanel.Show();
                _PresenterShowTourToStaff.Show();

                OpenedForms.Add(servicePanel);
                OpenedForms.Add(showTourToStaff);
            }
        }
        #region --- Close opened Forms ---
        public void CloseOpenedFormsInAgentMainForm()
        {
            if(OpenedForms.Contains(personalInfo))
            {
                _PresenterPersonalInfo.Close();
                OpenedForms.Remove(personalInfo);
            }
            else if(OpenedForms.Contains(clientPanel))
            {
                CloseOpenedFormsInClientForm();
                _PresenterClientPanel.Close();
                OpenedForms.Remove(clientPanel);
            }
            else if(OpenedForms.Contains(ordersPanel))
            {
                CloseOpenedFormsInOrdersPanel();
                _PresenterOrdersPanel.Close();
                OpenedForms.Remove(ordersPanel);
            }
            else if(OpenedForms.Contains(servicePanel))
            {
                CloseOpenedFormsInServicePanel();
                _PresenterServicePanel.Close();
                OpenedForms.Remove(servicePanel);
            }
        }

        //client panel
        public void CloseOpenedFormsInClientForm()
        {
            if(OpenedForms.Contains(showClients))
            {
                _PresenterListOfAllClients.Close();
                OpenedForms.Remove(showClients);
            }
            else if(OpenedForms.Contains(addNewClient))
            {
                _PresenterCreateNewClient.Close();
                OpenedForms.Remove(addNewClient);
            }
        }

        //orders panel
        public void CloseOpenedFormsInOrdersPanel()
        {
            if(OpenedForms.Contains(showBooking))
            {
                _PresenterShowBooking.Close();
                OpenedForms.Remove(showBooking);
            }
            else if(OpenedForms.Contains(createContract))
            {
                _PresenterCreateContract.Close();
                OpenedForms.Remove(createContract);
            }
        }

        //service package
        public void CloseOpenedFormsInServicePanel()
        {
            if(OpenedForms.Contains(showTourToStaff))
            {
                showTourToStaff.Close();
                OpenedForms.Remove(showTourToStaff);
            }
            else if(OpenedForms.Contains(showAddTourToStaff))
            {
                showAddTourToStaff.Close();
                OpenedForms.Remove(showAddTourToStaff);
            }
            else if(OpenedForms.Contains(showHotelsToStaff))
            {
                showHotelsToStaff.Close();
                OpenedForms.Remove(showHotelsToStaff);
            }
            else if(OpenedForms.Contains(showTransferToStaff))
            {
                showTransferToStaff.Close();
                OpenedForms.Remove(showTransferToStaff);
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
        private void AuthorizationForm_openAgentForm(object sender, EventArgs e)
        {
            authorizationForm.Close();
            agentMainPage = new AgentMainPage();
            _ModelAgentMainForm = new ModelAgentMainForm(GetConnection());
            _PresenterAgentMainPage = new PresenterAgentMainPage(agentMainPage, _ModelAgentMainForm);

            AgentTalonNum = _PresenterAgentMainPage.GetTalonNum(authorizationForm.AgentLogin);
            ListOfAllAgentEvents(_PresenterAgentMainPage);
            personalInfo = new PersonalInfo();
            _ModelPersonalInfo = new ModelPersonalInfo(GetConnection());
            _PresenterPersonalInfo = new PresenterPersonalInfo(_ModelPersonalInfo, personalInfo);

            _PresenterAgentMainPage.AddOnPanel(personalInfo);

            OpenedForms.Add(personalInfo);
            _PresenterAgentMainPage.Show();
            _PresenterPersonalInfo.Show(AgentTalonNum);

        }
        private void ListOfAllAgentEvents(PresenterAgentMainPage agentMainPage)
        {
            agentMainPage.OpenPersonalInfo += AgentMainPage_OpenPersonalInfo;
            agentMainPage.OpenClientForm += AgentMainPage_OpenClientForm;
            agentMainPage.OpenOrdersPanel += AgentMainPage_OpenOrdersPanel;
            agentMainPage.OpenServicesPanel += AgentMainPage_OpenServicesPanel;
        }

        public void Run()
        {
            authorizationForm.Run();
        }

    }
}

