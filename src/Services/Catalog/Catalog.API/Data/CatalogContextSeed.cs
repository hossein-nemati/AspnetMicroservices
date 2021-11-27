using System;
using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfigurationProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfigurationProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "id1",
                    Name = "IPhone",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "ImageFile",
                    Price = 2323.0M,
                    Categoy = "Categoy"
                },
                new Product()
                {
                    Id = "id2",
                    Name = "Samsung",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "ImageFile",
                    Price = 3456.0M,
                    Categoy = "Categoy"
                }
            };
        }
    }
}
