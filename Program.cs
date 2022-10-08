using System;

namespace metodlar
{
    class Program
    {
        static void Main(String[] args)
        {
            int a = 2;
            int b = 3;
            System.Console.WriteLine(a+b);

            int sonuc = topla(a,b);
            System.Console.WriteLine(sonuc);

            metodlar ornek = new metodlar();
            ornek.ekranaYazdır(Convert.ToString(sonuc));

        }

        static int topla(int deger1 , int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class  metodlar
    {
        public void ekranaYazdır(String veri)
        {
            System.Console.WriteLine(veri);
        }
    }
    
        
    
}
