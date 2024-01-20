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
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;

            bool kontrol = false;

            foreach(kisi kisi in kisilerim)
            {
                if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "Admin")
                {
                    //Admin sayfası yüklencek
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;

                }
                else if (kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "Üye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }

            }

            if(!kontrol)
            {
                MessageBox.Show("Hatalı giriş.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1,"Samet","Bayram",DateTime.Now,"samet","1","Admin"));
            kisilerim.Add(new kisi(2,"Enes","Yaprak",DateTime.Now,"enes","2","Üye"));
            kisilerim.Add(new kisi(3,"Burak","Çare",DateTime.Now,"bilal","3","Üye"));
            kisilerim.Add(new kisi(4,"Yaren","Kızıl",DateTime.Now,"yaren","4","Üye"));

            kitaplarim.Add(new Kitap(1,"İçimizdeki Şeytan","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","Roman",300,250,2016));
            kitaplarim.Add(new Kitap(2,"Tutunamayanlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",100,760,2015));
            kitaplarim.Add(new Kitap(3,"Uçurtma Avcısı","Khaled Hosseini","İngilizce","Everest Yayıncılık","Roman",200,350,2010));
            kitaplarim.Add(new Kitap(4,"Küçük Prens","Antoine de Saint-Exupery","İngilizce","Can Çocuk Yayınları","Roman",70,60,2018));
            kitaplarim.Add(new Kitap(5,"Kürk Mantolu Madonna","Sebahattin Ali","Türkçe","Yapı Kredi Yayınları","Roman",400,220,2015));
             // kitaplarim.Add(new Kitap(6,"Tehlikeli Oyunlar","Oğuz Atay","Türkçe","İletişim Yayıncılık","Roman",350,500,2015));
        }
    }
}
