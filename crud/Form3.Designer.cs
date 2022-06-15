
namespace crud
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnganti = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tekssks = new System.Windows.Forms.Label();
            this.teksnama = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.textsks = new System.Windows.Forms.TextBox();
            this.teksid = new System.Windows.Forms.Label();
            this.mahasiswaDataSet = new crud.MahasiswaDataSet();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kendaraanTableAdapter = new crud.MahasiswaDataSetTableAdapters.KendaraanTableAdapter();
            this.matakuliahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matakuliahTableAdapter = new crud.MahasiswaDataSetTableAdapters.MatakuliahTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamatkulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matakuliahBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tabel Matakuliah";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.namamatkulDataGridViewTextBoxColumn,
            this.sksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matakuliahBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(553, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "KEMBALI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(553, 194);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 11;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnganti
            // 
            this.btnganti.Location = new System.Drawing.Point(553, 143);
            this.btnganti.Name = "btnganti";
            this.btnganti.Size = new System.Drawing.Size(75, 23);
            this.btnganti.TabIndex = 10;
            this.btnganti.Text = "GANTI";
            this.btnganti.UseVisualStyleBackColor = true;
            this.btnganti.Click += new System.EventHandler(this.btnganti_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(553, 87);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 9;
            this.btntambah.Text = "TAMBAH";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tekssks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.teksnama, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textsks, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.teksid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textnama, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(243, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 172);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tekssks
            // 
            this.tekssks.AutoSize = true;
            this.tekssks.Location = new System.Drawing.Point(3, 117);
            this.tekssks.Name = "tekssks";
            this.tekssks.Size = new System.Drawing.Size(28, 13);
            this.tekssks.TabIndex = 5;
            this.tekssks.Text = "SKS";
            // 
            // teksnama
            // 
            this.teksnama.AutoSize = true;
            this.teksnama.Location = new System.Drawing.Point(3, 56);
            this.teksnama.Name = "teksnama";
            this.teksnama.Size = new System.Drawing.Size(38, 13);
            this.teksnama.TabIndex = 4;
            this.teksnama.Text = "NAMA";
            // 
            // textid
            // 
            this.textid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matakuliahBindingSource, "ID", true));
            this.textid.Location = new System.Drawing.Point(103, 3);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(94, 20);
            this.textid.TabIndex = 0;
            // 
            // textnama
            // 
            this.textnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matakuliahBindingSource, "Nama_matkul", true));
            this.textnama.Location = new System.Drawing.Point(103, 59);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(94, 20);
            this.textnama.TabIndex = 1;
            // 
            // textsks
            // 
            this.textsks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matakuliahBindingSource, "sks", true));
            this.textsks.Location = new System.Drawing.Point(103, 120);
            this.textsks.Name = "textsks";
            this.textsks.Size = new System.Drawing.Size(94, 20);
            this.textsks.TabIndex = 2;
            // 
            // teksid
            // 
            this.teksid.AutoSize = true;
            this.teksid.Location = new System.Drawing.Point(3, 0);
            this.teksid.Name = "teksid";
            this.teksid.Size = new System.Drawing.Size(18, 13);
            this.teksid.TabIndex = 3;
            this.teksid.Text = "ID";
            // 
            // mahasiswaDataSet
            // 
            this.mahasiswaDataSet.DataSetName = "MahasiswaDataSet";
            this.mahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kendaraanBindingSource
            // 
            this.kendaraanBindingSource.DataMember = "Kendaraan";
            this.kendaraanBindingSource.DataSource = this.mahasiswaDataSet;
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // matakuliahBindingSource
            // 
            this.matakuliahBindingSource.DataMember = "Matakuliah";
            this.matakuliahBindingSource.DataSource = this.mahasiswaDataSet;
            // 
            // matakuliahTableAdapter
            // 
            this.matakuliahTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // namamatkulDataGridViewTextBoxColumn
            // 
            this.namamatkulDataGridViewTextBoxColumn.DataPropertyName = "Nama_matkul";
            this.namamatkulDataGridViewTextBoxColumn.HeaderText = "Nama_matkul";
            this.namamatkulDataGridViewTextBoxColumn.Name = "namamatkulDataGridViewTextBoxColumn";
            // 
            // sksDataGridViewTextBoxColumn
            // 
            this.sksDataGridViewTextBoxColumn.DataPropertyName = "sks";
            this.sksDataGridViewTextBoxColumn.HeaderText = "sks";
            this.sksDataGridViewTextBoxColumn.Name = "sksDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnganti);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matakuliahBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnganti;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tekssks;
        private System.Windows.Forms.Label teksnama;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox textsks;
        private System.Windows.Forms.Label teksid;
        private MahasiswaDataSet mahasiswaDataSet;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private MahasiswaDataSetTableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.BindingSource matakuliahBindingSource;
        private MahasiswaDataSetTableAdapters.MatakuliahTableAdapter matakuliahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamatkulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sksDataGridViewTextBoxColumn;
    }
}