<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFGTrfNew
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GCFGTrf = New DevExpress.XtraGrid.GridControl()
        Me.GVFGTrf = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnFGTrfNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompNameFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompNameTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnFGTrfDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrepOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoTxtPrepOrder = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumnIdFgTrf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SMPrePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMPrint = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GCFGTrf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFGTrf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoTxtPrepOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GCFGTrf
        '
        Me.GCFGTrf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCFGTrf.Location = New System.Drawing.Point(0, 0)
        Me.GCFGTrf.MainView = Me.GVFGTrf
        Me.GCFGTrf.Name = "GCFGTrf"
        Me.GCFGTrf.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoTxtPrepOrder})
        Me.GCFGTrf.Size = New System.Drawing.Size(674, 385)
        Me.GCFGTrf.TabIndex = 1
        Me.GCFGTrf.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFGTrf})
        '
        'GVFGTrf
        '
        Me.GVFGTrf.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnFGTrfNumber, Me.GridColumnCompNameFrom, Me.GridColumnCompNameTo, Me.GridColumnFGTrfDate, Me.GridColumnStatus, Me.GridColumnPrepOrder, Me.GridColumnIdFgTrf, Me.GridColumnLastUpdate, Me.GridColumnUpdatedBy})
        Me.GVFGTrf.GridControl = Me.GCFGTrf
        Me.GVFGTrf.Name = "GVFGTrf"
        Me.GVFGTrf.OptionsBehavior.ReadOnly = True
        Me.GVFGTrf.OptionsView.ShowGroupPanel = False
        Me.GVFGTrf.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnIdFgTrf, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumnFGTrfNumber
        '
        Me.GridColumnFGTrfNumber.Caption = "Number"
        Me.GridColumnFGTrfNumber.FieldName = "fg_trf_number"
        Me.GridColumnFGTrfNumber.Name = "GridColumnFGTrfNumber"
        Me.GridColumnFGTrfNumber.Visible = True
        Me.GridColumnFGTrfNumber.VisibleIndex = 0
        '
        'GridColumnCompNameFrom
        '
        Me.GridColumnCompNameFrom.Caption = "From"
        Me.GridColumnCompNameFrom.FieldName = "comp_name_from"
        Me.GridColumnCompNameFrom.Name = "GridColumnCompNameFrom"
        Me.GridColumnCompNameFrom.Visible = True
        Me.GridColumnCompNameFrom.VisibleIndex = 1
        '
        'GridColumnCompNameTo
        '
        Me.GridColumnCompNameTo.Caption = "To"
        Me.GridColumnCompNameTo.FieldName = "comp_name_to"
        Me.GridColumnCompNameTo.Name = "GridColumnCompNameTo"
        Me.GridColumnCompNameTo.Visible = True
        Me.GridColumnCompNameTo.VisibleIndex = 2
        '
        'GridColumnFGTrfDate
        '
        Me.GridColumnFGTrfDate.Caption = "Created Date"
        Me.GridColumnFGTrfDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnFGTrfDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnFGTrfDate.FieldName = "fg_trf_date"
        Me.GridColumnFGTrfDate.Name = "GridColumnFGTrfDate"
        Me.GridColumnFGTrfDate.Visible = True
        Me.GridColumnFGTrfDate.VisibleIndex = 4
        '
        'GridColumnStatus
        '
        Me.GridColumnStatus.Caption = "Status"
        Me.GridColumnStatus.FieldName = "report_status"
        Me.GridColumnStatus.Name = "GridColumnStatus"
        Me.GridColumnStatus.Visible = True
        Me.GridColumnStatus.VisibleIndex = 7
        '
        'GridColumnPrepOrder
        '
        Me.GridColumnPrepOrder.Caption = "Prepare Order"
        Me.GridColumnPrepOrder.ColumnEdit = Me.RepoTxtPrepOrder
        Me.GridColumnPrepOrder.FieldName = "sales_order_number"
        Me.GridColumnPrepOrder.Name = "GridColumnPrepOrder"
        Me.GridColumnPrepOrder.Visible = True
        Me.GridColumnPrepOrder.VisibleIndex = 3
        '
        'RepoTxtPrepOrder
        '
        Me.RepoTxtPrepOrder.AutoHeight = False
        Me.RepoTxtPrepOrder.Name = "RepoTxtPrepOrder"
        Me.RepoTxtPrepOrder.NullText = "-"
        '
        'GridColumnIdFgTrf
        '
        Me.GridColumnIdFgTrf.Caption = "Id FG Tef"
        Me.GridColumnIdFgTrf.FieldName = "id_fg_trf"
        Me.GridColumnIdFgTrf.Name = "GridColumnIdFgTrf"
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Updated"
        Me.GridColumnLastUpdate.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnLastUpdate.FieldName = "last_update"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 5
        '
        'GridColumnUpdatedBy
        '
        Me.GridColumnUpdatedBy.Caption = "Updated By"
        Me.GridColumnUpdatedBy.FieldName = "last_user"
        Me.GridColumnUpdatedBy.Name = "GridColumnUpdatedBy"
        Me.GridColumnUpdatedBy.Visible = True
        Me.GridColumnUpdatedBy.VisibleIndex = 6
        '
        'ViewMenu
        '
        Me.ViewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMPrePrint, Me.SMPrint})
        Me.ViewMenu.Name = "ContextMenuStripYM"
        Me.ViewMenu.Size = New System.Drawing.Size(137, 48)
        '
        'SMPrePrint
        '
        Me.SMPrePrint.Name = "SMPrePrint"
        Me.SMPrePrint.Size = New System.Drawing.Size(136, 22)
        Me.SMPrePrint.Text = "Pre Printing"
        '
        'SMPrint
        '
        Me.SMPrint.Name = "SMPrint"
        Me.SMPrint.Size = New System.Drawing.Size(136, 22)
        Me.SMPrint.Text = "Print"
        '
        'FormFGTrfNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 385)
        Me.Controls.Add(Me.GCFGTrf)
        Me.Name = "FormFGTrfNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finished Good Transfer"
        CType(Me.GCFGTrf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFGTrf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoTxtPrepOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCFGTrf As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFGTrf As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnFGTrfNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompNameFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompNameTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFGTrfDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrepOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoTxtPrepOrder As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumnIdFgTrf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViewMenu As ContextMenuStrip
    Friend WithEvents SMPrePrint As ToolStripMenuItem
    Friend WithEvents SMPrint As ToolStripMenuItem
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
End Class
