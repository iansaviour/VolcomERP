﻿Public Class FormFGStock
    '------------------------------------
    'VARIABLE STOCK CARD
    '------------------------------------
    'Def var -Tab Stock Card
    Dim id_sample_image As String = "0"
    Dim id_comp_def As String = "0"
    Dim comp_def As String = ""
    Dim id_design_def As String = "0"
    Dim label_design_def As String = "0"
    Dim color_def As String = "-1"
    Dim division_def As String = "-1"
    Dim branding_def As String = "-1"
    Dim source_def As String = "-1"
    Dim class_def As String = "-1"
    Dim id_sample_def As String = "-1"

    'selected view  -Tab Stock Card
    Public id_design_selected As String = "-1"
    Public label_design_selected As String = "-1"
    Public id_wh_selected As String = "-1"
    Public comp_name_label_selected As String = ""
    Public date_from_selected As String = "-1"
    Public date_until_selected As String = "-1"

    'Datatalbe-Tab Stock Card
    Public dt As DataTable

    '------------------------------------
    'VARIABLE STOCK WH
    '------------------------------------
    'Def var -Tab Stock Sum
    Dim id_comp_def_stock_sum As String = "0"
    Dim comp_def_stock_sum As String = ""
    Dim label_design_stock_sum_def As String

    'Selected view - Tab Stock Sum
    Public id_wh_param_selected As String = "-1"
    Public id_locator_param_selected As String = "-1"
    Public id_rack_param_selected As String = "-1"
    Public id_drawer_param_selected As String = "-1"
    Public id_design_selected_stock_sum As String = "-1"
    Public label_design_selected_stock_sum As String = "-1"
    Public label_wh_selected_stock_sum As String = "-1"
    Public label_locator_selected_stock_sum As String = "-1"
    Public label_rack_selected_stock_sum As String = "-1"
    Public label_drawer_selected_stock_sum As String = "-1"
    Public date_from_selected_stock_sum As String = "-1"
    Public date_until_selected_stock_sum As String = "-1"
    Dim special_code_list As New List(Of String)

    'Datatalbe-Tab Stock Sum
    Public dt_sum As DataTable

    '------------------------------------
    'VARIABLE STOCK STORE
    '------------------------------------
    'Def var -Tab Stock Store
    Dim id_store_def_stock_store As String = "0"
    Dim store_def_stock_store As String = ""
    Dim label_design_stock_store_def As String

    'selected View - Tab Stock Store
    Public id_store_param_selected As String = "-1"
    Public id_design_selected_stock_store As String = "-1"
    Public label_design_selected_stock_store As String = "-1"
    Public label_store_selected_stock_store As String = "-1"
    Public date_from_selected_stock_store As String = "-1"
    Public date_until_selected_stock_store As String = "-1"

    'Datatalbe-Tab Stock Store
    Public dt_store As DataTable

    '-------------------------------------
    'VARIABLE STOCK QC
    '-------------------------------------
    'Def var -Tab Stock Store
    Dim label_design_stock_qc_def As String

    'selected View - Tab Stock Store
    Public id_design_selected_stock_qc As String = "-1"
    Public label_design_selected_stock_qc As String = "-1"
    Public date_from_selected_stock_qc As String = "-1"
    Public date_until_selected_stock_qc As String = "-1"

    'Datatalbe-Tab Stock Store
    Public dt_qc As DataTable

    Public id_pop_up As String = "-1"

    Private Sub FormFGStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If id_pop_up = "-1" Then
            viewWHStockCard()
            viewWHStockSum()
            viewProductStockSum()
            viewStoreStockStore()
            viewProductStockStore()
            XTPFGStockQC.PageVisible = False
        Else
            viewProductStockQC()
            XTPFGStockCardWH.PageVisible = False
            XTPFGStockStore.PageVisible = False
            XTPFGStockWHSum.PageVisible = False
            XTPFGStockQC.PageVisible = True
        End If
    End Sub

    '=============== TAB STOCK CARD FG=================================
    Sub viewWHStockCard()
        Dim query As String = getQueryWH()
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                comp_def = data.Rows(i)("comp_name_label").ToString
                Exit For
            End If
        Next
        SLEWH.Properties.DataSource = Nothing
        SLEWH.Properties.DataSource = data
        SLEWH.Properties.DisplayMember = "comp_name_label"
        SLEWH.Properties.ValueMember = "id_comp"
        If data.Rows.Count.ToString >= 1 Then
            SLEWH.EditValue = data.Rows(0)("id_comp").ToString
        Else
            SLEWH.EditValue = Nothing
        End If
    End Sub


    Private Sub SLEWH_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLEWH.EditValueChanged
        If SLEWH.EditValue = Nothing Then
            SLEWH.EditValue = "0"
        Else
            id_comp_def = SLEWH.EditValue.ToString
        End If
    End Sub

    Private Sub BtnTracking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTracking.Click
        viewStockCard()
    End Sub

    Private Sub BtnViewImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewImg.Click
        pre_viewImages("2", PictureEdit1, id_design_selected, True)
    End Sub

    Private Sub BandedGridViewFGStockCard_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles BandedGridViewFGStockCard.PopupMenuShowing
        If BandedGridViewFGStockCard.RowCount > 0 Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.Point)
            If hitInfo.InRow Then
                view.FocusedRowHandle = hitInfo.RowHandle
                ViewMenu.Show(view.GridControl, e.Point)
            End If
        End If
    End Sub

    Private Sub SMViewDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMViewDel.Click
        Cursor = Cursors.WaitCursor
        If BandedGridViewFGStockCard.RowCount > 0 Then
            Dim id_trans As String = "-1"
            Dim report_mark_type As String = "-1"
            Try
                id_trans = BandedGridViewFGStockCard.GetFocusedRowCellValue("id_report").ToString
                report_mark_type = BandedGridViewFGStockCard.GetFocusedRowCellValue("report_mark_type").ToString
            Catch ex As Exception
            End Try

            Dim showpopup As ClassShowPopUp = New ClassShowPopUp()
            showpopup.report_mark_type = report_mark_type
            showpopup.id_report = id_trans
            showpopup.show()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub FormFGStock_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormMain.show_rb(Name)
        check_menu()
    End Sub

    Private Sub FormFGStock_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        FormMain.hide_rb()
    End Sub

    Sub check_menu()
        checkFormAccess(Name)
    End Sub

    '===================== TAB STOCK SUMMARY=========================================
    Sub viewWHStockSum()
        Dim query As String = getQueryWH()
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                comp_def_stock_sum = data.Rows(i)("comp_name_label").ToString
                Exit For
            End If
        Next
        SLEWHStockSum.Properties.DataSource = Nothing
        SLEWHStockSum.Properties.DataSource = data
        SLEWHStockSum.Properties.DisplayMember = "comp_name_label"
        SLEWHStockSum.Properties.ValueMember = "id_comp"
        If data.Rows.Count.ToString >= 1 Then
            SLEWHStockSum.EditValue = data.Rows(0)("id_comp").ToString
        Else
            SLEWHStockSum.EditValue = Nothing
        End If
    End Sub

    Private Sub SLEWHStockSum_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLEWHStockSum.EditValueChanged
        If SLEWHStockSum.EditValue = Nothing Then
            SLEWHStockSum.EditValue = "0"
        Else
            id_comp_def_stock_sum = SLEWHStockSum.EditValue.ToString
            viewLocatorStockSum()
        End If
    End Sub

    Sub viewLocatorStockSum()
        Dim id_comp As String = "-1"
        Try
            id_comp = SLEWHStockSum.EditValue.ToString()
        Catch ex As Exception
        End Try
        Dim query As String = getQueryLocator(id_comp)
        viewSearchLookupQuery(SLELocatorStockSum, query, "id_wh_locator", "locator_label", "id_wh_locator")
    End Sub

    Private Sub SLELocatorStockSum_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLELocatorStockSum.EditValueChanged
        viewRackStockSum()
    End Sub

    Sub viewRackStockSum()
        Dim id_locator As String = "-1"
        Try
            id_locator = SLELocatorStockSum.EditValue.ToString
        Catch ex As Exception
        End Try
        Dim query As String = getRack(id_locator)
        viewSearchLookupQuery(SLERackStockSum, query, "id_wh_rack", "rack_label", "id_wh_rack")
    End Sub

    Private Sub SLERackStockSum_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLERackStockSum.EditValueChanged
        viewDrawerStockSum()
    End Sub

    Sub viewDrawerStockSum()
        Dim id_rack As String = "-1"
        Try
            id_rack = SLERackStockSum.EditValue.ToString
        Catch ex As Exception
        End Try
        Dim query As String = getDrawer(id_rack)
        viewSearchLookupQuery(SLEDrawerStockSum, query, "id_wh_drawer", "drawer_label", "id_wh_drawer")
    End Sub

    Private Sub SLEDrawerStockSum_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLEDrawerStockSum.EditValueChanged
        If SLEDrawerStockSum.EditValue Is Nothing Then
            BtnViewStockSum.Enabled = False
        Else
            BtnViewStockSum.Enabled = True
        End If
    End Sub

    Private Sub BtnViewStockSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewStockSum.Click
        Cursor = Cursors.WaitCursor

        'Clear List code
        special_code_list.Clear()

        'Prepare paramater
        date_until_selected_stock_sum = "9999-01-01"
        Try
            date_until_selected_stock_sum = DateTime.Parse(DEUntilStockFG.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        Try
            id_design_selected_stock_sum = SLEDesignStockSum.EditValue.ToString
            id_wh_param_selected = SLEWHStockSum.EditValue.ToString
            id_locator_param_selected = SLELocatorStockSum.EditValue.ToString
            id_rack_param_selected = SLERackStockSum.EditValue.ToString
            id_drawer_param_selected = SLEDrawerStockSum.EditValue.ToString
        Catch ex As Exception
        End Try

        'set selected
        If id_design_selected_stock_sum = "0" Then
            label_design_selected_stock_sum = "All Design"
        Else
            label_design_selected_stock_sum = SLEDesignStockSum.Properties.View.GetFocusedRowCellValue("label_design").ToString
        End If

        If id_wh_param_selected = "0" Then
            label_wh_selected_stock_sum = "All WH"
        Else
            label_wh_selected_stock_sum = SLEWHStockSum.Properties.View.GetFocusedRowCellValue("comp_name_label").ToString
        End If

        If id_locator_param_selected = "0" Then
            label_locator_selected_stock_sum = "All Locator"
        Else
            label_locator_selected_stock_sum = SLELocatorStockSum.Properties.View.GetFocusedRowCellValue("locator_label").ToString
        End If

        If id_rack_param_selected = "0" Then
            label_rack_selected_stock_sum = "All Rack"
        Else
            label_rack_selected_stock_sum = SLERackStockSum.Properties.View.GetFocusedRowCellValue("rack_label").ToString
        End If

        If id_drawer_param_selected = "0" Then
            label_drawer_selected_stock_sum = "All Drawer"
        Else
            label_drawer_selected_stock_sum = SLEDrawerStockSum.Properties.View.GetFocusedRowCellValue("drawer_label").ToString
        End If


        'Prepare Baded
        BGVFGStock.Columns.Clear()
        BGVFGStock.Bands.Clear()
        BGVFGStock.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        ' Make the group footers always visible.
        BGVFGStock.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways

        Dim band_desc As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStock.Bands.AddBand("DESCRIPTION")
        Dim band_aging As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStock.Bands.AddBand("AGING (MONTH)")
        Dim band_qty_free As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStock.Bands.AddBand("QTY FREE")
        Dim band_qty_res As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStock.Bands.AddBand("QTY RESERVED")
        Dim band_qty_total As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStock.Bands.AddBand("TOTAL QTY")
        'band_qty_total.AppearanceHeader.Font = New Font(BGVFGStock.Appearance.Row.Font.FontFamily, BGVFGStock.Appearance.Row.Font.Size, FontStyle.Bold)

        Dim query As String = "CALL view_stock_fg_sum('" + id_wh_param_selected + "', '" + id_locator_param_selected + "', '" + id_rack_param_selected + "', '" + id_drawer_param_selected + "', '" + id_design_selected_stock_sum + "', '" + date_until_selected_stock_sum + "') "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Columns.Count - 1
            If data.Columns(i).ColumnName.ToString = "id_sample" Or data.Columns(i).ColumnName.ToString = "Code" Or data.Columns(i).ColumnName.ToString = "id_design" Or data.Columns(i).ColumnName.ToString = "Design" Or data.Columns(i).ColumnName.ToString = "design_display_name" Or data.Columns(i).ColumnName.ToString = "uom" Or data.Columns(i).ColumnName.ToString = "id_design_stock" Or data.Columns(i).ColumnName.ToString = "Unit Cost" Or data.Columns(i).ColumnName.ToString = "Product Division" Or data.Columns(i).ColumnName.ToString = "Product Source" Or data.Columns(i).ColumnName.ToString = "Product Branding" Or data.Columns(i).ColumnName.ToString = "Range" Or data.Columns(i).ColumnName.ToString = "Product Counting" Or data.Columns(i).ColumnName.ToString = "Color" Or data.Columns(i).ColumnName.ToString = "Price" Then
                band_desc.Columns.Add(BGVFGStock.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
            ElseIf data.Columns(i).ColumnName.ToString.Contains(" Free") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 5
                band_qty_free.Columns.Add(BGVFGStock.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            ElseIf data.Columns(i).ColumnName.ToString.Contains(" Reserved") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 9
                band_qty_res.Columns.Add(BGVFGStock.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n2}"
            ElseIf data.Columns(i).ColumnName.ToString.Contains(" Aging") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 6
                band_aging.Columns.Add(BGVFGStock.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n2}"
            ElseIf data.Columns(i).ColumnName.ToString.Contains(" Total") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 6
                band_qty_total.Columns.Add(BGVFGStock.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                'BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.Font = New Font(BGVFGStock.Appearance.Row.Font.FontFamily, BGVFGStock.Appearance.Row.Font.Size, FontStyle.Bold)
                'BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).AppearanceCell.Font = New Font(BGVFGStock.Appearance.Row.Font.FontFamily, BGVFGStock.Appearance.Row.Font.Size, FontStyle.Bold)
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n2}"

                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStock.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n2}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n2}"
                item.ShowInGroupColumnFooter = BGVFGStock.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStock.GroupSummary.Add(item)

            End If
        Next
        GCFGStock.DataSource = data
        dt_sum = data

        'hide column
        BGVFGStock.Columns("id_sample").Visible = False
        BGVFGStock.Columns("id_design").Visible = False
        BGVFGStock.Columns("design_display_name").Visible = False
        BGVFGStock.Columns("uom").Visible = False
        BGVFGStock.Columns("id_design_stock").Visible = False
        BGVFGStock.Columns("Product Counting").Visible = False
        BGVFGStock.Columns("Range").Visible = False
        For j As Integer = 0 To special_code_list.Count - 1
            BGVFGStock.Columns(special_code_list(j)).Visible = False
        Next

        'Enable Group
        GroupControlStockSum.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Sub viewStockCard()
        Cursor = Cursors.WaitCursor
        BandedGridViewFGStockCard.Columns.Clear()
        BandedGridViewFGStockCard.Bands.Clear()
        'BandedGridViewFGStockCard.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        BandedGridViewFGStockCard.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        label_design_selected = ""
        id_wh_selected = "0"
        comp_name_label_selected = ""
        date_from_selected = "0000-01-01"
        date_until_selected = "9999-01-01"

        Try
            date_from_selected = DateTime.Parse(DEFrom.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        Try
            date_until_selected = DateTime.Parse(DEUntil.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        Try
            id_wh_selected = SLEWH.EditValue.ToString
        Catch ex As Exception
        End Try

        id_sample_image = "0"
        Dim band_ref As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BandedGridViewFGStockCard.Bands.AddBand("REFF")
        Dim band_qty As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BandedGridViewFGStockCard.Bands.AddBand("QUANTITY")
        Dim band_bal As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BandedGridViewFGStockCard.Bands.AddBand("BALANCE")
        Dim band_stat As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BandedGridViewFGStockCard.Bands.AddBand("")
        band_stat.AutoFillDown = True
        Dim query As String = "CALL view_stock_card_fg('" + id_design_selected + "', '" + id_wh_selected + "', '" + date_from_selected + "', '" + date_until_selected + "') "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Columns.Count - 1
            If data.Columns(i).ColumnName.ToString = "id_comp" Or data.Columns(i).ColumnName.ToString = "id_report" Or data.Columns(i).ColumnName.ToString = "report_mark_type" Or data.Columns(i).ColumnName.ToString = "id_storage_category" Or data.Columns(i).ColumnName.ToString = "Time" Or data.Columns(i).ColumnName.ToString = "Transaction" Or data.Columns(i).ColumnName.ToString = "Transaction Type" Then
                band_ref.Columns.Add(BandedGridViewFGStockCard.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
                If data.Columns(i).ColumnName.ToString = "Time" Then
                    BandedGridViewFGStockCard.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    BandedGridViewFGStockCard.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "dd MMM yyyy hh:mm:ss"
                End If
            ElseIf data.Columns(i).ColumnName.ToString = "Status" Then
                band_stat.Columns.Add(BandedGridViewFGStockCard.Columns.AddVisible(data.Columns(i).ColumnName.ToString, "Status"))
            ElseIf data.Columns(i).ColumnName.ToString.Contains(" Bal") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 4
                band_bal.Columns.Add(BandedGridViewFGStockCard.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
            Else
                band_qty.Columns.Add(BandedGridViewFGStockCard.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
            End If
        Next


        GCFGStockCard.DataSource = data
        dt = data

        'hide column
        BandedGridViewFGStockCard.Columns("id_comp").Visible = False
        BandedGridViewFGStockCard.Columns("id_report").Visible = False
        BandedGridViewFGStockCard.Columns("report_mark_type").Visible = False
        BandedGridViewFGStockCard.Columns("id_storage_category").Visible = False


        'enable group
        GroupControlInfo.Enabled = True
        GroupControlTraccking.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Sub viewProductStockSum()
        Dim query As String = ""
        query += "CALL view_design_wh(TRUE) "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                label_design_stock_sum_def = data.Rows(i)("label_design").ToString
                Exit For
            End If
        Next
        SLEDesignStockSum.Properties.DataSource = Nothing
        SLEDesignStockSum.Properties.DataSource = data
        SLEDesignStockSum.Properties.DisplayMember = "label_design"
        SLEDesignStockSum.Properties.ValueMember = "id_design"
        If data.Rows.Count.ToString >= 1 Then
            SLEDesignStockSum.EditValue = data.Rows(0)("id_design").ToString
        Else
            SLEDesignStockSum.EditValue = Nothing
        End If
    End Sub

    '===========================TAB STOCK STORE======================================
    Sub viewStoreStockStore()
        Dim query As String = getQueryStore()
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                store_def_stock_store = data.Rows(i)("comp_name_label").ToString
                Exit For
            End If
        Next
        SLEStockStore.Properties.DataSource = Nothing
        SLEStockStore.Properties.DataSource = data
        SLEStockStore.Properties.DisplayMember = "comp_name_label"
        SLEStockStore.Properties.ValueMember = "id_comp"
        If data.Rows.Count.ToString >= 1 Then
            SLEStockStore.EditValue = data.Rows(0)("id_comp").ToString
        Else
            SLEStockStore.EditValue = Nothing
        End If
    End Sub

    Sub viewProductStockStore()
        Dim query As String = ""
        query += "CALL view_design_wh(TRUE) "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                label_design_stock_store_def = data.Rows(i)("label_design").ToString
                Exit For
            End If
        Next
        SLEDesignStockStore.Properties.DataSource = Nothing
        SLEDesignStockStore.Properties.DataSource = data
        SLEDesignStockStore.Properties.DisplayMember = "label_design"
        SLEDesignStockStore.Properties.ValueMember = "id_design"
        If data.Rows.Count.ToString >= 1 Then
            SLEDesignStockStore.EditValue = data.Rows(0)("id_design").ToString
        Else
            SLEDesignStockStore.EditValue = Nothing
        End If
    End Sub

    Private Sub BtnViewStockStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewStockStore.Click
        Cursor = Cursors.WaitCursor

        'Prepare paramater
        date_from_selected_stock_store = "0000-01-01"
        date_until_selected_stock_store = "9999-01-01"
        Try
            date_from_selected_stock_store = DateTime.Parse(DEFromStockStore.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        Try
            date_until_selected_stock_store = DateTime.Parse(DEUntilStockStore.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        Try
            id_design_selected_stock_store = SLEDesignStockStore.EditValue.ToString
            id_store_param_selected = SLEStockStore.EditValue.ToString
        Catch ex As Exception
        End Try

        'set selected
        If id_design_selected_stock_store = "0" Then
            label_design_selected_stock_store = "All Design"
        Else
            label_design_selected_stock_sum = SLEDesignStockStore.Properties.View.GetFocusedRowCellValue("label_design").ToString
        End If

        If id_store_param_selected = "0" Then
            label_store_selected_stock_store = "All Store"
        Else
            label_store_selected_stock_store = SLEStockStore.Properties.View.GetFocusedRowCellValue("comp_name_label").ToString
        End If


        'Prepare Baded
        BGVFGStockStore.Columns.Clear()
        BGVFGStockStore.Bands.Clear()
        BGVFGStockStore.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Dim band_desc As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockStore.Bands.AddBand("DESCRIPTION")
        Dim band_qty As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockStore.Bands.AddBand("QTY")

        ' Make the group footers always visible.
        BGVFGStockStore.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways

        Dim queryx As String = ""
        queryx = "CALL view_stock_fg_store_detail('" + id_design_selected_stock_store + "', '"+id_store_param_selected+"','" + date_from_selected_stock_store + "', '" + date_until_selected_stock_store + "') "
        Dim data As DataTable = execute_query(queryx, -1, True, "", "", "", "")
        For i As Integer = 0 To Data.Columns.Count - 1
            If data.Columns(i).ColumnName.ToString = "Store" Or data.Columns(i).ColumnName.ToString = "id_sample" Or data.Columns(i).ColumnName.ToString = "Code" Or data.Columns(i).ColumnName.ToString = "id_design" Or data.Columns(i).ColumnName.ToString = "Design" Or data.Columns(i).ColumnName.ToString = "design_display_name" Or data.Columns(i).ColumnName.ToString = "uom" Or data.Columns(i).ColumnName.ToString = "Receiving WH Aging" Or data.Columns(i).ColumnName.ToString = "id_design_stock" Or data.Columns(i).ColumnName.ToString = "Age (Day)" Or data.Columns(i).ColumnName.ToString = "id_comp" Or data.Columns(i).ColumnName.ToString = "Product Division" Or data.Columns(i).ColumnName.ToString = "Product Source" Or data.Columns(i).ColumnName.ToString = "Product Branding" Or data.Columns(i).ColumnName.ToString = "Range" Or data.Columns(i).ColumnName.ToString = "Product Counting" Or data.Columns(i).ColumnName.ToString = "Color" Or data.Columns(i).ColumnName.ToString = "id_design_price" Or data.Columns(i).ColumnName.ToString = "Price Type" Or data.Columns(i).ColumnName.ToString = "Price Name" Or data.Columns(i).ColumnName.ToString = "Color" Or data.Columns(i).ColumnName.ToString = "Price" Then
                band_desc.Columns.Add(BGVFGStockStore.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
            Else
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 6
                band_qty.Columns.Add(BGVFGStockStore.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n2}"

                BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n2}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n2}"
                item.ShowInGroupColumnFooter = BGVFGStockStore.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockStore.GroupSummary.Add(item)
            End If
        Next
        GCFGStockStore.DataSource = data
        dt_store = data

        ''hide column
        BGVFGStockStore.Columns("id_sample").Visible = False
        BGVFGStockStore.Columns("id_design").Visible = False
        BGVFGStockStore.Columns("design_display_name").Visible = False
        BGVFGStockStore.Columns("uom").Visible = False
        BGVFGStockStore.Columns("id_design_stock").Visible = False
        BGVFGStockStore.Columns("id_design_price").Visible = False
        BGVFGStockStore.Columns("Product Counting").Visible = False
        BGVFGStockStore.Columns("Range").Visible = False
        BGVFGStockStore.Columns("id_comp").Visible = False

        'Enable Group
        GroupControlStockStore.Enabled = True
        Cursor = Cursors.Default
    End Sub

    '===========================TAB STOCK QC======================================
    Sub viewProductStockQC()
        Dim query As String = ""
        query += "CALL view_design_order(TRUE) "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Rows.Count - 1
            If i = 0 Then
                label_design_stock_qc_def = data.Rows(i)("label_design").ToString
                Exit For
            End If
        Next
        SLEDesignStockQC.Properties.DataSource = Nothing
        SLEDesignStockQC.Properties.DataSource = data

        SLEDesignStockQC.Properties.DisplayMember = "label_design"
        SLEDesignStockQC.Properties.ValueMember = "id_design"
        If data.Rows.Count.ToString >= 1 Then
            SLEDesignStockQC.EditValue = data.Rows(0)("id_design").ToString
        Else
            SLEDesignStockQC.EditValue = Nothing
        End If
        If data.Rows.Count > 0 Then
            GVDesignQC.BestFitColumns()
        End If
    End Sub

    Private Sub BtnViewStockQC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewStockQC.Click
        Cursor = Cursors.WaitCursor

        'Prepare paramater
        date_until_selected_stock_qc = "9999-01-01"

        Try
            date_until_selected_stock_qc = "9999-01-01"
        Catch ex As Exception
        End Try

        Try
            id_design_selected_stock_qc = SLEDesignStockQC.EditValue.ToString
            date_until_selected_stock_qc = DateTime.Parse(DEUntilStockQC.EditValue.ToString).ToString("yyyy-MM-dd")
        Catch ex As Exception
        End Try

        'set selected
        If id_design_selected_stock_qc = "0" Then
            label_design_selected_stock_qc = "All Design"
        Else
            label_design_selected_stock_qc = SLEDesignStockQC.Properties.View.GetFocusedRowCellValue("label_design").ToString
        End If

        'Prepare Baded
        BGVFGStockQC.Columns.Clear()
        BGVFGStockQC.Bands.Clear()
        BGVFGStockQC.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        Dim band_desc As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("DESCRIPTION")
        Dim band_rec As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("RECEIVE QC")
        Dim band_ret_out As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("RETURN OUT")
        Dim band_ret_in As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("RETURN IN")
        Dim band_pl As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("PACKING LIST TO WH")
        'update 18 Agustus 2015
        Dim band_adj_in As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("ADJUSTMENT IN QC")
        Dim band_adj_out As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("ADJUSTMENT OUT QC")
        '
        Dim band_total As DevExpress.XtraGrid.Views.BandedGrid.GridBand = BGVFGStockQC.Bands.AddBand("TOTAL IN QC")
        band_desc.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        band_rec.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        band_ret_out.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        band_ret_in.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        'update 18 Agustus 2015
        band_adj_in.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        band_adj_out.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        '
        band_pl.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)
        band_total.AppearanceHeader.Font = New Font(BGVFGStockQC.Appearance.Row.Font.FontFamily, BGVFGStockQC.Appearance.Row.Font.Size, FontStyle.Bold)

        ' Make the group footers always visible.
        BGVFGStockQC.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways

        Dim queryx As String = ""
        queryx = "CALL view_stock_prod_rec_report('" + id_design_selected_stock_qc + "', '" + date_until_selected_stock_qc + "')"
        Dim data As DataTable = execute_query(queryx, -1, True, "", "", "", "")
        For i As Integer = 0 To data.Columns.Count - 1
            If data.Columns(i).ColumnName.ToString = "id_sample" _
            Or data.Columns(i).ColumnName.ToString = "Code" _
            Or data.Columns(i).ColumnName.ToString = "id_design_master" _
            Or data.Columns(i).ColumnName.ToString = "Design" _
            Or data.Columns(i).ColumnName.ToString = "design_display_name" _
            Or data.Columns(i).ColumnName.ToString = "uom" _
            Or data.Columns(i).ColumnName.ToString = "Receiving WH Aging" _
            Or data.Columns(i).ColumnName.ToString = "Product Division" _
            Or data.Columns(i).ColumnName.ToString = "Product Source" _
            Or data.Columns(i).ColumnName.ToString = "Product Branding" _
            Or data.Columns(i).ColumnName.ToString = "Range" _
            Or data.Columns(i).ColumnName.ToString = "Product Counting" _
            Or data.Columns(i).ColumnName.ToString = "Color" _
            Or data.Columns(i).ColumnName.ToString = "id_season" _
            Or data.Columns(i).ColumnName.ToString = "Season" _
            Or data.Columns(i).ColumnName.ToString = "Delivery" _
            Or data.Columns(i).ColumnName.ToString = "id_prod_order" _
            Or data.Columns(i).ColumnName.ToString = "id_prod_order_det" _
            Or data.Columns(i).ColumnName.ToString = "id_design" _
            Or data.Columns(i).ColumnName.ToString = "id_product" _
            Or data.Columns(i).ColumnName.ToString = "Product Category" _
            Or data.Columns(i).ColumnName.ToString = "Product Class" _
            Or data.Columns(i).ColumnName.ToString = "Product Subcategory" _
            Or data.Columns(i).ColumnName.ToString = "Product Type" _
            Or data.Columns(i).ColumnName.ToString = "Order Number" _
            Or data.Columns(i).ColumnName.ToString = "Color" Then
                band_desc.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
                If data.Columns(i).ColumnName.ToString = "Design" Then
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).FieldNameSortGroup = "id_design"
                ElseIf data.Columns(i).ColumnName.ToString = "Season" Then
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).FieldNameSortGroup = "id_season"
                ElseIf data.Columns(i).ColumnName.ToString = "Delivery" Then
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).FieldNameSortGroup = "id_delivery"
                ElseIf data.Columns(i).ColumnName.ToString = "Order Number" Then
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).FieldNameSortGroup = "id_prod_order"
                End If
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_rec") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 4
                band_rec.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_ret_out") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 8
                band_ret_out.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_ret_in") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 7
                band_ret_in.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0 }"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_pl") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 3
                band_pl.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_adj_in") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 7
                band_adj_in.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            ElseIf data.Columns(i).ColumnName.ToString.Contains("_adj_out") Then
                Dim st_caption As String = data.Columns(i).ColumnName.ToString.Length - 8
                band_adj_out.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString.Substring(0, st_caption)))
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                item.FieldName = data.Columns(i).ColumnName.ToString
                item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                item.DisplayFormat = "{0:n0}"
                item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                BGVFGStockQC.GroupSummary.Add(item)
            Else
                If data.Columns(i).ColumnName.ToString = "Unit Cost" Or data.Columns(i).ColumnName.ToString = "Amount" Then
                    band_total.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n2}"

                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n2}"

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                    item.FieldName = data.Columns(i).ColumnName.ToString
                    item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    item.DisplayFormat = "{0:n2}"
                    item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                    BGVFGStockQC.GroupSummary.Add(item)
                Else
                    band_total.Columns.Add(BGVFGStockQC.Columns.AddVisible(data.Columns(i).ColumnName.ToString, data.Columns(i).ColumnName.ToString))
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).DisplayFormat.FormatString = "{0:n0}"

                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString).SummaryItem.DisplayFormat = "{0:n0}"

                    Dim item As DevExpress.XtraGrid.GridGroupSummaryItem = New DevExpress.XtraGrid.GridGroupSummaryItem()
                    item.FieldName = data.Columns(i).ColumnName.ToString
                    item.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    item.DisplayFormat = "{0:n0}"
                    item.ShowInGroupColumnFooter = BGVFGStockQC.Columns(data.Columns(i).ColumnName.ToString)
                    BGVFGStockQC.GroupSummary.Add(item)
                End If
            End If
            progres_bar_update(i, data.Columns.Count - 1)
        Next

        GCFGStockQC.DataSource = data
        dt_qc = data

        ''hide column
        BGVFGStockQC.Columns("id_sample").Visible = False
        BGVFGStockQC.Columns("id_design_master").Visible = False
        BGVFGStockQC.Columns("design_display_name").Visible = False
        BGVFGStockQC.Columns("uom").Visible = False
        BGVFGStockQC.Columns("Receiving WH Aging").Visible = False
        BGVFGStockQC.Columns("Product Division").Visible = False
        BGVFGStockQC.Columns("Product Source").Visible = False
        BGVFGStockQC.Columns("Product Branding").Visible = False
        BGVFGStockQC.Columns("Range").Visible = False
        BGVFGStockQC.Columns("Product Counting").Visible = False
        BGVFGStockQC.Columns("id_season").Visible = False
        BGVFGStockQC.Columns("id_prod_order").Visible = False
        BGVFGStockQC.Columns("id_prod_order_det").Visible = False
        BGVFGStockQC.Columns("id_design").Visible = False
        BGVFGStockQC.Columns("id_product").Visible = False
        BGVFGStockQC.Columns("id_delivery").Visible = False
        BGVFGStockQC.Columns("design_cop").Visible = False

        'Enable Group
        GroupControlStockQC.Enabled = True
        If data.Rows.Count > 0 Then
            BGVFGStockQC.BestFitColumns()
        End If
        Cursor = Cursors.Default
    End Sub
    Sub resetViewStockCard()
        id_design_selected = "-1"
        LabelControl5.Text = "-"
        LabelColor.Text = "-"
        LabelDivision.Text = "-"
        LabelBranding.Text = "-"
        LabelSource.Text = "-"
        LabelCurrentPrice.Text = "-"
        LabelPriceType.Text = "-"
        pre_viewImages("2", PictureEdit1, id_design_selected, False)
        GroupControlInfo.Enabled = False
        GroupControlTraccking.Enabled = False
    End Sub

    Private Sub TxtCodeDsgSC_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodeDsgSC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            Dim query As String = "CALL view_all_design_param('AND design_code=''" + TxtCodeDsgSC.Text + "''')"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            If data.Rows.Count = 0 Then
                stopCustom("Design not found !")
                resetViewStockCard()
                TxtCodeDsgSC.Focus()
            Else
                id_design_selected = data.Rows(0)("id_design").ToString.ToUpper
                LabelControl5.Text = data.Rows(0)("design_display_name").ToString.ToUpper
                LabelColor.Text = data.Rows(0)("color").ToString.ToUpper
                LabelDivision.Text = data.Rows(0)("product_division").ToString.ToUpper
                LabelBranding.Text = data.Rows(0)("product_class").ToString.ToUpper + " (" + data.Rows(0)("product_class_display").ToString.ToUpper + ")"
                LabelSource.Text = data.Rows(0)("size_chart").ToString.ToUpper
                LabelCurrentPrice.Text = data.Rows(0)("design_price").ToString.ToUpper
                LabelPriceType.Text = data.Rows(0)("design_price_type").ToString.ToUpper
                pre_viewImages("2", PictureEdit1, id_design_selected, False)
                GroupControlInfo.Enabled = True
                GroupControlTraccking.Enabled = True
                SLEWH.Focus()
                SLEWH.ShowPopup()
            End If
            GCFGStockCard.DataSource = Nothing
            Cursor = Cursors.Default
        Else
            resetViewStockCard()
            GCFGStockCard.DataSource = Nothing
        End If
    End Sub

    Private Sub XTCFGStock_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTCFGStock.SelectedPageChanged
        If XTCFGStock.SelectedTabPageIndex = 0 Then
        ElseIf XTCFGStock.SelectedTabPageIndex = 1 Then
            TxtCodeDsgSC.Focus()
        End If
    End Sub

    Private Sub SLEWH_KeyDown(sender As Object, e As KeyEventArgs) Handles SLEWH.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            DEFrom.Focus()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DEFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles DEFrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            DEUntil.Focus()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub DEUntil_KeyDown(sender As Object, e As KeyEventArgs) Handles DEUntil.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnTracking.Focus()
            viewStockCard()
        End If
    End Sub

    Private Sub SLEWH_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles SLEWH.Closed
        DEFrom.Focus()
    End Sub
End Class