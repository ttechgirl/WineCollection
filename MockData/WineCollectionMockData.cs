using System.Collections.Generic;
using WebApiClassText.Models;

namespace WebApiClassText.MockData
{
    public class WineCollectionMockData
    {
        public static IEnumerable<Models.WineCollections> WineCollections()
        {
            var winecollections = new List<WineCollections>();
            {
                
                new WineCollections
                {
                    Id = 1,
                    Name = "Hennessy",
                    ProductionYear = 1999,
                    Type = "Alcoholic",
                    Price = 15000,
                    Category = "White Wine",
                };
                new WineCollections
                {
                    Id = 2,
                    Name = "Magic Moment",
                    ProductionYear = 2019,
                    Type = "Alcoholic",
                    Price = 4200,
                    Category = "White Wine"
                };
                new WineCollections
                {
                    Id = 3,
                    Name = "Eva",
                    ProductionYear = 2000,
                    Type = "Non Alcoholic",
                    Price=850,
                    Category="Fruit wine",
                };
                new WineCollections
                {
                    Id=4,
                    Name ="Merlot",
                    ProductionYear =2015,
                    Type ="Non Alcoholic",
                    Price=14200.24,
                    Category="Red Wine"

                };












            };
            return winecollections;
        }
    }
}
