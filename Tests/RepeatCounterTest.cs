using Xunit;
namespace WordCounter.Objects
{
  public class WordCounterTest
  {

    [Fact]
    public void CountRepeats_aa_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("a", "a");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_Aa_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("A", "a");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aA_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("a", "A");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_cata_1()
    {
      // Arrange
      int expectedResult = 0;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("cat", "a");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aWithSpacesa_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats(" a ", "a");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aDoga_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("a dog", "a");

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_theCatIsTheBestthe_1()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("the cat is the best", "the");

      // Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void CountRepeats_catCommacat_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("cat,", "cat");

      // Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void CountRepeats_fullSentenceWithAllBehaviorsthe_2()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("The, cat is the best of these,", "the");

      // Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void CountRepeats_fullSentenceWithAllBehaviorscapitalThe_2()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter();

      // Act
      int result = testCounter.CountRepeats("The, cat is the best of these,", "The");

      // Assert
      Assert.Equal(expectedResult, result);
    }

  }
}
