using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;
using UlamRandomizerDataLogic;
using HtmlAgilityPack;
namespace UlamRandomizerBusinessLogic
{

    public class SpoonacularBL
    {
        

        private const string key = "b5777eef6858421490e664fadf85286e";

        public static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://api.spoonacular.com/"),
        };

        public class SpoonacularSearchResponse
        {
            public List<Ulam> results { get; set; }
            public Ulam ulamResult { get; set; }
        }
        public class RandomRecipeResponse
        {
            public List<Ulam> recipes { get; set; }
        }
        public static async Task<Ulam> GetUlamInfo(HttpClient httpClient, int id)
        {
            var response = await httpClient.GetFromJsonAsync<Ulam>($"recipes/{id}/information?apiKey={key}");

            if (response == null)
            {
                throw new InvalidOperationException($"No Ulam found with ID: {id}");
            }
            return response;
        }
        
        public static async Task<List<Ulam>> GetSearchResult(HttpClient httpClient, string query)
        {
            var response = await httpClient.GetFromJsonAsync<SpoonacularSearchResponse>(
                $"recipes/complexSearch?query={query}&number=20&apiKey={key}");

            if (response != null && response.results != null)
            {
                return response.results;
            }
            else
            {
                throw new InvalidOperationException($"No results found for query: {query}");
            }
        }
        public static async Task<Ulam> GenerateRandomUlam(HttpClient httpClient)
        {
            var response = await httpClient.GetFromJsonAsync<RandomRecipeResponse>($"recipes/random?number=1&apiKey={key}");
            if (response == null)
            {
                throw new InvalidOperationException("Failed to generate a random Ulam.");

            }
            else
            {
                return response.recipes.First();

            }
        }
    }
}
