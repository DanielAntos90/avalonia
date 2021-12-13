using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Models
{
    public class PridavekMenu
    {
        public static ObservableCollection<Pridavek> GetItems()
        {
            return new ObservableCollection<Pridavek>
            {
                 new Pridavek("Kukuřice"),
                 new Pridavek("Hrášek"),
                 new Pridavek("Ananas"),
                 new Pridavek("Ančovičky"),
                 new Pridavek("Olivy"),
                 new Pridavek("Oregano"),
                 new Pridavek("Beraní rohy"),
                 new Pridavek("Feferonky")
            };
        }
    }
}
