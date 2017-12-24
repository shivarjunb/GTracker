using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Goplecs.GTracker.DAL
{
    class GTContext : DbContext
    {
        //"GTContext" name of connection string on App.Config
        public GTContext():base("GTContext")
        {

        }

        //Define entity to use model as table
        public  DbSet<User> Users { get; set; }

        //prevents table names from being pluralized.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
