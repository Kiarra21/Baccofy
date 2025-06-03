using Baccofy.Views.Auth;
using Baccofy.Views.Menu.Akun;
using Baccofy.Views.Menu.Gaji;
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
    public partial class MenuOwner : Form
    {
        public MenuOwner()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Manajemen_Akun akun = new Manajemen_Akun();
            akun.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pencatatan_Pupuk_Bibit catat = new Pencatatan_Pupuk_Bibit();
            catat.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pencatatan_Pupuk_Bibit catat = new Pencatatan_Pupuk_Bibit();
            catat.Show();
            //this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Gaji_Petani gaji = new Gaji_Petani();
            gaji.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gaji_Petani gaji = new Gaji_Petani();
            gaji.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manajemen_Akun akun = new Manajemen_Akun();
            akun.Show();
            //this.Hide();
        }
    }
}
