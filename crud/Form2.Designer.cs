
namespace crud
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textnim = new System.Windows.Forms.TextBox();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaDataSet = new crud.MahasiswaDataSet();
            this.textnama = new System.Windows.Forms.TextBox();
            this.textprodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoTableAdapter = new crud.MahasiswaDataSetTableAdapters.InfoTableAdapter();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnganti = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textnim, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textnama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textprodi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(287, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRODI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAMA";
            // 
            // textnim
            // 
            this.textnim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoBindingSource, "NIM", true));
            this.textnim.Location = new System.Drawing.Point(103, 3);
            this.textnim.Name = "textnim";
            this.textnim.Size = new System.Drawing.Size(94, 20);
            this.textnim.TabIndex = 0;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "Info";
            this.infoBindingSource.DataSource = this.mahasiswaDataSet;
            // 
            // mahasiswaDataSet
            // 
            this.mahasiswaDataSet.DataSetName = "MahasiswaDataSet";
            this.mahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textnama
            // 
            this.textnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoBindingSource, "Nama", true));
            this.textnama.Location = new System.Drawing.Point(103, 59);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(94, 20);
            this.textnama.TabIndex = 1;
            // 
            // textprodi
            // 
            this.textprodi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infoBindingSource, "Prodi", true));
            this.textprodi.Location = new System.Drawing.Point(103, 120);
            this.textprodi.Name = "textprodi";
            this.textprodi.Size = new System.Drawing.Size(94, 20);
            this.textprodi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NIM";
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // btntambah
            // 
            this.btntambah.Location = new System.Drawing.Point(597, 76);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(75, 23);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "TAMBAH";
            this.btntambah.UseVisualStyleBackColor = true;
            this.btntambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnganti
            // 
            this.btnganti.Location = new System.Drawing.Point(597, 132);
            this.btnganti.Name = "btnganti";
            this.btnganti.Size = new System.Drawing.Size(75, 23);
            this.btnganti.TabIndex = 3;
            this.btnganti.Text = "GANTI";
            this.btnganti.UseVisualStyleBackColor = true;
            this.btnganti.Click += new System.EventHandler(this.btnganti_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(597, 183);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 4;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = true;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "KEMBALI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(216, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "Prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "Prodi";
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tabel Info";
            // 
            // Form2
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textnim;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox textprodi;
        private MahasiswaDataSet mahasiswaDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private MahasiswaDataSetTableAdapters.InfoTableAdapter infoTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnganti;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}