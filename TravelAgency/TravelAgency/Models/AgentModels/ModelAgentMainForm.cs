using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.AgentModels
{
    internal class ModelAgentMainForm
    {
        private NpgsqlConnection connection;


        public ModelAgentMainForm(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public int GetTalonNum(string login)
        {
            int talonNum = 0;

            using(NpgsqlCommand cmd = new NpgsqlCommand($"SELECT id_agent FROM staff_accounts_info WHERE login = '{login}'", connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            talonNum = reader.GetInt32(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return talonNum;
        }
    }
}
