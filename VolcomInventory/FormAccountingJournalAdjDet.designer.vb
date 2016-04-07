﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountingJournalAdjDet
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountingJournalAdjDet))
        Me.LargeImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.EPJournal = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BalanceMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SMBalance = New System.Windows.Forms.ToolStripMenuItem
        Me.GCJournalDet = New DevExpress.XtraGrid.GridControl
        Me.GVJournalDet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.MENote = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.BAddMat = New DevExpress.XtraEditors.SimpleButton
        Me.BDelMat = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BMark = New DevExpress.XtraEditors.SimpleButton
        Me.Bprint = New DevExpress.XtraEditors.SimpleButton
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSave = New DevExpress.XtraEditors.SimpleButton
        Me.PCGeneralheader = New DevExpress.XtraEditors.PanelControl
        Me.BPickJournal = New DevExpress.XtraEditors.SimpleButton
        Me.TEJournalNumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TEUserEntry = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TENumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TEDate = New DevExpress.XtraEditors.TextEdit
        Me.LTransNo = New DevExpress.XtraEditors.LabelControl
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BalanceMenu.SuspendLayout()
        CType(Me.GCJournalDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVJournalDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PCGeneralheader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCGeneralheader.SuspendLayout()
        CType(Me.TEJournalNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEUserEntry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LargeImageCollection
        '
        Me.LargeImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.LargeImageCollection.ImageStream = CType(resources.GetObject("LargeImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImageCollection.Images.SetKeyName(0, "20_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(1, "8_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(2, "23_24x24.png")
        '
        'EPJournal
        '
        Me.EPJournal.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EPJournal.ContainerControl = Me
        '
        'BalanceMenu
        '
        Me.BalanceMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMBalance})
        Me.BalanceMenu.Name = "ContextMenuStripYM"
        Me.BalanceMenu.Size = New System.Drawing.Size(116, 26)
        '
        'SMBalance
        '
        Me.SMBalance.Name = "SMBalance"
        Me.SMBalance.Size = New System.Drawing.Size(115, 22)
        Me.SMBalance.Text = "Balance"
        '
        'GCJournalDet
        '
        Me.GCJournalDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCJournalDet.Location = New System.Drawing.Point(0, 114)
        Me.GCJournalDet.MainView = Me.GVJournalDet
        Me.GCJournalDet.Name = "GCJournalDet"
        Me.GCJournalDet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.GCJournalDet.Size = New System.Drawing.Size(744, 286)
        Me.GCJournalDet.TabIndex = 16
        Me.GCJournalDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVJournalDet})
        '
        'GVJournalDet
        '
        Me.GVJournalDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GVJournalDet.GridControl = Me.GCJournalDet
        Me.GVJournalDet.Name = "GVJournalDet"
        Me.GVJournalDet.OptionsView.ShowFooter = True
        Me.GVJournalDet.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "No."
        Me.GridColumn6.FieldName = "no"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 40
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "IDAcc"
        Me.GridColumn7.FieldName = "id_acc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id Trans"
        Me.GridColumn1.FieldName = "id_acc_trans_adj_det"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Width = 139
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Account"
        Me.GridColumn2.FieldName = "acc_name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Note"
        Me.GridColumn3.FieldName = "note"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 300
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Debit"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn4.DisplayFormat.FormatString = "N2"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "debit"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "debit", "{0:N2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 138
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Mask.EditMask = "N2"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Credit"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemTextEdit2
        Me.GridColumn5.DisplayFormat.FormatString = "N2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "credit"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "credit", "{0:N2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 134
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.EditFormat.FormatString = "N2"
        Me.RepositoryItemTextEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit2.Mask.EditMask = "N2"
        Me.RepositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.MENote)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 400)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(744, 58)
        Me.PanelControl4.TabIndex = 18
        '
        'MENote
        '
        Me.MENote.Location = New System.Drawing.Point(55, 8)
        Me.MENote.Name = "MENote"
        Me.MENote.Size = New System.Drawing.Size(673, 40)
        Me.MENote.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Note"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BAddMat)
        Me.PanelControl3.Controls.Add(Me.BDelMat)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 75)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(744, 39)
        Me.PanelControl3.TabIndex = 17
        '
        'BAddMat
        '
        Me.BAddMat.ImageIndex = 0
        Me.BAddMat.ImageList = Me.LargeImageCollection
        Me.BAddMat.Location = New System.Drawing.Point(644, 5)
        Me.BAddMat.Name = "BAddMat"
        Me.BAddMat.Size = New System.Drawing.Size(91, 29)
        Me.BAddMat.TabIndex = 17
        Me.BAddMat.Text = "Add"
        '
        'BDelMat
        '
        Me.BDelMat.ImageIndex = 1
        Me.BDelMat.ImageList = Me.LargeImageCollection
        Me.BDelMat.Location = New System.Drawing.Point(547, 5)
        Me.BDelMat.Name = "BDelMat"
        Me.BDelMat.Size = New System.Drawing.Size(91, 29)
        Me.BDelMat.TabIndex = 16
        Me.BDelMat.Text = "Delete"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BMark)
        Me.PanelControl2.Controls.Add(Me.Bprint)
        Me.PanelControl2.Controls.Add(Me.BCancel)
        Me.PanelControl2.Controls.Add(Me.BSave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 458)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(744, 39)
        Me.PanelControl2.TabIndex = 15
        '
        'BMark
        '
        Me.BMark.Location = New System.Drawing.Point(9, 8)
        Me.BMark.Name = "BMark"
        Me.BMark.Size = New System.Drawing.Size(75, 23)
        Me.BMark.TabIndex = 21
        Me.BMark.Text = "Mark"
        '
        'Bprint
        '
        Me.Bprint.Location = New System.Drawing.Point(501, 8)
        Me.Bprint.Name = "Bprint"
        Me.Bprint.Size = New System.Drawing.Size(75, 23)
        Me.Bprint.TabIndex = 20
        Me.Bprint.Text = "Print"
        '
        'BCancel
        '
        Me.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancel.Location = New System.Drawing.Point(582, 8)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(70, 23)
        Me.BCancel.TabIndex = 19
        Me.BCancel.Text = "Cancel"
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(658, 8)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(70, 23)
        Me.BSave.TabIndex = 18
        Me.BSave.Text = "Save"
        '
        'PCGeneralheader
        '
        Me.PCGeneralheader.Controls.Add(Me.BPickJournal)
        Me.PCGeneralheader.Controls.Add(Me.TEJournalNumber)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl4)
        Me.PCGeneralheader.Controls.Add(Me.TEUserEntry)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl2)
        Me.PCGeneralheader.Controls.Add(Me.TENumber)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl1)
        Me.PCGeneralheader.Controls.Add(Me.TEDate)
        Me.PCGeneralheader.Controls.Add(Me.LTransNo)
        Me.PCGeneralheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCGeneralheader.Location = New System.Drawing.Point(0, 0)
        Me.PCGeneralheader.Name = "PCGeneralheader"
        Me.PCGeneralheader.Size = New System.Drawing.Size(744, 75)
        Me.PCGeneralheader.TabIndex = 14
        '
        'BPickJournal
        '
        Me.BPickJournal.Location = New System.Drawing.Point(301, 12)
        Me.BPickJournal.Name = "BPickJournal"
        Me.BPickJournal.Size = New System.Drawing.Size(26, 20)
        Me.BPickJournal.TabIndex = 19
        Me.BPickJournal.Text = "..."
        '
        'TEJournalNumber
        '
        Me.TEJournalNumber.Location = New System.Drawing.Point(78, 12)
        Me.TEJournalNumber.Name = "TEJournalNumber"
        Me.TEJournalNumber.Properties.ReadOnly = True
        Me.TEJournalNumber.Size = New System.Drawing.Size(217, 20)
        Me.TEJournalNumber.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Entry"
        '
        'TEUserEntry
        '
        Me.TEUserEntry.Location = New System.Drawing.Point(78, 41)
        Me.TEUserEntry.Name = "TEUserEntry"
        Me.TEUserEntry.Properties.ReadOnly = True
        Me.TEUserEntry.Size = New System.Drawing.Size(249, 20)
        Me.TEUserEntry.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "User Entry"
        '
        'TENumber
        '
        Me.TENumber.Location = New System.Drawing.Point(525, 12)
        Me.TENumber.Name = "TENumber"
        Me.TENumber.Size = New System.Drawing.Size(203, 20)
        Me.TENumber.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(470, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Number"
        '
        'TEDate
        '
        Me.TEDate.Location = New System.Drawing.Point(525, 41)
        Me.TEDate.Name = "TEDate"
        Me.TEDate.Properties.ReadOnly = True
        Me.TEDate.Size = New System.Drawing.Size(203, 20)
        Me.TEDate.TabIndex = 1
        '
        'LTransNo
        '
        Me.LTransNo.Location = New System.Drawing.Point(470, 44)
        Me.LTransNo.Name = "LTransNo"
        Me.LTransNo.Size = New System.Drawing.Size(23, 13)
        Me.LTransNo.TabIndex = 0
        Me.LTransNo.Text = "Date"
        '
        'FormAccountingJournalAdjDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 497)
        Me.Controls.Add(Me.GCJournalDet)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PCGeneralheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAccountingJournalAdjDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjustment Journal Detail"
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BalanceMenu.ResumeLayout(False)
        CType(Me.GCJournalDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVJournalDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PCGeneralheader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCGeneralheader.ResumeLayout(False)
        Me.PCGeneralheader.PerformLayout()
        CType(Me.TEJournalNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEUserEntry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents LargeImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents EPJournal As System.Windows.Forms.ErrorProvider
    Friend WithEvents BalanceMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SMBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GCJournalDet As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVJournalDet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MENote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BAddMat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDelMat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BMark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Bprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PCGeneralheader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TEUserEntry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TENumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LTransNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEJournalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BPickJournal As DevExpress.XtraEditors.SimpleButton
End Class
