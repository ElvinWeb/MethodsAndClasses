namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetValueByConsole();


            //int[] numbers = { 1, 2, 3, 4, 5 };
            //AddElementToArr(ref numbers, 12);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            Car car = new Car("BMW", "X6", 60, 3, 100);
            car.Drive(15);
            


            #region ThreeMethod
            static void GetValueByConsole()
            {
                Console.Write("Enter the first input: ");
                string word1 = Console.ReadLine();
                Console.Write("Enter the second input: ");
                string word2 = Console.ReadLine();
                IntOrNot(word1, word2);
            }
            static bool IntOrNot(string consoleVal1, string consoleVal2)
            {
                bool val1 = int.TryParse(consoleVal1, out int result1);
                bool val2 = int.TryParse(consoleVal2, out int result2);

                Console.WriteLine("Sum of numbers: " + GetSumOfNums(result1, result2));

                if (val1 && val2) return true;

                return false;
            }
            static int GetSumOfNums(int num1, int num2)
            {
                return num1 + num2;
            }
            #endregion

            #region Add New Element to the Array
            static void AddElementToArr(ref int[] array, int newArrItem)
            {
                int[] newArr = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    newArr[i] = array[i];
                }
                newArr[^1] = newArrItem;
                array = newArr;
            }
            #endregion

        }
    }
}