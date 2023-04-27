using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TravelAgency.Views.AgentViews;

namespace TravelAgency
{
    public partial class PersonalInfo : Form, IViewPersonalInfo
    {
        private bool checkShowEmployeeInfo;
        private Dictionary<string, object> _employee = new Dictionary<string, object>();

        public PersonalInfo()
        {
            InitializeComponent();
           
        }
        #region --- Interface ---
        public Dictionary<string, object> Info { get; set; }

        public void ShowForm()
        {
            if(Info.Count > 0)
            {
                talonNum.Texts = Info["talonNum"].ToString();
                infoAgent.Texts = Info["Info"].ToString();
                gender.Texts = Info["Gender"].ToString();
                DateTime temp = (DateTime)Info["BirthDate"];
                birthDate.Texts = temp.Day.ToString() + "." + temp.Month.ToString() + "." + temp.Year.ToString();
                temp = (DateTime)Info["StartDate"];
                startDate.Texts = temp.Day.ToString() + "." + temp.Month.ToString() + "." + temp.Year.ToString();
                salary.Texts = Info["AgentSalary"].ToString();
                phoneNumber.Texts = Info["PhoneNum"].ToString();
                position.Texts = Info["Position"].ToString();
            }
            this.Show();
        }

        public void CloseForm()
        {
            this.Close();
        }

        #endregion


    }
}
