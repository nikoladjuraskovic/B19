﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B19.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name tekst from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CirilicaULatinicu", ReplyAction="*")]
        B19.ServiceReference1.CirilicaULatinicuResponse CirilicaULatinicu(B19.ServiceReference1.CirilicaULatinicuRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CirilicaULatinicu", ReplyAction="*")]
        System.Threading.Tasks.Task<B19.ServiceReference1.CirilicaULatinicuResponse> CirilicaULatinicuAsync(B19.ServiceReference1.CirilicaULatinicuRequest request);
        
        // CODEGEN: Generating message contract since element name tekst from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LatinicaUCirilicu", ReplyAction="*")]
        B19.ServiceReference1.LatinicaUCirilicuResponse LatinicaUCirilicu(B19.ServiceReference1.LatinicaUCirilicuRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LatinicaUCirilicu", ReplyAction="*")]
        System.Threading.Tasks.Task<B19.ServiceReference1.LatinicaUCirilicuResponse> LatinicaUCirilicuAsync(B19.ServiceReference1.LatinicaUCirilicuRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CirilicaULatinicuRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CirilicaULatinicu", Namespace="http://tempuri.org/", Order=0)]
        public B19.ServiceReference1.CirilicaULatinicuRequestBody Body;
        
        public CirilicaULatinicuRequest() {
        }
        
        public CirilicaULatinicuRequest(B19.ServiceReference1.CirilicaULatinicuRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CirilicaULatinicuRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tekst;
        
        public CirilicaULatinicuRequestBody() {
        }
        
        public CirilicaULatinicuRequestBody(string tekst) {
            this.tekst = tekst;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CirilicaULatinicuResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CirilicaULatinicuResponse", Namespace="http://tempuri.org/", Order=0)]
        public B19.ServiceReference1.CirilicaULatinicuResponseBody Body;
        
        public CirilicaULatinicuResponse() {
        }
        
        public CirilicaULatinicuResponse(B19.ServiceReference1.CirilicaULatinicuResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CirilicaULatinicuResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CirilicaULatinicuResult;
        
        public CirilicaULatinicuResponseBody() {
        }
        
        public CirilicaULatinicuResponseBody(string CirilicaULatinicuResult) {
            this.CirilicaULatinicuResult = CirilicaULatinicuResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LatinicaUCirilicuRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LatinicaUCirilicu", Namespace="http://tempuri.org/", Order=0)]
        public B19.ServiceReference1.LatinicaUCirilicuRequestBody Body;
        
        public LatinicaUCirilicuRequest() {
        }
        
        public LatinicaUCirilicuRequest(B19.ServiceReference1.LatinicaUCirilicuRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LatinicaUCirilicuRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tekst;
        
        public LatinicaUCirilicuRequestBody() {
        }
        
        public LatinicaUCirilicuRequestBody(string tekst) {
            this.tekst = tekst;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LatinicaUCirilicuResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LatinicaUCirilicuResponse", Namespace="http://tempuri.org/", Order=0)]
        public B19.ServiceReference1.LatinicaUCirilicuResponseBody Body;
        
        public LatinicaUCirilicuResponse() {
        }
        
        public LatinicaUCirilicuResponse(B19.ServiceReference1.LatinicaUCirilicuResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LatinicaUCirilicuResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LatinicaUCirilicuResult;
        
        public LatinicaUCirilicuResponseBody() {
        }
        
        public LatinicaUCirilicuResponseBody(string LatinicaUCirilicuResult) {
            this.LatinicaUCirilicuResult = LatinicaUCirilicuResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : B19.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<B19.ServiceReference1.WebService1Soap>, B19.ServiceReference1.WebService1Soap {
        
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        B19.ServiceReference1.CirilicaULatinicuResponse B19.ServiceReference1.WebService1Soap.CirilicaULatinicu(B19.ServiceReference1.CirilicaULatinicuRequest request) {
            return base.Channel.CirilicaULatinicu(request);
        }
        
        public string CirilicaULatinicu(string tekst) {
            B19.ServiceReference1.CirilicaULatinicuRequest inValue = new B19.ServiceReference1.CirilicaULatinicuRequest();
            inValue.Body = new B19.ServiceReference1.CirilicaULatinicuRequestBody();
            inValue.Body.tekst = tekst;
            B19.ServiceReference1.CirilicaULatinicuResponse retVal = ((B19.ServiceReference1.WebService1Soap)(this)).CirilicaULatinicu(inValue);
            return retVal.Body.CirilicaULatinicuResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<B19.ServiceReference1.CirilicaULatinicuResponse> B19.ServiceReference1.WebService1Soap.CirilicaULatinicuAsync(B19.ServiceReference1.CirilicaULatinicuRequest request) {
            return base.Channel.CirilicaULatinicuAsync(request);
        }
        
        public System.Threading.Tasks.Task<B19.ServiceReference1.CirilicaULatinicuResponse> CirilicaULatinicuAsync(string tekst) {
            B19.ServiceReference1.CirilicaULatinicuRequest inValue = new B19.ServiceReference1.CirilicaULatinicuRequest();
            inValue.Body = new B19.ServiceReference1.CirilicaULatinicuRequestBody();
            inValue.Body.tekst = tekst;
            return ((B19.ServiceReference1.WebService1Soap)(this)).CirilicaULatinicuAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        B19.ServiceReference1.LatinicaUCirilicuResponse B19.ServiceReference1.WebService1Soap.LatinicaUCirilicu(B19.ServiceReference1.LatinicaUCirilicuRequest request) {
            return base.Channel.LatinicaUCirilicu(request);
        }
        
        public string LatinicaUCirilicu(string tekst) {
            B19.ServiceReference1.LatinicaUCirilicuRequest inValue = new B19.ServiceReference1.LatinicaUCirilicuRequest();
            inValue.Body = new B19.ServiceReference1.LatinicaUCirilicuRequestBody();
            inValue.Body.tekst = tekst;
            B19.ServiceReference1.LatinicaUCirilicuResponse retVal = ((B19.ServiceReference1.WebService1Soap)(this)).LatinicaUCirilicu(inValue);
            return retVal.Body.LatinicaUCirilicuResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<B19.ServiceReference1.LatinicaUCirilicuResponse> B19.ServiceReference1.WebService1Soap.LatinicaUCirilicuAsync(B19.ServiceReference1.LatinicaUCirilicuRequest request) {
            return base.Channel.LatinicaUCirilicuAsync(request);
        }
        
        public System.Threading.Tasks.Task<B19.ServiceReference1.LatinicaUCirilicuResponse> LatinicaUCirilicuAsync(string tekst) {
            B19.ServiceReference1.LatinicaUCirilicuRequest inValue = new B19.ServiceReference1.LatinicaUCirilicuRequest();
            inValue.Body = new B19.ServiceReference1.LatinicaUCirilicuRequestBody();
            inValue.Body.tekst = tekst;
            return ((B19.ServiceReference1.WebService1Soap)(this)).LatinicaUCirilicuAsync(inValue);
        }
    }
}