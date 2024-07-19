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
            /*task 1*/
            GetArrayElementByIndex(masyvas, 0);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 2*/
            ArrayChangeSecondElement(masyvas, 70);
            Console.WriteLine(masyvas[1]);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 3*/
            GetArrayLength(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 4*/
            GetArrayElementByIndex(masyvas, 2);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 5*/
            GetArrayLastElement(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            /*task 6*/
            GetArrayMiddleElement(masyvas);
            Console.WriteLine("///////////////////////////////////////////");
            /*bonus task 7*/
            Console.WriteLine("bonus task");
            ArrayElementAddition(masyvas, 1, 4);
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
    }
}