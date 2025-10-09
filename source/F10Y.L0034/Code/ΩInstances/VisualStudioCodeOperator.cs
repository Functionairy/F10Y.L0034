using System;


namespace F10Y.L0034
{
    public class VisualStudioCodeOperator : IVisualStudioCodeOperator
    {
        #region Infrastructure

        public static IVisualStudioCodeOperator Instance { get; } = new VisualStudioCodeOperator();


        private VisualStudioCodeOperator()
        {
        }

        #endregion
    }
}
