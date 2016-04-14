﻿Public Class FormMatRecWODet
    Public id_order As String = "-1"
    Public id_receive As String = "-1"
    Public id_comp_from As String = "-1"
    Public id_comp_to As String = "-1"
    Dim mat_wo_rec_det_qty_inp As Decimal

    Private Sub FormMatRecWODet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not id_order = "-1" Then
            view_list_purchase()
            view_po()
            GConListPurchase.Enabled = True
        End If

        view_report_status(LEReportStatus)
        viewComp()

        If id_receive = "-1" Then
            'new
            TERecDate.Text = view_date(0)
            TERecNumber.Text = header_number_mat("4")
            BShowOrder.Enabled = True
            BPrint.Visible = False
            BMark.Visible = False
            mat_wo_rec_det_qty_inp = 0.0
        Else
            'edit
            Dim order_created As String
            Dim query = "SELECT a.id_report_status,a.mat_wo_rec_note,b.id_comp_contact_to as id_comp_from,b.id_mat_wo,a.id_comp_contact_to as id_comp_to,g.season,a.id_mat_wo_rec,a.mat_wo_rec_number,DATE_FORMAT(b.mat_wo_date,'%Y-%m-%d') as mat_wo_datex,b.mat_wo_lead_time,a.delivery_order_date,a.delivery_order_number,b.mat_wo_number,DATE_FORMAT(a.mat_wo_rec_date,'%Y-%m-%d') AS mat_wo_rec_date, f.comp_name AS comp_from,d.comp_name AS comp_to "
            query += " ,drw.id_wh_drawer,rck.id_wh_rack,loc.id_wh_locator,comp.id_comp "
            query += "FROM tb_mat_wo_rec a INNER JOIN tb_mat_wo b ON a.id_mat_wo=b.id_mat_wo "
            query += "INNER JOIN tb_m_comp_contact c ON c.id_comp_contact=a.id_comp_contact_to "
            query += "INNER JOIN tb_m_comp d ON d.id_comp=c.id_comp "
            query += "INNER JOIN tb_m_comp_contact e ON e.id_comp_contact=b.id_comp_contact_to "
            query += "INNER JOIN tb_m_comp f ON f.id_comp=e.id_comp "
            query += "INNER JOIN tb_season_delivery h ON b.id_delivery=h.id_delivery "
            query += "INNER JOIN tb_season g ON g.id_season=h.id_season "
            query += "LEFT JOIN tb_m_wh_drawer drw ON drw.id_wh_drawer = a.id_wh_drawer "
            query += "LEFT JOIN tb_m_wh_rack rck ON rck.id_wh_rack = drw.id_wh_rack "
            query += "LEFT JOIN tb_m_wh_locator loc ON loc.id_wh_locator = rck.id_wh_locator "
            query += "LEFT JOIN tb_m_comp comp ON comp.id_comp = loc.id_comp WHERE a.id_mat_wo_rec='" & id_receive & "' "
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

            Try
                SLEStorage.EditValue = data.Rows(0)("id_comp").ToString
                SLELocator.EditValue = data.Rows(0)("id_wh_locator").ToString
                SLERack.EditValue = data.Rows(0)("id_wh_rack").ToString
                SLEDrawer.EditValue = data.Rows(0)("id_wh_drawer").ToString
            Catch ex As Exception
            End Try

            TEPONumber.Text = data.Rows(0)("mat_wo_number").ToString
            TEDONumber.Text = data.Rows(0)("delivery_order_number").ToString
            TERecNumber.Text = data.Rows(0)("mat_wo_rec_number").ToString

            id_order = data.Rows(0)("id_mat_wo").ToString
            id_comp_from = data.Rows(0)("id_comp_from").ToString
            TECompName.Text = data.Rows(0)("comp_from").ToString
            id_comp_to = data.Rows(0)("id_comp_to").ToString
            TECompShipToName.Text = data.Rows(0)("comp_to").ToString

            order_created = data.Rows(0)("mat_wo_datex").ToString
            TEOrderDate.Text = view_date_from(order_created, 0)
            TEEstRecDate.Text = view_date_from(order_created, Integer.Parse(data.Rows(0)("mat_wo_lead_time").ToString))

            TERecDate.Text = view_date_from(data.Rows(0)("mat_wo_rec_date").ToString, 0)

            Dim tgl_delivery() As String = data.Rows(0)("delivery_order_date").ToString.Split(" ")
            TEDODate.Text = tgl_delivery(0)

            LEReportStatus.EditValue = Nothing
            LEReportStatus.ItemIndex = LEReportStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)

            MENote.Text = data.Rows(0)("mat_wo_rec_note").ToString

            BShowOrder.Enabled = False
            GConListPurchase.Enabled = True

            TERecNumber.Enabled = False
            view_list_rec()
        End If
        allow_status()
        view_list_pcs()
    End Sub

    'view company
    Sub viewComp()
        Dim query As String = "SELECT * FROM tb_m_comp a "
        query += "INNER JOIN tb_m_comp_cat b ON a.id_comp_cat = b.id_comp_cat "
        query += "INNER JOIN tb_m_wh_locator c ON a.id_comp = c.id_comp "
        query += "INNER JOIN tb_m_wh_rack d ON c.id_wh_locator = d.id_wh_locator "
        query += "INNER JOIN tb_m_wh_drawer e ON e.id_wh_rack = d.id_wh_rack "
        query += "GROUP BY a.id_comp ORDER BY comp_number ASC "
        viewSearchLookupQuery(SLEStorage, query, "id_comp", "comp_name", "id_comp")
    End Sub
    'Rekursif Comp-Locator
    Private Sub SLEStorage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLEStorage.EditValueChanged
        viewLoactor()
    End Sub
    Private Sub SLELocator_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLELocator.EditValueChanged
        viewRack()
    End Sub
    Private Sub SLERack_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SLERack.EditValueChanged
        viewDrawer()
    End Sub
    'View Locator
    Sub viewLoactor()
        Dim id_comp As String = ""
        Try
            id_comp = SLEStorage.EditValue.ToString
        Catch ex As Exception
            id_comp = "-1"
        End Try
        Dim query As String = ""
        query = "SELECT * FROM tb_m_wh_locator a WHERE id_comp = '" + id_comp + "'"
        viewSearchLookupQuery(SLELocator, query, "id_wh_locator", "wh_locator", "id_wh_locator")
    End Sub
    'View Rack
    Sub viewRack()
        Dim id_locator As String = ""
        Try
            id_locator = SLELocator.EditValue.ToString
        Catch ex As Exception
            id_locator = "-1"
        End Try
        Dim query As String = "SELECT * FROM tb_m_wh_rack a WHERE id_wh_locator = '" + id_locator + "'"
        viewSearchLookupQuery(SLERack, query, "id_wh_rack", "wh_rack", "id_wh_rack")
    End Sub
    'View Drawer
    Sub viewDrawer()
        Dim id_rack As String = ""
        Try
            id_rack = SLERack.EditValue.ToString
        Catch ex As Exception
            id_rack = "-1"
        End Try
        Dim query As String = "SELECT * FROM tb_m_wh_drawer a WHERE id_wh_rack = '" + id_rack + "'"
        viewSearchLookupQuery(SLEDrawer, query, "id_wh_drawer", "wh_drawer", "id_wh_drawer")
    End Sub

    Private Sub BShowOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BShowOrder.Click
        FormPopUpWOMat.id_wo = id_order
        FormPopUpWOMat.id_pop_up = "1"
        FormPopUpWOMat.ShowDialog()
    End Sub

    Sub view_po()
        Dim query As String = String.Format("SELECT id_report_status,mat_wo_vat,mat_wo_number,id_comp_contact_to,id_comp_contact_ship_to,id_ovh,id_payment,DATE_FORMAT(mat_wo_date,'%Y-%m-%d') as mat_wo_datex,mat_wo_lead_time,mat_wo_top,id_currency,mat_wo_note FROM tb_mat_wo WHERE id_mat_wo = '{0}'", id_order)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        TEPONumber.Text = data.Rows(0)("mat_wo_number").ToString

        id_comp_to = data.Rows(0)("id_comp_contact_ship_to").ToString
        TECompName.Text = get_company_x(get_id_company(data.Rows(0)("id_comp_contact_to").ToString), "1")
        TECompShipToName.Text = get_company_x(get_id_company(data.Rows(0)("id_comp_contact_ship_to").ToString), "1")

        TEOrderDate.Text = view_date_from(data.Rows(0)("mat_wo_datex").ToString, 0)
        TEEstRecDate.Text = view_date_from(data.Rows(0)("mat_wo_datex").ToString, Integer.Parse(data.Rows(0)("mat_wo_lead_time").ToString))
    End Sub

    Sub view_list_rec()
        Dim query = "CALL view_wo_rec_mat_det('" & id_receive & "')"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCListPurchase.DataSource = data
    End Sub

    Sub view_list_purchase()
        Dim query = "CALL view_wo_mat_det_limit('" & id_order & "')"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCListPurchase.DataSource = data
    End Sub

    Sub view_list_pcs()
        Dim query = "CALL view_wo_rec_mat_pcs('" & id_receive & "')"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCRoll.DataSource = data
        calculate_qty_rec()
    End Sub

    Sub view_report_status(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_report_status,report_status FROM tb_lookup_report_status"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "report_status"
        lookup.Properties.ValueMember = "id_report_status"
        lookup.ItemIndex = 0
    End Sub

    Private Sub TERecNumber_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TERecNumber.Validating
        Dim query_jml As String
        query_jml = String.Format("SELECT COUNT(id_mat_wo_rec) FROM tb_mat_wo_rec WHERE mat_wo_rec_number='{0}' AND id_mat_wo_rec!='{1}'", TERecNumber.Text, id_receive)
        Dim jml As Integer = execute_query(query_jml, 0, True, "", "", "", "")
        If Not jml < 1 Then
            EP_TE_already_used(EPSampleRec, TERecNumber, "1")
        Else
            EP_TE_cant_blank(EPSampleRec, TERecNumber)
        End If
    End Sub

    Private Sub FormSampleReceiveDet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMark.Click
        FormReportMark.id_report = id_receive
        FormReportMark.report_mark_type = "17"
        FormReportMark.ShowDialog()
    End Sub

    Sub allow_status()
        If LEReportStatus.EditValue = "3" Or LEReportStatus.EditValue = "4" Or LEReportStatus.EditValue = "6" Or LEReportStatus.EditValue = "7" Then
            BPrint.Enabled = True
            BSave.Enabled = False
            'ColQty.Visible = False
            PCRoll.Visible = False
            GVRoll.OptionsBehavior.ReadOnly = True
            '
            MENote.Properties.ReadOnly = True
            TEDODate.Properties.ReadOnly = True
            TEDONumber.Properties.ReadOnly = True
            '
            GVListPurchase.OptionsBehavior.ReadOnly = True
            '
            SLEDrawer.Enabled = False
            SLERack.Enabled = False
            SLELocator.Enabled = False
            SLEStorage.Enabled = False
        ElseIf LEReportStatus.EditValue = "5" Then
            GConListPurchase.Enabled = False
            BSave.Enabled = False
            BMark.Enabled = False
            '
            PCRoll.Visible = False
            GVRoll.OptionsBehavior.ReadOnly = True
            '
            MENote.Properties.ReadOnly = True
            TEDODate.Properties.ReadOnly = True
            TEDONumber.Properties.ReadOnly = True
            '
            GVListPurchase.OptionsBehavior.ReadOnly = True
            '
            SLEDrawer.Enabled = False
            SLERack.Enabled = False
            SLELocator.Enabled = False
            SLEStorage.Enabled = False
        Else
            If Not check_edit_report_status(LEReportStatus.EditValue, "17", id_receive) Then
                BSave.Enabled = False
                '
                PCRoll.Visible = False
                GVRoll.OptionsBehavior.ReadOnly = True
            Else
                BSave.Enabled = True
                '
                PCRoll.Visible = True
                GVRoll.OptionsBehavior.ReadOnly = False
            End If
            BPrint.Enabled = False
            'PanelControlStorageNav.Visible = False
            'GridColumnQtyStored.Visible = False
            'ColQty.Visible = True
            ' ColQty.VisibleIndex = 4
            '
            MENote.Properties.ReadOnly = False
            TEDODate.Properties.ReadOnly = False
            TEDONumber.Properties.ReadOnly = False
            '
            GVListPurchase.OptionsBehavior.ReadOnly = False
            '
            SLEDrawer.Enabled = True
            SLERack.Enabled = True
            SLELocator.Enabled = True
            SLEStorage.Enabled = True
        End If
    End Sub


    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        '
        ReportMatRecWO.id_receive = id_receive

        Dim Report As New ReportMatRecWO()
        ' Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreview()
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Dim query As String = ""
        Dim err_txt As String = ""
        Dim rec_number, rec_date, do_number, do_date, rec_note, rec_stats, id_wh_drawer As String
        Dim id_rec_new As String

        ValidateChildren()

        rec_number = ""
        rec_date = ""
        do_number = ""
        do_date = ""
        rec_note = ""
        rec_stats = ""
        id_wh_drawer = ""

        'validasi
        Try
            rec_number = TERecNumber.Text
            rec_date = TERecDate.Text
            do_number = TEDONumber.Text
            do_date = DateTime.Parse(TEDODate.EditValue.ToString).ToString("yyyy-MM-dd")
            If do_date = "" Then
                do_date = "0000-00-00"
            Else
                do_date = DateTime.Parse(TEDODate.EditValue.ToString).ToString("yyyy-MM-dd")
            End If
            rec_note = MENote.Text
            rec_stats = LEReportStatus.EditValue
            id_wh_drawer = SLEDrawer.EditValue.ToString
        Catch ex As Exception
            err_txt = "1"
        End Try

        For i As Integer = 0 To GVListPurchase.RowCount - 1
            Try
                If GVListPurchase.GetRowCellValue(i, "id_mat_wo_det").ToString = "" Then
                    err_txt = "1"
                End If
            Catch ex As Exception
            End Try
        Next
        If id_receive = "-1" Then
            'new
            If err_txt = "1" Or Not formIsValidInGroup(EPSampleRec, GroupGeneralHeader) Or id_order = "-1" Then
                errorInput()
            Else
                Try
                    'insert rec
                    query = String.Format("INSERT INTO tb_mat_wo_rec(id_mat_wo,mat_wo_rec_number,delivery_order_number,delivery_order_date,mat_wo_rec_date,mat_wo_rec_note,id_report_status,id_comp_contact_to,id_wh_drawer) VALUES('{0}','{1}','{2}','{3}',DATE(NOW()),'{4}','{5}','{6}','{7}'); SELECT LAST_INSERT_ID();", id_order, rec_number, do_number, do_date, rec_note, rec_stats, id_comp_to, id_wh_drawer)

                    id_rec_new = execute_query(query, 0, True, "", "", "", "")
                    increase_inc_mat("4")
                    '
                    'rec detail
                    For i As Integer = 0 To GVListPurchase.RowCount - 1
                        Try
                            If Not GVListPurchase.GetRowCellValue(i, "id_mat_wo_det").ToString = "" And isDecimal(nominalWrite(GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_qty").ToString)) Then
                                query = String.Format("INSERT INTO tb_mat_wo_rec_det(id_mat_wo_det,id_mat_wo_rec,mat_wo_rec_det_qty,mat_wo_rec_det_note) VALUES('{0}','{1}','{2}','{3}')", GVListPurchase.GetRowCellValue(i, "id_mat_wo_det").ToString, id_rec_new, nominalWrite(GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_qty").ToString), GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_note").ToString)
                                execute_non_query(query, True, "", "", "", "")
                            End If
                        Catch ex As Exception
                        End Try
                    Next
                    'roll detail
                    If GVRoll.RowCount > 0 Then
                        query = "INSERT INTO tb_mat_wo_rec_pcs(id_mat_wo_rec,id_mat_det,piece,qty) VALUES"
                        For i As Integer = 0 To GVRoll.RowCount - 1
                            If Not i = 0 Then
                                query += ","
                            End If
                            query += String.Format("('{0}','{1}','{2}','{3}')", id_rec_new, GVRoll.GetRowCellValue(i, "id_mat_det").ToString, GVRoll.GetRowCellValue(i, "piece").ToString, decimalSQL(GVRoll.GetRowCellValue(i, "qty").ToString))
                        Next
                        execute_non_query(query, True, "", "", "", "")
                    End If
                    'insert who prepared
                    insert_who_prepared("17", id_rec_new, id_user)
                    'end insert who prepared
                    FormMatRecWO.view_mat_rec_purc()
                    FormMatRecWO.GVMatRecPurc.FocusedRowHandle = find_row(FormMatRecWO.GVMatRecPurc, "id_mat_wo_rec", id_rec_new)
                    FormMatRecWO.XTCTabReceive.SelectedTabPageIndex = 0
                    Close()
                Catch ex As Exception
                    errorConnection()
                End Try
            End If
        Else
            'edit
            If err_txt = "1" Or Not formIsValidInGroup(EPSampleRec, GroupGeneralHeader) Then
                errorInput()
            Else
                'Try
                'UPDATE rec
                query = String.Format("UPDATE tb_mat_wo_rec SET delivery_order_number='{0}',delivery_order_date='{1}',mat_wo_rec_note='{2}',id_report_status='{3}',id_comp_contact_to='{4}',id_wh_drawer='{6}' WHERE id_mat_wo_rec='{5}'", do_number, do_date, rec_note, rec_stats, id_comp_to, id_receive, id_wh_drawer)
                execute_non_query(query, True, "", "", "", "")
                'rec detail
                For i As Integer = 0 To GVListPurchase.RowCount - 1
                    Try
                        If Not GVListPurchase.GetRowCellValue(i, "id_mat_wo_det").ToString = "" And isDecimal(nominalWrite(GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_qty").ToString)) Then
                            query = String.Format("UPDATE tb_mat_wo_rec_det SET mat_wo_rec_det_qty='{0}',mat_wo_rec_det_note='{1}' WHERE id_mat_wo_rec_det='{2}'", nominalWrite(GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_qty").ToString), GVListPurchase.GetRowCellValue(i, "mat_wo_rec_det_note").ToString, GVListPurchase.GetRowCellValue(i, "id_mat_wo_rec_det").ToString)
                            execute_non_query(query, True, "", "", "", "")
                        End If
                    Catch ex As Exception
                    End Try
                Next

                'roll
                Dim sp_check As Boolean = False
                Dim query_del As String = "SELECT id_mat_wo_rec_pcs FROM tb_mat_wo_rec_pcs WHERE id_mat_wo_rec='" & id_receive & "'"
                Dim data_del As DataTable = execute_query(query_del, -1, True, "", "", "", "")
                If data_del.Rows.Count > 0 Then
                    For i As Integer = 0 To data_del.Rows.Count - 1
                        sp_check = False
                        ' false mean not found, believe me
                        For j As Integer = 0 To GVRoll.RowCount - 1
                            If Not GVRoll.GetRowCellValue(j, "id_mat_wo_rec_pcs").ToString = "" Then
                                '
                                If GVRoll.GetRowCellValue(j, "id_mat_wo_rec_pcs").ToString = data_del.Rows(i)("id_mat_wo_rec_pcs").ToString() Then
                                    sp_check = True
                                End If
                            End If
                        Next
                        'end loop check on gv
                        If sp_check = False Then
                            'Because not found, it's only mean already deleted
                            query = String.Format("DELETE FROM tb_mat_wo_rec_pcs WHERE id_mat_wo_rec_pcs='{0}'", data_del.Rows(i)("id_mat_wo_rec_pcs").ToString())
                            execute_non_query(query, True, "", "", "", "")
                        End If
                    Next
                End If

                For i As Integer = 0 To GVRoll.RowCount - 1
                    If Not GVRoll.GetRowCellValue(i, "id_mat_det").ToString = "" Then
                        If GVRoll.GetRowCellValue(i, "id_mat_wo_rec_pcs").ToString = "" Then
                            'insert new
                            query = String.Format("INSERT INTO tb_mat_wo_rec_pcs(id_mat_wo_rec,id_mat_det,piece,qty) VALUES('{0}','{1}','{2}','{3}')", id_receive, GVRoll.GetRowCellValue(i, "id_mat_det").ToString, GVRoll.GetRowCellValue(i, "piece").ToString, decimalSQL(GVRoll.GetRowCellValue(i, "qty").ToString))
                            execute_non_query(query, True, "", "", "", "")
                        Else
                            'update
                            query = String.Format("UPDATE tb_mat_wo_rec_pcs SET id_mat_det='{0}',piece='{1}',qty='{2}' WHERE id_mat_wo_rec_pcs='{3}'", GVRoll.GetRowCellValue(i, "id_mat_det").ToString, GVRoll.GetRowCellValue(i, "piece").ToString, decimalSQL(GVRoll.GetRowCellValue(i, "qty").ToString), GVRoll.GetRowCellValue(i, "id_mat_wo_rec_pcs").ToString)
                            execute_non_query(query, True, "", "", "", "")
                        End If
                    End If
                Next
                'end of roll

                FormMatRecWO.view_mat_rec_purc()
                FormMatRecWO.GVMatRecPurc.FocusedRowHandle = find_row(FormMatRecWO.GVMatRecPurc, "id_mat_wo_rec", id_receive)
                FormMatRecWO.XTCTabReceive.SelectedTabPageIndex = 0
                Close()
                'Catch ex As Exception
                '    errorConnection()
                'End Try
            End If
        End If
    End Sub

    Private Sub GVListPurchase_ShownEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVListPurchase.ShownEditor
        Try
            mat_wo_rec_det_qty_inp = GVListPurchase.GetFocusedRowCellDisplayText("mat_wo_rec_det_qty").ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSaveToStorage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormMatStorageIn.id_mat_purc_rec_det = GVListPurchase.GetFocusedRowCellDisplayText("id_mat_wo_rec_det").ToString
        FormMatStorageIn.action = "ins"
        FormMatStorageIn.ShowDialog()
    End Sub

    Private Sub GVListPurchase_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVListPurchase.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub
    'Cell Value Changed to resrict qty
    Private Sub RepositoryItemSpinEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim sqty As DevExpress.XtraEditors.SpinEdit = CType(sender, DevExpress.XtraEditors.SpinEdit)
            Dim qty_limit As Decimal = CType(GVListPurchase.GetFocusedRowCellDisplayText("qty").ToString, Decimal)
            Dim qty_rec As Decimal = CType(sqty.EditValue.ToString, Decimal)
            If (qty_rec > qty_limit) Then
                DevExpress.XtraEditors.XtraMessageBox.Show("- Qty issue must be smaller than qty ordered or equal to qty ordered !" + System.Environment.NewLine + "- Not allowed character input !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim qty_bound As Decimal = qty_rec - 1
                If qty_bound < 0 Then
                    qty_bound = 0
                End If
                GVListPurchase.SetFocusedRowCellValue("mat_wo_rec_det_qty", qty_limit.ToString)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TEDODate_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TEDODate.Validating
        If TEDODate.EditValue = Nothing Then
            EPSampleRec.SetError(TEDODate, "Please set delivery order date. ")
        Else
            EPSampleRec.SetError(TEDODate, String.Empty)
        End If
    End Sub

    Private Sub BAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAttach.Click
        Cursor = Cursors.WaitCursor
        FormDocumentUpload.id_report = id_order
        FormDocumentUpload.report_mark_type = "17"
        FormDocumentUpload.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Sub calculate_qty_rec()
        If GVListPurchase.RowCount > 0 Then
            For i As Integer = 0 To GVListPurchase.RowCount - 1
                Dim qty_rec As Decimal = 0.0
                For j As Integer = 0 To GVRoll.RowCount - 1
                    If GVListPurchase.GetRowCellValue(i, "id_mat_det").ToString = GVRoll.GetRowCellValue(j, "id_mat_det").ToString Then
                        qty_rec += GVRoll.GetRowCellValue(j, "qty").ToString
                    End If
                Next
                GVListPurchase.SetRowCellValue(i, "mat_wo_rec_det_qty", qty_rec)
            Next
        End If
        If GVRoll.RowCount > 0 Then
            BDelPieces.Visible = True
        Else
            BDelPieces.Visible = False
        End If
    End Sub
    Private Sub BAddPieces_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddPieces.Click
        If GVListPurchase.RowCount > 0 Then
            Dim id_mat_det As String = GVListPurchase.GetFocusedRowCellValue("id_mat_det").ToString

            Dim newRow As DataRow = (TryCast(GCRoll.DataSource, DataTable)).NewRow()
            newRow("id_mat_det") = GVListPurchase.GetFocusedRowCellValue("id_mat_det").ToString
            newRow("name") = GVListPurchase.GetFocusedRowCellValue("name").ToString
            newRow("code") = GVListPurchase.GetFocusedRowCellValue("code").ToString
            TryCast(GCRoll.DataSource, DataTable).Rows.Add(newRow)
            GCRoll.RefreshDataSource()
            GVRoll.RefreshData()
            GVRoll.FocusedRowHandle = GVRoll.RowCount - 1
            GVRoll.FocusedColumn = GVRoll.Columns("piece")
            GVRoll.ShowEditor()
        End If
    End Sub

    Private Sub GVRoll_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVRoll.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub GVRoll_HiddenEditor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVRoll.HiddenEditor
        If GVRoll.GetFocusedRowCellValue("qty").ToString = "" Then
            GVRoll.SetFocusedRowCellValue("qty", 0)
        End If
        If GVRoll.GetFocusedRowCellValue("piece").ToString = "" Then
            GVRoll.SetFocusedRowCellValue("piece", "-")
        End If
        calculate_qty_rec()
    End Sub
    Private Sub BDelPieces_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelPieces.Click
        If GVRoll.RowCount > 0 Then
            GVRoll.DeleteSelectedRows()
            calculate_qty_rec()
        End If
    End Sub

    Private Sub GVListPurchase_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GVListPurchase.PopupMenuShowing
        If GVListPurchase.RowCount > 0 Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(e.Point)
            If hitInfo.InRow Then
                view.FocusedRowHandle = hitInfo.RowHandle
                BalanceMenu.Show(view.GridControl, e.Point)
            End If
        End If
    End Sub
    Sub refresh_list()
        If id_receive = "-1" Then
            view_list_purchase()
        Else
            view_list_rec()
        End If
    End Sub
    Private Sub SMEditPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMEditPrice.Click
        If GVListPurchase.RowCount > 0 Then
            FormMasterRawMaterialDetSingle.id_mat_det = GVListPurchase.GetFocusedRowCellValue("id_mat_det").ToString
            FormMasterRawMaterialDetSingle.LabelPrintedName.Text = GVListPurchase.GetFocusedRowCellDisplayText("name").ToString
            FormMasterRawMaterialDetSingle.TxtMaterialTypeCode.Text = GVListPurchase.GetFocusedRowCellDisplayText("code").ToString
            FormMasterRawMaterialDetSingle.action = "upd"
            FormMasterRawMaterialDetSingle.id_pop_up = "2"
            FormMasterRawMaterialDetSingle.ShowDialog()
        End If
    End Sub
End Class