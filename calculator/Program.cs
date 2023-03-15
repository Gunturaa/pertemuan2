using System;

namespace percobaan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "===== Kalkulator =====";

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Silakan pilih operasi yang ingin Anda lakukan:");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");


                Console.Write("Silahkan Pilih Menu = ");
                string input = Console.ReadLine();
                

                Console.Write("Maaf Operasi yang dipilih tidak valid");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Masukkan nilai b:");
                int b = int.Parse(Console.ReadLine());

                int hasil = 0;

                if (input == "1")
                {
                    hasil = Penjumlahan(a, b);
                }
                else if (input == "2")
                {
                    hasil = Pengurangan(a, b);
                }
                else if (input == "3")
                {
                    hasil = Perkalian(a, b);
                }
                else if (input == "4")
                {
                    hasil = Pembagian(a, b);
                }
                else
                {
                    Console.WriteLine("Maaf Operasi yang dipilih tidak valid.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Hasil operasi: " + hasil);

                Console.WriteLine("Apakah Anda ingin melakukan operasi lagi? (y/n)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "n")
                {
                    isRunning = false;
                }
            }

            Console.WriteLine("\nTekan sembarang keyboard untuk keluar");
            Console.ReadKey();
        }

        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
