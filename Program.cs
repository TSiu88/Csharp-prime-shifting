using System;
using System.Collections.Generic;
using PrimeShifter;

public class Program {
  static void Main()
  {
    // Get input from user and quit if none entered
    Console.WriteLine("Find the primes up to what number?");
    string endString = Console.ReadLine();
    if(endString == ""){
      Environment.Exit(0);
    }
    int endNumber = int.Parse(endString);
    PrimeShift primeShift = new PrimeShift(endNumber);

    Console.WriteLine("Find the primes to: " + primeShift.GetEndNumber() + " and end checks at " + primeShift.GetEndCheck());
    
    // Check for primes and print output
    List<int> primeList = primeShift.CheckForPrimes();
    Console.Write("[ ");
    for (int j=0; j < primeList.Count; j++){
      Console.Write(primeList[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
  }
}