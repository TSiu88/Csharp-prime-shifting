using System;
using PrimeShifter;


public class Program {
  static void Main()
  {
    Console.WriteLine("Find the primes up to what number?");
    string endString = Console.ReadLine();
    int endNumber = int.Parse(endString);
    PrimeShift primeShift = new PrimeShift(endNumber);
    for (int i=0; i< endNumber-1; i++){
      Console.WriteLine(primeShift.GetPrimes()[i]);
    }
    
  }
}