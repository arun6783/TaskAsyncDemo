using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using TaskAsync.Shared;

namespace TaskAsync.Service.Controllers
{
    public class PersonController : ApiController
    {
        private readonly List<Person> _persons = new List<Person>
        {
            new Person {Id = 1, Name = "John", RatingScore = 89},
            new Person {Id = 2, Name = "Jonathan", RatingScore = 65},
            new Person {Id = 3, Name = "Derik", RatingScore = 80},
            new Person {Id = 4, Name = "Ian", RatingScore = 50},
            new Person {Id = 5, Name = "Mark", RatingScore = 70}
        };

        public IEnumerable<Person> Get()
        {
            return _persons;
        }


        public IHttpActionResult Get(int id)
        {
            var person = Get().FirstOrDefault(x => x.Id == id);
            if (person == null) return NotFound();
            return Ok(person);
        }
    }
}