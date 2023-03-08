using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string prenom;
            int age;
            Console.Write("Quel est votre nom de famille ?");
            nom = Console.ReadLine();
            Console.Write("Quelle est votre prénom?");
            prenom = Console.ReadLine();
            Console.Write("Quel est votre âge?");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Bonjour "+prenom+" "+nom+", vous avez "+age+" ans.");
            Console.ReadLine();
        }
    }
}
