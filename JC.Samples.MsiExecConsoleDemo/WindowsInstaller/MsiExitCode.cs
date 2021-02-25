using System.ComponentModel;

namespace JC.Samples.MsiExecConsoleDemo.WindowsInstaller
{
    #region Enums

    /// <summary>
    /// Holds all available MSI exit codes.
    /// See the following URL for reference:-
    /// https://msdn.microsoft.com/en-us/library/aa376931(v=vs.85).aspx
    /// </summary>
    public enum MsiExitCode
    {
        /// <summary>
        /// Action completed successfully.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS
        /// </value>
        [Description("Action completed successfully.")]
        Success = 0,

        /// <summary>
        /// The data is invalid.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_DATA
        /// </value>
        [Description("The data is invalid.")]
        InvalidDataError = 13,

        /// <summary>
        /// One of the parameters was invalid.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_PARAMETER
        /// </value>
        [Description("One of the parameters was invalid.")]
        InvalidParameterError = 87,

        /// <summary>
        /// This function is not available for this platform. 
        /// It is only available on Windows 2000 and 
        /// Windows XP with Window Installer version 2.0.
        /// </summary>
        /// <value>
        /// ERROR_CALL_NOT_IMPLEMENTED
        /// </value>
        [Description("This value is returned when a custom action attempts to call a function that cannot be called from custom actions. The function returns the value ERROR_CALL_NOT_IMPLEMENTED. Available beginning with Windows Installer version 3.0.")]
        CallNotImplementedError = 120,

        /// <summary>
        /// This error code only occurs when using Windows Installer version 2.0 and Windows XP or later. 
        /// If Windows Installer determines a product may be incompatible with the current operating system, it displays a dialog informing the user and asking whether to try to install anyway. 
        /// This error code is returned if the user chooses not to try the installation.
        /// </summary>
        /// <value>
        /// ERROR_APPHELP_BLOCK 
        /// </value>        
        [Description("If Windows Installer determines a product may be incompatible with the current operating system, it displays a dialog box informing the user and asking whether to try to install anyway. This error code is returned if the user chooses not to try the installation.")]
        ApplicationHelpBlockedError = 1259,

        /// <summary>
        /// The Windows Installer service could not be accessed. 
        /// Contact your support personnel to verify that the Windows Installer service is properly registered.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SERVICE_FAILURE
        /// </value>
        [Description("The Windows Installer service could not be accessed. Contact your support personnel to verify that the Windows Installer service is properly registered.")]
        InstallServiceFailureError = 1601,

        /// <summary>
        /// User cancels installation.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_USEREXIT
        /// </value>
        [Description("The user cancels installation.")]
        UserExitError = 1602,

        /// <summary>
        /// Fatal error during installation.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_FAILURE
        /// </value>
        [Description("A fatal error occurred during installation.")]
        FatalInstallFailureError = 1603,

        /// <summary>
        /// Installation suspended, incomplete.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SUSPEND
        /// </value>
        [Description("Installation suspended, incomplete.")]
        InstallSuspendedError = 1604,

        /// <summary>
        /// This action is only valid for products that are currently installed.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_PRODUCT
        /// </value>
        //[Description("This action is only valid for products that are currently installed.")]
        UnknownProductError = 1605,

        /// <summary>
        /// Feature ID not registered.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_FEATURE
        /// </value>
        [Description("The feature identifier is not registered.")]
        UnknownFeatureError = 1606,

        /// <summary>
        /// Component ID not registered.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_COMPONENT
        /// </value>
        [Description("The component identifier is not registered.")]
        UnknownComponentError = 1607,

        /// <summary>
        /// Unknown property.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_PROPERTY
        /// </value>
        [Description("This is an unknown property.")]
        UnknownPropertyError = 1608,

        /// <summary>
        /// Handle is in an invalid state.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_HANDLE_STATE
        /// </value>
        [Description("The handle is in an invalid state.")]
        InvalidHandleStateError = 1609,

        /// <summary>
        /// The configuration data for this product is corrupt. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_BAD_CONFIGURATION
        /// </value>
        [Description("The configuration data for this product is corrupt. Contact your support personnel.")]
        BadConfigurationError = 1610,

        /// <summary>
        /// Component qualifier not present.
        /// </summary>
        /// <value>
        /// ERROR_INDEX_ABSENT
        /// </value>
        [Description("The component qualifier not present.")]
        IndexAbsentError = 1611,

        /// <summary>
        /// The installation source for this product is not available. 
        /// Verify that the source exists and that you can access it.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SOURCE_ABSENT
        /// </value>
        [Description("The installation source for this product is not available. Verify that the source exists and that you can access it.")]
        InstallSourceAbsentError = 1612,

        /// <summary>
        /// This installation package cannot be installed by the Windows Installer service. 
        /// You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_VERSION
        /// </value>
        [Description("This installation package cannot be installed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.")]
        WrongInstallPackageVersionError = 1613,

        /// <summary>
        /// Product is uninstalled.
        /// </summary>
        /// <value>
        /// ERROR_PRODUCT_UNINSTALLED
        /// </value>
        [Description("The product is uninstalled.")]
        ProductUninstalledError = 1614,

        /// <summary>
        /// SQL query syntax invalid or unsupported.
        /// </summary>
        /// <value>
        /// ERROR_BAD_QUERY_SYNTAX
        /// </value>
        [Description("The SQL query syntax is invalid or unsupported.")]
        BadQuerySyntaxError = 1615,

        /// <summary>
        /// Record field does not exist.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_FIELD
        /// </value>
        [Description("The record field does not exist.")]
        InvalidFieldError = 1616,

        /// <summary>
        /// Another installation is already in progress. 
        /// Complete that installation before proceeding with this install.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_ALREADY_RUNNING
        /// </value>
        [Description("Another installation is already in progress. Complete that installation before proceeding with this install. For information about the mutex, see _MSIExecute Mutex.")]
        InstallInProgressError = 1618,

        /// <summary>
        /// This installation package could not be opened. 
        /// Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_OPEN_FAILED
        /// </value>
        [Description("This installation package could not be opened. Verify that the package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer package.")]
        InstallPackageOpenError = 1619,

        /// <summary>
        /// This installation package could not be opened. 
        /// Contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_INVALID
        /// </value>
        [Description("This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.")]
        InstallPackageInvalidError = 1620,

        /// <summary>
        /// There was an error starting the Windows Installer service user interface. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_UI_FAILURE
        /// </value>
        [Description("There was an error starting the Windows Installer service user interface. Contact your support personnel.")]
        InstallUIError = 1621,

        /// <summary>
        /// Error opening installation log file. 
        /// Verify that the specified log file location exists and is writable.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_LOG_FAILURE
        /// </value>
        [Description("There was an error opening installation log file. Verify that the specified log file location exists and is writable.")]
        InstallLogError = 1622,

        /// <summary>
        /// This language of this installation package is not supported by your system.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_LANGUAGE_UNSUPPORTED
        /// </value>
        [Description("This language of this installation package is not supported by your system.")]
        InstallLanguageUnsupportedError = 1623,

        /// <summary>
        /// Error applying transforms. 
        /// Verify that the specified transform paths are valid.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TRANSFORM_FAILURE
        /// </value>
        [Description("There was an error applying transforms. Verify that the specified transform paths are valid.")]
        InstallTransformError = 1624,

        /// <summary>
        /// This installation is forbidden by system policy. 
        /// Contact your system administrator.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PACKAGE_REJECTED
        /// </value>
        [Description("This installation is forbidden by system policy. Contact your system administrator.")]
        InstallPackageRejectedError = 1625,

        /// <summary>
        /// Function could not be executed.
        /// </summary>
        /// <value>
        /// ERROR_FUNCTION_NOT_CALLED
        /// </value>
        [Description("The function could not be executed.")]
        FunctionNotCalledError = 1626,

        /// <summary>
        /// Function failed during execution.
        /// </summary>
        /// <value>
        /// ERROR_FUNCTION_FAILED
        /// </value>
        [Description("The function failed during execution.")]
        FunctionFailedError = 1627,

        /// <summary>
        /// Invalid or unknown table specified.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_TABLE
        /// </value>
        [Description("An invalid or unknown table was specified.")]
        InvalidTableError = 1628,

        /// <summary>
        /// Data supplied is of wrong type.
        /// </summary>
        /// <value>
        /// ERROR_DATATYPE_MISMATCH
        /// </value>
        [Description("The data supplied is the wrong type.")]
        DatatypeMismatchError = 1629,

        /// <summary>
        /// Data of this type is not supported.
        /// </summary>
        /// <value>
        /// ERROR_UNSUPPORTED_TYPE
        /// </value>
        [Description("Data of this type is not supported.")]
        UnsupportedTypeError = 1630,

        /// <summary>
        /// The Windows Installer service failed to start. 
        /// Contact your support personnel.
        /// </summary>
        /// <value>
        /// ERROR_CREATE_FAILED
        /// </value>
        [Description("The Windows Installer service failed to start. Contact your support personnel.")]
        CreateFailedError = 1631,

        /// <summary>
        /// The temp folder is either full or inaccessible. 
        /// Verify that the temp folder exists and that you can write to it.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TEMP_UNWRITABLE
        /// </value>
        [Description("The Temp folder is either full or inaccessible. Verify that the Temp folder exists and that you can write to it.")]
        InstallTempUnwritableError = 1632,

        /// <summary>
        /// This installation package is not supported on this platform. 
        /// Contact your application vendor.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_PLATFORM_UNSUPPORTED
        /// </value>
        [Description("This installation package is not supported on this platform. Contact your application vendor.")]
        InstallPlatformUnsupportedError = 1633,

        /// <summary>
        /// Component not used on this machine
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_NOTUSED
        /// </value>
        [Description("Component is not used on this machine.")]
        InstallNotusedError = 1634,

        /// <summary>
        /// This patch package could not be opened. 
        /// Verify that the patch package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer patch package.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_OPEN_FAILED
        /// </value>
        [Description("This patch package could not be opened. Verify that the patch package exists and is accessible, or contact the application vendor to verify that this is a valid Windows Installer patch package.")]
        PatchPackageOpenFailedError = 1635,

        /// <summary>
        /// This patch package could not be opened. 
        /// Contact the application vendor to verify that this is a valid Windows Installer patch package.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_INVALID
        /// </value>
        [Description("This patch package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer patch package.")]
        PatchPackageInvalidError = 1636,

        /// <summary>
        /// This patch package cannot be processed by the Windows Installer service. 
        /// You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_UNSUPPORTED
        /// </value>
        [Description("This patch package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.")]
        PatchPackageUnsupportedError = 1637,

        /// <summary>
        /// Another version of this product is already installed. 
        /// Installation of this version cannot continue. 
        /// To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.
        /// </summary>
        /// <value>
        /// ERROR_PRODUCT_VERSION
        /// </value>
        [Description("Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs in Control Panel.")]
        ProductVersionError = 1638,

        /// <summary>
        /// Invalid command line argument. 
        /// Consult the Windows Installer SDK for detailed command line help.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_COMMAND_LINE
        /// </value>
        [Description("Invalid command line argument. Consult the Windows Installer SDK for detailed command-line help.")]
        InvalidCommandLineError = 1639,

        /// <summary>
        /// Installation from a Terminal Server client session not permitted for current user.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_REMOTE_DISALLOWED
        /// </value>
        [Description("The current user is not permitted to perform installations from a client session of a server running the Terminal Server role service.")]
        RemoteInstallDisallowedError = 1640,

        /// <summary>
        /// The installer has started a reboot. 
        /// This error code not available on Windows Installer version 1.0.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS_REBOOT_INITIATED
        /// </value>
        [Description("The installer has initiated a restart. This message is indicative of a success.")]
        RebootSuccessInitiatedError = 1641,

        /// <summary>
        /// The installer cannot install the upgrade patch because the program being upgraded may be missing or the upgrade patch updates a different version of the program. 
        /// Verify that the program to be upgraded exists on your computer and that you have the correct upgrade patch. 
        /// </summary>
        /// <value>
        /// ERROR_PATCH_TARGET_NOT_FOUND
        /// </value>
        [Description("The installer cannot install the upgrade patch because the program being upgraded may be missing or the upgrade patch updates a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade patch.")]
        PatchTargetNotFoundError = 1642,

        /// <summary>
        /// The patch package is not permitted by system policy. 
        /// This error code is available with Windows Installer versions 2.0 or later.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_PACKAGE_REJECTED
        /// </value>
        [Description("The patch package is not permitted by system policy.")]
        PatchPackageRejectedError = 1643,

        /// <summary>
        /// One or more customizations are not permitted by system policy. 
        /// This error code is available with Windows Installer versions 2.0 or later.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_TRANSFORM_REJECTED
        /// </value>
        [Description("One or more customizations are not permitted by system policy.")]
        InstallTransformRejectedError = 1644,

        /// <summary>
        /// Windows Installer does not permit installation from a Remote Desktop Connection.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_REMOTE_PROHIBITED
        /// </value>
        [Description("Windows Installer does not permit installation from a Remote Desktop Connection.")]
        RemoteInstallProhibitedError = 1645,

        /// <summary>
        /// The patch package is not a removable patch package.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_REMOVAL_UNSUPPORTED
        /// </value>
        [Description("The patch package is not a removable patch package. Available beginning with Windows Installer version 3.0.")]
        PatchRemovalUnsupportedError = 1646,

        /// <summary>
        /// The patch is not applied to this product.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_UNKNOWN_PATCH
        /// </value>
        [Description("The patch is not applied to this product. Available beginning with Windows Installer version 3.0.")]
        UnknownPatchError = 1647,

        /// <summary>
        /// No valid sequence could be found for the set of patches.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_NO_SEQUENCE
        /// </value>
        [Description("No valid sequence could be found for the set of patches. Available beginning with Windows Installer version 3.0.")]
        PatchNoSequenceError = 1648,

        /// <summary>
        /// Patch removal was disallowed by policy.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_REMOVAL_DISALLOWED
        /// </value>
        [Description("Patch removal was disallowed by policy. Available beginning with Windows Installer version 3.0.")]
        PatchRemovalDisallowedError = 1649,

        /// <summary>
        /// The XML patch data is invalid.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_INVALID_PATCH_XML
        /// </value>
        [Description("The XML patch data is invalid. Available beginning with Windows Installer version 3.0.")]
        InvalidPatchXMLError = 1650,

        /// <summary>
        /// Administrative user failed to apply patch for a per-user managed or a per-machine application that is in advertise state.
        /// Available beginning with Windows Installer version 3.0.
        /// </summary>
        /// <value>
        /// ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT
        /// </value>
        [Description("Administrative user failed to apply patch for a per-user managed or a per-machine application that is in advertise state. Available beginning with Windows Installer version 3.0.")]
        PatchManagedAdvertisedProductError = 1651,

        /// <summary>
        /// Windows Installer is not accessible when the computer is in Safe Mode.
        /// Exit Safe Mode and try again or try using System Restore to return your computer to a previous state.
        /// Available beginning with Windows Installer version 4.0.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_SERVICE_SAFEBOOT
        /// </value>
        [Description("Windows Installer is not accessible when the computer is in Safe Mode. Exit Safe Mode and try again or try using System Restore to return your computer to a previous state. Available beginning with Windows Installer version 4.0.")]
        InstallServiceSafeBootError = 1652,

        /// <summary>
        /// Could not perform a multiple-package transaction because rollback has been disabled.
        /// Multiple-Package Installations cannot run if rollback is disabled.
        /// Available beginning with Windows Installer version 4.5.
        /// </summary>
        /// <value>
        /// ERROR_ROLLBACK_DISABLED
        /// </value>
        [Description("Could not perform a multiple-package transaction because rollback has been disabled. Multiple-Package Installations cannot run if rollback is disabled. Available beginning with Windows Installer version 4.5.")]
        RollbackDisabledError = 1653,

        /// <summary>
        /// The app that you are trying to run is not supported on this version of Windows.
        /// A Windows Installer package, patch, or transform that has not been signed by Microsoft cannot be installed on an ARM computer.
        /// </summary>
        /// <value>
        /// ERROR_INSTALL_REJECTED
        /// </value>
        [Description("The app that you are trying to run is not supported on this version of Windows. A Windows Installer package, patch, or transform that has not been signed by Microsoft cannot be installed on an ARM computer.")]
        InstallRejectedError = 1654,

        /// <summary>
        /// A reboot is required to complete the install. 
        /// This does not include installs where the ForceReboot action is run. 
        /// This error code not available on Windows Installer version 1.0.
        /// </summary>
        /// <value>
        /// ERROR_SUCCESS_REBOOT_REQUIRED
        /// </value>
        [Description("A restart is required to complete the install. This message is indicative of a success. This does not include installs where the ForceReboot action is run.")]
        RebootRequiredSuccessError = 3010
    }

    #endregion
}