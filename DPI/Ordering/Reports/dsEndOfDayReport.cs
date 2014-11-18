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
    public class dsEndOfDayReport : DataSet {
        
        private EndOfDayReportDataTable tableEndOfDayReport;
        
        public dsEndOfDayReport() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected dsEndOfDayReport(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["EndOfDayReport"] != null)) {
                    this.Tables.Add(new EndOfDayReportDataTable(ds.Tables["EndOfDayReport"]));
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
        public EndOfDayReportDataTable EndOfDayReport {
            get {
                return this.tableEndOfDayReport;
            }
        }
        
        public override DataSet Clone() {
            dsEndOfDayReport cln = ((dsEndOfDayReport)(base.Clone()));
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
            if ((ds.Tables["EndOfDayReport"] != null)) {
                this.Tables.Add(new EndOfDayReportDataTable(ds.Tables["EndOfDayReport"]));
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
            this.tableEndOfDayReport = ((EndOfDayReportDataTable)(this.Tables["EndOfDayReport"]));
            if ((this.tableEndOfDayReport != null)) {
                this.tableEndOfDayReport.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "dsEndOfDayReport";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/dsEndOfDayReport.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEndOfDayReport = new EndOfDayReportDataTable();
            this.Tables.Add(this.tableEndOfDayReport);
        }
        
        private bool ShouldSerializeEndOfDayReport() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void EndOfDayReportRowChangeEventHandler(object sender, EndOfDayReportRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EndOfDayReportDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnStoreCode;
            
            private DataColumn columnDate;
            
            private DataColumn columnLocalRevenue;
            
            private DataColumn columnOtherRevenue;
            
            private DataColumn columnLocalCommission;
            
            private DataColumn columnOtherCommission;
            
            private DataColumn columnCreditReceipts;
            
            private DataColumn columnOtherReceipts;
            
            private DataColumn columnControlNumber;
            
            private DataColumn columnStoreNumber;
            
            internal EndOfDayReportDataTable() : 
                    base("EndOfDayReport") {
                this.InitClass();
            }
            
            internal EndOfDayReportDataTable(DataTable table) : 
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
            
            internal DataColumn StoreCodeColumn {
                get {
                    return this.columnStoreCode;
                }
            }
            
            internal DataColumn DateColumn {
                get {
                    return this.columnDate;
                }
            }
            
            internal DataColumn LocalRevenueColumn {
                get {
                    return this.columnLocalRevenue;
                }
            }
            
            internal DataColumn OtherRevenueColumn {
                get {
                    return this.columnOtherRevenue;
                }
            }
            
            internal DataColumn LocalCommissionColumn {
                get {
                    return this.columnLocalCommission;
                }
            }
            
            internal DataColumn OtherCommissionColumn {
                get {
                    return this.columnOtherCommission;
                }
            }
            
            internal DataColumn CreditReceiptsColumn {
                get {
                    return this.columnCreditReceipts;
                }
            }
            
            internal DataColumn OtherReceiptsColumn {
                get {
                    return this.columnOtherReceipts;
                }
            }
            
            internal DataColumn ControlNumberColumn {
                get {
                    return this.columnControlNumber;
                }
            }
            
            internal DataColumn StoreNumberColumn {
                get {
                    return this.columnStoreNumber;
                }
            }
            
            public EndOfDayReportRow this[int index] {
                get {
                    return ((EndOfDayReportRow)(this.Rows[index]));
                }
            }
            
            public event EndOfDayReportRowChangeEventHandler EndOfDayReportRowChanged;
            
            public event EndOfDayReportRowChangeEventHandler EndOfDayReportRowChanging;
            
            public event EndOfDayReportRowChangeEventHandler EndOfDayReportRowDeleted;
            
            public event EndOfDayReportRowChangeEventHandler EndOfDayReportRowDeleting;
            
            public void AddEndOfDayReportRow(EndOfDayReportRow row) {
                this.Rows.Add(row);
            }
            
            public EndOfDayReportRow AddEndOfDayReportRow(string StoreCode, System.DateTime Date, System.Decimal LocalRevenue, System.Decimal OtherRevenue, System.Decimal LocalCommission, System.Decimal OtherCommission, System.Decimal CreditReceipts, System.Decimal OtherReceipts, int ControlNumber, string StoreNumber) {
                EndOfDayReportRow rowEndOfDayReportRow = ((EndOfDayReportRow)(this.NewRow()));
                rowEndOfDayReportRow.ItemArray = new object[] {
                        StoreCode,
                        Date,
                        LocalRevenue,
                        OtherRevenue,
                        LocalCommission,
                        OtherCommission,
                        CreditReceipts,
                        OtherReceipts,
                        ControlNumber,
                        StoreNumber};
                this.Rows.Add(rowEndOfDayReportRow);
                return rowEndOfDayReportRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                EndOfDayReportDataTable cln = ((EndOfDayReportDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new EndOfDayReportDataTable();
            }
            
            internal void InitVars() {
                this.columnStoreCode = this.Columns["StoreCode"];
                this.columnDate = this.Columns["Date"];
                this.columnLocalRevenue = this.Columns["LocalRevenue"];
                this.columnOtherRevenue = this.Columns["OtherRevenue"];
                this.columnLocalCommission = this.Columns["LocalCommission"];
                this.columnOtherCommission = this.Columns["OtherCommission"];
                this.columnCreditReceipts = this.Columns["CreditReceipts"];
                this.columnOtherReceipts = this.Columns["OtherReceipts"];
                this.columnControlNumber = this.Columns["ControlNumber"];
                this.columnStoreNumber = this.Columns["StoreNumber"];
            }
            
            private void InitClass() {
                this.columnStoreCode = new DataColumn("StoreCode", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStoreCode);
                this.columnDate = new DataColumn("Date", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDate);
                this.columnLocalRevenue = new DataColumn("LocalRevenue", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLocalRevenue);
                this.columnOtherRevenue = new DataColumn("OtherRevenue", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOtherRevenue);
                this.columnLocalCommission = new DataColumn("LocalCommission", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLocalCommission);
                this.columnOtherCommission = new DataColumn("OtherCommission", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOtherCommission);
                this.columnCreditReceipts = new DataColumn("CreditReceipts", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCreditReceipts);
                this.columnOtherReceipts = new DataColumn("OtherReceipts", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOtherReceipts);
                this.columnControlNumber = new DataColumn("ControlNumber", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnControlNumber);
                this.columnStoreNumber = new DataColumn("StoreNumber", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnStoreNumber);
            }
            
            public EndOfDayReportRow NewEndOfDayReportRow() {
                return ((EndOfDayReportRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new EndOfDayReportRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(EndOfDayReportRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EndOfDayReportRowChanged != null)) {
                    this.EndOfDayReportRowChanged(this, new EndOfDayReportRowChangeEvent(((EndOfDayReportRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EndOfDayReportRowChanging != null)) {
                    this.EndOfDayReportRowChanging(this, new EndOfDayReportRowChangeEvent(((EndOfDayReportRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EndOfDayReportRowDeleted != null)) {
                    this.EndOfDayReportRowDeleted(this, new EndOfDayReportRowChangeEvent(((EndOfDayReportRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EndOfDayReportRowDeleting != null)) {
                    this.EndOfDayReportRowDeleting(this, new EndOfDayReportRowChangeEvent(((EndOfDayReportRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveEndOfDayReportRow(EndOfDayReportRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EndOfDayReportRow : DataRow {
            
            private EndOfDayReportDataTable tableEndOfDayReport;
            
            internal EndOfDayReportRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableEndOfDayReport = ((EndOfDayReportDataTable)(this.Table));
            }
            
            public string StoreCode {
                get {
                    try {
                        return ((string)(this[this.tableEndOfDayReport.StoreCodeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.StoreCodeColumn] = value;
                }
            }
            
            public System.DateTime Date {
                get {
                    try {
                        return ((System.DateTime)(this[this.tableEndOfDayReport.DateColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.DateColumn] = value;
                }
            }
            
            public System.Decimal LocalRevenue {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.LocalRevenueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.LocalRevenueColumn] = value;
                }
            }
            
            public System.Decimal OtherRevenue {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.OtherRevenueColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.OtherRevenueColumn] = value;
                }
            }
            
            public System.Decimal LocalCommission {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.LocalCommissionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.LocalCommissionColumn] = value;
                }
            }
            
            public System.Decimal OtherCommission {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.OtherCommissionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.OtherCommissionColumn] = value;
                }
            }
            
            public System.Decimal CreditReceipts {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.CreditReceiptsColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.CreditReceiptsColumn] = value;
                }
            }
            
            public System.Decimal OtherReceipts {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEndOfDayReport.OtherReceiptsColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.OtherReceiptsColumn] = value;
                }
            }
            
            public int ControlNumber {
                get {
                    try {
                        return ((int)(this[this.tableEndOfDayReport.ControlNumberColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.ControlNumberColumn] = value;
                }
            }
            
            public string StoreNumber {
                get {
                    try {
                        return ((string)(this[this.tableEndOfDayReport.StoreNumberColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEndOfDayReport.StoreNumberColumn] = value;
                }
            }
            
            public bool IsStoreCodeNull() {
                return this.IsNull(this.tableEndOfDayReport.StoreCodeColumn);
            }
            
            public void SetStoreCodeNull() {
                this[this.tableEndOfDayReport.StoreCodeColumn] = System.Convert.DBNull;
            }
            
            public bool IsDateNull() {
                return this.IsNull(this.tableEndOfDayReport.DateColumn);
            }
            
            public void SetDateNull() {
                this[this.tableEndOfDayReport.DateColumn] = System.Convert.DBNull;
            }
            
            public bool IsLocalRevenueNull() {
                return this.IsNull(this.tableEndOfDayReport.LocalRevenueColumn);
            }
            
            public void SetLocalRevenueNull() {
                this[this.tableEndOfDayReport.LocalRevenueColumn] = System.Convert.DBNull;
            }
            
            public bool IsOtherRevenueNull() {
                return this.IsNull(this.tableEndOfDayReport.OtherRevenueColumn);
            }
            
            public void SetOtherRevenueNull() {
                this[this.tableEndOfDayReport.OtherRevenueColumn] = System.Convert.DBNull;
            }
            
            public bool IsLocalCommissionNull() {
                return this.IsNull(this.tableEndOfDayReport.LocalCommissionColumn);
            }
            
            public void SetLocalCommissionNull() {
                this[this.tableEndOfDayReport.LocalCommissionColumn] = System.Convert.DBNull;
            }
            
            public bool IsOtherCommissionNull() {
                return this.IsNull(this.tableEndOfDayReport.OtherCommissionColumn);
            }
            
            public void SetOtherCommissionNull() {
                this[this.tableEndOfDayReport.OtherCommissionColumn] = System.Convert.DBNull;
            }
            
            public bool IsCreditReceiptsNull() {
                return this.IsNull(this.tableEndOfDayReport.CreditReceiptsColumn);
            }
            
            public void SetCreditReceiptsNull() {
                this[this.tableEndOfDayReport.CreditReceiptsColumn] = System.Convert.DBNull;
            }
            
            public bool IsOtherReceiptsNull() {
                return this.IsNull(this.tableEndOfDayReport.OtherReceiptsColumn);
            }
            
            public void SetOtherReceiptsNull() {
                this[this.tableEndOfDayReport.OtherReceiptsColumn] = System.Convert.DBNull;
            }
            
            public bool IsControlNumberNull() {
                return this.IsNull(this.tableEndOfDayReport.ControlNumberColumn);
            }
            
            public void SetControlNumberNull() {
                this[this.tableEndOfDayReport.ControlNumberColumn] = System.Convert.DBNull;
            }
            
            public bool IsStoreNumberNull() {
                return this.IsNull(this.tableEndOfDayReport.StoreNumberColumn);
            }
            
            public void SetStoreNumberNull() {
                this[this.tableEndOfDayReport.StoreNumberColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EndOfDayReportRowChangeEvent : EventArgs {
            
            private EndOfDayReportRow eventRow;
            
            private DataRowAction eventAction;
            
            public EndOfDayReportRowChangeEvent(EndOfDayReportRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public EndOfDayReportRow Row {
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