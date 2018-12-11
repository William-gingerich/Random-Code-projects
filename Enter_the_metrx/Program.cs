using System;
using System.IO;

namespace enterthematrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            //the magic sauce happends here
            for (int i = 1; i < lines.Length; i++)
            {
                char[] linedata = (lines[i]).ToCharArray();
                int n = Convert.ToInt16(Math.Sqrt(linedata.Length));
                char[,] matrix = new char[n, n];
                int dataindex = 0;
                int matrixsum = 0;

                //populates matrix with values
                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        // if statment to stop out of range(should be unnecessary but better safe then sorry)
                        if (dataindex > linedata.Length)
                        {
                            break;
                        }
                        else
                        {
                            matrix[x, y] = linedata[dataindex];
                        }
                        dataindex++;
                    }
                }
                //steps through the matrix and does vodo black magic
                for (int pos1 = 0; pos1 < n; pos1++)
                {
                    matrixsum += Convert.ToInt16(matrix[pos1, pos1]);
                }
                int x1 = n - 1;
                int y1 = 0;
                while (true)
                {
                    if (x1 >= 0)
                    {
                        matrixsum += Convert.ToInt16(matrix[y1, x1]);
                        x1--;
                        y1++;
                    }
                    else
                    {
                        break;
                    }



                }
                sw.WriteLine("The sum of the diagonals of matrix {0} is {1}.", (i - 1), matrixsum);
                Console.WriteLine(matrixsum);
                Console.ReadKey();

            }
            sw.Close();
        }
    }
}