using Baccofy.Views.Auth;
using Baccofy.Views.Menu.Pupuk_Bibit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baccofy.Views.Menu
{
    public partial class MenuPetani : Form
    {
        public MenuPetani()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pencatatan_Pupuk_Bibit catat = new Pencatatan_Pupuk_Bibit();
            catat.Show();
            //this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pencatatan_Pupuk_Bibit catat = new Pencatatan_Pupuk_Bibit();
            catat.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
