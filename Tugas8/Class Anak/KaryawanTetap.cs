using System;
using System.Collections.Generic;
using System.Text;
using Tugas_8.Class_Induk;

namespace Tugas_8.Class_Anak
{
    public class KaryawanTetap : Karyawan
    {
        public string Nik1;

        public string Nama1;
        public double GajiBulanan;

        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}
