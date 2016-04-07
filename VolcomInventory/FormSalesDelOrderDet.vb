Public Class FormSalesDelOrderDet 
    Public action As String
    Public id_pl_sales_order_del As String = "-1"
    Public id_sales_order As String = "-1"
    Public id_store_contact_to As String = "-1"
    Public id_comp_contact_from As String = "-1"
    Public id_report_status As String
    Public id_pl_sales_order_del_det_list As New List(Of String)
    Public id_pl_sales_order_del_det_counting_list As New List(Of String)
    Public id_pl_sales_order_del_det_drawer_list As New List(Of String)
    Dim id_season_default As String
    Dim id_delivery_default As String
    Public id_comp_user As String = "-1"
    Public dt As New DataTable
    Public id_pre As String = "-1"
    'Dim is_scan As Boolean = False


    'var check qty
    Public cond_check As Boolean = True
    Public sample_check As String
    Public qty_pl As Decimal
    Public allow_sum As Decimal

    Private Sub FormSalesDelOrderDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewReportStatus()
        viewSoType()
        viewSoStatus()
        actionLoad()
        WindowState = FormWindowState.Maximized
    End Sub

    Sub actionLoad()
        Try
            'initiation datatable jika blm ada
            dt.Columns.Add("id_product")
            dt.Columns.Add("id_pl_prod_order_rec_det_unique")
            dt.Columns.Add("product_code")
            dt.Columns.Add("product_counting_code")
            dt.Columns.Add("product_full_code")
            dt.Columns.Add("is_old_design")
        Catch ex As Exception

        End Try

        If action = "ins" Then
            XTPOutboundScanNew.PageEnabled = False
            'TxtSalesDelOrderNumber.Text = header_number_sales("3")
            BtnPrint.Enabled = False
            BMark.Enabled = False
            BtnAttachment.Enabled = False
            DDBPrint.Enabled = False
            DEForm.Text = view_date(0)
            check_but()
            check_but_drawer()

            'from waiting menu
            If id_sales_order <> "-1" Then
                viewSalesOrder()
            End If

        ElseIf action = "upd" Then
            GroupControlListItem.Enabled = True
            GroupControlDrawerDetail.Enabled = True
            GroupControlScannedItem.Enabled = True
            GVItemList.OptionsBehavior.AutoExpandAllGroups = True
            BtnBrowseSO.Enabled = False
            BtnInfoSrs.Enabled = True
            XTPOutboundScanNew.PageEnabled = True
            BMark.Enabled = True
            DDBPrint.Enabled = True

            'query view based on edit id's
            Dim query As String = "SELECT b.id_so_status, b.id_sales_order, a.id_store_contact_to, a.id_comp_contact_from, (d.comp_name) AS store_name_to, (d1.comp_name) AS comp_name_from, (d.comp_number) AS store_number_to, (d1.comp_number) AS comp_number_from, (d.address_primary) AS store_address_to, a.id_report_status, f.report_status, "
            query += "a.pl_sales_order_del_note, a.pl_sales_order_del_date, a.pl_sales_order_del_number, b.sales_order_number, "
            query += "DATE_FORMAT(a.pl_sales_order_del_date,'%Y-%m-%d') AS pl_sales_order_del_datex, b.id_so_type "
            query += "FROM tb_pl_sales_order_del a "
            query += "INNER JOIN tb_sales_order b ON a.id_sales_order = b.id_sales_order "
            query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_to "
            query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
            query += "INNER JOIN tb_m_comp_contact c1 ON c1.id_comp_contact = a.id_comp_contact_from "
            query += "INNER JOIN tb_m_comp d1 ON c1.id_comp = d1.id_comp "
            query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
            query += "INNER JOIN tb_lookup_so_type g ON g.id_so_type = b.id_so_type "
            query += "INNER JOIN tb_lookup_so_status h ON h.id_so_status = b.id_so_status "
            query += "WHERE a.id_pl_sales_order_del = '" + id_pl_sales_order_del + "' "
            Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
            id_report_status = data.Rows(0)("id_report_status").ToString
            id_store_contact_to = data.Rows(0)("id_store_contact_to").ToString
            id_comp_contact_from = data.Rows(0)("id_comp_contact_from").ToString
            TxtSalesOrder.Text = data.Rows(0)("sales_order_number").ToString
            TxtNameCompFrom.Text = data.Rows(0)("comp_name_from").ToString
            TxtCodeCompFrom.Text = data.Rows(0)("comp_number_from").ToString
            TxtNameCompTo.Text = data.Rows(0)("store_name_to").ToString
            TxtCodeCompTo.Text = data.Rows(0)("store_number_to").ToString
            MEAdrressCompTo.Text = data.Rows(0)("store_address_to").ToString
            DEForm.Text = view_date_from(data.Rows(0)("pl_sales_order_del_datex").ToString, 0)
            TxtSalesDelOrderNumber.Text = data.Rows(0)("pl_sales_order_del_number").ToString
            MENote.Text = data.Rows(0)("pl_sales_order_del_note").ToString
            LEReportStatus.ItemIndex = LEReportStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)
            LETypeSO.ItemIndex = LETypeSO.Properties.GetDataSourceRowIndex("id_so_type", data.Rows(0)("id_so_type").ToString)
            LEStatusSO.ItemIndex = LEStatusSO.Properties.GetDataSourceRowIndex("id_so_status", data.Rows(0)("id_so_status").ToString)
            id_sales_order = data.Rows(0)("id_sales_order").ToString

            'detail2
            viewDetail()
            view_barcode_list()
            viewDetailDrawer()
            check_but()
            check_but_drawer()
            allow_status()

            If id_pre = "1" Then
                prePrinting()
                Close()
            ElseIf id_pre = "2" Then
                printing()
                Close()
            End If
        End If
    End Sub
    Sub viewSalesOrder()
        Dim query As String = "SELECT a.id_so_type, a.id_so_status, a.id_sales_order, a.id_store_contact_to, (d.comp_name) AS store_name_to,a.id_report_status, f.report_status, "
        query += "a.sales_order_note,a.sales_order_date, a.sales_order_note, a.sales_order_number, "
        query += "DATE_FORMAT(a.sales_order_date,'%d %M %Y') AS sales_order_date, (SELECT COUNT(id_pl_sales_order_del) FROM tb_pl_sales_order_del WHERE tb_pl_sales_order_del.id_sales_order = a.id_sales_order) AS pl_created, "
        query += "a.id_warehouse_contact_to, (wh.comp_number) AS `wh_number`, (wh.comp_name) AS `wh_name` "
        query += "FROM tb_sales_order a "
        query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_to "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
        query += "INNER JOIN tb_m_comp_contact wh_cont ON wh_cont.id_comp_contact = a.id_warehouse_contact_to "
        query += "INNER JOIN tb_m_comp wh ON wh.id_comp = wh_cont.id_comp "
        query += "WHERE a.id_sales_order = '" + id_sales_order + "' "
        query += "ORDER BY a.id_sales_order DESC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        'SO
        TxtSalesOrder.Text = data.Rows(0)("sales_order_number").ToString

        'store data
        Dim query_comp_to As String = "SELECT id_comp FROM tb_m_comp_contact WHERE id_comp_contact = '" + data.Rows(0)("id_store_contact_to").ToString + "'"
        Dim id_comp_to As String = execute_query(query_comp_to, 0, True, "", "", "", "")
        id_store_contact_to = data.Rows(0)("id_store_contact_to").ToString
        TxtCodeCompTo.Text = get_company_x(id_comp_to, 2)
        TxtNameCompTo.Text = get_company_x(id_comp_to, 1)
        MEAdrressCompTo.Text = get_company_x(id_comp_to, 3)

        'wh
        id_comp_contact_from = data.Rows(0)("id_warehouse_contact_to").ToString
        TxtCodeCompFrom.Text = data.Rows(0)("wh_number").ToString
        TxtNameCompFrom.Text = data.Rows(0)("wh_name").ToString

        'tipe & status SO
        LETypeSO.ItemIndex = LETypeSO.Properties.GetDataSourceRowIndex("id_so_type", data.Rows(0)("id_so_type").ToString)
        LEStatusSO.ItemIndex = LEStatusSO.Properties.GetDataSourceRowIndex("id_so_status", data.Rows(0)("id_so_status").ToString)

        'general
        viewDetail()
        viewDetailDrawer()
        view_barcode_list()
        setDefaultDrawer()
        GroupControlListItem.Enabled = True
        GroupControlScannedItem.Enabled = True
        BtnInfoSrs.Enabled = True
        check_but()
        GVItemList.OptionsBehavior.AutoExpandAllGroups = True
        BtnBrowseSO.Enabled = False
        GroupControlDrawerDetail.Enabled = True
    End Sub

    Sub viewSoType()
        Dim query As String = "SELECT * FROM tb_lookup_so_type a ORDER BY a.id_so_type "
        viewLookupQuery(LETypeSO, query, 0, "so_type", "id_so_type")
    End Sub

    Sub viewSoStatus()
        Dim query As String = "SELECT * FROM tb_lookup_so_status a ORDER BY a.id_so_status "
        viewLookupQuery(LEStatusSO, query, 0, "so_status", "id_so_status")
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status a ORDER BY a.id_report_status "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        viewLookupQuery(LEReportStatus, query, 0, "report_status", "id_report_status")
    End Sub

    Sub viewDetail()
        If action = "ins" Then
            'action
            Dim query As String = "CALL view_sales_order_limit('" + id_sales_order + "', '0', '0')"
            Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
            Dim id_product_param As String = ""
            For i As Integer = 0 To (data.Rows.Count - 1)
                id_product_param += data.Rows(i)("id_product").ToString
                If i < (data.Rows.Count - 1) Then
                    id_product_param += ";"
                End If
            Next
            GCItemList.DataSource = data
            codeAvailableIns(id_product_param)
        ElseIf action = "upd" Then
            id_pl_sales_order_del_det_list.Clear()
            Dim query As String = "CALL view_pl_sales_order_del('" + id_pl_sales_order_del + "')"
            Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
            Dim id_product_param As String = ""
            For i As Integer = 0 To (data.Rows.Count - 1)
                id_pl_sales_order_del_det_list.Add(data.Rows(i)("id_pl_sales_order_del_det").ToString)
                id_product_param += data.Rows(i)("id_product").ToString
                If i < (data.Rows.Count - 1) Then
                    id_product_param += ";"
                End If
            Next
            GCItemList.DataSource = data
            codeAvailableIns(id_product_param)
        End If
    End Sub

    Sub view_barcode_list()
        If action = "ins" Then
            Dim query As String = "SELECT ('0') AS no, ('') AS code, ('0') AS id_pl_sales_order_del_det, ('0') AS id_pl_prod_order_rec_det_unique, ('0') AS id_product,('1') AS is_fix, ('') AS counting_code, ('0') AS id_pl_sales_order_del_det_counting "
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            GCBarcode.DataSource = data
            deleteRowsBc()
            allowDelete()
        ElseIf action = "upd" Then
            id_pl_sales_order_del_det_counting_list.Clear()
            Dim query As String = ""
            query += "SELECT ('') AS no, CONCAT(c.product_full_code, a.pl_sales_order_del_det_counting) AS code, "
            query += "(a.pl_sales_order_del_det_counting) AS counting_code, "
            query += "a.id_pl_sales_order_del_det_counting, ('2') AS is_fix, "
            query += "a.id_pl_prod_order_rec_det_unique, b.id_product "
            query += "FROM tb_pl_sales_order_del_det_counting a "
            query += "INNER JOIN tb_pl_sales_order_del_det b ON a.id_pl_sales_order_del_det = b.id_pl_sales_order_del_det "
            query += "INNER JOIN tb_m_product c ON c.id_product = b.id_product "
            query += "WHERE b.id_pl_sales_order_del = '" + id_pl_sales_order_del + "' AND a.id_counting_type='1' "
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            For i As Integer = 0 To (data.Rows.Count - 1)
                id_pl_sales_order_del_det_counting_list.Add(data.Rows(i)("id_pl_sales_order_del_det_counting").ToString)
            Next
            GCBarcode.DataSource = data
        End If
    End Sub

    Sub setDefaultDrawer()
        'get drw def
        Dim id_wh_par As String = get_company_contact_x(id_comp_contact_from, "3")
        Dim query As String = ""
        query += "SELECT wh.id_comp, wh.comp_number, loc.id_wh_locator, loc.wh_locator_code, rck.id_wh_rack, rck.wh_rack_code, drw.id_wh_drawer, drw.wh_drawer_code "
        query += "FROM tb_m_comp wh "
        query += "INNER JOIN tb_m_wh_drawer drw ON drw.id_wh_drawer = wh.id_drawer_def "
        query += "INNER JOIN tb_m_wh_rack rck ON rck.id_wh_rack = drw.id_wh_rack "
        query += "INNER JOIN tb_m_wh_locator loc ON loc.id_wh_locator = rck.id_wh_locator "
        query += "WHERE wh.id_comp='" + id_wh_par + "' "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        If data.Rows.Count > 0 Then
            Dim id_loc_def As String = data.Rows(0)("id_wh_locator").ToString
            Dim id_rck_def As String = data.Rows(0)("id_wh_rack").ToString
            Dim id_drw_def As String = data.Rows(0)("id_wh_drawer").ToString
            Dim wh As String = data.Rows(0)("comp_number").ToString
            Dim locator As String = data.Rows(0)("wh_locator_code").ToString
            Dim rack As String = data.Rows(0)("wh_rack_code").ToString
            Dim drawer As String = data.Rows(0)("wh_drawer_code").ToString
            Dim bom_unit_price As Decimal = 0
            Dim qty_all_product As Decimal = 0
            Dim total_cost As Decimal = 0

            'get stock
            Dim query_stc As String = "CALL view_stock_fg('" + id_wh_par + "','" + id_loc_def + "','" + id_rck_def + "','" + id_drw_def + "', '0','4', '9999-01-01') "
            Dim data_stc As DataTable = execute_query(query_stc, -1, True, "", "", "", "")
            
           
            For j As Integer = 0 To ((GVItemList.RowCount - 1) - GetGroupRowCount(GVItemList))
                Dim data_stc_filter As DataRow() = data_stc.Select("[id_product]='" + GVItemList.GetRowCellValue(j, "id_product").ToString + "' ")
                Dim id_product As String = GVItemList.GetRowCellValue(j, "id_product").ToString
                Dim code As String = GVItemList.GetRowCellValue(j, "code").ToString
                Dim name As String = GVItemList.GetRowCellValue(j, "name").ToString
                Dim size As String = GVItemList.GetRowCellValue(j, "size").ToString
                Dim qty_limit As Decimal = GVItemList.GetRowCellValue(j, "sales_order_det_qty_limit")
                Dim id_pl_sales_order_del_det_drawer As String = "0"
                Dim fill_status As Boolean = False

                If data_stc_filter.Length > 0 Then
                    Dim qty_avail As Decimal = data_stc_filter(0)("qty_all_product")
                    If qty_limit > 0 Then
                        If qty_avail = 0 Then
                            qty_all_product = 0
                            bom_unit_price = 0
                            total_cost = 0
                            fill_status = False
                        ElseIf qty_avail >= qty_limit Then
                            qty_all_product = qty_limit
                            bom_unit_price = data_stc_filter(0)("bom_unit_price")
                            total_cost = qty_all_product * bom_unit_price
                            fill_status = True
                        Else
                            qty_all_product = qty_avail
                            bom_unit_price = data_stc_filter(0)("bom_unit_price")
                            total_cost = qty_all_product * bom_unit_price
                            fill_status = True
                        End If
                    Else
                        qty_all_product = 0
                        bom_unit_price = 0
                        total_cost = 0
                        fill_status = False
                    End If
                Else
                    bom_unit_price = 0
                    qty_all_product = 0
                    total_cost = 0
                    fill_status = False
                End If

                If fill_status Then
                    Dim newRow As DataRow = (TryCast(GCDrawer.DataSource, DataTable)).NewRow()
                    newRow("id_pl_sales_order_del_det_drawer") = id_pl_sales_order_del_det_drawer
                    newRow("id_comp") = id_wh_par
                    newRow("id_wh_locator") = id_loc_def
                    newRow("id_wh_rack") = id_rck_def
                    newRow("id_wh_drawer") = id_drw_def
                    newRow("wh") = wh
                    newRow("locator") = locator
                    newRow("rack") = rack
                    newRow("drawer") = drawer
                    newRow("bom_unit_price") = bom_unit_price
                    newRow("id_product") = id_product
                    newRow("qty_all_product") = qty_all_product
                    newRow("total_cost") = total_cost
                    newRow("code") = code
                    newRow("name") = name
                    newRow("size") = size
                    TryCast(GCDrawer.DataSource, DataTable).Rows.Add(newRow)
                    GCDrawer.RefreshDataSource()
                    GVDrawer.RefreshData()
                    countQtyFromWh(id_product)
                    check_but_drawer()
                End If
            Next
        End If
    End Sub

    Sub viewDetailDrawer()
        id_pl_sales_order_del_det_drawer_list.Clear()
        Dim query As String = "CALL view_pl_sales_order_del_drw('" + id_pl_sales_order_del + "')"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To (data.Rows.Count - 1)
            id_pl_sales_order_del_det_drawer_list.Add(data.Rows(i)("id_pl_sales_order_del_det_drawer").ToString)
        Next
        GCDrawer.DataSource = data
    End Sub

    Sub codeAvailableIns(ByVal id_product_param As String)
        'unique
        dt.Clear()
        Dim query As String = "CALL view_stock_fg_unique_del('" + id_product_param + "') "
        Dim datax As DataTable = execute_query(query, -1, True, "", "", "", "")
        dt = datax
        'For k As Integer = 0 To (datax.Rows.Count - 1)
        '    Dim R As DataRow = dt.NewRow
        '    R("id_product") = datax.Rows(k)("id_product").ToString
        '    R("id_pl_prod_order_rec_det_unique") = datax.Rows(k)("id_pl_prod_order_rec_det_unique").ToString
        '    R("product_code") = datax.Rows(k)("product_code").ToString
        '    R("product_counting_code") = datax.Rows(k)("product_counting_code").ToString
        '    R("product_full_code") = datax.Rows(k)("product_full_code").ToString
        '    R("is_old_design") = datax.Rows(k)("is_old_design").ToString
        '    dt.Rows.Add(R)
        'Next

        'not unique 
        Dim query_c As ClassDesign = New ClassDesign()
        Dim query_not As String = query_c.queryOldDesignCode(id_product_param)
        Dim data_not As DataTable = execute_query(query_not, -1, True, "", "", "", "")

        'merge
        If data_not.Rows.Count > 0 Then
            If dt.Rows.Count = 0 Then
                dt = data_not
            Else
                dt.Merge(data_not)
            End If
        End If
    End Sub

    Sub codeAvailableDel(ByVal id_product_param As String)
        Dim i As Integer = dt.Rows.Count - 1
        While (i >= 0)
            If dt.Rows(i)("id_product").ToString = id_product_param Then
                dt.Rows.RemoveAt(i)
            End If
            i = i - 1
        End While
    End Sub

    'sub check_but
    Sub check_but()
        Dim id_productx As String = "0"
        Try
            id_productx = GVItemList.GetFocusedRowCellValue("id_product").ToString
        Catch ex As Exception
        End Try

        'Constraint Status
        If GVItemList.RowCount > 0 And id_productx <> "0" Then
            BtnEdit.Enabled = True
            BtnDel.Enabled = True
            'BtnAddDrawer.Enabled = True
            'BtnEditDrawer.Enabled = True
            'BtnDelDrawer.Enabled = True
        Else
            BtnEdit.Enabled = False
            BtnDel.Enabled = False
            'BtnAddDrawer.Enabled = False
            'BtnEditDrawer.Enabled = False
            'BtnDelDrawer.Enabled = False
        End If
    End Sub

    Sub check_but_drawer()
        Dim id_wh_drawer_ As String = "0"
        Try
            id_wh_drawer_ = GVDrawer.GetFocusedRowCellValue("id_wh_drawer").ToString
        Catch ex As Exception
        End Try

        If GVDrawer.RowCount > 0 And id_wh_drawer_ <> "0" Then
            BtnEditDrawer.Enabled = True
            BtnDelDrawer.Enabled = True
        Else
            BtnEditDrawer.Enabled = False
            BtnDelDrawer.Enabled = False
        End If
    End Sub

    Sub allow_status()
        If check_edit_report_status(id_report_status, "43", id_pl_sales_order_del) Then
            PanelControlNav.Enabled = True
            PanelControlNavDetail.Enabled = True
            PanelNavBarcode.Enabled = True
            MENote.Properties.ReadOnly = False
            BtnSave.Enabled = True
            GVItemList.OptionsCustomization.AllowQuickHideColumns = False
            GVItemList.OptionsCustomization.AllowGroup = False
        Else
            PanelControlNav.Enabled = False
            PanelControlNavDetail.Enabled = False
            PanelNavBarcode.Enabled = False
            MENote.Properties.ReadOnly = True
            BtnSave.Enabled = False
            GVItemList.OptionsCustomization.AllowQuickHideColumns = True
            GVItemList.Columns("sales_order_det_qty_limit").Visible = False
            GVItemList.Columns("qty_from_wh").Visible = False
            GVItemList.OptionsCustomization.AllowGroup = True
        End If

        'attachment
        If check_attach_report_status(id_report_status, "43", id_pl_sales_order_del) Then
            BtnAttachment.Enabled = True
        Else
            BtnAttachment.Enabled = False
        End If

        'pre print
        If check_pre_print_report_status(id_report_status) Then
            BtnPrePrinting.Enabled = True
        Else
            BtnPrePrinting.Enabled = False
        End If

        'print
        If check_print_report_status(id_report_status) Then
            BtnPrint.Enabled = True
        Else
            BtnPrint.Enabled = False
        End If
        TxtSalesDelOrderNumber.Focus()
    End Sub

    'DeleteRows
    Sub deleteRowsBc()
        GVBarcode.DeleteRow(GVBarcode.FocusedRowHandle)
    End Sub

    'Focus Column Code
    Sub focusColumnCodeBc()
        GVBarcode.FocusedColumn = GVBarcode.VisibleColumns(0)
        GVBarcode.ShowEditor()
    End Sub
    'New Row
    Sub newRowsBc()
        GVBarcode.AddNewRow()
        GCBarcode.RefreshDataSource()
        GVBarcode.RefreshData()
        GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
    End Sub

    Private Sub GVBarcode_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        'MsgBox(GVBarcode.GetFocusedRowCellValue("code").ToString)
        'GVBarcode.AddNewRow()
        'MsgBox("k")
    End Sub

    Private Sub GVBarcode_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Sub allowDelete()
        If GVBarcode.RowCount <= 0 Then
            BDelete.Enabled = False
        Else
            BDelete.Enabled = True
        End If
    End Sub

    Sub noEdit()
        Try
            Dim is_fix As String = GVBarcode.GetFocusedRowCellDisplayText("is_fix")
            'MsgBox(id_pl_prod_order_rec_det)
            If is_fix <> "2" Then
                GridColumnBarcode.OptionsColumn.AllowEdit = True
            Else
                GridColumnBarcode.OptionsColumn.AllowEdit = False
            End If
            'MsgBox(id_pl_prod_order_rec_det)
        Catch ex As Exception
            'errorCustom(ex.ToString)
        End Try
    End Sub

    Sub countQty(ByVal id_product_param As String)
        GVBarcode.ActiveFilterString = "[id_product]='" + id_product_param + "' "
        Dim tot As Integer = GVBarcode.RowCount
        GVBarcode.ActiveFilterString = ""

        GVItemList.FocusedRowHandle = find_row(GVItemList, "id_product", id_product_param)
        Dim price As Decimal = Decimal.Parse(GVItemList.GetFocusedRowCellValue("design_price").ToString)
        GVItemList.SetFocusedRowCellValue("pl_sales_order_del_det_amount", tot * price)
        GVItemList.SetFocusedRowCellValue("pl_sales_order_del_det_qty", tot)
    End Sub

    Private Sub BtnBrowseSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowseSO.Click
        FormPopUpSalesOrder.id_pop_up = "1"
        FormPopUpSalesOrder.ShowDialog()
    End Sub

    Private Sub BtnBrowseContactFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor = Cursors.WaitCursor
        FormPopUpContact.id_pop_up = "39"
        FormPopUpContact.id_departement = id_departement_user
        FormPopUpContact.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        FormPopUpSalesOrder.id_pop_up = "2"
        FormPopUpSalesOrder.id_sales_order = id_sales_order
        FormPopUpSalesOrder.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim id_sales_order_det As String = "0"
        Dim qty_from_wh As Decimal = 0.0
        Dim id_pl_sales_order_del_det = "-1"
        Try
            'id_sales_order_det = GVItemList.GetFocusedRowCellValue("id_sales_order_det").ToString
            id_sales_order_det = GVItemList.GetRowCellValue(GVItemList.FocusedRowHandle, "id_sales_order_det")
            qty_from_wh = Decimal.Parse(GVItemList.GetFocusedRowCellValue("qty_from_wh"))
            id_pl_sales_order_del_det = GVItemList.GetFocusedRowCellValue("id_pl_sales_order_del_det").ToString
        Catch ex As Exception

        End Try

        If action = "ins" Then
            If qty_from_wh = 0.0 Then
                'MsgBox(id_sales_order_det)
                FormPopUpSalesOrder.id_pop_up = "2"
                FormPopUpSalesOrder.id_sales_order = id_sales_order
                FormPopUpSalesOrder.id_sales_order_det = id_sales_order_det
                FormPopUpSalesOrder.indeks_edit = GVItemList.FocusedRowHandle()
                FormPopUpSalesOrder.ShowDialog()
            Else
                errorCustom("This data already locked and can't edit.")
            End If
        ElseIf action = "upd" Then
            If id_pl_sales_order_del_det = "0" Then
                If qty_from_wh = 0.0 Then
                    'MsgBox(id_sales_order_det)
                    FormPopUpSalesOrder.id_pop_up = "2"
                    FormPopUpSalesOrder.id_sales_order = id_sales_order
                    FormPopUpSalesOrder.id_sales_order_det = id_sales_order_det
                    FormPopUpSalesOrder.indeks_edit = GVItemList.FocusedRowHandle()
                    FormPopUpSalesOrder.ShowDialog()
                Else
                    errorCustom("This data already locked and can't edit.")
                End If
            Else
                errorCustom("This data already locked and can't edit.")
            End If
        End If
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Cursor = Cursors.WaitCursor
        Dim id_sales_order_det As String = "0"
        Dim qty_from_wh As Decimal = 0.0
        Dim id_product As String = "0"
        Dim id_pl_sales_order_del_det = "-1"
        Try
            id_sales_order_det = GVItemList.GetFocusedRowCellValue("id_sales_order_det").ToString
            qty_from_wh = Decimal.Parse(GVItemList.GetFocusedRowCellValue("qty_from_wh"))
            id_product = GVItemList.GetFocusedRowCellValue("id_product").ToString
            id_pl_sales_order_del_det = GVItemList.GetFocusedRowCellValue("id_pl_sales_order_del_det").ToString
        Catch ex As Exception

        End Try

        If action = "ins" Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = Windows.Forms.DialogResult.Yes Then
                GVItemList.DeleteRow(GVItemList.FocusedRowHandle)
                GCItemList.RefreshDataSource()
                GVItemList.RefreshData()
                codeAvailableDel(id_product)
                deleteDetailBC(id_product)
                allowScanPage()
                check_but()
            End If
        ElseIf action = "upd" Then
            If id_pl_sales_order_del_det = "0" Then
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    GVItemList.DeleteRow(GVItemList.FocusedRowHandle)
                    GCItemList.RefreshDataSource()
                    GVItemList.RefreshData()
                    codeAvailableDel(id_product)
                    deleteDetailBC(id_product)
                    allowScanPage()
                    check_but()
                End If
            Else
                errorCustom("This data already locked and can't delete.")
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub GVItemList_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVItemList.FocusedRowChanged
        check_but()
        AddHandler GVDrawer.RowCellStyle, AddressOf my_color_cell
        GCDrawer.RefreshDataSource()
        GVDrawer.RefreshData()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If action = "ins" Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to cancel ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = Windows.Forms.DialogResult.Yes Then
                Close()
            End If
        Else
            Close()
        End If
    End Sub

    Private Sub FormSalesDelOrderDet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Cursor = Cursors.WaitCursor
        makeSafeGV(GVItemList)
        makeSafeGV(GVDrawer)
        makeSafeGV(GVBarcode)
        ValidateChildren()

        'cek kesamaan from wh dengan scan
        Dim is_same_qty As Boolean = True
        For i As Integer = 0 To (GVItemList.RowCount - 1)
            Try
                Dim qty_from_wh As Decimal = Decimal.Parse(GVItemList.GetRowCellValue(i, "qty_from_wh"))
                Dim qty_del As Decimal = Decimal.Parse(GVItemList.GetRowCellValue(i, "pl_sales_order_del_det_qty"))
                If qty_from_wh <> qty_del Then
                    is_same_qty = False
                    Exit For
                End If
            Catch ex As Exception
            End Try
        Next

        'cek qty limit SO di DB
        For i As Integer = 0 To GVBarcode.RowCount - 1
            Try
                Dim id_sales_order_det_cekya As String = GVItemList.GetRowCellValue(i, "id_sales_order_det").ToString
                Dim qty_plya As String = GVItemList.GetRowCellValue(i, "pl_sales_order_del_det_qty").ToString
                Dim sample_checkya As String = GVItemList.GetRowCellValue(i, "name").ToString
                isAllowRequisition(sample_checkya, id_sales_order_det_cekya, qty_plya)
                If Not cond_check Then
                    Exit For
                End If
            Catch ex As Exception
            End Try
        Next

        'cek qty limit rack
        Dim available_stock As Boolean = True
        Dim warning_stock As String = ""
        For ix As Integer = 0 To GVDrawer.RowCount - 1
            Try
                Dim id_pl_sales_order_del_det_drawer As String = GVDrawer.GetRowCellValue(ix, "id_pl_sales_order_del_det_drawer").ToString
                If id_pl_sales_order_del_det_drawer = "0" Then
                    Dim qty_all_product As Decimal = GVDrawer.GetRowCellValue(ix, "qty_all_product").ToString
                    Dim id_wh_drawer As String = GVDrawer.GetRowCellValue(ix, "id_wh_drawer").ToString
                    Dim drawer As String = GVDrawer.GetRowCellValue(ix, "drawer").ToString
                    Dim id_wh_rack As String = GVDrawer.GetRowCellValue(ix, "id_wh_rack").ToString
                    Dim id_wh_locator As String = GVDrawer.GetRowCellValue(ix, "id_wh_locator").ToString
                    Dim id_comp As String = GVDrawer.GetRowCellValue(ix, "id_comp").ToString
                    Dim id_product As String = GVDrawer.GetRowCellValue(ix, "id_product").ToString
                    Dim query_cek_stok As String = "CALL view_stock_fg('" + id_comp + "','" + id_wh_locator + "','" + id_wh_rack + "','" + id_wh_drawer + "', '" + id_product + "','4', '9999-01-01')"
                    Dim data_cek_stok As DataTable = execute_query(query_cek_stok, -1, True, "", "", "", "")
                    If qty_all_product > data_cek_stok.Rows(0)("qty_all_product") Then
                        available_stock = False
                        warning_stock = "Out item in " + drawer + " cannot exceed " + data_cek_stok.Rows(0)("qty_all_product") + ""
                        Exit For
                    End If
                End If
            Catch ex As Exception

            End Try
        Next

        If Not formIsValidInPanel(EPForm, PanelControlTopLeft) Or Not formIsValidInPanel(EPForm, PanelControlTopMiddle) Then
            errorInput()
        ElseIf GVItemList.RowCount = 0 Or GVDrawer.RowCount = 0 Or GVBarcode.RowCount = 0 Then
            errorCustom("Delivery item, drawer detail, and scanned item data can't blank")
        ElseIf Not is_same_qty Then
            errorCustom("Qty from wh not equal to qty delivery, please check your input !")
        ElseIf Not cond_check Then
            errorCustom("- Product : '" + sample_check + "' cannot exceed " + allow_sum.ToString("F2") + ", please check in Info Qty !")
            infoQty()
        ElseIf Not available_stock Then
            errorCustom(warning_stock)
        Else
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Stock qty will be updated after this process. Are you sure to continue this process?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = Windows.Forms.DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                Dim pl_sales_order_del_note As String = MENote.Text.ToString
                If action = "ins" Then
                    'query main table
                    Dim pl_sales_order_del_number As String = header_number_sales("3")
                    Dim query_main As String = "INSERT tb_pl_sales_order_del(id_sales_order, pl_sales_order_del_number, id_comp_contact_from, id_store_contact_to, pl_sales_order_del_date, pl_sales_order_del_note, id_report_status, last_update, last_update_by) "
                    query_main += "VALUES('" + id_sales_order + "', '" + pl_sales_order_del_number + "', '" + id_comp_contact_from + "', '" + id_store_contact_to + "', NOW(), '" + pl_sales_order_del_note + "', '1', NOW(), " + id_user + "); SELECT LAST_INSERT_ID(); "
                    id_pl_sales_order_del = execute_query(query_main, 0, True, "", "", "", "")
                    increase_inc_sales("3")

                    'insert who prepared
                    insert_who_prepared("43", id_pl_sales_order_del, id_user)

                    'Detail return
                    Dim jum_ins_j As Integer = 0
                    Dim query_detail As String = ""
                    If GVItemList.RowCount > 0 Then
                        query_detail = "INSERT tb_pl_sales_order_del_det(id_pl_sales_order_del, id_sales_order_det, id_product, id_design_price, design_price, pl_sales_order_del_det_qty, pl_sales_order_del_det_note) VALUES "
                    End If
                    For j As Integer = 0 To ((GVItemList.RowCount - 1) - GetGroupRowCount(GVItemList))
                        Try
                            Dim id_sales_order_det As String = GVItemList.GetRowCellValue(j, "id_sales_order_det").ToString
                            Dim id_product As String = GVItemList.GetRowCellValue(j, "id_product").ToString
                            Dim id_design_price As String = GVItemList.GetRowCellValue(j, "id_design_price").ToString
                            Dim design_price As String = decimalSQL(GVItemList.GetRowCellValue(j, "design_price").ToString)
                            Dim pl_sales_order_del_det_qty As String = decimalSQL(GVItemList.GetRowCellValue(j, "pl_sales_order_del_det_qty").ToString)
                            Dim pl_sales_order_del_det_note As String = GVItemList.GetRowCellValue(j, "pl_sales_order_del_det_note").ToString

                            If jum_ins_j > 0 Then
                                query_detail += ", "
                            End If
                            query_detail += "('" + id_pl_sales_order_del + "', '" + id_sales_order_det + "', '" + id_product + "', '" + id_design_price + "', '" + design_price + "', '" + pl_sales_order_del_det_qty + "', '" + pl_sales_order_del_det_note + "') "
                            jum_ins_j = jum_ins_j + 1
                        Catch ex As Exception
                        End Try
                    Next
                    If GVItemList.RowCount > 0 Then
                        execute_non_query(query_detail, True, "", "", "", "")
                    End If

                    'get all detail id
                    Dim query_get_detail_id As String = "SELECT a.id_pl_sales_order_del_det, a.id_product "
                    query_get_detail_id += "FROM tb_pl_sales_order_del_det a "
                    query_get_detail_id += "WHERE a.id_pl_sales_order_del = '" + id_pl_sales_order_del + "' "
                    Dim data_get_detail_id As DataTable = execute_query(query_get_detail_id, -1, True, "", "", "", "")

                    'drawer
                    Dim jum_ins_s As Integer = 0
                    Dim query_drawer As String = ""
                    Dim query_drawer_stock As String = ""
                    If GVDrawer.RowCount > 0 Then
                        query_drawer = "INSERT INTO tb_pl_sales_order_del_det_drawer(id_pl_sales_order_del_det, id_wh_drawer, bom_unit_price, pl_sales_order_del_det_drawer_qty) VALUES "
                        query_drawer_stock = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
                    End If
                    For s As Integer = 0 To ((GVDrawer.RowCount - 1) - GetGroupRowCount(GVDrawer))
                        Dim id_product_drawer As String = GVDrawer.GetRowCellValue(s, "id_product")
                        Dim id_wh_drawer As String = GVDrawer.GetRowCellValue(s, "id_wh_drawer")
                        Dim bom_unit_price As String = decimalSQL(GVDrawer.GetRowCellValue(s, "bom_unit_price").ToString)
                        Dim pl_sales_order_del_det_drawer_qty As String = decimalSQL(GVDrawer.GetRowCellValue(s, "qty_all_product").ToString)
                        Dim id_pl_sales_order_del_det_drawer As String = ""
                        For s1 As Integer = 0 To (data_get_detail_id.Rows.Count - 1)
                            If id_product_drawer = data_get_detail_id.Rows(s1)("id_product").ToString Then
                                If jum_ins_s > 0 Then
                                    query_drawer += ", "
                                    query_drawer_stock += ", "
                                End If
                                query_drawer += "('" + data_get_detail_id.Rows(s1)("id_pl_sales_order_del_det").ToString + "', '" + id_wh_drawer + "', '" + bom_unit_price + "', '" + pl_sales_order_del_det_drawer_qty + "') "
                                query_drawer_stock += "('" + id_wh_drawer + "', '2', '" + id_product_drawer + "', '" + pl_sales_order_del_det_drawer_qty + "', NOW(), 'Delivery Order No: " + pl_sales_order_del_number + "', '" + bom_unit_price + "', '43', '" + id_pl_sales_order_del + "', '2') "
                                jum_ins_s = jum_ins_s + 1
                                Exit For
                            End If
                        Next
                    Next
                    If GVDrawer.RowCount > 0 Then
                        execute_non_query(query_drawer, True, "", "", "", "")
                    End If

                    'counting
                    Dim jum_ins_p As Integer = 0
                    Dim query_counting As String = ""
                    If GVBarcode.RowCount > 0 Then
                        query_counting = "INSERT INTO tb_pl_sales_order_del_det_counting(id_pl_sales_order_del_det, id_pl_prod_order_rec_det_unique, pl_sales_order_del_det_counting) VALUES "
                    End If
                    For p As Integer = 0 To (GVBarcode.RowCount - 1)
                        Dim id_product_counting As String = GVBarcode.GetRowCellValue(p, "id_product")
                        Dim id_pl_prod_order_rec_det_unique As String = GVBarcode.GetRowCellValue(p, "id_pl_prod_order_rec_det_unique").ToString
                        If id_pl_prod_order_rec_det_unique = "0" Then
                            id_pl_prod_order_rec_det_unique = "NULL "
                        End If
                        Dim pl_sales_order_del_det_counting As String = GVBarcode.GetRowCellValue(p, "counting_code").ToString
                        For p1 As Integer = 0 To (data_get_detail_id.Rows.Count - 1)
                            If id_product_counting = data_get_detail_id.Rows(p1)("id_product").ToString Then
                                If jum_ins_p > 0 Then
                                    query_counting += ", "
                                End If
                                query_counting += "('" + data_get_detail_id.Rows(p1)("id_pl_sales_order_del_det").ToString + "', " + id_pl_prod_order_rec_det_unique + ", '" + pl_sales_order_del_det_counting + "') "
                                jum_ins_p = jum_ins_p + 1
                                Exit For
                            End If
                        Next
                    Next
                    If GVBarcode.RowCount > 0 Then
                        execute_non_query(query_counting, True, "", "", "", "")
                    End If

                    'insert stock
                    If jum_ins_s > 0 Then
                        execute_non_query(query_drawer_stock, True, "", "", "", "")
                    End If

                    FormSalesDelOrder.viewSalesDelOrder()
                    FormSalesDelOrder.GVSalesDelOrder.FocusedRowHandle = find_row(FormSalesDelOrder.GVSalesDelOrder, "id_pl_sales_order_del", id_pl_sales_order_del)
                    action = "upd"
                    actionLoad()
                    infoCustom("Delivery Order : " + pl_sales_order_del_number + " was created successfully.")
                ElseIf action = "upd" Then
                    'update main table
                    Dim pl_sales_order_del_number As String = TxtSalesDelOrderNumber.Text
                    Dim query_main As String = "UPDATE tb_pl_sales_order_del SET pl_sales_order_del_number = '" + pl_sales_order_del_number + "', id_comp_contact_from = '" + id_comp_contact_from + "', id_store_contact_to = '" + id_store_contact_to + "', pl_sales_order_del_note = '" + pl_sales_order_del_note + "' last_update=NOW(), last_update_by=" + id_user + " WHERE id_pl_sales_order_del = '" + id_pl_sales_order_del + "'"
                    execute_non_query(query_main, True, "", "", "", "")

                    'update detail table
                    Dim jum_ins_j As Integer = 0
                    Dim query_detail As String = ""
                    If GVItemList.RowCount > 0 Then
                        query_detail = "INSERT tb_pl_sales_order_del_det(id_pl_sales_order_del, id_sales_order_det, id_product, id_design_price, design_price, pl_sales_order_del_det_qty, pl_sales_order_del_det_note) "
                    End If
                    For j As Integer = 0 To ((GVItemList.RowCount - 1) - GetGroupRowCount(GVItemList))
                        Try
                            Dim id_pl_sales_order_del_det As String = GVItemList.GetRowCellValue(j, "id_pl_sales_order_del_det").ToString
                            Dim id_sales_order_det As String = GVItemList.GetRowCellValue(j, "id_sales_order_det").ToString
                            Dim id_product As String = GVItemList.GetRowCellValue(j, "id_product").ToString
                            Dim id_design_price As String = GVItemList.GetRowCellValue(j, "id_design_price").ToString
                            Dim design_price As String = decimalSQL(GVItemList.GetRowCellValue(j, "design_price").ToString)
                            Dim pl_sales_order_del_det_qty As String = decimalSQL(GVItemList.GetRowCellValue(j, "pl_sales_order_del_det_qty").ToString)
                            Dim pl_sales_order_del_det_note As String = GVItemList.GetRowCellValue(j, "pl_sales_order_del_det_note").ToString

                            If id_pl_sales_order_del_det = "0" Then
                                If jum_ins_j > 0 Then
                                    query_detail += ", "
                                End If
                                query_detail += "VALUES('" + id_pl_sales_order_del + "', '" + id_sales_order_det + "', '" + id_product + "', '" + id_design_price + "', '" + design_price + "', '" + pl_sales_order_del_det_qty + "', '" + pl_sales_order_del_det_note + "') "
                                jum_ins_j = jum_ins_j + 1
                            Else
                                Dim query_detail_upd As String = "UPDATE tb_pl_sales_order_del_det SET id_product = '" + id_product + "', id_design_price = '" + id_design_price + "', design_price='" + design_price + "', pl_sales_order_del_det_qty = '" + pl_sales_order_del_det_qty + "', pl_sales_order_del_det_note = '" + pl_sales_order_del_det_note + "' WHERE id_pl_sales_order_del_det = '" + id_pl_sales_order_del_det + "'"
                                execute_non_query(query_detail_upd, True, "", "", "", "")
                                id_pl_sales_order_del_det_list.Remove(id_pl_sales_order_del_det)
                            End If
                        Catch ex As Exception
                            'MsgBox(ex.ToString)
                        End Try
                    Next
                    If GVItemList.RowCount > 0 And jum_ins_j > 0 Then
                        execute_non_query(query_detail, True, "", "", "", "")
                    End If

                    For j_del As Integer = 0 To (id_pl_sales_order_del_det_list.Count - 1)
                        Try
                            Dim query_detail_del As String = "DELETE FROM tb_pl_sales_order_del_det WHERE id_pl_sales_order_del_det = '" + id_pl_sales_order_del_det_list(j_del) + "'"
                            execute_non_query(query_detail_del, True, "", "", "", "")
                        Catch ex As Exception

                        End Try
                    Next

                    'get all detail id
                    Dim query_get_detail_id As String = "SELECT a.id_pl_sales_order_del_det, a.id_product "
                    query_get_detail_id += "FROM tb_pl_sales_order_del_det a "
                    query_get_detail_id += "WHERE a.id_pl_sales_order_del = '" + id_pl_sales_order_del + "' "
                    Dim data_get_detail_id As DataTable = execute_query(query_get_detail_id, -1, True, "", "", "", "")

                    'update drawer
                    Dim jum_ins_s As Integer = 0
                    Dim query_drawer As String = ""
                    Dim query_drawer_stock As String = ""
                    If GVDrawer.RowCount > 0 Then
                        query_drawer = "INSERT INTO tb_pl_sales_order_del_det_drawer(id_pl_sales_order_del_det, id_wh_drawer, bom_unit_price, pl_sales_order_del_det_drawer_qty) VALUES "
                        query_drawer_stock = "INSERT tb_storage_fg(id_wh_drawer, id_storage_category, id_product, storage_product_qty, storage_product_datetime, storage_product_notes, bom_unit_price, report_mark_type, id_report, id_stock_status) VALUES "
                    End If
                    For s As Integer = 0 To ((GVDrawer.RowCount - 1) - GetGroupRowCount(GVDrawer))
                        Dim id_pl_sales_order_del_det_drawer As String = GVDrawer.GetRowCellValue(s, "id_pl_sales_order_del_det_drawer")
                        Dim id_product_drawer As String = GVDrawer.GetRowCellValue(s, "id_product")
                        Dim id_wh_drawer As String = GVDrawer.GetRowCellValue(s, "id_wh_drawer")
                        Dim bom_unit_price As String = decimalSQL(GVDrawer.GetRowCellValue(s, "bom_unit_price").ToString)
                        Dim pl_sales_order_del_det_drawer_qty As String = decimalSQL(GVDrawer.GetRowCellValue(s, "qty_all_product").ToString)
                        For s1 As Integer = 0 To (data_get_detail_id.Rows.Count - 1)
                            If id_pl_sales_order_del_det_drawer = "0" Then
                                If id_product_drawer = data_get_detail_id.Rows(s1)("id_product").ToString Then
                                    If jum_ins_s > 0 Then
                                        query_drawer += ", "
                                        query_drawer_stock += ", "
                                    End If
                                    query_drawer += "('" + data_get_detail_id.Rows(s1)("id_pl_sales_order_del_det").ToString + "', '" + id_wh_drawer + "', '" + bom_unit_price + "', '" + pl_sales_order_del_det_drawer_qty + "') "
                                    query_drawer_stock += "('" + id_wh_drawer + "', '2', '" + id_product_drawer + "', '" + pl_sales_order_del_det_drawer_qty + "', NOW(), 'Delivery Order No: " + pl_sales_order_del_number + "', '" + bom_unit_price + "', '43', '" + id_pl_sales_order_del + "', '2') "
                                    jum_ins_s = jum_ins_s + 1
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                    If GVDrawer.RowCount > 0 And jum_ins_s > 0 Then
                        execute_non_query(query_drawer, True, "", "", "", "")
                    End If

                    'update counting
                    Dim jum_ins_p As Integer = 0
                    Dim query_counting As String = ""
                    If GVBarcode.RowCount > 0 Then
                        query_counting = "INSERT INTO tb_pl_sales_order_del_det_counting(id_pl_sales_order_del_det, id_pl_prod_order_rec_det_unique, pl_sales_order_del_det_counting) VALUES "
                    End If
                    For p As Integer = 0 To (GVBarcode.RowCount - 1)
                        Dim id_pl_sales_order_del_det_counting As String = GVBarcode.GetRowCellValue(p, "id_pl_sales_order_del_det_counting").ToString
                        Dim id_product_counting As String = GVBarcode.GetRowCellValue(p, "id_product")
                        Dim id_pl_prod_order_rec_det_unique As String = GVBarcode.GetRowCellValue(p, "id_pl_prod_order_rec_det_unique").ToString
                        If id_pl_prod_order_rec_det_unique = "0" Then
                            id_pl_prod_order_rec_det_unique = "NULL "
                        End If
                        Dim pl_sales_order_del_det_counting As String = GVBarcode.GetRowCellValue(p, "counting_code").ToString
                        For p1 As Integer = 0 To (data_get_detail_id.Rows.Count - 1)
                            If id_pl_sales_order_del_det_counting = "0" Then
                                If id_product_counting = data_get_detail_id.Rows(p1)("id_product").ToString Then
                                    If jum_ins_p > 0 Then
                                        query_counting += ", "
                                    End If
                                    query_counting += "('" + data_get_detail_id.Rows(p1)("id_pl_sales_order_del_det").ToString + "', " + id_pl_prod_order_rec_det_unique + ", '" + pl_sales_order_del_det_counting + "') "
                                    jum_ins_p = jum_ins_p + 1
                                    Exit For
                                End If
                            End If
                        Next
                    Next
                    If GVBarcode.RowCount > 0 And jum_ins_p > 0 Then
                        execute_non_query(query_counting, True, "", "", "", "")
                    End If

                    'insert stock
                    If jum_ins_s > 0 Then
                        execute_non_query(query_drawer_stock, True, "", "", "", "")
                    End If

                    FormSalesDelOrder.viewSalesDelOrder()
                    FormSalesDelOrder.GVSalesDelOrder.FocusedRowHandle = find_row(FormSalesDelOrder.GVSalesDelOrder, "id_pl_sales_order_del", id_pl_sales_order_del)
                    action = "upd"
                    actionLoad()
                    infoCustom("Delivery Order : " + pl_sales_order_del_number + " was edited successfully.")
                End If
                Cursor = Cursors.Default
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMark.Click
        Cursor = Cursors.WaitCursor
        FormReportMark.id_report = id_pl_sales_order_del
        FormReportMark.report_mark_type = "43"
        FormReportMark.form_origin = Name
        FormReportMark.is_view = "1"
        FormReportMark.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub TxtSalesOrder_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtSalesOrder.Validating
        EP_TE_cant_blank(EPForm, TxtSalesOrder)
        EPForm.SetIconPadding(TxtSalesOrder, 58)
    End Sub

    Private Sub TxtNameCompFrom_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNameCompFrom.Validating
        EP_TE_cant_blank(EPForm, TxtNameCompFrom)
        ' EPForm.SetIconPadding(TxtNameCompFrom, 30)
    End Sub

    Private Sub TxtNameCompTo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNameCompTo.Validating
        EP_TE_cant_blank(EPForm, TxtNameCompTo)
        EPForm.SetIconPadding(TxtNameCompTo, 1)
    End Sub


    Private Sub BtnAddDrawer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDrawer.Click
        Cursor = Cursors.WaitCursor
        Dim id_product As String = "-1"
        Try
            id_product = GVItemList.GetFocusedRowCellValue("id_product").ToString
        Catch ex As Exception
        End Try
        FormSalesDelOrderSingle.id_comp = get_company_contact_x(id_comp_contact_from, "3")
        FormSalesDelOrderSingle.id_product = "0"
        FormSalesDelOrderSingle.action_pop = "ins"
        FormSalesDelOrderSingle.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnEditDrawer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditDrawer.Click
        Cursor = Cursors.WaitCursor
        Dim id_product As String = "-1"
        Dim id_pl_sales_order_del_det_drawer As String = "-1"
        Dim id_wh_drawer As String = "-1"
        Dim qty_edit As Decimal = 0.0
        Try
            id_product = GVItemList.GetFocusedRowCellValue("id_product").ToString
            id_pl_sales_order_del_det_drawer = GVDrawer.GetFocusedRowCellValue("id_pl_sales_order_del_det_drawer").ToString
            id_wh_drawer = GVDrawer.GetFocusedRowCellValue("id_wh_drawer").ToString
            qty_edit = GVDrawer.GetFocusedRowCellValue("pl_sales_order_del_det_drawer_qty")
        Catch ex As Exception
        End Try

        If action = "ins" Then
            FormSalesDelOrderSingle.indeks_edit = GVDrawer.FocusedRowHandle
            FormSalesDelOrderSingle.id_product = "0"
            FormSalesDelOrderSingle.action_pop = "upd"
            FormSalesDelOrderSingle.id_comp = get_company_contact_x(id_comp_contact_from, "3")
            FormSalesDelOrderSingle.ShowDialog()
        ElseIf action = "upd" Then
            If id_pl_sales_order_del_det_drawer = "0" Then
                FormSalesDelOrderSingle.indeks_edit = GVDrawer.FocusedRowHandle
                FormSalesDelOrderSingle.id_product = "0"
                FormSalesDelOrderSingle.action_pop = "upd"
                FormSalesDelOrderSingle.id_comp = get_company_contact_x(id_comp_contact_from, "3")
                FormSalesDelOrderSingle.ShowDialog()
            Else
                errorCustom("This data already locked and can't edit.")
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnDelDrawer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelDrawer.Click
        Cursor = Cursors.WaitCursor
        Dim id_pl_sales_order_del_det_drawer As String = "-1"
        Try
            id_pl_sales_order_del_det_drawer = GVDrawer.GetFocusedRowCellValue("id_pl_sales_order_del_det_drawer").ToString
        Catch ex As Exception
        End Try

        Dim id_product_sel As String = "-1"
        Try
            id_product_sel = GVDrawer.GetFocusedRowCellValue("id_product").ToString
        Catch ex As Exception
        End Try

        GVItemList.ActiveFilterString = "[id_product]='" + id_product_sel + "' "
        GVItemList.FocusedRowHandle = 0
        Dim qty_sel As Integer = GVItemList.GetFocusedRowCellValue("pl_sales_order_del_det_qty")
        If qty_sel <= 0 Then
            makeSafeGV(GVItemList)
            If action = "ins" Then
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this drawer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Dim id_productx As String = GVDrawer.GetFocusedRowCellValue("id_product").ToString
                    GVDrawer.DeleteRow(GVDrawer.FocusedRowHandle)
                    GCDrawer.RefreshDataSource()
                    GVDrawer.RefreshData()
                    countQtyFromWh(id_productx)
                    check_but_drawer()
                End If
            ElseIf action = "upd" Then
                If id_pl_sales_order_del_det_drawer = "0" Then
                    Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this drawer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    If confirm = Windows.Forms.DialogResult.Yes Then
                        Dim id_productx As String = GVDrawer.GetFocusedRowCellValue("id_product").ToString
                        GVDrawer.DeleteRow(GVDrawer.FocusedRowHandle)
                        GCDrawer.RefreshDataSource()
                        GVDrawer.RefreshData()
                        countQtyFromWh(id_productx)
                        check_but_drawer()
                    End If
                Else
                    'cek uda ada product yg di scan ato blm
                    errorCustom("This data already locked and can't delete.")
                End If
            End If
        Else
            makeSafeGV(GVItemList)
            stopCustom("Drawer can not be removed because the product is already in the process of scanning. ")
        End If

        Cursor = Cursors.Default
    End Sub

    Sub countQtyFromWh(ByVal id_product_param As String)
        Dim jum As Decimal = 0.0
        For i As Integer = 0 To (GVDrawer.RowCount - 1)
            Try
                Dim id_product_i As String = GVDrawer.GetRowCellValue(i, "id_product").ToString
                If id_product_i = id_product_param Then
                    jum = jum + Decimal.Parse(GVDrawer.GetRowCellValue(i, "qty_all_product"))
                End If
            Catch ex As Exception

            End Try
        Next
        GVItemList.FocusedRowHandle = find_row(GVItemList, "id_product", id_product_param)
        GVItemList.SetFocusedRowCellValue("qty_from_wh", jum)
        allowScanPage()

    End Sub

    Sub allowScanPage()
        makeSafeGV(GVItemList)

        GVItemList.ActiveFilterString = "[qty_from_wh]>0"
        If GVItemList.RowCount > 0 Then
            XTPOutboundScanNew.PageEnabled = True
        Else
            XTPOutboundScanNew.PageEnabled = False
        End If
        GVItemList.ActiveFilterString = ""
    End Sub

    Private Sub BScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BScan.Click
        'is_scan = True
        MENote.Enabled = False
        If action = "ins" Then
            BtnBrowseSO.Enabled = False
        End If
        BtnSave.Enabled = False
        BScan.Enabled = False
        BStop.Enabled = True
        BDelete.Enabled = False
        BtnCancel.Enabled = False
        ControlBox = False
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnDel.Enabled = False
        BtnAddDrawer.Enabled = False
        BtnEditDrawer.Enabled = False
        BtnDelDrawer.Enabled = False
        BtnInfoSrs.Enabled = False
        newRowsBc()
        'allowDelete()
    End Sub

    Private Sub BStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BStop.Click
        'is_scan = False
        For i As Integer = 0 To (GVBarcode.RowCount - 1)
            Dim check_code As String = ""
            Try
                check_code = GVBarcode.GetRowCellValue(i, "code").ToString()
            Catch ex As Exception

            End Try
            If check_code = "" Or check_code = Nothing Or IsDBNull(check_code) Then
                GVBarcode.DeleteRow(i)
            End If
        Next

        MENote.Enabled = True
        If action = "ins" Then
            BtnBrowseSO.Enabled = True
        End If
        BtnSave.Enabled = True
        BScan.Enabled = True
        BStop.Enabled = False
        BtnCancel.Enabled = True
        allowDelete()
        ControlBox = True
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        BtnDel.Enabled = True
        BtnAddDrawer.Enabled = True
        BtnEditDrawer.Enabled = True
        BtnDelDrawer.Enabled = True
        BtnInfoSrs.Enabled = True
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        Dim id_pl_sales_order_del_det_counting As String = "-1"
        Try
            id_pl_sales_order_del_det_counting = GVBarcode.GetFocusedRowCellValue("id_pl_sales_order_del_det_counting").ToString
        Catch ex As Exception
        End Try

        If action = "ins" Then
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = Windows.Forms.DialogResult.Yes Then
                Dim id_product As String = GVBarcode.GetFocusedRowCellValue("id_product").ToString
                deleteRowsBc()
                If id_product <> "" Or id_product <> Nothing Then
                    GVBarcode.ApplyFindFilter("")
                    countQty(id_product)
                End If
                GCItemList.RefreshDataSource()
                GVItemList.RefreshData()
                allowDelete()
            End If
        ElseIf action = "upd" Then
            If id_pl_sales_order_del_det_counting = "0" Then
                Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If confirm = Windows.Forms.DialogResult.Yes Then
                    Dim id_product As String = GVBarcode.GetFocusedRowCellValue("id_product").ToString
                    deleteRowsBc()
                    If id_product <> "" Or id_product <> Nothing Then
                        GVBarcode.ApplyFindFilter("")
                        countQty(id_product)
                    End If
                    GCItemList.RefreshDataSource()
                    GVItemList.RefreshData()
                    allowDelete()
                End If
            Else
                errorCustom("This data already locked and can't delete.")
            End If
        End If
    End Sub

    Private Sub GVBarcode_CustomColumnDisplayText_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVBarcode.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVBarcode_FocusedColumnChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GVBarcode.FocusedColumnChanged
        If Not GVBarcode.FocusedColumn.FieldName = "code" Then
            GVBarcode.FocusedColumn = GVBarcode.Columns("code")
        End If
    End Sub

    Private Sub GVBarcode_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVBarcode.FocusedRowChanged
        noEdit()
    End Sub

    Private Sub GVItemList_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVItemList.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVBarcode_HiddenEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVBarcode.HiddenEditor
        Dim code_check As String = GVBarcode.GetFocusedRowCellValue("code").ToString
        Dim code_found As Boolean = False
        Dim code_duplicate As Boolean = False
        Dim counting_code As String = ""
        Dim id_pl_prod_order_rec_det_unique As String = "0"
        Dim id_product As String = ""
        Dim jum_scan As Integer = 0
        Dim jum_limit As Integer = 0
        Dim is_old As String = "0"

        'check available code
        Dim dt_filter As DataRow() = dt.Select("[product_full_code]='" + code_check + "' ")
        If dt_filter.Length > 0 Then
            counting_code = dt_filter(0)("product_counting_code").ToString
            id_pl_prod_order_rec_det_unique = dt_filter(0)("id_pl_prod_order_rec_det_unique").ToString
            id_product = dt_filter(0)("id_product").ToString
            is_old = dt_filter(0)("is_old_design").ToString
            code_found = True
        End If

        'get jum del & limit
        GVItemList.ActiveFilterString = "[id_product]='" + id_product + "' "
        GVItemList.FocusedRowHandle = 0
        Try
            jum_limit = GVItemList.GetFocusedRowCellValue("qty_from_wh")
        Catch ex As Exception
        End Try
        Try
            jum_scan = GVItemList.GetFocusedRowCellValue("pl_sales_order_del_det_qty")
        Catch ex As Exception
        End Try
        makeSafeGV(GVItemList)

        If is_old = "1" Then 'no unique
            If jum_limit <= 0 Then
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                stopCustom("Nothing item was prepared for this product. Please make sure all of product have stocks in selected drawer. ")
            ElseIf jum_scan >= jum_limit Then
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                stopCustom("'Scanned Qty' more than 'Qty from WH'")
            Else
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_pl_prod_order_rec_det_unique", id_pl_prod_order_rec_det_unique)
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_pl_sales_order_del_det_counting", "0")
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "is_fix", "2")
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "counting_code", counting_code)
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_product", id_product)
                countQty(id_product)
                newRowsBc()
                GCItemList.RefreshDataSource()
                GVItemList.RefreshData()
            End If
        ElseIf is_old = "2" 'unique code
            'check duplicate code
            GVBarcode.ActiveFilterString = "[code]='" + code_check + "' AND [is_fix]='2' "
            If GVBarcode.RowCount > 0 Then
                code_duplicate = True
            End If
            GVBarcode.ActiveFilterString = ""

            If Not code_found Then
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                stopCustom("Data not found or duplicate!")
            ElseIf code_duplicate Then
                GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                stopCustom("Data duplicate !")
            Else
                If jum_limit <= 0 Then
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                    GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                    stopCustom("Nothing item was prepared for this product. Please make sure all of product have stocks in selected drawer. ")
                ElseIf jum_scan >= jum_limit Then
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
                    GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
                    stopCustom("'Scanned Qty' more than 'Qty from WH'")
                Else
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_pl_prod_order_rec_det_unique", id_pl_prod_order_rec_det_unique)
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_pl_sales_order_del_det_counting", "0")
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "is_fix", "2")
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "counting_code", counting_code)
                    GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "id_product", id_product)
                    countQty(id_product)
                    newRowsBc()
                    GCItemList.RefreshDataSource()
                    GVItemList.RefreshData()
                End If
            End If
        Else 'not found
            GVBarcode.SetRowCellValue(GVBarcode.RowCount - 1, "code", "")
            GVBarcode.FocusedRowHandle = GVBarcode.RowCount - 1
            stopCustom("Data not found !")
        End If
    End Sub

    Sub deleteDetailBC(ByVal id_product_param As String)
        'delete detail
        Dim i As Integer = GVBarcode.RowCount - 1
        While (i >= 0)
            Dim id_product As String = ""
            Try
                id_product = GVBarcode.GetRowCellValue(i, "id_product").ToString()
            Catch ex As Exception

            End Try
            If id_product = id_product_param Then
                GVBarcode.DeleteRow(i)
            End If
            i = i - 1
        End While
    End Sub

    Private Sub BtnInfoSrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfoSrs.Click
        infoQty()
    End Sub

    Sub infoQty()
        If action = "ins" Then
            FormInfoSalesOrder.id_pop_up = "1"
            FormInfoSalesOrder.id_sales_order = id_sales_order
            FormInfoSalesOrder.id_sales_order_det = "0"
            FormInfoSalesOrder.ShowDialog()
        ElseIf action = "upd" Then
            If check_edit_report_status(id_report_status, "43", id_pl_sales_order_del) Then
                FormInfoSalesOrder.id_pop_up = "1"
                FormInfoSalesOrder.id_pl_sales_order_del = id_pl_sales_order_del
                FormInfoSalesOrder.id_sales_order = id_sales_order
                FormInfoSalesOrder.id_sales_order_det = "0"
                FormInfoSalesOrder.ShowDialog()
            Else
                FormInfoSalesOrder.id_pop_up = "1"
                FormInfoSalesOrder.id_sales_order = id_sales_order
                FormInfoSalesOrder.id_sales_order_det = "0"
                FormInfoSalesOrder.ShowDialog()
            End If
        End If
    End Sub

    'check limit qty
    Sub isAllowRequisition(ByVal sample_name As String, ByVal id_sales_order_det_cek As String, ByVal qty_plx As String)
        cond_check = True
        qty_pl = Decimal.Parse(qty_plx.ToString)
        sample_check = sample_name

        Dim query_check As String = ""
        If action = "ins" Then
            query_check = "call view_sales_order_limit('" + id_sales_order + "', '" + id_sales_order_det_cek + "', '0') "
        ElseIf action = "upd" Then
            query_check = "call view_sales_order_limit('" + id_sales_order + "', '" + id_sales_order_det_cek + "', '" + id_pl_sales_order_del + "') "
        End If
        'cek based on SO limit
        'query_check += "SELECT c.id_sales_order, a.id_sales_order_det, a.id_product,a.sales_order_det_qty,(a.sales_order_det_qty - COALESCE(b.jum_del, 0)) AS qty_allow "
        'query_check += "FROM tb_sales_order_det a "
        'query_check += "LEFT JOIN "
        'query_check += "(SELECT b1.id_sales_order_det, SUM(b1.pl_sales_order_del_det_qty) AS jum_del FROM tb_pl_sales_order_del_det b1 "
        'query_check += "INNER JOIN tb_pl_sales_order_del b2 ON b1.id_pl_sales_order_del = b2.id_pl_sales_order_del "
        'query_check += "WHERE b2.id_report_status != '5' "
        'If action = "upd" Then
        'query_check += "AND b2.id_pl_sales_order_del != '" + id_pl_sales_order_del + "' "
        'End If
        'query_check += "GROUP BY b1.id_sales_order_det) b ON a.id_sales_order_det = b.id_sales_order_det "
        'query_check += "INNER JOIN tb_sales_order c ON a.id_sales_order = c.id_sales_order "
        'query_check += "WHERE c.id_sales_order = '" + id_sales_order + "' AND a.id_sales_order_det LIKE '" + id_sales_order_det_cek + "' "

        Dim data As DataTable = execute_query(query_check, -1, True, "", "", "", "")
        allow_sum = Decimal.Parse(data.Rows(0)("sales_order_det_qty_limit"))
        If qty_pl > allow_sum Then
            cond_check = False
        End If
    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        'View
        'FormViewSalesDelOrder.id_pl_sales_order_del = id_pl_sales_order_del
        'FormViewSalesDelOrder.ShowDialog()

        'Print
        ReportSalesDelOrderDet.id_pl_sales_order_del = id_pl_sales_order_del
        Dim Report As New ReportSalesDelOrderDet()
        ' Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreview()
    End Sub

    Sub getReport()
        ReportSalesDelOrderDet.dt = GCItemList.DataSource
        ReportSalesDelOrderDet.id_pl_sales_order_del = id_pl_sales_order_del
        Dim Report As New ReportSalesDelOrderDet()

        ' '... 
        ' ' creating and saving the view's layout to a new memory stream 
        Dim str As System.IO.Stream
        str = New System.IO.MemoryStream()
        GVItemList.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Report.GVItemList.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)

        'Grid Detail
        ReportStyleGridview(Report.GVItemList)

        'Parse val
        Report.LabelTo.Text = TxtCodeCompTo.Text + "-" + TxtNameCompTo.Text
        Report.LabelFrom.Text = TxtCodeCompFrom.Text + "-" + TxtNameCompFrom.Text
        Report.LabelAddress.Text = MEAdrressCompTo.Text
        Report.LRecDate.Text = DEForm.Text
        Report.LRecNumber.Text = TxtSalesDelOrderNumber.Text
        Report.LabelNote.Text = MENote.Text
        Report.LabelPrepare.Text = TxtSalesOrder.Text
        Report.LabelCat.Text = LEStatusSO.Text


        'Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreview()
    End Sub

    'Color Cell
    Public Sub my_color_cell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'MsgBox("HAH")
        'Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender

        'e.Appearance.BackColor = Color.White
        'e.Appearance.BackColor2 = Color.White

        'Try
        'Dim id_product_style As String = GVItemList.GetFocusedRowCellValue("id_product").ToString
        'Dim id_product_check As String = View.GetRowCellValue(e.RowHandle, View.Columns("id_product"))
        'If id_product_check = id_product_style Then
        'e.Appearance.BackColor = Color.Lavender
        'e.Appearance.BackColor2 = Color.White
        'End If
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub my_color_cell2(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender

        e.Appearance.BackColor = Color.White
        e.Appearance.BackColor2 = Color.White

        Try
            Dim id_product_style As String = GVItemList.GetFocusedRowCellValue("id_product").ToString
            Dim id_product_check As String = View.GetRowCellValue(e.RowHandle, View.Columns("id_product"))
            If id_product_check = id_product_style Then
                e.Appearance.BackColor = Color.White
                e.Appearance.BackColor2 = Color.White
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAttachment.Click
        Cursor = Cursors.WaitCursor
        FormDocumentUpload.id_report = id_pl_sales_order_del
        FormDocumentUpload.report_mark_type = "43"
        FormDocumentUpload.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrintDrawer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintDrawer.Click
        Cursor = Cursors.WaitCursor
        AddHandler GVDrawer.RowCellStyle, AddressOf my_color_cell2
        ReportStyleGridview(GVDrawer)
        print(GCDrawer, "Item List Based on Drawer - " + TxtSalesOrder.Text)
        'AddHandler GVDrawer.RowCellStyle, AddressOf my_color_cell
        Cursor = Cursors.Default
    End Sub

    Private Sub GVDrawer_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVDrawer.FocusedRowChanged
        check_but_drawer()
    End Sub

    Private Sub DDBPrint_Click(sender As Object, e As EventArgs) Handles DDBPrint.Click

    End Sub

    Private Sub BtnPrePrinting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrePrinting.ItemClick
        prePrinting()
    End Sub

    Sub prePrinting()
        Cursor = Cursors.WaitCursor
        ReportSalesDelOrderDet.id_pre = "1"
        getReport()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrint.ItemClick
        printing()
    End Sub

    Sub printing()
        Cursor = Cursors.WaitCursor
        ReportSalesDelOrderDet.id_pre = "-1"
        getReport()
        Cursor = Cursors.Default
    End Sub
End Class