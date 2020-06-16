using System;
using System.Collections.Generic;
using System.Linq;

namespace Menghitung_Gaji_Karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat object semua karyawan
            KaryawanTetap tetap = new KaryawanTetap();
            tetap.Nik = "123-234-345";
            tetap.Nama = "Michael Suyama";
            tetap.GajiBulanan = 4000000;

            KaryawanHarian harian = new KaryawanHarian();
            harian.Nik = "123-321-213";
            harian.Nama = "Laura Callahan";
            harian.JumlahJamKerja = 8;
            harian.UpahPerJam = 13000;

            Sales sales = new Sales();
            sales.Nik = "789-987-798";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;


            //objek class collection (class induk)
            List<Karyawan> listkaryawan = new List<Karyawan>();
            listkaryawan.Add(tetap);
            listkaryawan.Add(harian);
            listkaryawan.Add(sales);

            int nourut = 1;

            foreach(Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. NIK : {1}, Nama: {2}, Gaji: {3:N0}",
                    nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nourut++;
            }

            Console.ReadKey();
        }
    }
}
