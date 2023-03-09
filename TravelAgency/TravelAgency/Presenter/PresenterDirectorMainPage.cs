﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;
using Npgsql;

namespace TravelAgency.Presenter
{
    internal class PresenterDirectorMainPage
    {
        ModelDirectorMainPage model = new ModelDirectorMainPage();
        IViewDirectorMainPage view;

        public event EventHandler OpenHumanResourcesForm;
        public event EventHandler OpenServicePackageForm;
        public event EventHandler CloseConnection;

        public PresenterDirectorMainPage(IViewDirectorMainPage view, ModelDirectorMainPage model)
        {
            this.model = model;
            this.view = view;

            view.OpenHumanResourcesForm += View_OpenHumanResourcesForm;
            view.OpenServicePackageForm += View_OpenServicePackageForm;
            view.CloseConnection += View_CloseConnection;
        }

        private void View_CloseConnection(object sender, EventArgs e)
        {
            if (CloseConnection != null) 
                CloseConnection(this, EventArgs.Empty);

        }

        private void View_OpenServicePackageForm(object sender, EventArgs e)
        {
            if(OpenServicePackageForm != null)
                OpenServicePackageForm(this, EventArgs.Empty);
        }

        private void View_OpenHumanResourcesForm(object sender, EventArgs e)
        {
            if(OpenHumanResourcesForm != null) 
                OpenHumanResourcesForm(this, EventArgs.Empty);
        }

        public void AddOnPanelHumanResources(HumanResourcesForm form)
        {
            view.addOnPanelHumanResources(form);
        }

        public void Show()
        {
            view.ShowForm();
        }
    }
}
