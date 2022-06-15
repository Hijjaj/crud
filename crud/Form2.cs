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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahasiswaDataSet.Info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.mahasiswaDataSet.Info);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OG8P1VHL\\HIJJAJ;Initial Catalog=Mahasiswa;User ID=sa;Password=123");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.insertinfo'"+textnim.Text+"','"+textnama.Text+"','"+textprodi.Text+"'",con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        void tampilkan()
        {
            SqlCommand com = new SqlCommand("exec dbo.showinfo", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnganti_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updateinfo'" + textnim.Text + "','" + textnama.Text + "','" + textprodi.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.deleteinfo'" + textnim.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses");
            tampilkan();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tampilkan();
        }
    }
    
}
