using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("/Paises")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        // GET: api/Pais
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pais/5
        [HttpGet("{pais}", Name = "GetPaises")]
        public async Task<String> GetAsync(string pais)
        {

            if (pais.Equals("BR", StringComparison.InvariantCultureIgnoreCase) == true || pais.Equals("CO", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                HttpContext.Response.StatusCode = 401;
                return null;
            }
            HttpClient httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://api.mercadolibre.com/classified_locations/countries/" + pais);
            HttpContext.Response.StatusCode = 200;
            return json;
        }
    }
}
