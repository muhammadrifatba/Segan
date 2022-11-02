﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    class dbConnection
    {
        public (NpgsqlConnection, NpgsqlCommand) InitializeConnection()
        {
            NpgsqlConnection con;
            NpgsqlCommand cmd;

            var uriString = "postgres://fjqfvszo:02h7yKBb-rHsNBug5T8kxZeUV_439eRx@satao.db.elephantsql.com/fjqfvszo";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);

            con = new NpgsqlConnection(connStr);
            cmd = new NpgsqlCommand();

            return (con, cmd);
        }
    }
}
