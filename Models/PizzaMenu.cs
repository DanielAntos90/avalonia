using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class PizzaMenu
    {
        public static ObservableCollection<Pizza> GetItems()
        {
            return new ObservableCollection<Pizza>
            {
                 new Pizza("Salámová" ),
                 new Pizza("Sýrová" ),
                 new Pizza("Tvarůžková" ),
                 new Pizza("Žampiónová" ),
                 new Pizza("Hawai" ),
                 new Pizza("Margarita" ),
                 new Pizza("Šunková" )
            };
        }
    }
}
