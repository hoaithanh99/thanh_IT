﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertWS.ServiceConvert {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceConvert.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EUR2VND", ReplyAction="*")]
        double EUR2VND(double eur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EUR2VND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> EUR2VNDAsync(double eur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USD2VND", ReplyAction="*")]
        double USD2VND(double usd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/USD2VND", ReplyAction="*")]
        System.Threading.Tasks.Task<double> USD2VNDAsync(double usd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2EUR", ReplyAction="*")]
        double VND2EUR(double dong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2EUR", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VND2EURAsync(double dong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2USD", ReplyAction="*")]
        double VND2USD(double dong);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VND2USD", ReplyAction="*")]
        System.Threading.Tasks.Task<double> VND2USDAsync(double dong);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ConvertWS.ServiceConvert.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ConvertWS.ServiceConvert.WebService1Soap>, ConvertWS.ServiceConvert.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double EUR2VND(double eur) {
            return base.Channel.EUR2VND(eur);
        }
        
        public System.Threading.Tasks.Task<double> EUR2VNDAsync(double eur) {
            return base.Channel.EUR2VNDAsync(eur);
        }
        
        public double USD2VND(double usd) {
            return base.Channel.USD2VND(usd);
        }
        
        public System.Threading.Tasks.Task<double> USD2VNDAsync(double usd) {
            return base.Channel.USD2VNDAsync(usd);
        }
        
        public double VND2EUR(double dong) {
            return base.Channel.VND2EUR(dong);
        }
        
        public System.Threading.Tasks.Task<double> VND2EURAsync(double dong) {
            return base.Channel.VND2EURAsync(dong);
        }
        
        public double VND2USD(double dong) {
            return base.Channel.VND2USD(dong);
        }
        
        public System.Threading.Tasks.Task<double> VND2USDAsync(double dong) {
            return base.Channel.VND2USDAsync(dong);
        }
    }
}
