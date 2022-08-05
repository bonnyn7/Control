namespace Homework9
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
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i].Length <= 3)
                {
                    secondArray[count] = firstArray[i];
                    count++;
                }
            }
        }
        
    }
}