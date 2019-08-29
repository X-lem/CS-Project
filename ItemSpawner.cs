public class ItemSpawner {

  private static readonly Item[] _ITEMS = {
                  new Coin(Coin.Wealth.Default),
                  new Potion(),
                  new Arrow(),
                  new Bomb(),
                  new Bow(),
                  new Sword()
  };

  private static readonly int[] _ITEMS_WEIGHT = {

  };

  private float _spawnRate;

  public ItemSpawner() {

  }
}