using System.Collections.Generic;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Rce.Domain;
using Rce.Domain.Abstractions;
using Rce.Domain.Models;

namespace Rce.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class RceController : Controller
    {
        private IReadRepository<EquipmentItem, int> _db;

        public RceController(IReadRepository<EquipmentItem, int> db)
        {
            _db = db;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value: " + id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
