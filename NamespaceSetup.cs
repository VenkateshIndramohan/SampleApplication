using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SampleApplication
{
    [TestClass]
    public class NamespaceSetup
    {
        [AssemblyInitialize]
        public static void ExecuteForCreatingReportsNamespace(TestContext testContext)
        {
            Reporter.StartReporter();
        }
    }
}
