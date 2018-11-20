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
            Me.nwindDataSet = New nwindDataSet()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
            Me.myPivotGridControl2 = New DXSample.MyPivotGridControl()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.myPivotGridControl1 = New DXSample.MyPivotGridControl()
			Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myPivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "SalesPerson"
			Me.bindingSource1.DataSource = Me.nwindDataSet
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' myPivotGridControl2
			' 
			Me.myPivotGridControl2.Cursor = System.Windows.Forms.Cursors.Default
			Me.myPivotGridControl2.DataSource = Me.bindingSource1
			Me.myPivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderDate1, Me.fieldUnitPrice1, Me.fieldSalesPerson1})
			Me.myPivotGridControl2.Location = New System.Drawing.Point(12, 238)
			Me.myPivotGridControl2.Name = "myPivotGridControl2"
			Me.myPivotGridControl2.Size = New System.Drawing.Size(400, 200)
			Me.myPivotGridControl2.SynchronizedPivot = Me.myPivotGridControl1
			Me.myPivotGridControl2.TabIndex = 1
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate1.AreaIndex = 0
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice1.AreaIndex = 0
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson1.AreaIndex = 0
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' myPivotGridControl1
			' 
			Me.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.myPivotGridControl1.DataSource = Me.bindingSource1
			Me.myPivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderDate, Me.fieldUnitPrice, Me.fieldSalesPerson})
			Me.myPivotGridControl1.Location = New System.Drawing.Point(12, 12)
			Me.myPivotGridControl1.Name = "myPivotGridControl1"
			Me.myPivotGridControl1.Size = New System.Drawing.Size(400, 200)
			Me.myPivotGridControl1.SynchronizedPivot = Me.myPivotGridControl2
			Me.myPivotGridControl1.TabIndex = 0
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate.AreaIndex = 0
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.Name = "fieldOrderDate"
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice.AreaIndex = 0
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(432, 466)
			Me.Controls.Add(Me.myPivotGridControl2)
			Me.Controls.Add(Me.myPivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
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
        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

