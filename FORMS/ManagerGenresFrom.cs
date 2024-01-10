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
    public partial class ManagerGenresFrom : Form
    {
        public ManagerGenresFrom()
        {
            InitializeComponent();
        }

        CLASSES.GENRE genre = new CLASSES.GENRE();
        private void ManagerGenresFrom_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter The Genre Name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (genre.addGenre(name))
                {
                    MessageBox.Show("New Genre Added Successfully", "New Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Genre Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
