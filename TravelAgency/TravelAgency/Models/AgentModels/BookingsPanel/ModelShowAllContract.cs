using System.Data;
using Npgsql;

namespace TravelAgency.Models.AgentModels.BookingsPanel
{
    public class ModelShowAllContract
    {
        private NpgsqlConnection _connection;

        public ModelShowAllContract(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public string GetContract(int id)
        {
            int idBook = 0, idAgent = 0;
            using (NpgsqlCommand cmd =
                   new NpgsqlCommand($"select id_agent, id_booking FROM contract WHERE id_contract = {id};",
                       _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            idAgent = r.GetInt32(0);
                            idBook = r.GetInt32(1);
                        }
                    }
                }
            }

            string text = "";
            using (NpgsqlCommand cmd =
                   new NpgsqlCommand($"select GenerateTextOfContract({idBook}, {idAgent});", _connection))
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

            return text;
        }

        public DataTable GetInfo()
        {
            DataTable info = new DataTable();
            using (NpgsqlCommand cmd = new NpgsqlCommand(
                       "select id_contract, s.surname || ' ' || s.name || ' ' || s.patronymic AS \"ФІО агент\", c.surname || ' ' || c.name || ' ' || c.patronymic, contract_date " +
                       "from contract con JOIN booking USING(id_booking) JOIN customer c USING(id_client), staff s where con.id_agent = s.talon_number",
                       _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        info.Load(r);
                    }
                }
            }

            return info;
        }
    }
}