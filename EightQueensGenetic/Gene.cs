using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensGenetic {
    interface IGene : ICloneable {
        int Fitness();
        IGene Mate(IGene other);
        IGene Mutate();
        void Randomize();
    }
}
