using System;

namespace StoneAge {
  class MenuOptions {
    
    public static void Menu()
    {
      Console.WriteLine("----------------------------");
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("1. What Game is this?");
      Console.WriteLine("2. Game Report -");
      Console.WriteLine("3. Total Resources -");
      Console.WriteLine("4. Find a Card -");
      Console.WriteLine("5. Add a Card -");
      Console.WriteLine("6. Add a Resource -");
      Console.WriteLine("Enter \"q\" to quit.");
      Console.WriteLine("----------------------------\n");
      MenuUses();
    }
    
    public static void MenuUses()
    {
      string answer = Console.ReadLine();
      switch(answer)
      {
        case "1":
          Console.WriteLine("Stone Age\n");
        break;

        case "2":
          Console.WriteLine(Game.GameReport());
        break;

        case "3":
          Console.WriteLine(Game.ResourceTotal());
        break;

        case "4":
          Console.WriteLine(Game.FindCard());
        break;

        case "5":
          Game.AddCard();
        break;

        case "6":
          Game.AddResource();
        break;

        case "q":
          Console.WriteLine("Have a great day! =)\n");
        break;

        default:
          Console.WriteLine("Please enter a vaild response\n");
        break;
      }

      if (answer != "q")
      {
        Menu();
      }
    }
  }
}