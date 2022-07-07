using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class BurgerMenu
    {
        public int BurgerMenuID { get; set; }
        public string MenuAdi { get; set; }
        public decimal MenuFiyat { get; set; }

        //bir menunun birden cok esktrasi olur
        public List<Ekstra> Ekstras { get; set; }
    }
}
