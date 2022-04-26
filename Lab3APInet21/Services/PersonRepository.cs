using Lab3APInet21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab3APInet21.Services
{

    public class PersonRepository : IPersonRepository
    {
        private readonly DataRegisterDb _context;

        public PersonRepository(DataRegisterDb context)
        {
            _context = context;
        }



        public WebbLink AddNewLinksToHobbyAndPerson(WebbLink newHobbyLink)
        {
            var result = _context.WebbLinks.Add(newHobbyLink);
            _context.SaveChanges();
            return result.Entity;
        }

        public Hobby AddPersonHobby(Hobby newHobby) // Klar
        {
            var result = _context.Hobbies.Add(newHobby);
            _context.SaveChanges();
            return result.Entity;
        }

        public ICollection<Person> GetAllPersons() // Klar
        {
            return _context.Persons.OrderBy(p => p.PersonId).ToList();
        }

        public ICollection<Hobby> GetPersonHobbys(int id)   // Klar
        {
            return _context.Persons.Where(p => p.PersonId == id).Select(h => h.Hobbies).FirstOrDefault();
        }

        public ICollection<WebbLink> GetPersonLinks(int id)  // Klar
        {
            var webbperson = (from p in _context.Persons
                              join h in _context.Hobbies
                              on p.PersonId equals h.PersonId

                              join w in _context.WebbLinks
                              on h.HobbyId equals w.HobbyId

                              where p.PersonId == id
                              select w).ToList();

            return webbperson;
        }
    }
}
