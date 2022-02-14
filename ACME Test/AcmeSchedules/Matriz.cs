using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSchedules
{
    public class Matriz
    {
        public int[,] storage = new int[3, 3];

        public int this[int row, int column]
        {
            // The embedded array will throw out of range exceptions as appropriate.
            get { return storage[row, column]; }
            set { storage[row, column] = value; }
        }


    }
}
