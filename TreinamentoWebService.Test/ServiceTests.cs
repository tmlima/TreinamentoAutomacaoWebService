using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreinamentoWebService.Automation;

namespace TreinamentoWebService.Test
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void ValidateHelloMessage()
        {
            HelloServiceWorkflow helloServiceWorkflow = new HelloServiceWorkflow();
            Assert.IsTrue( helloServiceWorkflow.VerifiyHelloMessage( "Thiago" ) );
        }
    }
}
