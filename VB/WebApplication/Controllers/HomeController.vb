Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports DevExpress.Data.WcfLinq
Imports NwindServiceReference

Namespace DXWebApplication1.Controllers
    Public Class HomeController
        Inherits Controller

        Private db As New northwindEntities(New Uri("http://localhost:60491/WcfDataService1.svc"))

        Public Function Index() As ActionResult
            Return View()
        End Function

        <ValidateInput(False)> _
        Public Function GridViewPartial() As ActionResult
            Dim model = GetWcfDataSource()
            Return PartialView("_GridViewPartial", model)
        End Function

        Private Function GetWcfDataSource() As WcfServerModeSource
            Return New WcfServerModeSource() With {.KeyExpression = "OrderID", .Query = db.Orders.Expand(Function(q) q.Customer).Expand(Function(q) q.Shipper)}
        End Function
    End Class
End Namespace