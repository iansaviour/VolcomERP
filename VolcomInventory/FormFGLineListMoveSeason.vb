﻿Public Class FormFGLineListMoveSeason
    Public id_pop_up As String = "-1"

    Private Sub FormFGLineListMoveSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewSeason()
        viewPlanOrder()
    End Sub

    Sub viewPlanOrder()
        Dim query As String = "SELECT * FROM tb_lookup_status_order ORDER BY id_lookup_status_order ASC"
        viewLookupQuery(LEPlanStatus, query, 0, "lookup_status_order", "id_lookup_status_order")
    End Sub

    Sub viewSeason()
        Dim query As String = "SELECT * FROM tb_season a "
        query += "INNER JOIN tb_range b ON a.id_range = b.id_range "
        query += "WHERE b.id_range >0 "
        If id_pop_up = "3" Then 'non merch
            query += "AND b.is_md='2' AND b.id_departement='" + id_departement_user + "' "
        Else
            query += "AND b.is_md='1' "
        End If
        query += "ORDER BY b.range DESC"
        viewSearchLookupQuery(SLESeason, query, "id_season", "season", "id_season")
    End Sub

    Private Sub LEPlanStatus_EditValueChanged(sender As Object, e As EventArgs) Handles LEPlanStatus.EditValueChanged
        Dim stt As String = "-1"
        Try
            stt = LEPlanStatus.EditValue.ToString
        Catch ex As Exception
        End Try
        If stt <> "3" Then
            LabelSeason.Visible = False
            SLESeason.Visible = False
        Else
            LabelSeason.Visible = True
            SLESeason.Visible = True
        End If
    End Sub

    Private Sub BtnUpdateRec_Click(sender As Object, e As EventArgs) Handles BtnUpdateRec.Click
        Dim confirm As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure want to change line list status for these data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = Windows.Forms.DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Dim id_lookup_status_order As String = LEPlanStatus.EditValue.ToString
            Dim id_season_to As String = SLESeason.EditValue.ToString
            For i As Integer = 0 To ((FormFGLineList.BGVLineList.RowCount - 1) - GetGroupRowCount(FormFGLineList.BGVLineList))
                Dim id_design As String = FormFGLineList.BGVLineList.GetRowCellValue(i, "id_design").ToString
                Dim id_season_from As String = FormFGLineList.BGVLineList.GetRowCellValue(i, "id_season").ToString

                'update line list status
                Dim query_upd As String = "UPDATE tb_m_design SET id_lookup_status_order='" + id_lookup_status_order + "' "
                If id_lookup_status_order = "2" Then 'drop
                    query_upd += ", id_active=2 "
                ElseIf id_lookup_status_order = "3" Then 'move
                    query_upd += ", id_season_move='" + id_season_to + "' "
                End If
                query_upd += "WHERE id_design='" + id_design + "' "
                execute_non_query(query_upd, True, "", "", "", "")


                'update time
                Dim upd As New ClassDesign
                upd.updatedTime(id_design)

                PBC.PerformStep()
                PBC.Update()
            Next
            FormFGLineList.viewLineList()
            Close()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub FormFGLineListMoveSeason_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class