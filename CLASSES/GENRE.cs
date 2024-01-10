using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace QuanlythuvienDHCNQN.CLASSES
{
    class GENRE
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        
        // create a unction to add a genre
        public Boolean addGenre(string name)
        {
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)";
            string genre_name = name;

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            if (db.setData(query, paramters) == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
    
        }

        // create a function to edit a genre
        public Boolean editGenre(int id, string name)
        {
            return true;
        }

        // create a function to remove a genre
        public Boolean removeGenre(int id)
        {
            return true;
        }

        // create a function to return table of genres
        public DataTable GenresList()
        {
            return new DataTable();
        }

    }
}
