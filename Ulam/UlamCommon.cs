using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UlamRandomizerBusinessLogic;

namespace UlamCommon;

public class Ulam
{
    [JsonPropertyName("title")]
    public string UlamName { get; set; }

    //[JsonPropertyName("mainIngredient1")]
    public string MainIngredient1 { get; set; }
    public string MainIngredient2 { get; set; }
    [JsonPropertyName("summary")]
    public string ulamDescription { get; set; }
    //public string Recipe { get; set; }
    [JsonPropertyName("image")]
    public string ImgString { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    public string Type { get; set; }
    [JsonPropertyName("extendedIngredients")]
    public List<Ingredient> ingredients { get; set; }
    public Ulam()
    {
    }
    public Ulam(string UlamName, string MainIngredient1, string MainIngredient2, string ulamDescription)
    {
        this.UlamName = UlamName;
        this.MainIngredient1 = MainIngredient1;
        this.MainIngredient2 = MainIngredient2;
        this.ulamDescription = ulamDescription;
    }

}
