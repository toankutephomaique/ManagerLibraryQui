using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanlythuvienDHCNQN.CLASSES
{
    class BOOKS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // create a function to add a new book
        public Boolean addBook(int id, string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime data_recived, string description, byte cover)
        {
            string query = "INSERT INTO `books`(`id`, `isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_recived`, `description`, `cover`) VALUES (@id,@isbn,@title,@author,@genre,@qty,@price,@publisher,@d_recv,@descrp,@img)";

            MySqlParameter[] paramters = new MySqlParameter[11];

            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = id;

            paramters[1] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            paramters[1].Value = isbn;

            paramters[2] = new MySqlParameter("@title", MySqlDbType.VarChar);
            paramters[2].Value = title;

            paramters[3] = new MySqlParameter("@author", MySqlDbType.Int32);
            paramters[3].Value = author_id;

            paramters[4] = new MySqlParameter("@genre", MySqlDbType.Int32);
            paramters[4].Value = genre_id;

            paramters[5] = new MySqlParameter("@qty", MySqlDbType.Int32);
            paramters[5].Value = quantity;

            paramters[6] = new MySqlParameter("@price", MySqlDbType.Double);
            paramters[6].Value = price;

            paramters[7] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            paramters[7].Value = publisher;

            paramters[8] = new MySqlParameter("@d_recv", MySqlDbType.Date);
            paramters[8].Value = data_recived;

            paramters[9] = new MySqlParameter("@descrp", MySqlDbType.VarChar);
            paramters[9].Value = description;

            paramters[10] = new MySqlParameter("@img", MySqlDbType.Blob);
            paramters[10].Value = cover;


            if (db.setData(query, paramters) == 1)
            {
                return true;

            }
            else
            {
                return false;
            }

            return true;
        }

        // create a function to edit the selected book
        public Boolean editBook()
        {
            return true;
        }

        // create a function to remove the selected book
        public Boolean removeBook()
        {
            return true;
        }
    }
}
