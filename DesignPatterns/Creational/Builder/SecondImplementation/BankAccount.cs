
namespace DesignPatterns.Creational.Builder.SecondImplementation
{
    class BankAccount
    {
        //################################################################################
        #region Fields

        private int m_AccountNumber;
        private string m_Owner;
        private double m_Balance;

        #endregion

        //################################################################################
        #region Constructor

        public BankAccount(int accountNumber, string owner, double balance)
        {
            this.m_AccountNumber = accountNumber;
            this.m_Owner = owner;
            this.m_Balance = balance;
        }

        #endregion
    }

    class BankAccountNewImpl
    {
        //################################################################################
        #region Fields

        private int m_AccountNumber;
        private string m_Owner;
        private string m_Branch;
        private double m_Balance;
        private double m_InterestRate;

        #endregion

        //################################################################################
        #region Constructor

        /**
         * In this example, it is very easy to swap constructor parameters accidentally which may cause to errors hard to debug.
         * On the other hand, we may implement an empty constructor and assign each field via properties.
         * But in this case developer may forget or skip it to assign.
         */
        public BankAccountNewImpl(int accountNumber, string owner, string branch, double balance, double interestRate)
        {
            this.m_AccountNumber = accountNumber;
            this.m_Owner = owner;
            this.m_Branch = branch;
            this.m_Balance = balance;
            this.m_InterestRate = interestRate;
        }

        #endregion
    }

    class BankAccountWithBuilder
    {
        //################################################################################
        #region Fields

        private int m_AccountNumber;
        private string m_Owner;
        private string m_Branch;
        private double m_Balance;
        private double m_InterestRate;

        private static Builder s_Builder;

        #endregion

        //################################################################################
        #region Constructor

        private BankAccountWithBuilder()
        {
            //bank account can only be created by Builder class.
        }

        #endregion

        //################################################################################
        #region Properties

        internal Builder GetBuilder(int accountNumber)
        {
            if (s_Builder == null)
            {
                s_Builder = new Builder(accountNumber);
            }

            return s_Builder;
        }

        #endregion

        //################################################################################
        #region Nested Static Class

        internal class Builder
        {
            //################################################################################
            #region Fields

            private readonly int m_AccountNumber;
            private string m_Owner;
            private string m_Branch;
            private double m_Balance;
            private double m_InterestRate;

            #endregion

            //################################################################################
            #region Constructor

            public Builder(int accountNumber)
            {
                this.m_AccountNumber = accountNumber;
            }

            public Builder WithOwner(string owner)
            {
                this.m_Owner = owner;
                return this;
            }

            public Builder AtBranch(string branch)
            {
                this.m_Branch = branch;
                return this;
            }

            public Builder OpeningBalance(double balance)
            {
                this.m_Balance = balance;
                return this;
            }

            public Builder AtRate(double rate)
            {
                this.m_InterestRate = rate;
                return this;
            }

            public BankAccountWithBuilder Build()
            {
                BankAccountWithBuilder bankAccount = new BankAccountWithBuilder();
                bankAccount.m_AccountNumber = this.m_AccountNumber;
                bankAccount.m_Owner = this.m_Owner;
                bankAccount.m_Branch = this.m_Branch;
                bankAccount.m_Balance = this.m_Balance;
                bankAccount.m_InterestRate = this.m_InterestRate;

                return bankAccount;
            }

            #endregion
        }

        #endregion
    }

    class Client
    {
        /**
         * This is the standant implementation of BankAccount class.
         */
        BankAccount bankAccount = new BankAccount(1, "Halit Yurtsever", 1000);

        /**
         * In this implementation, two new parameters are added to constructor. If you pay close attention last two parameters are
         * easy to swap accidentally which may causes big trouble.
         */
        BankAccountNewImpl bankAccountNewImpl = new BankAccountNewImpl(1, "Halit Yurtsever", "Tuzla", 1000, 1.5);

        /**
         * And here you can see the implementation of Builder Pattern. It may tricky to read but easy to implement.
         * This is a software engineering method to generating object oriented APIs that name is "Fluent Interface".
         */
        BankAccountWithBuilder bankAccountWithBuilder = new BankAccountWithBuilder
                                                            .Builder(1)
                                                            .WithOwner("Halit Yurtsever")
                                                            .AtBranch("Tuzla")
                                                            .OpeningBalance(1000)
                                                            .AtRate(1.5)
                                                            .Build();
    }
}
