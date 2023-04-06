using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelShowUsers
    {
        private NpgsqlConnection connection { get; set; }
        private string query;

        public ModelShowUsers(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfoAboutUser()
        {
            DataTable staffInfo = new DataTable();
            query = $"SELECT id_agent AS №, login AS \"Логін\" FROM staff_accounts_info";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        staffInfo.Load(reader);
                }
            }

            return staffInfo;
        }

        public int DeleteUser(int id)
        {
            query = $"SELECT DropUserStaff({id})";
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
                    return 0;
                }
                return 1;
            }
        }
    }
}
