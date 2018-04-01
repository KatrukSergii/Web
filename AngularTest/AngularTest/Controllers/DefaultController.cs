using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AngularTest.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DefaultController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Didn't", "believe", "it", "right??" };
        }
    }
}
