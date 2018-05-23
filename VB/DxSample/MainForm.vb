Imports DevExpress.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DxSample.Service.Models
Imports System
Imports System.Linq

Namespace DxSample
	Partial Public Class MainForm
		Inherits XtraForm

		Private Context As New [Default].Container(New Uri("http://localhost:50936/"))

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.customerBindingSource.DataSource = Me.Context.Customers.ToList()
			Me.orderBindingSource.DataSource = Me.Context.Orders.ToList()
		End Sub

		Private Sub GridView_RowUpdated(ByVal sender As Object, ByVal e As RowObjectEventArgs) Handles GridView.RowUpdated
			If e.RowHandle = GridControl.NewItemRowHandle Then
				Me.Context.AddToOrders(DirectCast(e.Row, Order))
			Else
				Me.Context.UpdateObject(e.Row)
			End If
		End Sub

		Private Sub GridView_RowDeleted(ByVal sender As Object, ByVal e As RowDeletedEventArgs) Handles GridView.RowDeleted
			Me.Context.DeleteObject(e.Row)
		End Sub

		Private Sub SaveButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles SaveButton.ItemClick
			Me.Context.SaveChanges()
		End Sub
	End Class
End Namespace
