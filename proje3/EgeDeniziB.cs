using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje3
{
    public class EgeDeniziB
    {
        //tuttuğumuz veriler
        public string balik_Adi;
        public string diger_Adi;
        public string boyut;
        public string bilgi;
        public List<string> ortam;//ortam birden fazla olacağı için liste
        //boş constructerimiz
        public EgeDeniziB()
        {
            this.balik_Adi = string.Empty;
            this.diger_Adi = string.Empty;
            this.boyut = string.Empty;
            this.bilgi = string.Empty;
            this.ortam = new List<string>();
        }
        //parametreli constructerimiz
        public EgeDeniziB(string balik_Adi, string diger_Adi, string boyut, string bilgi, List<string> ortam)
        {
            this.balik_Adi = balik_Adi;
            this.diger_Adi = diger_Adi;
            this.boyut = boyut;
            this.bilgi = bilgi;
            this.ortam = ortam;
        }
        //toString Metodu
        public override string ToString()
        {
            return $"Balık: {balik_Adi}\n" +
                   $"Diğer Adı:{(diger_Adi != null ? $"({diger_Adi})" : "  Yok")}\n" +
                   $"Bilgi: \n {bilgi}\n" +
                   $"Boyut: {boyut}\n" +
                   $"Ortam: {string.Join(", ", ortam)}\n";
        }


    }
}
