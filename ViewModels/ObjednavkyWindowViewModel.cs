using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Test.Services;
using Test.Models;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Test.ViewModels
{
    class ObjednavkyWindowViewModel : ViewModelBase
    {
        [Reactive]
        public Objednavka SelectedObjednavka { get; set; }
        [Reactive]
        public ObservableCollection<Objednavka> Objednavky { get; private set; }
        public ObjednavkyWindowViewModel()
        {
            /*   using (ObjednavkaContext context = new ObjednavkaContext())
               {
                   //Items = new ObservableCollection<Objednavka>(context.DbObjednavka.OrderBy(x => x.Text));

                   foreach (Objednavka objednavka in context.DbObjednavka)
                   {
                       Console.WriteLine(objednavka.ToString());
                       Debug.WriteLine(objednavka.ToString());
                   }

                   Objednavky = new ObservableCollection<Objednavka>(context.DbObjednavka);
               }*/

            Objednavky = Json.getObjednavky();
            try
            {
                SelectedObjednavka = Objednavky.First();
            } 
            catch (Exception e) 
            { 
                //vyjímka když neexistuje json soubor
            }
            
        }

        public void Uloz()
        {
            Json.saveChanges(Objednavky);
        }

    }
}
