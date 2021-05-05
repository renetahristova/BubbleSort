using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 0, 2, 5, -1, 4, 1 };
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
            // Driver method to test binary search
           
                int[] arr = { 2, 3, 4, 10, 40 };
                int n = arr.Length;
                int x = 10;

                int result = BinarySearch(arr, 0, n - 1, x);

                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element found at index "
                                      + result);
            
        }
        //Метод за двоично търсене
        static int BinarySearch(int [] array, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                //Проверява дали елемента е в средата
                if (array[mid] == x)
                    return mid;
                //Проверява дали елемента е по-малък от средния и преминава наляво
                if (array[mid] > x)
                {
                    return BinarySearch(array, l, mid - 1, x);
                }
                //Ако е по- голям преминава надясно
                else {
                    return BinarySearch(array, mid + 1, r, x);
                }
                
            }

            //Ако елемента не съществува в масива
            return -1;
        }

    }
}
