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

  }
}
