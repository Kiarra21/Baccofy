using Baccofy.Controllers;
using Baccofy.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Baccofy.Views.Menu.Gaji
{
    public partial class Gaji_Petani : Form
    {
        private List<GajiPetaniModel> gajiList;

        public Gaji_Petani()
        {
            InitializeComponent();
            this.Load += Gaji_Petani_Load; 
        }

        private void Gaji_Petani_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxAkun();
            LoadComboBoxId();
        }

        private void LoadData()
        {
            gajiList = GajiPetaniController.GetAll();

            dgvGajiPetani.DataSource = null;
            dgvGajiPetani.AutoGenerateColumns = true;
            dgvGajiPetani.DataSource = gajiList;

            if (dgvGajiPetani.Columns.Contains("Akun_Id_Akun"))
                dgvGajiPetani.Columns["Akun_Id_Akun"].Visible = false;

        }


        private void LoadComboBoxAkun()
        {
            var akunList = AkunController.GetAll();
            cbNamaAkun.DataSource = null;
            cbNamaAkun.DataSource = akunList;
            cbNamaAkun.DisplayMember = "Username";
            cbNamaAkun.ValueMember = "Id_Akun";
        }

        private void LoadComboBoxId()
        {
            var list = GajiPetaniController.GetAll();
            comboBox1.DataSource = null;
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Id_Gaji";
            comboBox1.ValueMember = "Id_Gaji";
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                var gaji = new GajiPetaniModel
                {
                    Tanggal = dtpTanggal.Value,
                    Nominal = decimal.Parse(txtNominal.Text),
                    Keterangan = txtKeterangan.Text,
                    Akun_Id_Akun = (int)cbNamaAkun.SelectedValue
                };

                GajiPetaniController.Insert(gaji);
                MessageBox.Show("Gaji petani berhasil ditambahkan.");
                LoadData();
                LoadComboBoxId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            try
            {
                var gaji = new GajiPetaniModel
                {
                    Id_Gaji = (int)comboBox1.SelectedValue,
                    Tanggal = dtpTanggal.Value,
                    Nominal = decimal.Parse(txtNominal.Text),
                    Keterangan = txtKeterangan.Text,
                    Akun_Id_Akun = (int)cbNamaAkun.SelectedValue
                };

                GajiPetaniController.Update(gaji);
                MessageBox.Show("Gaji petani berhasil diupdate.");
                LoadData();
                LoadComboBoxId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = (int)comboBox1.SelectedValue;
                    GajiPetaniController.Delete(id);
                    MessageBox.Show("Gaji petani berhasil dihapus.");
                    LoadData();
                    LoadComboBoxId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null) return;

            int selectedId;
            if (int.TryParse(comboBox1.SelectedValue.ToString(), out selectedId))
            {
                // Cari data dengan Id_Gaji yang dipilih
                var selectedGaji = gajiList?.Find(g => g.Id_Gaji == selectedId);
                if (selectedGaji != null)
                {
                    dtpTanggal.Value = selectedGaji.Tanggal;
                    txtNominal.Text = selectedGaji.Nominal.ToString();
                    txtKeterangan.Text = selectedGaji.Keterangan;
                    cbNamaAkun.SelectedValue = selectedGaji.Akun_Id_Akun;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}