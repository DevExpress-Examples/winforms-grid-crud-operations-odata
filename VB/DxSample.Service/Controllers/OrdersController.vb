Imports DxSample.Service.Models
Imports System.Linq
Imports System.Web.Http
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web.OData

Namespace DxSample.Service.Controllers
	Public Class OrdersController
		Inherits ODataController

		Private Function OrderExists(ByVal key As Integer) As Boolean
			Return DataContext.Orders.Any(Function(c) c.ID = key)
		End Function

		<EnableQuery>
		Public Function [Get]() As IQueryable(Of Order)
			Return DataContext.Orders
		End Function

		<EnableQuery>
		Public Function [Get](<FromODataUri> ByVal key As Integer) As SingleResult(Of Order)
			Dim result As IQueryable(Of Order) = DataContext.Orders.Where(Function(c) c.ID = key)
			Return SingleResult.Create(result)
		End Function

		Public Async Function Post(ByVal order As Order) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			order = Await DataContext.AddOrder(order.Name, order.CustomerID)
			Return Me.Created(order)
		End Function

		Public Async Function Patch(<FromODataUri> ByVal key As Integer, ByVal order As Delta(Of Order)) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			Dim entity As Order = Await DataContext.FindOrderAsync(key)
			If entity Is Nothing Then
				Return Me.NotFound()
			End If
			order.Patch(entity)
			Return Me.Updated(entity)
		End Function

		Public Async Function Put(<FromODataUri> ByVal key As Integer, ByVal update As Order) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			If key <> update.ID Then
				Return Me.BadRequest()
			End If
			Await DataContext.UpdateOrder(update)
			Return Me.Updated(update)
		End Function

		Public Async Function Delete(<FromODataUri> ByVal key As Integer) As Task(Of IHttpActionResult)
			Dim order As Order = Await DataContext.FindOrderAsync(key)
			If order Is Nothing Then
				Return Me.NotFound()
			End If
			Await DataContext.RemoveOrder(order)
			Return Me.StatusCode(HttpStatusCode.NoContent)
		End Function
	End Class
End Namespace