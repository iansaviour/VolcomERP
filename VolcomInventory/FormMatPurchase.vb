﻿Public Class FormMatPurchase
    Dim bnew_active As String = "1"
    Dim bedit_active As String = "1"
    Dim bdel_active As String = "1"

    Private Sub FormMatPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_mat_purc()
        'GVMatPurchase.ActiveFilterString = "[id_mat_purc] > 1 AND [id_mat_purc] < 6"
        viewProdDemand()
    End Sub

    Private Sub FormMatPurchase_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        FormMain.show_rb(Name)
        checkFormAccess(Name)
    End Sub

    Private Sub FormMatPurchase_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        FormMain.hide_rb()
    End Sub
    Sub view_mat_purc()
        Dim query = "SELECT IFNULL(rev.mat_purc_number,'-') as mat_purc_rev_number,a.id_report_status,h.report_status,a.id_mat_purc, "
        query += "b.id_season,a.id_delivery,i.delivery, "
        query += "b.season, g.payment,"
        query += "d.comp_name AS comp_name_to, "
        query += "f.comp_name AS comp_name_ship_to, "
        query += "a.mat_purc_number,"
        query += "a.mat_purc_date, "
        query += "DATE_ADD(a.mat_purc_date,INTERVAL a.mat_purc_lead_time DAY) AS mat_purc_lead_time, "
        query += "DATE_ADD(a.mat_purc_date,INTERVAL (a.mat_purc_top+a.mat_purc_lead_time) DAY) AS mat_purc_top "
        query += "FROM tb_mat_purc a INNER JOIN tb_season_delivery i ON a.id_delivery = i.id_delivery "
        query += "INNER JOIN tb_season b ON i.id_season = b.id_season "
        query += "INNER JOIN tb_m_comp_contact c ON a.id_comp_contact_to = c.id_comp_contact "
        query += "INNER JOIN tb_m_comp d ON c.id_comp = d.id_comp "
        query += "INNER JOIN tb_m_comp_contact e ON a.id_comp_contact_ship_to = e.id_comp_contact "
        query += "INNER JOIN tb_m_comp f ON e.id_comp = f.id_comp "
        query += "INNER JOIN tb_lookup_payment g ON a.id_payment = g.id_payment "
        query += "LEFT JOIN tb_mat_purc rev ON rev.id_mat_purc = a.id_mat_purc_rev "
        query += "INNER JOIN tb_lookup_report_status h ON h.id_report_status = a.id_report_status "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCMatPurchase.DataSource = data
        check_menu()
    End Sub
    Sub check_menu()
        If GVMatPurchase.RowCount < 1 Then
            'hide all except new
            bnew_active = "1"
            bedit_active = "0"
            bdel_active = "0"
            checkFormAccess(Name)
            button_main(bnew_active, bedit_active, bdel_active)
            '
        Else
            'show all
            bnew_active = "1"
            bedit_active = "1"
            bdel_active = "1"
            checkFormAccess(Name)
            button_main(bnew_active, bedit_active, bdel_active)
            '
        End If
    End Sub

    Private Sub GVSamplePurchase_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVMatPurchase.FocusedRowChanged
        no_focus_gv(sender, e)
    End Sub

    Sub no_focus_gv(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim focusedRowHandle As Integer = -1
        If e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle OrElse e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle Then
            Return
        End If
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.FocusedRowHandle < 0 Then
            If e.PrevFocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                focusedRowHandle = 0
            ElseIf Control.MouseButtons = MouseButtons.Left OrElse Control.MouseButtons = MouseButtons.Right Then
                focusedRowHandle = e.PrevFocusedRowHandle
            Else
                Dim prevRow As Integer = view.GetVisibleIndex(e.PrevFocusedRowHandle)
                Dim currRow As Integer = view.GetVisibleIndex(e.FocusedRowHandle)
                If prevRow > currRow Then
                    focusedRowHandle = e.PrevFocusedRowHandle - 1
                Else
                    focusedRowHandle = e.PrevFocusedRowHandle + 1
                End If
                If focusedRowHandle < 0 Then
                    focusedRowHandle = 0
                End If
                If focusedRowHandle >= view.DataRowCount Then
                    focusedRowHandle = view.DataRowCount - 1
                End If
            End If
            If focusedRowHandle < 0 Then
                view.FocusedRowHandle = 0
            Else
                view.FocusedRowHandle = focusedRowHandle
            End If
        End If
    End Sub

    Private Sub GVSamplePurchase_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVMatPurchase.CustomColumnDisplayText
        If e.Column.FieldName = "id_delivery" Then
            Dim rowhandle As Integer = e.ListSourceRowIndex
            If GVMatPurchase.IsGroupRow(rowhandle) Then
                rowhandle = GVMatPurchase.GetDataRowHandleByGroupRowHandle(rowhandle)
                e.DisplayText = GVMatPurchase.GetRowCellDisplayText(rowhandle, "delivery")
            End If
        End If
        If e.Column.FieldName = "id_season" Then
            Dim rowhandle As Integer = e.ListSourceRowIndex
            If GVMatPurchase.IsGroupRow(rowhandle) Then
                rowhandle = GVMatPurchase.GetDataRowHandleByGroupRowHandle(rowhandle)
                e.DisplayText = GVMatPurchase.GetRowCellDisplayText(rowhandle, "season")
            End If
        End If
    End Sub
    '========= from PD =============
    Sub viewProdDemand()
        Dim query As String = "SELECT *,c.report_status FROM tb_prod_demand a "
        query += "INNER JOIN tb_season b ON a.id_season = b.id_season "
        query += "INNER JOIN tb_lookup_report_status c ON c.id_report_status = a.id_report_status "
        query += "ORDER BY a.id_prod_demand DESC "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCProdDemand.DataSource = data
        GVProdDemand.Columns("season").GroupIndex = 0
        If data.Rows.Count > 0 Then
            GVProdDemand.FocusedRowHandle = 0
            view_product()
            'show all
            bnew_active = "1"
            bedit_active = "1"
            bdel_active = "1"
        Else
            'hide all except new
            bnew_active = "1"
            bedit_active = "0"
            bdel_active = "0"
        End If
        checkFormAccess(Name)
        button_main(bnew_active, bedit_active, bdel_active)
    End Sub
    Private Sub GVProdDemand_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVProdDemand.FocusedRowChanged
        Dim focusedRowHandle As Integer = -1
        If e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle OrElse e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle Then
            Return
        End If
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.FocusedRowHandle < 0 Then
            If e.PrevFocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                focusedRowHandle = 0
            ElseIf Control.MouseButtons = MouseButtons.Left OrElse Control.MouseButtons = MouseButtons.Right Then
                focusedRowHandle = e.PrevFocusedRowHandle
            Else
                Dim prevRow As Integer = view.GetVisibleIndex(e.PrevFocusedRowHandle)
                Dim currRow As Integer = view.GetVisibleIndex(e.FocusedRowHandle)
                If prevRow > currRow Then
                    focusedRowHandle = e.PrevFocusedRowHandle - 1
                Else
                    focusedRowHandle = e.PrevFocusedRowHandle + 1
                End If
                If focusedRowHandle < 0 Then
                    focusedRowHandle = 0
                End If
                If focusedRowHandle >= view.DataRowCount Then
                    focusedRowHandle = view.DataRowCount - 1
                End If
            End If
            If focusedRowHandle < 0 Then
                view.FocusedRowHandle = 0
            Else
                view.FocusedRowHandle = focusedRowHandle
            End If
        End If
    End Sub
    'Row Click Number
    Private Sub GVProdDemand_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVProdDemand.RowClick
        view_product()
        'checkPrintStatus()
    End Sub

    Sub view_product()
        Try
            Dim id_prod_demand As String = GVProdDemand.GetFocusedRowCellDisplayText("id_prod_demand").ToString
            Dim query As String = "CALL view_prod_demand('" & id_prod_demand & "', 0)"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            GCProduct.DataSource = data
            GVProduct.ClearGrouping()
            GVProduct.Columns("category").GroupIndex = 0
            GVProduct.Columns("design_name").GroupIndex = 1
            GVProduct.ExpandAllGroups()
            '
            If check_print_report_status(GVProdDemand.GetFocusedRowCellDisplayText("id_report_status").ToString) Then
                BCreate.Enabled = True
            Else
                BCreate.Enabled = False
            End If
        Catch ex As Exception
            errorConnection()
        End Try
    End Sub

    Private Sub BCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCreate.Click
        FormProdDemandMat.id_prod_demand = GVProdDemand.GetFocusedRowCellDisplayText("id_prod_demand").ToString
        FormProdDemandMat.is_in_mat = "1"
        FormProdDemandMat.ShowDialog()
    End Sub

    Private Sub GVMatPurchase_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVMatPurchase.DoubleClick
        If GVMatPurchase.RowCount > 0 Then
            FormMatPurchaseDet.id_purc = GVMatPurchase.GetFocusedRowCellDisplayText("id_mat_purc")
            FormMatPurchaseDet.ShowDialog()
        End If
    End Sub
End Class