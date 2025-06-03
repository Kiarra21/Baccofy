using Baccofy.Controllers;
using Baccofy.Models;
using System;
using System.Windows.Forms;

namespace Baccofy.Views.Auth
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            textBox3.PasswordChar = '●';
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string nomorTelepon = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(nomorTelepon) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field wajib diisi!");
                return;
            }

            AkunModel akun = new AkunModel
            {
                Username = username,
                Nomor_Telepon = nomorTelepon,
                Password = password,
                Role_Id_Role = 2 
            };

            AuthController authController = new AuthController();
            bool success = authController.Register(akun);

            if (success)
            {
                MessageBox.Show("Registrasi berhasil! Silakan login.");
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Coba lagi.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
