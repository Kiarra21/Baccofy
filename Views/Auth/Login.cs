using Baccofy.Controllers;
using Baccofy.Views.Menu;
using System;
using System.Windows.Forms;

namespace Baccofy.Views.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.");
                return;
            }

            try
            {
                AuthController controller = new AuthController();
                var (isAuthenticated, role) = controller.Login(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Login berhasil sebagai " + role);

                    if (role == "owner")
                    {
                        MenuOwner owner = new MenuOwner();
                        owner.Show();
                    }
                    else if (role == "petani")
                    {
                        MenuPetani petani = new MenuPetani();
                        petani.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal. Username atau password salah.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
