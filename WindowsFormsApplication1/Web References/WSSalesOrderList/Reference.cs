﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WindowsFormsApplication1.WSSalesOrderList {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SalesOrderList_Binding", Namespace="urn:microsoft-dynamics-schemas/page/salesorderlist")]
    public partial class SalesOrderList_Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ReadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadByRecIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReadMultipleOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsUpdatedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetRecIdFromKeyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SalesOrderList_Service() {
            this.Url = global::WindowsFormsApplication1.Properties.Settings.Default.WindowsFormsApplication1_WSSalesOrderList_SalesOrderList_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ReadCompletedEventHandler ReadCompleted;
        
        /// <remarks/>
        public event ReadByRecIdCompletedEventHandler ReadByRecIdCompleted;
        
        /// <remarks/>
        public event ReadMultipleCompletedEventHandler ReadMultipleCompleted;
        
        /// <remarks/>
        public event IsUpdatedCompletedEventHandler IsUpdatedCompleted;
        
        /// <remarks/>
        public event GetRecIdFromKeyCompletedEventHandler GetRecIdFromKeyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/salesorderlist:Read", RequestNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", ResponseElementName="Read_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("SalesOrderList")]
        public SalesOrderList Read(string No) {
            object[] results = this.Invoke("Read", new object[] {
                        No});
            return ((SalesOrderList)(results[0]));
        }
        
        /// <remarks/>
        public void ReadAsync(string No) {
            this.ReadAsync(No, null);
        }
        
        /// <remarks/>
        public void ReadAsync(string No, object userState) {
            if ((this.ReadOperationCompleted == null)) {
                this.ReadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadOperationCompleted);
            }
            this.InvokeAsync("Read", new object[] {
                        No}, this.ReadOperationCompleted, userState);
        }
        
        private void OnReadOperationCompleted(object arg) {
            if ((this.ReadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadCompleted(this, new ReadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/salesorderlist:ReadByRecId", RequestNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", ResponseElementName="ReadByRecId_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("SalesOrderList")]
        public SalesOrderList ReadByRecId(string recId) {
            object[] results = this.Invoke("ReadByRecId", new object[] {
                        recId});
            return ((SalesOrderList)(results[0]));
        }
        
        /// <remarks/>
        public void ReadByRecIdAsync(string recId) {
            this.ReadByRecIdAsync(recId, null);
        }
        
        /// <remarks/>
        public void ReadByRecIdAsync(string recId, object userState) {
            if ((this.ReadByRecIdOperationCompleted == null)) {
                this.ReadByRecIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadByRecIdOperationCompleted);
            }
            this.InvokeAsync("ReadByRecId", new object[] {
                        recId}, this.ReadByRecIdOperationCompleted, userState);
        }
        
        private void OnReadByRecIdOperationCompleted(object arg) {
            if ((this.ReadByRecIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadByRecIdCompleted(this, new ReadByRecIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/salesorderlist:ReadMultiple", RequestNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", ResponseElementName="ReadMultiple_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ReadMultiple_Result")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public SalesOrderList[] ReadMultiple([System.Xml.Serialization.XmlElementAttribute("filter")] SalesOrderList_Filter[] filter, string bookmarkKey, int setSize) {
            object[] results = this.Invoke("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize});
            return ((SalesOrderList[])(results[0]));
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(SalesOrderList_Filter[] filter, string bookmarkKey, int setSize) {
            this.ReadMultipleAsync(filter, bookmarkKey, setSize, null);
        }
        
        /// <remarks/>
        public void ReadMultipleAsync(SalesOrderList_Filter[] filter, string bookmarkKey, int setSize, object userState) {
            if ((this.ReadMultipleOperationCompleted == null)) {
                this.ReadMultipleOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReadMultipleOperationCompleted);
            }
            this.InvokeAsync("ReadMultiple", new object[] {
                        filter,
                        bookmarkKey,
                        setSize}, this.ReadMultipleOperationCompleted, userState);
        }
        
        private void OnReadMultipleOperationCompleted(object arg) {
            if ((this.ReadMultipleCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReadMultipleCompleted(this, new ReadMultipleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/salesorderlist:IsUpdated", RequestNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", ResponseElementName="IsUpdated_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("IsUpdated_Result")]
        public bool IsUpdated(string Key) {
            object[] results = this.Invoke("IsUpdated", new object[] {
                        Key});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IsUpdatedAsync(string Key) {
            this.IsUpdatedAsync(Key, null);
        }
        
        /// <remarks/>
        public void IsUpdatedAsync(string Key, object userState) {
            if ((this.IsUpdatedOperationCompleted == null)) {
                this.IsUpdatedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsUpdatedOperationCompleted);
            }
            this.InvokeAsync("IsUpdated", new object[] {
                        Key}, this.IsUpdatedOperationCompleted, userState);
        }
        
        private void OnIsUpdatedOperationCompleted(object arg) {
            if ((this.IsUpdatedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsUpdatedCompleted(this, new IsUpdatedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:microsoft-dynamics-schemas/page/salesorderlist:GetRecIdFromKey", RequestNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", ResponseElementName="GetRecIdFromKey_Result", ResponseNamespace="urn:microsoft-dynamics-schemas/page/salesorderlist", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("GetRecIdFromKey_Result")]
        public string GetRecIdFromKey(string Key) {
            object[] results = this.Invoke("GetRecIdFromKey", new object[] {
                        Key});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetRecIdFromKeyAsync(string Key) {
            this.GetRecIdFromKeyAsync(Key, null);
        }
        
        /// <remarks/>
        public void GetRecIdFromKeyAsync(string Key, object userState) {
            if ((this.GetRecIdFromKeyOperationCompleted == null)) {
                this.GetRecIdFromKeyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRecIdFromKeyOperationCompleted);
            }
            this.InvokeAsync("GetRecIdFromKey", new object[] {
                        Key}, this.GetRecIdFromKeyOperationCompleted, userState);
        }
        
        private void OnGetRecIdFromKeyOperationCompleted(object arg) {
            if ((this.GetRecIdFromKeyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRecIdFromKeyCompleted(this, new GetRecIdFromKeyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/salesorderlist")]
    public partial class SalesOrderList {
        
        private string keyField;
        
        private string noField;
        
        private string sell_to_Customer_NoField;
        
        private string sell_to_Customer_NameField;
        
        private string external_Document_NoField;
        
        private string sell_to_Post_CodeField;
        
        private string sell_to_Country_Region_CodeField;
        
        private string sell_to_ContactField;
        
        private string bill_to_Customer_NoField;
        
        private string bill_to_NameField;
        
        private string bill_to_Post_CodeField;
        
        private string bill_to_Country_Region_CodeField;
        
        private string bill_to_ContactField;
        
        private string ship_to_CodeField;
        
        private string ship_to_NameField;
        
        private string ship_to_Post_CodeField;
        
        private string ship_to_Country_Region_CodeField;
        
        private string ship_to_ContactField;
        
        private System.DateTime posting_DateField;
        
        private bool posting_DateFieldSpecified;
        
        private string shortcut_Dimension_1_CodeField;
        
        private string shortcut_Dimension_2_CodeField;
        
        private string location_CodeField;
        
        private string salesperson_CodeField;
        
        private string assigned_User_IDField;
        
        private string currency_CodeField;
        
        private System.DateTime document_DateField;
        
        private bool document_DateFieldSpecified;
        
        private Status statusField;
        
        private bool statusFieldSpecified;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string Sell_to_Customer_No {
            get {
                return this.sell_to_Customer_NoField;
            }
            set {
                this.sell_to_Customer_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Sell_to_Customer_Name {
            get {
                return this.sell_to_Customer_NameField;
            }
            set {
                this.sell_to_Customer_NameField = value;
            }
        }
        
        /// <remarks/>
        public string External_Document_No {
            get {
                return this.external_Document_NoField;
            }
            set {
                this.external_Document_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Sell_to_Post_Code {
            get {
                return this.sell_to_Post_CodeField;
            }
            set {
                this.sell_to_Post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Sell_to_Country_Region_Code {
            get {
                return this.sell_to_Country_Region_CodeField;
            }
            set {
                this.sell_to_Country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Sell_to_Contact {
            get {
                return this.sell_to_ContactField;
            }
            set {
                this.sell_to_ContactField = value;
            }
        }
        
        /// <remarks/>
        public string Bill_to_Customer_No {
            get {
                return this.bill_to_Customer_NoField;
            }
            set {
                this.bill_to_Customer_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Bill_to_Name {
            get {
                return this.bill_to_NameField;
            }
            set {
                this.bill_to_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Bill_to_Post_Code {
            get {
                return this.bill_to_Post_CodeField;
            }
            set {
                this.bill_to_Post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Bill_to_Country_Region_Code {
            get {
                return this.bill_to_Country_Region_CodeField;
            }
            set {
                this.bill_to_Country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Bill_to_Contact {
            get {
                return this.bill_to_ContactField;
            }
            set {
                this.bill_to_ContactField = value;
            }
        }
        
        /// <remarks/>
        public string Ship_to_Code {
            get {
                return this.ship_to_CodeField;
            }
            set {
                this.ship_to_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Ship_to_Name {
            get {
                return this.ship_to_NameField;
            }
            set {
                this.ship_to_NameField = value;
            }
        }
        
        /// <remarks/>
        public string Ship_to_Post_Code {
            get {
                return this.ship_to_Post_CodeField;
            }
            set {
                this.ship_to_Post_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Ship_to_Country_Region_Code {
            get {
                return this.ship_to_Country_Region_CodeField;
            }
            set {
                this.ship_to_Country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Ship_to_Contact {
            get {
                return this.ship_to_ContactField;
            }
            set {
                this.ship_to_ContactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Posting_Date {
            get {
                return this.posting_DateField;
            }
            set {
                this.posting_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Posting_DateSpecified {
            get {
                return this.posting_DateFieldSpecified;
            }
            set {
                this.posting_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Shortcut_Dimension_1_Code {
            get {
                return this.shortcut_Dimension_1_CodeField;
            }
            set {
                this.shortcut_Dimension_1_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Shortcut_Dimension_2_Code {
            get {
                return this.shortcut_Dimension_2_CodeField;
            }
            set {
                this.shortcut_Dimension_2_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Location_Code {
            get {
                return this.location_CodeField;
            }
            set {
                this.location_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Salesperson_Code {
            get {
                return this.salesperson_CodeField;
            }
            set {
                this.salesperson_CodeField = value;
            }
        }
        
        /// <remarks/>
        public string Assigned_User_ID {
            get {
                return this.assigned_User_IDField;
            }
            set {
                this.assigned_User_IDField = value;
            }
        }
        
        /// <remarks/>
        public string Currency_Code {
            get {
                return this.currency_CodeField;
            }
            set {
                this.currency_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Document_Date {
            get {
                return this.document_DateField;
            }
            set {
                this.document_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Document_DateSpecified {
            get {
                return this.document_DateFieldSpecified;
            }
            set {
                this.document_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Status Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/salesorderlist")]
    public enum Status {
        
        /// <remarks/>
        Open,
        
        /// <remarks/>
        Released,
        
        /// <remarks/>
        Pending_Approval,
        
        /// <remarks/>
        Pending_Prepayment,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/salesorderlist")]
    public partial class SalesOrderList_Filter {
        
        private SalesOrderList_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        public SalesOrderList_Fields Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        public string Criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/salesorderlist")]
    public enum SalesOrderList_Fields {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Sell_to_Customer_No,
        
        /// <remarks/>
        Sell_to_Customer_Name,
        
        /// <remarks/>
        External_Document_No,
        
        /// <remarks/>
        Sell_to_Post_Code,
        
        /// <remarks/>
        Sell_to_Country_Region_Code,
        
        /// <remarks/>
        Sell_to_Contact,
        
        /// <remarks/>
        Bill_to_Customer_No,
        
        /// <remarks/>
        Bill_to_Name,
        
        /// <remarks/>
        Bill_to_Post_Code,
        
        /// <remarks/>
        Bill_to_Country_Region_Code,
        
        /// <remarks/>
        Bill_to_Contact,
        
        /// <remarks/>
        Ship_to_Code,
        
        /// <remarks/>
        Ship_to_Name,
        
        /// <remarks/>
        Ship_to_Post_Code,
        
        /// <remarks/>
        Ship_to_Country_Region_Code,
        
        /// <remarks/>
        Ship_to_Contact,
        
        /// <remarks/>
        Posting_Date,
        
        /// <remarks/>
        Shortcut_Dimension_1_Code,
        
        /// <remarks/>
        Shortcut_Dimension_2_Code,
        
        /// <remarks/>
        Location_Code,
        
        /// <remarks/>
        Salesperson_Code,
        
        /// <remarks/>
        Assigned_User_ID,
        
        /// <remarks/>
        Currency_Code,
        
        /// <remarks/>
        Document_Date,
        
        /// <remarks/>
        Status,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void ReadCompletedEventHandler(object sender, ReadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SalesOrderList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SalesOrderList)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void ReadByRecIdCompletedEventHandler(object sender, ReadByRecIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadByRecIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadByRecIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SalesOrderList Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SalesOrderList)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void ReadMultipleCompletedEventHandler(object sender, ReadMultipleCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReadMultipleCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReadMultipleCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SalesOrderList[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SalesOrderList[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void IsUpdatedCompletedEventHandler(object sender, IsUpdatedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsUpdatedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsUpdatedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetRecIdFromKeyCompletedEventHandler(object sender, GetRecIdFromKeyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRecIdFromKeyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRecIdFromKeyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591