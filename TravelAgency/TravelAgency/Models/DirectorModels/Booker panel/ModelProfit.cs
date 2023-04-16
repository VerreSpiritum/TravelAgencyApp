using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.Booker_panel
{
    internal class ModelProfit
    {
        private NpgsqlConnection connection;

        public ModelProfit(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfo(string Start, string End)
        {
            DataTable data = new DataTable();

            using(NpgsqlCommand cmd = new NpgsqlCommand($"select Coalesce(SUM(cost), 0), '{Start}', '{End}' from contract WHERE contract_date >= '{Start}' AND contract_date <= '{End}'", connection))
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                        data.Load(reader);
                }
            }
            return data;
        }
    }
}
