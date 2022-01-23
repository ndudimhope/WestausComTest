using Westaus.Service;

namespace Westaus
{
    class Program
    {
        static void Main(string[] args)
        {
            ImportProducts importProducts = new ImportProducts();

            JsonConverter converter = new JsonConverter();
            importProducts.GetAllProducts("ndudimuzordinma.myshopify.com/admin/api/2022-01/products.json", "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").GetAwaiter().GetResult();

            converter.CreateExcel();
        }
    }
}