Imports DxSample.Service.Models
Imports System.Linq
Imports System.Web.Http
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web.OData

Namespace DxSample.Service.Controllers
	Public Class CustomersController
		Inherits ODataController

		Private Function CustomerExists(ByVal key As Integer) As Boolean
			Return DataContext.Customers.Any(Function(c) c.ID = key)
		End Function

		<EnableQuery>
		Public Function [Get]() As IQueryable(Of Customer)
			Return DataContext.Customers
		End Function

		<EnableQuery>
		Public Function [Get](<FromODataUri> ByVal key As Integer) As SingleResult(Of Customer)
			Dim result As IQueryable(Of Customer) = DataContext.Customers.Where(Function(c) c.ID = key)
			Return SingleResult.Create(result)
		End Function

		Public Async Function Post(ByVal customer As Customer) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			customer = Await DataContext.AddCustomer(customer.Name)
			Return Me.Created(customer)
		End Function

		Public Async Function Patch(<FromODataUri> ByVal key As Integer, ByVal customer As Delta(Of Customer)) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			Dim entity As Customer = Await DataContext.FindCustomerAsync(key)
			If entity Is Nothing Then
				Return Me.NotFound()
			End If
			customer.Patch(entity)
			Return Me.Updated(entity)
		End Function

		Public Async Function Put(<FromODataUri> ByVal key As Integer, ByVal update As Customer) As Task(Of IHttpActionResult)
			If Not Me.ModelState.IsValid Then
				Return Me.BadRequest(Me.ModelState)
			End If
			If key <> update.ID Then
				Return Me.BadRequest()
			End If
			Await DataContext.UpdateCustomer(update)
			Return Me.Updated(update)
		End Function

		Public Async Function Delete(<FromODataUri> ByVal key As Integer) As Task(Of IHttpActionResult)
			Dim customer As Customer = Await DataContext.FindCustomerAsync(key)
			If customer Is Nothing Then
				Return Me.NotFound()
			End If
			Await DataContext.RemoveCustomer(customer)
			Return Me.StatusCode(HttpStatusCode.NoContent)
		End Function
	End Class
End Namespace