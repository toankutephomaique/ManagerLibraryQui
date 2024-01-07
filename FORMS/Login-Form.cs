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
            dashF.Enabled = true;
            this.Close();

            // create the database
        }
    }
}
