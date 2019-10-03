using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Antik
    {

        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        private string[] nameArray = new string[] { "a", "b", "c", "d", "e" };
        private string[] categoryArray = new string[] { "Red", "Green", "Blue", "Yellow", "Magenta", " Black" };

        //Randomgeneratorn används för att lägga in två tal och få ut ett slumpmässigt tal från dem
        //För Chance of Category använde jag .lenght istället för ett speciellt nummer för att göra koden mer flexibel ifall man vill ändra något
        public Antik ()
        {
            actualValue = generator.Next(0, 100);
            rarity = generator.Next(0, 100);

            int chanceModifier;
            chanceModifier = generator.Next(0, 100);
            if (chanceModifier <= 10)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            chanceModifier = generator.Next(0, nameArray.Length);
            name = nameArray[chanceModifier];

            chanceModifier = generator.Next(0, categoryArray.Length);
            category = categoryArray[chanceModifier];
        }
        //skriver ut en string vilket är enkelt, eller använder .ToString ifall variablen inte normal går att skriva ut.
        //För priset som vi inte egentligen vet än refferera den till metoden Evaluate() som returnerar en int, alltså måste den också göras om till en string med .ToString
        public void PrintInfo()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Category = " + category);
            Console.WriteLine(Evaluate().ToString());
            Console.WriteLine("Rarity = " + rarity.ToString());
        }
        
        //Jag behöver inte ta någon input från mainkoden i (), då Antiken "antique1" redan är skapad och används ifall man kallar antique1.Evaluate()
        public int Evaluate()
        {
            //Alltså så använder sig koden av actualValue och rarity som antique1 har.
            price = actualValue * rarity;

            //Då det inte går att spara decimaltal i en int valde jag att helt enkelt ta 50 - 150 gånger taler och sedan dela allt med 100 för...
            //...att få samma effekt som att ta gånger antingen 0.5 till 1.5
            int modifier;
            modifier = generator.Next(50, 150);
            price = price * modifier / 100;
            return price;
        }
        //dessa två är bara en return rad
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        //han inte med denna, men att returnera true går att koden inte får några error meddelanden, och är alternativet från att kommentera bort kodblocket.
        public bool IsCursed()
        {
            return true;
        }
        
    }
}
