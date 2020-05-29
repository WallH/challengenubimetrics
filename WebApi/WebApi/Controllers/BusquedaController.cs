using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {        
        // GET: api/Busqueda
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/Busqueda/5
        [HttpGet("{buscado}", Name = "GetBusqueda")]
        public async Task<string> GetAsync(string buscado)
        {

            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.mercadolibre.com/sites/MLA/search?q=" + buscado);
            
            Buscado retPiv = JsonConvert.DeserializeObject<Buscado>(json);
            var ret = JsonConvert.SerializeObject(retPiv);

            HttpContext.Response.StatusCode = 200;
            HttpContext.Response.ContentType = "application/json";
            return ret;
        }

    }
}
