public class MaxHealthBoost : Powerup {

  double _maxHealthIncrease = 5;

  public MaxHealthBoost() {

  }

  public double Use() {
    return _maxHealthIncrease;

    // detroy object
  }
}