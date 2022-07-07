using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CRUD
{
    public class MenuService
    {
        ProjectContext db = new ProjectContext();

        //Menu CRUD islemleri

        //Create
        public string CreateMenu(BurgerMenu menu)
        {
            try
            {
                db.BurgerMenus.Add(menu);
                db.SaveChanges();
                return $"{menu.MenuAdi} kaydedildi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //listeleme
        public List<BurgerMenu> MenuList()
        {
            return db.BurgerMenus.ToList();
        }

        //Guncelleme
        public string UpdateMenu(BurgerMenu menu)
        {

            BurgerMenu updated = db.BurgerMenus.FirstOrDefault(x => x.BurgerMenuID == menu.BurgerMenuID);
            updated.MenuAdi = menu.MenuAdi;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme
        public string DeleteMenu(int id)
        {
            try
            {
                BurgerMenu silinecek = db.BurgerMenus.Find(id);
                db.BurgerMenus.Remove(silinecek);
                db.SaveChanges();
                return "Silme işlemi gerçekleştirildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
