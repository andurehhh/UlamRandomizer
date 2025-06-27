using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UlamRandomizerBusinessLogic
{
    class Ingredient
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("amount")]
        public double Amount { get; set; }
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
        [JsonPropertyName("aisle")]
        public string Aisle { get; set; }
    }
    class Recipe
    {
        [JsonPropertyName("title")]
        public string RecipeName { get; set; }
        [JsonPropertyName("extendedIngredients")]
        public List<Ingredient> Ingredients { get; set; }


    }

}
