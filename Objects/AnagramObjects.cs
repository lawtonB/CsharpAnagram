using System.Collections.Generic;
namespace Anagrams
{
    public class Anagram
  {
      private string _userInput1;
      private string _userInput2;
      private char[] _inputInfo;
      private char[]  _inputInfo2;
//constructor//

    public Anagram(string UserInput1, string UserInput2)
     {
       _userInput1 = UserInput1;
       _userInput2 = UserInput2;
       char[] _inputInfo = UserInput1.ToCharArray();
       char[]  _inputInfo2 = UserInput2.ToCharArray();
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

      public bool CompareInputs(string UserInput1, string UserInput2)
      {
        if (UserInput1 == UserInput2)
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
