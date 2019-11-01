using System.Collections.Generic;

public class Arthur : Player {

  public Arthur() {
    _maxHealth = 250;
    _health = _maxHealth;
    _damageModifier = 1.2;
  }

  List<Item> _unusableWeapons = new List<Item>() {
    new Bomb()
  };

  public override bool CanUseWeapon(Item item) {
    if (_unusableWeapons.Contains(item))
      return false;

    return true;
  }
}