internal class Program
{
    static void Main(String[] args)
    {

        string Player;
        Random random = new Random();
        int Bot;
        bool PlayAgain = true;
        string answer;
        bool DumbBot;
        bool DumbPlayer;


        Console.WriteLine("---------------------");
        Console.WriteLine("Welcome to TicTacToe:");
        Console.WriteLine("---------------------");
        Console.WriteLine();
        Console.WriteLine("The rules are as follows: ");
        Console.WriteLine("1. To make a move Type \"T\" for TOP, \"B\" for BOTTOM, \"M\" for MIDDLE, \"L\" for LEFT and \"R\" for RIGHT");
        Console.WriteLine("2. Combine the letters to reach the corners: TR (top right), BL (bottom left)");
        Console.WriteLine("3. The rest of the game will play out as a normal TicTacToe game, but the ai is random :P");
        Console.WriteLine();

        string[,] PlayingField =
            {
                {"#", "#", "#"},
                {"#", "#", "#"},
                {"#", "#", "#"},
            };

        while (PlayAgain == true)
        {

            for (int i = 0; i < PlayingField.GetLength(0); i++)
            {
                for (int j = 0; j < PlayingField.GetLength(1); j++)
                {
                    Console.Write(PlayingField[i, j] + " ");
                }
                Console.WriteLine();
            }


            DumbPlayer = true;
            Console.WriteLine();
            Console.Write("Make a move!: ");
            Player = Console.ReadLine();
            Player = Player.ToUpper();


            if (DumbPlayer)
            {
                switch (Player)
                {
                    case "T":
                        if (PlayingField[0, 1] == "#")
                        {
                            PlayingField[0, 1] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "B":
                        if (PlayingField[2, 1] == "#")
                        {
                            PlayingField[2, 1] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "M":
                        if (PlayingField[1, 1] == "#")
                        {
                            PlayingField[1, 1] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "L":
                        if (PlayingField[1, 0] == "#")
                        {
                            PlayingField[1, 0] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "R":
                        if (PlayingField[1, 2] == "#")
                        {
                            PlayingField[1, 2] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "TR":
                        if (PlayingField[0, 2] == "#")
                        {
                            PlayingField[0, 2] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "TL":
                        if (PlayingField[0, 0] == "#")
                        {
                            PlayingField[0, 0] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "BR":
                        if (PlayingField[2, 2] == "#")
                        {
                            PlayingField[2, 2] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                    case "BL":
                        if (PlayingField[2, 0] == "#")
                        {
                            PlayingField[2, 0] = "X";
                            DumbPlayer = false;
                        }
                        else
                        {
                            Console.WriteLine("Thats taken buddy...");

                        }
                        break;

                }
            }
            

            if (Player != "T" && Player != "B" && Player != "M" && Player != "L" && Player != "R" && Player != "TR" && Player != "TL" && Player != "BL" && Player != "BR")
            {
                Console.WriteLine("THATS NOT A MOVE IDIOT!!!!");
            }

            Bot = random.Next(1, 10);
            DumbBot = true;
            if (DumbPlayer == false)
            {
                while (DumbBot)
                {
                    switch (Bot)
                    {
                        case 1:
                            if (PlayingField[0, 0] == "#")
                            {
                                PlayingField[0, 0] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 2:
                            if (PlayingField[0, 1] == "#")
                            {
                                PlayingField[0, 1] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 3:
                            if (PlayingField[0, 2] == "#")
                            {
                                PlayingField[0, 2] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 4:
                            if (PlayingField[1, 0] == "#")
                            {
                                PlayingField[1, 0] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 5:
                            if (PlayingField[1, 1] == "#")
                            {
                                PlayingField[1, 1] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 6:
                            if (PlayingField[1, 2] == "#")
                            {
                                PlayingField[1, 2] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 7:
                            if (PlayingField[2, 0] == "#")
                            {
                                PlayingField[2, 0] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 8:
                            if (PlayingField[2, 1] == "#")
                            {
                                PlayingField[2, 1] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;

                        case 9:
                            if (PlayingField[2, 2] == "#")
                            {
                                PlayingField[2, 2] = "O";
                                DumbBot = false;
                            }
                            else
                            {
                                Bot = random.Next(1, 10);
                            }
                            break;
                    }
                }
            }

            if (PlayingField[0, 0] == "X" && PlayingField[0, 1] == "X" && PlayingField[0, 2] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }
            else if (PlayingField[1, 0] == "X" && PlayingField[1, 1] == "X" && PlayingField[1, 2] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }
            else if (PlayingField[2, 0] == "X" && PlayingField[2, 1] == "X" && PlayingField[2, 2] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }

            else if (PlayingField[0, 0] == "X" && PlayingField[1, 0] == "X" && PlayingField[2, 0] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }
            else if (PlayingField[0, 1] == "X" && PlayingField[1, 1] == "X" && PlayingField[2, 1] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }
            else if (PlayingField[0, 2] == "X" && PlayingField[1, 2] == "X" && PlayingField[2, 2] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }

            else if (PlayingField[0, 0] == "X" && PlayingField[1, 1] == "X" && PlayingField[2, 2] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }
            else if (PlayingField[0, 2] == "X" && PlayingField[1, 1] == "X" && PlayingField[2, 0] == "X")
            {
                Console.WriteLine("YOU WIN!!!");
                PlayAgain = false;
            }




            if (PlayingField[0, 0] == "O" && PlayingField[0, 1] == "O" && PlayingField[0, 2] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }
            else if (PlayingField[1, 0] == "O" && PlayingField[1, 1] == "O" && PlayingField[1, 2] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }
            else if (PlayingField[2, 0] == "O" && PlayingField[2, 1] == "O" && PlayingField[2, 2] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }

            else if (PlayingField[0, 0] == "O" && PlayingField[1, 0] == "O" && PlayingField[2, 0] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }
            else if (PlayingField[0, 1] == "O" && PlayingField[1, 1] == "O" && PlayingField[2, 1] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }
            else if (PlayingField[0, 2] == "O" && PlayingField[1, 2] == "O" && PlayingField[2, 2] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }

            else if (PlayingField[0, 0] == "O" && PlayingField[1, 1] == "O" && PlayingField[2, 2] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }
            else if (PlayingField[0, 2] == "O" && PlayingField[1, 1] == "O" && PlayingField[2, 0] == "O")
            {
                Console.WriteLine("YOU LOSE...");
                PlayAgain = false;
            }


            Console.WriteLine("Do you want to continue playing? (Y/N)");
            answer = Console.ReadLine();
            answer.ToUpper();
            if (answer == "Y")
            {
                PlayAgain = true;
            }
            else if (answer == "N")
            {
                PlayAgain = false;
                Console.WriteLine("Thx for playing!");
            }


        }





    }
}