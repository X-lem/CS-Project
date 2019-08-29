public class Bow : Weapon {

  private static readonly int[] _STARTING_ARROWS_COUNT = { 0, 5 };
  private static readonly int[] _STARTING_ARROWS_WEIGHT = { 80, 20 };
  int _arrows = 0;
  int _range = 0;

  public Bow() {
    var usesIndex = Helpers.RandomResultWeighted(_STARTING_ARROWS_WEIGHT);
    _arrows = _STARTING_ARROWS_COUNT[usesIndex];

    _damage = 10;
  }

  public Bow(int arrows, int range, double damage) {
    _arrows = arrows;
    _range = range;
    _damage = damage;
  }

  public override double UseWeapon() {

    if (_arrows > 0) {
      _arrows--;
      return _damage;
    }

    return 0;
  }

  public void AddArrows(int count) {
    _arrows += count;
  }
}