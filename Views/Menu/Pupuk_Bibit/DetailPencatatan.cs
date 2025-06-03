using Baccofy.Controllers;
using Baccofy.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Baccofy.Views.Menu.Pupuk_Bibit
{
    public partial class DetailPencatatan : Form
    {
        private int _idPencatatan;

        public DetailPencatatan(int idPencatatan)
        {
            InitializeComponent();
            _idPencatatan = idPencatatan;

            LoadComboBoxBahan();
            LoadData();
        }

        private void LoadComboBoxBahan()
        {
            var bahanList = DetailPencatatanController.GetAllBahan();
            comboBoxBahan.DataSource = bahanList;
            comboBoxBahan.DisplayMember = "Nama_Bahan";
            comboBoxBahan.ValueMember = "Id_Bahan";
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DetailPencatatanController.GetByPencatatanId(_idPencatatan);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(txtBoxKuantitas.Text);
                string ket = txtboxKeterangan.Text;
                int idBahan = Convert.ToInt32(comboBoxBahan.SelectedValue);

                DetailPencatatanController.InsertDetail(_idPencatatan, idBahan, quantity, ket);
                MessageBox.Show("Detail berhasil ditambahkan.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan detail: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
