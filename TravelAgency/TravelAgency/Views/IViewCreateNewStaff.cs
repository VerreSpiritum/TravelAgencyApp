using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewCreateNewStaff
    {
        string Name { get; set; }
        string SecondName { get; set; }
        string Surname { get; set; }
        string BirthDate { get; set; }
        string PhoneNumber { get; set; }
        string Gender { get; set; }
        string StartDate { get; set; }
        int Salary { get; set; }
        string Post { get; set; }
        string ResultOfAdding { get; set; }

        event EventHandler sendInfo;

        void ShowForm();
        void CloseForm();


    }

}
