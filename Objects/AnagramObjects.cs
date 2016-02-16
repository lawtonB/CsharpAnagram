using System;
using System.Collections.Generic;
using System.Linq;
namespace Anagrams
{
    public class Anagram
  {
      private string _userInput1;
      private string _userInput2;
//constructor//

    public Anagram(string UserInput1, string UserInput2)
     {
       _userInput1 = UserInput1;
       _userInput2 = UserInput2;
     }

// getters and setters for properties//

      public string GetUserInput1()
      {
      return _userInput1;
      }
      public string GetUserInput2()
      {
      return _userInput2;
      }

    public bool CompareInputs()
    {
      char[] _inputInfo = _userInput1.ToCharArray();
      char[]  _inputInfo2 = _userInput2.ToCharArray();
      Array.Sort(_inputInfo);
      Array.Sort(_inputInfo2);

      if (_inputInfo == _inputInfo2)
      {
        return true;
      }
      else if (_inputInfo.SequenceEqual(_inputInfo2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
