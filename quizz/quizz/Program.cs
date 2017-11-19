using System;
using System.Collections.Generic;
using System.Linq;

namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();
            Question[] NewQuestions;

            Question vraag1 = new Question() { Vraag = "test vraag 1 antwoord is 1", Moeilijkheidsgraad = 1, Antwoord = "1", Categorie = "algemeen" };
            Question vraag5 = new Question() { Vraag = "test vraag 1 antwoord is 1 algemeen", Moeilijkheidsgraad = 1, Antwoord = "1", Categorie = "algemeen" };
            Question vraag2 = new Question() { Vraag = "test vraag 2 antwoord is 2", Moeilijkheidsgraad = 2, Antwoord = "3", Categorie = "landen" };
            Question vraag3 = new Question() { Vraag = "test vraag 3 antwoord is 3", Moeilijkheidsgraad = 3, Antwoord = "2", Categorie = "dieren" };
            Question vraag4 = new Question() { Vraag = "test vraag 4 antwoord is 4", Moeilijkheidsgraad = 2, Antwoord = "4", Categorie = "heelal" };

            Question vraag6 = new Question() { Vraag = "meerkeuze vraag", Moeilijkheidsgraad = 2, Antwoord = "3", Categorie = "meerkeuze" };
            Option option1 = new Option() { Number = 1, Anwser = "dit is het foute antwoord" };
            Option option2 = new Option() { Number = 2, Anwser = "dit is het bijna goede antwoord" };
            Option option3 = new Option() { Number = 2, Anwser = "dit is het goede antwoord" };

            vraag6.addOption(option1);
            vraag6.addOption(option2);
            vraag6.addOption(option3);

            questions.Add(vraag1);
            questions.Add(vraag2);
            questions.Add(vraag3);
            questions.Add(vraag4);
            questions.Add(vraag5);
            questions.Add(vraag6);


            Console.WriteLine("Welkom! wilt u de quizz beginnen? (Druk op een toets)");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Wilt u speciale vragen? (j/n)");

            String key = Console.ReadKey().Key.ToString();
            Console.WriteLine();


            if(key.Equals("J"))
            {
                Console.WriteLine("Wat voor soort moeilijkheidsgraad wilt u? (1 t/m 3)");
                var moeilijkheidsgraad = 1;
                int.TryParse(Console.ReadLine(), out moeilijkheidsgraad);
                Console.WriteLine();

                Console.WriteLine("Wat voor soort categorie wilt u? (algemeen, landen, dieren, heelal, meerkeuze)");
                var categorie = Console.ReadLine();

                NewQuestions = questions.Where(s => s.Moeilijkheidsgraad.Equals(moeilijkheidsgraad) && s.Categorie.Equals(categorie)).ToArray();
            } else
            {
                NewQuestions = questions.ToArray();
            }

            int teller = 1;
            int goedeAntwoorden = 0;

            var Playquestions = NewQuestions.OrderBy(x => x.Moeilijkheidsgraad);

            foreach (Question q in Playquestions)
            {
                Console.WriteLine("Vraag " + teller + ". " + q.Vraag);

                int optieteller = 1;
                foreach(Option o in q.Options)
                {
                    Console.WriteLine("optie " + optieteller + ". " + o.Anwser);
                    optieteller++;
                }

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
