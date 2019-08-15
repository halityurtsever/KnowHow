using System;

namespace CascadeDisposeCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var subType = new SubType())
            {
                subType.SubMethod();
            }
        }
    }

    class BaseType : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposed: BaseType");
        }
    }

    class SubType : BaseType
    {
        private WrappedType wrappedType = new WrappedType();

        internal void SubMethod()
        {
            Console.WriteLine("Sub method is called.");

            using (var wrappedType = new WrappedType())
            {
                wrappedType.WrappedMethod();
            }
        }
    }

    class WrappedType : IDisposable
    {
        internal void WrappedMethod()
        {
            Console.WriteLine("Wrapped method is called.");
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    Console.WriteLine("Disposed: WrappedType");
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~WrappedType() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion

    }
}
