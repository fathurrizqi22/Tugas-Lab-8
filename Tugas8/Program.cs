using System;
using System.Collections.Generic;
using Tugas_8.Class_Anak;
using Tugas_8.Class_Induk;


namespace Tugas_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // objek untuk semua karyawan


            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-456-001";
            karyawanTetap.Nama = "Ainz-sama";
            karyawanTetap.GajiBulanan = 3000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-456-002";
            karyawanHarian.Nama = "Albedo";
            karyawanHarian.JumlahJamKerja = 7;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "123-456-003";
            sales.Nama = "Tokikaze";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 32000;

            // objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut,
                    karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
