using System;

namespace RPG_C_.src.entities
{
    class Program
    {
        static void Main(string[] args)
        {

            Characters noctis = new Knight("Noctis", 50, 1500, 900, "Espada Encantada");
            Characters prompto = new Gunslighter("Prompto", 30, 800, 1300, "Ebony and Ivory");
            Characters poring = new Monster("Poring", 70, 300, 0, "Cabeçada");

            while (poring.hp > 0)
            {
                noctis.Attack(poring);
                prompto.Attack(poring);
                poring.Attack(noctis);
                poring.Attack(prompto);

                System.Console.WriteLine("\n");
            }
            System.Console.WriteLine("Pampampamapam-pam-pam-pampampam!");


        }

    }
}