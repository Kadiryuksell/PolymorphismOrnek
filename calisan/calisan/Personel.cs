using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisan
{
    public class Personel
    {
        public string Isim { get; set;}
        protected decimal maas;

        public decimal Maas
        {
            get
            {
                return maas;
            }
        }
        public Personel()
        {
            //todo
        }

        public virtual void maasHesapla()
        {
            //todo
        }

    }
}
