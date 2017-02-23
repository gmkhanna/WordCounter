using System;
using Xunit;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class RepeatCounterTest
  {
      [Fact]
      public void Test_StringEqual_1()
      {
          //Arrange
          string inputWord = "A";
          string inputText = "A";

          //ACT
          RepeatCounter testInput = new RepeatCounter(inputWord, inputText);
          int testResult = testInput.CountRepeats();

          //Assert
          Assert.Equal(testResult, 1);
      }

      [Fact]
      public void Test_StringNOTEqual_0()
      {
          //Arrange
          string inputWord = "A";
          string inputText = "B";

          //ACT
          RepeatCounter testInput = new RepeatCounter(inputWord, inputText);
          int testResult = testInput.CountRepeats();

          //Assert
          Assert.Equal(testResult, 0);
      }

      [Fact]
      public void Test_StringTwoCharOrMoreEqual_1()
      {
          //Arrange
          string inputWord = "AT";
          string inputText = "AT";

          //ACT
          RepeatCounter testInput = new RepeatCounter(inputWord, inputText);
          int testResult = testInput.CountRepeats();

          //Assert
          Assert.Equal(testResult, 1);

      }



  }
}
