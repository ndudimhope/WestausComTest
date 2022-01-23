using Newtonsoft.Json;
using ShopifySharp;
using ShopifySharp.Lists;

namespace Westaus.Service
{
    public class ImportProducts
    {
        public async Task GetAllProducts(string shopUrl, string shopToken)
        {
            ProductService service = new ProductService(shopUrl, shopToken);
            var products = await service.ListAsync();
            dynamic result = JsonConvert.SerializeObject(products);

            //Writing Json Result to File
            File.WriteAllText(@"C:\Users\ndudi\Documents\ShopifyProducts\products.json", result);
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            

        }


        



    }
}