using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TaskAsync.Shared;

namespace TaskAsync.Repository
{
    public class PersonRepository
    {
        public async Task<List<Person>> GetPersons()
        {
            return await GetPersonsFromService();
          //  return new List<Person>();
        }

     

        private static async Task<List<Person>> GetPersonsFromService()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(new Uri("http://localhost:8080/api/person"));
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsAsync<List<Person>>();
                }
                return new List<Person>();
            }
        }
    }
}
