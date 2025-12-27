using System.Collections;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilinovIA.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[][] Array1 = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Array1[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    Array1[i][j] = matrix[i, j];
                }

            }
            int numRows = matrix.GetLength(0);
            int[] firstColumn = new int[numRows];
            for (int i = 0; i < numRows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }
            Array.Sort(firstColumn);
            int[,] matrix1 = new int[5, 5]
            {
                {firstColumn[0], Array1[0][1],  Array1[0][2],   Array1[0][3], Array1[0][4]},
                {firstColumn[1], Array1[1][1],  Array1[1][2],   Array1[1][3], Array1[1][4]},
                {firstColumn[2], Array1[2][1],  Array1[2][2],   Array1[2][3], Array1[2][4]},
                {firstColumn[3], Array1[3][1],  Array1[3][2],   Array1[3][3], Array1[3][4]},
                {firstColumn[4], Array1[4][1],  Array1[4][2],   Array1[4][3], Array1[4][4]}
            };
            return matrix1; 
        }
    }
}
