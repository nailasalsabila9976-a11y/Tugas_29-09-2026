using System;
namespace Tugas
{
    class Home
    {
        static void Main(string[] args)
        {
            bool ulang = true;
            while (ulang)
            {
                Menu me = new Menu();
                me.menuUtama();

                int pilihan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(pilihan);

                if (pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("MENU ITS");
                    Console.WriteLine("1. Cek Jalur Prestasi");
                    Console.WriteLine("2. Cek Jalur UTBK");
                    Console.Write("Pilih jalur seleksi yang mau dicek: ");
                    int pilihanJalur = Convert.ToInt32(Console.ReadLine());


                    if (pilihanJalur == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("JALUR PRESTASI");

                        Console.Write("Masukkan nilai Matematika (a): ");
                        int nilaiA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Masukkan nilai Bahasa Inggris (b): ");
                        int nilaiB = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Masukkan nilai Mapel Pilihan (c): ");
                        int nilaiC = Convert.ToInt32(Console.ReadLine());

                        int totalNilai = ITS.jalurPrestasi(nilaiA, nilaiB, nilaiC);
                        Console.WriteLine("Total Nilai Anda: " + totalNilai);

                        if (nilaiA > 100 || nilaiB > 100 || nilaiC > 100 || nilaiA < 0 || nilaiB < 0 || nilaiC < 0)
                        {
                            Console.WriteLine("Nilai yang diinputkan salah, maksimal adalah 100");
                        }
                        else
                        {
                            if (totalNilai >= 280)
                            {
                                Console.WriteLine("Lulus");
                            }
                            else
                            {
                                Console.WriteLine("Tidak Lulus");
                            }
                        }

                        Console.WriteLine("Tekan Enter untuk kembali...");
                        Console.ReadLine();
                    }
                    else if (pilihanJalur == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("JALUR UTBK");

                        Console.Write("Masukkan nilai UTBK (a): ");
                        int nilaiA = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Masukkan nilai TKA (b): ");
                        int nilaiB = Convert.ToInt32(Console.ReadLine());


                        double totalUTBK = ITS.jalurUTBK(nilaiA, nilaiB);

                        Console.WriteLine("Total Nilai UTBK Anda: " + totalUTBK);

                        if (nilaiA < 600 || nilaiB < 280)
                        {
                            Console.WriteLine("Nilai yang diinputkan salah");
                        }
                        else
                        {
                            Console.WriteLine("Total Nilai UTBK: " + totalUTBK);
                            Console.WriteLine("Lulus");
                        }
                        Console.WriteLine("Tekan Enter untuk kembali...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Pilihan jalur tidak tersedia");
                    }
                }
            }
        }
    }
    class Menu
    {
        public void menuUtama()
        {
            Console.Clear();

            Console.WriteLine("Silakan pilih menu yang diinginkan");
            Console.WriteLine("1 Menu Kasir");
            Console.WriteLine("2 Menu Perhitungan Masuk ITS");
            Console.WriteLine("Ketik 0 untuk kembali");
        }
        public void menuKasir()
        {
            Console.Clear();

            Console.WriteLine("Selamat datang pada sub Menu Kasir");
        }
        public void menuPerhitunganMasukITS()
        {
            Console.Clear();

            Console.WriteLine("Cek peluang Anda masuk ke ITS");

            Console.WriteLine("Pilih jalur yang ingin Anda periksa");
            Console.WriteLine("1 Jalur Prestasi");
            Console.WriteLine("2 Jalur UTBK");
        }
    }
    class Kasir
    {
        public void belanja()
        {

        }
    }
    class ITS
    {
        public static int jalurPrestasi(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double jalurUTBK(int a, int b)
        {
            return a + (b * 0.30);
        }
    }
}