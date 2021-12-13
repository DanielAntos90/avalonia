using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Test.Views
{
    public partial class ObjednavkyWindowView : UserControl
    {
        public ObjednavkyWindowView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
