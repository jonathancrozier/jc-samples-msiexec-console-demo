using JC.Samples.MsiExecConsoleDemo.WindowsInstaller;
using Serilog;
using System;
using System.IO;

namespace JC.Samples.MsiExecConsoleDemo
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    class Program
    {
        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command-line arguments</param>
        static void Main(string[] args)
        {
            // Configure logging.
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Verbose()
               .WriteTo.Console()
               .CreateLogger();

            // Configure the MSI package details.
            string baseDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            var msiPackage = new MsiPackage(
                pathToInstallerFile   : Path.Combine(baseDirectory, "Msi", "InstEd-1.5.15.26.msi"),
                pathToInstallLogFile  : Path.Combine(baseDirectory, "install-logs", "install.log"),
                pathToUninstallLogFile: Path.Combine(baseDirectory, "uninstall-logs", "unintall.log"));

            // Install the program.
            Log.Information("Installing program");
            msiPackage.Install();

            // Uninstall the program.
            Log.Information("Uninstalling program");
            msiPackage.Uninstall();

            // Inform the user that the program has completed.
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");

            Console.ReadKey(true);
        }

        #endregion
    }
}