using System;
using System.Collections.Generic;

namespace StoneAge {
  public static class Game {
    public static string Name = "Stone Age";
    public static List<Card> Cards = new List<Card>();
    public static List<Resource> Resources = new List<Resource>();

    public static void AddCard()
    {
      Console.WriteLine("\nEnter the name of the card:");
      string name = Console.ReadLine();

      Console.WriteLine("\nEnter the type of the card:");
      string type = Console.ReadLine();

      int number = Cards.Count;

      Cards.Add(new Card(name, type, number));
    }

    public static void AddResource()
    {
      Console.WriteLine("Enter the name of the resource:\n");
      string name = Console.ReadLine();

      Console.WriteLine("Enter the color of the resource:\n");
      string color = Console.ReadLine();

      Console.WriteLine("Enter the quantity of the resource:\n");
      int quantity = Int32.Parse(Console.ReadLine());

      Resources.Add(new Resource(name, color, quantity));
    }

    public static string GameReport()
    {
      string output = "\nGame Title: --Stone Age-- \n-------------------RESOURCES----------------------\n";
      
      foreach(Resource resource in Resources)
      {
        output += resource.ToString() + "\n";
      }

      output += "\n---------------------Cards-----------------------\n";

      foreach(Card card in Cards)
      {
        output += card.ToString() + "\n";
      }

      return output;
    }

    public static string ResourceTotal()
    {
      int total = 0;
      foreach(Resource res in Resources)
      {
        total += res.Quantity;
      }

      string output = $"\n---Total number of resources: {total}---\n";
      return output;
    }

    public static string FindCard()
    {
      Console.WriteLine("What is the number of the card you want to find?");
      int answer = Int32.Parse(Console.ReadLine());
      string output = "";

      foreach(Card card in Cards)
      {
        if (answer == card.Number)
        {
          output = "\n--------------------\n" + card.ToString();
        }
      }

      if (output == "")
      {
        output = "Please enter a valid card number.";
      }
      return output;
    }
  }
}