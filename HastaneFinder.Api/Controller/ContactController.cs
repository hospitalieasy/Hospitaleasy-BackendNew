using HastaneFinder.Business.Abstract;
using HastaneFinder.Business.Concrete;
using HastaneFinder.Entitiy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService contactService;

        public ContactController()
        {
            contactService = new ContactManager();
        }


        [HttpGet]
        public List<Contact> Get()
        {
            return contactService.GetAllContact();
        }

        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return contactService.GetContactById(id);
        }
        [HttpPost]

        public Contact Post([FromBody] Contact cont)
        {
            return contactService.AddContact(cont);
        }
    }
}
