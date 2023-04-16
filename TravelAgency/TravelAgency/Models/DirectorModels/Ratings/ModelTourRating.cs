using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.Booker_panel
{
    internal class ModelTourRating
    {
        private NpgsqlConnection connection;

        public ModelTourRating(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfo()
        {
            DataTable data = new DataTable();

            using(NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM agencyPopylarity", connection))
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
