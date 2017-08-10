using System;

namespace Concepts.Task_Sample.CommonLibrary.MonteCarlo
{
    public class MonteCarlo
    {
        //################################################################################
        #region Fields

        private readonly Parameters m_Parameters;

        #endregion

        //################################################################################
        #region Constructor

        public MonteCarlo(Parameters parameters)
        {
            m_Parameters = parameters;
        }

        #endregion

        //################################################################################
        #region Properties

        private Parameters Parameters => m_Parameters;

        #endregion

        //################################################################################
        #region Public Implementation

        public double Simulate()
        {
            // Risk-neutral probabilities:
            double piup = (Parameters.InterestRate - Parameters.DownGrowth) / (Parameters.UpGrowth - Parameters.DownGrowth);
            double pidown = 1 - piup;

            double sum = 0.0;

            // Run simulations:
            for (int index = 0; index < Parameters.Simulations; index++)
            {
                // Generate one path:
                double sumPricePath = Parameters.InitialPrice;
                double previous = Parameters.InitialPrice;

                for (int i = 1; i <= Parameters.Periods; i++)
                {
                    double rn = Parameters.NextDouble;

                    double next;
                    if (rn > pidown)
                    {
                        next = previous * Parameters.UpGrowth;
                    }
                    else
                    {
                        next = previous * Parameters.DownGrowth;
                    }

                    sumPricePath += next;
                    previous = next;
                }

                double priceAverage = sumPricePath / (Parameters.Periods + 1);
                double callPayOff = Math.Max(priceAverage - Parameters.ExercisePrice, 0);

                sum += callPayOff;
            }

            // Return average across all simulations:
            return (sum / Math.Pow(Parameters.InterestRate, Parameters.Periods)) / Parameters.Simulations;
        }

        #endregion
    }
}
