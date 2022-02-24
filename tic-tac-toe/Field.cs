using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    internal class Field
    {
        private char[,] field = {{' ', ' ', ' '}, {' ', ' ', ' ',}, { ' ', ' ', ' ', } };
        public void ShowField()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                        
                    if (j == 2)
                    {
                        Console.Write(field[i, j]);
                    }
                    else
                    {
                        Console.Write(field[i, j]+" |");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine('\n');
        }
        public void Template()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j =0; j <4; j++)
                {
                    if (i == 0 && j == 0)
                        Console.Write("  ");
                    else if (i == 0)
                    {
                        Console.Write(j +" ");
                    }
                    else if (j == 0)
                    {
                        Console.Write(i + " ");
                        if (j==3)
                        {
                            
                        }
                    }
                    else
                    {
                        Console.Write(" |");
                    }
                }
                Console.WriteLine();
            }
        }
        public void AddX(int x, int y)
        {
            field[x, y] = Point.X;
        }
        public void AddO(int x, int y)
        {
            field[x, y] = Point.O;
        }
        public bool Win()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((field[i, 0] == Point.X && field[i, 1] == Point.X && field[i, 2] == Point.X) || (field[0, j] == Point.X && field[1, j] == Point.X && field[2, j] == Point.X))
                    {
                        Console.WriteLine("Player 1 Win");
                        return false;
                    }
                    else if ((field[0,0]==Point.X&& field[1,1]==Point.X&&field[2,2]==Point.X)|| (field[2, 0] == Point.X && field[1, 1] == Point.X && field[0, 2] == Point.X))
                    {
                        Console.WriteLine("Player 1 Win");
                        return false;

                    }
                    if ((field[i, 0] == Point.O && field[i, 1] == Point.O && field[i, 2] == Point.O) ||( field[0, j] == Point.O && field[1, j] == Point.O && field[2, j] == Point.O))
                    {
                        Console.WriteLine("Player 2 Win");
                        return false;
                    }
                    else if ((field[0, 0] == Point.O && field[1, 1] == Point.O && field[2, 2] == Point.O)|| (field[2, 0] == Point.O && field[1, 1] == Point.O && field[0, 2] == Point.O))
                    {
                        Console.WriteLine("Player 2 Win");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
