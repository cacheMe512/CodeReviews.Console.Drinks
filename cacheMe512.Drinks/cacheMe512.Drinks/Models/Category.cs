﻿using Newtonsoft.Json;

namespace cacheMe512.Drinks.Models
{
    public class Category
    {
        public string StrCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("drinks")]
        public List<Category> CategoriesList { get; set; }
    }
}