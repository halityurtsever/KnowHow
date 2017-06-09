using System;
using System.Security;
using System.Security.Permissions;

using Contents.AppDomain_Sample.PluginAdapter;

namespace Concepts.AppDomain_Sample.MainApplication
{
    public class Program
    {
        static void Main()
        {
            //Create a setup for sub domain
            AppDomainSetup subDomainSetup = new AppDomainSetup();
            subDomainSetup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            //Set permissions that allows to create and write to file
            //FileSizeOnDisc property also requires unrestricted PermissionState
            PermissionSet permissionSet = new PermissionSet(PermissionState.Unrestricted);
            SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.Execution);
            FileIOPermission fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
            fileIOPermission.AllFiles = FileIOPermissionAccess.AllAccess;

            permissionSet.AddPermission(securityPermission);
            permissionSet.AddPermission(fileIOPermission);

            //Create sub domain with defined setup and permission set
            AppDomain subDomain = AppDomain.CreateDomain("PluginSubDomain", null, subDomainSetup, permissionSet);

            //Define assembly and type name that want to execute
            string assemblyName = "PluginApplication";
            string typeName = "Contents.AppDomain_Sample.PluginApplication.FileOperationPlugin";

            //Instantiate a new object which is defined in the sub domain assembly
            IPluginService pluginService = (IPluginService)subDomain.CreateInstanceAndUnwrap(assemblyName, typeName);

            #region SubDomain object implementation

            pluginService.FilePath = @"C:\tmp\test.txt";

            //Create file
            pluginService.CreateFile();
            Console.WriteLine($"> File Length: {pluginService.FileLength}");
            Console.WriteLine($"> File Size on Disc: {pluginService.FileSizeOnDisc}"); //Requires unrestricted permission state

            //Write to file
            pluginService.WriteFile("Halit Yurtsever");
            Console.WriteLine($"> File Length: {pluginService.FileLength}");
            Console.WriteLine($"> File Size on Disc: {pluginService.FileSizeOnDisc}");

            //Read file
            string content;
            pluginService.ReadFile(out content);
            Console.WriteLine($"> File Content: {content}");

            //Delete file
            pluginService.DeleteFile();

            #endregion

            //Unload sub domain when finish your work
            AppDomain.Unload(subDomain);
        }
    }
}
