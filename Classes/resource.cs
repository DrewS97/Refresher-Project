using System;

namespace StoneAge {
  public class Resource {
    public string Name {get; set;}
    public string Color {get; set;}
    public int Quantity {get; set;}
    
    public Resource()
    {
      Name = "";
      Color = "";
      Quantity = 0;
    }

    public Resource(string name)
    {
      Name = name;
      Color = "";
      Quantity = 0;
    }

    public Resource(string name, string color, int quantity)
    {
      Name = name;
      Color = color;
      Quantity = quantity;
    }

    public override string ToString()
    {
      string resourceString = String.Format($"| Name:  {Name,-9}|\n| Color: {Color,-9}|\n| Qty:   {Quantity,-9}|");
      resourceString += "\n-------------------";
      return resourceString;
    }
  }
}