﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoloProjectMvc.BasketItemsReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BasketItem", Namespace="http://schemas.datacontract.org/2004/07/ModelPoco")]
    [System.SerializableAttribute()]
    public partial class BasketItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.Basket BasketField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BasketIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BasketItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.Product ProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public SoloProjectMvc.BasketItemsReference.Basket Basket {
            get {
                return this.BasketField;
            }
            set {
                if ((object.ReferenceEquals(this.BasketField, value) != true)) {
                    this.BasketField = value;
                    this.RaisePropertyChanged("Basket");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BasketId {
            get {
                return this.BasketIdField;
            }
            set {
                if ((this.BasketIdField.Equals(value) != true)) {
                    this.BasketIdField = value;
                    this.RaisePropertyChanged("BasketId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BasketItemId {
            get {
                return this.BasketItemIdField;
            }
            set {
                if ((this.BasketItemIdField.Equals(value) != true)) {
                    this.BasketItemIdField = value;
                    this.RaisePropertyChanged("BasketItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.Product Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Basket", Namespace="http://schemas.datacontract.org/2004/07/ModelPoco")]
    [System.SerializableAttribute()]
    public partial class Basket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BasketIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.BasketItem[] BasketItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public int BasketId {
            get {
                return this.BasketIdField;
            }
            set {
                if ((this.BasketIdField.Equals(value) != true)) {
                    this.BasketIdField = value;
                    this.RaisePropertyChanged("BasketId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.BasketItem[] BasketItems {
            get {
                return this.BasketItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.BasketItemsField, value) != true)) {
                    this.BasketItemsField = value;
                    this.RaisePropertyChanged("BasketItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/ModelPoco")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.BasketItem[] BasketItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageLinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberInStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SearchTermsField;
        
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
        public SoloProjectMvc.BasketItemsReference.BasketItem[] BasketItems {
            get {
                return this.BasketItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.BasketItemsField, value) != true)) {
                    this.BasketItemsField = value;
                    this.RaisePropertyChanged("BasketItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageLink {
            get {
                return this.ImageLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageLinkField, value) != true)) {
                    this.ImageLinkField = value;
                    this.RaisePropertyChanged("ImageLink");
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
        public int NumberInStock {
            get {
                return this.NumberInStockField;
            }
            set {
                if ((this.NumberInStockField.Equals(value) != true)) {
                    this.NumberInStockField = value;
                    this.RaisePropertyChanged("NumberInStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SearchTerms {
            get {
                return this.SearchTermsField;
            }
            set {
                if ((object.ReferenceEquals(this.SearchTermsField, value) != true)) {
                    this.SearchTermsField = value;
                    this.RaisePropertyChanged("SearchTerms");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ModelPoco")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AccountTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.Address[] AddressesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.Basket[] BasketsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RetypeEmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RetypePasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public string AccountType {
            get {
                return this.AccountTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountTypeField, value) != true)) {
                    this.AccountTypeField = value;
                    this.RaisePropertyChanged("AccountType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.Address[] Addresses {
            get {
                return this.AddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressesField, value) != true)) {
                    this.AddressesField = value;
                    this.RaisePropertyChanged("Addresses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.Basket[] Baskets {
            get {
                return this.BasketsField;
            }
            set {
                if ((object.ReferenceEquals(this.BasketsField, value) != true)) {
                    this.BasketsField = value;
                    this.RaisePropertyChanged("Baskets");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RetypeEmailAddress {
            get {
                return this.RetypeEmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.RetypeEmailAddressField, value) != true)) {
                    this.RetypeEmailAddressField = value;
                    this.RaisePropertyChanged("RetypeEmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RetypePassword {
            get {
                return this.RetypePasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.RetypePasswordField, value) != true)) {
                    this.RetypePasswordField = value;
                    this.RaisePropertyChanged("RetypePassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/ModelPoco")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Line1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Line2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Line3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SoloProjectMvc.BasketItemsReference.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public int AddressId {
            get {
                return this.AddressIdField;
            }
            set {
                if ((this.AddressIdField.Equals(value) != true)) {
                    this.AddressIdField = value;
                    this.RaisePropertyChanged("AddressId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string County {
            get {
                return this.CountyField;
            }
            set {
                if ((object.ReferenceEquals(this.CountyField, value) != true)) {
                    this.CountyField = value;
                    this.RaisePropertyChanged("County");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Line1 {
            get {
                return this.Line1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Line1Field, value) != true)) {
                    this.Line1Field = value;
                    this.RaisePropertyChanged("Line1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Line2 {
            get {
                return this.Line2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Line2Field, value) != true)) {
                    this.Line2Field = value;
                    this.RaisePropertyChanged("Line2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Line3 {
            get {
                return this.Line3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Line3Field, value) != true)) {
                    this.Line3Field = value;
                    this.RaisePropertyChanged("Line3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Postcode {
            get {
                return this.PostcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostcodeField, value) != true)) {
                    this.PostcodeField = value;
                    this.RaisePropertyChanged("Postcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SoloProjectMvc.BasketItemsReference.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BasketItemsReference.IBasketItemsService")]
    public interface IBasketItemsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemsService/PopulateBasketAndProductKeys", ReplyAction="http://tempuri.org/IBasketItemsService/PopulateBasketAndProductKeysResponse")]
        void PopulateBasketAndProductKeys(int basketId, int productId, SoloProjectMvc.BasketItemsReference.BasketItem basketItem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasketItemsService/PopulateBasketAndProductKeys", ReplyAction="http://tempuri.org/IBasketItemsService/PopulateBasketAndProductKeysResponse")]
        System.Threading.Tasks.Task PopulateBasketAndProductKeysAsync(int basketId, int productId, SoloProjectMvc.BasketItemsReference.BasketItem basketItem);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasketItemsServiceChannel : SoloProjectMvc.BasketItemsReference.IBasketItemsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasketItemsServiceClient : System.ServiceModel.ClientBase<SoloProjectMvc.BasketItemsReference.IBasketItemsService>, SoloProjectMvc.BasketItemsReference.IBasketItemsService {
        
        public BasketItemsServiceClient() {
        }
        
        public BasketItemsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasketItemsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketItemsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasketItemsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void PopulateBasketAndProductKeys(int basketId, int productId, SoloProjectMvc.BasketItemsReference.BasketItem basketItem) {
            base.Channel.PopulateBasketAndProductKeys(basketId, productId, basketItem);
        }
        
        public System.Threading.Tasks.Task PopulateBasketAndProductKeysAsync(int basketId, int productId, SoloProjectMvc.BasketItemsReference.BasketItem basketItem) {
            return base.Channel.PopulateBasketAndProductKeysAsync(basketId, productId, basketItem);
        }
    }
}
