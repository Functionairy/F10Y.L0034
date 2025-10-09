using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.L0034
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.IExecutableFilePaths _Raw => Raw.ExecutableFilePaths.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>C:\Users\davidcoats\AppData\Local\Programs\Microsoft VS Code\bin\code.cmd</value></para>
        /// </summary>
        string VisualStudio_Code => Instances.OperatingSystemOperator.SwitchOn_OSPlatform(
            () => Instances.PathOperator.Get_FilePath(
                Instances.DirectoryPaths.ApplicationData_Local,
                @"Programs\Microsoft VS Code\bin\code.cmd"),
            () => Instances.PathOperator.Get_FilePath(
                Instances.DirectoryPaths.Program_Files,
                @"Visual Studio Code.app/Contents/Resources/app/bin/code"),
            () => throw new NotImplementedException()
        );
    }
}
