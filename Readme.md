# Project Based Learning @ROOT - IT 



### Learning to Use Markdown

* Markdown or .md is the default type used by GitHub for it's Readme pages. 

* Learn how to use Markdown for Documentation: https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet

* Can use the Markdown Extension Pack in VSCode for UI Support. 

  ![](.\Images\MarkdownExtension.JPG)

  

### Tic Tac Toe - Project Planning and Decomposition

1. Understand the Game Logic. Use https://www.youtube.com/watch?v=3qzcAMShotQ for explanation on how to play.
2. To be created as a **Console Application**.
3. Decide if it is a 1D array of 9 elements or a 3 x 3 2D array. We choose 1D array containing *Characters.*
4. Display the Board to the user as a  3 x 3 2D array as shown in the image below.

![Tic Tac Toe Board - Initialized](.\Images\EmptyBoard.JPG)

4. Code Snippet used for Displaying the Board as a 3 x 3 2D array.

   ```c#
   using System;
   
   namespace TicTacToeV1
   {
       class Program
       {
           //Declare and Initialize the TicTacToe Board as a 1D char array with 9 elements
           static char[] board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
   
           static void Main(string[] args)
           {
               PrintBoard();
           }
   
           public static void PrintBoard()
           {
               //Logic to display a 1D char array of size 9 as a 3 x 3 - 2D Board on screen
               Console.WriteLine("Tic Tac Toe Board\n");
               for (int i = 0; i < board.Length; i++)
               {
                   Console.Write(board[i] + "\t");
                   if (i % 3 == 2)
                   {
                       Console.WriteLine("\n");
                   }
               }
           }
       }
   }
   ```

   

5. Board is ready. Get player names as input. Player 1 and Player 2. 

6. X plays first, but who gets the symbol X is to be determined by a Coin Toss or Random Generation. 

7. Once the Start player (Current Player) is determined, we can get Player input position for placing X

8. Refresh the board and show where X is placed. 

9. If it has been 5 moves or more in total, then check if the current player has won or if the game is draw

   - Write logic to determine if the Current Player has Won.
   - Write logic to determine if the game is Draw.

10. If the round is won or draw, break the loop and display the game results.

    - Write code to display the round results

    - #### Update the Player Score

    - #### Check if the Overall Game (best of 3/5) is Won or Draw and Display Results Accordingly

    - #### Otherwise, Move on to Next Round where the other player (Who played as O) will start as X and if it is the final round, then another Coin Toss could be used to determine who plays as X.

11. Otherwise, switch current player to other symbol and repeat steps from 7 to 10 till round ends.



