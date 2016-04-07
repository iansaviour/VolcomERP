﻿Public Class FormDocumentUpload 
    Public is_view As String = "-1"
    Public id_report As String = "0"
    Public report_mark_type As String = "0"

    Dim source_path As String = get_setup_field("upload_dir")
    Private Sub FormDocumentUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If is_view = "1" Then
            PCNav.Visible = False
        End If
        view_file()
    End Sub

    Private Sub BClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BClose.Click
        Close()
    End Sub

    Private Sub Bupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bupload.Click
        FormDocumentUploadDet.id_report = id_report
        FormDocumentUploadDet.report_mark_type = report_mark_type
        FormDocumentUploadDet.ShowDialog()
    End Sub

    Sub view_file()
        Dim query As String = "SELECT id_doc,doc_desc,datetime,'yes' as is_download,CONCAT(id_doc,'_" & report_mark_type & "_" & id_report & "',ext) AS filename FROM tb_doc WHERE report_mark_type='" & report_mark_type & "' AND id_report='" & id_report & "'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        GCFileList.DataSource = data

        If GVFileList.RowCount > 0 Then
            BDelete.Visible = True
        Else
            BDelete.Visible = False
        End If
    End Sub

    Private Sub GVFileList_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVFileList.RowClick

    End Sub

    Private Sub RICE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RICE.Click
        Try
            Dim path As String = Application.StartupPath & "\download\"
            'create directory if not exist
            If Not IO.Directory.Exists(path) Then
                System.IO.Directory.CreateDirectory(path)
            End If
            'download
            My.Computer.Network.DownloadFile(source_path & report_mark_type & "\" & GVFileList.GetFocusedRowCellValue("filename").ToString, path & GVFileList.GetFocusedRowCellValue("doc_desc").ToString & "_" & GVFileList.GetFocusedRowCellValue("filename").ToString, "", "", True, 100, True)
            'open folder
            If IO.File.Exists(path & GVFileList.GetFocusedRowCellValue("doc_desc").ToString & "_" & GVFileList.GetFocusedRowCellValue("filename").ToString) Then
                Dim open_folder As ProcessStartInfo = New ProcessStartInfo()
                open_folder.WindowStyle = ProcessWindowStyle.Maximized
                open_folder.FileName = "explorer.exe"
                open_folder.Arguments = "/select,""" & path & GVFileList.GetFocusedRowCellValue("doc_desc").ToString & "_" & GVFileList.GetFocusedRowCellValue("filename").ToString & """"
                Process.Start(open_folder)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RICE_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RICE.MouseHover
        Cursor = Cursors.Hand
    End Sub

    Private Sub RICE_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RICE.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub GVFileList_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVFileList.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.ListSourceRowIndex + 1).ToString()
        End If
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        Cursor = Cursors.WaitCursor
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to delete this document?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = Windows.Forms.DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Try
                Dim query As String = ""
                query = String.Format("DELETE FROM tb_doc WHERE id_doc = '{0}'", GVFileList.GetFocusedRowCellValue("id_doc"))
                execute_non_query(query, True, "", "", "", "")
                If IO.File.Exists(source_path & report_mark_type & "\" & GVFileList.GetFocusedRowCellValue("filename").ToString) Then
                    IO.File.Delete(source_path & report_mark_type & "\" & GVFileList.GetFocusedRowCellValue("filename").ToString)
                End If
                view_file()
            Catch ex As Exception
                errorConnection()
            End Try
            Cursor = Cursors.Default
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub FormDocumentUpload_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class