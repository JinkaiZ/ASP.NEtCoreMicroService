using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IdentityServerCenter.Controllers 
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ValuesController : ControllerBase 
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
