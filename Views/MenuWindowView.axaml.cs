using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Test.Views
{
    public partial class MenuWindowView : UserControl
    {
        public MenuWindowView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
