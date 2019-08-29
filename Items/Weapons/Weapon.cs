public abstract class Weapon : Item {

  public double _damage { get; set; }
  protected double _depreciation { get; set; } = 0;
  protected double _maxDurability { get; set; } = 0;
  protected double _durability { get; set; } = 0;

  public abstract double UseWeapon();
}