using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Menghitung_Gaji_Karyawan
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }        
             

        //method inheritance
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
