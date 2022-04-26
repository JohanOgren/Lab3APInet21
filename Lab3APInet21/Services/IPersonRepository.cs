using Lab3APInet21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21.Services
{
    public interface IPersonRepository
    {
        ICollection<Person> GetAllPersons(); // Hämta alla personer
        //Person GetSinglePerson(int id); // Singel person Test
        ICollection<Hobby> GetPersonHobbys(int id); // Hämta alla hobbys ifrån en person

        ICollection<WebbLink> GetPersonLinks(int id); // Hämta alla länkar från en person

        Hobby AddPersonHobby(Hobby hobby);

        WebbLink AddNewLinksToHobbyAndPerson(WebbLink newHobbyLink);
    }
}
