using System;

public class Blub : Enemy {

  public enum Color { Red, Yellow, Blue, Purple, White, Green }
  private string[] _colorArray = { "#E10010", "#FFD300", "#06339B", "#64039A", "#FFFFFF", "#61D600" };
  private static readonly Object[] _DROPS = { new Coin(Coin.Wealth.Bankrupt) };

  Color _color;

  public Blub(Color color = Color.Green) {
    _maxHealth = _health = 100;
    _damage = 10;

    _color = Color.Green;
  }

  public Color GetColor() {
    return _color;
  }
  public string GetColorHex() {
    return _colorArray[(int) _color];
  }

  public override void TakeDamage(double damage) {
    _health -= damage;

    if (_health <= 0) {
      // drop _DROP and delete object.
    }
  }
}