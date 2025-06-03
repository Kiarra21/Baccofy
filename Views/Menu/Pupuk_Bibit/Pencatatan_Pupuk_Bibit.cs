using Baccofy.Controllers;
using Baccofy.Models;
using Baccofy.Views.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Baccofy.Views.Menu.Pupuk_Bibit
{
    public partial class Pencatatan_Pupuk_Bibit : Form
    {
        public Pencatatan_Pupuk_Bibit()
        {
            InitializeComponent();
            this.Load += Pencatatan_Pupuk_Bibit_Load;
        }

        private void Pencatatan_Pupuk_Bibit_Load(object sender, EventArgs e)
        {
            ReloadAll();
        }

        private void ReloadAll()
        {
            try
            {
                comboBox2.DataSource = null;
                comboBox2.DataSource = PencatatanController.GetAllAkun();
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";

                comboBox1.DataSource = null;
                comboBox1.DataSource = PencatatanController.GetAll();
                comboBox1.DisplayMember = "Id_Pencatatan";
                comboBox1.ValueMember = "Id_Pencatatan";

                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat load data: " + ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            var data = PencatatanController.GetAllWithUsername();
            dataGridView1.DataSource = data;

            if (!dataGridView1.Columns.Contains("DetailButton"))
            {
                DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
                detailButton.Name = "DetailButton";
                detailButton.HeaderText = "Detail";
                detailButton.Text = "Lihat Detail";
                detailButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(detailButton);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem is KeyValuePair<int, string> selectedAkun)
                {
                    var pencatatan = new PencatatanModel
                    {
                        Tanggal = dateTimePicker1.Value.Date,
                        Akun_Id_Akun = selectedAkun.Key
                    };

                    PencatatanController.Insert(pencatatan);
                    MessageBox.Show("Berhasil tambah data!");
                    ReloadAll();
                }
                else
                {
                    MessageBox.Show("Pilih akun terlebih dahulu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insert: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedValue is int selectedId &&
                    comboBox2.SelectedItem is KeyValuePair<int, string> selectedAkun)
                {
                    var pencatatan = new PencatatanModel
                    {
                        Id_Pencatatan = selectedId,
                        Tanggal = dateTimePicker1.Value.Date,
                        Akun_Id_Akun = selectedAkun.Key
                    };

                    PencatatanController.Update(pencatatan);
                    MessageBox.Show("Berhasil update data!");
                    ReloadAll();
                }
                else
                {
                    MessageBox.Show("Pilih data pencatatan dan akun terlebih dahulu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update: " + ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int selectedId)
            {
                var data = PencatatanController.GetById(selectedId);
                if (data != null)
                {
                    dateTimePicker1.Value = data.Tanggal;
                    comboBox2.SelectedValue = data.Akun_Id_Akun;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DetailButton"].Index && e.RowIndex >= 0)
            {
                int idPencatatan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_pencatatan"].Value);
                var detailForm = new DetailPencatatan(idPencatatan);
                detailForm.Show();
            }
        }

       
    }
}
