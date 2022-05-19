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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.nwindDataSet = new Q143451.nwindDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new Q143451.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.myPivotGridControl2 = new DXSample.MyPivotGridControl();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.myPivotGridControl1 = new DXSample.MyPivotGridControl();
            this.fieldOrderDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson2 = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.fieldOrderDate,
            this.fieldUnitPrice,
            this.fieldSalesPerson});
            this.myPivotGridControl2.Location = new System.Drawing.Point(12, 238);
            this.myPivotGridControl2.Name = "myPivotGridControl2";
            this.myPivotGridControl2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.myPivotGridControl2.Size = new System.Drawing.Size(400, 200);
            this.myPivotGridControl2.SynchronizedPivot = this.myPivotGridControl1;
            this.myPivotGridControl2.TabIndex = 1;
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            dataSourceColumnBinding1.ColumnName = "OrderDate";
            this.fieldOrderDate.DataBinding = dataSourceColumnBinding1;
            this.fieldOrderDate.Name = "fieldOrderDate";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            dataSourceColumnBinding2.ColumnName = "UnitPrice";
            this.fieldUnitPrice.DataBinding = dataSourceColumnBinding2;
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson.AreaIndex = 0;
            dataSourceColumnBinding3.ColumnName = "Sales Person";
            this.fieldSalesPerson.DataBinding = dataSourceColumnBinding3;
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl1.DataSource = this.bindingSource1;
            this.myPivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderDate2,
            this.fieldUnitPrice2,
            this.fieldSalesPerson2});
            this.myPivotGridControl1.Location = new System.Drawing.Point(12, 12);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.myPivotGridControl1.Size = new System.Drawing.Size(400, 200);
            this.myPivotGridControl1.SynchronizedPivot = this.myPivotGridControl2;
            this.myPivotGridControl1.TabIndex = 0;
            // 
            // fieldOrderDate2
            // 
            this.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate2.AreaIndex = 0;
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            this.fieldOrderDate2.DataBinding = dataSourceColumnBinding4;
            this.fieldOrderDate2.Name = "fieldOrderDate2";
            // 
            // fieldUnitPrice2
            // 
            this.fieldUnitPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice2.AreaIndex = 0;
            dataSourceColumnBinding5.ColumnName = "UnitPrice";
            this.fieldUnitPrice2.DataBinding = dataSourceColumnBinding5;
            this.fieldUnitPrice2.Name = "fieldUnitPrice2";
            // 
            // fieldSalesPerson2
            // 
            this.fieldSalesPerson2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSalesPerson2.AreaIndex = 0;
            dataSourceColumnBinding6.ColumnName = "Sales Person";
            this.fieldSalesPerson2.DataBinding = dataSourceColumnBinding6;
            this.fieldSalesPerson2.Name = "fieldSalesPerson2";
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
    }
}

