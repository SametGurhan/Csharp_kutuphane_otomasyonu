using _135_Forms_kutuphane_otomasyon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _135_Forms_kutuphane_otomasyon
{
    public partial class AdminSayfasi : Form
    {
        List<kisi> kisilerim;
        List<Kitap> kitaplarim;
      

        public AdminSayfasi(List<kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
                
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (kisi kisi in kisilerim) 
            {
                dataGridView1.Rows.Add(kisi.getId(),kisi.getIsim(),kisi.getSoyisim(),kisi.getOlusturmaTarih(),kisi.getKullaniciAdi(),kisi.getSifre(),kisi.getYetki());
           
            }

            foreach (Kitap kitap in kitaplarim ) 
            {
                dataGridView2.Rows.Add(kitap.getkitapid(),kitap.getkitapismi(),kitap.getkitapyazar(),kitap.getkitapdili(),kitap.getyayinevi(),kitap.getkitaptur(),kitap.getadet(),kitap.getsayfasayi(),kitap.getbasimyil());
            }
        }

        public void textleridoldur() 
        {
            if(dataGridView1.CurrentRow.Cells[0]!=null)
            { 
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
   
     
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }
        private void button1_Click(object sender, EventArgs e)
        {//ekle
            dataGridView1.Rows.Add(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,maskedTextBox1.Text,textBox5.Text,textBox6.Text,textBox7.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {//sil
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string isim = textBox2.Text;
            string soyisim = textBox3.Text;
            string tarih = maskedTextBox1.Text;
            string kullaniciadi = textBox5.Text;
            string sifre = textBox6.Text;
            string yetki = textBox7.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullaniciadi,sifre,yetki);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i=0;i<groupBox1.Controls.Count;i++) 
            { 
                if(groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is MaskedTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox01.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox02.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox03.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox04.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox05.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox06.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox07.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox08.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox09.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //1ekle
            dataGridView2.Rows.Add(textBox01.Text,textBox02.Text,textBox03.Text,textBox04.Text,textBox05.Text,textBox06.Text,textBox07.Text,textBox08.Text,textBox09.Text);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //2sil
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            //3güncelle
            string kitapid = textBox01.Text;
            string kitapismi = textBox02.Text;
            string kitapyazar = textBox03.Text;
            string kitapdili = textBox04.Text;
            string yayinevi = textBox05.Text;
            string kitaptur = textBox06.Text;
            string adet = textBox07.Text;
            string sayfasayi = textBox08.Text;
            string basimyil = textBox09.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapismi, kitapyazar, kitapdili, yayinevi, kitaptur, adet, sayfasayi, basimyil);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            //4 temizle
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                if (groupBox2.Controls[i] is TextBox)
                {
                    groupBox2.Controls[i].Text = string.Empty;
                }
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kisiara_Click(object sender, EventArgs e)
        {
            kisi hedefkisi = null;
            int secilenkisi_id = Convert.ToInt32(txt_kisiid.Text);

            foreach(kisi kisi in kisilerim)
            {

                if(kisi.getId()==secilenkisi_id)
                {
                    hedefkisi = kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkisi.getId(),hedefkisi.getIsim(),hedefkisi.getSoyisim(),hedefkisi.getOlusturmaTarih(),hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());
            

        }

        private void btn_kisiyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Clear();

            foreach (kisi hedefkisi in kisilerim)
            {

                 dataGridView1.Rows.Add(hedefkisi.getId(),hedefkisi.getIsim(),hedefkisi.getSoyisim(),hedefkisi.getOlusturmaTarih(),hedefkisi.getKullaniciAdi(), hedefkisi.getSifre(), hedefkisi.getYetki());
                
            }


        }

        private void btn_kitapara_Click(object sender, EventArgs e)
        {
            Kitap hedefkitap = null;
            int secilenkitap_id = Convert.ToInt32(txt_kitapid.Text);

            foreach(Kitap kitap in kitaplarim )
            {

                if(kitap.getkitapid()==secilenkitap_id)
                {
                    hedefkitap = kitap;
                    break;
                }

            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefkitap.getkitapid(),hedefkitap.getkitapismi(),hedefkitap.getkitapyazar(),hedefkitap.getkitapdili(),hedefkitap.getyayinevi(),hedefkitap.getkitaptur(),hedefkitap.getadet(),hedefkitap.getsayfasayi(),hedefkitap.getbasimyil());
        }

        private void btn_kitapyenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Clear();

            foreach (Kitap hedefkitap in kitaplarim)
            {

                dataGridView2.Rows.Add(hedefkitap.getkitapid(),hedefkitap.getkitapismi(),hedefkitap.getkitapyazar(),hedefkitap.getkitapdili(),hedefkitap.getyayinevi(),hedefkitap.getkitaptur(),hedefkitap.getadet(),hedefkitap.getsayfasayi(),hedefkitap.getbasimyil());

            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
