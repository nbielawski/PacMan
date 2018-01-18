using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    public class PacManClass
    {
        public int Points { get; set; }
        public int Lives { get; set; }


        public PacManClass()
        {
            this.Points = 5000;
            this.Lives = 3;
        }
    }
}
