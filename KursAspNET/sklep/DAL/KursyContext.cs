using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using sklep.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace sklep.DAL
{
    class KursyContext : DbContext
    {
        public KursyContext():base("KursyContext")
        {

        }

        static KursyContext()
        {
            Database.SetInitializer<KursyContext>(new kursyInitializer()); //wywołanie inicializera
        }
        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
