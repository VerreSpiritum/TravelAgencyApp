﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.AgentModels.ServicePanel
{
    internal class ModelShowTransferToStaff
    {
        private NpgsqlConnection connection;
        
        public ModelShowTransferToStaff(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
        public DataTable ShowTransfers()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM show_transfers";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    return dt;
                }
            }
            return dt;
        }
    }
}
