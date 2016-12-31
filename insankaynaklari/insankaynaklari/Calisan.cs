using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insankaynaklari
{
    class Calisan
    {
        public int tckimlik { get; set; }

        public int maas { get; set; }

        public string elemanturu { get; set; }

        public override string ToString()
        {
            return string.Format("T.C. Kimlik No : {0} \t Maaş : {1}");
        }
        public virtual double PirimMaasHesapla(int satisAdeti)
        {
            double prim = satisAdeti * 10;
            return maas + prim;
        }
    }
}
