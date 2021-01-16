using System;
using System.Collections.Generic;

namespace Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String>languages = new List<String>(new String[]
            {
                "HTML", "CSS", "Javacrit", "jQuery", "PHP", "Boostrap", "Java"
            });
            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(($"{i} = {languages[i]}"));
            }
            Console.WriteLine("4ème Element du tableau : " + languages[3]);
            Console.WriteLine("4ème Index du tableau : " + languages[4]);
            languages.Remove("Boostrap");
            languages[languages.FindIndex(ind => ind.Equals("Javacrit"))] = "Javascript";
            languages.Add("C");
            for (int i = 0; i < languages.Count; i++)
            {
                Console.WriteLine(($"{i}) = {languages[i]}"));
            }
        }
    }
}
