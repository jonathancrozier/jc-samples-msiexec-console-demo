using Serilog;
using System.Diagnostics;

namespace JC.Samples.MsiExecConsoleDemo.Helpers
{
    /// <summary>
    /// Provides methods to help with interacting with processes.
    /// </summary>
    public class ProcessHelper
    {
        #region Methods
        
        /// <summary>
        /// Creates a process that runs in the background with no UI.
        /// </summary>
        /// <param name="processFilePath">The file path for the process to start</param>
        /// <param name="processArguments">The command-line arguments to use</param>
        /// <returns>The created hidden process</returns>
        public static Process CreateHiddenProcess(string processFilePath, string processArguments)
        {
            Log.Information("Creating hidden process '{0}' with arguments '{1}'", processFilePath, processArguments);

            var process                   = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName    = processFilePath;
            process.StartInfo.Arguments   = processArguments;

            Log.Information("Hidden process '{0}' with arguments '{1}' created", processFilePath, processArguments);

            return process;
        }

        #endregion
    }
}