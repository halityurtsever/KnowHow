using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

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

        public static void ToOutput(string output)
        {
            Debug.WriteLine(output);
        }

        public static void ToFile(string output)
        {
            if (string.IsNullOrEmpty(m_LogFilePath))
            {
                m_LogFilePath = CreateLogFile();
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

        #endregion
    }
}
