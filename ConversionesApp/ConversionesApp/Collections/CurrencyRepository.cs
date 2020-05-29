using ConversionesApp.Models;
using ConversionesApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConversionesApp.Collections
{

    public class CurrencyRepository
    {
        public CurrencyService currencyService = new CurrencyService();
        private List<Currency> currencies = new List<Currency>();

        public List<Currency> Currencies { get => currencies; set => currencies = value; }

        public CurrencyRepository()
        {
            currencyService = new CurrencyService();
        }
        public async void cargarAsync()
        {
           
            Currencies = await currencyService.getCurrenciesAsync();

            
        }
        public void guardar()
        {
            string path = Environment.CurrentDirectory;
            File.WriteAllText(path+@"\guardado\save.json", JsonConvert.SerializeObject(currencies));
        }
    }
}
