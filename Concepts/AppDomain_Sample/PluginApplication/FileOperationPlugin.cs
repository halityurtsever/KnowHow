using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

using Contents.AppDomain_Sample.PluginAdapter;

namespace Contents.AppDomain_Sample.PluginApplication
{
    public class FileOperationPlugin : MarshalByRefObject, IPluginService
    {
        //######################################################################
        #region DLL Imports

        [DllImport("kernel32.dll")]
        static extern uint GetCompressedFileSizeW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpFileName,
            [Out, MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        static extern int GetDiskFreeSpaceW(
            [In, MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName,
            out uint lpSectorsPerCluster,
            out uint lpBytesPerSector,
            out uint lpNumberOfFreeClusters,
            out uint lpTotalNumberOfClusters);

        #endregion

        //######################################################################
        #region Fields

        private string m_FilePath;

        #endregion

        //######################################################################
        #region Private Implementation

        private long GetFileSizeOnDisk()
        {
            FileInfo fileInfo = new FileInfo(m_FilePath);
            if (fileInfo.Directory == null) return 0;

            int result = GetDiskFreeSpaceW(
                fileInfo.Directory.Root.FullName,
                out uint sectorsPerCluster,
                out uint bytesPerSector,
                out uint dummy,
                out dummy);

            if (result == 0) throw new Win32Exception();

            uint clusterSize = sectorsPerCluster * bytesPerSector;

            uint losize = GetCompressedFileSizeW(m_FilePath, out uint hosize);
            var size = (long)hosize << 32 | losize;
            return ((size + clusterSize - 1) / clusterSize) * clusterSize;
        }

        #endregion

        //######################################################################
        #region IPluginService Implementation

        string IPluginService.FilePath
        {
            get
            {
                return m_FilePath;
            }

            set
            {
                m_FilePath = value;
            }
        }

        long IPluginService.FileLength
        {
            get
            {
                FileInfo fileInfo = new FileInfo(m_FilePath);
                return fileInfo.Length;
            }
        }

        long IPluginService.FileSizeOnDisc => GetFileSizeOnDisk();

        bool IPluginService.CreateFile()
        {
            try
            {
                var fileStream = File.Create(m_FilePath);
                fileStream.Close();
                Console.WriteLine("File is created.");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("File cannot be created.");
                return false;
            }
        }

        bool IPluginService.WriteFile(string content)
        {
            try
            {
                File.AppendAllText(m_FilePath, content);
                Console.WriteLine($"Content '{content}' is written to the file.");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Content cannot be written into the file.");
                return false;
            }
        }

        bool IPluginService.ReadFile(out string content)
        {
            try
            {
                content = File.ReadAllText(m_FilePath);
                Console.WriteLine("File is read.");
                return true;
            }
            catch (Exception)
            {
                content = string.Empty;
                Console.WriteLine("File cannot be read.");
                return false;
            }
        }

        bool IPluginService.DeleteFile()
        {
            try
            {
                File.Delete(m_FilePath);
                Console.WriteLine("File is deleted.");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("File cannot be deleted.");
                return false;
            }
        }

        #endregion
    }
}
