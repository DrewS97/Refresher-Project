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
      string output = "\nGame Title: --Stone Age-- \n------------------------RESOURCES-------------------------\n";
      string name = "";
      string type = "";
      string color = "";
      string number = "";
      string quantity = "";
      
      for(int i = 0; i < Resources.Count; i++)
      {
        if(i % 3 == 0 && i != 0)
        {
          name += "|\n";
          output += name;
          name = "";

          color += "|\n";
          output += color;
          color = "";

          quantity += "|\n";
          output += quantity;
          output += "----------------------------------------------------------\n";
          quantity = "";
        }


        name += String.Format($"| Name: {Resources[i].Name,-9}  ");
        color += String.Format($"| Color: {Resources[i].Color,-8}  ");
        quantity += String.Format($"| Quantity: {Resources[i].Quantity, -5}  ");
        if (i == Resources.Count - 1)
        {
          name += "|\n";
          output += name;
          name = "";

          color += "|\n";
          output += color;
          color = "";

          quantity += "|\n";
          output += quantity;
          output += "----------------------------------------------------------\n";
          quantity = "";
        }


      }


      output += "\n--------------------------Cards--------------------------\n";

      for(int i = 0; i < Cards.Count; i++)
      {
        if(i % 3 == 0 && i != 0)
        {
          name += "|\n";
          output += name;
          name = "";

          type += "|\n";
          output += type;
          type = "";

          number += "|\n";
          output += number;
          output += "----------------------------------------------------------\n";
          number = "";
        }

        name += String.Format($"| Name: {Cards[i].Name,-9}  ");
        type += String.Format($"| Type: {Cards[i].Type,-9}  ");
        number += String.Format($"| Number: {Cards[i].Number, -7}  ");
        if (i == Cards.Count - 1)
        {
          name += "|\n";
          output += name;
          name = "";

          type += "|\n";
          output += type;
          type = "";

          number += "|\n";
          output += number;
          output += "----------------------------------------------------------\n";
          number = "";
        }
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