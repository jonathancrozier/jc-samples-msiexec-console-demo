# Samples - MsiExec Console Demo
An example of how to install and uninstall programs using msiexec via C# and a custom ```MsiPackage``` class.

```csharp
// Configure the MSI package details.
string baseDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

var msiPackage = new MsiPackage(
    pathToInstallerFile   : Path.Combine(baseDirectory, "Msi", "InstEd-1.5.15.26.msi"),
    pathToInstallLogFile  : Path.Combine(baseDirectory, "install-logs", "install.log"),
    pathToUninstallLogFile: Path.Combine(baseDirectory, "uninstall-logs", "unintall.log"));

// Install the program.
msiPackage.Install();

// Uninstall the program.
msiPackage.Uninstall();
```
