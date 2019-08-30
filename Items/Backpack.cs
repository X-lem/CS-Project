using System;

public class Backpack : Item {

  const int _backpackSize = 5;
  private Item[] _slots = new Item[_backpackSize];

  public Backpack() {
    _name = "Backpack";
  }

  public void AddToBackpack(Item item) {

    bool putInEmptySpot = true;

    // Don't allow a backpack to be put inside a backpack
    // ToDo; Possibly allow it, but it takes up a space and can't be used to hold more items.
    if (item is Backpack) return;

    // Determine if the item already exists in the ArrayList
    for(int i = 0; i < _slots.Length; i++) {
      if(_slots[i] != null && _slots[i].GetType() == item.GetType()) {

        var slot = _slots[i];
        Console.WriteLine(i + " - slot size " + slot._stackSize);
        Console.WriteLine(i + " - item size " + item._stackSize);


        // Will fit in one slot
        if (slot._stackSize + item._stackSize <= slot._stackLimit) {
          Console.WriteLine("One shot");
          slot._stackSize += item._stackSize;
          putInEmptySpot = false;
          break;
        }
        // Only part of the stack will fit, split it and put part of it in the spot
        else {
          Console.WriteLine("Split");
          int space = slot._stackLimit - slot._stackSize;
          
          Console.WriteLine("Space: " + space);
          
          // Adjust the size
          slot._stackSize += space;
          item._stackSize -= space;
          
          Console.WriteLine("slot: " + slot._stackSize);
          Console.WriteLine("item: " + item._stackSize);
        }
        
        Console.WriteLine("__________________________");
        Console.WriteLine();
      }
    }

    // Add raitem to first empty slot if there's room
    // TODO: Fix - https://dotnetfiddle.net/7aj9Mg
    if (putInEmptySpot) {
      for(int i = 0; i < _slots.Length; i++) {
        Console.WriteLine("Item stack size: " + item._stackSize);
        
        Console.WriteLine("TYPE: " + item.GetType());

        // Instanciate item
        var newItem = Helpers.GetInstance<Item>(item.GetType());


        // Will fit in one slot
        if (item._stackSize <= item._stackLimit) {
          Console.WriteLine("One shot");
          _slots[i] = item;
          break;
        }
        // Only part of the stack will fit, split it and put part of it in the spot
        else {
          Console.WriteLine("Split");
          int overflow = item._stackSize - item._stackLimit;
          
          _slots[i] = item;
          
          Console.WriteLine("Overflow: " + overflow);
          
          item._stackSize = overflow;
          
        }
        Console.WriteLine(item._stackSize);
      }
    }
  }

  public void RemoveFromBackpack(int index) {
    _slots[index] = null;
  }
}