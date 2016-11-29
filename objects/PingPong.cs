using System.Collections.Generic;
using System;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    private List<int> myNumbers = new List<int>();

    public List<int> GetNumbers()
    {
      return myNumbers;
    }

    public void Generator(int userInput)
    {
      for (int i = 0; i < userInput; i++)
      {
        myNumbers.Add(i);
      }
	  }
  }
}
