﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreinamentoWebService.Automation.HelloService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloService.IHelloWorldService")]
    public interface IHelloWorldService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/Hello", ReplyAction="http://tempuri.org/IHelloWorldService/HelloResponse")]
        string Hello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/Hello", ReplyAction="http://tempuri.org/IHelloWorldService/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldServiceChannel : TreinamentoWebService.Automation.HelloService.IHelloWorldService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldServiceClient : System.ServiceModel.ClientBase<TreinamentoWebService.Automation.HelloService.IHelloWorldService>, TreinamentoWebService.Automation.HelloService.IHelloWorldService {
        
        public HelloWorldServiceClient() {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello(string name) {
            return base.Channel.Hello(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync(string name) {
            return base.Channel.HelloAsync(name);
        }
    }
}