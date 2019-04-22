using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VeriTabaniProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string secim = "";
        MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=root;database=musterisiparis");
        MySqlDataAdapter da;
        DataTable dt;
        private void Listele()
        {
            try
            {
                baglanti.Open();
                da = new MySqlDataAdapter("SELECT * FROM Musteriler", baglanti);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                label6.Text = "Bağlantı başarılı...";

                veriCek();

            }
            catch (Exception e)
            {
                label6.Text = "Bağlantı gerçekleştirilemedi. " + e.ToString();
            }
            
        }

        private void veriCek()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void PasifButton()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
        }
        private void AktifButton()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void AktiftextBox()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;

        }

        private void PasiftextBox()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PasiftextBox();
            button4.Enabled = false;
            button5.Enabled = false;
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktiftextBox();
            PasifButton();
            Temizle();
            secim = "Ekle";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AktiftextBox();
            PasifButton();
            secim = "Güncelle";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AktifButton();
            Sil();
            Listele();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secim == "Ekle")
                Ekle();
            else if (secim == "Güncelle")
                Guncelle();
            AktifButton();
            Listele();
        }

        private void Ekle()
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO musteriler (musteriNo,musteriAdi,musteriSoyadi,musteriEposta,musteriTelefon) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Guncelle()
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("Update musteriler set musteriAdi='" + textBox2.Text + "',musteriSoyadi='" + textBox3.Text + "', musteriEposta='" + textBox4.Text + "', musteriTelefon='" + textBox5.Text + "' where musteriNo='"+textBox1.Text+"'",baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();

        }

        private void Sil()
        {
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("delete from musteriler where musteriNo='" + textBox1.Text + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AktifButton();
            PasiftextBox();
            Temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            veriCek();
        }
    }
}
