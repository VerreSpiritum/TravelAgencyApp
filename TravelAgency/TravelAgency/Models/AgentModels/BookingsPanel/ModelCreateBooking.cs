using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace TravelAgency.Models.AgentModels.BookingsPanel
{
    public class ModelCreateBooking
    {
        private NpgsqlConnection _connection;
        private int book = 0;
        public string Error { get; set; }

        public ModelCreateBooking(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public DataTable GetClient()
        {
            DataTable data = new DataTable();

            string query = "SELECT id_client, email_adress FROM customer";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        data.Load(r);
                        
                    }
                }
            } 
            return data;
        }
        public DataTable GetTour()
        {
            DataTable infoT = new DataTable();
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_tour, name FROM tour ORDER BY name", _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                       infoT.Load(r);
                        
                    }
                }
            }
            return infoT;
        }

        public DataTable GetAddTour(int ID)
        {
            string query =
                $"select a.id_additional_tour, a.name from additional_tour a JOIN cities_included_in_additional_tour ciat USING(id_additional_tour) WHERE ciat.city IN (SELECT city FROM tour t JOIN cities_included_in_tour cit USING(id_tour) WHERE id_tour = {ID})";
            DataTable infoAT = new DataTable();
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                       infoAT.Load(r);
                        
                    }
                }
            }

            return infoAT;
        }

        public DataTable GetHotelTour(int ID)
        {
            string query = $"select r.id_hotel, h.name, room_grade, city from rooms r JOIN hotels h USING(id_hotel) WHERE city IN (select city from cities_included_in_tour WHERE id_tour = {ID} " +
                           $"AND SUBSTRING(period_of_residence::text, 1, 10)::date = (SELECT start_date from cities_included_in_tour cit WHERE cit.city = h.city AND id_tour = {ID}) " +
                           $"AND split_part(period_of_residence::text, ' - ', 2)::date = (SELECT end_date from cities_included_in_tour cit WHERE cit.city = h.city AND id_tour = {ID}))";
            DataTable infoH = new DataTable();
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        infoH.Load(r);
                        
                    }
                }
            }

            return infoH;
        }
        
        
        public DataTable GetHotelAddTour(int ID)
        {
            string query = $"select r.id_hotel, h.name, room_grade, city from rooms r JOIN hotels h USING(id_hotel) WHERE city IN (select city from cities_included_in_additional_tour WHERE id_additional_tour = {ID} " +
                           $"AND SUBSTRING(period_of_residence::text, 1, 10)::date = (SELECT start_date from cities_included_in_additional_tour cit WHERE cit.city = h.city AND id_additional_tour = {ID}) " +
                           $"AND split_part(period_of_residence::text, ' - ', 2)::date = (SELECT end_date from cities_included_in_additional_tour cit WHERE cit.city = h.city AND id_additional_tour = {ID}))"; 
            DataTable infoH = new DataTable();
            Error = String.Empty;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                using (NpgsqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        infoH.Load(r);
                        
                    }
                }
            }

            return infoH;
        }
        public DataTable GetTransport(int ID)
        {
            string query = $"select tr.id_transfer, t.name, from_where, to_where FROM transfer tr " +
                           $"JOIN transport t USING(id_transport), tour WHERE tour.departure_city = to_where and tour.id_tour = {ID}";
            DataTable info = new DataTable();
            Error = String.Empty;
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
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

        public void CreateBookingWithHotel(List<int> hotel)
        {
            Error = String.Empty;
            
            foreach (int i in hotel)
            {
                string query_2 = $"INSERT INTO booking_with_hotel VALUES ({book}, {i})";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_2, _connection))
                {
                    try
                    {
                        using (NpgsqlDataReader r = cmd.ExecuteReader())
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        Error = ex.Message;
                        return;
                    }
                }
            }
        }

        public void CreateBookingWithTransfer(int id)
        {
            Error = String.Empty;

           string query_2 = $"INSERT INTO booking_with_transfer VALUES ({book}, {id})";
           using (NpgsqlCommand cmd = new NpgsqlCommand(query_2, _connection))
           {
               try
               {
                   using (NpgsqlDataReader r = cmd.ExecuteReader())
                   {

                   }
               }
               catch (Exception ex)
               {
                   Error = ex.Message;
                   return;
               }

           }
        }

        public void CreateBookingWithAddTour(int Aid)
        {
            Error = String.Empty;
            string query_1 = $"INSERT INTO booking_with_additional_tour VALUES ({book}, {Aid})";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query_1, _connection))
            {
                try
                {
                    using (NpgsqlDataReader r = cmd.ExecuteReader())
                    {

                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return;
                }
            } 
        }
        public void CreateBooking(int id, int client)
        {
            string query = $"INSERT INTO booking VALUES (DEFAULT, {client}, {id}) RETURNING id_booking";
            Error = String.Empty;
            
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                try
                {
                    using (NpgsqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                book = r.GetInt32(0);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    Error += ex.Message;
                    return; 
                }
            }
            
            
            
        }
    }
}