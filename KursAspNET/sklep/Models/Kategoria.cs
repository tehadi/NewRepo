using System.Collections
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sklep.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        [StringLength(100)]
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }
        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}