using System;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreinamentoWebService.Automation;

namespace TreinamentoWebService.Test
{
    [TestClass]
    public class ServiceTests
    {
        private VendaServiceWorkflow vendaServiceWorkflow;
        private HelloServiceWorkflow helloServiceWorkflow;

        public ServiceTests()
        {
            helloServiceWorkflow = new HelloServiceWorkflow();
            vendaServiceWorkflow = new VendaServiceWorkflow();
        }

        [ TestMethod]
        public void ValidateHelloMessage()
        {
            Assert.IsTrue( helloServiceWorkflow.VerifiyHelloMessage( "Thiago" ) );
        }

        [TestMethod]
        public void ValidaCampoCodigoVerificacao()
        {
            const string CodigoEsperado = "da84";
            Assert.AreEqual( vendaServiceWorkflow.GetCodigoVerificacao( GetNumeroNotaFiscal() ), CodigoEsperado );
        }

        [TestMethod]
        public void ValidaCampoDataEmissao()
        {
            Assert.IsTrue( vendaServiceWorkflow.GetDataEmissao( GetNumeroNotaFiscal() ) > new DateTime( 2018, 1, 1 ) );
        }

        [TestMethod]
        public void ValidaCampoDiscriminacao()
        {
            const int VendaId = 1;
            const string ExpectedDiscriminacao = "Teclado T2";
            Assert.AreEqual( vendaServiceWorkflow.GetVendaServicoDiscriminacao( VendaId ), ExpectedDiscriminacao );
        }

        private string GetNumeroNotaFiscal()
        {
            return "2018";
        }
    }
}
