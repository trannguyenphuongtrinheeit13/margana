/*
 * Russell Chamunorwa Mazonde
 * class for creating mysql connections as well as executing queries
 * also has close connection function for sql connection
 * all sql functions will be executed from this class
 * untested
 * */


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
        MySqlConnection cmv_connection = null; //create var instance

        public mySQL()
        {

        }

        public MySqlConnection _OpenConnection()
        {
            //connection string
            string lc_connString = "SERVER=" + Properties.Settings.Default.server + ";" +
                                    "Database=" + Properties.Settings.Default.database + ";" +
                                    "UID=" + Properties.Settings.Default.uid + ";" +
                                    "PASSWORD=" + Properties.Settings.Default.password + ";";

            cmv_connection = new MySqlConnection(lc_connString); //create connection
            cmv_connection.Open();
            return cmv_connection; //return connection
        }

        public void _closeConnection()
        {
            if (cmv_connection != null)
                cmv_connection.Close(); //close mysql connection
        }

        public string _getRandomWord(string _lang)
        { //get a random word from the list of words 
            string lc_sqlQuery = "SELECT `word` FROM `margana`.`words` WHERE `lang`='@lang' ORDER BY RAND() LIMIT 1;";
            MySqlCommand lc_cmd = new MySqlCommand(lc_sqlQuery, cmv_connection);
            lc_cmd.Prepare();

            lc_cmd.Parameters.AddWithValue("@lang", _lang);
            MySqlDataReader lc_sqlResult = lc_cmd.ExecuteReader();
            return lc_sqlResult.GetString(0); //get the word and return it
        }
    }
}
