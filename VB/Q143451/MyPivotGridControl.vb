Imports Microsoft.VisualBasic
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Diagnostics
Imports System

Namespace DXSample
	Public Class MyPivotGridControl
		Inherits PivotGridControl
		Public Sub New()
			MyBase.New()
		End Sub
		Private synchronizedPivot_Renamed As MyPivotGridControl
		Public Property SynchronizedPivot() As MyPivotGridControl
			Get
				Return synchronizedPivot_Renamed
			End Get
			Set(ByVal value As MyPivotGridControl)
				synchronizedPivot_Renamed = value
				If synchronizedPivot_Renamed.SynchronizedPivot Is Nothing Then
					synchronizedPivot_Renamed.SynchronizedPivot = Me
					synchronizedPivot_Renamed.Size = Size
				End If
			End Set
		End Property
		Protected Overrides Sub ScrollBarsValueChanged(ByVal newValue As Point)
			MyBase.ScrollBarsValueChanged(newValue)
			synchronizedPivot_Renamed.ScrollBarsValueChangedInternal(newValue)
		End Sub
		Private Sub ScrollBarsValueChangedInternal(ByVal newValue As Point)
			MyBase.ScrollBarsValueChanged(newValue)
		End Sub
	End Class
End Namespace