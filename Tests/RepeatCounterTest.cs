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
      RepeatCounter testCounter = new RepeatCounter("a", "a");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_Aa_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter("A", "a");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aA_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter("a", "A");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_cata_1()
    {
      // Arrange
      int expectedResult = 0;
      RepeatCounter testCounter = new RepeatCounter("cat", "a");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aWithSpacesa_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter(" a ", "a");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_aDoga_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter("a dog", "a");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_theCatIsTheBestthe_1()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter("the cat is the best", "the");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_catCommacat_1()
    {
      // Arrange
      int expectedResult = 1;
      RepeatCounter testCounter = new RepeatCounter("cat,", "cat");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_fullSentenceWithAllBehaviorsthe_2()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter("The, cat is the best of these,", "the");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void CountRepeats_fullSentenceWithAllBehaviorscapitalThe_2()
    {
      // Arrange
      int expectedResult = 2;
      RepeatCounter testCounter = new RepeatCounter("The, cat is the best of these,", "The");

      // Act
      int result = testCounter.CountRepeats();

      // Assert
      Assert.Equal(expectedResult, result);
    }

  }
}
