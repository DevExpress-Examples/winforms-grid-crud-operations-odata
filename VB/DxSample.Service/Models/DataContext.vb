Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Namespace DxSample.Service.Models
	Public NotInheritable Class DataContext

		Private Sub New()
		End Sub

		Private Shared ListCustomers As List(Of Customer)
		Private Shared ListOrders As List(Of Order)
		Private Shared CustomersCounter As Integer
        Private Shared OrdersCounter As Integer
        Private Shared ReadOnly Sync As New Object

		Shared Sub New()
			DataContext.ListCustomers = New List(Of Customer)()
			DataContext.ListOrders = New List(Of Order)()
			DataContext.CustomersCounter = 1
			DataContext.OrdersCounter = 1
			DataContext.AddCustomer("John")
			DataContext.AddCustomer("Bob")
			DataContext.AddOrder("Chai", 1)
			DataContext.AddOrder("Chang", 1)
			DataContext.AddOrder("Queso Caprale", 2)
		End Sub

		Public Shared ReadOnly Property Customers() As IQueryable(Of Customer)
			Get
				Return DataContext.ListCustomers.AsQueryable()
			End Get
		End Property

		Public Shared ReadOnly Property Orders() As IQueryable(Of Order)
			Get
				Return DataContext.ListOrders.AsQueryable()
			End Get
		End Property

		Public Shared Function AddCustomer(ByVal name As String) As Task(Of Customer)
            Return Task.Run(Of Customer)(Function()
                                             SyncLock DataContext.Sync
                                                 Dim result As New Customer() With {
                                                     .ID = DataContext.CustomersCounter,
                                                     .Name = name}
                                                 DataContext.CustomersCounter = DataContext.CustomersCounter + 1
                                                 DataContext.ListCustomers.Add(result)
                                                 Return result
                                             End SyncLock

                                         End Function)
		End Function

		Public Shared Function AddOrder(ByVal name As String, ByVal customerID As Integer) As Task(Of Order)
            Return Task.Run(Of Order)(Function()
                                          SyncLock DataContext.Sync
                                              Dim result As New Order() With {
                                                  .ID = DataContext.OrdersCounter,
                                                  .Name = name,
                                                  .CustomerID = customerID}
                                              DataContext.OrdersCounter = DataContext.OrdersCounter + 1
                                              DataContext.ListOrders.Add(result)
                                              Return result
                                          End SyncLock
                                      End Function)
		End Function

		Public Shared Function FindCustomerAsync(ByVal key As Integer) As Task(Of Customer)
			Return Task.Run(Of Customer)(Function() DataContext.Customers.SingleOrDefault(Function(c) c.ID = key))
		End Function

		Public Shared Function FindOrderAsync(ByVal key As Integer) As Task(Of Order)
			Return Task.Run(Of Order)(Function() DataContext.Orders.SingleOrDefault(Function(o) o.ID = key))
		End Function

		Public Shared Function UpdateCustomer(ByVal customer As Customer) As Task
			Return Task.Run(Sub()
				Dim original As Customer = DataContext.Customers.Single(Function(c) c.ID = customer.ID)
				Dim index As Integer = DataContext.ListCustomers.IndexOf(original)
				DataContext.ListCustomers(index) = customer
			End Sub)
		End Function

		Public Shared Function UpdateOrder(ByVal order As Order) As Task
			Return Task.Run(Sub()
				Dim original As Order = DataContext.Orders.Single(Function(o) o.ID = order.ID)
				Dim index As Integer = DataContext.ListOrders.IndexOf(original)
				DataContext.ListOrders(index) = order
			End Sub)
		End Function

		Public Shared Function RemoveCustomer(ByVal customer As Customer) As Task
			Return Task.Run(Function() DataContext.ListCustomers.Remove(customer))
		End Function

		Public Shared Function RemoveOrder(ByVal order As Order) As Task
			Return Task.Run(Function() DataContext.ListOrders.Remove(order))
		End Function
	End Class
End Namespace