using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listAllOperatingSystemsFromTheFile = new List<string>();

            string jsonOS = File.ReadAllText(@"C:\Users\MarijaNet\source\repos\JsonFile\jsonFIle.json");
            Console.WriteLine(jsonOS);

            //JsonDocument jsonDocument = JsonDocument.Parse(jsonOS);
            //JsonElement root = jsonDocument.RootElement;
            //Console.WriteLine(root);
            var jsonDocument = JsonDocument.Parse(jsonOS);

            var jsonElement = jsonDocument.RootElement.TryGetProperty("System", out JsonElement targetElement);
            Console.WriteLine($"The Element is : {jsonElement}");
            if (!jsonElement)
            {
                Console.WriteLine("Element is not found");
            }
        }
            
    }
}
 