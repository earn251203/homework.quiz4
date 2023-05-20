using System;

class UniqueQuiz4
{
    static void Main(string[] args)
    {
        int rowCount = int.Parse(Console.ReadLine());
        int range = int.Parse(Console.ReadLine());
        int checkRange = 1 + range * 2;
        int[] populationData = new int[rowCount];
        int[] resultStorage = new int[rowCount - checkRange + 1];

        for (int i = 0; i < rowCount; i++)
        {
            populationData[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < rowCount - checkRange + 1; i++)
        {
            for (int j = 0; j < checkRange; j++)
            {
                resultStorage[i] += populationData[j + i];
            }
        }

        FindMaximumValue(resultStorage);
    }

    static void FindMaximumValue(int[] array)
    {
        int maxValue = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue >= array[i])
                maxValue = maxValue;
            else
                maxValue = array[i];
        }
        DisplayResult(maxValue);
    }

    static void DisplayResult(int result)
    {
        Console.WriteLine("The maximum value is: " + result);
    }
} 
