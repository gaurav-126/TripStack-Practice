// Menu.cs
using System;
using System.Collections.Generic;
using System.Linq;
public class Menu
{
    // Dictionary to store menu items and their prices
    private Dictionary<string, double> menuItems;

    public Menu()
    {
        // Initialize the menu with some default items
        menuItems = new Dictionary<string, double>
        {
            {"Dosa", 50},
            { "Idli Sambar",60},
            {"Pizza", 120},
            {"Misal", 70},
            { "Pav Bhaji",130},
            // Add more items as needed
        };
    }

    // Method to display the menu
    public void DisplayMenu()
    {

        Console.WriteLine("-------------Menu-------------");
        Console.WriteLine("Sr.No     Food Item       Price");
        Console.WriteLine("1.        Dosa            50Rs");
        Console.WriteLine("2.        Idli Sambar     60Rs");
        Console.WriteLine("3.        Pizza           120Rs");
        Console.WriteLine("4.        Misal           70Rs");
        Console.WriteLine("5.        Pav Bhaji       130Rs");
        Console.WriteLine();
    }

    // Method to get the price of a specific item
    public double GetItemPrice(string itemName)
    {
        if (menuItems.TryGetValue(itemName, out double price))
        {
            return price;
        }
        return -1; // Indicate item not found
    }


    // Method to get the total number of menu items
    public int GetMenuItemsCount()
    {
        return menuItems.Count;
    }

    // Method to get the item name by its Sr.No
    public string GetItemNameBySrNo(int srNo)
    {
        if (srNo > 0 && srNo <= menuItems.Count)
        {
            return menuItems.ElementAt(srNo - 1).Key;
        }
        return null; // Indicate invalid Sr.No
    }
}
