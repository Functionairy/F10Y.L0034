using System;
using System.Collections.Generic;
using System.Linq;

using F10Y.T0002;


namespace F10Y.L0034
{
    [FunctionsMarker]
    public partial interface IVisualStudioCodeOperator
    {
        void Open()
        {
            Instances.CommandLineOperator.Run_NoWait(
                Instances.ExecutableFilePaths.VisualStudio_Code);
        }

        void Open(string filePath)
        {
            var arguments = $"{filePath}";

            Instances.CommandLineOperator.Run_NoWait(
                Instances.ExecutableFilePaths.VisualStudio_Code,
                arguments);
        }

        void Open(IEnumerable<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                this.Open(filePath);
            }
        }

        void Open(params string[] filePaths)
            => this.Open(filePaths.AsEnumerable());
    }
}
