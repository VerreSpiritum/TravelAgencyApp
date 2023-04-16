using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.Booker_panel
{
    internal class ModelConcludedContract
    {
        private NpgsqlConnection connection;

        public ModelConcludedContract(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfo(string Start, string End)
        {
            DataTable data = new DataTable();

            using(NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM get_summary_info_about_staff_contract('{Start}', '{End}')", connection))
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
