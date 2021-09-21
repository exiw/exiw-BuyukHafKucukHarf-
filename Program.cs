using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukHafKucukHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Lütfen kelimeyi giriniz");
            string kelime = Console.ReadLine();
            string buyukharf = kelime.ToUpper();
            string kucukharf = kelime.ToLower();
            Console.WriteLine(" Büyük Harf :" + buyukharf);
            Console.WriteLine(" Küçük Harf :" + kucukharf);
            Console.ReadKey();
        }
    }
}
