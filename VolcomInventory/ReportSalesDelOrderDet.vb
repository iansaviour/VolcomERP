﻿Public Class ReportSalesDelOrderDet
    Public Shared id_pl_sales_order_del As String
    Public Shared dt As DataTable
    Public Shared id_pre As String = "-1"

    Private Sub GVItemList_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVItemList.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub ReportSalesDelOrderDet_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        GCItemList.DataSource = dt
        If id_pre = "-1" Then
            load_mark_horz("43", id_pl_sales_order_del, "2", "1", XrTable1)
        Else
            pre_load_mark_horz("43", id_pl_sales_order_del, "2", "2", XrTable1)
        End If
    End Sub
End Class