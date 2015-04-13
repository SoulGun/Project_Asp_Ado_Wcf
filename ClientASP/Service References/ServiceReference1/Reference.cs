﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Transformation", ReplyAction="http://tempuri.org/IService2/TransformationResponse")]
        string Transformation(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Transformation", ReplyAction="http://tempuri.org/IService2/TransformationResponse")]
        System.Threading.Tasks.Task<string> TransformationAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/RemoveVowels", ReplyAction="http://tempuri.org/IService2/RemoveVowelsResponse")]
        string RemoveVowels(string stringInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/RemoveVowels", ReplyAction="http://tempuri.org/IService2/RemoveVowelsResponse")]
        System.Threading.Tasks.Task<string> RemoveVowelsAsync(string stringInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Inverse", ReplyAction="http://tempuri.org/IService2/InverseResponse")]
        string Inverse(string stringInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Inverse", ReplyAction="http://tempuri.org/IService2/InverseResponse")]
        System.Threading.Tasks.Task<string> InverseAsync(string stringInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Inverse2By2", ReplyAction="http://tempuri.org/IService2/Inverse2By2Response")]
        string Inverse2By2(string stringInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/Inverse2By2", ReplyAction="http://tempuri.org/IService2/Inverse2By2Response")]
        System.Threading.Tasks.Task<string> Inverse2By2Async(string stringInput);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : MvcApplication2.ServiceReference1.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<MvcApplication2.ServiceReference1.IService2>, MvcApplication2.ServiceReference1.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Transformation(string text) {
            return base.Channel.Transformation(text);
        }
        
        public System.Threading.Tasks.Task<string> TransformationAsync(string text) {
            return base.Channel.TransformationAsync(text);
        }
        
        public string RemoveVowels(string stringInput) {
            return base.Channel.RemoveVowels(stringInput);
        }
        
        public System.Threading.Tasks.Task<string> RemoveVowelsAsync(string stringInput) {
            return base.Channel.RemoveVowelsAsync(stringInput);
        }
        
        public string Inverse(string stringInput) {
            return base.Channel.Inverse(stringInput);
        }
        
        public System.Threading.Tasks.Task<string> InverseAsync(string stringInput) {
            return base.Channel.InverseAsync(stringInput);
        }
        
        public string Inverse2By2(string stringInput) {
            return base.Channel.Inverse2By2(stringInput);
        }
        
        public System.Threading.Tasks.Task<string> Inverse2By2Async(string stringInput) {
            return base.Channel.Inverse2By2Async(stringInput);
        }
    }
}