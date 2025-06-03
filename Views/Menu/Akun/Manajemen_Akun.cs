using Baccofy.Controllers;
using Baccofy.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Baccofy.Views.Menu.Akun
{
    public partial class Manajemen_Akun : Form
    {
        private List<AkunModel> akunList;
        private List<RoleModel> roleList;

        public Manajemen_Akun()
        {
            InitializeComponent();
            LoadRoles();
            LoadAkunIds();
        }

        private void LoadData()
        {
            var akunList = AkunController.GetAll(); 
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = akunList;
        }
        private void LoadRoles()
        {
            roleList = AkunController.GetAllRoles();
            comboBox2.DataSource = roleList;
            comboBox2.DisplayMember = "Nama_Role";
            comboBox2.ValueMember = "Id_Role";
        }

        private void LoadAkunIds()
        {
            akunList = AkunController.GetAll();
            comboBox1.DataSource = akunList;
            comboBox1.DisplayMember = "Id_Akun";
            comboBox1.ValueMember = "Id_Akun";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is AkunModel selectedAkun)
            {
                textBox1.Text = selectedAkun.Username;
                textBox2.Text = selectedAkun.Password;
                textBox3.Text = selectedAkun.Nomor_Telepon;
                comboBox2.SelectedValue = selectedAkun.Role_Id_Role;
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            var akun = new AkunModel
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
                Nomor_Telepon = textBox3.Text,
                Role_Id_Role = Convert.ToInt32(comboBox2.SelectedValue)
            };

            AkunController.Create(akun);
            MessageBox.Show("Akun berhasil ditambahkan.");
            LoadAkunIds();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (comboBox1.SelectedItem is AkunModel selectedAkun)
            {
                selectedAkun.Username = textBox1.Text;
                selectedAkun.Password = textBox2.Text;
                selectedAkun.Nomor_Telepon = textBox3.Text;
                selectedAkun.Role_Id_Role = Convert.ToInt32(comboBox2.SelectedValue);

                AkunController.Update(selectedAkun);
                MessageBox.Show("Akun berhasil diupdate.");
                LoadAkunIds();
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            if (comboBox1.SelectedItem is AkunModel selectedAkun)
            {
                var result = MessageBox.Show("Yakin ingin menghapus akun ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AkunController.Delete(selectedAkun.Id_Akun);
                    MessageBox.Show("Akun berhasil dihapus.");
                    LoadAkunIds();
                    LoadData();
                }
            }
        }

        private void Manajemen_Akun_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadRoles();
            LoadAkunIds();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
