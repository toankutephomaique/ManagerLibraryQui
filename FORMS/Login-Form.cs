using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QuanlythuvienDHCNQN.FORMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_From_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("../../IMAGES/user.png");
            pictureBox_Pass.Image = Image.FromFile("../../IMAGES/lock.png");
        }

        private void label_close_MouseEnter(object sender, MouseEventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //manipulate the dashboard from the login 
        private Dashboard_From dashF = null;
        public Login_Form(Dashboard_From SourceFrom)
        {
            dashF = SourceFrom as Dashboard_From;
            InitializeComponent();
        }

        //the login button
        private void button_login_Click(object sender, EventArgs e)
        {
            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username`=@usn AND `password`=@pass",db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if this user exists or not
            if (table.Rows.Count > 0)// if exists
            {
                dashF.Enabled = true;
                this.Close();
            }
            else // if not  
            {
                // check if the username is empty
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // check if the username is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // if this data dosn't exists
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pictureBox_Pass_Click(object sender, EventArgs e)
        {

        }

    }       
}
