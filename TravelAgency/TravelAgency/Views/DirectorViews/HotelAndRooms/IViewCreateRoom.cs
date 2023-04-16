﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.HotelAndRooms
{
    internal interface IViewCreateRooms
    {
        List<string> Facilities { get; set; }
        List<string> Hotel { get; set;}
        DataTable facilites { get; set; }

        string Name { get; set; }
        string RoomGrade { get; set; }
        string Meals { get; set; }
        string Info { get; set; }
        string Photo { get; set; }
        int Price { get; set; }
        string Period { get; set; }

        string Error { get; set; }

        void ShowForm();
        void CloseForm();

        event EventHandler CreateRoom;
    }
}
