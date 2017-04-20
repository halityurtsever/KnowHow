
namespace DesignPatterns.Creational.Singleton
{
    //################################################################################
    #region Singleton Not Thread Safe

    public class SingletonNotThreadSafe
    {
        //################################################################################
        #region Static Fields

        private static SingletonNotThreadSafe s_SingletonNotThreadSafe;

        #endregion

        //################################################################################
        #region Constructor

        private SingletonNotThreadSafe()
        {
        }

        #endregion

        //################################################################################
        #region Properties

        public SingletonNotThreadSafe Instance
        {
            get
            {
                if (s_SingletonNotThreadSafe == null)
                {
                    s_SingletonNotThreadSafe = new SingletonNotThreadSafe();
                }

                return s_SingletonNotThreadSafe;
            }
        }

        #endregion
    }

    #endregion

    //################################################################################
    #region Singleton Simple Thread Safety

    public class SingletonSimpleThreadSafety
    {
        //################################################################################
        #region Static Fields

        private static SingletonSimpleThreadSafety s_SingletonSimpleThreadSafety;
        private static readonly object SyncLock = new object();

        #endregion

        //################################################################################
        #region Constructor

        private SingletonSimpleThreadSafety()
        {
        }

        #endregion

        //################################################################################
        #region Properties

        public SingletonSimpleThreadSafety Instance
        {
            get
            {
                lock (SyncLock)
                {
                    if (s_SingletonSimpleThreadSafety == null)
                    {
                        s_SingletonSimpleThreadSafety = new SingletonSimpleThreadSafety();
                    }

                    return s_SingletonSimpleThreadSafety;
                }
            }
        }

        #endregion
    }

    #endregion

    //################################################################################
    #region Singleton Double Check Thread Safety

    public class SingletonDoubleCheckThreadSafety
    {
        //################################################################################
        #region Static Fields

        //volatile guarantees object to instantiate 
        private static volatile SingletonDoubleCheckThreadSafety s_SingletonDoubleCheckThreadSafety;
        private static readonly object SyncLock = new object();

        #endregion

        //################################################################################
        #region Constructor

        private SingletonDoubleCheckThreadSafety()
        {
        }

        #endregion

        //################################################################################
        #region Properties

        public SingletonDoubleCheckThreadSafety Instance
        {
            get
            {
                //this check prevents unnecessary locking on each Instance call
                if (s_SingletonDoubleCheckThreadSafety == null)
                {
                    lock (SyncLock)
                    {
                        /**
                         * this check prevents re-instantiating the singleton object
                         * 
                         * sample scenario:
                         * - process #1 calls Instance property
                         * - process #2 calls Instance property
                         * - process #1 locks and instantiates Singleton object, and
                         *   process #2 waits for releasing lock object
                         *   
                         * if below null check not exists, process #2 would re-instantiate singleton object
                         * 
                         */
                        if (s_SingletonDoubleCheckThreadSafety == null)
                        {
                            s_SingletonDoubleCheckThreadSafety = new SingletonDoubleCheckThreadSafety();
                        }
                    }
                }

                return s_SingletonDoubleCheckThreadSafety;
            }
        }

        #endregion
    }

    #endregion
}
