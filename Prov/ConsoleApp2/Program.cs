using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kod som man hade kunnat använda för att ge spelaren några saker att sälja till att börja med...
            //Man hade kunnat göra en 4loop för att skapa ett antal instanser av Antik klassen
            Random generator = new Random();
            int amountOfStarterBooks = generator.Next(1, 5);



            //Jag skapade en Antik instans som heter antique1 helt enkelt för att kolla att det fungerar och för att...
            //...skriva ut och använda några av metoderna i klassen.
            Antik antique1 = new Antik();

            Console.WriteLine("You have a "+ antique1.GetCategory()+ " antique, which according to recent discoveries went under the name; " + antique1.GetName());
            Console.WriteLine();

            antique1.PrintInfo();
            


            Console.ReadLine();
        }
    }
}
