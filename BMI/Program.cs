using System;
namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo, Selamat Datang di Program Penghitung BMI.");
            Console.ReadLine();
            bool lanjut = true;

            while(lanjut)
            {
                CalculateBMI();
                Console.ReadLine();
                lanjut = pengulangan();
            }
            Console.WriteLine("Terima Kasih Telah Menggunakan Program Penghitungan BMI!");

        }

        public static void CalculateBMI()
        {
            try
            {
                Console.WriteLine("Masukan Berat Badan Anda (kg):");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Masukan Tinggi Badan Anda (m):");
                double height = Convert.ToDouble(Console.ReadLine());

                double bmi = weight / (height * height);
                Console.WriteLine($"BMI Anda adalah: {bmi:f2}");

                if (bmi < 18.5)
                {
                    Console.WriteLine("Berat Badan Kurang");
                }
                else if (18.5 <= bmi && bmi < 24.9)
                {
                    Console.WriteLine("Berat Badan Normal");
                }
                else if (25 <= bmi && bmi < 29.9)
                {
                    Console.WriteLine("Berat Badan Berlebih");
                }
                else
                {
                    Console.WriteLine("Obesitas");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input tidak valid. Pastikan Anda memasukkan angka.");
            }
        }

        static bool pengulangan()
        {
            Console.WriteLine("Apakah anda ingin menghitung BMI lagi? (y/n):");
            String Jawab = Console.ReadLine().Trim().ToLower();
            if (Jawab == "y") 
            {
                return true;
            } else if (Jawab == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Input invalid, program di matikan");
                return false;
            }
        }
    }
}