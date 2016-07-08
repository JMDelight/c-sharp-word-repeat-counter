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

  }
}
