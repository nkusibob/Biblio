﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioAdmin.ServiceReferenceExemplaires {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsCountRetardsUsers", Namespace="http://schemas.datacontract.org/2004/07/wcflibrary")]
    [System.SerializableAttribute()]
    public partial class clsCountRetardsUsers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbreExemDispoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NbreRetardsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbreExemDispo {
            get {
                return this.NbreExemDispoField;
            }
            set {
                if ((this.NbreExemDispoField.Equals(value) != true)) {
                    this.NbreExemDispoField = value;
                    this.RaisePropertyChanged("NbreExemDispo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NbreRetards {
            get {
                return this.NbreRetardsField;
            }
            set {
                if ((this.NbreRetardsField.Equals(value) != true)) {
                    this.NbreRetardsField = value;
                    this.RaisePropertyChanged("NbreRetards");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsexemplaires", Namespace="http://schemas.datacontract.org/2004/07/wcflibrary")]
    [System.SerializableAttribute()]
    public partial class clsexemplaires : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdExemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime achatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime date_empruntField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idLivreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_biblioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdExem {
            get {
                return this.IdExemField;
            }
            set {
                if ((this.IdExemField.Equals(value) != true)) {
                    this.IdExemField = value;
                    this.RaisePropertyChanged("IdExem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime achat {
            get {
                return this.achatField;
            }
            set {
                if ((this.achatField.Equals(value) != true)) {
                    this.achatField = value;
                    this.RaisePropertyChanged("achat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string code {
            get {
                return this.codeField;
            }
            set {
                if ((object.ReferenceEquals(this.codeField, value) != true)) {
                    this.codeField = value;
                    this.RaisePropertyChanged("code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date_emprunt {
            get {
                return this.date_empruntField;
            }
            set {
                if ((this.date_empruntField.Equals(value) != true)) {
                    this.date_empruntField = value;
                    this.RaisePropertyChanged("date_emprunt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idLivre {
            get {
                return this.idLivreField;
            }
            set {
                if ((this.idLivreField.Equals(value) != true)) {
                    this.idLivreField = value;
                    this.RaisePropertyChanged("idLivre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_biblio {
            get {
                return this.id_biblioField;
            }
            set {
                if ((this.id_biblioField.Equals(value) != true)) {
                    this.id_biblioField = value;
                    this.RaisePropertyChanged("id_biblio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceExemplaires.IServiceExemplaires")]
    public interface IServiceExemplaires {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispo", ReplyAction="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoResponse")]
        BiblioAdmin.ServiceReferenceExemplaires.clsCountRetardsUsers[] VerifiNbreExemDispo(string biblio, string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispo", ReplyAction="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoResponse")]
        System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsCountRetardsUsers[]> VerifiNbreExemDispoAsync(string biblio, string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoAdo", ReplyAction="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoAdoResponse")]
        int VerifiNbreExemDispoAdo(string biblio, string livre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoAdo", ReplyAction="http://tempuri.org/IServiceExemplaires/VerifiNbreExemDispoAdoResponse")]
        System.Threading.Tasks.Task<int> VerifiNbreExemDispoAdoAsync(string biblio, string livre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetCountAll", ReplyAction="http://tempuri.org/IServiceExemplaires/GetCountAllResponse")]
        System.Data.DataSet GetCountAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetCountAll", ReplyAction="http://tempuri.org/IServiceExemplaires/GetCountAllResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCountAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetAll", ReplyAction="http://tempuri.org/IServiceExemplaires/GetAllResponse")]
        System.Data.DataSet GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetAll", ReplyAction="http://tempuri.org/IServiceExemplaires/GetAllResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeRetard", ReplyAction="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeRetardResponse")]
        System.Data.DataSet Exemplaire_SoldeRetard();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeRetard", ReplyAction="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeRetardResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Exemplaire_SoldeRetardAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/Exemplaire_Solde", ReplyAction="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeResponse")]
        System.Data.DataSet Exemplaire_Solde();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/Exemplaire_Solde", ReplyAction="http://tempuri.org/IServiceExemplaires/Exemplaire_SoldeResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> Exemplaire_SoldeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/CreateExemplaire", ReplyAction="http://tempuri.org/IServiceExemplaires/CreateExemplaireResponse")]
        void CreateExemplaire(string code, System.DateTime achatDt, System.DateTime empruntdt, int idBiblio, int idLivre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/CreateExemplaire", ReplyAction="http://tempuri.org/IServiceExemplaires/CreateExemplaireResponse")]
        System.Threading.Tasks.Task CreateExemplaireAsync(string code, System.DateTime achatDt, System.DateTime empruntdt, int idBiblio, int idLivre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/LoadAllCopyCA", ReplyAction="http://tempuri.org/IServiceExemplaires/LoadAllCopyCAResponse")]
        System.Data.DataSet LoadAllCopyCA();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/LoadAllCopyCA", ReplyAction="http://tempuri.org/IServiceExemplaires/LoadAllCopyCAResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> LoadAllCopyCAAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetAllExemBiblio", ReplyAction="http://tempuri.org/IServiceExemplaires/GetAllExemBiblioResponse")]
        BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[] GetAllExemBiblio(string biblio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/GetAllExemBiblio", ReplyAction="http://tempuri.org/IServiceExemplaires/GetAllExemBiblioResponse")]
        System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[]> GetAllExemBiblioAsync(string biblio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/SearchExemBiblio", ReplyAction="http://tempuri.org/IServiceExemplaires/SearchExemBiblioResponse")]
        BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[] SearchExemBiblio(string biblio, string nameExempl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceExemplaires/SearchExemBiblio", ReplyAction="http://tempuri.org/IServiceExemplaires/SearchExemBiblioResponse")]
        System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[]> SearchExemBiblioAsync(string biblio, string nameExempl);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceExemplairesChannel : BiblioAdmin.ServiceReferenceExemplaires.IServiceExemplaires, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceExemplairesClient : System.ServiceModel.ClientBase<BiblioAdmin.ServiceReferenceExemplaires.IServiceExemplaires>, BiblioAdmin.ServiceReferenceExemplaires.IServiceExemplaires {
        
        public ServiceExemplairesClient() {
        }
        
        public ServiceExemplairesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceExemplairesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceExemplairesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceExemplairesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BiblioAdmin.ServiceReferenceExemplaires.clsCountRetardsUsers[] VerifiNbreExemDispo(string biblio, string title) {
            return base.Channel.VerifiNbreExemDispo(biblio, title);
        }
        
        public System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsCountRetardsUsers[]> VerifiNbreExemDispoAsync(string biblio, string title) {
            return base.Channel.VerifiNbreExemDispoAsync(biblio, title);
        }
        
        public int VerifiNbreExemDispoAdo(string biblio, string livre) {
            return base.Channel.VerifiNbreExemDispoAdo(biblio, livre);
        }
        
        public System.Threading.Tasks.Task<int> VerifiNbreExemDispoAdoAsync(string biblio, string livre) {
            return base.Channel.VerifiNbreExemDispoAdoAsync(biblio, livre);
        }
        
        public System.Data.DataSet GetCountAll() {
            return base.Channel.GetCountAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCountAllAsync() {
            return base.Channel.GetCountAllAsync();
        }
        
        public System.Data.DataSet GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public System.Data.DataSet Exemplaire_SoldeRetard() {
            return base.Channel.Exemplaire_SoldeRetard();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Exemplaire_SoldeRetardAsync() {
            return base.Channel.Exemplaire_SoldeRetardAsync();
        }
        
        public System.Data.DataSet Exemplaire_Solde() {
            return base.Channel.Exemplaire_Solde();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> Exemplaire_SoldeAsync() {
            return base.Channel.Exemplaire_SoldeAsync();
        }
        
        public void CreateExemplaire(string code, System.DateTime achatDt, System.DateTime empruntdt, int idBiblio, int idLivre) {
            base.Channel.CreateExemplaire(code, achatDt, empruntdt, idBiblio, idLivre);
        }
        
        public System.Threading.Tasks.Task CreateExemplaireAsync(string code, System.DateTime achatDt, System.DateTime empruntdt, int idBiblio, int idLivre) {
            return base.Channel.CreateExemplaireAsync(code, achatDt, empruntdt, idBiblio, idLivre);
        }
        
        public System.Data.DataSet LoadAllCopyCA() {
            return base.Channel.LoadAllCopyCA();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> LoadAllCopyCAAsync() {
            return base.Channel.LoadAllCopyCAAsync();
        }
        
        public BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[] GetAllExemBiblio(string biblio) {
            return base.Channel.GetAllExemBiblio(biblio);
        }
        
        public System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[]> GetAllExemBiblioAsync(string biblio) {
            return base.Channel.GetAllExemBiblioAsync(biblio);
        }
        
        public BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[] SearchExemBiblio(string biblio, string nameExempl) {
            return base.Channel.SearchExemBiblio(biblio, nameExempl);
        }
        
        public System.Threading.Tasks.Task<BiblioAdmin.ServiceReferenceExemplaires.clsexemplaires[]> SearchExemBiblioAsync(string biblio, string nameExempl) {
            return base.Channel.SearchExemBiblioAsync(biblio, nameExempl);
        }
    }
}