using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensGenetic {
    class EightQueenGene : IGene {
        static private Random rnd_ = new Random();

        private int[] queen_location_;

        public int[] QueenLocation {
            get {
                return queen_location_;
            }
        }

        public EightQueenGene(int size) {
            queen_location_ = new int[size];
            for (int i = 0; i < queen_location_.Length; i++) {
                queen_location_[i] = rnd_.Next(queen_location_.Length) + 1;
            }
        }

        public int Fitness() {
            int fitness = 0;
            for (int i = 0; i < queen_location_.Length; i++) {
                for (int j = i + 1; j < queen_location_.Length; j++) {
                    if (queen_location_[i] + j - i == queen_location_[j])
                        fitness += 1;
                    else if (queen_location_[i] - j + i == queen_location_[j])
                        fitness += 1;
                    else if (queen_location_[i] == queen_location_[j])
                        fitness += 1;
                }
            }
            return fitness;
        }
        public IGene Mutate() {
            int b = rnd_.Next(queen_location_.Length);
            queen_location_[b] = rnd_.Next(queen_location_.Length) + 1;
            return this;
        }
        public IGene Mate(IGene other) {
            EightQueenGene ret = other.Clone() as EightQueenGene;
            for (int i = 0; i < ret.queen_location_.Length / 2; i++) {
                ret.queen_location_[i] = queen_location_[i];
            }
            return ret;
        }
        public void Randomize() {
            for (int i = 0; i < queen_location_.Length; i++) {
                queen_location_[i] = rnd_.Next(queen_location_.Length) + 1;
            }
        }

        public object Clone() {
            EightQueenGene ret = new EightQueenGene(this.QueenLocation.Length);
            for (int i = 0; i < queen_location_.Length; i++) {
                ret.queen_location_[i] = queen_location_[i];
            }
            return ret;
        }
    }
}