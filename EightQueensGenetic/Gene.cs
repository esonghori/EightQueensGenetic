using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensGenetic {
    interface Gene {
        int Fitness();
        Gene Mate(Gene other);
        Gene Mutate();
    }
}
