using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.AgentModels.BookingsPanel
{
    internal class ModelShowBookings
    {
        private NpgsqlConnection connection;

        public ModelShowBookings(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfo()
        {
            string query = "SELECT * FROM ShowBooking";
            DataTable dataTable = new DataTable();

            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection)) 
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public string DeleteBooking(int ID)
        {
            string query = $"DELETE FROM ShowBooking WHERE id_booking = {ID}";
            string error = "";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
            return error;
        }
    }
}
