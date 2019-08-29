public class Coin : Item {

  private static readonly int[] _COIN_DROP_VALUE = {0, 1, 3, 5, 10};
  private static readonly int[] _COIN_DROP_WEIGHT_BANKRUPT = {50, 50, 0, 0, 0};
  private static readonly int[] _COIN_DROP_WEIGHT_POOR = {10, 85, 5, 0, 0};
  private static readonly int[] _COIN_DROP_WEIGHT_DEFUALT = {0, 60, 25, 15, 0};
  private static readonly int[] _COIN_DROP_WEIGHT_RICH = {0, 5, 20, 50, 25};
  private static readonly int[] _COIN_DROP_WEIGHT_EXTRAVAGANT = {0, 0, 10, 20, 70};

  public enum Wealth { Bankrupt, Poor, Default, Rich, Extravagant }

  int _value = 1;
  public Coin() {
    DetermineValue();
  }

  public Coin(Wealth wealth) {
    DetermineValue(wealth);
  }

  public Coin(int value) {
    _value = value;
  }

  // Determins the value of the coin
  private void DetermineValue(Wealth wealth = Wealth.Default) {
    int valueIndex = Helpers.RandomResultWeighted(GetCoinDropWeight(wealth));
    _value = _COIN_DROP_VALUE[valueIndex];
  }

  private int[] GetCoinDropWeight(Wealth wealth) {

    switch (wealth) {
      case Wealth.Bankrupt:
        return _COIN_DROP_WEIGHT_BANKRUPT;
      case Wealth.Poor:
        return _COIN_DROP_WEIGHT_POOR;
      case Wealth.Rich:
        return _COIN_DROP_WEIGHT_RICH;
      case Wealth.Extravagant:
        return _COIN_DROP_WEIGHT_EXTRAVAGANT;
      default:
        return _COIN_DROP_WEIGHT_DEFUALT;
    }
  }
}