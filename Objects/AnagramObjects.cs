using System.Collections.Generic;
namespace Anagrams
{
    public class Anagram
  {
      private string _userInput1;
      private string _userInput2;
//constructor//

    public Anagram(string UserInput1, string UserInput2)
     {
       char[] _inputInfo = _userInput1.ToCharArray();
       char[]  _inputInfo2 = _userInput2.ToCharArray();
       _userInput1 = UserInput1;
       _userInput2 = UserInput2;
       _inputInfo.Add(this);
       _inputInfo2.Add(this);
     }

//getters and setters for properties//

      public string GetUserInput1()
      {
      return _userInput1;
      }
      public string GetUserInput2()
      {
      return _userInput2;
      }

      public bool CompareInputs(string _userInput1, string _userInput2)
      {
        if (_userInput1 == _userInput2)
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
