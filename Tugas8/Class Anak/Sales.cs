using System;
using System.Collections.Generic;
using System.Text;
using Tugas_8.Class_Induk;

namespace Tugas_8.Class_Anak
{
    public class Sales : Karyawan
    {
        public string Nik1;
        public string Nama1;
        public double JumlahPenjualan;
        public double Komisi;

        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
