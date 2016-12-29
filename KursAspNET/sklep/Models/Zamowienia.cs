using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep.Models
{
    public class Zamowienie
    {
        public int ZamowienieID { get; set; }
        [Required(ErrorMessage = "Wprowadz imie")]
        [StringLength(50)]
        public string imie { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowadz ulice")]
        [StringLength(100)]
        public string ulica { get; set; }
        [Required(ErrorMessage = "Wprowadz Miasto")]
        [StringLength(100)]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(6)]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage = "Wprowadz telefon")]
        [StringLength(100)]
        public string telefon { get; set; }
        [Required(ErrorMessage = "Wprowadz mail")]
        [StringLength(100)]
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
