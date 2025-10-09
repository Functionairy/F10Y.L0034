using System;


namespace F10Y.L0034
{
    public static class Instances
    {
        public static L0000.ICommandLineOperator CommandLineOperator => L0000.CommandLineOperator.Instance;
        public static L0000.IDirectoryPaths DirectoryPaths => L0000.DirectoryPaths.Instance;
        public static IExecutableFilePaths ExecutableFilePaths => L0034.ExecutableFilePaths.Instance;
        public static L0000.IMachineNameOperator MachineNameOperator => L0000.MachineNameOperator.Instance;
        public static L0000.IOperatingSystemOperator OperatingSystemOperator => L0000.OperatingSystemOperator.Instance;
        public static L0000.IPathOperator PathOperator => L0000.PathOperator.Instance;
    }
}