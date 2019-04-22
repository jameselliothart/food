using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "James' Spot", Location = "Houston", Cuisine = CuisineType.Mexican },
                new Restaurant {Id = 2, Name = "Trevor's Place", Location = "Austin", Cuisine = CuisineType.Indian },
                new Restaurant {Id = 3, Name = "Isaiah's Lounge", Location = "San Antonio", Cuisine = CuisineType.Italian},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
