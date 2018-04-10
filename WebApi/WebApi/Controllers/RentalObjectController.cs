using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models.Rent;
using Repository;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/RentalObject")]
    public class RentalObjectController : Controller
    {
        private readonly IRepositoryProvider repository = RepositoryProvider.RepositoryProvider.GetRepository();
        // GET: api/RentalObject
        [HttpGet]
        public IEnumerable<RentalObject> Get()
        {
            return this.repository.RentalObjectRepositroy.Get(0, 100);
        }

        // GET: api/RentalObject/5
        [HttpGet("{id}")]
        public RentalObject Get(int id)
        {
            return this.repository.RentalObjectRepositroy.GetById(id);
        }
        
        // POST: api/RentalObject
        [HttpPost]
        public void Post([FromBody]RentalObject value)
        {
            this.repository.RentalObjectRepositroy.Add(value);
        }
        
        // PUT: api/RentalObject/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]RentalObject value)
        {
            this.repository.RentalObjectRepositroy.Save(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.RentalObjectRepositroy.Remove(id);
        }
    }
}
