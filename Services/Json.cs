using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Test.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Collections.ObjectModel;

namespace Test.Services
{
    class Json
    {
        private static string fileName = "objednavky.json";

        static ObservableCollection<Objednavka> Objednavky { get; set; }

        private static JsonSerializerOptions setOptions()
        {
            return new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
        }

        public static void add(Objednavka objednavka)
        {
            Objednavky = getObjednavky();
            

            Objednavky.Add(objednavka);
            saveChanges(Objednavky);

        }
        public static void saveChanges(ObservableCollection<Objednavka> objednavky)
        {
            string json = JsonSerializer.Serialize(objednavky, setOptions());
            System.IO.File.WriteAllText(fileName, json);

        }

        public static ObservableCollection<Objednavka> getObjednavky()
        {
            string json = System.IO.File.ReadAllText(fileName);
            Debug.WriteLine(json);

            try
            {
                Objednavky = JsonSerializer.Deserialize<ObservableCollection<Objednavka>>(json, setOptions());
            } catch (System.Text.Json.JsonException e)
            {
                Objednavky = new ObservableCollection<Objednavka>();
            }
            
            return Objednavky;

        }

    }
}
