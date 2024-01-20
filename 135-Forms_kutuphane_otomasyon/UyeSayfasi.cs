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
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach(Kitap kitap in kitaplarim)
            {

                dataGridView1.Rows.Add(kitap.getkitapid(),kitap.getkitapismi(),kitap.getkitapyazar(),kitap.getkitapdili(),kitap.getyayinevi(),kitap.getkitaptur(),kitap.getadet(),kitap.getsayfasayi(),kitap.getbasimyil());

            }
        }

        private void btn_ktpara_Click(object sender, EventArgs e)
        {
            int kitapid=Convert.ToInt32(txt_ktpid.Text);
            Kitap hedefkitap = null;

            foreach (Kitap kitap in kitaplarim)
            {
                if(kitap.getkitapid()==kitapid)
                {
                    hedefkitap = kitap;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefkitap.getkitapid(),hedefkitap.getkitapismi(),hedefkitap.getkitapyazar(),hedefkitap.getkitapdili(),hedefkitap.getyayinevi(),hedefkitap.getkitaptur(), hedefkitap.getadet(), hedefkitap.getsayfasayi(), hedefkitap.getbasimyil());
            
        }

        private void btn_ktpyenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Clear();

            foreach (Kitap hedefkitap in kitaplarim)
            {

                dataGridView1.Rows.Add(hedefkitap.getkitapid(),hedefkitap.getkitapismi(),hedefkitap.getkitapyazar(),hedefkitap.getkitapdili(),hedefkitap.getyayinevi(),hedefkitap.getkitaptur(), hedefkitap.getadet(), hedefkitap.getsayfasayi(), hedefkitap.getbasimyil());

            }
        }
    }
}
