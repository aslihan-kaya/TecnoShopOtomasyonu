using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;

namespace TecnoShopOtomasyonu
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            dataGridView1.DataSource = FMusteriler.Listele();
        }

        private void şubelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sube go = new Sube();
            go.Show();
            this.Hide();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel go = new Personel();
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

        private void Musteri_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMusteriler ekleme = new EMusteriler();
            ekleme.MusteriAdi = textBox1.Text;
            ekleme.MTelefon = Convert.ToInt32(textBox2.Text);
            ekleme.MAdres = textBox3.Text;
            ekleme.PersonelNo = Convert.ToInt32 (textBox4.Text);
            FMusteriler.Ekleme(ekleme);
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMusteriler ekleme = new EMusteriler();
            ekleme.MusteriNo = Convert.ToInt32(textBox1.Tag);
            ekleme.MusteriAdi = textBox1.Text;
            ekleme.MTelefon = Convert.ToInt32(textBox2.Text);
            ekleme.MAdres = textBox3.Text;
            ekleme.PersonelNo = Convert.ToInt32(textBox4.Text);
            FMusteriler.Guncelle(ekleme);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells
                ["MusteriNo"].Value.ToString();
            textBox1.Text = satir.Cells
                ["MusteriAdi"].Value.ToString();
            textBox2.Text = satir.Cells
                ["MTeleon"].Value.ToString();
            textBox3.Text = satir.Cells
                ["MAdres"].Value.ToString();
            textBox4.Text = satir.Cells
               ["PersonelNo"].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMusteriler sil = new EMusteriler();
            sil.MusteriNo = Convert.ToInt32(textBox1.Tag);
            FMusteriler.Sil(sil);
            Liste();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }
    }
}
