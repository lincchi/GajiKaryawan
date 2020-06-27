using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;


namespace Menghitung_Gaji_Karyawan
{
    class Program
    {
               
        static void Main(string[] args)
        {            
            //MEMBUAT LIST
            KaryawanTetap[] tetap = new KaryawanTetap[10];
            KaryawanHarian[] harian = new KaryawanHarian[10];
            Sales[] sales = new Sales[10];

            List<Karyawan> listkaryawan = new List<Karyawan>();

            int menu;

            do
            {
                mainmenu:
                Console.Title = "Aplikasi Gaji Karyawan";

                Console.WriteLine("Aplikasi Gaji Karyawan");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Pilihan Menu : ");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("---------------------------------");
                Console.WriteLine();

                Console.Write("Masukan Pilihan : ");              
                menu = Convert.ToInt32(Console.ReadLine());

                int i = 0;
                int u = 0;
                int y = 0;
                switch (menu)
                {
                    case 1:                        
                        Console.Clear();
                        int plh1;

                        do
                        {
                            Console.WriteLine("Tambah Karyawan");
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Pilih Karyawan :\n1 Tetap \n2 Harian \n3 Sales \n4 Kembali ke Menu");
                            Console.WriteLine("---------------------------------");
                            Console.Write("Masukan Pilihan : ");

                            plh1 = Convert.ToInt32(Console.ReadLine());
                            switch (plh1)
                            {
                                //TAMBAH KARYAWAN
                                case 1:                                    
                                    i++;                                    
                                    tetap[i] = new KaryawanTetap();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Tetap \n ");
                                    Console.Write("NIk : ");
                                    tetap[i].Nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    tetap[i].Nama = Console.ReadLine();
                                    Console.Write("Gaji Bulanan : ");
                                    tetap[i].GajiBulanan = int.Parse(Console.ReadLine());

                                    //Menambahkan ke list
                                    listkaryawan.Add(tetap[i]);
                                    Console.WriteLine("\n");
                                    break;

                                case 2:
                                    u++;                                    
                                    harian[u] = new KaryawanHarian();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Harian \n ");
                                    Console.Write("NIk : ");
                                    harian[u].Nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    harian[u].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Jam Kerja : ");
                                    harian[u].JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Upah Per Jam : ");
                                    harian[u].UpahPerJam = Convert.ToDouble(Console.ReadLine());

                                    //Menambahkan ke list
                                    listkaryawan.Add(harian[u]);
                                    Console.WriteLine("\n");
                                    break;

                                case 3:                                    
                                    y++;                                    
                                    sales[y] = new Sales();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Sales \n ");
                                    Console.Write("NIk : ");
                                    sales[y].Nik = Console.ReadLine();
                                    Console.Write("Nama : ");
                                    sales[y].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Penjualan : ");
                                    sales[y].JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Komisi : ");
                                    sales[y].Komisi = Convert.ToDouble(Console.ReadLine());

                                    //Menambahkan ke list
                                    listkaryawan.Add(sales[y]);
                                    Console.WriteLine("\n");
                                    break;


                                case 4:
                                    Console.Clear();
                                    goto mainmenu;
                            }

                        }
                        while (plh1 != 4);
                        Console.Clear();
                        break;
                        
                    //HAPUS KARYAWAN
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Karyawan");
                        Console.WriteLine("---------------------------------");
                        Console.Write("NIK : ");
                        string nikhapus = Console.ReadLine();
                        
                        if (listkaryawan.Any(n => n.Nik == nikhapus))
                        {
                            listkaryawan.RemoveAll(x => x.Nik == nikhapus);
                            Console.WriteLine("Data karyawan berhasil dihapus\n\n");
                        }
                        else
                        {
                            Console.WriteLine("Data tidak ditemukan\n\n");
                        }

                        break;

                         

                    //TAMPILKAN DATA
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tampilkan Data");
                        Console.WriteLine("---------------------------------");
                        int nourut = 0;
                        
                            foreach (Karyawan karyawan in listkaryawan)
                            {
                                nourut++;
                                Console.Write("{0}. NIK : {1} | Nama: {2} | Gaji: {3:N0} | ",
                                    nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                                if (karyawan is KaryawanTetap)
                                {
                                    Console.Write("Karyawan Tetap \n");
                                }

                                else if (karyawan is KaryawanHarian)
                                {
                                    Console.Write("Karyawan Harian \n");
                                }

                                else if (karyawan is Sales)
                                {
                                    Console.Write("Sales \n");
                                }
                            }
                            Console.WriteLine("\n");
                        
                        break;

                    //KELUAR
                    case 4:                        
                        Environment.Exit(0);                        
                        break;

                   
                    default:
                        Console.WriteLine("Yang anda Input Salah");
                        break;
                }

            }

            while (menu != 4);
            Environment.Exit(0);
        }

    }
    
}