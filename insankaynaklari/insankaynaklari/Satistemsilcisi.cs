using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insankaynaklari
{
    class Satistemsilcisi : Calisan
    {
        public int satismiktari { get; set; }

        public override double PirimliMaasHesapla(int satisadeti)
        {
            if (satisadeti <= 10)
            {
                maas += satisadeti * 10;
            }
            else if (satisadeti <= 20) 
            {
                maas *= satisadeti * 30;
                            }
            else
            {
                maas += satisadeti * 10;    
            }
            return maas;
        }
    }
}
