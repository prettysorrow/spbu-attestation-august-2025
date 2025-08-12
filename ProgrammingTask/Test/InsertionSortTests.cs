// <copyright file="InsertionSortTests.cs" company="_">
// psiblvdegod, 2025, under MIT License.
// </copyright>

namespace ProgrammingTask.Test;

// SA1600 : Elements should be documented.
#pragma warning disable SA1600

using ProgrammingTask.Lib;

/// <summary>
/// Tests class InsertionSort.
/// </summary>
[TestFixture]
public class InsertionSortTests
{
    [Test]
    public void Sort_ShouldPass()
    {
        List<int> numbers = [10, 2, 4, 5, 7, 1, -20, 30, 11];

        InsertionSort.Sort(numbers);

        List<int> expectedResult = [-20, 1, 2, 4, 5, 7, 10, 11, 30];

        Assert.That(numbers.SequenceEqual(expectedResult));
    }

    [Test]
    public void SortEven_ShouldPass()
    {
        List<int> numbers = [6, 2, 7, 4];

        InsertionSort.SortEven(numbers);

        List<int> expectedResult = [2, 4, 7, 6];

        Assert.That(numbers.SequenceEqual(expectedResult));
    }

    [Test]
    public void Sort()
    {
        List<int> numbers = [6, 2, 7, 4, 11, 2, 3, 2, 2];

        InsertionSort.SortEven(numbers);

        List<int> expectedResult = [2, 2, 7, 2, 11, 2, 3, 4, 6];

        Assert.That(numbers.SequenceEqual(expectedResult));
    }
}
