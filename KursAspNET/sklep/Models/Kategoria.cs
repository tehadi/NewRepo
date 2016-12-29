﻿using System.Collections
using System.Collections.Generic;

namespace sklep.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }
        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}