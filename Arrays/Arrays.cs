using System;
using System.Linq;

namespace Arrays
{
    class Aray
    {
        //Maximum Element:
        public void Max()
        {
            int[] arr1 = { 10, 20, 5, 15, 30 };
            int max = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine("Maximum element in the array: " + max);
        }
        //Average:
        public void Average() 
        {
            int[] randomNumbers = new int[5];
            int s = 0;
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomNumbers[i] = random.Next(10, 50);
            }
            foreach (int num in randomNumbers)
            {
                Console.Write(num + " ");
                s += num;
            }
            double average = (double) s / randomNumbers.Length;
            Console.WriteLine("\n Average:" + average);
        }
        //Store:
        public void Store()
        {
            int[] elements = new int[10];
            Random random = new Random();
            for(int i = 0; i<10; i++)
            {
                elements[i] = random.Next(1, 10);
            }
            foreach(int num in elements)
            {
                Console.Write(num + " ");
            }
        }
        //Reverse:
        public void Reverse()
        {
            int[] elements = new int[3];
            elements[0] = 2;
            elements[1] = 5;
            elements[2] = 7;
            Console.Write("The values store into an array: ");
            foreach (int num in elements)
            {
               Console.Write(num +" ");
            }
            Console.Write("\n Reversed array: ");
            for (int i = (elements.Length) - 1; i >= 0; i--)
            {
                Console.Write(elements[i] + " ");
            }
        }
        //Sum:
        public void Sum()
        {
            int[] elements=new int[3] { 2,5,8 };
            int sum = 0;
            foreach (int num in elements)
            {
                sum += num;
            }
            Console.WriteLine("Sum of array elemets: "+sum);
        }
        //Copy:
        public void Copy()
        {
            int[] a = { 15,10,12};
            int[] b = new int[a.Length];
            Console.Write("First array:");
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
            Console.Write("\nSecond array:");
            for (int i=0; i<a.Length; i++)
            {
                b[i] = a[i];
            }
            foreach(int i in b)
            {
                Console.Write(i +" ");
            }
        }
        //Duplicate:
       public void Count()
       {
            int[] count = { 5, 1, 1, 5, 6 };
            Console.Write("Duplicate elements:");
            for (int i=0; i<count.Length; i++)
            {
                for (int j=i+1;j<count.Length;j++)
                {
                   if (count[i] == count[j])
                    {
                        Console.Write(count[i]+" ");
                        break;
                    }
                }
            }
        }
        //Unique:
        public void Count1()
        {
            int[] count = { 5, 1, 1, 5, 6 };
            var unique = count.Distinct();
            Console.Write("\nUnique elements:" );
            foreach (int i in unique)
            {
                Console.Write(i+" ");
            }
        }
        //Merge:
        public void Merge()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3 };
            int[] c = a.Concat(b).OrderBy(x => x).ToArray();
            Console.Write("Merged elements:");
            foreach (int i in c)
            {
                Console.Write(i+" ");
            }
        }
        //Sort:
        public void Sort()
        {
            int[] arr = { 5, 8, 9, 25, 0, 7 };
            Array.Sort(arr);
            Console.WriteLine("Sorted Elements:");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
