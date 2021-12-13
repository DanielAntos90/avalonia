using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Pizza
    {
        //public int PizzaId { get; set; }
        public string Name { get; }

        // [NotMapped]
        [Reactive]
        public ObservableCollection<Pridavek> Pridavky { get; set; }

        public Pizza(string name)
        {
            Name = name;
            Pridavky = PridavekMenu.GetItems();
        }

        internal void setUncheckedPridavek()
        {
            foreach (var pr in Pridavky)
            {
                pr.IsChecked = false;
            }
        }
    }
}
