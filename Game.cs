using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
      //This Method will update coordinate of character based on inputs
    public new static void UpdatePosition(string keyPressed, out int x, out int y)
        {
            //First we set 2 variables in order to avoid errors
            x = 0;
            y = 0;

            switch(keyPressed)
            {
                case "W":
                    y -= 1;
                    break;

                case "S":
                    y += 1;
                    break;

                case "A":
                    x -= 1;
                    break;

                case "D":
                    x += 1;
                    break;

            }
        }
               //This method will allow the player icon to change with each keypress.
       //Its input will be the key pressed and it will return a symbol
       //that represents the player.
       public new static char UpdateCursor(string keyPressed)
        {

            char direction = 'o'; // First we set a variable named direction 

            switch(keyPressed)
            {
                case "W":
                    direction = '^';
                    break;

                case "S":
                    direction = 'v';
                    break;

                case "A":
                    direction = '<';
                    break;

                case "D":
                    direction = ('>');
                    break;
            }

            return direction; //Finaly, we return the direction to the program
        }
        //This method will compare coordinates and put score or not
        public new static bool DidScore(int charX, int charY, int fruitX, int fruitY)
        {
            if(charX == fruitX && charY == fruitY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Without this method, hitting the boundaries will break the game!
        public new static int KeepInBounds(int coordinate, int maxValue)
        {
            

            if (coordinate > maxValue)
            {
                return 0; // If the player went to the left or top edge, send on the opposite side
            }
            else if (coordinate < 0)
            {
                return maxValue; // same
            }
            else
            {
                return coordinate; // It's OK
            }
        }



  }
}
