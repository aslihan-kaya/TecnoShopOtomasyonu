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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        private void Liste()
        {
            dataGridView1.DataSource = FPersoneller.Listele();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EPersoneller ekleme = new EPersoneller();
            ekleme.PersonelAdi = textBox1.Text;
            ekleme.Telefon = Convert.ToInt32( textBox2.Text);
            ekleme.Adres = textBox3.Text;
            ekleme.Maas = Convert.ToDecimal( textBox4.Text);
            ekleme.Prim = Convert.ToDecimal(textBox5.Text);
            ekleme.SubeNo = Convert.ToInt32(textBox6.Text);
            FPersoneller.Ekleme(ekleme);
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EPersoneller ekleme = new EPersoneller();
            ekleme.PersonelNo = Convert.ToInt32(textBox1.Tag);
            ekleme.PersonelAdi = textBox1.Text;
            ekleme.Telefon = Convert.ToInt32(textBox2.Text);
            ekleme.Adres = textBox3.Text;
            ekleme.Maas = Convert.ToDecimal(textBox4.Text);
            ekleme.Prim = Convert.ToDecimal(textBox5.Text);
            ekleme.SubeNo = Convert.ToInt32(textBox6.Text);
            FPersoneller.Guncelle(ekleme);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells
                ["PersonelNo"].Value.ToString();
            textBox1.Text = satir.Cells
                ["PersonelAdi"].Value.ToString();
            textBox2.Text = satir.Cells
                ["Teleon"].Value.ToString();
            textBox3.Text = satir.Cells
                ["Adres"].Value.ToString();
            textBox4.Text = satir.Cells
               ["Maas"].Value.ToString();
            textBox5.Text = satir.Cells
               ["Prim"].Value.ToString();
            textBox6.Text = satir.Cells
               ["SubeNo"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EPersoneller sil = new EPersoneller();
            sil.PersonelNo = Convert.ToInt32(textBox1.Tag);
            FPersoneller.Sil(sil);
            Liste();
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

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar go = new Raporlar();
            go.Show();
            this.Hide();
        }
    }
}
