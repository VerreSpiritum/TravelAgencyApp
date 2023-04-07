using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TravelAgency.Models.DirectorModels.TransportsAndTransfersModels
{
    internal class ModelShowTransfers
    {
        private NpgsqlConnection connection;

        public ModelShowTransfers(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable GetInfoAboutTransfer()
        {
            DataTable transferInfo = new DataTable();
            string query = $"SELECT * FROM show_transfers";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        transferInfo.Load(reader);
                }
            }

            return transferInfo;
        }

        public int DeleteTransfer(int id)
        {
            string query = $"DELETE FROM transfer WHERE id_transfer = {id}";
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
