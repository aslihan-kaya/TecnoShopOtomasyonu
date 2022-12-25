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
    public partial class Sube : Form
    {
        public Sube()
        {
            InitializeComponent();
        }

        private void Liste()
        {
            dataGridView1.DataSource = FSubeler.Listele();
        }
        private void Sube_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ESubeler ekleme = new ESubeler();
            ekleme.SubeAdi = textBox1.Text;
            ekleme.Subeil = textBox2.Text;
            ekleme.Subeilce = textBox3.Text;
            FSubeler.Ekleme(ekleme);
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ESubeler ekleme = new ESubeler();
            ekleme.SubeNo = Convert.ToInt32(textBox1.Tag);
            ekleme.SubeAdi = textBox1.Text;
            ekleme.Subeil = textBox2.Text;
            ekleme.Subeilce = textBox3.Text;
            FSubeler.Guncelle(ekleme);
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells
                ["SubeNo"].Value.ToString();
            textBox1.Text = satir.Cells
                ["SubeAdi"].Value.ToString();
            textBox2.Text = satir.Cells
                ["Subeil"].Value.ToString();
            textBox3.Text = satir.Cells
                ["Subeilce"].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ESubeler sil = new ESubeler();
            sil.SubeNo = Convert.ToInt32(textBox1.Tag);
            FSubeler.Sil(sil);
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
