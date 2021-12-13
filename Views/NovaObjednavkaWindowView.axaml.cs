using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Test.Models;
using Test.Services;
using System.Collections.ObjectModel;
using System;

namespace Test.Views
{
    public partial class NovaObjednavkaWindowView : UserControl
    {
        public NovaObjednavkaWindowView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

        }
    }
}
