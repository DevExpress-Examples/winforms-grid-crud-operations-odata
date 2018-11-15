<!-- default file list -->
*Files to look at*:

* [WebApiConfig.cs](./CS/DxSample.Service/App_Start/WebApiConfig.cs) (VB: [WebApiConfig.vb](./VB/DxSample.Service/App_Start/WebApiConfig.vb))
* [CustomersController.cs](./CS/DxSample.Service/Controllers/CustomersController.cs) (VB: [CustomersController.vb](./VB/DxSample.Service/Controllers/CustomersController.vb))
* [OrdersController.cs](./CS/DxSample.Service/Controllers/OrdersController.cs) (VB: [OrdersController.vb](./VB/DxSample.Service/Controllers/OrdersController.vb))
* [Customer.cs](./CS/DxSample.Service/Models/Customer.cs) (VB: [Customer.vb](./VB/DxSample.Service/Models/Customer.vb))
* [DataContext.cs](./CS/DxSample.Service/Models/DataContext.cs) (VB: [DataContext.vb](./VB/DxSample.Service/Models/DataContext.vb))
* [Order.cs](./CS/DxSample.Service/Models/Order.cs) (VB: [Order.vb](./VB/DxSample.Service/Models/Order.vb))
* **[MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))**
<!-- default file list end -->
# How to implement CRUD operations using XtraGrid and OData


<p>This example demonstrates how to bind <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic"><u>GridControl</u></a> to <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.bindingsource%28v=VS.100%29.aspx#Y8235"><u>BindingSource</u></a> and populate it with data retrieved from the <a href="http://www.odata.org/">OData</a> services.</p>
<p>Unlike the Entity Framework data context, the OData service context lacks automatic modifications tracking. Programmers must track all changes manually. This example demonstrates how to use XtraGrid events to track changes.</p>
<br />Each time the user makes modifications in cells and commits a modified row, GridView raises the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_RowUpdatedtopic"><u>RowUpdated</u></a> event. This is an optimal moment to notify the data context that an entity was modified. When a row is removed from GridView, it raises another event: <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_RowDeletedtopic">RowDeleted</a>. These two events are sufficient to keep the context aware of all changes.<br />


```cs
private void GridView_RowUpdated(object sender, RowObjectEventArgs e)
{
	if (e.RowHandle == GridControl.NewItemRowHandle) {
		this.Context.AddToOrders((Order)e.Row);
	} else {
		this.Context.UpdateObject(e.Row);
	}
}

private void GridView_RowDeleted(object sender, RowDeletedEventArgs e)
{
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


<p><strong>See also:</strong><strong><br /> </strong><a href="https://www.devexpress.com/Support/Center/p/E4365">How to implement CRUD operations using XtraGrid and WCF Server Mode</a></p>


<h3>Description</h3>

Starting with version 14.1, we introduced the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseColumnView_RowDeletedtopic">ColumnView.RowDeleted</a> event, which is now used in this example

<br/>


