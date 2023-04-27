using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.AgentModels
{
    internal class ModelPersonalInfo
    {
        private NpgsqlConnection connection;
        private Dictionary<string, object> temp = new Dictionary<string, object>();
        public Dictionary<string, object> infoAboutPerson { get => temp; } 


        public ModelPersonalInfo(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public void GetInfo(int talonNum)
        {
            using(NpgsqlCommand cmd = new NpgsqlCommand($"select * from getPersonalInfo({talonNum})", connection)) 
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            temp.Add("talonNum", reader.GetInt32(0));
                            temp.Add("Info", reader.GetString(1));
                            temp.Add("Position", reader.GetString(2));
                            temp.Add("Gender", reader.GetString(3));
                            temp.Add("BirthDate", reader.GetDateTime(4));
                            temp.Add("StartDate", reader.GetDateTime(5));
                            temp.Add("AgentSalary", reader.GetInt32(6));
                            temp.Add("PhoneNum", reader.GetString(7));
                        }
                    }
                }
            }
        }
    }
}
