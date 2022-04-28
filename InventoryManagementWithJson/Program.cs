using System;
using InventoryManagementWithJson;
using InventoryManagementWithJson.InventoryDataManagement;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(" ***** Welcome In The Inventory Management ***** ");
        const string INVENTORY_FILE_PATH = @"D:\InventoryManagementSystem\InventoryManagement\InventoryManagementWithJson\InventoryDataManagement\Inventory.json";
        InventoryDataDisplay inventoryData = new InventoryDataDisplay();
        Console.WriteLine(" Display 1\n");
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
                case 0:
                    check = false;
                    break;
            }
        }
    }
}