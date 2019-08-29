using System;

public static class Helpers
{
  #region RandomNumberGenerators

  /// <summary>
  /// Returns the index that is used to select an item in an array
  /// </summary>
  /// <param name="weights">An array of integers representing the weights of a given array. Doesn't need to add up to 100</param>
  public static int RandomResultWeighted(int[] weights) {

    int weightTotal = 0;
    foreach (int w in weights) { weightTotal += w; }

    int result = 0, total = 0;
    Random random = new Random();
    int randVal = random.Next(0, weightTotal);
    for (result = 0; result < weights.Length; result++) {
        total += weights[result];
        if (total > randVal) break;
    }
    return result;
  }

  #endregion


  #region Instanciators
  public static T GetInstance<T>(Type type)
  {
      return (T)Activator.CreateInstance(type);
  }
  #endregion
}