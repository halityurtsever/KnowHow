using System;
using System.Diagnostics;
using System.IO;

namespace CodeHelpers
{
    public static class Tracer
    {
        //################################################################################
        #region Constants

        private const string c_LogFilePrefix = "Log";
        private static string m_LogFilePath = string.Empty;

        #endregion

        //################################################################################
        #region Fields

        private static readonly Stopwatch m_StopWatch = new Stopwatch();

        #endregion

        //################################################################################
        #region Static Implementation

        public static void ToOutput(string output, bool isLogToFile)
        {
            Debug.WriteLine(output);

            if (isLogToFile)
            {
                ToFile(output); 
            }
        }

        public static void StartTimer()
        {
            m_StopWatch.Start();
        }

        public static string StopTimer()
        {
            m_StopWatch.Stop();
            var elapsedTime = m_StopWatch.Elapsed;
            m_StopWatch.Reset();

            return $"{elapsedTime.Milliseconds}";
        }

        public static void CurrentArray(int[] array, bool isLogToFile)
        {
            var arrayOutput = string.Empty;
            for (int j = 0; j < array.Length; j++)
            {
                arrayOutput += $"{array[j]}-";
            }

            ToOutput($"CURRENT ARRAY: {arrayOutput.Substring(0, arrayOutput.Length - 1)}", isLogToFile);
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private static string GenerateLogFileName()
        {
            var postfix = DateTime.UtcNow.ToString("yyyy.MM.dd_HH.mm.ss");

            return $"{c_LogFilePrefix}_{postfix}.txt";
        }

        private static string CreateLogFile()
        {
            //Generate a log filename
            var filename = GenerateLogFileName();

            //Get root path of C drive
            var rootFolder = Path.GetPathRoot(Environment.SystemDirectory);
            var logFolder = Path.Combine(rootFolder, "logs");

            //Create log folder, if it not exists
            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            //Create log file and close it
            var filePath = Path.Combine(logFolder, filename);
            var file = File.Create(filePath);
            file.Close();

            return filePath;
        }

        private static void ToFile(string output)
        {
            //if (string.IsNullOrEmpty(m_LogFilePath))
            //{
            //    m_LogFilePath = CreateLogFile();
            //}

            //TODO: Write output to a log file.
        }

        #endregion
    }
}
