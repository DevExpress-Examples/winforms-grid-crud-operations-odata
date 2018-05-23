Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web
Imports System.Web
Imports System.ServiceModel

Namespace XtraGridDataServiceExample.Service
	<ServiceBehavior(IncludeExceptionDetailInFaults := True)> _
	Public Class NorthwindGate
		Inherits DataService(Of NorthwindEntities)
		' This method is called only once to initialize service-wide policies.
		Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
			' TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
			' Examples:
			config.SetEntitySetAccessRule("Products", EntitySetRights.AllRead Or EntitySetRights.AllWrite)
			' config.SetServiceOperationAccessRule("MyServiceOperation", ServiceOperationRights.All);
			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2
			config.UseVerboseErrors = True
		End Sub
	End Class
End Namespace
