﻿Public Class FormChangeStatus
    Public id_pop_up As String = "-1"
    Public id_current As String = ""
    '1 = Finalize WH- Rec Prod
    '2 = Finalize WH- DO
    '3 = RETURN
    '4 = RETURN QC
    '5 = TRF

    Sub viewReportStatus()
        Dim query As String = "SELECT id_report_status, report_status FROM tb_lookup_report_status WHERE id_report_status=3 OR id_report_status=5 OR id_report_status=6 ORDER BY id_report_status ASC "
        viewSearchLookupQuery(SLEStatusRec, query, "id_report_status", "report_status", "id_report_status")
    End Sub

    Private Sub FormChangeStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewReportStatus()
    End Sub

    Private Sub BtnUpdateRec_Click(sender As Object, e As EventArgs) Handles BtnUpdateRec.Click
        If id_pop_up = "1" Then
            Dim check_stt As Boolean = False
            For c As Integer = 0 To ((FormSalesOrderSvcLevel.GVPL.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVPL))
                Dim rs As String = FormSalesOrderSvcLevel.GVPL.GetRowCellValue(c, "id_report_status").ToString
                If rs = "5" Or rs = "6" Then
                    check_stt = True
                    Exit For
                End If
            Next

            If check_stt Then
                stopCustom("Can't update status because data is already locked.")
                FormSalesOrderSvcLevel.GVPL.ActiveFilterString = ""
                Close()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to finalize status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To ((FormSalesOrderSvcLevel.GVPL.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVPL))
                        Dim ch_stt As ClassProductionPLToWHRec = New ClassProductionPLToWHRec()
                        ch_stt.changeStatus(FormSalesOrderSvcLevel.GVPL.GetRowCellValue(i, "id_pl_prod_order_rec").ToString, SLEStatusRec.EditValue.ToString)
                        PBC.PerformStep()
                        PBC.Update()
                    Next
                    Cursor = Cursors.Default
                End If
            End If
            FormSalesOrderSvcLevel.GVPL.ActiveFilterString = ""
            FormSalesOrderSvcLevel.viewRecProduct()
            Close()
        ElseIf id_pop_up = "2" Then
            Dim check_stt As Boolean = False
            For c As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesDelOrder.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesDelOrder))
                Dim rs As String = FormSalesOrderSvcLevel.GVSalesDelOrder.GetRowCellValue(c, "id_report_status").ToString
                If rs = "5" Or rs = "6" Then
                    check_stt = True
                    Exit For
                End If
            Next

            If check_stt Then
                stopCustom("Can't update status because data is already locked.")
                FormSalesOrderSvcLevel.GVSalesDelOrder.ActiveFilterString = ""
                Close()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to finalize status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesDelOrder.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesDelOrder))
                        Dim stt As ClassSalesDelOrder = New ClassSalesDelOrder()
                        stt.changeStatus(FormSalesOrderSvcLevel.GVSalesDelOrder.GetRowCellValue(i, "id_pl_sales_order_del").ToString, SLEStatusRec.EditValue.ToString)
                        PBC.PerformStep()
                        PBC.Update()
                    Next
                    Cursor = Cursors.Default
                End If
            End If
            FormSalesOrderSvcLevel.GVSalesDelOrder.ActiveFilterString = ""
            FormSalesOrderSvcLevel.viewDO()
            Close()
        ElseIf id_pop_up = "3" Then
            Dim check_stt As Boolean = False
            For c As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesReturn.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesReturn))
                Dim rs As String = FormSalesOrderSvcLevel.GVSalesReturn.GetRowCellValue(c, "id_report_status").ToString
                If rs = "5" Or rs = "6" Then
                    check_stt = True
                    Exit For
                End If
            Next

            If check_stt Then
                stopCustom("Can't update status because data is already locked.")
                FormSalesOrderSvcLevel.GVSalesReturn.ActiveFilterString = ""
                Close()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to finalize status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesReturn.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesReturn))
                        Dim stt As ClassSalesReturn = New ClassSalesReturn()
                        stt.changeStatus(FormSalesOrderSvcLevel.GVSalesReturn.GetRowCellValue(i, "id_sales_return").ToString, SLEStatusRec.EditValue.ToString)
                        PBC.PerformStep()
                        PBC.Update()
                    Next
                    Cursor = Cursors.Default
                End If
            End If
            FormSalesOrderSvcLevel.GVSalesReturn.ActiveFilterString = ""
            FormSalesOrderSvcLevel.viewReturn()
            Close()
        ElseIf id_pop_up = "4" Then
            Dim check_stt As Boolean = False
            For c As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesReturnQC.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesReturnQC))
                Dim rs As String = FormSalesOrderSvcLevel.GVSalesReturnQC.GetRowCellValue(c, "id_report_status").ToString
                If rs = "5" Or rs = "6" Then
                    check_stt = True
                    Exit For
                End If
            Next

            If check_stt Then
                stopCustom("Can't update status because data is already locked.")
                FormSalesOrderSvcLevel.GVSalesReturnQC.ActiveFilterString = ""
                Close()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to finalize status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To ((FormSalesOrderSvcLevel.GVSalesReturnQC.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVSalesReturnQC))
                        Dim stt As ClassSalesReturnQC = New ClassSalesReturnQC()
                        stt.changeStatus(FormSalesOrderSvcLevel.GVSalesReturnQC.GetRowCellValue(i, "id_sales_return_qc").ToString, SLEStatusRec.EditValue.ToString)
                        PBC.PerformStep()
                        PBC.Update()
                    Next
                    Cursor = Cursors.Default
                End If
            End If
            FormSalesOrderSvcLevel.GVSalesReturnQC.ActiveFilterString = ""
            FormSalesOrderSvcLevel.viewReturnQC()
            Close()
        ElseIf id_pop_up = "5" Then
            Dim check_stt As Boolean = False
            For c As Integer = 0 To ((FormSalesOrderSvcLevel.GVFGTrf.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVFGTrf))
                Dim rs As String = FormSalesOrderSvcLevel.GVFGTrf.GetRowCellValue(c, "id_report_status").ToString
                If rs = "5" Or rs = "6" Then
                    check_stt = True
                    Exit For
                End If
            Next

            If check_stt Then
                stopCustom("Can't update status because data is already locked.")
                FormSalesOrderSvcLevel.GVFGTrf.ActiveFilterString = ""
                Close()
            Else
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to finalize status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Cursor = Cursors.WaitCursor
                    For i As Integer = 0 To ((FormSalesOrderSvcLevel.GVFGTrf.RowCount - 1) - GetGroupRowCount(FormSalesOrderSvcLevel.GVFGTrf))
                        Dim stt As ClassFGTrf = New ClassFGTrf()
                        stt.changeStatus(FormSalesOrderSvcLevel.GVFGTrf.GetRowCellValue(i, "id_fg_trf").ToString, SLEStatusRec.EditValue.ToString)
                        PBC.PerformStep()
                        PBC.Update()
                    Next
                    Cursor = Cursors.Default
                End If
            End If
            FormSalesOrderSvcLevel.GVFGTrf.ActiveFilterString = ""
            FormSalesOrderSvcLevel.viewTrf()
            Close()
        End If
    End Sub

    Private Sub FormChangeStatus_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class