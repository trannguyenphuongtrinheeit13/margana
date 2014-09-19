using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Margana_Word_Game
{
    class mySQL
    {
        MySqlConnection cmv_connection; //create var instance

        public mySQL()
        {

        }

        public MySqlConnection _OpenConnection(){
            //connection string
            string cmv_connString = "SERVER=" + Properties.Settings.Default.server + ";" +
                                    "Database=" + Properties.Settings.Default.database + ";" +
                                    "UID=" + Properties.Settings.Default.uid + ";" +
                                    "PASSWORD=" + Properties.Settings.Default.password + ";";
            cmv_connection = new MySqlConnection(cmv_connString); //create connection
            return cmv_connection; //return connection
        }

        public void _closeConnection(){
            cmv_connection.Close(); //close mysql connection
        }
    }
}
