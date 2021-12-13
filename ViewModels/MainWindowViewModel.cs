using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Test.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        ViewModelBase content;

        public MainWindowViewModel()
        {
            Content = new MenuWindowViewModel();
        }

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void NovaObjednavka()
        {
            Content = new NovaObjednavkaWindowViewModel();
        }

        public void TvojeObjednavky()
        {
            Content = new ObjednavkyWindowViewModel();
        }

        public void Zpet()
        {
            Content = new MenuWindowViewModel();
        }

    }
}
