using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TravelAgency.Models
{
    internal class ModelListOfAllStaff
    {
        private NpgsqlConnection connection;
        private string query;

        public ModelListOfAllStaff(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfoAboutStaff()
        {
            DataTable staffInfo = new DataTable();
            query = $"SELECT talon_number AS №, concat(surname, ' ', substring(name, 1, 1), '. ', substring(patronymic, 1, 1), '.') AS ФІО, position AS Посада, " +
                $"sex AS Стать, date_of_birth AS \"Дата народження\", start_date AS \"Дата початку роботи\", salary AS Зарплатня, phone_number AS \"Номер телефону\" " +
                $"FROM staff\r\n";
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

        public int DeleteEmployee(int id)
        {
            int checkError;
            query = $"DELETE FROM Staff WHERE talon_number = {id}";
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                checkError = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
            }
            return checkError;
        }
    }
}
