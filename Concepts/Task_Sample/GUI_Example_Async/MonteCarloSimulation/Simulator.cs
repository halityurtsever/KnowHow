using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using Concepts.Task_Sample.CommonLibrary.MonteCarlo;

namespace Async.MonteCarloSimulation
{
    public partial class Simulator : Form
    {
        private int simulationCount;

        public Simulator()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (simulationCount == 0)
            {
                toolStripProgressBar.Value = 0;
            }

            //set parameters
            Parameters parameters = new Parameters();
            parameters.InitialPrice = Convert.ToDouble(textBoxInitialPrice.Text);
            parameters.ExercisePrice = Convert.ToDouble(textBoxExercisePrice.Text);
            parameters.UpGrowth = Convert.ToDouble(textBoxUpGrowth.Text);
            parameters.DownGrowth = Convert.ToDouble(textBoxDownGrowth.Text);
            parameters.InterestRate = Convert.ToDouble(textBoxInterestRate.Text);
            parameters.Periods = Convert.ToInt64(textBoxPeriods.Text);
            parameters.Simulations = Convert.ToInt64(textBoxSimulations.Text);

            MonteCarlo monteCarlo = new MonteCarlo(parameters);
            Stopwatch stopwatch = new Stopwatch();
            int itemCount = 0;

            simulationCount++;
            toolStripStatusLabel.Text = $@"Simulation Count: {simulationCount}";

            //first start simulation and calculate result
            Task<string> simulationTask = Task<string>.Factory.StartNew(
                () =>
                    {
                        //start simulation
                        stopwatch.Start();
                        double simulationResult = monteCarlo.Simulate();
                        stopwatch.Stop();

                        //collect results
                        var elapsedTime = stopwatch.ElapsedMilliseconds;
                        itemCount = listBoxResults.Items.Count;
                        string result = $"{itemCount + 1} -> {simulationResult:C} ({elapsedTime:##,###} secs)";
                        stopwatch.Reset();

                        return result;
                    });

            //then after first task completed, update the UI. Because of it is UI, do this task
            //in UI thread by using TaskScheduler.FromCurrentSynchronizationContext
            simulationTask.ContinueWith(
                (previous) =>
                    {
                        //display results
                        listBoxResults.Items.Insert(itemCount, previous.Result);

                        simulationCount--;
                        toolStripStatusLabel.Text = $@"Simulation Count: {simulationCount}";

                        toolStripProgressBar.Value = 100 - 100 / (listBoxResults.Items.Count + simulationCount) * simulationCount;
                    },
                TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Simulator_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = @"Simulation Count: 0";
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            toolStripProgressBar.Value = 0;
        }
    }
}
