using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace Test.Models
{
    public class Objednavka
    {
        //public int ObjednavkaId { get; set; }

        [Reactive]
        public bool IsFavourite {get;set;}

        public Pizza OrderedPizza { get; }

        public DateTime Datum { get; set; }

        public Objednavka(Pizza orderedPizza)
        {
            OrderedPizza = orderedPizza;
            Datum = DateTime.Now;
        }
    }
}
