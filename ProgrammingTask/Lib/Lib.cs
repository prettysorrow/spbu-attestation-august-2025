namespace ProgrammingTask.Lib;

using System.Linq;

public static class InsertionSort
{
    public static void SortEven(List<int> numbers)
    {
        var evens = numbers.Where(x => x % 2 == 0).ToList();
        var evenIndexes = new List<int>(evens.Count);
        for (var i = 0; i < numbers.Count; ++i)
        {
            if (numbers[i] % 2 == 0)
            {
                evenIndexes.Add(i);
            }
        }

        Sort(evens);

        for (var i = 0; i < evens.Count; ++i)
        {
            numbers[evenIndexes[i]] = evens[i];
        }
    }

    private static void Sort(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int current = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > current)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = current;
        }
    }
}
