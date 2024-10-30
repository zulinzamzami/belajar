using System;

namespace ZulinPSAT2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====PSAT 2024-19048-Zulin Nafisah Zam Zami======");
            Console.WriteLine("Selamat datang di Rumah Sakit Sehat Selalu");
            Console.WriteLine("=================================================");
            Console.WriteLine("===========19048-Zulin Nafisah Zam Zami==========");
            Console.WriteLine("=================================================");
            

            // Input data pasien
            Console.Write("Nama Pasien: ");
            string namaPasien = Console.ReadLine();

            Console.Write("Alamat Pasien: ");
            string alamatPasien = Console.ReadLine();

            Console.Write("Jenis Kelamin (L/P): ");
            char jenisKelamin = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Lama Inap (hari): ");
            int lamaInap = int.Parse(Console.ReadLine());

            // Input jenis kamar
            Console.WriteLine("\nJenis Kamar:");
            Console.WriteLine("1. Kelas I (100000)");
            Console.WriteLine("2. Kelas II (200000)");
            Console.WriteLine("3. Kelas III (300000)");
            Console.WriteLine("4. Kelas VIP (500000)");
            Console.WriteLine("5. Kelas VVIP (600000)");
            Console.Write("Pilih Jenis Kamar (1-5): ");
            int pilihanKamar = int.Parse(Console.ReadLine());

            // Input jenis dokter
            Console.WriteLine("\nJenis Dokter:");
            Console.WriteLine("1. Dokter Anak (50000)");
            Console.WriteLine("2. Dokter Penyakit Dalam (60000)");
            Console.WriteLine("3. Dokter THT (70000)");
            Console.WriteLine("4. Dokter Bedah (90000)");
            Console.WriteLine("5. Dokter Umum (40000)");
            Console.Write("Pilih Jenis Dokter (1-5): ");
            int pilihanDokter = int.Parse(Console.ReadLine());

            // Hitung total bayar
            int tarifKamar = 0;
            switch (pilihanKamar)
            {
                case 1:
                    tarifKamar = 100000;
                    break;
                case 2:
                    tarifKamar = 200000;
                    break;
                case 3:
                    tarifKamar = 300000;
                    break;
                case 4:
                    tarifKamar = 500000;
                    break;
                case 5:
                    tarifKamar = 600000;
                    break;
                default:
                    Console.WriteLine("Pilihan kamar tidak valid.");
                    return;
            }

            int tarifDokter = 0;
            switch (pilihanDokter)
            {
                case 1:
                    tarifDokter = 50000;
                    break;
                case 2:
                    tarifDokter = 60000;
                    break;
                case 3:
                    tarifDokter = 70000;
                    break;
                case 4:
                    tarifDokter = 90000;
                    break;
                case 5:
                    tarifDokter = 40000;
                    break;
                default:
                    Console.WriteLine("Pilihan dokter tidak valid.");
                    return;
            }

            int totalBayar = (tarifKamar + tarifDokter) * lamaInap;

            // Output total bayar
            Console.WriteLine("\nDetail Tagihan:");
            Console.WriteLine("Nama Pasien: " + namaPasien);
            Console.WriteLine("Alamat Pasien: " + alamatPasien);
            Console.WriteLine("Jenis Kelamin: " + (jenisKelamin == 'L' ? "Laki-laki" : "Perempuan"));
            Console.WriteLine("Lama Inap: " + lamaInap + " hari");
            Console.WriteLine("Jenis Kamar: " + GetJenisKamar(pilihanKamar));
            Console.WriteLine("Jenis Dokter: " + GetJenisDokter(pilihanDokter));
            Console.WriteLine("Total Bayar: Rp " + totalBayar);
        }

        static string GetJenisKamar(int pilihan)
        {
            switch (pilihan)
            {
                case 1:
                    return "Kelas I";
                case 2:
                    return "Kelas II";
                case 3:
                    return "Kelas III";
                case 4:
                    return "Kelas VIP";
                case 5:
                    return "Kelas VVIP";
                default:
                    return "Tidak Valid";
            }
        }

        static string GetJenisDokter(int pilihan)
        {
            switch (pilihan)
            {
                case 1:
                    return "Dokter Anak";
                case 2:
                    return "Dokter Penyakit Dalam";
                case 3:
                    return "Dokter THT";
                case 4:
                    return "Dokter Bedah";
                case 5:
                    return "Dokter Umum";
                default:
                    return "Tidak Valid";
            }
        }
    }
}

