using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _135_Forms_kutuphane_otomasyon.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapismi  { get; set; }
        public string kitapyazar  { get; set; }
        public string kitapdili { get; set; }
        public string yayinevi  { get; set; }
        public string kitaptur  { get; set; }
        public int adet { get; set; }
        public int sayfasayi { get; set; }
        public int basimyil  { get; set; }//9 özellik
        public Kitap()
        {

        }
        public Kitap(int kitapid, string kitapismi, string kitapyazar, string kitapdili, string yayinevi, string kitaptur,int adet,int sayfasayi, int basimyil)
        {
            this.kitapid = kitapid;
            this.kitapismi = kitapismi;
            this.kitapyazar = kitapyazar;
            this.kitapdili = kitapdili;
            this.yayinevi = yayinevi;
            this.kitaptur = kitaptur;
            this.adet = adet;
            this.sayfasayi = sayfasayi;
            this.basimyil = basimyil;
           
        }
        //---------------------------------------------------------1
        public void setkitapid(int kitapid) 
        {
            this.kitapid = kitapid; 
        }
        public int getkitapid()
        {
            return this.kitapid; 
        }
        //--------------------------------------------------------2
        public void setkitapismi(string kitapismi) { this.kitapismi = kitapismi; }
        public string getkitapismi() { return this.kitapismi; }
        //--------------------------------------------------------3
        public void setkitapyazar(string kitapyazar) { this.kitapyazar = kitapyazar; }
        public string getkitapyazar() { return this.kitapyazar; }
        //--------------------------------------------------------4
        public void setkitapdili(string kitapdili) { this.kitapdili = kitapdili; }
        public string getkitapdili() { return this.kitapdili; }
        //--------------------------------------------------------5
        public void setyayinevi(string yayinevi) { this.yayinevi = yayinevi; }
        public string getyayinevi() { return this.yayinevi; }
        //--------------------------------------------------------6
        public void settur(string kitaptur) { this.kitaptur = kitaptur; }
        public string getkitaptur() { return this.kitaptur; }
        //--------------------------------------------------------7
        
        public void setadet(int adet) { this.adet = adet; }
        public int getadet() { return this.adet; }
        //--------------------------------------------------------8
        public void setsayfasayi(int sayfasayi) { this.sayfasayi = sayfasayi; }
        public int getsayfasayi() { return this.sayfasayi; }
        //--------------------------------------------------------9
        public void setbasimyil(int basimyil) { this.basimyil = basimyil; }
        public int getbasimyil() { return this.basimyil; }

        //---------------------------------------------------------

    }
}
