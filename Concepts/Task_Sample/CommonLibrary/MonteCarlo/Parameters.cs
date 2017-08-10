using System;

namespace Concepts.Task_Sample.CommonLibrary.MonteCarlo
{
    public class Parameters
    {
        //################################################################################
        #region Fields

        private Random m_Rand = new Random(); //Random number generator.

        private double m_InitialPrice; //Initial price.
        private double m_ExercisePrice; //Excercise price.
        private double m_UpGrowth; //Up growth.
        private double m_DownGrowth; //Down growth.
        private double m_InterestRate; //Interest rate.

        private long m_Periods; //Number of periods to maturity.
        private long m_Simulations; //Number of simulations to perform.

        #endregion

        //################################################################################
        #region Public Implementation

        public double InitialPrice
        {
            get { return m_InitialPrice; }
            set { m_InitialPrice = value; }
        }

        public double ExercisePrice
        {
            get { return m_ExercisePrice; }
            set { m_ExercisePrice = value; }
        }

        public double UpGrowth
        {
            get { return m_UpGrowth; }
            set { m_UpGrowth = value; }
        }

        public double DownGrowth
        {
            get { return m_DownGrowth; }
            set { m_DownGrowth = value; }
        }

        public double InterestRate
        {
            get { return m_InterestRate; }
            set { m_InterestRate = value; }
        }

        public double NextDouble => m_Rand.NextDouble();

        public long Periods
        {
            get { return m_Periods; }
            set { m_Periods = value; }
        }

        public long Simulations
        {
            get { return m_Simulations; }
            set { m_Simulations = value; }
        }

        #endregion
    }
}
