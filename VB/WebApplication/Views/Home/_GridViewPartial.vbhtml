@Html.DevExpress().GridView(
        Sub(settings)
                settings.Name = "GridView"
                settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}

                settings.KeyFieldName = "OrderID"

                settings.SettingsPager.Visible = True
                settings.Settings.ShowGroupPanel = True
                settings.Settings.ShowFilterRow = True
                settings.SettingsBehavior.AllowSelectByRowClick = True

                settings.Columns.Add("OrderID")
                settings.Columns.Add("Customer.ContactName")
                settings.Columns.Add("ShippedDate")
                settings.Columns.Add("Shipper.CompanyName")
        End Sub).Bind(Model).GetHtml()