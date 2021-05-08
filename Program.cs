using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3,0,2,5,-1,4,1};
            int t;
            //Принтиране на масива преди сортиране
            Console.WriteLine("Original array :");
            foreach (int a in array)
                Console.Write(a + " ");
            //Сортиране на масива
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    //Сравнение на две числа
                    if (array[i] > array[i + 1])
                    {
                        //смяна на местата ако първото число е по-голямо 
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }
            //Принтиране на масива след сортиране
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int a in array)
                Console.Write(a + " ");
            Console.Write("\n");
            //-------------------------------------------------------------
            //Резултат от метод binary search 
            int n = array.Length;
            Console.WriteLine("Enter a number:");
            //Въвеждаме от конзолата числото, което ще търсим в масива
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary search result:");
            int firstResult = BinarySearch(array, 0, n - 1, x);

            if (firstResult == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at index " + firstResult);
            }
            //Резултат от метод линейно търсене
            Console.WriteLine("Linear search result:");
            int secondResult = search(array, x);
            if (secondResult == -1)
            {
                Console.WriteLine("Element is not present in array");
            }
            else
            {
                Console.WriteLine("Element is present at index " + secondResult);
            }

        }
        //Метод за двоично търсене
        static int BinarySearch(int[] binArr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                //Проверява дали елемента е в средата
                if (binArr[mid] == x)
                    return mid;
                //Проверява дали елемента е по-малък от средния и преминава наляво
                if (binArr[mid] > x)
                {
                    return BinarySearch(binArr, l, mid - 1, x);
                }
                //Ако е по- голям преминава надясно
                else
                {
                    return BinarySearch(binArr, mid + 1, r, x);
                }

            }

            //Ако елемента не съществува в масива
            return -1;
        }
        //Метод за линейно търсене
        public static int search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            //Ако елемента не съществува в масива
            return -1;
        }
    }
}
