using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] GridData = {"0","1","2","3","4","5","6","7","8"};

            Console.WriteLine(GridData[0]+"|"+GridData[1]+"|"+GridData[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(GridData[3]+"|"+GridData[4]+"|"+GridData[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(GridData[6]+"|"+GridData[7]+"|"+GridData[8]);
            string CurrentPlayer="x";
            int turnNum=1;


            while (turnNum!=10)
            {
                Console.WriteLine("Player "+CurrentPlayer+", what square would you like to choose?");
                string selectSquare = Console.ReadLine();
                int selectNum = int.Parse(selectSquare);
                GridData[selectNum]=CurrentPlayer;


                Console.WriteLine(GridData[0]+"|"+GridData[1]+"|"+GridData[2]);
                Console.WriteLine("-+-+-");
                Console.WriteLine(GridData[3]+"|"+GridData[4]+"|"+GridData[5]);
                Console.WriteLine("-+-+-");
                Console.WriteLine(GridData[6]+"|"+GridData[7]+"|"+GridData[8]);
                
                if (GridData[0]==GridData[1])
                {
                    if (GridData[0]==GridData[2])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[3]==GridData[4])
                {
                    if (GridData[3]==GridData[5])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[6]==GridData[7])
                {
                    if (GridData[6]==GridData[8])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[0]==GridData[3])
                {
                    if (GridData[0]==GridData[6])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[1]==GridData[4])
                {
                    if (GridData[1]==GridData[7])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[2]==GridData[5])
                {
                    if (GridData[2]==GridData[8])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[0]==GridData[4])
                {
                    if (GridData[0]==GridData[8])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }

                if (GridData[2]==GridData[4])
                {
                    if (GridData[2]==GridData[6])
                    {
                        Console.WriteLine(CurrentPlayer+" wins!!!");
                        turnNum=9;
                    }
                }


                if (CurrentPlayer=="x")
                {
                    CurrentPlayer="o";
                }
                else
                {
                    CurrentPlayer="x";
                }

                turnNum =turnNum+1;
            }
        }
    }
}