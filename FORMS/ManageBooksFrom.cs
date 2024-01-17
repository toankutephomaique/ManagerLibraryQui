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
    public partial class ManageBooksFrom : Form
    {
        public ManageBooksFrom()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ManageBooksFrom_Load(object sender, EventArgs e)
        {
            //display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/updates.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
            button_selectCover.Image = Image.FromFile("../../IMAGES/upload.png");
        }

        // browse and display book cover
        private void button_selectCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_cover.Image = Image.FromFile(opf.FileName);
            }
        }

        // show authors list in a new form
        private void button_selectAuthor_Click(object sender, EventArgs e)
        {
            AuthorsListForm athsLsForm = new AuthorsListForm(this);
            athsLsForm.Show();
        }
    }
}
