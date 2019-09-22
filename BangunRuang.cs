using System;

namespace QUIZ09092019
{
    2 references
    class BangunRuang
    {
        1 reference
        public void VolumeBalok()
        {
            Int panjang, lebar, tinggi, Volume;

            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");

            Console.Write("Masukkan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            Volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok adalah"+Volume);
        }
        1 reference
        public void VolumeKubus()
        {
            Int sisi;

            Console.WriteLine("Menghitung Volume Kubus");

            Console.Write("Masukkan nilai sisi :");
            sisi = Convert.ToInt32(Console.ReadLine());

            Int volume = sisi * sisi * sisi ;

            Console.WriteLine("Volume Kubus adalah"+volume);
        }
    }
}