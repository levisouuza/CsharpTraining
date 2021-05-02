using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe dois números: ");
            string[] nums = Console.ReadLine().Split(" ");

            int row = int.Parse(nums[0]);
            int col = int.Parse(nums[1]);

            int[,] mat = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                Console.Write("Informe os valores da linha " + i + ": ");
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < col; j++)
                {                    
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("Valor procurado: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {                
                for (int j = 0; j < col; j++)
                {
                    if (mat[i, j] == value)
                    {

                        Console.WriteLine("Position: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < col - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < row - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }


                    };
                }
            }





        }
    }
}
