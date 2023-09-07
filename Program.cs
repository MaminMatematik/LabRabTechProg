using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write length of ZubMass");
            int allLength = Convert.ToInt32(Console.ReadLine());
            int[][] ZubMass =new int[allLength][];
            for(int i=0; i<allLength;i++)
            {
                Console.WriteLine("Write length of ZubMass "+i);
                int length= Convert.ToInt32(Console.ReadLine());
                for (int j=0;j<length;j++)
                {
                    ZubMass[i] = new int[length];
                    Console.WriteLine("Write element number " + j);
                    int element= Convert.ToInt32(Console.ReadLine());
                    ZubMass[i][j] = element;
                }
            }
            for (int i=0;i<ZubMass.Length;i++)
            {
                for(int j=0;j<ZubMass[i].Length;j++)
                {
                    Console.Write(ZubMass[i][j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Prikol");
            Console.ReadKey();
        }
    }
}
