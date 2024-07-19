namespace LearningObjects
{

    public class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 1, 2, 3, 4, 5 };
            //int[] masyvas = { 6, 222, 3, 8, 543, 2, 90, 17, 84 };
            //int[] masyvas = { 0, 0, 0, 0, 5, 0, 0, 0, 0 };

            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 1");
            GetArrayElementByIndex(masyvas, 0);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 2");
            ArrayChangeSecondElement(masyvas, 70);
            Console.WriteLine(masyvas[1]);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 3");
            GetArrayLength(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 4");
            GetArrayElementByIndex(masyvas, 2);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 5");
            GetArrayLastElement(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 6");
            GetArrayMiddleElement(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("BONUS TASK 7");
            ArrayElementAddition(masyvas, 1, 4);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 8");
            int[] newArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] newStringArr = {"Labas", "Kaip sekasi?"};
            char[] newCharArr = {'a', '?'};
            CheckArrayElementExists(newArr, 10);
            CheckArrayElementExists(newArr, 11);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 9");
            Console.WriteLine(newArr[0]);
            SetArrayElementByIndex(newArr, 0, 28);
            Console.WriteLine(newArr[0]);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 10");
            CheckCharArrayIfContainsSymbol(newCharArr, '?');
            CheckCharArrayIfContainsSymbol(newCharArr, 'a');
            CheckCharArrayIfContainsSymbol(newCharArr, 'B');
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 11");
            CheckStringArrayIfContainsElement(newStringArr, "Labas");
            CheckStringArrayIfContainsElement(newStringArr, "as");
            CheckStringArrayIfContainsElement(newStringArr, "Čio Ty");
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 12");
            CheckArrayContainsSumOfTwoElements(newArr, 2, 5);
            CheckArrayContainsSumOfTwoElements(newArr, 15, 5);
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("TASK 13");
            CheckArrayIfIndexExists(newArr, 0);
            CheckArrayIfIndexExists(newArr, 9);
            CheckArrayIfIndexExists(newArr, 10);
            CheckArrayIfIndexExists(newArr, 25);
        }

        /*task 1*/
        public static void GetArrayElementByIndex(int[] arr, int index)
        {
            Console.WriteLine(arr[index]);
        }

        /*task 2*/
        public static int[] ArrayChangeSecondElement(int[] arr, int value)
        {
            arr[1] = value;
            return arr;
        }

        /*task 3*/
        public static void GetArrayLength(int[] arr) {
            Console.WriteLine(arr.Length);
        }

        /*task 4*/
        // same as task 1, so reused code

        /*task 5*/
        public static void GetArrayLastElement(int[] arr)
        {
            int lastArrElement = arr.Length;
            Console.WriteLine(arr[lastArrElement-1]);
        }

        /*task 6*/
        public static void GetArrayMiddleElement(int[] arr)
        {
            int lastArrElement = arr.Length;
            Console.WriteLine(arr[lastArrElement/2]);
        }

        /*bonus task 7*/
        public static void ArrayElementAddition(int[] arr, int index1, int index2)
        {
            Console.WriteLine(arr[index1] + arr[index2]);
        }

        /*task 8*/
        public static void CheckArrayElementExists(int[] arr, int element)
        {
            if (arr.Contains(element))
                Console.WriteLine("Element " + element + " exists in the array");
            else
                Console.WriteLine("Element " + element + " does not exist in the array");
        }

        /*task 9*/
        public static int[] SetArrayElementByIndex(int[] arr, int index, int value)
        {
            arr[index] = value;
            return arr;
        }

        /*task 10*/
        public static void CheckCharArrayIfContainsSymbol(char[] arr, char symbol)
        {
            if (arr.Contains(symbol))
                Console.WriteLine("Symbol " + symbol + " exists in the array");
            else
                Console.WriteLine("Symbol " + symbol + " does not exist in the array");
        }

        /*task 11*/
        public static void CheckStringArrayIfContainsElement(string[] arr, string element)
        {
            if (arr.Contains(element))
                Console.WriteLine("Element " + element + " exists in the array");
            else
                Console.WriteLine("Element " + element + " does not exist in the array");
        }

        /*task 12*/
        public static void CheckArrayContainsSumOfTwoElements(int[] arr, int num1, int num2)
        {
            if (arr.Contains(num1+num2))
                Console.WriteLine("Sum of numbers " + num1 + " and " + num2 + " exist in the array");
            else
                Console.WriteLine("Sum of numbers " + num1 + " and " + num2 + " do not exist in the array");
        }

        /*task 13*/
        public static void CheckArrayIfIndexExists(int[] arr, int index)
        {
            if (arr.Length-1>=index)
                Console.WriteLine("Index " + index + " exists in the array");
            else
                Console.WriteLine("Index " + index + " does not exist in the array");
        }
    }
}