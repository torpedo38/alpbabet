using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
        int L = int.Parse(inputs[1]); // the number of links
        int E = int.Parse(inputs[2]); // the number of exit gateways
        int[,] links = new int[N, N];
        int[] gateways = new int[E];

        for (int i = 0; i < L; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
            int N2 = int.Parse(inputs[1]);
            links[i, i] = links[N1, N2];
        }
        for (int i = 0; i < E; i++)
        {
            int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
            gateways[i] = gateways[EI];
        }
        /*int[, ] links = new int[L, L];
        for (int i = 0; i < L; i++)
        {

        }*/
        // game loop
        while (true)
        {
            int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Bobnet agent is positioned this turn
            
            for (int i = 0; i < L; i++)
            {
                if (links[i, i] == links[gateways[i], SI])
                {
                    if (gateways[i] > SI)
                    {
                        Console.WriteLine(SI + " " + gateways[i]);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(gateways[i] + " " + SI);
                        return;
                    }
                }
                else if (links[gateways[i], SI] == links[i, i])
                {
                    if (gateways[i] > SI)
                    {
                        Console.WriteLine(SI + " " + gateways[i]);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(gateways[i] + " " + SI);
                        return;
                    }
                }
            }
            Random rnd = new Random();

            for (int i = 0; i < L; i++)
            {

            }
        }
    }
}