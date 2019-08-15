using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Program
    {
        //You can increase this number to fill up more memory
        const int c_NumberOfFinalizeObjects = 1000;

        //You can increase this number to cause more post-finalization work to be done
        const int c_MaxIterations = 100;

        static void Main()
        {
            FinalizeObject fo = null;

            //Create and release a large number of objects that require finalization
            for (int i = 0; i < c_NumberOfFinalizeObjects; i++)
            {
                fo = new FinalizeObject(i);
            }

            //Release the last object created in the loop
            fo = null;

            //Force garbage collection
            GC.Collect();

            //Wait for all finalizers to complete before continuing.
            //Without this call, the worker loop below might execute at the same time as finalizers.
            //With this call, the worker loop executes only after all finalizers have been called.
            GC.WaitForPendingFinalizers();

            //Worker loop to perform post-finalization code.
            for (int i = 0; i < c_MaxIterations; i++)
            {
                Console.WriteLine("Doing some post-finalize work.");
            }
        }
    }

    internal class FinalizeObject
    {
        //Make this number very large to cause the finalizer to do more work
        private const int c_MaxIterations = 10000;

        private int m_ObjectId;

        public FinalizeObject(int id)
        {
            m_ObjectId = id;
        }

        ~FinalizeObject()
        {
            Console.WriteLine($"Finalizing a FinalizeObject:{{{m_ObjectId}}}");

            //Do some work
            for (int i = 0; i < c_MaxIterations; i++)
            {
                //This method performs no operation on i,
                //but prevents the JIT compiler from optimizing away the code inside the loop
                GC.KeepAlive(i);
            }
        }
    }
}
