using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Models
{
    internal class ModelCreateNewStaff
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string StartDate { get; set; }
        public string Salary { get; set; }
        public string Post { get; set; }

        public void CreateNewStaff(NpgsqlConnection connection)
        {
            string sql = "INSERT INTO Staff(name, patronymic, surname, position, sex, date_of_birth, salary, start_date, phone_number) VALUES " +
                $"('{Name}', '{SecondName}', '{Surname}', '{Post}', '{Gender}', '{BirthDate}', {int.Parse(Salary)}, '{StartDate}', '{PhoneNumber}')";
            try {
             
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection); 
                var text = cmd.ExecuteScalar().ToString();
               
            }
            catch
            {
                string a = "Error";
            }

        }
    }
}
