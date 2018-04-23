Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Namespace WebApplication
	Public NotInheritable Class WebApiConfig
		Private Sub New()
		End Sub
		Public Shared Sub Register(ByVal config As HttpConfiguration)
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", New With {Key .id = RouteParameter.Optional})
		End Sub
	End Class
End Namespace