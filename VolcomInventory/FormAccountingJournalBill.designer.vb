﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountingJournalBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountingJournalBill))
        Me.BalanceMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SMBalance = New System.Windows.Forms.ToolStripMenuItem
        Me.LargeImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ImgBut = New DevExpress.Utils.ImageCollection(Me.components)
        Me.EPJournal = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.GridColumnStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RSLEStatusOpen = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnIdReport = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnReportMarkType = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnReff = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdCompany = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.MENote = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PCButton = New DevExpress.XtraEditors.PanelControl
        Me.BDelMat = New DevExpress.XtraEditors.SimpleButton
        Me.BAddMat = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BMark = New DevExpress.XtraEditors.SimpleButton
        Me.Bprint = New DevExpress.XtraEditors.SimpleButton
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSave = New DevExpress.XtraEditors.SimpleButton
        Me.PCGeneralheader = New DevExpress.XtraEditors.PanelControl
        Me.TENumber = New DevExpress.XtraEditors.TextEdit
        Me.Blink = New DevExpress.XtraEditors.SimpleButton
        Me.TEReffNumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LEBilling = New DevExpress.XtraEditors.LookUpEdit
        Me.TEUserEntry = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TEDate = New DevExpress.XtraEditors.TextEdit
        Me.LTransNo = New DevExpress.XtraEditors.LabelControl
        Me.BalanceMenu.SuspendLayout()
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCJournalDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVJournalDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSLEStatusOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCButton.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PCGeneralheader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCGeneralheader.SuspendLayout()
        CType(Me.TENumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEReffNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEBilling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEUserEntry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'LargeImageCollection
        '
        Me.LargeImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.LargeImageCollection.ImageStream = CType(resources.GetObject("LargeImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImageCollection.Images.SetKeyName(0, "20_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(1, "8_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(2, "23_24x24.png")
        '
        'ImgBut
        '
        Me.ImgBut.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImgBut.ImageStream = CType(resources.GetObject("ImgBut.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImgBut.Images.SetKeyName(0, "20_24x24.png")
        Me.ImgBut.Images.SetKeyName(1, "8_24x24.png")
        Me.ImgBut.Images.SetKeyName(2, "23_24x24.png")
        Me.ImgBut.Images.SetKeyName(3, "arrow_refresh.png")
        Me.ImgBut.Images.SetKeyName(4, "check_mark.png")
        Me.ImgBut.Images.SetKeyName(5, "gnome_application_exit (1).png")
        Me.ImgBut.Images.SetKeyName(6, "printer_3.png")
        Me.ImgBut.Images.SetKeyName(7, "save.png")
        Me.ImgBut.Images.SetKeyName(8, "31_24x24.png")
        Me.ImgBut.Images.SetKeyName(9, "18_24x24.png")
        Me.ImgBut.Images.SetKeyName(10, "attachment-icon.png")
        Me.ImgBut.Images.SetKeyName(11, "document_32.png")
        '
        'EPJournal
        '
        Me.EPJournal.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EPJournal.ContainerControl = Me
        '
        'GCJournalDet
        '
        Me.GCJournalDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCJournalDet.Location = New System.Drawing.Point(0, 111)
        Me.GCJournalDet.MainView = Me.GVJournalDet
        Me.GCJournalDet.Name = "GCJournalDet"
        Me.GCJournalDet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1, Me.RSLEStatusOpen})
        Me.GCJournalDet.Size = New System.Drawing.Size(826, 289)
        Me.GCJournalDet.TabIndex = 16
        Me.GCJournalDet.TabStop = False
        Me.GCJournalDet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVJournalDet})
        '
        'GVJournalDet
        '
        Me.GVJournalDet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumnStatus, Me.GridColumnIdReport, Me.GridColumnReportMarkType, Me.GridColumnReff, Me.GridColumnIdCompany})
        Me.GVJournalDet.GridControl = Me.GCJournalDet
        Me.GVJournalDet.Name = "GVJournalDet"
        Me.GVJournalDet.OptionsLayout.Columns.StoreAllOptions = True
        Me.GVJournalDet.OptionsLayout.StoreAllOptions = True
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
        Me.GridColumn1.FieldName = "id_acc_trans_det"
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
        Me.GridColumn3.OptionsColumn.AllowEdit = False
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
        'GridColumnStatus
        '
        Me.GridColumnStatus.Caption = "Status"
        Me.GridColumnStatus.ColumnEdit = Me.RSLEStatusOpen
        Me.GridColumnStatus.FieldName = "id_status_open"
        Me.GridColumnStatus.Name = "GridColumnStatus"
        '
        'RSLEStatusOpen
        '
        Me.RSLEStatusOpen.AutoHeight = False
        Me.RSLEStatusOpen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RSLEStatusOpen.Name = "RSLEStatusOpen"
        Me.RSLEStatusOpen.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumnIdReport
        '
        Me.GridColumnIdReport.Caption = "Id Report"
        Me.GridColumnIdReport.FieldName = "id_report"
        Me.GridColumnIdReport.Name = "GridColumnIdReport"
        '
        'GridColumnReportMarkType
        '
        Me.GridColumnReportMarkType.Caption = "Report mark Type"
        Me.GridColumnReportMarkType.FieldName = "report_mark_type"
        Me.GridColumnReportMarkType.Name = "GridColumnReportMarkType"
        '
        'GridColumnReff
        '
        Me.GridColumnReff.Caption = "Reff"
        Me.GridColumnReff.FieldName = "report_number"
        Me.GridColumnReff.Name = "GridColumnReff"
        Me.GridColumnReff.Visible = True
        Me.GridColumnReff.VisibleIndex = 5
        '
        'GridColumnIdCompany
        '
        Me.GridColumnIdCompany.Caption = "Id Company"
        Me.GridColumnIdCompany.FieldName = "id_comp"
        Me.GridColumnIdCompany.Name = "GridColumnIdCompany"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.MENote)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 400)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(826, 58)
        Me.PanelControl4.TabIndex = 14
        '
        'MENote
        '
        Me.MENote.Location = New System.Drawing.Point(55, 8)
        Me.MENote.Name = "MENote"
        Me.MENote.Size = New System.Drawing.Size(759, 40)
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
        'PCButton
        '
        Me.PCButton.Controls.Add(Me.BDelMat)
        Me.PCButton.Controls.Add(Me.BAddMat)
        Me.PCButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCButton.Location = New System.Drawing.Point(0, 75)
        Me.PCButton.Name = "PCButton"
        Me.PCButton.Size = New System.Drawing.Size(826, 36)
        Me.PCButton.TabIndex = 17
        '
        'BDelMat
        '
        Me.BDelMat.Dock = System.Windows.Forms.DockStyle.Right
        Me.BDelMat.ImageIndex = 1
        Me.BDelMat.ImageList = Me.LargeImageCollection
        Me.BDelMat.Location = New System.Drawing.Point(642, 2)
        Me.BDelMat.Name = "BDelMat"
        Me.BDelMat.Size = New System.Drawing.Size(91, 32)
        Me.BDelMat.TabIndex = 16
        Me.BDelMat.TabStop = False
        Me.BDelMat.Text = "Delete"
        '
        'BAddMat
        '
        Me.BAddMat.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAddMat.ImageIndex = 0
        Me.BAddMat.ImageList = Me.LargeImageCollection
        Me.BAddMat.Location = New System.Drawing.Point(733, 2)
        Me.BAddMat.Name = "BAddMat"
        Me.BAddMat.Size = New System.Drawing.Size(91, 32)
        Me.BAddMat.TabIndex = 17
        Me.BAddMat.TabStop = False
        Me.BAddMat.Text = "Add"
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
        Me.PanelControl2.Size = New System.Drawing.Size(826, 39)
        Me.PanelControl2.TabIndex = 15
        '
        'BMark
        '
        Me.BMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.BMark.ImageIndex = 4
        Me.BMark.ImageList = Me.ImgBut
        Me.BMark.Location = New System.Drawing.Point(2, 2)
        Me.BMark.Name = "BMark"
        Me.BMark.Size = New System.Drawing.Size(84, 35)
        Me.BMark.TabIndex = 21
        Me.BMark.TabStop = False
        Me.BMark.Text = "Mark"
        '
        'Bprint
        '
        Me.Bprint.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bprint.ImageIndex = 6
        Me.Bprint.ImageList = Me.ImgBut
        Me.Bprint.Location = New System.Drawing.Point(549, 2)
        Me.Bprint.Name = "Bprint"
        Me.Bprint.Size = New System.Drawing.Size(93, 35)
        Me.Bprint.TabIndex = 20
        Me.Bprint.TabStop = False
        Me.Bprint.Text = "Print"
        '
        'BCancel
        '
        Me.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BCancel.ImageIndex = 5
        Me.BCancel.ImageList = Me.ImgBut
        Me.BCancel.Location = New System.Drawing.Point(642, 2)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(91, 35)
        Me.BCancel.TabIndex = 6
        Me.BCancel.Text = "Cancel"
        '
        'BSave
        '
        Me.BSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BSave.ImageIndex = 7
        Me.BSave.ImageList = Me.ImgBut
        Me.BSave.Location = New System.Drawing.Point(733, 2)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(91, 35)
        Me.BSave.TabIndex = 5
        Me.BSave.Text = "Save"
        '
        'PCGeneralheader
        '
        Me.PCGeneralheader.Controls.Add(Me.TENumber)
        Me.PCGeneralheader.Controls.Add(Me.Blink)
        Me.PCGeneralheader.Controls.Add(Me.TEReffNumber)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl4)
        Me.PCGeneralheader.Controls.Add(Me.LEBilling)
        Me.PCGeneralheader.Controls.Add(Me.TEUserEntry)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl2)
        Me.PCGeneralheader.Controls.Add(Me.LabelControl1)
        Me.PCGeneralheader.Controls.Add(Me.TEDate)
        Me.PCGeneralheader.Controls.Add(Me.LTransNo)
        Me.PCGeneralheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PCGeneralheader.Location = New System.Drawing.Point(0, 0)
        Me.PCGeneralheader.Name = "PCGeneralheader"
        Me.PCGeneralheader.Size = New System.Drawing.Size(826, 75)
        Me.PCGeneralheader.TabIndex = 13
        '
        'TENumber
        '
        Me.TENumber.EditValue = ""
        Me.TENumber.Location = New System.Drawing.Point(186, 12)
        Me.TENumber.Name = "TENumber"
        Me.TENumber.Properties.EditValueChangedDelay = 1
        Me.TENumber.Properties.ReadOnly = True
        Me.TENumber.Size = New System.Drawing.Size(156, 20)
        Me.TENumber.TabIndex = 155
        Me.TENumber.TabStop = False
        '
        'Blink
        '
        Me.Blink.ImageList = Me.LargeImageCollection
        Me.Blink.Location = New System.Drawing.Point(284, 41)
        Me.Blink.Name = "Blink"
        Me.Blink.Size = New System.Drawing.Size(58, 21)
        Me.Blink.TabIndex = 3
        Me.Blink.Text = "Link"
        '
        'TEReffNumber
        '
        Me.TEReffNumber.EditValue = ""
        Me.TEReffNumber.Location = New System.Drawing.Point(90, 42)
        Me.TEReffNumber.Name = "TEReffNumber"
        Me.TEReffNumber.Properties.EditValueChangedDelay = 1
        Me.TEReffNumber.Size = New System.Drawing.Size(188, 20)
        Me.TEReffNumber.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl4.TabIndex = 152
        Me.LabelControl4.Text = "Reff Number"
        '
        'LEBilling
        '
        Me.LEBilling.Location = New System.Drawing.Point(90, 12)
        Me.LEBilling.Name = "LEBilling"
        Me.LEBilling.Properties.Appearance.Options.UseTextOptions = True
        Me.LEBilling.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LEBilling.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LEBilling.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.LEBilling.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.LEBilling.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.LEBilling.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEBilling.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_bill_type", "Id Billing Type", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bill_type", "Billing Type")})
        Me.LEBilling.Properties.NullText = ""
        Me.LEBilling.Properties.ShowFooter = False
        Me.LEBilling.Size = New System.Drawing.Size(90, 20)
        Me.LEBilling.TabIndex = 1
        '
        'TEUserEntry
        '
        Me.TEUserEntry.Location = New System.Drawing.Point(642, 38)
        Me.TEUserEntry.Name = "TEUserEntry"
        Me.TEUserEntry.Properties.ReadOnly = True
        Me.TEUserEntry.Size = New System.Drawing.Size(172, 20)
        Me.TEUserEntry.TabIndex = 0
        Me.TEUserEntry.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(572, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "User Entry"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Number"
        '
        'TEDate
        '
        Me.TEDate.Location = New System.Drawing.Point(642, 12)
        Me.TEDate.Name = "TEDate"
        Me.TEDate.Properties.ReadOnly = True
        Me.TEDate.Size = New System.Drawing.Size(172, 20)
        Me.TEDate.TabIndex = 0
        Me.TEDate.TabStop = False
        '
        'LTransNo
        '
        Me.LTransNo.Location = New System.Drawing.Point(572, 15)
        Me.LTransNo.Name = "LTransNo"
        Me.LTransNo.Size = New System.Drawing.Size(23, 13)
        Me.LTransNo.TabIndex = 0
        Me.LTransNo.Text = "Date"
        '
        'FormAccountingJournalBill
        '
        Me.AcceptButton = Me.BSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BCancel
        Me.ClientSize = New System.Drawing.Size(826, 497)
        Me.Controls.Add(Me.GCJournalDet)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PCButton)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PCGeneralheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAccountingJournalBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry Journal"
        Me.BalanceMenu.ResumeLayout(False)
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPJournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCJournalDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVJournalDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSLEStatusOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCButton.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PCGeneralheader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCGeneralheader.ResumeLayout(False)
        Me.PCGeneralheader.PerformLayout()
        CType(Me.TENumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEReffNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEBilling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEUserEntry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BalanceMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SMBalance As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents LargeImageCollection As DevExpress.Utils.ImageCollection
    Public WithEvents ImgBut As DevExpress.Utils.ImageCollection
    Friend WithEvents EPJournal As System.Windows.Forms.ErrorProvider
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
    Friend WithEvents GridColumnStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RSLEStatusOpen As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnIdReport As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReportMarkType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MENote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PCButton As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BDelMat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BAddMat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BMark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Bprint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PCGeneralheader As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TEUserEntry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LTransNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEBilling As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TEReffNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Blink As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TENumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumnIdCompany As DevExpress.XtraGrid.Columns.GridColumn
End Class
