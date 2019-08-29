using System;

class Generator {
  static void Main() {

    //weighting of each thing, high number means more occurrance
    int[] rockCount = { 1, 2, 3, 4, 5, 6, 7 };
    int[] rockWeights = { 2, 4, 30, 22, 20, 13, 9 };

    int[] generatedCount = new int[rockCount.Length];

    // Fill array
    for (int i = 0; i < generatedCount.Length; i++) {
      generatedCount[i] = 0;
    }

    int weightTotal = 0;
    foreach (int w in rockWeights) {
      weightTotal += w;
    }
    
    int randVal;
    Random random = new Random();

    int count = 0;
    do {
      int result = 0, total = 0;
      
      randVal = random.Next(0, weightTotal);
      // Console.WriteLine("Random number: " + randVal);
      for (result = 0; result < rockWeights.Length; result++) {
        total += rockWeights[result];
        if (total > randVal) break;
      }
      generatedCount[result]++;
      // Console.WriteLine("Result: " + result);
      // Console.WriteLine("Rocks generated: " + rockCount[result]);
      count++;
    } while(count < 10000);

    // Display the results
    Console.WriteLine("Total weight: " + weightTotal);
    Console.WriteLine("Total count: " + count);
    for (int i = 0; i < generatedCount.Length; i++) {
      Console.WriteLine(rockCount[i] + " rock generated " + generatedCount[i] + " times. " + ((double)generatedCount[i] * 100.00 / count) + "%");
    }
  }
}