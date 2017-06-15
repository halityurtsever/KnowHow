
namespace DataStructures.Arrays.JaggedArrays
{
    class JaggedArrays_Program
    {
        //a.k.a Array of Arrays

        static void Main(string[] args)
        {
            #region Two Level Jagged Array

            int[][] jagged2 = new int[][] { };

            //Second level isn't allowed to initialize, because of each array size in the top array may varies.
            int[][] jagged2WithInitials = new int[5][];

            //As you can see each inner array has initialized with different size
            int[][] jagged2Initialized = new int[3][]
                                             {
                                                 new int[] { 1, 2, 3, 4 },
                                                 new int[] { 3, 4, 5, 6, 7, 8, 9 },
                                                 new int[] { 5, 6 }
                                             };

            #endregion

            #region Three Level Jagged Array

            int[][][] jagged3 = new int[][][] { };

            int[][][] jagged3WithInitials = new int[3][][];

            int[][][] jagged3Initialized = new int[3][][]
                                               {
                                                   new int[2][]
                                                       {
                                                           new int[] { 1, 2, 3 },
                                                           new int[] { 1, 2, 3, 4, 5 }
                                                       },
                                                   new int[4][]
                                                       {
                                                           new int[] { 5, 6, 7, 8 },
                                                           new int[] { 1, 5 },
                                                           new int[] { 4, 5, 6 },
                                                           new int[] { 7, 8, 9, 0 }
                                                       },
                                                   new int[3][]
                                                       {
                                                           new int[] { 1, 3, 4, 5 },
                                                           new int[] { 4, 5, 6, 7, 8, 9, 0 },
                                                           new int[] { 9, 0 }
                                                       }
                                               };

            #endregion
        }
    }
}
