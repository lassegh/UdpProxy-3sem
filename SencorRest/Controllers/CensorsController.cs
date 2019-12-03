using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

namespace SencorRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CensorsController : ControllerBase
    {
        private static List<CensorData> censorsList = new List<CensorData>();

        private int nextId = 0;

        // GET: api/Censors
        [HttpGet]
        public IEnumerable<CensorData> Get()
        {
            return censorsList;
        }

        // GET: api/Censors/5
        [HttpGet("{id}")]
        public CensorData Get(int id)
        {
            return censorsList.FirstOrDefault(c => c.Id == id);
        }

        // POST: api/Censors
        [HttpPost]
        public void Post([FromBody] CensorData value)
        {
            value.Id = nextId;
            censorsList.Add(value);
            nextId++;
        }
    }
}
