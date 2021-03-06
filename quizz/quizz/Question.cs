﻿using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    public class Question
    {
        private string vraag;
        private int moeilijkheidsgraad;
        private string categorie;
        private string antwoord;
        private string gebruikerAntwoord;
        private List<Option> options = new List<Option>();

        public int Moeilijkheidsgraad { get { return moeilijkheidsgraad; }  set { moeilijkheidsgraad = value; } }
        public string Vraag { get { return vraag; } set { vraag = value; } }
        public string Categorie { get { return categorie; } set { categorie = value; } }
        public string Antwoord { get { return antwoord; } set { antwoord = value; } }
        public string GebruikerAntwoord { get { return gebruikerAntwoord; } set { gebruikerAntwoord = value; } }
        public List<Option> Options { get { return options; } }

        public Boolean Checkantwoord()
        {
            return (antwoord == gebruikerAntwoord);
        }

        public void addOption(Option option)
        {
            options.Add(option);
        }
    }
}
