﻿Public Class FormFGCodeReplaceWHDet 
    Public action As String = "-1"
    Public id_fg_code_replace_wh As String = "-1"
    Public id_report_status As String = "-1"
    Public id_fg_code_replace_wh_det_list As New List(Of String)

    Private Sub FormFGCodeReplaceWHDet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewReportStatus()
        actionLoad()
    End Sub

    Private Sub FormFGCodeReplaceWHDet_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Sub actionLoad()
        If action = "ins" Then
            TxtNumber.Text = header_number_sales("19")
            BtnPrint.Enabled = False
            BMark.Enabled = False
            DEForm.Text = view_date(0)
            viewDetail()
            GroupControlListItem.Enabled = True
            check_but()

            'visible column counting
            GridColumnCountingStart.Visible = False
            GridColumnCountingEnd.Visible = False
        ElseIf action = "upd" Then
            GroupControlListItem.Enabled = True
            GVItemList.OptionsBehavior.AutoExpandAllGroups = True

            'visible column counting
            GridColumnCountingStart.Visible = False
            GridColumnCountingEnd.Visible = False

            'query view based on edit id's
            Dim query_c As ClassFGCodeReplace = New ClassFGCodeReplace()
            Dim query As String = query_c.queryMainWH("AND rep.id_fg_code_replace_wh=''" + id_fg_code_replace_wh + "'' ", "1")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            id_fg_code_replace_wh = data.Rows(0)("id_fg_code_replace_wh").ToString
            id_report_status = data.Rows(0)("id_report_status").ToString
            LEReportStatus.ItemIndex = LEReportStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString)
            TxtNumber.Text = data.Rows(0)("fg_code_replace_wh_number").ToString
            DEForm.Text = view_date_from(data.Rows(0)("fg_code_replace_wh_datex").ToString, 0)
            MENote.Text = data.Rows(0)("fg_code_replace_wh_note").ToString

            'detail2
            viewDetail()
            check_but()
            allow_status()
        End If
    End Sub

    Sub viewReportStatus()
        Dim query As String = "SELECT * FROM tb_lookup_report_status a ORDER BY a.id_report_status "
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        viewLookupQuery(LEReportStatus, query, 0, "report_status", "id_report_status")
    End Sub

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
        Else
            BtnEdit.Enabled = False
            BtnDel.Enabled = False
        End If
    End Sub

    Sub viewDetail()
        Dim id_param As String = ""
        Dim query_c As ClassFGCodeReplace = New ClassFGCodeReplace()
        Dim query As String = query_c.queryDetailWH(id_fg_code_replace_wh)
        Dim data As DataTable = execute_query(query, "-1", True, "", "", "", "")
        If action = "upd" Then
            For i As Integer = 0 To (data.Rows.Count - 1)
                id_fg_code_replace_wh_det_list.Add(data.Rows(i)("id_fg_code_replace_wh_det").ToString)
            Next
        End If
        GCItemList.DataSource = data
    End Sub

    Sub allow_status()
        If check_edit_report_status(id_report_status, "68", id_fg_code_replace_wh) Then
            GVItemList.OptionsBehavior.Editable = True
            GVItemList.OptionsCustomization.AllowGroup = False
            MENote.Properties.ReadOnly = False
            GVItemList.OptionsCustomization.AllowGroup = False
            BtnSave.Enabled = True
            PanelControlNav.Enabled = True
            GVItemList.OptionsCustomization.AllowGroup = False
        Else
            GVItemList.OptionsBehavior.Editable = False
            GVItemList.OptionsCustomization.AllowGroup = True
            MENote.Properties.ReadOnly = True
            GVItemList.OptionsCustomization.AllowGroup = True
            BtnSave.Enabled = False
            PanelControlNav.Enabled = False
            GVItemList.OptionsCustomization.AllowGroup = True
        End If

        If id_report_status = "6" Then
            GridColumnCountingStart.Visible = True
            GridColumnCountingEnd.Visible = True
        Else
            GridColumnCountingStart.Visible = False
            GridColumnCountingEnd.Visible = False
        End If

        If check_print_report_status(id_report_status) Then
            BtnPrint.Enabled = True
        Else
            BtnPrint.Enabled = False
        End If
    End Sub


    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Cursor = Cursors.WaitCursor
        FormFGCodeReplaceWHSingle.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = Windows.Forms.DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            GVItemList.DeleteRow(GVItemList.FocusedRowHandle)
            GCItemList.RefreshDataSource()
            GVItemList.RefreshData()
            check_but()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Cursor = Cursors.WaitCursor
        makeSafeGV(GVItemList)
        ValidateChildren()

        If Not formIsValidInGroup(EPForm, GroupGeneralHeader) Then
            errorInput()
        ElseIf GVItemList.RowCount < 1 Then
            stopCustom("Item list can't blank !")
        Else
            Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to save changes this data ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If confirm = Windows.Forms.DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                Dim fg_code_replace_wh_number As String = TxtNumber.Text
                Dim fg_code_replace_wh_note As String = MENote.Text
                Dim id_report_status As String = LEReportStatus.EditValue

                If action = "ins" Then
                    'Main tbale
                    Dim query As String = "INSERT INTO tb_fg_code_replace_wh(fg_code_replace_wh_number, fg_code_replace_wh_date, fg_code_replace_wh_note, id_report_status) "
                    query += "VALUES('" + fg_code_replace_wh_number + "', NOW(), '" + fg_code_replace_wh_note + "', '" + id_report_status + "'); SELECT LAST_INSERT_ID(); "
                    id_fg_code_replace_wh = execute_query(query, 0, True, "", "", "", "")

                    increase_inc_sales("19")

                    'insert who prepared
                    insert_who_prepared("68", id_fg_code_replace_wh, id_user)

                    'Detail 
                    Dim jum_i As Integer = 0
                    Dim query_detail As String = ""
                    If GVItemList.RowCount > 0 Then
                        query_detail = "INSERT INTO tb_fg_code_replace_wh_det(id_fg_code_replace_wh,id_product,fg_code_replace_wh_det_qty,counting_start,counting_end) VALUES "
                    End If
                    For i As Integer = 0 To ((GVItemList.RowCount - 1) - (GetGroupRowCount(GVItemList)))
                        Dim id_product As String = GVItemList.GetRowCellValue(i, "id_product").ToString
                        Dim fg_code_replace_wh_det_qty As String = decimalSQL(GVItemList.GetRowCellValue(i, "fg_code_replace_wh_det_qty").ToString)
                        Dim counting_start As String = GVItemList.GetRowCellValue(i, "counting_start").ToString
                        Dim counting_end As String = GVItemList.GetRowCellValue(i, "counting_end").ToString

                        If jum_i > 0 Then
                            query_detail += ", "
                        End If
                        query_detail += "('" + id_fg_code_replace_wh + "', '" + id_product + "', '" + fg_code_replace_wh_det_qty + "', '" + counting_start + "', '" + counting_end + "') "
                        jum_i = jum_i + 1
                    Next
                    If GVItemList.RowCount > 0 Then
                        execute_non_query(query_detail, True, "", "", "", "")
                    End If
                ElseIf action = "upd" Then
                    Dim query As String = "UPDATE tb_fg_code_replace_wh SET fg_code_replace_wh_note='" + fg_code_replace_wh_note + "' WHERE id_fg_code_replace_wh='" + id_fg_code_replace_wh + "' "
                    execute_non_query(query, True, "", "", "", "")

                    'edit detail table
                    Dim jum_i As Integer = 0
                    Dim query_detail As String = ""
                    If GVItemList.RowCount > 0 Then
                        query_detail = "INSERT INTO tb_fg_code_replace_wh_det(id_fg_code_replace_wh,id_product,fg_code_replace_wh_det_qty,counting_start,counting_end) VALUES "
                    End If
                    For i As Integer = 0 To ((GVItemList.RowCount - 1) - (GetGroupRowCount(GVItemList)))
                        Dim id_fg_code_replace_wh_det As String = GVItemList.GetRowCellValue(i, "id_fg_code_replace_wh_det").ToString
                        Dim id_product As String = GVItemList.GetRowCellValue(i, "id_product").ToString
                        Dim fg_code_replace_wh_det_qty As String = decimalSQL(GVItemList.GetRowCellValue(i, "fg_code_replace_wh_det_qty").ToString)
                        Dim counting_start As String = GVItemList.GetRowCellValue(i, "counting_start").ToString
                        Dim counting_end As String = GVItemList.GetRowCellValue(i, "counting_end").ToString

                        If id_fg_code_replace_wh_det = "0" Then
                            If jum_i > 0 Then
                                query_detail += ", "
                            End If
                            query_detail += "('" + id_fg_code_replace_wh + "', '" + id_product + "', '" + fg_code_replace_wh_det_qty + "', '" + counting_start + "', '" + counting_end + "') "
                            jum_i = jum_i + 1
                        Else
                            'tidak ada yang diedit
                            'Dim query_edit As String = "UPDATE tb_fg_code_replace_wh_det SET WHERE id_sample_order_det = '" + id_sample_order_det + "' "
                            'execute_non_query(query_edit, True, "", "", "", "")
                            id_fg_code_replace_wh_det_list.Remove(id_fg_code_replace_wh_det)
                        End If
                    Next
                    If GVItemList.RowCount > 0 And jum_i > 0 Then
                        execute_non_query(query_detail, True, "", "", "", "")
                    End If

                    'delete sisa
                    For k As Integer = 0 To (id_fg_code_replace_wh_det_list.Count - 1)
                        Try
                            Dim querydel As String = "DELETE FROM tb_fg_code_replace_wh_det WHERE id_fg_code_replace_wh_det = '" + id_fg_code_replace_wh_det_list(k) + "' "
                            execute_non_query(querydel, True, "", "", "", "")
                        Catch ex As Exception
                            ex.ToString()
                        End Try
                    Next
                End If

                FormFGCodeReplace.viewCodeReplaceWH()
                FormFGCodeReplace.GVFGCodeReplaceWH.FocusedRowHandle = find_row(FormFGCodeReplace.GVFGCodeReplaceWH, "id_fg_code_replace_wh", id_fg_code_replace_wh)
                Cursor = Cursors.Default
                Close()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Cursor = Cursors.WaitCursor
        ReportFGCodeReplaceWH.id_report = id_fg_code_replace_wh
        ReportFGCodeReplaceWH.dt = GCItemList.DataSource
        Dim Report As New ReportFGCodeReplaceWH()

        ' '... 
        ' ' creating and saving the view's layout to a new memory stream 
        Dim str As System.IO.Stream
        str = New System.IO.MemoryStream()
        GVItemList.SaveLayoutToStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Report.GridView1.RestoreLayoutFromStream(str, DevExpress.Utils.OptionsLayoutBase.FullLayout)
        str.Seek(0, System.IO.SeekOrigin.Begin)

        'Grid Detail
        ReportStyleGridview(Report.GridView1)

        Report.LabelNo.Text = TxtNumber.Text
        Report.LabelDate.Text = DEForm.Text
        Report.LabelNote.Text = MENote.Text

        'Show the report's preview. 
        Dim Tool As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(Report)
        Tool.ShowPreview()
        Cursor = Cursors.Default
    End Sub

    Private Sub BMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMark.Click
        Cursor = Cursors.WaitCursor
        FormReportMark.report_mark_type = "68"
        FormReportMark.id_report = id_fg_code_replace_wh
        FormReportMark.form_origin = Name
        FormReportMark.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub GVItemList_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVItemList.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub BtnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cursor = Cursors.WaitCursor
        FormDocumentUpload.report_mark_type = "68"
        FormDocumentUpload.id_report = id_fg_code_replace_wh
        FormDocumentUpload.ShowDialog()
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click

    End Sub
End Class