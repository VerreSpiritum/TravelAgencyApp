using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TravelAgency.Views
{
    internal interface IViewEditEmployee
    {
        int TalonNum { get; set; }
        bool talonNumFind { get; set; }
        string Name { get; set; }
        string Patronymic { get; set; }
        string Surname { get; set; }
        string Position { get; set; }
        string Gender { get; set; }
        //int Salary { get; set; }
        string PhoneNumber { get; set; }
        Dictionary<String, Object> InfoToUpdate { get;}
        bool IsFromTable { get; set; }
        
        int CheckUpdate { get; set; }

        event EventHandler GetInfo;
        event EventHandler UpdateInfo;

        void ShowForm();
        void CloseForm();


    }
}
