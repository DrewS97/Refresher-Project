using System;

namespace StoneAge {
  public class Card {
    public string Name {get; set;}
    public string Type {get; set;}
    public int Number {get; set;} = 1;
    
    public Card()
    {
      Name = "";
      Type = "";
      Number = 0;
      Number++;
    }

    public Card(string name)
    {
      Name = name;
      Type = "";
      Number = 0;
      Number++;
    }

    public Card(string name, string type, int number)
    {
      Name = name;
      Type = type;
      Number = number;
      Number++;
    }

    public override string ToString()
    {
      string cardString = String.Format($"| Name: {Name,-8}  |\n| Type: {Type,-8}  |\n| Number: {Number,-8}|");
      cardString += "\n--------------------";
      return cardString;
    }
  }
}