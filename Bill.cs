// Bill.cs
using System;
using System.Collections.Generic;

public class Bill : Menu
{
    private Dictionary<string, int> orderedItemsWithQuantity;
    private double totalBill;

    public Bill()
    {
        orderedItemsWithQuantity = new Dictionary<string, int>();
        totalBill = 0.0;
    }

    // Method to add an item to the bill with the specified quantity
    public void AddToBill(string itemName, double itemPrice, int quantity)
    {
        if (orderedItemsWithQuantity.TryGetValue(itemName, out int currentQuantity))
        {
            orderedItemsWithQuantity[itemName] = currentQuantity + quantity;
        }
        else
        {
            orderedItemsWithQuantity[itemName] = quantity;
        }

        totalBill += itemPrice * quantity;
    }

    // Method to display the bill with quantities
    public void DisplayBill()
    {
        Console.WriteLine();
        Console.WriteLine("Bill:");
        foreach (var item in orderedItemsWithQuantity)
        {
            Console.WriteLine($"{item.Key} - Quantity: {item.Value} - Total Price: {item.Value * GetItemPrice(item.Key)}Rs");
        }
        Console.WriteLine($"Total: {totalBill}Rs");
        //the amount you need to pay is
        Console.WriteLine("Thank you for visiting ! Your order is processing...");
        Console.WriteLine();
    }
}
