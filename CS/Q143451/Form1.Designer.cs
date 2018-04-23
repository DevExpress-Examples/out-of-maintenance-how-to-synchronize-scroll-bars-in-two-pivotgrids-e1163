namespace Q143451 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.nwindDataSet = new Q143451.nwindDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new Q143451.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.myPivotGridControl2 = new DXSample.MyPivotGridControl();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.myPivotGridControl1 = new DXSample.MyPivotGridControl();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SalesPerson";
            this.bindingSource1.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // myPivotGridControl2
            // 
            this.myPivotGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl2.DataSource = this.bindingSource1;
            this.myPivotGridControl2.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate1,
            this.fieldUnitPrice1,
            this.fieldSalesPerson1});
            this.myPivotGridControl2.Location = new System.Drawing.Point(12, 238);
            this.myPivotGridControl2.Name = "myPivotGridControl2";
            this.myPivotGridControl2.Size = new System.Drawing.Size(400, 200);
            this.myPivotGridControl2.SynchronizedPivot = this.myPivotGridControl1;
            this.myPivotGridControl2.TabIndex = 1;
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 0;
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice1.AreaIndex = 0;
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson1.AreaIndex = 0;
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl1.DataSource = this.bindingSource1;
            this.myPivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate,
            this.fieldUnitPrice,
            this.fieldSalesPerson});
            this.myPivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.Size = new System.Drawing.Size(400, 200);
            this.myPivotGridControl1.SynchronizedPivot = this.myPivotGridControl2;
            this.myPivotGridControl1.TabIndex = 0;
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.Name = "fieldOrderDate";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 466);
            this.Controls.Add(this.myPivotGridControl2);
            this.Controls.Add(this.myPivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyPivotGridControl myPivotGridControl1;
        private DXSample.MyPivotGridControl myPivotGridControl2;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Q143451.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
    }
}

