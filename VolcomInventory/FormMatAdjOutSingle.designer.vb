﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatAdjOutSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMatAdjOutSingle))
        Me.GroupGeneralHeader = New DevExpress.XtraEditors.GroupControl
        Me.LECurrency = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.TxtAdjDate = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.TxtAdjNumber = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GConListPurchase = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GCDetail = New DevExpress.XtraGrid.GridControl
        Me.GVDetail = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnIdAdjSampleDet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdWHDrawer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdWHRack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdWHLOcator = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdWH = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdSample = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnIdmatDetPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnCode = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnSize = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnWHDrawer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnUOM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnRemark = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnAdjPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnQty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.GridColumnAmount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BtnEdit = New DevExpress.XtraEditors.SimpleButton
        Me.LargeImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BtnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDel = New DevExpress.XtraEditors.SimpleButton
        Me.GroupGeneralFooter = New DevExpress.XtraEditors.GroupControl
        Me.LEReportStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.METotSay = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.MENote = New DevExpress.XtraEditors.MemoEdit
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.BMark = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BtnPrint = New DevExpress.XtraEditors.SimpleButton
        Me.EPAdj = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BAttach = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupGeneralHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGeneralHeader.SuspendLayout()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAdjDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAdjNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GConListPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GConListPurchase.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupGeneralFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupGeneralFooter.SuspendLayout()
        CType(Me.LEReportStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.METotSay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.EPAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupGeneralHeader
        '
        Me.GroupGeneralHeader.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupGeneralHeader.Controls.Add(Me.LECurrency)
        Me.GroupGeneralHeader.Controls.Add(Me.LabelControl13)
        Me.GroupGeneralHeader.Controls.Add(Me.TxtAdjDate)
        Me.GroupGeneralHeader.Controls.Add(Me.LabelControl6)
        Me.GroupGeneralHeader.Controls.Add(Me.TxtAdjNumber)
        Me.GroupGeneralHeader.Controls.Add(Me.LabelControl3)
        Me.GroupGeneralHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupGeneralHeader.Location = New System.Drawing.Point(0, 0)
        Me.GroupGeneralHeader.Name = "GroupGeneralHeader"
        Me.GroupGeneralHeader.Size = New System.Drawing.Size(829, 75)
        Me.GroupGeneralHeader.TabIndex = 32
        '
        'LECurrency
        '
        Me.LECurrency.Enabled = False
        Me.LECurrency.Location = New System.Drawing.Point(163, 38)
        Me.LECurrency.Name = "LECurrency"
        Me.LECurrency.Properties.Appearance.Options.UseTextOptions = True
        Me.LECurrency.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LECurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LECurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_currency", "Id Currency", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("currency", "Currency")})
        Me.LECurrency.Properties.NullText = ""
        Me.LECurrency.Properties.ShowFooter = False
        Me.LECurrency.Size = New System.Drawing.Size(250, 20)
        Me.LECurrency.TabIndex = 148
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(32, 41)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl13.TabIndex = 146
        Me.LabelControl13.Text = "Currency"
        '
        'TxtAdjDate
        '
        Me.TxtAdjDate.EditValue = ""
        Me.TxtAdjDate.Location = New System.Drawing.Point(540, 12)
        Me.TxtAdjDate.Name = "TxtAdjDate"
        Me.TxtAdjDate.Properties.EditValueChangedDelay = 1
        Me.TxtAdjDate.Properties.ReadOnly = True
        Me.TxtAdjDate.Size = New System.Drawing.Size(277, 20)
        Me.TxtAdjDate.TabIndex = 0
        Me.TxtAdjDate.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(500, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl6.TabIndex = 124
        Me.LabelControl6.Text = "Date"
        '
        'TxtAdjNumber
        '
        Me.TxtAdjNumber.EditValue = ""
        Me.TxtAdjNumber.Location = New System.Drawing.Point(163, 12)
        Me.TxtAdjNumber.Name = "TxtAdjNumber"
        Me.TxtAdjNumber.Properties.EditValueChangedDelay = 1
        Me.TxtAdjNumber.Properties.ReadOnly = True
        Me.TxtAdjNumber.Size = New System.Drawing.Size(250, 20)
        Me.TxtAdjNumber.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl3.TabIndex = 86
        Me.LabelControl3.Text = "Adjusment Out  Number"
        '
        'GConListPurchase
        '
        Me.GConListPurchase.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GConListPurchase.Controls.Add(Me.PanelControl1)
        Me.GConListPurchase.Controls.Add(Me.PanelControl2)
        Me.GConListPurchase.Dock = System.Windows.Forms.DockStyle.Top
        Me.GConListPurchase.Location = New System.Drawing.Point(0, 75)
        Me.GConListPurchase.Name = "GConListPurchase"
        Me.GConListPurchase.Size = New System.Drawing.Size(829, 259)
        Me.GConListPurchase.TabIndex = 33
        Me.GConListPurchase.Text = "Adjustment List"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GCDetail)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(22, 46)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(805, 211)
        Me.PanelControl1.TabIndex = 19
        '
        'GCDetail
        '
        Me.GCDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCDetail.Location = New System.Drawing.Point(0, 0)
        Me.GCDetail.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GCDetail.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCDetail.MainView = Me.GVDetail
        Me.GCDetail.Name = "GCDetail"
        Me.GCDetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.GCDetail.Size = New System.Drawing.Size(805, 211)
        Me.GCDetail.TabIndex = 2
        Me.GCDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVDetail, Me.GridView1})
        '
        'GVDetail
        '
        Me.GVDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnIdAdjSampleDet, Me.GridColumnNo, Me.GridColumnIdWHDrawer, Me.GridColumnIdWHRack, Me.GridColumnIdWHLOcator, Me.GridColumnIdWH, Me.GridColumnIdSample, Me.GridColumnIdmatDetPrice, Me.GridColumnCode, Me.GridColumnName, Me.GridColumnSize, Me.GridColumnWHDrawer, Me.GridColumnUOM, Me.GridColumnRemark, Me.GridColumnAdjPrice, Me.GridColumnQty, Me.GridColumnAmount})
        Me.GVDetail.GridControl = Me.GCDetail
        Me.GVDetail.Name = "GVDetail"
        Me.GVDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GVDetail.OptionsBehavior.Editable = False
        Me.GVDetail.OptionsView.ShowFooter = True
        Me.GVDetail.OptionsView.ShowGroupPanel = False
        '
        'GridColumnIdAdjSampleDet
        '
        Me.GridColumnIdAdjSampleDet.Caption = "id adj det"
        Me.GridColumnIdAdjSampleDet.FieldName = "id_adj_out_mat_det"
        Me.GridColumnIdAdjSampleDet.Name = "GridColumnIdAdjSampleDet"
        Me.GridColumnIdAdjSampleDet.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnIdAdjSampleDet.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdAdjSampleDet.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnNo
        '
        Me.GridColumnNo.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNo.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnNo.Caption = "No"
        Me.GridColumnNo.FieldName = "no"
        Me.GridColumnNo.Name = "GridColumnNo"
        Me.GridColumnNo.OptionsColumn.AllowEdit = False
        Me.GridColumnNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnNo.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnNo.Visible = True
        Me.GridColumnNo.VisibleIndex = 0
        Me.GridColumnNo.Width = 50
        '
        'GridColumnIdWHDrawer
        '
        Me.GridColumnIdWHDrawer.Caption = "Id WH Drawer"
        Me.GridColumnIdWHDrawer.FieldName = "id_wh_drawer"
        Me.GridColumnIdWHDrawer.Name = "GridColumnIdWHDrawer"
        Me.GridColumnIdWHDrawer.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnIdWHDrawer.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdWHDrawer.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnIdWHDrawer.Width = 77
        '
        'GridColumnIdWHRack
        '
        Me.GridColumnIdWHRack.Caption = "Id WH Rack"
        Me.GridColumnIdWHRack.FieldName = "id_wh_rack"
        Me.GridColumnIdWHRack.Name = "GridColumnIdWHRack"
        Me.GridColumnIdWHRack.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnIdWHRack.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdWHRack.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdWHLOcator
        '
        Me.GridColumnIdWHLOcator.Caption = "Id WH Locator"
        Me.GridColumnIdWHLOcator.FieldName = "id_wh_locator"
        Me.GridColumnIdWHLOcator.Name = "GridColumnIdWHLOcator"
        Me.GridColumnIdWHLOcator.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnIdWHLOcator.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdWHLOcator.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnIdWHLOcator.Width = 78
        '
        'GridColumnIdWH
        '
        Me.GridColumnIdWH.Caption = "Id WH"
        Me.GridColumnIdWH.FieldName = "id_comp"
        Me.GridColumnIdWH.Name = "GridColumnIdWH"
        Me.GridColumnIdWH.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnIdWH.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdWH.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdSample
        '
        Me.GridColumnIdSample.Caption = "Sample"
        Me.GridColumnIdSample.FieldName = "id_mat_det"
        Me.GridColumnIdSample.Name = "GridColumnIdSample"
        Me.GridColumnIdSample.OptionsColumn.AllowShowHide = False
        Me.GridColumnIdSample.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdmatDetPrice
        '
        Me.GridColumnIdmatDetPrice.Caption = "Id Mat Det price"
        Me.GridColumnIdmatDetPrice.FieldName = "id_mat_det_price"
        Me.GridColumnIdmatDetPrice.Name = "GridColumnIdmatDetPrice"
        '
        'GridColumnCode
        '
        Me.GridColumnCode.Caption = "Code"
        Me.GridColumnCode.FieldName = "code"
        Me.GridColumnCode.Name = "GridColumnCode"
        Me.GridColumnCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnCode.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnCode.Visible = True
        Me.GridColumnCode.VisibleIndex = 1
        Me.GridColumnCode.Width = 100
        '
        'GridColumnName
        '
        Me.GridColumnName.Caption = "Name"
        Me.GridColumnName.FieldName = "name"
        Me.GridColumnName.Name = "GridColumnName"
        Me.GridColumnName.OptionsColumn.AllowEdit = False
        Me.GridColumnName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnName.OptionsColumn.AllowShowHide = False
        Me.GridColumnName.Visible = True
        Me.GridColumnName.VisibleIndex = 2
        Me.GridColumnName.Width = 200
        '
        'GridColumnSize
        '
        Me.GridColumnSize.Caption = "Size"
        Me.GridColumnSize.FieldName = "size"
        Me.GridColumnSize.Name = "GridColumnSize"
        Me.GridColumnSize.OptionsColumn.AllowEdit = False
        Me.GridColumnSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnSize.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnSize.Width = 46
        '
        'GridColumnWHDrawer
        '
        Me.GridColumnWHDrawer.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnWHDrawer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnWHDrawer.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnWHDrawer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnWHDrawer.Caption = "Drawer"
        Me.GridColumnWHDrawer.FieldName = "wh_drawer"
        Me.GridColumnWHDrawer.Name = "GridColumnWHDrawer"
        Me.GridColumnWHDrawer.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnWHDrawer.Visible = True
        Me.GridColumnWHDrawer.VisibleIndex = 3
        Me.GridColumnWHDrawer.Width = 110
        '
        'GridColumnUOM
        '
        Me.GridColumnUOM.Caption = "UOM"
        Me.GridColumnUOM.FieldName = "uom"
        Me.GridColumnUOM.Name = "GridColumnUOM"
        Me.GridColumnUOM.OptionsColumn.AllowEdit = False
        Me.GridColumnUOM.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumnRemark
        '
        Me.GridColumnRemark.Caption = "Remark"
        Me.GridColumnRemark.FieldName = "adj_out_mat_det_note"
        Me.GridColumnRemark.Name = "GridColumnRemark"
        Me.GridColumnRemark.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumnAdjPrice
        '
        Me.GridColumnAdjPrice.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnAdjPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnAdjPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnAdjPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnAdjPrice.Caption = "Cost"
        Me.GridColumnAdjPrice.DisplayFormat.FormatString = "N4"
        Me.GridColumnAdjPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAdjPrice.FieldName = "adj_out_mat_det_price"
        Me.GridColumnAdjPrice.Name = "GridColumnAdjPrice"
        Me.GridColumnAdjPrice.Visible = True
        Me.GridColumnAdjPrice.VisibleIndex = 4
        Me.GridColumnAdjPrice.Width = 110
        '
        'GridColumnQty
        '
        Me.GridColumnQty.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnQty.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnQty.Caption = "Qty"
        Me.GridColumnQty.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.GridColumnQty.DisplayFormat.FormatString = "N2"
        Me.GridColumnQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnQty.FieldName = "adj_out_mat_det_qty"
        Me.GridColumnQty.Name = "GridColumnQty"
        Me.GridColumnQty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumnQty.Visible = True
        Me.GridColumnQty.VisibleIndex = 5
        Me.GridColumnQty.Width = 86
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.Mask.EditMask = "f0"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'GridColumnAmount
        '
        Me.GridColumnAmount.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnAmount.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumnAmount.Caption = "Amount"
        Me.GridColumnAmount.DisplayFormat.FormatString = "n2"
        Me.GridColumnAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAmount.FieldName = "adj_out_mat_det_amount"
        Me.GridColumnAmount.Name = "GridColumnAmount"
        Me.GridColumnAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "adj_out_mat_det_amount", "{0:n2}")})
        Me.GridColumnAmount.Visible = True
        Me.GridColumnAmount.VisibleIndex = 6
        Me.GridColumnAmount.Width = 131
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCDetail
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.BtnEdit)
        Me.PanelControl2.Controls.Add(Me.BtnAdd)
        Me.PanelControl2.Controls.Add(Me.BtnDel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(22, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(805, 44)
        Me.PanelControl2.TabIndex = 18
        '
        'BtnEdit
        '
        Me.BtnEdit.ImageIndex = 2
        Me.BtnEdit.ImageList = Me.LargeImageCollection
        Me.BtnEdit.Location = New System.Drawing.Point(607, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(91, 29)
        Me.BtnEdit.TabIndex = 19
        Me.BtnEdit.Text = "Edit"
        '
        'LargeImageCollection
        '
        Me.LargeImageCollection.ImageSize = New System.Drawing.Size(24, 24)
        Me.LargeImageCollection.ImageStream = CType(resources.GetObject("LargeImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImageCollection.Images.SetKeyName(0, "20_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(1, "8_24x24.png")
        Me.LargeImageCollection.Images.SetKeyName(2, "23_24x24.png")
        '
        'BtnAdd
        '
        Me.BtnAdd.ImageIndex = 0
        Me.BtnAdd.ImageList = Me.LargeImageCollection
        Me.BtnAdd.Location = New System.Drawing.Point(704, 7)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(91, 29)
        Me.BtnAdd.TabIndex = 18
        Me.BtnAdd.Text = "Add"
        '
        'BtnDel
        '
        Me.BtnDel.ImageIndex = 1
        Me.BtnDel.ImageList = Me.LargeImageCollection
        Me.BtnDel.Location = New System.Drawing.Point(510, 7)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(91, 29)
        Me.BtnDel.TabIndex = 17
        Me.BtnDel.Text = "Delete"
        '
        'GroupGeneralFooter
        '
        Me.GroupGeneralFooter.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupGeneralFooter.Controls.Add(Me.LEReportStatus)
        Me.GroupGeneralFooter.Controls.Add(Me.LabelControl21)
        Me.GroupGeneralFooter.Controls.Add(Me.LabelControl19)
        Me.GroupGeneralFooter.Controls.Add(Me.METotSay)
        Me.GroupGeneralFooter.Controls.Add(Me.LabelControl18)
        Me.GroupGeneralFooter.Controls.Add(Me.MENote)
        Me.GroupGeneralFooter.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupGeneralFooter.Location = New System.Drawing.Point(0, 334)
        Me.GroupGeneralFooter.Name = "GroupGeneralFooter"
        Me.GroupGeneralFooter.Size = New System.Drawing.Size(829, 113)
        Me.GroupGeneralFooter.TabIndex = 170
        '
        'LEReportStatus
        '
        Me.LEReportStatus.Enabled = False
        Me.LEReportStatus.Location = New System.Drawing.Point(77, 58)
        Me.LEReportStatus.Name = "LEReportStatus"
        Me.LEReportStatus.Properties.Appearance.Options.UseTextOptions = True
        Me.LEReportStatus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LEReportStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEReportStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_report_status", "ID Report Status", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("report_status", "Report Status")})
        Me.LEReportStatus.Properties.NullText = ""
        Me.LEReportStatus.Properties.ShowFooter = False
        Me.LEReportStatus.Size = New System.Drawing.Size(336, 20)
        Me.LEReportStatus.TabIndex = 145
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(27, 61)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl21.TabIndex = 146
        Me.LabelControl21.Text = "Status"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(460, 15)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl19.TabIndex = 140
        Me.LabelControl19.Text = "Say"
        '
        'METotSay
        '
        Me.METotSay.Location = New System.Drawing.Point(500, 11)
        Me.METotSay.Name = "METotSay"
        Me.METotSay.Properties.MaxLength = 100
        Me.METotSay.Properties.ReadOnly = True
        Me.METotSay.Size = New System.Drawing.Size(317, 67)
        Me.METotSay.TabIndex = 139
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(27, 15)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl18.TabIndex = 138
        Me.LabelControl18.Text = "Note"
        '
        'MENote
        '
        Me.MENote.Location = New System.Drawing.Point(77, 11)
        Me.MENote.Name = "MENote"
        Me.MENote.Properties.MaxLength = 100
        Me.MENote.Size = New System.Drawing.Size(336, 41)
        Me.MENote.TabIndex = 137
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BAttach)
        Me.PanelControl3.Controls.Add(Me.BtnPrint)
        Me.PanelControl3.Controls.Add(Me.BtnCancel)
        Me.PanelControl3.Controls.Add(Me.BtnSave)
        Me.PanelControl3.Controls.Add(Me.BMark)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 447)
        Me.PanelControl3.LookAndFeel.SkinName = "Blue"
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(829, 30)
        Me.PanelControl3.TabIndex = 171
        '
        'BMark
        '
        Me.BMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.BMark.Location = New System.Drawing.Point(2, 2)
        Me.BMark.Name = "BMark"
        Me.BMark.Size = New System.Drawing.Size(75, 26)
        Me.BMark.TabIndex = 16
        Me.BMark.Text = "Mark"
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Location = New System.Drawing.Point(752, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 26)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Save"
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancel.Location = New System.Drawing.Point(677, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 26)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnPrint.Location = New System.Drawing.Point(602, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 26)
        Me.BtnPrint.TabIndex = 14
        Me.BtnPrint.Text = "Print"
        '
        'EPAdj
        '
        Me.EPAdj.ContainerControl = Me
        '
        'BAttach
        '
        Me.BAttach.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAttach.Location = New System.Drawing.Point(500, 2)
        Me.BAttach.Name = "BAttach"
        Me.BAttach.Size = New System.Drawing.Size(102, 26)
        Me.BAttach.TabIndex = 17
        Me.BAttach.Text = "Attachment"
        '
        'FormMatAdjOutSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 477)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.GroupGeneralFooter)
        Me.Controls.Add(Me.GConListPurchase)
        Me.Controls.Add(Me.GroupGeneralHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMatAdjOutSingle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjustment Out Material"
        CType(Me.GroupGeneralHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGeneralHeader.ResumeLayout(False)
        Me.GroupGeneralHeader.PerformLayout()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAdjDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAdjNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GConListPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GConListPurchase.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupGeneralFooter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupGeneralFooter.ResumeLayout(False)
        Me.GroupGeneralFooter.PerformLayout()
        CType(Me.LEReportStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.METotSay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MENote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.EPAdj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupGeneralHeader As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LECurrency As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtAdjDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtAdjNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GConListPurchase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdWHDrawer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdWHRack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdWHLOcator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdWH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdSample As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdAdjSampleDet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnWHDrawer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnAdjPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumnAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupGeneralFooter As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LEReportStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents METotSay As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MENote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BMark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPAdj As System.Windows.Forms.ErrorProvider
    Public WithEvents LargeImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents GridColumnIdmatDetPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BAttach As DevExpress.XtraEditors.SimpleButton
End Class
