namespace MaxByGenererics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///UC1
            Console.WriteLine("Find Maximum of 3 intiger numbers");
            int input;
            int[] intArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter {0} number", i + 1);
                input = int.Parse(Console.ReadLine());
                intArray[i] = input;
            }
            MaxOfThreeInt.toPrint(intArray);
        }
    }
}