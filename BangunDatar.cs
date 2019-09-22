using System;

namespace QUIZ09092019
{
    2 references
    class BangunDatar
    {
        1 references
        public void LuasPersegi()
        {
            Int sisi;
            Console.Write("masukkan nilai sisi : ");
            sisi= Convert.ToInt32(Console.ReadLine());

            Int luas = sisi * sisi;

            Console.WriteLine("Luas persegi adalah "+luas);
            
        }

        1 reference
        public void LuasSegitiga()
        {
            Int tinggi, alas;
            Console.Write("masukkan nilai tinggi : ");
            tinggi= Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai alas");
            alas= Convert.ToInt32(Console.ReadLine());

            Int luas= alas * tinggi;

            Console.WriteLine("Luas segitiga adalah "+luas);
        }

        1 reference
        public void LuasLingkaran()
        {
            const double phi = 3.14;
            double luas;
            Int r;

            Console.Write("Masukkan panjang jari-jari lingkaran:");
            r = Convert.ToInt32(Console.ReadLine());
            luas = phi * r * r;
            Console.WriteLine("Luas Lingkaran adalah "+luas);
        }
        0 references
        public void BangunRuang()
        {
            BangunRuang obj=new BangunRuang();

            obj.VolumeBalok();
            Console.WriteLine("--------------------------------");

            obj.VolumeKubus();
        }
    }
}