using System;
using Xunit;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void Test1_InputA_True()
    // {
    //   //Arrange
    //   string userInput = "A";
    //   string checkText = "A";
    //   bool expResult = true;
    //
    //   //Act
    //   RepeatCounter testMethod = new RepeatCounter(userInput, checkText);
    //   bool result = testMethod.CountRepeatsBool();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }
    //
    // [Fact]
    // public void Test2_InputAT_True()
    // {
    //   //Arrange
    //   string userInput = "buffalo";
    //   string checkText = "buffalo";
    //   bool expResult = true;
    //
    //   //Act
    //   RepeatCounter testMethod = new RepeatCounter(userInput, checkText);
    //   bool result = testMethod.CountRepeatsBool();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }
    //
    // [Fact]
    // public void Test3_InputAnyCaseWord_1()
    // {
    //   //Arrange
    //   string userInput = "Buffalo";
    //   string checkText = "buFFaLo";
    //   int expResult = 1;
    //
    //   //Act
    //   RepeatCounter testFunc = new RepeatCounter(userInput, checkText);
    //   int result = testFunc.GetCount();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }

    // [Fact]
    // public void Test4_SplitText_8()
    // {
    //   //Arrange
    //   string checkText = "The buffalo is large. Buffalo is my name.";
    //   int expResult = 8;
    //
    //   //Act
    //   RepeatCounter testFunc = new RepeatCounter(checkText);
    //   int result = testFunc.GetCount();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }


    // [Fact]
    // public void Test3_InputTEA_TEATEA()
    // {
    //   //Arrange
    //   string userInput = "TEA";
    //   string checkText = "TEA";
    //   bool expResult = "T","E","A","T","E","A";
    //
    //   //Act
    //   RepeatCounter testMethod = new RepeatCounter(userInput, checkText);
    //   bool result = testMethod.stringToCharCompare();
    //
    //   //Assert
    //   Console.WriteLine(expResult);
    //   Console.WriteLine(result);
    //   Assert.Equal(expResult, result);
    // }

    [Fact]
    public void Test6_SplitText_8()
    {
      //Arrange
      string userInput = "buffalo";
      string checkText = "The buffalo is large. Buffalo is my name.";
      int expResult = 2;

      //Act
      RepeatCounter testFunc = new RepeatCounter(userInput, checkText);
      int result = testFunc.GetCount();

      //Assert
      Assert.Equal(expResult, result);
    }

  }
}
