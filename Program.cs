using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGenerator
{
    class Program
    {
        static void Main(string[] args)
        {            
            Labyrinth lab = new Labyrinth(8,10);             
            lab.CreateReferencePoint("E");
            lab.CreateReferencePoint("S");
            lab.Print();
            Console.WriteLine();   

            Console.ReadKey();
        }
    }
}
