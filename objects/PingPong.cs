using System.Collections.Generic;
using System;

namespace PingPong.Objects
{
  public class PingPongGenerator
  {
    public List<int> myNumbers = new List<int>();

    public void Generator(int userInput)
    {
      for (int i = 0; i < userInput; i++)
      {
        myNumbers.Add(i);
      }
	  }
  }
}
