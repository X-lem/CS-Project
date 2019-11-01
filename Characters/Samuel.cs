using System.Collections.Generic;

public class Samuel : Player {
  
  public Samuel() {
    _maxHealth = 150;
    _health = _maxHealth;
    _damageModifier = 0.8;

    _coins = 10;
  }

  List<Item> _unusableWeapons = new List<Item>() {
    new Sword()
  };

  public override bool CanUseWeapon(Item item) {
    if (_unusableWeapons.Contains(item))
      return false;

    return true;
  }
}