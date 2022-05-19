Imports Microsoft.VisualBasic
Imports System
Namespace Q143451
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.nwindDataSet = New nwindDataSet()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
            Me.myPivotGridControl2 = New DXSample.MyPivotGridControl()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.myPivotGridControl1 = New DXSample.MyPivotGridControl()
            Me.fieldOrderDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson2 = New DevExpress.XtraPivotGrid.PivotGridField()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myPivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'bindingSource1
            '
            Me.bindingSource1.DataMember = "SalesPerson"
            Me.bindingSource1.DataSource = Me.nwindDataSet
            '
            'salesPersonTableAdapter
            '
            Me.salesPersonTableAdapter.ClearBeforeFill = True
            '
            'myPivotGridControl2
            '
            Me.myPivotGridControl2.Cursor = System.Windows.Forms.Cursors.Default
            Me.myPivotGridControl2.DataSource = Me.bindingSource1
            Me.myPivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderDate, Me.fieldUnitPrice, Me.fieldSalesPerson})
            Me.myPivotGridControl2.Location = New System.Drawing.Point(12, 238)
            Me.myPivotGridControl2.Name = "myPivotGridControl2"
            Me.myPivotGridControl2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.myPivotGridControl2.Size = New System.Drawing.Size(400, 200)
            Me.myPivotGridControl2.SynchronizedPivot = Me.myPivotGridControl1
            Me.myPivotGridControl2.TabIndex = 1
            '
            'fieldOrderDate
            '
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "OrderDate"
            Me.fieldOrderDate.DataBinding = DataSourceColumnBinding1
            Me.fieldOrderDate.Name = "fieldOrderDate"
            '
            'fieldUnitPrice
            '
            Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice.AreaIndex = 0
            DataSourceColumnBinding2.ColumnName = "UnitPrice"
            Me.fieldUnitPrice.DataBinding = DataSourceColumnBinding2
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            '
            'fieldSalesPerson
            '
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 0
            DataSourceColumnBinding3.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = DataSourceColumnBinding3
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            '
            'myPivotGridControl1
            '
            Me.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.myPivotGridControl1.DataSource = Me.bindingSource1
            Me.myPivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderDate2, Me.fieldUnitPrice2, Me.fieldSalesPerson2})
            Me.myPivotGridControl1.Location = New System.Drawing.Point(12, 12)
            Me.myPivotGridControl1.Name = "myPivotGridControl1"
            Me.myPivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.myPivotGridControl1.Size = New System.Drawing.Size(400, 200)
            Me.myPivotGridControl1.SynchronizedPivot = Me.myPivotGridControl2
            Me.myPivotGridControl1.TabIndex = 0
            '
            'fieldOrderDate2
            '
            Me.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate2.AreaIndex = 0
            DataSourceColumnBinding4.ColumnName = "OrderDate"
            Me.fieldOrderDate2.DataBinding = DataSourceColumnBinding4
            Me.fieldOrderDate2.Name = "fieldOrderDate2"
            '
            'fieldUnitPrice2
            '
            Me.fieldUnitPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice2.AreaIndex = 0
            DataSourceColumnBinding5.ColumnName = "UnitPrice"
            Me.fieldUnitPrice2.DataBinding = DataSourceColumnBinding5
            Me.fieldUnitPrice2.Name = "fieldUnitPrice2"
            '
            'fieldSalesPerson2
            '
            Me.fieldSalesPerson2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson2.AreaIndex = 0
            DataSourceColumnBinding6.ColumnName = "Sales Person"
            Me.fieldSalesPerson2.DataBinding = DataSourceColumnBinding6
            Me.fieldSalesPerson2.Name = "fieldSalesPerson2"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(432, 466)
            Me.Controls.Add(Me.myPivotGridControl2)
            Me.Controls.Add(Me.myPivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myPivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private myPivotGridControl1 As DXSample.MyPivotGridControl
		Private myPivotGridControl2 As DXSample.MyPivotGridControl
		Private nwindDataSet As nwindDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
        Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
        Private fieldOrderDate2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

