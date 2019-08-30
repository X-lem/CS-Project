public class MaxHealthBoost : Powerup {

  double _maxHealthIncrease = 25;

  public MaxHealthBoost() {

  }

  public override void Use(Player player) {

    player.AdjustMaxHealth(_maxHealthIncrease);
    
    // detroy object
  }
}