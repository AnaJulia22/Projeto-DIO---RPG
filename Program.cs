using rpg.src.Entities;

namespace rpg
{
    
    class program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White wizard");

            Console.Write(wizard.Attack(1));
            Console.Write(wizard.Attack(7));
           
        }
    }

}
