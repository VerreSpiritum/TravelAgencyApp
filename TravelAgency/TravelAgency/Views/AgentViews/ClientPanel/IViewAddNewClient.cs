using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace TravelAgency.Views.AgentViews.ClientPanel
{
    internal interface IViewAddNewClient
    {
        string Name { get; }
        string SecondName { get; }
        string Surname { get; }
        string PhoneNumber { get; }
        string BirthDate { get; }
        string Gender { get; }
        string Email { get; }
        string IdentCode { get; }
        string RegistryEntryNum { get; }
        string PassportNumber { get; }
        string ResultOfAdding { get; set; }
        event EventHandler sendInfo;

        void CloseForm();

        void ShowForm();
    }
}
