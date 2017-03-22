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
    }
}
