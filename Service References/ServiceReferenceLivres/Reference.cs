﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioAdmin.ServiceReferenceLivres {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLivres.IServiceLivres")]
    public interface IServiceLivres {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/getImageEF", ReplyAction="http://tempuri.org/IServiceLivres/getImageEFResponse")]
        string getImageEF(string titre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/getImageEF", ReplyAction="http://tempuri.org/IServiceLivres/getImageEFResponse")]
        System.Threading.Tasks.Task<string> getImageEFAsync(string titre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/insertLivre", ReplyAction="http://tempuri.org/IServiceLivres/insertLivreResponse")]
        void insertLivre(string isbn, string titre, string url, string auteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/insertLivre", ReplyAction="http://tempuri.org/IServiceLivres/insertLivreResponse")]
        System.Threading.Tasks.Task insertLivreAsync(string isbn, string titre, string url, string auteur);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/getImage", ReplyAction="http://tempuri.org/IServiceLivres/getImageResponse")]
        string getImage(string titre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLivres/getImage", ReplyAction="http://tempuri.org/IServiceLivres/getImageResponse")]
        System.Threading.Tasks.Task<string> getImageAsync(string titre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLivresChannel : BiblioAdmin.ServiceReferenceLivres.IServiceLivres, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLivresClient : System.ServiceModel.ClientBase<BiblioAdmin.ServiceReferenceLivres.IServiceLivres>, BiblioAdmin.ServiceReferenceLivres.IServiceLivres {
        
        public ServiceLivresClient() {
        }
        
        public ServiceLivresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLivresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLivresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLivresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getImageEF(string titre) {
            return base.Channel.getImageEF(titre);
        }
        
        public System.Threading.Tasks.Task<string> getImageEFAsync(string titre) {
            return base.Channel.getImageEFAsync(titre);
        }
        
        public void insertLivre(string isbn, string titre, string url, string auteur) {
            base.Channel.insertLivre(isbn, titre, url, auteur);
        }
        
        public System.Threading.Tasks.Task insertLivreAsync(string isbn, string titre, string url, string auteur) {
            return base.Channel.insertLivreAsync(isbn, titre, url, auteur);
        }
        
        public string getImage(string titre) {
            return base.Channel.getImage(titre);
        }
        
        public System.Threading.Tasks.Task<string> getImageAsync(string titre) {
            return base.Channel.getImageAsync(titre);
        }
    }
}