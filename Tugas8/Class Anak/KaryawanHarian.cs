using System;
using System.Collections.Generic;
using System.Text;
using Tugas_8.Class_Induk;

namespace Tugas_8.Class_Anak
{
    public class KaryawanHarian : Karyawan
    {
        public string Nik1;
        public string Nama1;
        public double UpahPerJam;
        public double JumlahJamKerja;

        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
