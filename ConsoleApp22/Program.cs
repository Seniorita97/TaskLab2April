using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {

        yenidendaxilet:
         Console.WriteLine("EDED DAXIL EDIN");

            bool check = int.TryParse(Console.ReadLine(), out int num);
            if (!check || num <999) goto yenidendaxilet;


            NumResult(num);
        }

        public static void NumResult(int num1)
        {
          
            
           

                int count = 0;
                int temp = num1;

                
                while (temp > 0)
                {
                    temp /= 10;
                    count++;
                }

                int[] arr = new int[count];

            for ( int i = 0; i < arr.Length; i++)
            {
                arr[i] = num1 % 10;
                num1 /= 10;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        

    }
}
