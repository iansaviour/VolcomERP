Public Class ClassFGTrf
    Public Function queryMain(ByVal condition As String, ByVal order_type As String) As String
        Dim query As String = "CALL view_fg_trf_main('" + condition + "', '" + order_type + "') "
        Return query
    End Function

    Public Function queryDetail(ByVal id_report_param As String) As String
        Dim query As String = "CALL view_fg_trf('" + id_report_param + "')"
        Return query
    End Function

    Public Sub changeStatus(ByVal id_report_par As String, ByVal id_status_reportx_par As String)
        'rollback stock if cancelled and complerted
        If id_status_reportx_par = "5" Then
            Dim query_drawer As String = "SELECT c.fg_trf_number, b.id_product, a.id_wh_drawer, a.fg_trf_det_drawer_qty, a.bom_unit_price FROM tb_fg_trf_det_drawer a "
            query_drawer += "INNER JOIN tb_fg_trf_det b ON a.id_fg_trf_det = b.id_fg_trf_det "
            query_drawer += "INNER JOIN tb_fg_trf c ON c.id_fg_trf = b.id_fg_trf "
            query_drawer += "WHERE b.id_fg_trf = '" + id_report_par + "' "
            Dim data_drawer As DataTable = execute_query(query_drawer, -1, True, "", "", "", "")

            'prepare rollback stock
            Dim query_drawer_stock As String = ""
            Dim jum_ins_c As Integer = 0
            If data_drawer.Rows.Count > 0 Then
                query_drawer_stock = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
            End If
            For c As Integer = 0 To (data_drawer.Rows.Count - 1)
                If c > 0 Then
                    query_drawer_stock += ", "
                End If
                query_drawer_stock += "('" + data_drawer(c)("id_wh_drawer").ToString + "', '1', '" + data_drawer(c)("id_product").ToString + "', '" + decimalSQL(data_drawer(c)("fg_trf_det_drawer_qty").ToString) + "', NOW(), 'Finished Goods Transfer No: " + data_drawer(c)("fg_trf_number").ToString + ", has been canceled', '" + decimalSQL(data_drawer(c)("bom_unit_price").ToString) + "', '57', '" + id_report_par + "', '2') "
            Next

            'excequte rollback
            If data_drawer.Rows.Count > 0 Then
                execute_non_query(query_drawer_stock, True, "", "", "", "")
            End If
        ElseIf id_status_reportx_par = "6" Then
            Dim query_drawer As String = "SELECT c.fg_trf_number, b.id_product, a.id_wh_drawer, a.fg_trf_det_drawer_qty, a.bom_unit_price FROM tb_fg_trf_det_drawer a "
            query_drawer += "INNER JOIN tb_fg_trf_det b ON a.id_fg_trf_det = b.id_fg_trf_det "
            query_drawer += "INNER JOIN tb_fg_trf c ON c.id_fg_trf = b.id_fg_trf "
            query_drawer += "WHERE b.id_fg_trf = '" + id_report_par + "' "
            Dim data_drawer As DataTable = execute_query(query_drawer, -1, True, "", "", "", "")

            'prepare rollback stock
            Dim query_drawer_stock_reserved As String = ""
            Dim query_drawer_stock_preparedx As String = ""
            Dim jum_ins_c As Integer = 0
            If data_drawer.Rows.Count > 0 Then
                query_drawer_stock_reserved = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
                query_drawer_stock_preparedx = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
            End If
            For c As Integer = 0 To (data_drawer.Rows.Count - 1)
                If c > 0 Then
                    query_drawer_stock_reserved += ", "
                    query_drawer_stock_preparedx += ", "
                End If
                query_drawer_stock_reserved += "('" + data_drawer(c)("id_wh_drawer").ToString + "', '1', '" + data_drawer(c)("id_product").ToString + "', '" + decimalSQL(data_drawer(c)("fg_trf_det_drawer_qty").ToString) + "', NOW(), 'Transfer Completed and delete reserved stock, no : " + data_drawer(c)("fg_trf_number").ToString + "', '" + decimalSQL(data_drawer(c)("bom_unit_price").ToString) + "', '57', '" + id_report_par + "', '2') "
                query_drawer_stock_preparedx += "('" + data_drawer(c)("id_wh_drawer").ToString + "', '2', '" + data_drawer(c)("id_product").ToString + "', '" + decimalSQL(data_drawer(c)("fg_trf_det_drawer_qty").ToString) + "', NOW(), 'Transfer Completed, no : " + data_drawer(c)("fg_trf_number").ToString + "', '" + decimalSQL(data_drawer(c)("bom_unit_price").ToString) + "', '57', '" + id_report_par + "', '1') "
            Next

            'excequte
            If data_drawer.Rows.Count > 0 Then
                execute_non_query(query_drawer_stock_reserved, True, "", "", "", "")
                execute_non_query(query_drawer_stock_preparedx, True, "", "", "", "")
            End If

            'get drawer destination
            Dim query_drw_dest As String = "SELECT trf.fg_trf_number,trf.id_wh_drawer, det.id_product, det.fg_trf_det_qty, dsg.design_cop "
            query_drw_dest += "FROM tb_fg_trf trf "
            query_drw_dest += "INNER JOIN tb_fg_trf_det det ON det.id_fg_trf = trf.id_fg_trf "
            query_drw_dest += "INNER JOIN tb_m_product prd ON prd.id_product=det.id_product "
            query_drw_dest += "INNER JOIN tb_m_design dsg ON dsg.id_design = prd.id_design "
            query_drw_dest += "WHERE trf.id_fg_trf='" + id_report_par + "' "
            Dim data_drw_dest As DataTable = execute_query(query_drw_dest, -1, True, "", "", "", "")
            Dim query_drawer_stock_in As String = ""
            If data_drw_dest.Rows.Count > 0 Then
                query_drawer_stock_in = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
                For ms As Integer = 0 To data_drw_dest.Rows.Count - 1
                    If ms > 0 Then
                        query_drawer_stock_in += ", "
                    End If
                    query_drawer_stock_in += "('" + data_drw_dest.Rows(ms)("id_wh_drawer").ToString + "', '1', '" + data_drw_dest(ms)("id_product").ToString + "', '" + decimalSQL(data_drw_dest(ms)("fg_trf_det_qty").ToString) + "', NOW(), 'Transfer Completed, no : " + data_drw_dest(ms)("fg_trf_number").ToString + "', '" + decimalSQL(data_drw_dest(ms)("design_cop").ToString) + "', '57', '" + id_report_par + "', '1') "
                Next
                execute_non_query(query_drawer_stock_in, True, "", "", "", "")
            End If

            'set is valid unique
            Dim query_stt_unique As String = ""
            query_stt_unique += "UPDATE tb_fg_trf_det_counting fg_un "
            query_stt_unique += "INNER JOIN tb_fg_trf_det fg_det ON fg_un.id_fg_trf_det = fg_det.id_fg_trf_det "
            query_stt_unique += "SET fg_un.is_valid = '1' "
            query_stt_unique += "WHERE fg_det.id_fg_trf = '" + id_report_par + "' "
            execute_non_query(query_stt_unique, True, "", "", "", "")
        End If

        Dim query As String = String.Format("UPDATE tb_fg_trf SET id_report_status='{0}', id_report_status_rec = '" + id_status_reportx_par + "', last_update=NOW(), last_update_by=" + id_user + " WHERE id_fg_trf ='{1}'", id_status_reportx_par, id_report_par)
        execute_non_query(query, True, "", "", "", "")
    End Sub
End Class
