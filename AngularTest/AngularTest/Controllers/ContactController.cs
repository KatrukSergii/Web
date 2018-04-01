using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;

namespace AngularTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Contact")]
    public class ContactController : Controller
    {
        private readonly IRepositoryProvider repository = RepositoryProvider.RepositoryProvider.GetRepository();
        // GET: api/Contract
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return this.repository.ContactRepository.Get(0, 10);
        }

        // GET: api/Contract/5
        [HttpGet("{id}", Name = "Get")]
        public Contact Get(string id)
        {
            return this.repository.ContactRepository.GetById(id);
        }
        
        // POST: api/Contract
        [HttpPost]
        public void Post([FromBody]Contact value)
        {
            this.repository.ContactRepository.Add(value);
        }
        
        // PUT: api/Contract/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Contact value)
        {
            this.repository.ContactRepository.Save(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.repository.ContactRepository.Remove(id);
        }
    }
}
