﻿using System;
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
            //display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            //populate datagridview with genres
            dataGridView_genres.DataSource = genre.GenresList();

            // customize datagridview header
            dataGridView_genres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial",15,FontStyle.Bold);
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 

            dataGridView_genres.EnableHeadersVisualStyles = false;
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

                    //populate datagridview with genres
                    dataGridView_genres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Genre Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string name = textBox_name.Text;

                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Enter The Genre Name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (genre.editGenre(id, name))
                    {
                        MessageBox.Show("Genre Name Updated Successfully", "New Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //populate datagridview with genres
                        dataGridView_genres.DataSource = genre.GenresList();

                    }
                    else
                    {
                        MessageBox.Show("Genre Name Not Updated", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                    if (genre.removeGenre(id))
                    {
                        MessageBox.Show("Genre Deleted Successfully", "Delete Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clear fields
                    textBox_id.Text = "";
                    textBox_name.Text = "";

                    //populate datagridview with genres
                    dataGridView_genres.DataSource = genre.GenresList();
                }
                    else
                    {
                        MessageBox.Show("Genre Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        // display the selected genre data in textboxes
        private void dataGridView_genres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_genres.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_genres.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
