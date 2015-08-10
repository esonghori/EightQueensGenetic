using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensGenetic {
    class GeneticAlgorithm {
        private List<IGene> genes_;
        private double mating_ratio_ = 0.5;
        private double new_born_ratio_ = 0.3;
        private Random rnd_ = new Random();
        private object lock_ = new object();

        public bool Finished {
            get {
                return (GetTop().Fitness() == 0);
            }
        }

        public double MatingRatio {
            get {
                return mating_ratio_;
            }
            set {
                mating_ratio_ = value;
            }
        }

        public double NewBornRatio {
            get {
                return new_born_ratio_;
            }
            set {
                new_born_ratio_ = value;
            }
        }

        public GeneticAlgorithm(int population, Type gene_type, params object[] gene_constructor_args) {
            lock (lock_) {
                genes_ = new List<IGene>(population);
                for (int i = 0; i < population; i++) {
                    genes_.Add((IGene)Activator.CreateInstance(gene_type, gene_constructor_args));
                }
            }
        }

        public void Randomize() {
            lock (lock_) {
                for (int i = 0; i < genes_.Count; i++) {
                    genes_[i].Randomize();
                }
            }
        }

        public void StartCyle() {
            Sort_();
            Mate_();
        }

        public IGene GetTop() {
            IGene ret;
            lock (lock_) {
                ret = genes_[0].Clone() as IGene;
            }
            return ret;
        }

        public SortedDictionary<int, int> GetFitnessDistribution() {
            var dictionary = new SortedDictionary<int, int>();
            lock (lock_) {
                foreach (var gen in genes_) {
                    int fitness = gen.Fitness();
                    if (dictionary.ContainsKey(fitness)) {
                        dictionary[fitness]++;
                    } else {
                        dictionary[fitness] = 1;
                    }
                }
            }
            return dictionary;
        }

        private void Sort_() {
            lock (lock_) {
                genes_.Sort(delegate (IGene a, IGene b) {
                    return (a.Fitness() - b.Fitness());
                });
            }
        }
        private void Mate_() {
            for (int i = 0; i < genes_.Count * new_born_ratio_; i++) {
                int male = rnd_.Next((int)(genes_.Count * mating_ratio_));
                int female = rnd_.Next((int)(genes_.Count * mating_ratio_));

                lock (lock_) {
                    IGene new_born = genes_[male].Mate(genes_[female]).Mutate();
                    genes_[genes_.Count - 1 - i] = new_born;
                }
            }
        }

    }
}
