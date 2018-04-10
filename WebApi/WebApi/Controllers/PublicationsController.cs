using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models.Rent;
using Repository;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Publications")]
    public class PublicationsController : Controller
    {
        private readonly IRepositoryProvider repository = RepositoryProvider.RepositoryProvider.GetRepository();
        // GET: api/Publications
        [HttpGet]
        public IEnumerable<Publication> Get()
        {
            return this.repository.PublicationRepository.Get(0, 100);
        }

        // GET: api/Publications/5
        [HttpGet("{id}")]
        public Publication Get(int id)
        {
            return this.repository.PublicationRepository.GetById(id);
        }
        
        // POST: api/Publications
        [HttpPost]
        public void Post([FromBody]Publication value)
        {
            this.repository.PublicationRepository.Add(value);
        }
        
        // PUT: api/Publications/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Publication value)
        {
            this.repository.PublicationRepository.Save(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.PublicationRepository.Remove(id);
        }
    }
}
