﻿using cacheMe512.Drinks.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Reflection;
using System.Web;

namespace cacheMe512.Drinks;

internal class DrinksService
{
    public List<Category> GetCategories()
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1/");
        var request = new RestRequest("list.php?c=list");
        var response = client.ExecuteAsync(request);

        List<Category> categories = new();

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

            categories = serialize.CategoriesList;
            TableVisualizationEngine.ShowTable(categories, "Categories Menu");
            return categories;
        }

        return categories;
    }

    internal List<Drink> GetDrinksByCategory(string category)
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1/");
        var request = new RestRequest($"filter.php?c={HttpUtility.UrlEncode(category)}");

        var response = client.ExecuteAsync(request);

        List<Drink> drinks = new();

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<cacheMe512.Drinks.Models.Drinks>(rawResponse);
            drinks = serialize.DrinksList;

            TableVisualizationEngine.ShowTable(drinks, "Drinks Menu");

            return drinks;
        }

        return drinks;
    }

    internal void GetDrink(string drink)
    {
        var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1/");
        var request = new RestRequest($"lookup.php?i={drink}");
        var response = client.ExecuteAsync(request);

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<DrinkDetailObject>(rawResponse);
            List<DrinkDetail> returnedList = serialize.DrinkDetailList;
            DrinkDetail drinkDetail = returnedList[0];
            List<object> prepList = new();

            foreach (PropertyInfo prop in drinkDetail.GetType().GetProperties())
            {
                if (!string.IsNullOrEmpty(prop.GetValue(drinkDetail)?.ToString()))
                {
                    prepList.Add(new
                    {
                        Key = prop.Name,
                        Value = prop.GetValue(drinkDetail)
                    });
                }
            }

            TableVisualizationEngine.ShowTable(prepList, drinkDetail.DrinkName);
        }
    }
}
