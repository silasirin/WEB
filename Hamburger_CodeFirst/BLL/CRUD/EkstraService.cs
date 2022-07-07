using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CRUD
{
    public class EkstraService
    {
        ProjectContext db = new ProjectContext();
        //Create
        public string CreateEkstra(Ekstra ekstra)
        {
            try
            {
                db.Ekstras.Add(ekstra);
                db.SaveChanges();
                return $"{ekstra.EkstraAdi} kaydedildi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        //listeleme
        public List<Ekstra> EkstraList()
        {
            return db.Ekstras.ToList();
        }

        //Guncelleme
        public string UpdateEkstra(Ekstra ekstra)
        {

            Ekstra updated = db.Ekstras.FirstOrDefault(x => x.EkstraID == ekstra.EkstraID);
            updated.EkstraAdi = ekstra.EkstraAdi;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme
        public string DeleteEkstra(int id)
        {
            try
            {
                Ekstra silinecek = db.Ekstras.Find(id);
                db.Ekstras.Remove(silinecek);
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
