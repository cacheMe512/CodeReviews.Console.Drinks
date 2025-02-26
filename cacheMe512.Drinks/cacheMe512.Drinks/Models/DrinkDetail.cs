using Newtonsoft.Json;

namespace cacheMe512.Drinks.Models
{
    internal class DrinkDetailObject
    {
        [JsonProperty("drinks")]
        public List<DrinkDetail> DrinkDetailList { get; set; }
    }
    internal class DrinkDetail
    {
        [JsonProperty("strDrink")]
        public string DrinkName { get; set; }

        [JsonProperty("strDrinkAlternate")]
        public object DrinkAlternate { get; set; }

        [JsonProperty("strTags")]
        public object Tags { get; set; }

        [JsonProperty("strVideo")]
        public object Video { get; set; }

        [JsonProperty("strCategory")]
        public string Category { get; set; }

        [JsonProperty("strIBA")]
        public object Iba { get; set; }

        [JsonProperty("strAlcoholic")]
        public string Alcoholic { get; set; }

        [JsonProperty("strGlass")]
        public string Glass { get; set; }

        [JsonProperty("strInstructions")]
        public string Instructions { get; set; }

        [JsonProperty("strInstructionsES")]
        public object InstructionsEs { get; set; }

        [JsonProperty("strInstructionsDE")]
        public string InstructionsDe { get; set; }

        [JsonProperty("strInstructionsFR")]
        public object InstructionsFr { get; set; }

        [JsonProperty("strInstructionsIT")]
        public string InstructionsIt { get; set; }

        [JsonProperty("strInstructionsZH-HANS")]
        public object InstructionsZhhans { get; set; }

        [JsonProperty("strInstructionsZH-HANT")]
        public object InstructionsZhhant { get; set; }

        [JsonProperty("strDrinkThumb")]
        public string DrinkThumb { get; set; }

        [JsonProperty("strIngredient1")]
        public string Ingredient1 { get; set; }

        [JsonProperty("strIngredient2")]
        public string Ingredient2 { get; set; }

        [JsonProperty("strIngredient3")]
        public string Ingredient3 { get; set; }

        [JsonProperty("strIngredient4")]
        public string Ingredient4 { get; set; }

        [JsonProperty("strIngredient5")]
        public object Ingredient5 { get; set; }

        [JsonProperty("strMeasure1")]
        public string Measure1 { get; set; }

        [JsonProperty("strMeasure2")]
        public string Measure2 { get; set; }

        [JsonProperty("strMeasure3")]
        public string Measure3 { get; set; }

        [JsonProperty("strMeasure4")]
        public string Measure4 { get; set; }

        [JsonProperty("strImageSource")]
        public object ImageSource { get; set; }

        [JsonProperty("strImageAttribution")]
        public object ImageAttribution { get; set; }

        [JsonProperty("strCreativeCommonsConfirmed")]
        public string CreativeCommonsConfirmed { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }
    }
}