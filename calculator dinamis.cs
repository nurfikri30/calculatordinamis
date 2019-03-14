using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator";

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine(" 1.Penambahan\n 2.Pengurangan\n 3.Perkalian\n 4.Pembagian");
            Console.WriteLine("Inputkan Nomor Menu [1...4] : ");
            int c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + penambahan(a, b));
                Console.WriteLine("tekan Enter Untuk Keluar");
                Console.ReadKey();
            }
            else if (c == 2)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan" + a + "-" + b + "=" + pengurangan(a, b));
                Console.WriteLine("tekan Enter Untuk Keluar");
                Console.ReadKey();
            }
            else if (c == 3)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian" + a + "*" + b + "=" + perkalian(a, b));
                Console.WriteLine("tekan Enter Untuk Keluar");
                Console.ReadKey();
            }
            else if (c == 4)
            {
                Console.WriteLine("Inputkan Nilai Pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inputkan Nilai Kedua : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian" + a + "/" + b + "=" + pembagian(a, b));
                Console.WriteLine("tekan Enter Untuk Keluar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Inputan Salah ");
                Console.WriteLine("tekan Enter Untuk Keluar");
                Console.ReadKey();


            }
              int penambahan(int a, int b)
            {
                return a + b;

            }
             int pengurangan(int a, int b)
            {
                return a - b;

            }
             int perkalian(int a, int b)
            {
                return a * b;

            }
             int pembagian(int a, int b)
            {
                return a / b;

            }
        }
    }
}
