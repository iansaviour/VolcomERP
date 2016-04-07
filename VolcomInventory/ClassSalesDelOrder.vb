Public Class ClassSalesDelOrder
    Public Function queryMain(ByVal condition As String, ByVal order_type As String) As String
        If order_type = "1" Then
            order_type = "ASC "
        ElseIf order_type = "2" Then
            order_type = "DESC "
        End If

        If condition <> "-1" Then
            condition = condition
        Else
            condition = ""
        End If

        Dim query As String = "SELECT a.id_pl_sales_order_del, a.id_store_contact_to, (d.comp_name) AS store_name_to, id_comp_contact_from,a.id_report_status, f.report_status, "
        query += "a.pl_sales_order_del_note, a.pl_sales_order_del_date, a.pl_sales_order_del_number, b.sales_order_number, "
        query += "DATE_FORMAT(a.pl_sales_order_del_date,'%d %M %Y') AS pl_sales_order_del_date, (wh.id_comp) AS `id_wh`, (wh.comp_name) AS `wh_name`, cat.id_so_status, cat.so_status, "
        query += "a.last_update, getUserEmp(a.last_update_by, 1) AS `last_user`, ('No') AS `is_select` "
        query += "FROM tb_pl_sales_order_del a "
        query += "INNER JOIN tb_sales_order b ON a.id_sales_order = b.id_sales_order "
        query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_to "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
        query += "INNER JOIN tb_m_comp_contact wh_cont ON wh_cont.id_comp_contact = a.id_comp_contact_from "
        query += "INNER JOIN tb_m_comp wh ON wh.id_comp = wh_cont.id_comp "
        query += "INNER JOIN tb_lookup_so_status cat ON cat.id_so_status = b.id_so_status "
        query += "WHERE a.id_pl_sales_order_del>0 "
        query += condition + " "
        query += "ORDER BY a.id_pl_sales_order_del " + order_type
        Return query
    End Function
    Public Function queryMainInvoice(ByVal condition As String, ByVal order_type As String) As String
        If order_type = "1" Then
            order_type = "ASC "
        ElseIf order_type = "2" Then
            order_type = "DESC "
        End If

        If condition <> "-1" Then
            condition = condition
        Else
            condition = ""
        End If

        Dim query As String = "SELECT a.id_pl_sales_order_del, a.id_store_contact_to, (d.comp_name) AS store_name_to, id_comp_contact_from,a.id_report_status, f.report_status, "
        query += "a.pl_sales_order_del_note, a.pl_sales_order_del_date, a.pl_sales_order_del_number, b.sales_order_number, "
        query += "DATE_FORMAT(a.pl_sales_order_del_date,'%d %M %Y') AS pl_sales_order_del_date, (wh.id_comp) AS `id_wh`, (wh.comp_name) AS `wh_name`, cat.id_so_status, cat.so_status, "
        query += "a.last_update, getUserEmp(a.last_update_by, 1) AS `last_user`, ('No') AS `is_select` "
        query += "FROM tb_pl_sales_order_del a "
        query += "INNER JOIN tb_sales_order b ON a.id_sales_order = b.id_sales_order "
        query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_to "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
        query += "INNER JOIN tb_m_comp_contact wh_cont ON wh_cont.id_comp_contact = a.id_comp_contact_from "
        query += "INNER JOIN tb_m_comp wh ON wh.id_comp = wh_cont.id_comp "
        query += "LEFT JOIN tb_sales_pos sp ON sp.id_pl_sales_order_del=a.id_pl_sales_order_del "
        query += "INNER JOIN tb_lookup_so_status cat ON cat.id_so_status = b.id_so_status "
        query += "WHERE a.id_pl_sales_order_del>0 AND ISNULL(sp.id_sales_pos) "
        query += condition + " "
        query += "ORDER BY a.id_pl_sales_order_del " + order_type
        Return query
    End Function
    Public Sub changeStatus(ByVal id_report_par As String, ByVal id_status_reportx_par As String)
        'rollback stock if cancelled and complerted
        If id_status_reportx_par = "5" Then
            Dim query_drawer As String = "SELECT c.pl_sales_order_del_number, b.id_product, a.id_wh_drawer, a.pl_sales_order_del_det_drawer_qty, a.bom_unit_price FROM tb_pl_sales_order_del_det_drawer a "
            query_drawer += "INNER JOIN tb_pl_sales_order_del_det b ON a.id_pl_sales_order_del_det = b.id_pl_sales_order_del_det "
            query_drawer += "INNER JOIN tb_pl_sales_order_del c ON c.id_pl_sales_order_del = b.id_pl_sales_order_del "
            query_drawer += "WHERE b.id_pl_sales_order_del= '" + id_report_par + "' "
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
                query_drawer_stock += "('" + data_drawer(c)("id_wh_drawer").ToString + "', '1', '" + data_drawer(c)("id_product").ToString + "', '" + decimalSQL(data_drawer(c)("pl_sales_order_del_det_drawer_qty").ToString) + "', NOW(), 'Delivery Order No: " + data_drawer(c)("pl_sales_order_del_number").ToString + ", has been canceled', '" + decimalSQL(data_drawer(c)("bom_unit_price").ToString) + "', '43', '" + id_report_par + "', '2') "
            Next

            'excequte rollback
            If data_drawer.Rows.Count > 0 Then
                execute_non_query(query_drawer_stock, True, "", "", "", "")
            End If
        ElseIf id_status_reportx_par = "6" Then
            Dim query_drawer As String = "SELECT c.pl_sales_order_del_number, b.id_product, a.id_wh_drawer, getCompByContact(c.id_store_contact_to,4) AS id_wh_drawer_store, a.pl_sales_order_del_det_drawer_qty, a.bom_unit_price FROM tb_pl_sales_order_del_det_drawer a "
            query_drawer += "INNER JOIN tb_pl_sales_order_del_det b ON a.id_pl_sales_order_del_det = b.id_pl_sales_order_del_det "
            query_drawer += "INNER JOIN tb_pl_sales_order_del c ON c.id_pl_sales_order_del = b.id_pl_sales_order_del "
            query_drawer += "WHERE b.id_pl_sales_order_del= '" + id_report_par + "' "
            Dim data_drawer As DataTable = execute_query(query_drawer, -1, True, "", "", "", "")

            'prepare rollback stock
            Dim st_res As New ClassStock()
            Dim st_prep As New ClassStock()
            Dim st_store As New ClassStock()
            Dim jum_ins_c As Integer = 0

            For c As Integer = 0 To (data_drawer.Rows.Count - 1)
                st_res.prepInsStockFG(data_drawer(c)("id_wh_drawer").ToString, 1, data_drawer(c)("id_product").ToString, decimalSQL(data_drawer(c)("bom_unit_price").ToString), "43", id_report_par, decimalSQL(data_drawer(c)("pl_sales_order_del_det_drawer_qty").ToString), "", "2")
                st_prep.prepInsStockFG(data_drawer(c)("id_wh_drawer").ToString, 2, data_drawer(c)("id_product").ToString, decimalSQL(data_drawer(c)("bom_unit_price").ToString), "43", id_report_par, decimalSQL(data_drawer(c)("pl_sales_order_del_det_drawer_qty").ToString), "", "1")
                st_store.prepInsStockFG(data_drawer(c)("id_wh_drawer_store").ToString, 1, data_drawer(c)("id_product").ToString, decimalSQL(data_drawer(c)("bom_unit_price").ToString), "43", id_report_par, decimalSQL(data_drawer(c)("pl_sales_order_del_det_drawer_qty").ToString), "", "1")
            Next

            'excequte
            If data_drawer.Rows.Count > 0 Then
                st_res.insStockFG()
                st_prep.insStockFG()
                st_store.insStockFG()
            End If

            'post to virtual POS
            'If form_origin = "FormSalesDelOrderDet" Then
            '    'main
            '    Dim id_so_type As String = execute_query("SELECT b.id_so_type FROM tb_pl_sales_order_del a INNER JOIN tb_sales_order b ON a.id_sales_order = b.id_sales_order WHERE a.id_pl_sales_order_del = '" + id_report + "' ", 0, True, "", "", "", "")
            '    If id_so_type = "2" Then
            '        Dim query_pos As String = "INSERT INTO tb_sales_pos(id_store_contact_from, sales_pos_date, sales_pos_number, sales_pos_note, id_so_type, id_report_status) "
            '        query_pos += "VALUES ('" + FormSalesDelOrderDet.id_store_contact_to + "', NOW(), '" + header_number_sales("6") + "', '', '" + FormSalesDelOrderDet.LETypeSO.EditValue.ToString + "', '1') "
            '        execute_non_query(query_pos, True, "", "", "", "")

            '        'det
            '        Dim id_sales_posx As String = execute_query("SELECT LAST_INSERT_ID()", 0, True, "", "", "", "")

            '        increase_inc_sales("6")
            '        'insert who prepared
            '        insert_who_prepared("48", id_sales_posx, id_user)

            '        Dim jum_p As Integer = 0
            '        Dim query_pos_det As String = "INSERT INTO tb_sales_pos_det(id_sales_pos, id_product, id_design_price, design_price, sales_pos_det_qty) VALUES "
            '        For p As Integer = 0 To (FormSalesDelOrderDet.GVItemList.RowCount - 1)
            '            Try
            '                Dim id_productx As String = FormSalesDelOrderDet.GVItemList.GetRowCellValue(p, "id_product").ToString
            '                If jum_p > 0 Then
            '                    query_pos_det += ", "
            '                End If
            '                query_pos_det += "('" + id_sales_posx + "', '" + FormSalesDelOrderDet.GVItemList.GetRowCellValue(p, "id_product").ToString + "', '" + FormSalesDelOrderDet.GVItemList.GetRowCellValue(p, "id_design_price").ToString + "', '" + decimalSQL(FormSalesDelOrderDet.GVItemList.GetRowCellValue(p, "design_price").ToString) + "', '" + decimalSQL(FormSalesDelOrderDet.GVItemList.GetRowCellValue(p, "pl_sales_order_del_det_qty").ToString) + "') "
            '                jum_p = jum_p + 1
            '            Catch ex As Exception
            '            End Try
            '        Next

            '        'excecute
            '        If jum_p > 0 Then
            '            execute_non_query(query_pos_det, True, "", "", "", "")
            '        End If
            '    End If
            'End If
        End If
        Dim query As String = String.Format("UPDATE tb_pl_sales_order_del SET id_report_status='{0}', last_update=NOW(), last_update_by=" + id_user + " WHERE id_pl_sales_order_del ='{1}'", id_status_reportx_par, id_report_par)
        execute_non_query(query, True, "", "", "", "")
    End Sub
End Class
