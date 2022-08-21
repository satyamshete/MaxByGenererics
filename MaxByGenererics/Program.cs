namespace MaxByGenererics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///UC1
            //Console.WriteLine("Find Maximum of 3 intiger numbers");
            //int input;
            //int[] intArray = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = int.Parse(Console.ReadLine());
            //    intArray[i] = input;
            //}
            //MaxOfThreeInt.toPrint(intArray);

            ///UC2
            //Console.WriteLine("Find Maximum of 3 float numbers");
            //float input;
            //float[] floatArray = new float[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = float.Parse(Console.ReadLine());
            //    floatArray[i] = input;
            //}
            //MaxOfThreeFloat.toPrint(floatArray);

            ////UC3
            //  ////UC3
            //Console.WriteLine("Find Maximum of String");
            //string input;
            //string[] stringArray = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} string", i + 1);
            //    input = Console.ReadLine();
            //    stringArray[i] = input;
            //}
            //MaxOfString.toPrint(stringArray);

            ////UC4
            //MaximumUsingParamsWithoutGenerics.toPrint(100, 125, 482);
            //MaximumUsingParamsWithoutGenerics.toPrint(10.51f, 12.215f, 4.82f, 31.515f);
            //MaximumUsingParamsWithoutGenerics.toPrint("With", "Params");

            ////UC5
            //Console.WriteLine("Find Maximum of String or Intigers with Params and Generics");
            UsingParams.FindMax(10, 15, 20);
            UsingParams.FindMax(15.21, 15.1754, 15.5188);
            UsingParams.FindMax("Generics", "With", "Params");
        }
    }
}