using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models.DirectorModels.ToursAndAdditionalTours
{
    internal class ModelShowRooms
    {
        private NpgsqlConnection connection;

        public ModelShowRooms(NpgsqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable ShowRooms()
        {
            DataTable dt = new DataTable();
            string query = "select id_room, name AS hotel, room_grade, meals, period_of_residence, info, r.photos, price from rooms r, hotels h WHERE r.id_hotel = h.id_hotel";
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

        public int DeleteRoom(int ID)
        {
            string query = $"DELETE FROM rooms WHERE id_room = {ID}";

            using(NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex) 
                { 
                    return 0; 
                }
            }
        }
    }
}
