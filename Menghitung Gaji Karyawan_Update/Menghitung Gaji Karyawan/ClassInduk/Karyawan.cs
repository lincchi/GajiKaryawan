using System;
using System.Collections.Generic;
using System.Text;

namespace Menghitung_Gaji_Karyawan
{
    abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }

        //method
        public abstract double Gaji();
    }
}
