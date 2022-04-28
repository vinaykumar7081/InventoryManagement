using InventoryManagementWithJson.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementWithJson.InventoryDataManupulate
{
    public class InventoryManager
    {
        InventoryDataDisplay inventory = new InventoryDataDisplay();
        InventoryFactory factory = new InventoryFactory();
        List<InventoryData> riceList = new List<InventoryData>();
        List<InventoryData> pulsesList = new List<InventoryData>();
        List<InventoryData> wheatList = new List<InventoryData>();
        public void ReadData(string filePath)
        {
            InventoryDetails details = factory.ReadJson(filePath);
            this.riceList = details.RiceList;
            this.pulsesList = details.PulsesList;
            this.wheatList = details.WheatList;
        }
        public void AddInventory(InventoryData data, string inventoryName, string filePath)
        {
            if (inventoryName.Equals("RiceList"))
            {
                riceList.Add(data);
            }
            if (inventoryName.Equals("PulsesList"))
            {
                pulsesList.Add(data);
            }
            if (inventoryName.Equals("WheatList"))
            {
                wheatList.Add(data);
            }
            SaveInventory(filePath);
            //inventory.DisplayInventoryData(filePath);

        }
        public void SaveInventory(string filePath)
        {
            InventoryDetails fields = new InventoryDetails();
            fields.RiceList = riceList;
            fields.PulsesList = pulsesList;
            fields.WheatList = wheatList;
            factory.WriteToJson(filePath, fields);
           // inventory.DisplayInventoryData(filePath);
        }
        public void EditInventory(InventoryData data1, string inventoryName, string filePath)
        {
            ReadData(filePath);
            InventoryData inventory = new InventoryData();
            if (inventoryName.Equals("Rice"))
            {
                foreach (InventoryData data in riceList)
                {
                    if (data.Name.Equals(data1))
                    {
                        Console.WriteLine("Enter the Option to edit the Code");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }

            if (inventoryName.Equals("Pulses"))
            {
                foreach (InventoryData data in pulsesList)
                {
                    if (data.Name.Equals(data1))
                    {
                        Console.WriteLine("Enter the Option to edit the Code");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (InventoryData data in wheatList)
                {
                    if (data.Name.Equals(data1))
                    {
                        Console.WriteLine("Enter the Option to edit the Code");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                inventory.Name = Console.ReadLine();
                                break;
                            case 2:
                                inventory.Price = Convert.ToDecimal(Console.ReadLine());
                                break;
                            case 3:
                                inventory.Weight = Convert.ToDecimal(Console.ReadLine());
                                break;
                        }
                    }
                }
            }
            SaveInventory(filePath);
        }
    }
}
    
