using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sklep.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kursu")]
        [StringLength(100)]
        public string TytulKursu { get; set; }
        [Required(ErrorMessage = "Wprowadz auor")]
        [StringLength(100)]
        public string AutorKursu { get; set; }

        
        public DateTime DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool BestSeller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; }
        

        public virtual Kategoria Kategoria { get; set; }
    }
}
    