namespace ProgrammingTask.Tests;

using ProgrammingTask.Lib;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        List<int> numbers = [6, 2, 7, 4];

        InsertionSort.SortEven(numbers);

        List<int> expectedResult = [2, 4, 7, 6];

        Assert.That(numbers.SequenceEqual(expectedResult));
    }
}
