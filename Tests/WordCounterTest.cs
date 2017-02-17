using System;
using Xunit;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void Test1_InputA_True()
    {
      //Arrange
      string userInput = "A";
      string checkText = "A";
      bool expResult = true;

      //Act
      RepeatCounter testMethod = new RepeatCounter(userInput, checkText);
      bool result = testMethod.CountRepeatsBool();

      //Assert
      Assert.Equal(expResult, result);
    }

    [Fact]
    public void Test2_InputAT_True()
    {
      //Arrange
      string userInput = "AT";
      string checkText = "AT";
      bool expResult = true;

      //Act
      RepeatCounter testMethod = new RepeatCounter(userInput, checkText);
      bool result = testMethod.CountRepeatsBool();

      //Assert
      Assert.Equal(expResult, result);
    }

  }
}
