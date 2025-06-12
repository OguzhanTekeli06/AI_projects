using System.Collections.Generic;
using System.Linq;


namespace bulanikMantik1
{
    public class Bulanik_Mantik
    {


        public double hassaslik_mamdani, miktar_mamdani, kirlilik_mamdani;
        public double hassaslik, miktar, kirlilik;
       
        public Bulanik_Mantik(double hassaslik, double miktar, double kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
        }


        public string[] HassaslikKumesiniGetir()                          //Bu kısımlar, bulanık kümeleri temsil eder. Her parametre (hassaslık, miktar, kirlilik) için değerlerin ait olabileceği bulanık kümeleri belirler:
        {
            List<string> kumeler = new List<string>();

            if (hassaslik <= 4)
            {
                kumeler.Add("Sağlam");
            }
            if (hassaslik >= 3 && hassaslik <= 7)
            {
                kumeler.Add("Orta");
            }
            if (hassaslik >= 5.50)
            {
                kumeler.Add("Hassas");
            }

            if (kumeler.Count == 0)
            {
                kumeler.Add("Küme Bulunamadı ??");
            }

            return kumeler.ToArray();
        }                                    


        public List<string> Hassas = new List<string>();

        public void Hassasiyet_Kontrolu()
        {
            Hassas.AddRange(HassaslikKumesiniGetir());
        }

        public string[] KirlilikKumesiniGetir()
        {
            List<string> kumeler = new List<string>();

            if (kirlilik <= 4.50)
            {
                kumeler.Add("Küçük");
            }
            if (kirlilik >= 3 && kirlilik <= 7)
            {
                kumeler.Add("Orta");
            }
            if (kirlilik >= 5.50)
            {
                kumeler.Add("Büyük");
            }

            if (kumeler.Count == 0)
            {
                kumeler.Add("Küme Bulunamadı ??");
            }

            return kumeler.ToArray();
        }


        public List<string> Kir = new List<string>();

        public void Kirlilik_kontrolu()
        {
            Kir.AddRange(KirlilikKumesiniGetir());
        }

        public string[] MiktarKumesiniGetir()
        {
            List<string> kumeler = new List<string>();

            if (miktar <= 4)
            {
                kumeler.Add("Küçük");
            }
            if (miktar >= 3 && miktar <= 7)
            {
                kumeler.Add("Orta");
            }
            if (miktar >= 5.50)
            {
                kumeler.Add("Büyük");
            }

            if (kumeler.Count == 0)
            {
                kumeler.Add("Küme Bulunamadı ??");
            }

            return kumeler.ToArray();
        }


        public List<string> Mik = new List<string>();
        public void Miktar_kontrolu()
        {
            Mik.AddRange(MiktarKumesiniGetir());
        }

        public double Hassasiyet_mamdani(string kume_tip)                // bir girdinin bir kümeye ne kadar ait olduğunu bulanık üyelik derecesi (0-1 arası) ile ifade eder.
        {
            if (hassaslik < 2 && kume_tip == "Sağlam")
            {
                hassaslik_mamdani = 1;
            }
            else if (hassaslik >= 2 && hassaslik <= 4 && kume_tip == "Sağlam")
            {
                hassaslik_mamdani = (4 - hassaslik) / 2;
            }
            else if (hassaslik >= 3 && hassaslik <= 5 && kume_tip == "Orta")
            {
                hassaslik_mamdani = (hassaslik - 3) / 2;
            }
            else if (hassaslik >= 5 && hassaslik <= 7 && kume_tip == "Orta")
            {
                hassaslik_mamdani = (7 - hassaslik) / 2;
            }
            else if (hassaslik >= 5.5 && hassaslik <= 8 && kume_tip == "Hassas")
            {
                hassaslik_mamdani = (hassaslik - 5.5) / 2.5;
            }
            else
            {
                hassaslik_mamdani = 1;
            }
            return hassaslik_mamdani;
        }
        public double Miktar_mamdani(string kume_tip)
        {
            if (miktar < 2 && kume_tip == "Küçük")
            {
                miktar_mamdani = 1;
            }
            else if (miktar >= 2 && miktar <= 4 && kume_tip == "Küçük")
            {
                miktar_mamdani = (4 - miktar) / 2;
            }
            else if (miktar >= 3 && miktar <= 5 && kume_tip == "Orta")
            {
                miktar_mamdani = (miktar - 3) / 2;
            }
            else if (miktar >= 5 && miktar <= 7 && kume_tip == "Orta")
            {
                miktar_mamdani = (7 - miktar) / 2;
            }
            else if (miktar >= 5.5 && miktar <= 8 && kume_tip == "Büyük")
            {
                miktar_mamdani = (miktar - 5.5) / 2.5;
            }
            else
            {
                miktar_mamdani = 1;
            }
            return miktar_mamdani;
        }

        public double Kirlilik_mamdani(string kume_tip)
        {
            if (kirlilik < 2 && kume_tip == "Küçük")
            {
                kirlilik_mamdani = 1;
            }
            else if (kirlilik >= 2 && kirlilik <= 4.5 && kume_tip == "Küçük")
            {
                kirlilik_mamdani = (4.5 - kirlilik) / 2.5;
            }
            else if (kirlilik >= 3 && kirlilik <= 5 && kume_tip == "Orta")
            {
                kirlilik_mamdani = (kirlilik - 3) / 2;
            }
            else if (kirlilik >= 5 && kirlilik <= 7 && kume_tip == "Orta")
            {
                kirlilik_mamdani = (7 - kirlilik) / 2;
            }
            else if (kirlilik >= 5.5 && kirlilik <= 8 && kume_tip == "Büyük")
            {
                kirlilik_mamdani = (kirlilik - 5.5) / 2.5;
            }
            else
            {
                kirlilik_mamdani = 1;
            }
            return kirlilik_mamdani;
        }

        public double Min_arama(List<double> mamdani_snc)                //Bu fonksiyonlar, bulanık mantıktaki "AND" → min, "OR" → max işlemleri için kullanılır.
        {
            double min = mamdani_snc.Min();
            return min;
        }

        public double Max_arama(List<double> maxlar)
        {
            double max = maxlar.Max();
            return max;
        }


        public double donus_ortanca;
        public double sure_ortanca;
        public double deterjan_ortanca;
        public double Donus_hızı_Ortanca(string donus_hizi_tur)          // Dönüş hızı, süre ve deterjan miktarı için temsilci (ortalama) değerler atanmış:
        {
            if (donus_hizi_tur == "Hassas")
            {
                donus_ortanca = -1.15;
            }
            else if (donus_hizi_tur == "Normal Hassas")
            {
                donus_ortanca = 2.75;
            }
            else if (donus_hizi_tur == "Orta")
            {
                donus_ortanca = 5;
            }
            else if (donus_hizi_tur == "Normal Güçlü")
            {
                donus_ortanca = 7.25;
            }
            else
            {
                donus_ortanca = 11.15;
            }
            return donus_ortanca;
        }

        public double Sure_Ortanca(string sure_tur)
        {
            if (sure_tur == "Kısa")
            {
                sure_ortanca = -1.49;
            }
            else if (sure_tur == "Normal Kısa")
            {
                sure_ortanca = 39.9;
            }
            else if (sure_tur == "Orta")
            {
                sure_ortanca = 57.5;
            }
            else if (sure_tur == "Normal Uzun")
            {
                sure_ortanca = 75.1;
            }
            else
            {
                sure_ortanca = 102.15;
            }
            return sure_ortanca;
        }

        public double Deretjan_Ortanca(string deterjanTur)
        {
            if (deterjanTur == "Çok Az")
            {
                deterjan_ortanca = 10;
            }
            else if (deterjanTur == "Normal Hassas")
            {
                deterjan_ortanca = 85;
            }
            else if (deterjanTur == "Orta")
            {
                deterjan_ortanca = 150;
            }
            else if (deterjanTur == "Normal Güçlü")
            {
                deterjan_ortanca = 215;
            }
            else
            {
                deterjan_ortanca = 290;
            }
            return deterjan_ortanca;
        }

         public List<double> dns = new List<double>();
        public double dns_snc;
        public double donus_ort;
        public double Durulama(List<double> maxlar, List<double> ortancalar)
        {
            double donus = 0;
            for (int i = 0; i < maxlar.Count(); i++)
            {
                donus += maxlar[i];
            }
            for (int i = 0; i < maxlar.Count(); i++)
            {
                dns.Add(maxlar[i] * ortancalar[i]);
            }
            dns_snc = dns.Sum();

            donus_ort = dns_snc / donus;

            return donus_ort;
        }
    
    }
}