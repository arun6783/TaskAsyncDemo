using NUnit.Framework;

namespace TaskAsync.Repository.Tests
{
    [TestFixture]
    public class PersonRepositoryTests
    {
        [Test]
        public void ShouldGetListOfPersons()
        {
            var personRepository = new PersonRepository();
         var  persons = personRepository.GetPersons();
         Assert.That(persons.Result, Is.Null);
        }
    }
}
