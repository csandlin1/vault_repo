﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace DPI.Reports {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class dsSalesRptByStore : DataSet {
        
        private SalesRptByStoreDataTable tableSalesRptByStore;
        
        public dsSalesRptByStore() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsSalesRptByStore(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["SalesRptByStore"] != null)) {
                    this.Tables.Add(new SalesRptByStoreDataTable(ds.Tables["SalesRptByStore"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public SalesRptByStoreDataTable SalesRptByStore {
            get {
                return this.tableSalesRptByStore;
            }
        }
        
        public override DataSet Clone() {
            dsSalesRptByStore cln = ((dsSalesRptByStore)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["SalesRptByStore"] != null)) {
                this.Tables.Add(new SalesRptByStoreDataTable(ds.Tables["SalesRptByStore"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableSalesRptByStore = ((SalesRptByStoreDataTable)(this.Tables["SalesRptByStore"]));
            if ((this.tableSalesRptByStore != null)) {
                this.tableSalesRptByStore.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsSalesRptByStore";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsSalesRptByStore.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableSalesRptByStore = new SalesRptByStoreDataTable();
            this.Tables.Add(this.tableSalesRptByStore);
        }
        
        private bool ShouldSerializeSalesRptByStore() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void SalesRptByStoreRowChangeEventHandler(object sender, SalesRptByStoreRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SalesRptByStoreDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnStateName;
            
            private DataColumn columnDMADesc;
            
            private DataColumn columnSales_Count;
            
            private DataColumn columnReportPeriod;
            
            private DataColumn columnTransactionType;
            
            private DataColumn columnStoreName_Number;
            
            private DataColumn columnAddress;
            
            private DataColumn columnCityStateZip;
            
            private DataColumn columnpLM;
            
            internal SalesRptByStoreDataTable() : 
                    base("SalesRptByStore") {
                this.InitClass();
            }
            
            internal SalesRptByStoreDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn StateNameColumn {
                get {
                    return this.columnStateName;
                }
            }
            
            internal DataColumn DMADescColumn {
                get {
                    return this.columnDMADesc;
                }
            }
            
            internal DataColumn Sales_CountColumn {
                get {
                    return this.columnSales_Count;
                }
            }
            
            internal DataColumn ReportPeriodColumn {
                get {
                    return this.columnReportPeriod;
                }
            }
            
            internal DataColumn TransactionTypeColumn {
                get {
                    return this.columnTransactionType;
                }
            }
            
            internal DataColumn StoreName_NumberColumn {
                get {
                    return this.columnStoreName_Number;
                }
            }
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn CityStateZipColumn {
                get {
                    return this.columnCityStateZip;
                }
            }
            
            internal DataColumn pLMColumn {
                get {
                    return this.columnpLM;
                }
            }
            
            public SalesRptByStoreRow this[int index] {
                get {
                    return ((SalesRptByStoreRow)(this.Rows[index]));
                }
            }
            
            public event SalesRptByStoreRowChangeEventHandler SalesRptByStoreRowChanged;
            
            public event SalesRptByStoreRowChangeEventHandler SalesRptByStoreRowChanging;
            
            public event SalesRptByStoreRowChangeEventHandler SalesRptByStoreRowDeleted;
            
            public event SalesRptByStoreRowChangeEventHandler SalesRptByStoreRowDeleting;
            
            public void AddSalesRptByStoreRow(SalesRptByStoreRow row) {
                this.Rows.Add(row);
            }
            
            public SalesRptByStoreRow AddSalesRptByStoreRow(string StateName, string DMADesc, int Sales_Count, string ReportPeriod, string TransactionType, string StoreName_Number, string Address, string CityStateZip, string pLM) {
                SalesRptByStoreRow rowSalesRptByStoreRow = ((SalesRptByStoreRow)(this.NewRow()));
                rowSalesRptByStoreRow.ItemArray = new object[] {
                        StateName,
                        DMADesc,
                        Sales_Count,
                        ReportPeriod,
                        TransactionType,
                        StoreName_Number,
                        Address,
                        CityStateZip,
                        pLM};
                this.Rows.Add(rowSalesRptByStoreRow);
                return rowSalesRptByStoreRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                SalesRptByStoreDataTable cln = ((SalesRptByStoreDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new SalesRptByStoreDataTable();
            }
            
            internal void InitVars() {
                this.columnStateName = this.Columns["StateName"];
                this.columnDMADesc = this.Columns["DMADesc"];
                this.columnSales_Count = this.Columns["Sales_Count"];
                this.columnReportPeriod = this.Columns["ReportPeriod"];
                this.columnTransactionType = this.Columns["TransactionType"];
                this.columnStoreName_Number = this.Columns["StoreName_Number"];
                this.columnAddress = this.Columns["Address"];
                this.columnCityStateZip = this.Columns["CityStateZip"];
                this.columnpLM = this.Columns["pLM"];
            }
            
            private void InitClass() {
                this.columnStateName = new DataColumn("StateName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStateName);
                this.columnDMADesc = new DataColumn("DMADesc", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDMADesc);
                this.columnSales_Count = new DataColumn("Sales_Count", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSales_Count);
                this.columnReportPeriod = new DataColumn("ReportPeriod", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReportPeriod);
                this.columnTransactionType = new DataColumn("TransactionType", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTransactionType);
                this.columnStoreName_Number = new DataColumn("StoreName_Number", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStoreName_Number);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCityStateZip = new DataColumn("CityStateZip", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCityStateZip);
                this.columnpLM = new DataColumn("pLM", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnpLM);
                this.columnStateName.AllowDBNull = true;
                this.columnDMADesc.AllowDBNull = true;
                this.columnSales_Count.AllowDBNull = true;
                this.columnReportPeriod.AllowDBNull = true;
                this.columnTransactionType.AllowDBNull = true;
                this.columnStoreName_Number.AllowDBNull = true;
                this.columnAddress.AllowDBNull = true;
                this.columnCityStateZip.AllowDBNull = true;
                this.columnpLM.AllowDBNull = true;
            }
            
            public SalesRptByStoreRow NewSalesRptByStoreRow() {
                return ((SalesRptByStoreRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new SalesRptByStoreRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(SalesRptByStoreRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.SalesRptByStoreRowChanged != null)) {
                    this.SalesRptByStoreRowChanged(this, new SalesRptByStoreRowChangeEvent(((SalesRptByStoreRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.SalesRptByStoreRowChanging != null)) {
                    this.SalesRptByStoreRowChanging(this, new SalesRptByStoreRowChangeEvent(((SalesRptByStoreRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.SalesRptByStoreRowDeleted != null)) {
                    this.SalesRptByStoreRowDeleted(this, new SalesRptByStoreRowChangeEvent(((SalesRptByStoreRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.SalesRptByStoreRowDeleting != null)) {
                    this.SalesRptByStoreRowDeleting(this, new SalesRptByStoreRowChangeEvent(((SalesRptByStoreRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveSalesRptByStoreRow(SalesRptByStoreRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SalesRptByStoreRow : DataRow {
            
            private SalesRptByStoreDataTable tableSalesRptByStore;
            
            internal SalesRptByStoreRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableSalesRptByStore = ((SalesRptByStoreDataTable)(this.Table));
            }
            
            public string StateName {
                get {
                    return ((string)(this[this.tableSalesRptByStore.StateNameColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.StateNameColumn] = value;
                }
            }
            
            public string DMADesc {
                get {
                    return ((string)(this[this.tableSalesRptByStore.DMADescColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.DMADescColumn] = value;
                }
            }
            
            public int Sales_Count {
                get {
                    return ((int)(this[this.tableSalesRptByStore.Sales_CountColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.Sales_CountColumn] = value;
                }
            }
            
            public string ReportPeriod {
                get {
                    return ((string)(this[this.tableSalesRptByStore.ReportPeriodColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.ReportPeriodColumn] = value;
                }
            }
            
            public string TransactionType {
                get {
                    return ((string)(this[this.tableSalesRptByStore.TransactionTypeColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.TransactionTypeColumn] = value;
                }
            }
            
            public string StoreName_Number {
                get {
                    return ((string)(this[this.tableSalesRptByStore.StoreName_NumberColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.StoreName_NumberColumn] = value;
                }
            }
            
            public string Address {
                get {
                    return ((string)(this[this.tableSalesRptByStore.AddressColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.AddressColumn] = value;
                }
            }
            
            public string CityStateZip {
                get {
                    return ((string)(this[this.tableSalesRptByStore.CityStateZipColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.CityStateZipColumn] = value;
                }
            }
            
            public string pLM {
                get {
                    return ((string)(this[this.tableSalesRptByStore.pLMColumn]));
                }
                set {
                    this[this.tableSalesRptByStore.pLMColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class SalesRptByStoreRowChangeEvent : EventArgs {
            
            private SalesRptByStoreRow eventRow;
            
            private DataRowAction eventAction;
            
            public SalesRptByStoreRowChangeEvent(SalesRptByStoreRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public SalesRptByStoreRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}