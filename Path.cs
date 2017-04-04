using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGenerator
{
    class Path
    {
        private string[] mDirections = { "LEFT", "DOWN","RIGHT" };
        public int PathLength { get; set; }
        public int MaxColumns { get; set; }
        public int MaxRows { get; set; }
        
        public Path(int pathLength, int columns, int rows)
        {
            this.PathLength = pathLength;
            this.MaxColumns = columns;
            this.MaxRows = rows;
        }
         
        public int[,] createRandomPath()
        {
            PathLength = 0;
            int[,] path = new int[MaxRows, MaxColumns];
            
            for (int row=0; row < path.GetLength(0); row++)
            {
                bool pathCleared = false;

                for (int col = 0; col < path.GetLength(1); col++)
                {
                    if (!pathCleared)
                    {
                        if (isPath() || col == MaxRows - 1)
                        {
                            path[row, col] = 1;
                            pathCleared = true;
                        }
                    }
                    else
                    {
                        path[row, col] = 0;
                    }
                }
            }

            return path;
        }

        public string generateRandomDirection()
        {            
            Random randomNumber = new Random();
            int directionIndex = randomNumber.Next(0, 2);
            return mDirections[directionIndex];
        }

        public bool isPath()
        {
            return new Random().Next(0, 2) == 0;
        }
    }
}
