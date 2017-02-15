using System;
using System.Diagnostics;
using System.IO;

namespace CodeHelpers
{
    public class Tracer
    {
        //################################################################################
        #region Constants

        private const string c_LogFilePrefix = "Log";

        #endregion

        //################################################################################
        #region Fields

        private readonly string m_LogFilePath;
        private readonly bool m_IsLogToFile;
        private readonly OutputType m_OutputType;
        private readonly Stopwatch m_StopWatch = new Stopwatch();

        #endregion

        //################################################################################
        #region Constructor

        public Tracer(OutputType outputType, bool isLogToFile)
        {
            m_LogFilePath = CreateLogFile();
            m_OutputType = outputType;
            m_IsLogToFile = isLogToFile;
        }

        #endregion

        //################################################################################
        #region Public Implementation

        public void WriteOutput(string output)
        {
            switch (m_OutputType)
            {
                case OutputType.NoneUI:
                    NoUIOutput(output);
                    break;

                case OutputType.Debug:
                    DebugOutput(output);
                    break;

                case OutputType.Console:
                    ConsoleOutput(output);
                    break;
            }
        }

        public void StartTimer()
        {
            m_StopWatch.Start();
        }

        public string StopTimer()
        {
            m_StopWatch.Stop();
            var elapsedTime = m_StopWatch.Elapsed;
            m_StopWatch.Reset();

            return $"{elapsedTime}";
        }

        public void CurrentArray(int[] array)
        {
            if (m_OutputType == OutputType.NoneUI && !m_IsLogToFile)
            {
                return;
            }

            var arrayOutput = string.Empty;
            for (int j = 0; j < array.Length; j++)
            {
                arrayOutput += $"{array[j]}-";
            }

            var output = $"CURRENT ARRAY: {arrayOutput.Substring(0, arrayOutput.Length - 1)}";
            WriteOutput(output);
        }

        #endregion

        //################################################################################
        #region Private Implementation

        private void NoUIOutput(string output)
        {
            if (m_IsLogToFile)
            {
                OutputToLogFile(output);
            }
        }

        private void DebugOutput(string output)
        {
            Debug.WriteLine(output);

            if (m_IsLogToFile)
            {
                OutputToLogFile(output);
            }
        }

        private void ConsoleOutput(string output)
        {
            Console.WriteLine(output);

            if (m_IsLogToFile)
            {
                OutputToLogFile(output);
            }
        }

        private string GenerateLogFileName()
        {
            var postfix = DateTime.UtcNow.ToString("yyyy.MM.dd_HH.mm.ss");

            return $"{c_LogFilePrefix}_{postfix}.txt";
        }

        private string CreateLogFile()
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

        private void OutputToLogFile(string output)
        {
            using (var stream = File.AppendText(m_LogFilePath))
            {
                var textWriter = TextWriter.Synchronized(stream);
                textWriter.WriteLine(output);
            }
        }

        #endregion
    }
}
