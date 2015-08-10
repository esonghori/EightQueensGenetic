using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace EightQueensGenetic {
    public partial class MainForm : Form {
        private BackgroundWorker background_worker_step_;
        private BackgroundWorker background_worker_infinit_;
        private GeneticAlgorithm genetic_algoithm_;
        private const int size_ = 8;
        private const int population_ = 100;
        private const int cycles_ = 8;
        private int top_fitness_ = -1;
        public MainForm() {
            InitializeComponent();
            genetic_algoithm_ = new GeneticAlgorithm(population_, typeof(EightQueenGene), size_);

            background_worker_step_ = new BackgroundWorker();
            background_worker_step_.DoWork += Background_worker_step__DoWork;
            background_worker_step_.RunWorkerCompleted += Background_worker_step_RunWorkerCompleted;
            background_worker_infinit_ = new BackgroundWorker();
            background_worker_infinit_.WorkerReportsProgress = true;
            background_worker_infinit_.WorkerSupportsCancellation = true;
            background_worker_infinit_.DoWork += Background_worker_infinit_DoWork;
            background_worker_infinit_.ProgressChanged += Background_worker_infinit_Update_Queen;
            background_worker_infinit_.ProgressChanged += Background_worker_infinit_Update_Curve;
            this.DoubleBuffered = true;
        }

        private void StartStopBtn_Click(object sender, EventArgs e) {
            if (background_worker_infinit_.IsBusy) {
                background_worker_infinit_.ReportProgress(0);
                background_worker_infinit_.CancelAsync();
                StartStopBtn.Text = "Resume";
            } else if (genetic_algoithm_.Finished) {
                genetic_algoithm_.Randomize();
                background_worker_infinit_.RunWorkerAsync();
                StartStopBtn.Text = "Stop";
                stepBtn.Enabled = false;
            } else {
                background_worker_infinit_.RunWorkerAsync();
                StartStopBtn.Text = "Stop";
                stepBtn.Enabled = false;
            }
        }

        private void stepBtn_Click(object sender, EventArgs e) {
            background_worker_step_.RunWorkerAsync();
        }

        private void Draw_Queens(EightQueenGene top_gene) {
            BoardPicBox.Refresh();
            int[] queen_location = top_gene.QueenLocation;
            Graphics graphics = BoardPicBox.CreateGraphics();
            Image queen = Properties.Resources.queen;
            int board_box_size = BoardPicBox.Width / 8;
            for (int i = 0; i < queen_location.Length; i++) {
                int x = i * board_box_size;
                int y = (queen_location[i] - 1) * board_box_size;
                graphics.DrawImage(queen, x, y, board_box_size, board_box_size);
            }
            graphics.Flush();
            fitnessTextBox.Text = String.Format("{0}", top_gene.Fitness());
        }

        private void Background_worker_step__DoWork(object sender, DoWorkEventArgs e) {
            genetic_algoithm_.StartCyle();
        }

        private void Background_worker_step_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            Draw_Queens(genetic_algoithm_.GetTop() as EightQueenGene);
        }

        private void Background_worker_infinit_DoWork(object sender, DoWorkEventArgs e) {
            int top_fitness = 0;
            do {
                if (background_worker_infinit_.CancellationPending) {
                    return;
                }
                genetic_algoithm_.StartCyle();
                top_fitness = genetic_algoithm_.GetTop().Fitness();
                background_worker_infinit_.ReportProgress(top_fitness % 100);
            } while (top_fitness > 0);
            if (StartStopBtn.InvokeRequired) {
                StartStopBtn.Invoke(new MethodInvoker(delegate { StartStopBtn.Text = "Start Again"; }));
            }
        }

        private void Background_worker_infinit_Update_Queen(object sender, ProgressChangedEventArgs e) {
            if (top_fitness_ != e.ProgressPercentage) {
                top_fitness_ = e.ProgressPercentage;
                Draw_Queens(genetic_algoithm_.GetTop() as EightQueenGene);
            }
        }
        private void Background_worker_infinit_Update_Curve(object sender, ProgressChangedEventArgs e) {
            fitnessCurvePicBox.Refresh();
            var dist = genetic_algoithm_.GetFitnessDistribution();
            var graphics = fitnessCurvePicBox.CreateGraphics();
            List<Point> points = new List<Point>(dist.Count);

            int x_step = fitnessCurvePicBox.Width / 8;
            int height = fitnessCurvePicBox.Height;

            for (int i = 0; i <= dist.Keys.Max(); i++) {
                if (dist.ContainsKey(i)) {
                    points.Add(new Point(x_step * i, height - dist[i]));
                } else {
                    points.Add(new Point(x_step * i, height - 0));
                }
            }
            graphics.DrawCurve(Pens.Black, points.ToArray());
        }
    }
}
