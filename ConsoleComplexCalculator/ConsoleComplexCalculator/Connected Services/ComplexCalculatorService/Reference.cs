﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComplexCalculatorService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexType", Namespace="http://schemas.datacontract.org/2004/07/ComplexCalculator")]
    public partial class ComplexType : object
    {
        
        private double ImaginryValueOperationField;
        
        private double RealValueOperationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ImaginryValueOperation
        {
            get
            {
                return this.ImaginryValueOperationField;
            }
            set
            {
                this.ImaginryValueOperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RealValueOperation
        {
            get
            {
                return this.RealValueOperationField;
            }
            set
            {
                this.RealValueOperationField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ComplexCalculatorService.ComplexServices")]
    public interface ComplexServices
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/AddTwoValue", ReplyAction="http://tempuri.org/ComplexServices/AddTwoValueResponse")]
        string AddTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/AddTwoValue", ReplyAction="http://tempuri.org/ComplexServices/AddTwoValueResponse")]
        System.Threading.Tasks.Task<string> AddTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/AddFourValue", ReplyAction="http://tempuri.org/ComplexServices/AddFourValueResponse")]
        string AddFourValue(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/AddFourValue", ReplyAction="http://tempuri.org/ComplexServices/AddFourValueResponse")]
        System.Threading.Tasks.Task<string> AddFourValueAsync(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/SubtractTwoValue", ReplyAction="http://tempuri.org/ComplexServices/SubtractTwoValueResponse")]
        string SubtractTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/SubtractTwoValue", ReplyAction="http://tempuri.org/ComplexServices/SubtractTwoValueResponse")]
        System.Threading.Tasks.Task<string> SubtractTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/SubtractFourValue", ReplyAction="http://tempuri.org/ComplexServices/SubtractFourValueResponse")]
        string SubtractFourValue(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/SubtractFourValue", ReplyAction="http://tempuri.org/ComplexServices/SubtractFourValueResponse")]
        System.Threading.Tasks.Task<string> SubtractFourValueAsync(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/DivisionTwoValue", ReplyAction="http://tempuri.org/ComplexServices/DivisionTwoValueResponse")]
        string DivisionTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/DivisionTwoValue", ReplyAction="http://tempuri.org/ComplexServices/DivisionTwoValueResponse")]
        System.Threading.Tasks.Task<string> DivisionTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/DivisionFourValue", ReplyAction="http://tempuri.org/ComplexServices/DivisionFourValueResponse")]
        string DivisionFourValue(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/DivisionFourValue", ReplyAction="http://tempuri.org/ComplexServices/DivisionFourValueResponse")]
        System.Threading.Tasks.Task<string> DivisionFourValueAsync(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/MultiplyTwoValue", ReplyAction="http://tempuri.org/ComplexServices/MultiplyTwoValueResponse")]
        string MultiplyTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/MultiplyTwoValue", ReplyAction="http://tempuri.org/ComplexServices/MultiplyTwoValueResponse")]
        System.Threading.Tasks.Task<string> MultiplyTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/MultiplyFourValue", ReplyAction="http://tempuri.org/ComplexServices/MultiplyFourValueResponse")]
        string MultiplyFourValue(double real1, double imaginary1, double real2, double imaginary2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ComplexServices/MultiplyFourValue", ReplyAction="http://tempuri.org/ComplexServices/MultiplyFourValueResponse")]
        System.Threading.Tasks.Task<string> MultiplyFourValueAsync(double real1, double imaginary1, double real2, double imaginary2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ComplexServicesChannel : ComplexCalculatorService.ComplexServices, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ComplexServicesClient : System.ServiceModel.ClientBase<ComplexCalculatorService.ComplexServices>, ComplexCalculatorService.ComplexServices
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ComplexServicesClient() : 
                base(ComplexServicesClient.GetDefaultBinding(), ComplexServicesClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ComplexServices.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComplexServicesClient(EndpointConfiguration endpointConfiguration) : 
                base(ComplexServicesClient.GetBindingForEndpoint(endpointConfiguration), ComplexServicesClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComplexServicesClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ComplexServicesClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComplexServicesClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ComplexServicesClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ComplexServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string AddTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.AddTwoValue(FirstComplex, SecondComplex);
        }
        
        public System.Threading.Tasks.Task<string> AddTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.AddTwoValueAsync(FirstComplex, SecondComplex);
        }
        
        public string AddFourValue(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.AddFourValue(real1, imaginary1, real2, imaginary2);
        }
        
        public System.Threading.Tasks.Task<string> AddFourValueAsync(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.AddFourValueAsync(real1, imaginary1, real2, imaginary2);
        }
        
        public string SubtractTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.SubtractTwoValue(FirstComplex, SecondComplex);
        }
        
        public System.Threading.Tasks.Task<string> SubtractTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.SubtractTwoValueAsync(FirstComplex, SecondComplex);
        }
        
        public string SubtractFourValue(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.SubtractFourValue(real1, imaginary1, real2, imaginary2);
        }
        
        public System.Threading.Tasks.Task<string> SubtractFourValueAsync(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.SubtractFourValueAsync(real1, imaginary1, real2, imaginary2);
        }
        
        public string DivisionTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.DivisionTwoValue(FirstComplex, SecondComplex);
        }
        
        public System.Threading.Tasks.Task<string> DivisionTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.DivisionTwoValueAsync(FirstComplex, SecondComplex);
        }
        
        public string DivisionFourValue(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.DivisionFourValue(real1, imaginary1, real2, imaginary2);
        }
        
        public System.Threading.Tasks.Task<string> DivisionFourValueAsync(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.DivisionFourValueAsync(real1, imaginary1, real2, imaginary2);
        }
        
        public string MultiplyTwoValue(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.MultiplyTwoValue(FirstComplex, SecondComplex);
        }
        
        public System.Threading.Tasks.Task<string> MultiplyTwoValueAsync(ComplexCalculatorService.ComplexType FirstComplex, ComplexCalculatorService.ComplexType SecondComplex)
        {
            return base.Channel.MultiplyTwoValueAsync(FirstComplex, SecondComplex);
        }
        
        public string MultiplyFourValue(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.MultiplyFourValue(real1, imaginary1, real2, imaginary2);
        }
        
        public System.Threading.Tasks.Task<string> MultiplyFourValueAsync(double real1, double imaginary1, double real2, double imaginary2)
        {
            return base.Channel.MultiplyFourValueAsync(real1, imaginary1, real2, imaginary2);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ComplexServices))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ComplexServices))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:63613/ComplexSer.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ComplexServicesClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ComplexServices);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ComplexServicesClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ComplexServices);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ComplexServices,
        }
    }
}
