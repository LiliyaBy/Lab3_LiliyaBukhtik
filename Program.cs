using System;
using System.Net.Mail;

namespace Lab3_LiliyaBukhtik
{


    class Scanner
    {
        int[] intarray = { 1, 2, 3, 13, 12, 5, 9, 0 };

        public void CheckEntry(int k)
        { int i = 0; bool flag1= false;
            do
                if (intarray[i] == k) flag1=true;
                else i++;
            while ((i < intarray.Length)&&(flag1==false));
            if (flag1==true) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }

    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //0
            for (int i = 1; i < 99; i ++)
             {
                 if ((double)i%2!=0)
                 Console.Write(i+" ");
             }
             Console.WriteLine();
             //1
             int num = 5;
             while (num > 0)
             {
                 Console.Write( num-- +" ");
             }
             Console.WriteLine();
             //2
             try
             {
                 Console.WriteLine("Enter the number");
                 int number = Convert.ToInt32(Console.ReadLine());
                 if (number<=0) Console.WriteLine("Error");
                 else { 
                 int recursion(int n) 
                 {   if (n == 1) return 1;
                     return n + recursion(n - 1);
                 }
                 int sum = recursion(number);
                 Console.WriteLine($"Sum = {sum}");
                 }
             }
             catch 
             { Console.WriteLine("Error"); } 
            //3
            Console.WriteLine("Enter a number to search");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Scanner num2 = new Scanner();
            num2.CheckEntry(num3);
            //4 */
            Console.WriteLine("Enter the length of the array");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0) Console.WriteLine("Error");
            int[] ranarray = new int [num1];
            for (int i =0; i<ranarray.Length;i++) 
            { 
                Random rnd = new Random();
                ranarray[i]=rnd.Next(1, 999);
                Console.Write(ranarray[i]+" ");

            }
            int max = ranarray[0], min=ranarray[0], average=0; int val1 = ranarray.Length;

            for (int i = 0; i < ranarray.Length-1; i++)
            {
                
                if (ranarray[i]>max)
                    max = ranarray[i];
                if (ranarray[i]<min)
                    min = ranarray[i];
                
            }
            
            for (int i = 0; i < ranarray.Length; i++)
                average = average + ranarray[i];

            Console.WriteLine("\nMaximum array element " + max + " ");
            Console.WriteLine("Minimum array element " + min);
            Console.WriteLine("Average value of array elements " + (double)average/ ranarray.Length);
            //5
            int[] line1 = { 1, 3, 5, 7, 9 };
            int[] line2 = { 2, 4, 6, 8, 10 };

            foreach (int l1 in line1)
                Console.Write(l1+" ");
            Console.WriteLine();
            foreach (int l2 in line2)
                Console.Write(l2+" ");
            Console.WriteLine();
            //6
            Console.WriteLine("Febonachi");
            void CalculFebonNum()
            {
                int[] number = new int [11];

                number[0] = 0; number[1] = 1;
                for (int i = 2; i < number.Length; i++)
                    number[i] = number[i - 1] + number[i - 2];
                foreach (int n1 in number)
                    Console.Write(n1 + " ");
                Console.WriteLine();

            }

            CalculFebonNum();
            //7

            void ReplaceValues() 
            { 
            Console.WriteLine("Enter the size of the array");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num4];
               
                try
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine("Enter the value of the {0} element", i);
                        int val = Convert.ToInt32(Console.ReadLine());
                        numbers[i] = val;
                    }
                }
                catch {Console.WriteLine("Ошибкен" ); }

                Console.WriteLine("The result is an array");
                foreach (int n1 in numbers)
                    Console.Write(n1 + " ");


                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i % 2 != 0)
                        numbers[i] = 0;
                }

                Console.WriteLine();
                Console.WriteLine("Array after replacing elements with odd index");
                foreach (int n1 in numbers)
                    Console.Write( n1 + " ");
            }
            ReplaceValues();

            Console.WriteLine("\n"); 

            //8
            string[] names = { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Alice" };

                foreach (string name in names)
                {
                Array.Sort(names);
                Console.Write(name + " ");
                }

            Console.WriteLine("\n");

        }
    }
}