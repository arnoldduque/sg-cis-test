﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGCISTest.SGCISService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/DataSGCISTest.Model")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SGCISTest.SGCISService.PersonType PersonTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonTypeIdField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SGCISTest.SGCISService.PersonType PersonType {
            get {
                return this.PersonTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonTypeField, value) != true)) {
                    this.PersonTypeField = value;
                    this.RaisePropertyChanged("PersonType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonTypeId {
            get {
                return this.PersonTypeIdField;
            }
            set {
                if ((this.PersonTypeIdField.Equals(value) != true)) {
                    this.PersonTypeIdField = value;
                    this.RaisePropertyChanged("PersonTypeId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonType", Namespace="http://schemas.datacontract.org/2004/07/DataSGCISTest.Model")]
    [System.SerializableAttribute()]
    public partial class PersonType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SGCISService.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersons", ReplyAction="http://tempuri.org/IPersonService/GetPersonsResponse")]
        SGCISTest.SGCISService.Person[] GetPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersons", ReplyAction="http://tempuri.org/IPersonService/GetPersonsResponse")]
        System.Threading.Tasks.Task<SGCISTest.SGCISService.Person[]> GetPersonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        void DeletePerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/DeletePerson", ReplyAction="http://tempuri.org/IPersonService/DeletePersonResponse")]
        System.Threading.Tasks.Task DeletePersonAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        bool UpdatePerson(int id, string name, int age, int personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IPersonService/UpdatePersonResponse")]
        System.Threading.Tasks.Task<bool> UpdatePersonAsync(int id, string name, int age, int personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/CreatePerson", ReplyAction="http://tempuri.org/IPersonService/CreatePersonResponse")]
        int CreatePerson(string name, int age, int personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/CreatePerson", ReplyAction="http://tempuri.org/IPersonService/CreatePersonResponse")]
        System.Threading.Tasks.Task<int> CreatePersonAsync(string name, int age, int personType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonTypes", ReplyAction="http://tempuri.org/IPersonService/GetPersonTypesResponse")]
        SGCISTest.SGCISService.PersonType[] GetPersonTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersonTypes", ReplyAction="http://tempuri.org/IPersonService/GetPersonTypesResponse")]
        System.Threading.Tasks.Task<SGCISTest.SGCISService.PersonType[]> GetPersonTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InitializeData", ReplyAction="http://tempuri.org/IPersonService/InitializeDataResponse")]
        void InitializeData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/InitializeData", ReplyAction="http://tempuri.org/IPersonService/InitializeDataResponse")]
        System.Threading.Tasks.Task InitializeDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : SGCISTest.SGCISService.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<SGCISTest.SGCISService.IPersonService>, SGCISTest.SGCISService.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SGCISTest.SGCISService.Person[] GetPersons() {
            return base.Channel.GetPersons();
        }
        
        public System.Threading.Tasks.Task<SGCISTest.SGCISService.Person[]> GetPersonsAsync() {
            return base.Channel.GetPersonsAsync();
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int id) {
            return base.Channel.DeletePersonAsync(id);
        }
        
        public bool UpdatePerson(int id, string name, int age, int personType) {
            return base.Channel.UpdatePerson(id, name, age, personType);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePersonAsync(int id, string name, int age, int personType) {
            return base.Channel.UpdatePersonAsync(id, name, age, personType);
        }
        
        public int CreatePerson(string name, int age, int personType) {
            return base.Channel.CreatePerson(name, age, personType);
        }
        
        public System.Threading.Tasks.Task<int> CreatePersonAsync(string name, int age, int personType) {
            return base.Channel.CreatePersonAsync(name, age, personType);
        }
        
        public SGCISTest.SGCISService.PersonType[] GetPersonTypes() {
            return base.Channel.GetPersonTypes();
        }
        
        public System.Threading.Tasks.Task<SGCISTest.SGCISService.PersonType[]> GetPersonTypesAsync() {
            return base.Channel.GetPersonTypesAsync();
        }
        
        public void InitializeData() {
            base.Channel.InitializeData();
        }
        
        public System.Threading.Tasks.Task InitializeDataAsync() {
            return base.Channel.InitializeDataAsync();
        }
    }
}
