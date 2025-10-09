using System;


namespace F10Y.L0034
{
    public class Values : IValues
    {
        #region Infrastructure

        public static IValues Instance { get; } = new Values();


        private Values()
        {
        }

        #endregion
    }
}
