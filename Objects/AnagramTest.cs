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
      //act//
      bool result = newAnagram.CompareInputs(input1, input2);
      //assert//
      Assert.Equal(true, result);
    }
    [Fact]
    public void IsWord_forWordNotEqualingSameWord_false()
    {
      string input1 = "frog";
      string input2 = "superman";
      Anagram newAnagram = new Anagram(input1,input2);

      bool result = newAnagram.CompareInputs(input1, input2);

      Assert.Equal(false, result);
    }
  }
}


// if beard = beard
// else if bread = beard
// else  hat = beard

// Array.Sort, Array.CharAt(),
