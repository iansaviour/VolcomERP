Public Class FormSalesOrderPacking 
    Public id_trans As String = "-1"
    Public id_cur_status As String = "-1"
    Public id_pop_up As String = "-1"

    Private Sub FormSalesOrderPacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM tb_lookup_prepare_status a "
        viewSearchLookupQuery(SLEPackingStatus, query, "id_prepare_status", "prepare_status", "id_prepare_status")
        SLEPackingStatus.EditValue = id_cur_status
    End Sub

    Private Sub FormSalesOrderPacking_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to update Packing Status?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = Windows.Forms.DialogResult.Yes Then
            If id_pop_up = "-1" Then
                Cursor = Cursors.WaitCursor
                Dim query_upd As String = "UPDATE tb_sales_order SET id_prepare_status='" + SLEPackingStatus.EditValue.ToString + "' WHERE id_sales_order='" + id_trans + "' "
                execute_non_query(query_upd, True, "", "", "", "")
                FormSalesOrderList.viewSalesOrder()
                Close()
                Cursor = Cursors.Default
            ElseIf id_pop_up = "1" Then
                Cursor = Cursors.WaitCursor
                Dim query_upd As String = "UPDATE tb_sales_order SET id_prepare_status='" + SLEPackingStatus.EditValue.ToString + "' WHERE id_sales_order='" + id_trans + "' "
                execute_non_query(query_upd, True, "", "", "", "")
                FormSalesOrderSvcLevel.viewSalesOrder()
                Close()
                Cursor = Cursors.Default
            ElseIf id_pop_up = "2" Then
                Cursor = Cursors.WaitCursor
                Dim query_upd As String = "UPDATE tb_sales_return_order SET id_prepare_status='" + SLEPackingStatus.EditValue.ToString + "' WHERE id_sales_return_order='" + id_trans + "' "
                execute_non_query(query_upd, True, "", "", "", "")
                FormSalesOrderSvcLevel.viewReturnOrder()
                Close()
                Cursor = Cursors.Default
            ElseIf id_pop_up = "3" Then
                Cursor = Cursors.WaitCursor
                Dim query_upd As String = "UPDATE tb_sales_return_order SET id_prepare_status='" + SLEPackingStatus.EditValue.ToString + "' WHERE id_sales_return_order='" + id_trans + "' "
                execute_non_query(query_upd, True, "", "", "", "")
                FormSalesOrderSvcLevel.viewReturnOrder()
                FormViewSalesReturnOrder.actionLoad()
                Close()
                Cursor = Cursors.Default
            End If
        End If
    End Sub
End Class