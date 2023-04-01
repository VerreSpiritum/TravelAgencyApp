using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Models
{
    internal class ModelShowUsers
    {
        private NpgsqlConnection connection { get; set; }

        public ModelShowUsers(NpgsqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
