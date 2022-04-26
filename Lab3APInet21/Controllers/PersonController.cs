using Lab3APInet21.Models;
using Lab3APInet21.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private IPersonRepository _personRepo;

        public PersonController(IPersonRepository URepo)
        {
            _personRepo = URepo;
        }

        [HttpGet] // Hämta alla Personer.
        public IActionResult GetPerson()
        {
            return Ok(_personRepo.GetAllPersons());
        }

        [HttpGet("{id}/hobbies")]  //Hämta alla hobbys för 1 person
        public IActionResult GetPersonHobbys(int id)
        {
            return Ok(_personRepo.GetPersonHobbys(id));
        }

        [HttpGet("{id}/links")] // Hämta alla länkar till specifika hobbys för 1 person
        public IActionResult GetPersonLinks(int id)
        {
            return Ok(_personRepo.GetPersonLinks(id));
        }

        [HttpPost("{id}/createhobby")]/// skapa en ny hobby till en ny person

        public IActionResult PostNewHobby(Hobby hobby) 
        {
            try
            {
                if (hobby == null)
                {
                    return BadRequest();
                }

                var createHobby = _personRepo.AddPersonHobby(hobby);
                return CreatedAtAction(nameof(GetPersonHobbys),
                    new { id = createHobby.HobbyId },
                    createHobby);

            }
            catch (Exception)
            {
               return StatusCode(StatusCodes.Status500InternalServerError, "Error Can not create that Hobby to Database.....");
                throw;
            }
        }

        [HttpPost("{id}/createlink")] // Skapa ny link till ny hobby för en specifik person
        public IActionResult PostNewLinks(WebbLink webbLink)
        {
            try
            {
                if (webbLink == null)
                {
                    return BadRequest();
                }
                var createLink = _personRepo.AddNewLinksToHobbyAndPerson(webbLink);
                return CreatedAtAction(nameof(GetPersonLinks),
                    new { id = createLink.WebbLinkId },
                    createLink);



            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Can not create that link to Database.....");

                throw;
            }
        }
    }
}
