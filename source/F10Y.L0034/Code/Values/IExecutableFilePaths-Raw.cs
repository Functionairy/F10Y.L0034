using System;

using F10Y.T0003;


namespace F10Y.L0034.Raw
{
    [ValuesMarker]
    public partial interface IExecutableFilePaths
    {
        /// <summary>
        /// <para><value>C:\Users\davidcoats\AppData\Local\Programs\Microsoft VS Code\bin\code.cmd</value></para>
        /// </summary>
        string VisualStudio_Code_Windows_davidcoats => @"C:\Users\davidcoats\AppData\Local\Programs\Microsoft VS Code\bin\code.cmd";

        /// <summary>
        /// <para><value>C:\Users\David\AppData\Local\Programs\Microsoft VS Code\bin\code.cmd</value></para>
        /// </summary>
        string VisualStudio_Code_Windows_David => @"C:\Users\David\AppData\Local\Programs\Microsoft VS Code\bin\code.cmd";

        /// <summary>
        /// <para><value>/usr/local/bin/code</value></para>
        /// </summary>
        string VisualStudio_Code_MacOS => "/Applications/Visual Studio Code.app/Contents/Resources/app/bin/code";
    }
}
