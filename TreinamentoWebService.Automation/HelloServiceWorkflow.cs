using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoWebService.Automation
{
    public class HelloServiceWorkflow
    {
        public bool VerifiyHelloMessage(string name)
        {
            HelloService.HelloWorldServiceClient client = new HelloService.HelloWorldServiceClient();
            string response = client.Hello( name );
            return response == "Olá " + name + "!";
        }
    }
}
