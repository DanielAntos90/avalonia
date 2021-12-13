using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

namespace Test.Models
{
    public class Pridavek
    {
        //public int PridavekId { get; set; }
        public string Name { get; set; }
        [Reactive]
        public bool IsChecked { get; set; }

        public Pridavek(string name)
        {
            Name = name;
        }

    }
}
