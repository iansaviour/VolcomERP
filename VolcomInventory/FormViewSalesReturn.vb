﻿Public Class FormViewSalesReturn 
    Public action As String
    Public id_sales_return As String = "-1"
    Public id_sales_return_order As String = "-1"
    Public id_store_contact_from As String = "-1"
    Public id_store As String = "-1"
    Public id_comp_contact_to As String = "-1"
    Public id_report_status As String
    Public id_sales_return_det_list As New List(Of String)
    Public id_sales_return_det_counting_list As New List(Of String)
    Public id_sales_return_det_drawer_list As New List(Of String)
    Public id_sales_return_det_drawer_detail_list As New List(Of String)
    Public id_comp_user As String = "-1"
    Public dt As New DataTable
    Public id_comp_to As String = "-1"
    Public id_drawer As String = "-1"
    Public id_prepare_status As String = "-1"
    Public is_detail_soh As String = "-1"
    'Dim is_scan As Boolean = False

    'var check qty
    Public cond_check As Boolean = True
    Public sample_check As String
    Public qty_pl As Decimal
    Public allow_sum As Decimal

    Private Sub FormSalesReturnDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewReportStatus()
        actionLoad()
    End Sub

    Sub actionLoad()
        GroupControlListItem.Enabled = True
        GroupControlScannedItem.Enabled = True
        GVItemList.OptionsBehavior.AutoExpandAllGroups = True

        'query view based on edit id's
        Dim query As String = "SELECT a.id_wh_drawer,dw.wh_drawer_code,b.id_sales_return_order, a.id_store_contact_from, a.id_comp_contact_to, (d.comp_name) AS store_name_from, (d1.comp_name) AS comp_name_to, (d.comp_number) AS store_number_from, (d1.comp_number) AS comp_number_to, (d.address_primary) AS store_address_from, a.id_report_status, f.report_status, "
        query += "a.sales_return_note,a.sales_return_date, a.sales_return_number, sales_return_store_number,b.sales_return_order_number, "
        query += "DATE_FORMAT(a.sales_return_date,'%Y-%m-%d') AS sales_return_datex, (c.id_comp) AS id_store, (c1.id_comp) AS id_comp_to, b.id_prepare_status, prep_stt.prepare_status  "
        query += "FROM tb_sales_return a "
        query += "INNER JOIN tb_sales_return_order b ON a.id_sales_return_order = b.id_sales_return_order "
        query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_from "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_m_comp_contact c1 ON c1.id_comp_contact = a.id_comp_contact_to "
        query += "INNER JOIN tb_m_comp d1 ON c1.id_comp = d1.id_comp "
        query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
        query += "LEFT JOIN tb_m_wh_drawer dw ON dw.id_wh_drawer=a.id_wh_drawer "
        query += "LEFT JOIN tb_lookup_prepare_status prep_stt ON prep_stt.id_prepare_status = b.id_prepare_status "
        query += "WHERE a.id_sales_return = '" + id_sales_return + "' "
        Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
        id_report_status = data.Rows(0)("id_report_status").ToString

        id_store_contact_from = data.Rows(0)("id_store_contact_from").ToString
        id_comp_contact_to = data.Rows(0)("id_comp_contact_to").ToString

        TxtStoreReturnNumber.Text = data.Rows(0)("sales_return_store_number").ToString
        TxtSalesReturnNumber.Text = data.Rows(0)("sales_return_number").ToString
        TxtSalesReturnOrderNumber.Text = data.Rows(0)("sales_return_order_number").ToString

        TxtNameCompFrom.Text = data.Rows(0)("store_name_from").ToString
        TxtCodeCompFrom.Text = data.Rows(0)("store_number_from").ToString
        TxtNameCompTo.Text = data.Rows(0)("comp_name_to").ToString
        TxtCodeCompTo.Text = data.Rows(0)("comp_number_to").ToString

        MEAdrressCompFrom.Text = data.Rows(0)("store_address_from").ToString

        DEForm.Text = view_date_from(data.Rows(0)("sales_return_datex").ToString, 0)
        TxtSalesReturnNumber.Text = data.Rows(0)("sales_return_number").ToString
        MENote.Text = data.Rows(0)("sales_return_note").ToString
        LEReportStatus.ItemIndex = LEReportStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)
        id_sales_return_order = data.Rows(0)("id_sales_return_order").ToString
        id_store = data.Rows(0)("id_store").ToString
        id_comp_to = data.Rows(0)("id_comp_to").ToString

        id_drawer = data.Rows(0)("id_wh_drawer").ToString
        TEDrawer.Text = data.Rows(0)("wh_drawer_code").ToString
        id_prepare_status = data.Rows(0)("id_prepare_status").ToString
        TxtOrderStatus.Text = data.Rows(0)("prepare_status").ToString

        If is_detail_soh <> "-1" Then
            TxtOrderStatus.Visible = True
            LabelOrderStatus.Visible = True
            PanelControlBottomRight.Visible = False
            GroupControl3.Visible = False
            GroupControlStatus.Visible = True
        End If
        'detail2
        viewDetail()
        view_barcode_list()
        check_but()
        allow_status()
    End Sub
    Sub viewSalesReturnOrder()
        Dim query As String = "SELECT a.id_sales_return_order, a.id_store_contact_to, (d.comp_name) AS store_name_to,a.id_report_status, f.report_status, "
        query += "a.sales_return_order_note, a.sales_return_order_note, a.sales_return_order_number, "
        query += "DATE_FORMAT(a.sales_return_order_date,'%d %M %Y') AS sales_return_order_date, "
        query += "DATE_FORMAT(a.sales_return_order_est_date,'%d %M %Y') AS sales_return_order_est_date "
        query += "FROM tb_sales_return_order a "
        'query += "INNER JOIN tb_sales_return_order_det b ON a.id_sales_return_order = b.id_sales_return_order "
        query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact = a.id_store_contact_to "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_lookup_report_status f ON f.id_report_status = a.id_report_status "
        query += "WHERE a.id_sales_return_order ='" + id_sales_return_order + "' "
        query += "ORDER BY a.id_sales_return_order ASC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        'SO
        TxtSalesReturnOrderNumber.Text = data.Rows(0)("sales_return_order_number").ToString

        'store data
        Dim query_comp_to As String = "SELECT id_comp FROM tb_m_comp_contact WHERE id_comp_contact = '" + data.Rows(0)("id_store_contact_to").ToString + "'"
        Dim id_comp_from As String = execute_query(query_comp_to, 0, True, "", "", "", "")
        id_store = id_comp_from
        id_store_contact_from = data.Rows(0)("id_store_contact_to").ToString
        TxtCodeCompFrom.Text = get_company_x(id_comp_from, 2)
        TxtNameCompFrom.Text = get_company_x(id_comp_from, 1)
        'MEAdrressCompTo.Text = get_company_x(id_comp_to, 3)

        'general
        viewDetail()
        viewDetailDrawer()
        viewDetailDrawer2()
        view_barcode_list()
        GroupControlListItem.Enabled = True
        GroupControlScannedItem.Enabled = True
        GVItemList.OptionsBehavior.AutoExpandAllGroups = True
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status a ORDER BY a.id_report_status "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        viewLookupQuery(LEReportStatus, query, 0, "report_status", "id_report_status")
    End Sub

    Sub viewDetail()
        Dim query As String = "CALL view_sales_return('" + id_sales_return + "')"
        Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
        For i As Integer = 0 To (data.Rows.Count - 1)
            id_sales_return_det_list.Add(data.Rows(i)("id_sales_return_det").ToString)
            codeAvailableIns(data.Rows(i)("id_product").ToString, id_store, data.Rows(i)("id_design_price").ToString)
        Next
        GCItemList.DataSource = data
    End Sub


    Sub view_barcode_list()
        Dim id_product_param As String = "-1"
        Dim id_design_price_param As String = "-1"
        Try
            id_product_param = GVItemList.GetFocusedRowCellValue("id_product").ToString
        Catch ex As Exception
        End Try
        Try
            id_design_price_param = GVItemList.GetFocusedRowCellValue("id_design_price").ToString
        Catch ex As Exception
        End Try

        Dim query As String = ""
        query += "SELECT ('') AS no, CONCAT(c.product_full_code, a.sales_return_det_counting) AS code, (c.product_full_code) AS product_code, "
        query += "(a.sales_return_det_counting) AS counting_code, "
        query += "a.id_sales_return_det_counting, ('2') AS is_fix, "
        query += "a.id_pl_prod_order_rec_det_unique, b.id_product, "
        query += "d.bom_unit_price, b.id_design_price, b.design_price "
        query += "FROM tb_sales_return_det_counting a "
        query += "INNER JOIN tb_sales_return_det b ON a.id_sales_return_det = b.id_sales_return_det "
        query += "INNER JOIN tb_m_product c ON c.id_product = b.id_product "
        query += "LEFT JOIN tb_pl_prod_order_rec_det_counting d ON d.id_pl_prod_order_rec_det_unique = a.id_pl_prod_order_rec_det_unique "
        query += "WHERE b.id_sales_return = '" + id_sales_return + "' AND b.id_product = '" + id_product_param + "' AND b.id_design_price = '" + id_design_price_param + "' "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCBarcode.DataSource = data
    End Sub

    Sub viewDetailDrawer()
        'Dim query As String = ""
        'query += "SELECT a.id_sales_return_det_drawer, a.id_sales_return_det, "
        'query += "a.sales_return_det_drawer_qty, a.sales_return_det_drawer_qty_stored, a.bom_unit_price, b.id_product, "
        'query += "('-') AS drawer, "
        'query += "('-') AS rack, "
        'query += "('-') AS locator, "
        'query += "('-') AS wh, "
        'query += "b.id_design_price, b.design_price "
        'query += "FROM tb_sales_return_det_drawer a "
        'query += "INNER JOIN tb_sales_return_det b ON a.id_sales_return_det = b.id_sales_return_det "
        ''query += "LEFT JOIN tb_m_wh_drawer c ON c.id_wh_drawer = a.id_wh_drawer "
        ''query += "LEFT JOIN tb_m_wh_rack d ON d.id_wh_rack = c.id_wh_rack "
        ''query += "LEFT JOIN tb_m_wh_locator e ON e.id_wh_locator = d.id_wh_locator "
        ''query += "LEFT JOIN tb_m_comp f ON f.id_comp = e.id_comp "
        'query += "WHERE b.id_sales_return = '" + id_sales_return + "' "
        'Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        'For i As Integer = 0 To (data.Rows.Count - 1)
        '    id_sales_return_det_drawer_list.Add(data.Rows(i)("id_sales_return_det_drawer").ToString)
        'Next
        'GCDrawer.DataSource = data
    End Sub

    Sub viewDetailDrawer2()
        'Dim query As String = ""
        'query += "SELECT IF(ISNULL(a.id_sales_return_det_drawer_detail), '0', a.id_sales_return_det_drawer_detail) as id_sales_return_det_drawer_detail, b.id_sales_return_det_drawer, "
        'query += "b1.id_sales_return, "
        'query += "(c.wh_drawer_code) AS drawer, "
        'query += "(d.wh_rack_code) AS rack, "
        'query += "(e.wh_locator_code) AS locator, "
        'query += "(f.comp_number) AS wh  "
        'query += "FROM tb_sales_return_det_drawer_detail a "
        'query += "INNER JOIN tb_sales_return_det_drawer b ON a.id_sales_return_det_drawer = b.id_sales_return_det_drawer "
        'query += "INNER JOIN tb_sales_return_det b1 ON b1.id_sales_return_det = b.id_sales_return_det "
        'query += "INNER JOIN tb_m_wh_drawer c ON c.id_wh_drawer = a.id_wh_drawer "
        'query += "INNER JOIN tb_m_wh_rack d ON d.id_wh_rack = c.id_wh_rack "
        'query += "INNER JOIN tb_m_wh_locator e ON e.id_wh_locator = d.id_wh_locator "
        'query += "INNER JOIN tb_m_comp f ON f.id_comp = e.id_comp "
        'query += "WHERE b1.id_sales_return = '" + id_sales_return + "' "
        'Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        'For i As Integer = 0 To (data.Rows.Count - 1)
        '    id_sales_return_det_drawer_detail_list.Add(data.Rows(i)("id_sales_return_det_drawer_detail").ToString)
        'Next
        'GCDrawerDetail.DataSource = data
    End Sub

    Sub codeAvailableIns(ByVal id_product_param As String, ByVal id_store_param As String, ByVal id_design_price_param As String)
        'Dim query As String = ""
        'query = "CALL view_stock_fg_unique_ret('" + id_product_param + "','" + id_store_param + "', '" + id_design_price_param + "','" + id_sales_return + "')"

        'Dim datax As DataTable = execute_query(query, -1, True, "", "", "", "")
        'For k As Integer = 0 To (datax.Rows.Count - 1)
        '    insertDt(datax.Rows(k)("id_product").ToString, datax.Rows(k)("id_pl_prod_order_rec_det_unique").ToString, datax.Rows(k)("product_code").ToString, datax.Rows(k)("product_counting_code").ToString, datax.Rows(k)("product_full_code").ToString, Decimal.Parse(datax.Rows(k)("bom_unit_price").ToString), datax.Rows(k)("id_design_price").ToString, Decimal.Parse(datax.Rows(k)("design_price").ToString))
        'Next
        ''GCTest.DataSource = dt
    End Sub

    Sub insertDt(ByVal id_product_param As String, ByVal id_pl_prod_order_rec_det_unique_param As String, ByVal product_code_param As String, ByVal product_counting_code_param As String, ByVal product_full_code_param As String, ByVal cost_param As Decimal, ByVal id_design_price_param As String, ByVal design_price_param As Decimal)
        'Dim R As DataRow = dt.NewRow
        'R("id_product") = id_product_param
        'R("id_pl_prod_order_rec_det_unique") = id_pl_prod_order_rec_det_unique_param
        'R("product_code") = product_code_param
        'R("product_counting_code") = product_counting_code_param
        'R("product_full_code") = product_full_code_param
        'R("bom_unit_price") = cost_param
        'R("id_design_price") = id_design_price_param
        'R("design_price") = design_price_param
        'dt.Rows.Add(R)
    End Sub

    Sub codeAvailableDel(ByVal id_product_param As String)
        'Dim i As Integer = dt.Rows.Count - 1
        'While (i >= 0)
        '    If dt.Rows(i)("id_product").ToString = id_product_param Then
        '        dt.Rows.RemoveAt(i)
        '    End If
        '    i = i - 1
        'End While
    End Sub


    'sub check_but
    Sub check_but()
        
    End Sub

    Sub allow_status()
        MENote.Properties.ReadOnly = True
        TxtStoreReturnNumber.Properties.ReadOnly = True
        BtnAttachment.Enabled = True
        TxtSalesReturnNumber.Focus()
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

    Private Sub GVBarcode_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Sub allowDelete()

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

    Sub countQty(ByVal id_product_param As String, ByVal id_design_price_param As String, ByVal design_price_param As Decimal)
        Dim tot As Decimal = 0.0
        For i As Integer = 0 To GVBarcode.RowCount - 1
            Dim id_product As String = GVBarcode.GetRowCellValue(i, "id_product").ToString
            Dim id_design_price As String = GVBarcode.GetRowCellValue(i, "id_design_price").ToString
            Dim design_price As Decimal = Decimal.Parse(GVBarcode.GetRowCellValue(i, "design_price").ToString)
            If id_product = id_product_param And id_design_price = id_design_price_param And design_price = design_price_param Then
                tot = tot + 1.0
            End If
        Next

        Dim indeks As Integer = 0
        For j As Integer = 0 To GVItemList.RowCount - 1
            Try
                Dim id_productx As String = GVItemList.GetRowCellValue(j, "id_product").ToString
                Dim id_design_pricex As String = GVItemList.GetRowCellValue(j, "id_design_price").ToString
                Dim design_pricex As Decimal = Decimal.Parse(GVItemList.GetRowCellValue(j, "design_price").ToString)
                If id_productx = id_product_param And id_design_pricex = id_design_price_param And design_pricex = design_price_param Then
                    indeks = j
                    Exit For
                End If
            Catch ex As Exception
            End Try
        Next



        GVItemList.FocusedRowHandle = indeks
        Dim price As Decimal = Decimal.Parse(GVItemList.GetFocusedRowCellValue("design_price").ToString)
        GVItemList.SetFocusedRowCellValue("sales_return_det_amount", tot * price)
        GVItemList.SetFocusedRowCellValue("sales_return_det_qty", tot)
    End Sub

    Private Sub FormSalesReturnDet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub


    Private Sub BMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMark.Click
        Cursor = Cursors.WaitCursor
        FormReportMark.id_report = id_sales_return
        FormReportMark.is_view = "1"
        FormReportMark.report_mark_type = "46"
        FormReportMark.form_origin = Name
        FormReportMark.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub GVItemList_FocusedRowChanged_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVItemList.FocusedRowChanged
        view_barcode_list()
    End Sub



    Sub countQtyFromWh(ByVal id_product_param As String)
        'Dim jum As Decimal = 0.0
        'For i As Integer = 0 To (GVDrawer.RowCount - 1)
        '    Try
        '        Dim id_product_i As String = GVDrawer.GetRowCellValue(i, "id_product").ToString
        '        If id_product_i = id_product_param Then
        '            jum = jum + Decimal.Parse(GVDrawer.GetRowCellValue(i, "qty_all_product"))
        '        End If
        '    Catch ex As Exception

        '    End Try
        'Next
        'GVItemList.FocusedRowHandle = find_row(GVItemList, "id_product", id_product_param)
        'GVItemList.SetFocusedRowCellValue("qty_from_wh", jum)
        'allowScanPage()
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
        Cursor = Cursors.WaitCursor
        Dim code_check As String = GVBarcode.GetFocusedRowCellValue("code").ToString
        Dim code_found As Boolean = False
        Dim code_duplicate As Boolean = False
        'Dim id_pl_sales_order_del_det As String = ""
        Dim counting_code As String = ""
        Dim id_pl_prod_order_rec_det_unique As String = ""
        Dim id_product As String = ""
        Dim bom_unit_price As Decimal = 0.0
        Dim id_design_price As String = ""
        Dim design_price As Decimal = 0.0
        Dim index_atas As Integer = -100

        'check available code
        For i As Integer = 0 To (dt.Rows.Count - 1)
            Dim code As String = dt.Rows(i)("product_full_code").ToString
            counting_code = dt.Rows(i)("product_counting_code").ToString
            id_pl_prod_order_rec_det_unique = dt.Rows(i)("id_pl_prod_order_rec_det_unique").ToString
            id_product = dt.Rows(i)("id_product").ToString
            bom_unit_price = Decimal.Parse(dt.Rows(i)("bom_unit_price").ToString)
            id_design_price = dt.Rows(i)("id_design_price").ToString
            design_price = Decimal.Parse(dt.Rows(i)("design_price").ToString)
            If code = code_check Then
                index_atas = i
                code_found = True
                Exit For
            End If
        Next

        'check duplicate code
        If GVBarcode.RowCount <= 0 Then
            code_duplicate = False
        Else
            For i As Integer = 0 To (GVBarcode.RowCount - 1)
                Dim code As String = ""
                If Not IsDBNull(GVBarcode.GetRowCellValue(i, "code")) Then
                    code = GVBarcode.GetRowCellValue(i, "code".ToString)
                End If

                Dim is_fix As String = "1"
                If Not IsDBNull(GVBarcode.GetRowCellValue(i, "is_fix")) Then
                    is_fix = GVBarcode.GetRowCellValue(i, "is_fix").ToString
                End If

                If code = code_check And is_fix = "2" Then
                    code_duplicate = True
                    Exit For
                End If
            Next
        End If

        'check indeks row
        For g As Integer = 0 To (GVItemList.RowCount - 1)
            Dim id_productx As String = "-1"
            Dim id_design_pricex As String = "-1"
            Try
                id_productx = GVItemList.GetRowCellValue(g, "id_product")
            Catch ex As Exception
            End Try
            Try
                id_design_pricex = GVItemList.GetRowCellValue(g, "id_design_price")
            Catch ex As Exception
            End Try
            If id_product = id_productx And id_design_price = id_design_pricex Then
                index_atas = g
                Exit For
            End If
        Next


        If Not code_found Then
            GVBarcode.SetFocusedRowCellValue("code", "")
            stopCustom("Data not found or duplicate!")
        ElseIf code_duplicate Then
            GVBarcode.SetFocusedRowCellValue("code", "")
            stopCustom("Data duplicate !")
        Else
            If GVItemList.GetRowCellValue(index_atas, "sales_return_det_qty") >= GVItemList.GetRowCellValue(index_atas, "sales_return_det_qty_limit") Then
                GVBarcode.SetFocusedRowCellValue("code", "")
                stopCustom("Return Qty more than Remaining Qty.")
            Else
                GVBarcode.SetFocusedRowCellValue("id_pl_prod_order_rec_det_unique", id_pl_prod_order_rec_det_unique)
                GVBarcode.SetFocusedRowCellValue("id_sales_return_det_counting", "0")
                GVBarcode.SetFocusedRowCellValue("is_fix", "2")
                GVBarcode.SetFocusedRowCellValue("counting_code", counting_code)
                GVBarcode.SetFocusedRowCellValue("id_product", id_product)
                GVBarcode.SetFocusedRowCellValue("bom_unit_price", bom_unit_price)
                GVBarcode.SetFocusedRowCellValue("id_design_price", id_design_price)
                GVBarcode.SetFocusedRowCellValue("design_price", design_price)
                countQty(id_product, id_design_price, design_price)
                newRowsBc()
            End If
        End If
        Cursor = Cursors.Default
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

    Sub deleteDetailDrawer(ByVal id_product_param As String)

    End Sub


    'Color Cell
    Public Sub my_color_cell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'MsgBox("HAH")
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender

        e.Appearance.BackColor = Color.White
        e.Appearance.BackColor2 = Color.White

        Try
            Dim id_product_style As String = GVItemList.GetFocusedRowCellValue("id_product").ToString
            Dim id_design_price_style As String = GVItemList.GetFocusedRowCellValue("id_design_price").ToString

            Dim id_product_check As String = View.GetRowCellValue(e.RowHandle, View.Columns("id_product"))
            Dim id_design_price_check As String = View.GetRowCellValue(e.RowHandle, View.Columns("id_design_price"))
            If id_product_check = id_product_style And id_design_price_check = id_design_price_style Then
                e.Appearance.BackColor = Color.Lavender
                e.Appearance.BackColor2 = Color.White
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub check_but_drawer()
       
    End Sub



    Private Sub BtnAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAttachment.Click
        Cursor = Cursors.WaitCursor
        FormDocumentUpload.id_report = id_sales_return
        FormDocumentUpload.is_view = "1"
        FormDocumentUpload.report_mark_type = "46"
        FormDocumentUpload.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub GVItemList_ColumnFilterChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVItemList.ColumnFilterChanged
        view_barcode_list()
    End Sub
End Class