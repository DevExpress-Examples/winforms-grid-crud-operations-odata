<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134576837/14.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4070)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - CRUD operations (OData)

This example shows how to bind the WinForms Data Grid control to a `BindingSource` that gets data from [OData services](https://www.odata.org).

Unlike the Entity Framework data context, the OData service context does not have automatic change tracking (you must track changes manually). This example demonstrates how to handle grid events to track user edits.

Each time the user changes the value in a cell and commits the row, the `GridView` raises the [RowUpdated](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.RowUpdated) event. Handle this event to notify the data context about the change. When a row has been deleted, the `GridView` raises the [RowDeleted](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.RowDeleted) event.

```cs
private void GridView_RowUpdated(object sender, RowObjectEventArgs e) {
  if (e.RowHandle == GridControl.NewItemRowHandle) {
    this.Context.AddToOrders((Order)e.Row);
  } else {
    this.Context.UpdateObject(e.Row);
  }
}

private void GridView_RowDeleted(object sender, RowDeletedEventArgs e) {
  this.Context.DeleteObject(e.Row);
}
```

```vb
Private Sub GridView_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
  If e.RowHandle = GridControl.NewItemRowHandle Then
    Me.Context.AddToOrders(CType(e.Row, Order))
    Else Me.Context.UpdateObject(e.Row)
  End If
End Sub

Private Sub GridView_RowDeleted(sender As Object, e As RowDeletedEventArgs) Handles GridView1.RowDeleted
  Me.Context.DeleteObject(e.Row)
End Sub
```


## Files to Review

* [MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))
* [WebApiConfig.cs](./CS/DxSample.Service/App_Start/WebApiConfig.cs) (VB: [WebApiConfig.vb](./VB/DxSample.Service/App_Start/WebApiConfig.vb))
* [CustomersController.cs](./CS/DxSample.Service/Controllers/CustomersController.cs) (VB: [CustomersController.vb](./VB/DxSample.Service/Controllers/CustomersController.vb))
* [OrdersController.cs](./CS/DxSample.Service/Controllers/OrdersController.cs) (VB: [OrdersController.vb](./VB/DxSample.Service/Controllers/OrdersController.vb))
* [Customer.cs](./CS/DxSample.Service/Models/Customer.cs) (VB: [Customer.vb](./VB/DxSample.Service/Models/Customer.vb))
* [DataContext.cs](./CS/DxSample.Service/Models/DataContext.cs) (VB: [DataContext.vb](./VB/DxSample.Service/Models/DataContext.vb))
* [Order.cs](./CS/DxSample.Service/Models/Order.cs) (VB: [Order.vb](./VB/DxSample.Service/Models/Order.vb))


## Documentaion

* [Data Binding - WinForms Data Grid](https://docs.devexpress.com/WindowsForms/634/controls-and-libraries/data-grid/data-binding)
