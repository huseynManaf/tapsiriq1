namespace tapsiriq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin:");
            int e = int.Parse(Console.ReadLine());
            

            int a, b, c, d;
            a =  123046 % 100000 / 10000;
            b = 123046 % 10/10;
            c = 123046 % 10;
            d = a*a+b*b+c*c;
            Console.WriteLine(d);



        }
    }
}