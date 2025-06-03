namespace Baccofy.Views.Menu.Pupuk_Bibit
{
    partial class DetailPencatatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPencatatan));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            txtBoxKuantitas = new TextBox();
            comboBoxBahan = new ComboBox();
            txtboxKeterangan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-23, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(420, 227);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBoxKuantitas
            // 
            txtBoxKuantitas.Location = new Point(365, 91);
            txtBoxKuantitas.Name = "txtBoxKuantitas";
            txtBoxKuantitas.Size = new Size(48, 23);
            txtBoxKuantitas.TabIndex = 2;
            // 
            // comboBoxBahan
            // 
            comboBoxBahan.FormattingEnabled = true;
            comboBoxBahan.Location = new Point(103, 91);
            comboBoxBahan.Name = "comboBoxBahan";
            comboBoxBahan.Size = new Size(152, 23);
            comboBoxBahan.TabIndex = 5;
            // 
            // txtboxKeterangan
            // 
            txtboxKeterangan.Location = new Point(103, 143);
            txtboxKeterangan.Name = "txtboxKeterangan";
            txtboxKeterangan.Size = new Size(152, 23);
            txtboxKeterangan.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 91);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "bahan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 143);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 8;
            label2.Text = "keterangan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 94);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "Kuantitas";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(537, 159);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 11;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // DetailPencatatan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambah);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxKeterangan);
            Controls.Add(comboBoxBahan);
            Controls.Add(txtBoxKuantitas);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "DetailPencatatan";
            Text = "DetailPencatatan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox txtBoxKuantitas;
        private ComboBox comboBoxBahan;
        private TextBox txtboxKeterangan;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnTambah;
    }
}