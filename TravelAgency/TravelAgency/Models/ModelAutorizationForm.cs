﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TravelAgency.Models
{
    internal class ModelAutorizationForm
    {
        private string login;
        private string password;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password 
        { 
            get { return password; } 
            set { password = value; } 
        }

        public string ConnectingToDB()
        {
            string error;
            string connectionstr = "Server=localhost;Port=5432;Database=travelAgency;UserID=" + login.ToLower() + ";Password=" + password + ";";
            NpgsqlConnection connectToDB = new NpgsqlConnection(connectionstr);
            try
            {
                connectToDB.Open();
                error = "";
            }
            catch
            {
                error = "Виникла помилка! Перевірте дані!";
            }
            return error;
        }
    }
}