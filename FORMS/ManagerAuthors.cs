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
    public partial class ManagerAuthors : Form
    {

        CLASSES.AUTHOR author = new CLASSES.AUTHOR();

        public ManagerAuthors()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerAuthors_Load(object sender, EventArgs e)
        {
            //display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            //populate datagridview with genres
            dataGridView_authors.DataSource = author.AuthorsList();

            // customize datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView_authors.EnableHeadersVisualStyles = false;
        }

        // add a new author
        private void button_add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_education.Text;
            string bio = richTextBox_bio.Text;

            // check if the first/last name are empty
            if(first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("You need To Enter The Authors First & Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio)) 
                {
                    MessageBox.Show("New Author Added Successfully", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //populate datagridview with genres
                    //dataGridView_genres.DataSource = genre.GenresList();
                }

                else
                {
                    MessageBox.Show("Author Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
