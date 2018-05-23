Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports DxSample.Service.Models
Imports System.Web.OData.Builder
Imports System.Web.OData.Extensions

Namespace DxSample.Service
	Public NotInheritable Class WebApiConfig

		Private Sub New()
		End Sub

		Public Shared Sub Register(ByVal config As HttpConfiguration)
			' Web API configuration and services

			' Web API routes
			config.MapHttpAttributeRoutes()

			config.Routes.MapHttpRoute(name:= "DefaultApi", routeTemplate:= "api/{controller}/{id}", defaults:= New With {Key .id = RouteParameter.Optional})

			Dim builder As ODataModelBuilder = New ODataConventionModelBuilder()
			builder.EntitySet(Of Customer)("Customers")
			builder.EntitySet(Of Order)("Orders")
			config.MapODataServiceRoute("ODataRoute", Nothing, builder.GetEdmModel())
		End Sub
	End Class
End Namespace
