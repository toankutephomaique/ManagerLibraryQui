using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlythuvienDHCNQN.FORMS
{
    public partial class Dashboard_From : Form
    {
        public Dashboard_From()
        {
            InitializeComponent();
        }

        private void Dashboard_From_Load(object sender, EventArgs e)
        {
            // logo orgin dhcnqn
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/book.png");

            // logo close button
            button_close.Image = Image.FromFile("../../IMAGES/close.png");

            // the menu images
            button_books.Image = Image.FromFile("../../IMAGES/literature.png");
            button_authors.Image = Image.FromFile("../../IMAGES/author.png");
            button_genres.Image = Image.FromFile("../../IMAGES/tag.png");
            button_circulation.Image = Image.FromFile("../../IMAGES/loop.png");
            button_users.Image = Image.FromFile("../../IMAGES/users.png");

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_From_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            // show the login from
            Login_Form lgf = new Login_Form(this);
            lgf.Show();
        }

        private void button_genres_Click(object sender, EventArgs e)
        {

            // show the manager genres from
            ManagerGenresFrom mngGnrF = new ManagerGenresFrom();
            mngGnrF.Show();
        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            // show the manager genres from
            ManagerAuthors mngAthF = new ManagerAuthors();
            mngAthF.Show();
        }
    }
}
