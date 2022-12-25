using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoShopOtomasyonu
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=MSI;Database=TecnoShop;Integrated Security=true");
        public void method(string scode)
        {
            SqlDataAdapter dp = new SqlDataAdapter(scode, baglanti); //parametre alınmış
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            method ("select* from Urunler order by UrunTipi desc");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            method("select Sum(UrunFiyat) from Urunler group by UrunAdi");
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            method("select* from Subeler order by Subeil asc");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            method("select* from Musteriler order by MusteriAdi asc");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sube go = new Sube();
            go.Show();
            this.Hide();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
