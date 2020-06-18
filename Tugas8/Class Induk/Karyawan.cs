using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_8.Class_Induk
{
    public abstract class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public abstract double Gaji();
    }
}
