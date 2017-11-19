using System;
using System.Collections.Generic;

namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();

            Question vraag1 = new Question() { Vraag = "test vraag 1 antwoord is 1", Moeilijkheidsgraad = 1, Antwoord = "1", Categorie = "algemeen" };
            Question vraag2 = new Question() { Vraag = "test vraag 2 antwoord is 2", Moeilijkheidsgraad = 2, Antwoord = "2", Categorie = "landen" };
            Question vraag3 = new Question() { Vraag = "test vraag 3 antwoord is 3", Moeilijkheidsgraad = 3, Antwoord = "3", Categorie = "dieren" };
            Question vraag4 = new Question() { Vraag = "test vraag 4 antwoord is 4", Moeilijkheidsgraad = 4, Antwoord = "4", Categorie = "heelal" };

            questions.Add(vraag1);
            questions.Add(vraag2);
            questions.Add(vraag3);
            questions.Add(vraag4);

            Console.WriteLine("Welkom! wilt u de quizz beginnen? (Druk op een toets)");
            Console.ReadKey();

            int teller = 1;
            int goedeAntwoorden = 0;

            foreach(Question q in questions)
            {

                Console.WriteLine("Vraag " + teller + ". " + q.Vraag);
                Console.WriteLine("Vul je antwoord in:");

                q.GebruikerAntwoord = Console.ReadLine();

                if (q.Checkantwoord())
                {
                    goedeAntwoorden++;
                }

                teller++;
                Console.WriteLine();
            }



            Console.WriteLine("Dit waren de vragen. U heeft " + goedeAntwoorden + " van de " + (teller - 1) +  " vragen goed.");
            Console.ReadKey();
        }
    }
}
