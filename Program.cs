using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünyalı, gezegenler arası hacim farkı bulma programına hoşgeldiniz:");
            System.Console.WriteLine("Samanyolu galaksisinden istediğiniz, 2 adet gezegeni seçiniz:");
System.Console.WriteLine("1- Merkür 2-Venüs 3-Dünya 4-Mars 5-Jupiter 6-Satürn 7-Uranus 8-Neptün");
string[] gezegenler = {"Merkür", "Venüs", "Dünya", "Mars", "Jupiter", "Satürn", "Uranus", "Neptün"};
Int32 x =Int32.Parse(Console.ReadLine()); System.Console.WriteLine(gezegenler[x] + "i seçtiniz.");
Int32 y =Int32.Parse(Console.ReadLine()); System.Console.WriteLine(gezegenler[y] + "i seçtiniz.");
string isim1= gezegenler[x];
string isim2= gezegenler[y];
System.Console.WriteLine("1. gezegenin yarıçapını km cinsinden yazınız:");
Int32 a =Int32.Parse(Console.ReadLine());
System.Console.WriteLine("2. gezegenin yarıçapını km cinsinden yazınız:");
Int32 b =Int32.Parse(Console.ReadLine());

double gezegenhacmi1=(4/3)*Math.PI*Math.Pow(a,3);
double gezegenhacmi2=(4/3)*Math.PI*Math.Pow(b,3);
double c=Math.Abs(gezegenhacmi2 - gezegenhacmi1);

System.Console.WriteLine("İki gezegen arası hacim farkı:" + c + "km^3'tür.");

        }
    }
}
