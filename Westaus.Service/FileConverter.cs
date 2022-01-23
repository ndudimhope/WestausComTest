using Aspose.Cells;
using Aspose.Cells.Utility;
using IronXL;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westaus.Service
{
    public class FileConverter
    {
        public void JsonToExcel() 
        {
            // Create a Workbook object
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];

            // Read JSON File
            string jsonInput = File.ReadAllText(@"C:\Users\ndudi\Documents\ShopifyProducts\products.json");

            // Set JsonLayoutOptions
            JsonLayoutOptions options = new JsonLayoutOptions();
            options.ArrayAsTable = true;

            // Import JSON Data
            JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);

            //Path to save workbook to
            string filePath = @"C:\Users\ndudi\Documents\ShopifyProducts\";

            // Save Excel file
            workbook.Save(filePath + "products.xlsx");
        }

        public void ExcelToJson() 
        {

            //Path to load workbook from
            string filePath = @"C:\Users\ndudi\Documents\ShopifyProducts\";
            WorkBook workbook = WorkBook.Load(filePath + "products.xlsx");
            workbook.SaveAsJson(filePath + "productexport.json");
        }
    }
}
