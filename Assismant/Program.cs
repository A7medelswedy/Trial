using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assismant
{
    internal class Program
    {

        // Main function ( view output to user)
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" enter size of Array (it must be 6)");
                int n = int.Parse(Console.ReadLine());
                string[] arr = new string[n];
                if (n <= 0)
                {
                    throw new Exception(" invalid size ");
                }

                //loop to read names from usesr
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(" Enter name : " + (i + 1));
                    arr[i] = Console.ReadLine();

                }
                Console.WriteLine("Names before sort :");
                print(arr);
                Task sorttask = Task.Run(() => selectionsort(arr));
                Console.WriteLine(" Enter target (name to found this index)");
                string target = Console.ReadLine();
                int v = Binarysearch(arr, target);


                
                Task searchtask = Task.Run(() => Binarysearch(arr, target));
                Console.WriteLine("Names after sort :");
                print(arr);
               

                
                Console.WriteLine(" index " + v);

            }

            catch (Exception )
            {
                throw new Exception(" invalid Input");
            }
        }
        // sorting names by selection sort Algorithm
        static void selectionsort(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min].CompareTo(arr[j]) > 0)
                    {
                        min = j;
                    }
                }
                string temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
        // print All items in Array
        static void print(string[] arr)
        {
            foreach (string n in arr)
            {
                Console.Write(" " + n);
            }
            Console.WriteLine();
        }
        // search a target by binary search Algorithm

        static int Binarysearch(string[] arr, string target)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l <= r)
            {
                int mid = l + r / 2;
                if (target == arr[mid])
                {
                    return mid;

                }
                else if (target.CompareTo(arr[mid]) > 0)
                {
                    l = mid + 1;
                }
                else if (target.CompareTo(arr[mid]) < 0)
                {
                    r = mid - 1;
                }
            }
            return -1;

        }


    }
}
