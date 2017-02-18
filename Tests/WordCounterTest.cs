using System;
using Xunit;
using System.Collections.Generic;

namespace RepeatCounter
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
    //   int result = testFunc.CountRepeats();
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
    //   int result = testFunc.CountRepeats();
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
    //   bool result = testMethod.CountRepeats();
    //
    //   //Assert
    //   Console.WriteLine(expResult);
    //   Console.WriteLine(result);
    //   Assert.Equal(expResult, result);
    // }

    // [Fact]
    // public void Test6_SplitText_8()
    // {
    //   //Arrange
    //   string userInput = "buffalo";
    //   string checkText = "The buffalo is large. Buffalo is my name.";
    //   int expResult = 2;
    //
    //   //Act
    //   RepeatCounter testFunc = new RepeatCounter(userInput, checkText);
    //   int result = testFunc.CountRepeats();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }

    [Fact]
    public void Test7_CountWithSpecChar_3()
    {
      //Arrange
      string userInput = "buffalo";
      string checkText = "The buffalo is large. Buffalo is my name, and buffalo's are strong. 'bUFFULOEs' is not how you spell the plural version of the word 'buffalo'. and buffaloies and buffaloly is also wrong.";
      int expResult = 5;

      //Act
      RepeatCounter testFunc = new RepeatCounter(userInput, checkText);
      int result = testFunc.CountRepeats();

      //Assert
      Assert.Equal(expResult, result);
    }

    // [Fact]
    // public void Test8_Contains_True()
    // {
    //   //Arrange
    //   string userInput = "buffalo";
    //   string checkText = "The buffalo is large. Buffalo is my name, and buffalo's are strong, buffalo, buffalo. 'bUFFULOEs' is not how you spell the plural version of the word 'buffalo'. and buffaloies and buffaloly is also wrong.";
    //   int expResult = 5;
    //
    //   //Act
    //   RepeatCounter testFunc = new RepeatCounter(userInput, checkText);
    //   int result = testFunc.CountRepeats();
    //
    //   //Assert
    //   Assert.Equal(expResult, result);
    // }


  }
}
