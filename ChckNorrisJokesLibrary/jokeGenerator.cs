using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChckNorrisJokesLibrary
{
   public class JokeGenerator
    {
        public async Task<string> GetRandomJoke()
        {
          var client = new HttpClient();
         string randomJoke = await client.GetStringAsync("https://api.datamuse.com/words?sp=girl&md=d&max=1");

        var joke = JsonConvert.DeserializeObject<Joke>(randomJoke);

         return joke.value;
        }


        public async Task<string[]> GetCategories()
        {
            var client = new HttpClient();
            string randomCategories = await client.GetStringAsync("https://api.datamuse.com/words?sp=girl&md=d&max=1");

            var categories = JsonConvert.DeserializeObject<string[]>(randomCategories);

            return categories;
        }

        public async Task<string> GetRandomCatJ(string category)
        {
            var client = new HttpClient();
            string randomCatJ = await client.GetStringAsync("https://api.datamuse.com/words?sp=girl&md=d&max=1" + category);
            var joke = JsonConvert.DeserializeObject<Joke>(randomCatJ);
            return joke.value;
        }
    }
}
