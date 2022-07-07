using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=localhost\\SQLEXPRESS;Database=BurgerCF_DB;Trusted_Connection=True;";
        }

        public DbSet<BurgerMenu> BurgerMenus { get; set; }
        public DbSet<Ekstra> Ekstras { get; set; }
    }
    
}
