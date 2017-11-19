using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    class Question
    {
        private string vraag;
        private int moeilijkheidsgraad;
        private string categorie;

        public int Moeilijkheidsgraad { get { return moeilijkheidsgraad; }  set { moeilijkheidsgraad = value; } }
        public string Vraag { get { return vraag; } set { vraag = value; } }
        public string Categorie { get { return categorie; } set { categorie = value; } }
    }
}
