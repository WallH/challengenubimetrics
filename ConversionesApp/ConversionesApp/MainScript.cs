using ConversionesApp.Collections;
using ConversionesApp.Models;
using ConversionesApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConversionesApp
{
    class MainScript
    {

        private static CurrencyRepository currencyRepository = new CurrencyRepository();
        static async Task Main(string[] args)
        {

            int i = 0;
            string path = Environment.CurrentDirectory + @"\guardado";
            if(!Directory.Exists(path)) Directory.CreateDirectory(path);
            currencyRepository = new CurrencyRepository();
            //currencyRepository.cargarAsync();

            currencyRepository.Currencies = await currencyRepository.currencyService.getCurrenciesAsync();

            foreach (Currency cur in currencyRepository.Currencies)
            {
                cur.Todolar = (await currencyRepository.currencyService.ToDolarRatio("ARS")).Ratio;
                if (i++ == 1) File.WriteAllText(path+@"\save.csv", cur.Todolar.ToString());
                else File.AppendAllText(path+@"\save.csv", ","+ cur.Todolar.ToString());
            }
            currencyRepository.guardar();

        }
    }
}
