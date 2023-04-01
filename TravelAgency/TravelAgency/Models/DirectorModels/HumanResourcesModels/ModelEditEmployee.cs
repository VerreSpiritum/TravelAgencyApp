using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelEditEmployee
    {
        public NpgsqlConnection connection { get; set; }
        
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string PhoneNumber { get; set; }

        private string query;

        public bool GetInfo(int talonNumber)
        {
            query = $"SELECT name, patronymic, surname, position, sex, salary, phone_number FROM staff WHERE talon_number = {talonNumber}";
            bool checkRows;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using(NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Name = reader.GetString(0);
                            Patronymic = reader.GetString(1);
                            Surname = reader.GetString(2);
                            Position = reader.GetString(3);
                            Gender = reader.GetString(4);
                            Salary = reader.GetInt32(5);
                            PhoneNumber = reader.GetString(6);
                        }
                        checkRows = true;
                    }
                    else
                    {
                        checkRows = false;
                    }
                    reader.Close();
                }
            }
   
            return checkRows;
            
        }
        public int UpdateInfo(Dictionary<string, object> infoToUpdate, int talonNum)
        {
            query = "UPDATE staff SET(";
            int i = 0;
            foreach(string key in infoToUpdate.Keys)
            {
                if (i + 1 == infoToUpdate.Count)
                    query += $"{key}";
                else
                {
                    query += $"{key},";
                }
                i++;
            }
            query += ") = (";
            i = 0;
            foreach(object value in infoToUpdate.Values)
            {
                if (i + 1 == infoToUpdate.Count)
                    query += CheckType(value) + ")";
                else
                {
                    query += CheckType(value) + ",";
                }
                i++;
            }
            query += $"WHERE talon_number = {talonNum}";
            return SendQuery(query);

        }

        private int SendQuery(string query)
        {
            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                return cmd.ExecuteNonQuery();

            }
        }

        private string CheckType(object value)
        {
            if(value.GetType().Equals(typeof(int)))
            {
                return $"{value}";
            }
            else
            {
                return $"'{value}'";
            }
        }
    }
}
