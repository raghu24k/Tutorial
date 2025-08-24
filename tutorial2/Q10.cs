//Given a matrix mat[][] of size N x M, where every row and column is sorted in increasing order, and a number X is given. The task is to find whether element X is present in the matrix or not.

 
using System;

class Q10
{
    static int matSearch(int[,] mat, int N, int M, int X)
    {
        int row = 0, col = M - 1;

        while (row < N && col >= 0)
        {
            if (mat[row, col] == X)
                return 1;  // Found
            else if (mat[row, col] > X)
                col--;      // Move left
            else
                row++;      // Move down
        }

        return 0; // Not found
    }

    static void Main(string[] args)
    {
        int[,] mat1 = { { 3, 30, 38 },
                        { 44, 52, 54 },
                        { 57, 60, 69 } };
        int X1 = 62;
        Console.WriteLine(matSearch(mat1, 3, 3, X1)); // Output: 0

        int[,] mat2 = { { 18, 21, 27, 38, 55, 67 } };
        int X2 = 55;
        Console.WriteLine(matSearch(mat2, 1, 6, X2)); // Output: 1

        Console.ReadLine();
    }
}
