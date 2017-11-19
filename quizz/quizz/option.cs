using System;
using System.Collections.Generic;
using System.Text;

namespace quizz
{
    public class Option
    {
        private int number;
        private string anwser;

        public int Number { get { return number; } set { number = value; } }
        public string Anwser { get { return anwser; } set { anwser = value; } }
    }
}
