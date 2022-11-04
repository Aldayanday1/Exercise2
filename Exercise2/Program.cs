using System;

namespace QuickShort
{
    class Program
    {

        private int[] arr = new int[70];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 70)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 70 element \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, MF;
            if (low > high)
                return;

            i = low + 1;
            MF = high;
            pivot = arr[low];
            while (i <= MF)
            {

                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((arr[MF] > pivot) && (MF >= low))
                {
                    MF--;
                    cmp_count++;
                }
                cmp_count++;
                if (i < MF)
                {

                    swap(i, MF);
                    mov_count++;
                }
            }

            if (low < MF)
            {

                swap(low, MF);
                mov_count++;
            }

            q_sort(low, MF - 1);

            q_sort(MF + 1, high);

        }
        void display()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("-----------------------");
            for (int MF = 0; MF < n; MF++)
            {
                Console.WriteLine(arr[MF]);
            }
            Console.WriteLine("\nNumber of data comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movements:" + mov_count);
        }
        int getSize()
        {
            return (n);
        }

    }
}