using System;
using System.Xml;
using TreinamentoWebService.Automation.VendaService;

namespace TreinamentoWebService.Automation
{
    public class VendaServiceWorkflow
    {
        private VendaServiceClient client;

        public VendaServiceWorkflow()
        {
            client = new VendaServiceClient();
        }

        public string GetCodigoVerificacao(string numeroNotaFiscal )
        {
            NfseReponse response = client.GetNfse( numeroNotaFiscal );
            return response.Nfse.CodigoVerificacao;
        }

        public DateTime GetDataEmissao( string numeroNotaFiscal )
        {
            return client.GetNfse( numeroNotaFiscal ).Nfse.DataEmissao;
        }

        public string GetVendaServicoDiscriminacao(int idVenda)
        {
            string nfse = client.GetVenda( idVenda ).Nfse;
            XmlDocument nfseXml = new XmlDocument();
            nfseXml.LoadXml( nfse );
            XmlNode node = nfseXml.SelectSingleNode( "//Discriminacao" );
            return node.InnerText;
        }
    }
}
