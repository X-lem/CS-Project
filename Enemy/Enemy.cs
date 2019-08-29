public abstract class Enemy {

  public string _name { get; set; }
  public  double _maxHealth { get; set; }
  public double _health { get; set; }
  public double _damage { get; set; }

  public abstract void TakeDamage(double damage);
}