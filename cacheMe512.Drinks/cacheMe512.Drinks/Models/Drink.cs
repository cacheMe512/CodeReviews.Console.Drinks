using Newtonsoft.Json;

namespace cacheMe512.Drinks.Models
{
    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList { get; set; }
    }

    public class Drink
    {
        [JsonProperty("idDrink")]
        public string DrinkId { get; set; }

        [JsonProperty("strDrink")]
        public string DrinkName { get; set; }
    }

}