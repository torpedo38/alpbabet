using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[,] grid = new char[n, n];
        char[,] row = new char[n, n];

        char[, ] clear(char[,] table)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    table[i, j] = '-';
                }
            }
            return table;
        }

        for (int i = 0; i < n; i++)
        {
            string m = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                grid[i, j] = m[j];
            }
        }

        int[, ] function(int a,int b,int k) 
        {
            int test = 0;

            if ((int)grid[a-1, b] == k++)
            {
                function(a - 1, b, k++);
                row[a - 1, b] = (char)(k++);
            }
            if ((int)grid[a + 1, b] == k++)
            {
                function(a + 1, b, k++);
                test++;
            }
            if ((int)grid[a, b - 1] == k++)
            {
                function(a, b - 1, k++);
                test++;
            }
            if ((int)grid[a, b + 1] == k++)
            {
                function(a, b + 1, k++);
                test++;
            }
            if (test >= 2)
            {
                return [a, b];
            }

            return [a,b];
        }

        for (int x = 0; x < n; x++)
        {
            for (int y = 0; y < n; y++)
            {
                if (grid[x, y] == 'a')
                {
                    row[x, y] = 'a';
                    function(x, y, 98);
                }
            }
        }
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("answer");
    }
}