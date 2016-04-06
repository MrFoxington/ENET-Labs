using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_3
{
    public partial class NumberGuesse : System.Web.UI.Page
    {
        GuessGame game; 

        protected void Page_Load(object sender, EventArgs e)
        {
            game = (GuessGame)Session["Game"];

            if( game == null)
            {
                game = new GuessGame();
                game.ResetGame();
                Session["Game"] = game;
            }

            lbl_prevGuess.Text = game.PreviousGuesses;
        }

        protected void btn_submitGuess_Click(object sender, EventArgs e)
        {
            string guesse = txt_guess.Text;
            int num;
            bool isValid = int.TryParse(guesse, out num);
            if (isValid)
            {
               bool isRight = game.MakeGuess(num);
                    if(isRight)
                {
                    lbl_prevGuess.Text = "YOU WIN!";
                }
            }

            
        }

        protected void btn_reset_Click(object sender, EventArgs e)
        {
            game.ResetGame();
        }
        
    }

}