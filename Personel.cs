using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp
{
    public class Personel
    {
        public string Ad {  get; set; }//auto property
        public string Soyad {  get; set; }
        public string Tel {  get; set; }
        public string Adres {  get; set; }
        public string FullName => $"{Ad} {Soyad}";

        private int yas;//field
        public int Yas//backing field property 
        {
            get //property okumak istediğinde
            {
                return yas;

            }
            set//property yazılmak istendiğinde
            {
                //kontrol mekanizması
                if (value>0)
                {
                    yas = value;
                }
            }
        }

    }
}