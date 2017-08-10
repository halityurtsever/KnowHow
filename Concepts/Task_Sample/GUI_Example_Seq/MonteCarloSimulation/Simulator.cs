using System;
using System.Diagnostics;
using System.Windows.Forms;

using Concepts.Task_Sample.CommonLibrary.MonteCarlo;

namespace Seq.MonteCarloSimulation
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //set parameters
            Parameters parameters = new Parameters();
            parameters.InitialPrice = Convert.ToDouble(textBoxInitialPrice.Text);
            parameters.ExercisePrice = Convert.ToDouble(textBoxExercisePrice.Text);
            parameters.UpGrowth = Convert.ToDouble(textBoxUpGrowth.Text);
            parameters.DownGrowth = Convert.ToDouble(textBoxDownGrowth.Text);
            parameters.InterestRate = Convert.ToDouble(textBoxInterestRate.Text);
            parameters.Periods = Convert.ToInt64(textBoxPeriods.Text);
            parameters.Simulations = Convert.ToInt64(textBoxSimulations.Text);

            //start simulation
            MonteCarlo monteCarlo = new MonteCarlo(parameters);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var simulationResult = monteCarlo.Simulate();
            stopwatch.Stop();

            //collect results
            var elapsedTime = stopwatch.ElapsedMilliseconds;
            var itemCount = listBoxResults.Items.Count;
            var result = $"{itemCount + 1} -> {simulationResult:C} ({elapsedTime:##,###} secs)";

            //display results
            listBoxResults.Items.Insert(itemCount, result);
            stopwatch.Reset();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
