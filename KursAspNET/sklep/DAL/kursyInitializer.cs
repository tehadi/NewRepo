using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using sklep.Models;

namespace sklep.DAL
{
    class kursyInitializer :DropCreateDatabaseAlways<KursyContext>
    {
        protected override void Seed(KursyContext context)
        {
            SeedKursyData(context);
            base.Seed(context);
            
        }

        private void SeedKursyData(KursyContext context)
        {
            var kategorie = new List<Kategoria>
           {
               new Kategoria() {KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc" },
               new Kategoria() {KategoriaId=2, NazwaKategorii="html", NazwaPlikuIkony="html.png",  OpisKategorii="opis htm" },
               new Kategoria() {KategoriaId=3, NazwaKategorii="cpp", NazwaPlikuIkony="cpp.png" , OpisKategorii="opiscpp" },
               new Kategoria() {KategoriaId=4, NazwaKategorii="java", NazwaPlikuIkony="java.png" , OpisKategorii="opis java" },
               new Kategoria() {KategoriaId=5, NazwaKategorii="jira", NazwaPlikuIkony="jira.png" , OpisKategorii="opis jira" }
           };
            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();
            var kursy = new List<Kurs>
            {
                new Kurs() { AutorKursu="adrian", TytulKursu="asp.mvc", KategoriaId=1, CenaKursu=99,BestSeller=true,NazwaPlikuObrazka="mvc.jpg", DataDodania= DateTime.Now ,OpisKursu="lalala opis 1"},
                new Kurs() { AutorKursu="adrian", TytulKursu="java kurs", KategoriaId=4, CenaKursu=199,BestSeller=true,NazwaPlikuObrazka="java.jpg", DataDodania= DateTime.Now ,OpisKursu="lalala opis 1"}
            };
            kursy.ForEach(k => context.Kursy.Add(k));
            context.SaveChanges();
        }
    }
}
