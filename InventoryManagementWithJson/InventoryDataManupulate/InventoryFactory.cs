using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementWithJson.InventoryDataManupulate
{
    public class InventoryFactory
    {
        public InventoryDetails ReadJson(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            var inventory = JsonConvert.DeserializeObject<InventoryDetails>(json);
            return inventory;
        }
        public void WriteToJson(string filePath, InventoryDetails fields)
        {
            var serializeJson = JsonConvert.SerializeObject(fields);
            File.WriteAllText(filePath, serializeJson);
        }
    }
}
