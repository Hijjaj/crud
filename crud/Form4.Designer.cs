
namespace crud
{
    partial class Form4
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
            this.iDKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaDataSet = new crud.MahasiswaDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnganti = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tekssks = new System.Windows.Forms.Label();
            this.teksnama = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.teksid = new System.Windows.Forms.Label();
            this.textjenis = new System.Windows.Forms.TextBox();
            this.kendaraanTableAdapter = new crud.MahasiswaDataSetTableAdapters.KendaraanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tabel Kendaraan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKendaraanDataGridViewTextBoxColumn,
            this.jeniskendaraanDataGridViewTextBoxColumn,
            this.namaKendaraanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kendaraanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // iDKendaraanDataGridViewTextBoxColumn
            // 
            this.iDKendaraanDataGridViewTextBoxColumn.DataPropertyName = "ID_Kendaraan";
            this.iDKendaraanDataGridViewTextBoxColumn.HeaderText = "ID_Kendaraan";
            this.iDKendaraanDataGridViewTextBoxColumn.Name = "iDKendaraanDataGridViewTextBoxColumn";
            // 
            // jeniskendaraanDataGridViewTextBoxColumn
            // 
            this.jeniskendaraanDataGridViewTextBoxColumn.DataPropertyName = "Jenis_kendaraan";
            this.jeniskendaraanDataGridViewTextBoxColumn.HeaderText = "Jenis_kendaraan";
            this.jeniskendaraanDataGridViewTextBoxColumn.Name = "jeniskendaraanDataGridViewTextBoxColumn";
            // 
            // namaKendaraanDataGridViewTextBoxColumn
            // 
            this.namaKendaraanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.HeaderText = "Nama_Kendaraan";
            this.namaKendaraanDataGridViewTextBoxColumn.Name = "namaKendaraanDataGridViewTextBoxColumn";
            // 
            // kendaraanBindingSource
            // 
            this.kendaraanBindingSource.DataMember = "Kendaraan";
            this.kendaraanBindingSource.DataSource = this.mahasiswaDataSet;
            // 
            // mahasiswaDataSet
            // 
            this.mahasiswaDataSet.DataSetName = "MahasiswaDataSet";
            this.mahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(553, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "KEMBALI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(553, 194);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 18;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnganti
            // 
            this.btnganti.Location = new System.Drawing.Point(553, 143);
            this.btnganti.Name = "btnganti";
            this.btnganti.Size = new System.Drawing.Size(75, 23);
            this.btnganti.TabIndex = 17;
            this.btnganti.Text = "GANTI";
            this.btnganti.UseVisualStyleBackColor = true;
            this.btnganti.Click += new System.EventHandler(this.btnganti_Click);
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(553, 87);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 16;
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
            this.tableLayoutPanel1.Controls.Add(this.textnama, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.teksid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textjenis, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(243, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 172);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tekssks
            // 
            this.tekssks.AutoSize = true;
            this.tekssks.Location = new System.Drawing.Point(3, 117);
            this.tekssks.Name = "tekssks";
            this.tekssks.Size = new System.Drawing.Size(90, 13);
            this.tekssks.TabIndex = 5;
            this.tekssks.Text = "Nama Kendaraan";
            // 
            // teksnama
            // 
            this.teksnama.AutoSize = true;
            this.teksnama.Location = new System.Drawing.Point(3, 56);
            this.teksnama.Name = "teksnama";
            this.teksnama.Size = new System.Drawing.Size(86, 13);
            this.teksnama.TabIndex = 4;
            this.teksnama.Text = "Jenis Kendaraan";
            // 
            // textid
            // 
            this.textid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kendaraanBindingSource, "ID_Kendaraan", true));
            this.textid.Location = new System.Drawing.Point(103, 3);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(94, 20);
            this.textid.TabIndex = 0;
            // 
            // textnama
            // 
            this.textnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kendaraanBindingSource, "Nama_Kendaraan", true));
            this.textnama.Location = new System.Drawing.Point(103, 120);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(94, 20);
            this.textnama.TabIndex = 2;
            // 
            // teksid
            // 
            this.teksid.AutoSize = true;
            this.teksid.Location = new System.Drawing.Point(3, 0);
            this.teksid.Name = "teksid";
            this.teksid.Size = new System.Drawing.Size(73, 13);
            this.teksid.TabIndex = 3;
            this.teksid.Text = "ID Kendaraan";
            this.teksid.Click += new System.EventHandler(this.teksid_Click);
            // 
            // textjenis
            // 
            this.textjenis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kendaraanBindingSource, "Jenis_kendaraan", true));
            this.textjenis.Location = new System.Drawing.Point(103, 59);
            this.textjenis.Name = "textjenis";
            this.textjenis.Size = new System.Drawing.Size(94, 20);
            this.textjenis.TabIndex = 1;
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label teksid;
        private System.Windows.Forms.TextBox textjenis;
        private MahasiswaDataSet mahasiswaDataSet;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private MahasiswaDataSetTableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKendaraanDataGridViewTextBoxColumn;
    }
}