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

  }
}
