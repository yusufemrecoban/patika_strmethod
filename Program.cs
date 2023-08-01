using System;

namespace patika_strmehod
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="alp iyi insan";
            string degisken2="alp kötü bir insan";

            //Length;
            //string yapısının uzunluğunu ölçer
            Console.WriteLine(degisken.Length);

            //Concat;
            //ekleme işleminde kullanılır
            Console.WriteLine(String.Concat(degisken," mi acaba ",degisken2));

            //Compare,CompareTo;
            //iki stringi karşılaştırır
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains;
            //string içinde arama yapar
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("insan"));
            Console.WriteLine(degisken.StartsWith("alp hakkında :"));

            //IndexOf;
            //string içinde arama yapar
            Console.WriteLine(degisken.IndexOf("insan"));
            Console.WriteLine(degisken.IndexOf("insan",6));
            Console.WriteLine(degisken.LastIndexOf("insan"));

            //Insert;
            //string içine ekleme yapar
            Console.WriteLine(degisken.Insert(0,"çok "));

            //PadLerft,PadRight;
            //string içine boşluk ekleme yapar
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove;
            //string içinden silme yapar
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));
            
            //Replace;
            //string içinde değiştirme yapar
            Console.WriteLine(degisken.Replace(" alp "," yusuf "));
            Console.WriteLine(degisken.Replace(" ","_"));
            
            //Split;
            //string içinde ayırma yapar
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring;
            //string içinde bölme yapar
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));

            




            Console.ReadLine();
        }
    }
}