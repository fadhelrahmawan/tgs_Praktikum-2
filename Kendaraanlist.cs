using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1184064
{
    class Kendaraanlist
    {
        static void Main(String[] args)
        {
            List: // label
            Console.Clear();
            Console.WriteLine("|---------Garasi Otomotif--------|");
            Console.WriteLine("|1.Daftar Harga Kendaraan        |");
            Console.WriteLine("|2.Pesan Kendaraan               |");
            Console.WriteLine("|3.Keluar                        |");
            Console.WriteLine("|--------------------------------|");
            Console.Write("> Pilih Kendaraan : ");
            int PilihanKendaraan = int.Parse(Console.ReadLine());
            if (PilihanKendaraan != 1 && PilihanKendaraan != 2 && PilihanKendaraan != 3)
            {
                Console.WriteLine("Pilihan Tidak Tersedia !");
                Console.WriteLine(" ");
                Console.WriteLine("Tekan ENTER Untuk memilih ulang");
                Console.ReadKey(true);
                goto List;
            }

            switch (PilihanKendaraan)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("|------------------- Harga -------------------|");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("|  Daftar Makanan     |     Harga             |");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine("| 1. Motor            | Rp. 12000000          |");
                    Console.WriteLine("| 2. Mobil            | Rp. 250000000         |");
                    Console.WriteLine("|---------------------------------------------|");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Tekan Enter Untuk Kembali Ke menu... ");
                    Console.ReadKey(true);
                    goto List;
                    break;
                case 2:
                    INPUT:

                    Console.Clear();
                    Console.WriteLine("|-------- List Kendaraan ------|");
                    Console.WriteLine("| > Pilih Menu Makanan         |");
                    Console.WriteLine("|   [ 1. Motor        ]        |");
                    Console.WriteLine("|   [ 2. Mobil ]               |");
                    Console.WriteLine("|------------------------------|");
                    Console.Write("|> Pilih :  ");
                    int PilihanJenis = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    if (PilihanJenis != 1 && PilihanJenis != 2)
                    {
                        Console.WriteLine("Pilihan Tidak Tersedia !");
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan ENTER Untuk memilih ulang");
                        Console.ReadKey(true);
                        goto INPUT;
                    }
                    else if (PilihanJenis == 1)
                    {
                        Console.Write("|Nama\t\t: ");
                        string nama = (Console.ReadLine());
                        int beliMotor = 0;
                        Console.Write("|Beli Berapa\t: ");
                        beliMotor = Convert.ToInt16(Console.ReadLine());
                        Motor hargaNasgor = new Motor();
                        hargaNasgor.HargaMot(beliMotor);
                        hargaNasgor.output();
                        Console.WriteLine("|--------------------------------------|");
                        Console.WriteLine("|Tekan ENTER untuk kembali ke menu...");
                        Console.ReadKey(true);

                    }

                    if (PilihanJenis == 2)
                    {
                        Console.Write("|Nama\t\t: ");
                        string nama = (Console.ReadLine());
                        int beliMobil = 0;
                        Console.Write("|Beli Berapa\t: ");
                        beliMobil = Convert.ToInt16(Console.ReadLine());
                        Mobil hargaMie = new Mobil();
                        hargaMie.HargaMie(beliMobil);
                        hargaMie.output();
                        Console.WriteLine("|--------------------------------------|");
                        Console.WriteLine("|Tekan ENTER untuk kembali ke menu...");
                        Console.ReadKey(true);
                    }
                    goto List;
                    break;
                case 3:
                    return;
            }
        }
    }
}