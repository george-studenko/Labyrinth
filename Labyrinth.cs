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
    }
}
