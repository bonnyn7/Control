namespace Control
{
    class Task
    {
        static void Main(string[] args)
        {
            string[] firstArray = new string[5] { "oak", ":-)", "pine", "maple", "apple" };
            string[] secondArray = new string[firstArray.Length];
            SecondArray(firstArray, secondArray);
            PrintArray(secondArray);
        }
        static void SecondArray(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            int border = 3;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i].Length <= border)
                {
                    secondArray[count] = firstArray[i];
                    count++;
                }
            }
        }
        static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}