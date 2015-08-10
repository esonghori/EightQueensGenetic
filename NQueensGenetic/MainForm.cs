using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace NQueensGenetic {
    public partial class MainForm : Form {
        private BackgroundWorker background_worker_step_;
        private BackgroundWorker background_worker_infinit_;
        private GeneticAlgorithm genetic_algoithm_;
        private Stopwatch stop_watch_ = new Stopwatch();
        private int size_;
        private const int population_ = 50;
        private int top_fitness_ = -1;
        public MainForm() {
            InitializeComponent();
            background_worker_step_ = new BackgroundWorker();
            background_worker_step_.DoWork += Background_worker_step__DoWork;
            background_worker_step_.RunWorkerCompleted += Background_worker_step_RunWorkerCompleted;
            background_worker_infinit_ = new BackgroundWorker();
            background_worker_infinit_.WorkerReportsProgress = true;
            background_worker_infinit_.WorkerSupportsCancellation = true;
            background_worker_infinit_.DoWork += Background_worker_infinit_DoWork;
            background_worker_infinit_.ProgressChanged += Background_worker_infinit_Update_Queen;
            this.DoubleBuffered = true;
        }

        private void StartStopBtn_Click(object sender, EventArgs e) {
            if (background_worker_infinit_.IsBusy) {
                background_worker_infinit_.ReportProgress(0);
                background_worker_infinit_.CancelAsync();
                StartStopBtn.Text = "Resume";
            } else {
                if (genetic_algoithm_ == null || genetic_algoithm_.Finished) {
                    if (genetic_algoithm_ == null || sizeNumUpDown.Value != size_) {
                        size_ = (int)sizeNumUpDown.Value;
                        genetic_algoithm_ = new GeneticAlgorithm(population_, typeof(NQueenGene), size_);
                    } else {
                        genetic_algoithm_.Randomize();
                    }
                }
                background_worker_infinit_.RunWorkerAsync();
                StartStopBtn.Text = "Stop";
                sizeNumUpDown.Enabled = false;
                timeTextBox.Text = "";
                stop_watch_.Restart();
            }
        }

        private void stepBtn_Click(object sender, EventArgs e) {
            background_worker_step_.RunWorkerAsync();
        }

        private void DrawBoard(Graphics graphics) {
            int board_box_size = (int)(BoardPicBox.Width / size_);
            Brush white = Brushes.SandyBrown;
            Brush black = Brushes.Brown;
            for (int i = 0; i < size_; i++) {
                for (int j = 0; j < size_; j++) {
                    Brush brush;
                    if ((i + j) % 2 == 0) {
                        brush = white;
                    } else {
                        brush = black;
                    }
                    Rectangle r = new Rectangle(i * board_box_size, j * board_box_size, board_box_size, board_box_size);
                    graphics.FillRectangles(brush,new Rectangle[]{r});
                }
            }

        }
        private void DrawQueens(NQueenGene top_gene) {
            BoardPicBox.Refresh();
            int[] queen_location = top_gene.QueenLocation;
            Graphics graphics = BoardPicBox.CreateGraphics();
            DrawBoard(graphics);
            Image queen = Properties.Resources.queen;
            int board_box_size = (int)(BoardPicBox.Width / size_);
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
            DrawQueens(genetic_algoithm_.GetTop() as NQueenGene);
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
                StartStopBtn.Invoke(new MethodInvoker(delegate {
                    stop_watch_.Stop();
                    timeTextBox.Text = String.Format("{0}", stop_watch_.ElapsedMilliseconds/1000.0);
                    StartStopBtn.Text = "Start Again";
                    sizeNumUpDown.Enabled = true;
                }));
            }
        }

        private void Background_worker_infinit_Update_Queen(object sender, ProgressChangedEventArgs e) {
            if (top_fitness_ != e.ProgressPercentage) {
                top_fitness_ = e.ProgressPercentage;
                DrawQueens(genetic_algoithm_.GetTop() as NQueenGene);
            }
        }
    }
}
