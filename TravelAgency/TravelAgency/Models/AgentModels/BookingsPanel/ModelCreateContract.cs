using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Design;

namespace TravelAgency.Forms.AgentForms.OrdersPanel
{
    internal class ModelCreateContract
    {
        private NpgsqlConnection connection;
        private int ID_agent;
        
        public int Cost { get; set; }
        public int Discount { get; set; }
        public ModelCreateContract(NpgsqlConnection connection, int id_agent)
        {
            this.connection = connection;
            ID_agent = id_agent;
        }

        public DataTable GetInfo()
        {
            string query = "SELECT * FROM ShowBooking";
            DataTable dataTable = new DataTable();

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            
            return dataTable;
        }

        public string GetContract(int ID_book, int id_agent)
        {
            string text = "";
            using (NpgsqlCommand cmd = new NpgsqlCommand($"select GenerateTextOfContract({ID_book}, {id_agent});", connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            text = r.GetString(0);
                        }
                    }
                }
            }
            using (NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO contract VALUES (DEFAULT, {ID_book}, '{DateTime.Today}', {id_agent}, {Cost - Discount});", connection))
            {
                try
                {
                    using (NpgsqlDataReader r = cmd.ExecuteReader())
                    {
                   
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }
                
            }
            return text;
        }
        public void GetPrice(int ID_book, string email_client)
        {
            int ID_client = 0; 
            using (NpgsqlCommand cmd = new NpgsqlCommand($"select id_client FROM customer WHERE email_adress = '{email_client}'", connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ID_client = reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            using (NpgsqlCommand cmd = new NpgsqlCommand($"select SaleForClient({ID_client}, GenerateCost({ID_book})::INTEGER), GenerateCost({ID_book});", connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            Discount = r.GetInt32(0);
                            Cost = r.GetInt32(1);
                        }
                        
                    }
                }
            }
        }
        
    }
}
