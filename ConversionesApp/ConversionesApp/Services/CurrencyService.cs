using ConversionesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesApp.Services
{
    public class CurrencyService
    {
        public HttpClient _httpClient;
        public CurrencyService()
        {
            
        }
        public async Task<List<Currency>> getCurrenciesAsync()
        {
            _httpClient = new HttpClient();
            var json = await _httpClient.GetStringAsync("https://api.mercadolibre.com/currencies/");
            List<Currency> retPiv = JsonConvert.DeserializeObject<List<Currency>>(json);
            return retPiv;
        }

        public async Task<ToDolar> ToDolarRatio(string parameter)
        {
            _httpClient = new HttpClient();
            var json = await _httpClient.GetStringAsync("https://api.mercadolibre.com/currency_conversions/search?from="+ parameter+ "&to=USD");
            ToDolar uniqueValue = JsonConvert.DeserializeObject<ToDolar>(json);
            return uniqueValue;
        }







    }
}
