using System; 

namespace uppgift2_14
{
class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utför en decimal räkning där det ingår en multiplikation."); 
            Console.ReadLine();

            Console.WriteLine("Skriv ett decimal tal."); 
            string decimaltal1text = Console.ReadLine();
            float decimaltal1 = float.Parse(decimaltal1text);

            Console.WriteLine("Skriv in ett till decimaltal.");
            string decimaltal2text = Console.ReadLine();
            float decimaltal2 = float.Parse(decimaltal2text);

            float summan;

            summan = decimaltal1 * decimaltal2;

            Console.WriteLine("Summan av talen blir " + summan); 

            

        }
    }
}
