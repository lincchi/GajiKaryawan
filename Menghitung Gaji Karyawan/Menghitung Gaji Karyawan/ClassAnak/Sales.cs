using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Menghitung_Gaji_Karyawan
{
    class Sales : Karyawan
    {        
        public int Komisi { get; set; }
        
        public double JumlahPenjualan { get; set; }

        //method interface
        public override double Gaji()
        {
            return (Komisi * JumlahPenjualan);
        }
    }
}
