using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            // int a = 10;//
            //int b = 6;//

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("pilih menu calculator ");
            Console.WriteLine();
            Console.WriteLine(" 1. penambahan\n 2 pengurangan\n 3 perkalian\n 4 pembagian");
            Console.WriteLine();
            Console.WriteLine("inputkan nomor[1-4]");
            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1 )
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console .ReadLine 
            Console.WriteLine("hasil penambahan " + a + " + " + b + "=" + penambahan(a, b));
            }

            Console.Write
            Console.WriteLine("hasil penambahan " + a + " + " + b + "=" + penambahan(a, b));
            Console.WriteLine("hasil pengurangan  {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2} ", a, b, pembagian(a, b));

            Console.WriteLine("\n tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
            static int penambahan(int a, int b)
        {
            return a + b;
        }

            static int pengurangan(int a, int b)
        {
            return a - b;
        }

            static int perkalian(int a, int b)
            {
                return a * b;
            }

            static int pembagian(int a, int b)
            {
                return a / b; 
            }
        }
}
   