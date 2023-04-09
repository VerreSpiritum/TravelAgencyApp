﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.ToursAndAdditionalTours
{
    internal class ModelShowTours
    {
        private NpgsqlConnection connection;

        public ModelShowTours(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable ShowTours()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM showToursForDirector";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    using(NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch(Exception ex)
                {
                    return dt;
                }
            }
            return dt;
        }

        public int DeleteTour(int ID)
        {
            string query = $"DELETE FROM tour WHERE id_tour = {ID}";

            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { return 0; }
            }
        }
    }
}
