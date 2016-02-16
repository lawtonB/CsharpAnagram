using Xunit;
using Anagrams;
using System;
using System.Collections.Generic;


namespace AnagramTest
{
  public class AnagramTester
  {
    [Fact]
    public void IsWord_forWordEqualingSameWord_true()
    {
      //arrange//
      string input1 = "beard";
      string input2 = "beard";
      Anagram newAnagram = new Anagram(input1, input2);
      // List<Anagram> newListAnagram = new List<Anagram>() {newAnagram};
      //act//
      bool result = newAnagram.CompareInputs(input1, input2);
      //assert//
      Assert.Equal(true, result);
    }
  }
}


// if beard = beard
// else if bread = beard
// else  hat = beard

// Array.Sort, Array.CharAt(),
