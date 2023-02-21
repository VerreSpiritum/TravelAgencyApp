﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    public interface IViewDirectorMainPage
    {
        bool humanResourcesOpen { get; set; }

        void ShowForm();
        void addOnPanelHumanResources(HumanResoucesForm form);

        event EventHandler OpenHumanResoucesForm;
        event EventHandler OpenServicePackageForm;
    }
}