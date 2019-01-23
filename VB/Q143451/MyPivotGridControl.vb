Imports DevExpress.XtraPivotGrid
Imports System.Drawing

Namespace DXSample
	Public Class MyPivotGridControl
		Inherits PivotGridControl

		Public Sub New()
			MyBase.New()
		End Sub
'INSTANT VB NOTE: The variable synchronizedPivot was renamed since Visual Basic does not allow variables and other class members to have the same name:
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