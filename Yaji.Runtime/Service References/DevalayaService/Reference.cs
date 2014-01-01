﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yaji.Runtime.DevalayaService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DevalayaService.IDevalayaService")]
    public interface IDevalayaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDevalayaService/GetNewListings", ReplyAction="http://tempuri.org/IDevalayaService/GetNewListingsResponse")]
        Yaji.Common.DevalayaSummary[] GetNewListings(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDevalayaService/GetNewListings", ReplyAction="http://tempuri.org/IDevalayaService/GetNewListingsResponse")]
        System.Threading.Tasks.Task<Yaji.Common.DevalayaSummary[]> GetNewListingsAsync(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDevalayaService/GetDetails", ReplyAction="http://tempuri.org/IDevalayaService/GetDetailsResponse")]
        Yaji.Common.DevalayaDetails GetDetails(System.Guid ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDevalayaService/GetDetails", ReplyAction="http://tempuri.org/IDevalayaService/GetDetailsResponse")]
        System.Threading.Tasks.Task<Yaji.Common.DevalayaDetails> GetDetailsAsync(System.Guid ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDevalayaServiceChannel : Yaji.Runtime.DevalayaService.IDevalayaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DevalayaServiceClient : System.ServiceModel.ClientBase<Yaji.Runtime.DevalayaService.IDevalayaService>, Yaji.Runtime.DevalayaService.IDevalayaService {
        
        public DevalayaServiceClient() {
        }
        
        public DevalayaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DevalayaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DevalayaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DevalayaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Yaji.Common.DevalayaSummary[] GetNewListings(int count) {
            return base.Channel.GetNewListings(count);
        }
        
        public System.Threading.Tasks.Task<Yaji.Common.DevalayaSummary[]> GetNewListingsAsync(int count) {
            return base.Channel.GetNewListingsAsync(count);
        }
        
        public Yaji.Common.DevalayaDetails GetDetails(System.Guid ID) {
            return base.Channel.GetDetails(ID);
        }
        
        public System.Threading.Tasks.Task<Yaji.Common.DevalayaDetails> GetDetailsAsync(System.Guid ID) {
            return base.Channel.GetDetailsAsync(ID);
        }
    }
}