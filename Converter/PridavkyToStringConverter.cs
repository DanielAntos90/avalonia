using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using Avalonia.Data.Converters;
using Test.Models;

namespace Test
{
    class PridavkyToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<Pridavek> Pridavky = (ObservableCollection<Pridavek>)value;

            List<string> sb = new List<string>();
            foreach (var pr in Pridavky)
            {
                if (pr.IsChecked)
                {
                    sb.Add(pr.Name);
                }
            }

            if (sb.Count >= 1)
            {
                return "\nPřídavky:\n" + String.Join("\n", sb.ToArray());
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}