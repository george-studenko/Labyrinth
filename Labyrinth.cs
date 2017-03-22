using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGenerator
{
    class Labyrinth
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private List<string> sides = new List<string>{ "TOP","RIGHT","BOTTOM","LEFT"};
        public string[,] TheLabyrinth { get; set; }

        private string wall = "#";
        // Default empty constructor
        /// <summary>
        /// If using the default Constructor
        /// after creating an instance of Labyrinth 
        /// set the Rows and Columns properties
        /// and then call to InitializeLabyrinth
        /// </summary>
        public Labyrinth()
        {

        }
        // Constructor 
        /// <summary>
        /// Creates a labyrinth and initializes it
        /// </summary>
        /// <param name="rows">Sets the total Rows for the labyrinth</param>
        /// <param name="cols">Sets the total Columns for the labyrinth</param>
        public Labyrinth(int rows, int cols)
        {
            this.Rows = rows;
            this.Columns = cols;
            InitializeLabyrinth();
        }

        public void InitializeLabyrinth()
        {
            TheLabyrinth = new string[Rows, Columns];
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    TheLabyrinth[row, col] = wall;
                }
            }
        }
        public void Print()
        {
            for (int row = 0; row < Rows; row++)
            {
                // creates a line break to start next row
                Console.WriteLine("  ");
                // adds some padding to the left of the screen
                Console.Write("  ");
                for (int col = 0; col < Columns; col++)
                {
                    Console.Write(TheLabyrinth[row, col]);
                }                
            }
        }
        public void CreateReferencePoint(string type)
        {
            int row = 0;
            int col = 0;
            
            Random r = new Random();
            int sideIndex = r.Next(0, 3);
            
            string side = sides[sideIndex];            
            sides.Remove(side);
            
            switch (side)
            {
                case "TOP":
                    row = 0;
                    col = r.Next(1, Columns-2);                    
                    break;
                case "RIGHT":
                    col = Columns - 1;
                    row = r.Next(1, Rows - 2);
                    break;
                case "BOTTOM":
                    row = Rows-1;
                    col = r.Next(1, Columns - 2);
                    break;
                case "LEFT":
                    col = 0;
                    row = r.Next(1, Rows - 2);
                    break;                
            }
            TheLabyrinth[row, col] = type;            
        }
    }
}
