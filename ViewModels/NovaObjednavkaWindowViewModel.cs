using ReactiveUI.Fody.Helpers;
using System.Collections.ObjectModel;
using System.Linq;
using Test.Models;
using Test.Services;

namespace Test.ViewModels
{
    class NovaObjednavkaWindowViewModel : ViewModelBase
    {

        [Reactive]
        public Pizza SelectedPizza { get; set; }
        public ObservableCollection<Pizza> Menu { get; private set; }

        public NovaObjednavkaWindowViewModel()
        {
            Menu = PizzaMenu.GetItems();
            SelectedPizza = Menu.First();
        }

        public void Odeslat()
        {
         /* using (DatabaseContext context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add(new Objednavka(SelectedPizza));
                context.SaveChanges();
            }*/
            Json.add(new Objednavka(SelectedPizza));
            SelectedPizza.setUncheckedPridavek();
        }

    }
}
