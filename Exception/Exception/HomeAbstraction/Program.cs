using System;

namespace HomeAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hisense hisense = new Hisense();
           Yoshiro yoshiro = new Yoshiro();
           Samsung samsung  = new Samsung();
           Lg lg = new Lg();
           Sony sony = new Sony();


            hisense.Name = "Hisense";
            hisense.Model = "CLV";
            Console.WriteLine("Name: " + hisense.Name);
            Console.WriteLine("Model: " + hisense.Model);
            hisense.Televisions();

            Console.WriteLine(" ");

            yoshiro.Name = "Yoshiro";
            yoshiro.Model = "ADL";
            Console.WriteLine("Name: " + yoshiro.Name);
            Console.WriteLine("Model: " + yoshiro.Model);
            yoshiro.Televisions();

            Console.WriteLine(" ");

            samsung.Name = "Samsung";
            samsung.Model = "CL54";
            Console.WriteLine("Name: " +  samsung.Name);
            Console.WriteLine("Model: " + samsung.Model);
            samsung.Televisions();

            Console.WriteLine(" ");

            lg.Name = "LG";
            lg.Model = "BR45A698";
            Console.WriteLine("Name: " + lg.Name);
            Console.WriteLine("Model: " + lg.Model);
            lg.Televisions();

            Console.WriteLine(" ");

            sony.Name = "SONY";
            sony.Model = "ALE5478";
            Console.WriteLine("Name: " + sony.Name);
            Console.WriteLine("Model: " + sony.Model);
            sony.Televisions();
        }
    }
}
