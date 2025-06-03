namespace Baccofy.Views.Menu.Gaji
{
    partial class Gaji_Petani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gaji_Petani));
            pictureBox1 = new PictureBox();
            dgvGajiPetani = new DataGridView();
            txtNominal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKeterangan = new TextBox();
            comboBox1 = new ComboBox();
            cbNamaAkun = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dtpTanggal = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGajiPetani).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvGajiPetani
            // 
            dgvGajiPetani.AutoGenerateColumns = true;

            dgvGajiPetani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGajiPetani.Location = new Point(154, 211);
            dgvGajiPetani.Name = "dgvGajiPetani";
            dgvGajiPetani.Size = new Size(556, 194);
            dgvGajiPetani.TabIndex = 1;
            dgvGajiPetani.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(309, 126);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(100, 23);
            txtNominal.TabIndex = 2;
            txtNominal.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 129);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Nominal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 167);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(309, 164);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(100, 23);
            txtKeterangan.TabIndex = 5;
            txtKeterangan.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(35, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbNamaAkun
            // 
            cbNamaAkun.FormattingEnabled = true;
            cbNamaAkun.Location = new Point(497, 129);
            cbNamaAkun.Name = "cbNamaAkun";
            cbNamaAkun.Size = new Size(105, 23);
            cbNamaAkun.TabIndex = 7;
            cbNamaAkun.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 129);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Akun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 167);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 9;
            label4.Text = "Tanggal";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(635, 100);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += button1_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(635, 138);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button2_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(635, 181);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(75, 23);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Delete";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += button3_Click;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(497, 164);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(105, 23);
            dtpTanggal.TabIndex = 14;
            dtpTanggal.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Gaji_Petani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpTanggal);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbNamaAkun);
            Controls.Add(comboBox1);
            Controls.Add(txtKeterangan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNominal);
            Controls.Add(dgvGajiPetani);
            Controls.Add(pictureBox1);
            Name = "Gaji_Petani";
            Text = "Gaji_Petani";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGajiPetani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvGajiPetani;
        private TextBox txtNominal;
        private Label label1;
        private Label label2;
        private TextBox txtKeterangan;
        private ComboBox comboBox1;
        private ComboBox cbNamaAkun;
        private Label label3;
        private Label label4;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private DateTimePicker dtpTanggal;
    }
}