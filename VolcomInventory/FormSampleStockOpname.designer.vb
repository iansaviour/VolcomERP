﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSampleStockOpname
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
        Me.GCSOWH = New DevExpress.XtraGrid.GridControl
        Me.GVSOWH = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnFgSoStoreNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnStore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnReportStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnSOStatus = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GCSOWH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSOWH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCSOWH
        '
        Me.GCSOWH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSOWH.Location = New System.Drawing.Point(0, 0)
        Me.GCSOWH.MainView = Me.GVSOWH
        Me.GCSOWH.Name = "GCSOWH"
        Me.GCSOWH.Size = New System.Drawing.Size(807, 492)
        Me.GCSOWH.TabIndex = 2
        Me.GCSOWH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSOWH})
        '
        'GVSOWH
        '
        Me.GVSOWH.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnFgSoStoreNumber, Me.GridColumnStore, Me.GridColumn1, Me.GridColumnLastUpdate, Me.GridColumnReportStatus, Me.GridColumnSOStatus})
        Me.GVSOWH.GridControl = Me.GCSOWH
        Me.GVSOWH.GroupCount = 1
        Me.GVSOWH.Name = "GVSOWH"
        Me.GVSOWH.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSOWH.OptionsView.ShowGroupPanel = False
        Me.GVSOWH.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnSOStatus, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumnFgSoStoreNumber
        '
        Me.GridColumnFgSoStoreNumber.Caption = "Number"
        Me.GridColumnFgSoStoreNumber.FieldName = "sample_so_number"
        Me.GridColumnFgSoStoreNumber.Name = "GridColumnFgSoStoreNumber"
        Me.GridColumnFgSoStoreNumber.Visible = True
        Me.GridColumnFgSoStoreNumber.VisibleIndex = 0
        '
        'GridColumnStore
        '
        Me.GridColumnStore.Caption = "Warehouse"
        Me.GridColumnStore.FieldName = "comp_name_from"
        Me.GridColumnStore.Name = "GridColumnStore"
        Me.GridColumnStore.Visible = True
        Me.GridColumnStore.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Creatd Date"
        Me.GridColumn1.FieldName = "sample_so_date_created"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Update"
        Me.GridColumnLastUpdate.FieldName = "sample_so_last_update"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 3
        '
        'GridColumnReportStatus
        '
        Me.GridColumnReportStatus.Caption = "Status"
        Me.GridColumnReportStatus.FieldName = "report_status"
        Me.GridColumnReportStatus.Name = "GridColumnReportStatus"
        Me.GridColumnReportStatus.Visible = True
        Me.GridColumnReportStatus.VisibleIndex = 4
        '
        'GridColumnSOStatus
        '
        Me.GridColumnSOStatus.Caption = "Stock Opname Status"
        Me.GridColumnSOStatus.FieldName = "lock"
        Me.GridColumnSOStatus.FieldNameSortGroup = "id_lock"
        Me.GridColumnSOStatus.Name = "GridColumnSOStatus"
        Me.GridColumnSOStatus.Visible = True
        Me.GridColumnSOStatus.VisibleIndex = 5
        '
        'FormSampleStockOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 492)
        Me.Controls.Add(Me.GCSOWH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSampleStockOpname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Opname Sample"
        CType(Me.GCSOWH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSOWH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCSOWH As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSOWH As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnFgSoStoreNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReportStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSOStatus As DevExpress.XtraGrid.Columns.GridColumn
End Class
