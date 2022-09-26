using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace P2_1_1184061
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Angka Pertama dan Angka Kedua");
            int angkaPertama = int.Parse(Console.ReadLine());
            int angkaKedua = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Angka Pertama = " + angkaPertama);
            Console.WriteLine("Angka Kedua = " + angkaKedua);

            Console.WriteLine("");

            Console.Write(angkaPertama);
            Console.Write(" + ");
            Console.Write(angkaKedua + " = ");
            Console.WriteLine(angkaPertama + angkaKedua);

            Console.Write(angkaPertama);
            Console.Write(" - ");
            Console.Write(angkaKedua + " = ");
            Console.WriteLine(angkaPertama - angkaKedua);

            Console.Write(angkaPertama);
            Console.Write(" * ");
            Console.Write(angkaKedua + " = ");
            Console.WriteLine(angkaPertama * angkaKedua);

            Console.Write(angkaPertama);
            Console.Write(" / ");
            Console.Write(angkaKedua + " = ");
            Console.WriteLine(angkaPertama / angkaKedua);
        }
    }
}
