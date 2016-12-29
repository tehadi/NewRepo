using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string komentarz { get; set; }
        public DateTime dataDodania { get; set; }
        public StanZamowienia StanZamowienia { get; set; }
        public decimal WartoscZamowienia { get; set; }
        List<PozycjaZamowienia> PozycjeZamowienia { get; set; }
    }


    public enum StanZamowienia
    {
        Nowe,Zrealizowane, WTrakcie
    }
}
