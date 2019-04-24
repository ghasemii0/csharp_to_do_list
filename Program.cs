using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace idkSomething {
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/ View)");
      string AddOrView = Console.ReadLine();
      if(AddOrView == "add" || AddOrView == "Add") {
        Console.WriteLine("Add a task to your list");
        string userTask = Console.ReadLine();
        Item newItem = new Item(userTask);
        Main();
      }
      else if (AddOrView == "view" || AddOrView == "View")
      {
        foreach (Item task in Item.GetAll())
        Console.WriteLine(task.GetDescription());
        Main();
      }
    }
  }
}
