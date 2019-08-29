public class Potion : Item {
  private double _strength = 5;

  private static readonly int[] _SPAWN_COUNT = { 1, 2, 3, 4, 5, 6, 7 };
  private static readonly int[] _SPAWN_WEIGHT = { 35, 25, 15, 10, 8, 5, 2 };

  public Potion(bool spawnGroup = false) {
    _name = "Potion";
    _stackLimit = 7;

    if (spawnGroup) {
      var usesIndex = Helpers.RandomResultWeighted(_SPAWN_WEIGHT);
      _stackSize = _SPAWN_COUNT[usesIndex];
    }
    else {
      _stackSize = 1;
    }
  }

  public double Use() {

    _stackSize--;
    if (_stackSize <= 0) {
      // Destroy object
    }

    return _strength;
  }
}