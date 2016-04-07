﻿Public Class FormMarkAssignSingle
    Public id_mark_asg As String = "-1"

    Private Sub FormMarkAssignSingle_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub FormMarkAssignSingle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_mark_type(LEMarkType)
        view_status(LEReportStatus)
        If id_mark_asg <> "-1" Then
            Dim query As String = String.Format("SELECT * FROM tb_mark_asg WHERE id_mark_asg = '{0}'", id_mark_asg)
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

            LEMarkType.EditValue = Nothing
            LEMarkType.ItemIndex = LEMarkType.Properties.GetDataSourceRowIndex("report_mark_type", data.Rows(0)("report_mark_type").ToString())

            LEReportStatus.EditValue = Nothing
            LEReportStatus.ItemIndex = LEReportStatus.Properties.GetDataSourceRowIndex("id_report_status", data.Rows(0)("id_report_status").ToString())
        End If
    End Sub

    Private Sub view_mark_type(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT report_mark_type,report_mark_type_name FROM tb_lookup_report_mark_type"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = Nothing
        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "report_mark_type_name"
        lookup.Properties.ValueMember = "report_mark_type"
        lookup.ItemIndex = 0
    End Sub
    Private Sub view_status(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_report_status,report_status FROM tb_lookup_report_status WHERE id_report_status='2' OR id_report_status='3'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = Nothing
        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "report_status"
        lookup.Properties.ValueMember = "id_report_status"
        lookup.ItemIndex = 0
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Dim query As String = ""
        Dim mark_type, id_report_status As String
        mark_type = LEMarkType.EditValue
        id_report_status = LEReportStatus.EditValue

        If id_mark_asg = "-1" Then
            'new
            query = "INSERT INTO tb_mark_asg(report_mark_type,id_report_status) VALUES('" & mark_type & "','" & id_report_status & "')"
            execute_non_query(query, True, "", "", "", "")
            FormMarkAssign.view_asg()
            Close()
        Else
            'edit
            query = "UPDATE tb_mark_asg SET report_mark_type='" & mark_type & "',id_report_status='" & id_report_status & "' WHERE id_mark_asg='" & id_mark_asg & "'"
            execute_non_query(query, True, "", "", "", "")
            FormMarkAssign.view_asg()
            Close()
        End If
    End Sub
End Class