using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {

  public class Program
  {
    public static void Main()
    {
      // List<Item> Cars = new List<Car>() {};

      Console.WriteLine("Welcome to the To Do List! Enjoy your stay!");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string AddView = Console.ReadLine();
      if (AddView.ToLower() == "add") 
      {
        Console.WriteLine("What would you like to add?");
        string Add = Console.ReadLine();
        Item newItem = new Item(Add);
        Main();
      }
      else if (AddView.ToLower() == "view")
      {
        List<Item> result = Item.GetAll();
        // foreach (Item task in result)
        // {
        //   Console.WriteLine(task.Description);
        // }
        for (int j = 0; j < result.Count; j++) {
          Console.WriteLine(result[j].Description);
        }
      }
    }
  }
}

//Item newItem = new Item(description);
// List<Item> result = Item.GetAll();