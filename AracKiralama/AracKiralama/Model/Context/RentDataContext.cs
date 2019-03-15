using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NYPProje.Model.Data;


namespace NYPProje.Model.Context
{
    class RentDataContext:DbContext
    {
        public RentDataContext()
        {
            Database.Connection.ConnectionString = "Server=PC;Database=NYPProjem;Trusted_Connection=true;";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ArabaEkle> ArabaEkles { get; set; }
        public DbSet<ArabaKirala> ArabaKiralas { get; set; }
        public DbSet<ArabaMarka> ArabaMarkas { get; set; }
        public DbSet<Personel> Personels { get; set; }

    }
}
