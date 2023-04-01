using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelEditUser
    {
        private NpgsqlConnection connection;


        public string GetLogin { get;  set; }

        public ModelEditUser(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
