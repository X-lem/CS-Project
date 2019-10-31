using System;

public class Archer : Enemy {

  private static readonly Object[] _DROPS = { 
                                        new Coin(Coin.Wealth.Rich),
                                        new Potion(),
                                        new Arrow(5),
                                        new Bow()
                                    };
  private static readonly int[] _DROPS_WEIGHT = { 50, 25, 20, 5 };
  private Item _drop;

  public Archer() {
    var usesIndex = Helpers.RandomResultWeighted(_DROPS_WEIGHT);
    _drop = (Item)_DROPS[usesIndex];

    _maxHealth = _health = 100;
    _damage = 25;
  }


  public override void TakeDamage(double damage) {
    _health -= damage;

    if (_health <= 0) {
      // drop _DROP and delete object.
    }
  }
}