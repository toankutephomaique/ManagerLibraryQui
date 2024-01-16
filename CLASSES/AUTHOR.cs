using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanlythuvienDHCNQN.CLASSES
{
    class AUTHOR
    {

        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // create a unction to add a new author
        public Boolean addAuthor(string fname, string lname, string edu, string bio)
        {
            string query = "INSERT INTO `authors`(`first_name`, `last_name`, `education`, `bio`) VALUES (@fn, @ln, @edu, @bio)";

            MySqlParameter[] paramters = new MySqlParameter[4];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            paramters[2].Value = edu;

            paramters[3] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            paramters[3].Value = bio;


            if (db.setData(query, paramters) == 1)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        // create a function to return table of authors
        public DataTable AuthorsList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `authors`", null);
            return table;
        }
    }
}
