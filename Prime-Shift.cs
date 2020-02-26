using System;
using System.Collections.Generic;

namespace PrimeShifter{
  public class PrimeShift
  {
    private int _endNumber;
    private int _endCheck;
    private List<int> _primes;
    public PrimeShift(int endNumber)
    {
      _endNumber = endNumber;
      _endCheck = Convert.ToInt32(Math.Sqrt(endNumber));
      _primes = new List<int>(0);
      CreateAllNumbers();
    }

    public int GetEndNumber(){
      return _endNumber;
    }

    public int GetEndCheck(){
      return _endCheck;
    }

    public List<int> GetPrimes(){
      return _primes;
    }
    public void CreateAllNumbers()
    {
      for (int i = 2; i <= _endNumber; i++){
        _primes.Add(i);
      }
    }

    public List<int> CheckForPrimes(){
      int checkIndex = 0;
      while(_primes[checkIndex] <= _endCheck){
        int primeToCheck = _primes[checkIndex];
        int primeSquared = Convert.ToInt32(Math.Pow(primeToCheck, 2));
        int endCheckValue = (int)Math.Ceiling((double)(_endNumber - primeSquared)/primeToCheck);
        Console.WriteLine("end check Value" + endCheckValue);

        for(int i=0; i<=endCheckValue; i++){
          int numToRemove = primeSquared + (primeToCheck * i);
          if (numToRemove <= _primes[_primes.Count-1]){
            Console.WriteLine("remove " + numToRemove);
          }
          
        }

        checkIndex++;
      }
      return _primes;
    }
  }
}