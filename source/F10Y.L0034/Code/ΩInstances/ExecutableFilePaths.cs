using System;


namespace F10Y.L0034
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}


namespace F10Y.L0034.Raw
{
    public class ExecutableFilePaths : IExecutableFilePaths
    {
        #region Infrastructure

        public static IExecutableFilePaths Instance { get; } = new ExecutableFilePaths();


        private ExecutableFilePaths()
        {
        }

        #endregion
    }
}
