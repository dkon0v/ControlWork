internal class Program
{
    private static void Main(string[] args)
    {
        string[] array1 = { "let", "me", "go", "to", "IT" };
        int count1 = CountStringLessThreeChar(array1);
        string[] result1 = FillResultArray(array1, count1);


        string[] array2 = { "314", "12", "-40", "f_id", "abba" };
        int count2 = CountStringLessThreeChar(array2);
        string[] result2 = FillResultArray(array2, count2);

        string[] array3 = { "Russia", "England", "France", "Germany" };
        int count3 = CountStringLessThreeChar(array3);
        string[] result3 = FillResultArray(array3, count3);

        void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
            Console.WriteLine();
        }

        int CountStringLessThreeChar(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
            return count;
        }

        string[] FillResultArray(string[] array, int count)
        {
            string[] result = new string[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    result[result.Length - count] = array[i];
                    count--;
                }
            }
            return result;
        }

        PrintArray(result1);
        PrintArray(result2);
        PrintArray(result3);
    }
}