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
        public int Salary { get; set; }
        public string Post { get; set; }
        public string ResultOfAdding { get; set; }
        
        private string query;
        
        public void CreateNewStaff(NpgsqlConnection connection)
        {
            query = "INSERT INTO Staff(name, patronymic, surname, position, sex, date_of_birth, salary, start_date, phone_number) VALUES " +
                $"('{Name}', '{SecondName}', '{Surname}', '{Post}', '{Gender}', '{BirthDate}', {Salary}, '{StartDate}', '{PhoneNumber}')";
            
            try 
            {
             
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection); 
                string text = cmd.ExecuteNonQuery().ToString();
            }
            catch
            {
                ResultOfAdding = "Виникла помилка при додавані нового співробітника";
            }
            
            if(String.IsNullOrEmpty(ResultOfAdding))
            {
                ResultOfAdding = "Успішно додано нового співробітника!";
            }
        }
    }
}
