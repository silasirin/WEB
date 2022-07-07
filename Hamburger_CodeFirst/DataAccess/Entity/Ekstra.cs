using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Ekstra
    {
        public int EkstraID { get; set; }
        public string EkstraAdi { get; set; }
        public decimal EkstraFiyat { get; set; }
        public int BurgerMenuID { get; set; } 

        //Bir ekstranin bir menusu olur.
        public BurgerMenu BurgerMenu { get; set; }

    }
}
