public class Sword : Weapon {


  public Sword() {

  }


  public override double UseWeapon() {

    // Calculate percentage of depriciation and apply it to durability
    if (_depreciation != 0) {
      _durability *= 1 - (_depreciation / 100);
    }

    if (_durability <= 0) {
      // Destroy weapon
    }

    return _damage;
  }
}