using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models.Rent;
using Repository;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/PublicationRequest")]
    public class PublicationRequestController : Controller
    {
        private readonly IRepositoryProvider repository = RepositoryProvider.RepositoryProvider.GetRepository();
        // GET: api/PublicationRequest
        [HttpGet]
        public IEnumerable<PublicationRequest> Get()
        {
            return this.repository.PublicationRequestRepository.Get(0, 100);
        }

        // GET: api/PublicationRequest/5
        [HttpGet("{id}", Name = "Get")]
        public PublicationRequest Get(int id)
        {
            return this.repository.PublicationRequestRepository.GetById(id);
        }
        
        // POST: api/PublicationRequest
        [HttpPost]
        public void Post([FromBody]PublicationRequest value)
        {
            this.repository.PublicationRequestRepository.Add(value);
        }
        
        // PUT: api/PublicationRequest/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]PublicationRequest value)
        {
            this.repository.PublicationRequestRepository.Save(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.PublicationRequestRepository.Remove(id);
        }
    }
}
