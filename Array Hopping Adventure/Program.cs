public class Program
{
    public static void Main(string[] args)
    {
        List<int> listA = FillInList();
        List<int> listB = FillInList();

        int maxValue = FindMaxValue(listA, listB);

        Console.WriteLine($"Max value is {maxValue}");

    }

    public static int FindMaxValue(List<int> listA, List<int> listB)
    {
        int indexA = 0;
        int? indexB = null;
        int maxValue = 0;
        bool inListA = true;

        while (true)
        {
            if (inListA)
            {
                indexB = listA[indexA];
                if (listB[indexB.Value] > maxValue)
                {
                    maxValue = listB[indexB.Value];
                }
            }
            else
            {
                indexA = listB[indexB.Value];
                if (indexA == 0)
                {
                    return maxValue;
                }
            }

            inListA = !inListA;
        }        
    }

    public static List<int> FillInList()
    {
        int totalNumbers = 0;
        List<int> intList = new List<int>();

        do
        {
            intList.Add(new Random().Next(0, 10));
            totalNumbers++;
        } while (totalNumbers <= 3);

        if (!intList.Contains(0))
        {            
            Random random = new Random();
            int randomIndex = random.Next(0, intList.Count);
            intList[randomIndex] = 0;
        }

        return intList;
    }
}