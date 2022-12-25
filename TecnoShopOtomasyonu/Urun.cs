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
using Entity;
using Facade;

namespace TecnoShopOtomasyonu
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=MSI;Database=TecnoShop;Integrated Security=true");

        private void Liste()
        {
            dataGridView1.DataSource = FUrunler.Listele();
        }

        public void methot(string scode)
        {
            SqlDataAdapter dp = new SqlDataAdapter(scode, con);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel go = new Personel();
            go.Show();
            this.Hide();
        }

        private void şubelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sube go = new Sube();
            go.Show();
            this.Hide();
        }

        private void müşterilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Musteri go = new Musteri();
            go.Show();
            this.Hide();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun go = new Urun();
            go.Show();
            this.Hide();
        }

        private void Urun_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand secim = new SqlCommand("select * from Urunler", con);

            SqlDataReader dr;
            dr = secim.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UrunTipi"].ToString());
            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EUrunler ekleme = new EUrunler();
            ekleme.UrunTipi = comboBox1.Text;
            ekleme.UrunAdi = textBox2.Text;
            ekleme.UrunFiyat =Convert.ToDecimal( textBox3.Text);
            ekleme.MusteriNo = Convert.ToInt32(textBox4.Text);
            FUrunler.Ekleme(ekleme);
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EUrunler ekleme = new EUrunler();
            ekleme.UrunNo = Convert.ToInt32(comboBox1.Tag);
            ekleme.UrunTipi = comboBox1.Text;
            ekleme.UrunAdi = textBox2.Text;
            ekleme.UrunFiyat = Convert.ToDecimal(textBox3.Text);
            ekleme.MusteriNo = Convert.ToInt32(textBox4.Text);
            FUrunler.Guncelle(ekleme);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            comboBox1.Tag = satir.Cells
                ["UrunNo"].Value.ToString();
            comboBox1.Text = satir.Cells
                ["UrunTipi"].Value.ToString();
            textBox2.Text = satir.Cells
                ["UrunAdi"].Value.ToString();
            textBox3.Text = satir.Cells
                ["UrunFiyat"].Value.ToString();
            textBox4.Text = satir.Cells
               ["MusteriNo"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EUrunler sil = new EUrunler();
            sil.UrunNo = Convert.ToInt32(comboBox1.Tag);
            FUrunler.Sil(sil);
            Liste();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand secim = new SqlCommand("select * from Urunler where UrunTipi=@UrunTipi", con);
            secim.Parameters.AddWithValue("@UrunTipi", comboBox1.SelectedItem);

            SqlDataReader dr;
            dr = secim.ExecuteReader();

            while (dr.Read())
            {
                textBox3.Text = dr["UrunFiyat"].ToString();
            }

            con.Close();
        }
    }
    }

