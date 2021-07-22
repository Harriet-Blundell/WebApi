using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class GreetingController : ControllerBase
    {
        [HttpGet("greeting")]
        public string GetString()
        {
            return "I hope this greeting message is being read!";
        }

        [HttpGet("all")]
        public async Task<List<Elephant>> GetElephantList()
        {
            var elephantFilePath = await System.IO.File.ReadAllTextAsync(@"elephants.json");
            var elephantData = JsonSerializer.Deserialize<List<Elephant>>(elephantFilePath);
            return elephantData;
        }

        [HttpGet("{id}")]
        public async Task<Elephant> GetElephantById(Guid id)
        {
            var elephantList = await GetElephantList();
            return elephantList.Find(elephant => elephant.id == id);
        }
    }
}
