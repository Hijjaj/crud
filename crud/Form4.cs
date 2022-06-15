using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void teksid_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahasiswaDataSet.Kendaraan' table. You can move, or remove it, as needed.
            this.kendaraanTableAdapter.Fill(this.mahasiswaDataSet.Kendaraan);

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OG8P1VHL\\HIJJAJ;Initial Catalog=Mahasiswa;User ID=sa;Password=123");

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertkendaraan'" + textid.Text + "','" + textjenis.Text + "','" + textnama.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.showkendaraan", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnganti_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updatekendaraan'" + textid.Text + "','" + textjenis.Text + "','" + textnama.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilkan();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deletekendaraan'" + textid.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }
    }
}
