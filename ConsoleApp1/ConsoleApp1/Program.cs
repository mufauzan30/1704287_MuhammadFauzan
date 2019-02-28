using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //output tanpa perpindahan baris
            Console.Write("Wilujeng Enjing");
            Console.Write("Mahasiswa Tunas Bangsa");

            //output dengan perpindahan baris
            Console.WriteLine();
            Console.WriteLine("Computer Science ");
            Console.WriteLine("FPMIPA UPI");

            //menunggu sesaat
            //Console.ReadLine();

            //deklarasi var
            string tujuan;
            double jumlah_penumpang=0;
            double tarif_dasar;
            bool punya_member;
            double total_tarif;
            double dewasa;
            double anak;

            //input output
            Console.WriteLine();
            Console.WriteLine("Aritmatika Sederhana");
            Console.WriteLine("====================");

            Console.Write("Masukkan Tujuan Wisata : ");
            tujuan = Console.ReadLine();

            Console.Write("Masukkan Jumlah Penumpang dewasa : ");
            jumlah_penumpang = jumlah_penumpang + Convert.ToInt16(Console.ReadLine());

            Console.Write("Masukkan Jumlah Penumpang anak : ");
            jumlah_penumpang = jumlah_penumpang + (Convert.ToDouble(Console.ReadLine()) * 0.5);


            Console.Write("Masukkan Tarif Dasar Perorang: ");
            tarif_dasar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Jenis Penumpang [1]Member [2]Umum: ");
            punya_member = (Convert.ToInt16(Console.ReadLine())==1);

            //potongan untuk member sebesar 20%

            if (punya_member)
            {
                total_tarif = tarif_dasar * jumlah_penumpang * 80 / 100 ;
            }
            else
            {
                total_tarif = tarif_dasar * jumlah_penumpang;
            }

            Console.WriteLine("Total Tarif Rp. {0}", total_tarif);

            //menunggu sesaat
            Console.ReadLine();

        }
    }
}
