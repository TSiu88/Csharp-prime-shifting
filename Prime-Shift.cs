using System.Collections.Generic;

namespace PrimeShifter{
  public class PrimeShift
  {
    private int _endNumber;
    private List<int> _primes;
    public PrimeShift(int endNumber)
    {
      _endNumber = endNumber;
      _primes = new List<int>(0);
      CreateAllNumbers();
    }

    public int GetEndNumber(){
      return _endNumber;
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
  }
}