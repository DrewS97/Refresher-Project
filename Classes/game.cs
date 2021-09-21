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
      int counter = 3;
      double num = Resources.Count / 3;
      double loop = Math.Ceiling(num);
      int index = 0;
      
      for(double i = 0; i < loop; i++)
      {
        if((Resources.Count - counter) >= 0)
        {
          for(int j = counter - 3; j < counter; j++)
          {
            name += String.Format($"| Name: {Resources[j].Name,-9}  ");
          }

          name += "|\n";
          output += name;
          name = "";
        }
        else
        {
          name += String.Format($"| Name: {Resources[index].Name,-9}  ");
        }

        if((Resources.Count - counter) >= 0)
        {
          for(int j = counter - 3; j < counter; j++)
          {
            color += String.Format($"| Color: {Resources[j].Color,-8}  ");
          }

          color += "|\n";
          output += color;
          color = "";
        }
        else
        {
          color += String.Format($"| Color: {Resources[index].Color,-8}  ");
        }

        if((Resources.Count - counter) >= 0)
        {
          for(int j = counter - 3; j < counter; j++)
          {
            quantity += String.Format($"| Quantity: {Resources[j].Quantity, -5}  ");
          }

          quantity += "|\n";
          output += quantity;
          output += "----------------------------------------------------------\n";
          quantity = "";
        }
        else
        {
          quantity += String.Format($"| Quantity: {Resources[index].Quantity, -5}  ");
        }

        if((Resources.Count - counter) >= 0)
        {
          index = index + 3;
        }
        else
        {
          index++;
        }
        counter = counter + 3;
      }

      output += name + "\n";
      name = "";
      output += color + "\n";
      color = "";
      output += quantity + "\n";
      quantity = "";

      output += "\n--------------------------Cards--------------------------\n";
      
      counter = 1;

      for(int i = 0; i < Cards.Count; i++)
      {
        double newRow = 1;
        if(i != 0)
        {
          newRow = counter % 3;
        }
        counter++;

        name += String.Format($"| Name: {Cards[i].Name,-9}  ");

        if(newRow == 0)
        {
          name += "|\n";
          output += name;
          name = "";
        }
        else
        {
          output += name;
          name = "";
        }
        
        type += String.Format($"| Type: {Cards[i].Type,-9}  ");
        if(newRow == 0)
        {
          type += "|\n";
          output += type;
          type = "";
        }


        number += String.Format($"| Number: {Cards[i].Number, -7}  ");
        if(newRow == 0)
        {
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