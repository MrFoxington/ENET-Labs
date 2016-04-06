using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Lab_3
{
    public class GuessGame
    {

        private int answer;
        private string previousGuesses;
            
        public string PreviousGuesses { get; }

        public GuessGame()
        {
            ResetGame();
        }

        public void ResetGame()
        {
            Random r = new Random();

            answer = r.Next(1, 10);
        }

        public bool MakeGuess(int guesse)
        {
            if(guesse == answer)
            {
                return true;
            }

            previousGuesses += " " + guesse;

            return false;
        }



    }
}