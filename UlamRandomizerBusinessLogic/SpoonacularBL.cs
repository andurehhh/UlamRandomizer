using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UlamCommon;
using UlamRandomizerDataLogic;
using HtmlAgilityPack;
using Azure;
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

            IdentifyMainIngredients(response);

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
            var response = await httpClient.GetFromJsonAsync<RandomRecipeResponse>($"recipes/random?number=1&include-tags=lunch,dinner&exclude-tags=dessert&apiKey={key}");

            IdentifyMainIngredients(response.recipes.First());
            if (response == null)
            {
                throw new InvalidOperationException("Failed to generate a random Ulam.");

            }
            else
            {
                return response.recipes.First();

            }
        }
        public static  void IdentifyMainIngredients(Ulam ulam)
        {
            if (ulam.ingredients != null)
            {

                foreach (var ing in ulam.ingredients)
                {
                    if (ing.Aisle != null)
                    {
                        if (ing.Aisle.Equals("Meat") || ing.Aisle.Equals("Seafood"))
                        {
                            if (ulam.MainIngredient1 == null)
                            {
                                ulam.MainIngredient1 = ing.Name;
                            }
                            else if (ulam.MainIngredient2 == null)
                            {
                                ulam.MainIngredient2 = ing.Name;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
                foreach (var ing in ulam.ingredients)
                {
                    if ((ulam.MainIngredient1 == null || ulam.MainIngredient2 == null) && (ing.Aisle.Equals("Produce")))
                    {
                        if (ulam.MainIngredient1 == null)
                        {
                            ulam.MainIngredient1 = ing.Name;
                        }
                        else if (ulam.MainIngredient2 == null)
                        {
                            ulam.MainIngredient2 = ing.Name;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
