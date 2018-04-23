'------------------------------------------------------------------------------
' <copyright file="WebDataService.svc.cs" company="Microsoft">
'     Copyright (c) Microsoft Corporation.  All rights reserved.
' </copyright>
'------------------------------------------------------------------------------

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web
Imports System.Web

Namespace WCF
	Public Class WcfDataService1
		Inherits DataService(Of northwindEntities)
		Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
			config.SetEntitySetAccessRule("*", EntitySetRights.AllRead)
			config.SetServiceOperationAccessRule("*", ServiceOperationRights.All)
			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3
		End Sub
	End Class
End Namespace
