using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueensGenetic {
    class GeneticAlgorithm {
        private List<Gene> genes_;
        private double mating_ratio_ = 0.3;
        private double new_born_ratio_ = 0.5;
        private Random rnd_ = new Random();

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
            genes_ = new List<Gene>(population);
            for (int i = 0; i < population; i++) {
                genes_.Add((Gene)Activator.CreateInstance(gene_type, gene_constructor_args));
            }
        }

        public void StartCyle() {
            Sort_();
            Mating_();
        }

        public Gene GetTop() {
            return genes_[0];
        }

        public Gene FindAnswer(int cycles) {
            for (int i = 0; i < cycles; i++) {
                StartCyle();
            }
            return GetTop();
        }

        private void Sort_() {
            genes_.Sort(delegate (Gene a, Gene b) {
                return (a.Fitness() - b.Fitness());
            });
        }
        private void Mating_() {
            for (int i = 0; i < genes_.Count * new_born_ratio_; i++) {
                int male = rnd_.Next((int)(genes_.Count * mating_ratio_));
                int female = rnd_.Next((int)(genes_.Count * mating_ratio_));

                Gene new_born = genes_[male].Mate(genes_[female]).Mutate();
                genes_[genes_.Count - 1 - i] = new_born;
            }
        }

    }
}
