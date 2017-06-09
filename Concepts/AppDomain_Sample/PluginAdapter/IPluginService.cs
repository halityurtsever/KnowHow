
namespace Contents.AppDomain_Sample.PluginAdapter
{
    public interface IPluginService
    {
        //################################################################################
        #region Properties

        string FilePath { get; set; }

        long FileLength { get; }

        long FileSizeOnDisc { get; }

        #endregion

        //################################################################################
        #region Methods

        bool CreateFile();

        bool WriteFile(string content);

        bool ReadFile(out string content);

        bool DeleteFile();

        #endregion

    }
}
