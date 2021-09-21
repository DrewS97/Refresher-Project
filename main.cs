using System;

namespace StoneAge {
  class Program {
    public static void Main (string[] args) {
      
      Game.Cards.Add(new Card("Orc", "Fighting", 0));
      Game.Cards.Add(new Card("Fairy", "Spirit", 1));
      Game.Cards.Add(new Card("Dwarf", "Mining", 2));
      Game.Cards.Add(new Card("Slime", "Demon", 3));
      Game.Cards.Add(new Card("Elf", "Mage", 4));
      Game.Cards.Add(new Card("Dragon", "Beast", 5));


      Game.Resources.Add(new Resource("Gold", "Yellow", 20));
      Game.Resources.Add(new Resource("Wood", "Brown", 120));
      Game.Resources.Add(new Resource("Silver", "Grey", 45));
      Game.Resources.Add(new Resource("Stone", "Grey", 100));
      Game.Resources.Add(new Resource("Food", "Green", 150));
      Game.Resources.Add(new Resource("Gemstones", "Shiny", 40));


      MenuOptions.Menu();
    }
  }
}