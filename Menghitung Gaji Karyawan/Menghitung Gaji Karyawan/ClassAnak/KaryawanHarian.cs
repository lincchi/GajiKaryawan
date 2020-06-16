using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Menghitung_Gaji_Karyawan
{
    class KaryawanHarian : Karyawan
    {
        
        public double UpahPerJam { get; set; }
        public double JumlahJamKerja { get; set; }

        //method interface
        public override double Gaji()
        {
            return (UpahPerJam * JumlahJamKerja);
        }
    }
}
