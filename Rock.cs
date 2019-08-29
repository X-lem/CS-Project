using System;
using System.Collections.Generic;

public class Rock {
  
  const int _CULSTER_CHANCE = 80;
  // The amount of rocks to be generated and the percentage of change each has
  private static readonly int[] _ROCK_CLUSTER_COUNT = { 1, 2, 3, 4, 5, 6, 7 };
  private static readonly int[] _ROCK_CLUSTER_WEIGHT = { 2, 4, 30, 22, 20, 13, 9 };

  Random _random = new Random();

  public int posX { get; set; }
  public int posY { get; set; }

  // Spawns a single rock
  public Rock() {

  }
  public Rock(int x, int y) {
    posX = x;
    posY = y;
  }

  // Spawns a single rock with a chance of a cluster
  public void PossibleRockCluster(int clusterChance = _CULSTER_CHANCE) {

    int ranNum = _random.Next(0, 100);

    if (ranNum > clusterChance) {
      RockCluster();
    }
    else {
      Rock r = new Rock();
    }
  }

  // Spawns a rock cluster
  public void RockCluster() {

    // Generate initial clump or rocks
    int rockClusterSize = _ROCK_CLUSTER_COUNT[Helpers.RandomResultWeighted(_ROCK_CLUSTER_WEIGHT)];
    
    // The linear chance of another rock spawning. Last number is repeated
    int[] generateChance = { 90, 80, 65, 50, 35, 20, 15, 10 };

    // Add onto initial clump
    int i = 0;
    do {
      if (generateChance.Length == 0) break;

      int ranNum = _random.Next(0, 100);
      Console.WriteLine("RanNum: " + ranNum + ". Chance: " + generateChance[i]);
      if (ranNum < generateChance[i]) {
        rockClusterSize++;
        Console.WriteLine("Rock Generated");
      }
      else {
        Console.WriteLine("No rock, break.");
        break;
      }
      
      // Repeatedly use the last number in the array
      if (i < generateChance.Length - 1) i++;
    } while (true);

    // List<Rock> rockGroup = RockGroup(rockClusterSize);
  }

  // For spawning multiple rocks close to one another.
  public List<Rock> RockGroup(int spawnAmount, int startX, int StartY) {
    List<Rock> rocks = new List<Rock>();

    for(int i = 0; i < spawnAmount; i++) {
      Rock r = new Rock(startX, StartY);
    }

    return rocks;
  }
}