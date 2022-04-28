using System;
using InventoryManagementWithJson;
using InventoryManagementWithJson.InventoryDataManagement;
using InventoryManagementWithJson.InventoryDataManupulate;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** Welcome In The Inventory Management ***** ");
        const string INVENTORY_FILE_PATH = @"D:\InventoryManagementSystem\InventoryManagement\InventoryManagementWithJson\InventoryDataManupulate\InventoryObject.json";
        InventoryDataDisplay inventoryData = new InventoryDataDisplay();
        InventoryManager manager = new InventoryManager();
        Console.WriteLine(" Display 1\n Add Inventory Data 2\n Edit the InventoryData 3\n");
        bool check = true;
        while (check)
        {
            Console.WriteLine("Enter the Above Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    inventoryData.DisplayInventoryData(INVENTORY_FILE_PATH);
                    break;
                case 2:
                    Console.WriteLine("Enter the InventoryName List \n Grain Name\n FilePath");
                    string inventoryName = Console.ReadLine();
                    InventoryData data = new InventoryData();
                    data.Name = Console.ReadLine();
                    data.Weight = 40;
                    data.Price = 75;
                    manager.AddInventory(data, inventoryName, INVENTORY_FILE_PATH);
                    break;
                case 3:
                    Console.WriteLine("Enter the InventoryName List \n Grain Name\n FilePath");
                    string name = Console.ReadLine();
                    InventoryData editData = new InventoryData();
                    editData.Name = Console.ReadLine();
                    editData.Weight = 40;
                    editData.Price = 75;
                    manager.AddInventory(editData, name, INVENTORY_FILE_PATH);
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}