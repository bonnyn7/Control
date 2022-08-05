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
        
    }
}