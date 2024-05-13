using Contactly.Data;
using Contactly.Model;
using Contactly.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contactly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactlyDBContext dbContext;

        public ContactsController(ContactlyDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        

    [HttpGet]
    public IActionResult GetAllContacts()
    {
        var contacts = dbContext.Contacts.ToList();
        return Ok(contacts);
    }

    [HttpPost]

    public IActionResult AddContact(AddContactRequestDTO request)
    {
            var domainModelContact = new Contact
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                IsFavorite = request.IsFavorite
            };
        dbContext.Contacts.Add(domainModelContact);
        dbContext.SaveChanges();
        return Ok(domainModelContact);

    }





        

    }
}
