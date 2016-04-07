﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSalesOrderSvcLevel
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GCFilter = New DevExpress.XtraEditors.GroupControl()
        Me.SLEPackingStatus = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnIdPrepareStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrepareStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnView = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BHide = New DevExpress.XtraEditors.SimpleButton()
        Me.BExpand = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntil = New DevExpress.XtraEditors.DateEdit()
        Me.DEFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GCSalesOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnSalesTargetNumb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSalesTargetDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDSalesTargetNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReportStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.GridColumnIdSalesOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReff = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SMView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDetailOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePackingStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XTCSvcLevel = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPPrepareOrder = New DevExpress.XtraTab.XtraTabPage()
        Me.XTPReturnOrder = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSalesReturnOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesReturnOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnEstDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnTimeRemaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReturnQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnOrderQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCurrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSvcLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCFilterRet = New DevExpress.XtraEditors.GroupControl()
        Me.SLEPackingStatusRet = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewRet = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilRet = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromRet = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.XTPRec = New DevExpress.XtraTab.XtraTabPage()
        Me.GCPL = New DevExpress.XtraGrid.GridControl()
        Me.GVPL = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdPLSample = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdContactFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdCompContactTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdReportStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPLNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSeasno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPLNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSRNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPLDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPLCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDesignMain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnVendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSelectRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUserRec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCFilterRec = New DevExpress.XtraEditors.GroupControl()
        Me.BtnUpdateRec = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEStatusRec = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewRec = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilRec = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromRec = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.XTPDelOrder = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSalesDelOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesDelOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdSalesDelOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnWHName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnUpdateDO = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEStatusDO = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewDO = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilDO = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromDO = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.XTPReturn = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSalesReturn = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesReturn = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnSalesReturnNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnReturnOrderNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnStore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompNameTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnStoreRetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSelReturn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnUpdateReturn = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEStatusReturn = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewReturn = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilReturn = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromReturn = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.XTPReturnQC = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSalesReturnQC = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesReturnQC = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnSalesReturnQCNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnStoreNameFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnQCCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnUpdateReturnQC = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEStatusReturnQC = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewReturnQC = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilReturnQC = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromReturnQC = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.XTPTrf = New DevExpress.XtraTab.XtraTabPage()
        Me.GCFGTrf = New DevExpress.XtraGrid.GridControl()
        Me.GVFGTrf = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnFGTrfNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCompNameFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnFGTrfDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnPrepOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoTxtPrepOrder = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumnIdFgTrf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnSelTrf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnUpdateTrf = New DevExpress.XtraEditors.SimpleButton()
        Me.SLEStatusTrf = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnViewTrf = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.DEUntilTrf = New DevExpress.XtraEditors.DateEdit()
        Me.DEFromTrf = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GCFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCFilter.SuspendLayout()
        CType(Me.SLEPackingStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntil.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewMenu.SuspendLayout()
        CType(Me.XTCSvcLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCSvcLevel.SuspendLayout()
        Me.XTPPrepareOrder.SuspendLayout()
        Me.XTPReturnOrder.SuspendLayout()
        CType(Me.GCSalesReturnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesReturnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCFilterRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCFilterRet.SuspendLayout()
        CType(Me.SLEPackingStatusRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilRet.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromRet.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPRec.SuspendLayout()
        CType(Me.GCPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVPL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCFilterRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCFilterRec.SuspendLayout()
        CType(Me.SLEStatusRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilRec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromRec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPDelOrder.SuspendLayout()
        CType(Me.GCSalesDelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesDelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SLEStatusDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPReturn.SuspendLayout()
        CType(Me.GCSalesReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SLEStatusReturn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilReturn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilReturn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromReturn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromReturn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPReturnQC.SuspendLayout()
        CType(Me.GCSalesReturnQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesReturnQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.SLEStatusReturnQC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilReturnQC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilReturnQC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromReturnQC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromReturnQC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPTrf.SuspendLayout()
        CType(Me.GCFGTrf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVFGTrf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoTxtPrepOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.SLEStatusTrf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilTrf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEUntilTrf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromTrf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFromTrf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCFilter
        '
        Me.GCFilter.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GCFilter.Controls.Add(Me.SLEPackingStatus)
        Me.GCFilter.Controls.Add(Me.BtnView)
        Me.GCFilter.Controls.Add(Me.LabelControl1)
        Me.GCFilter.Controls.Add(Me.BHide)
        Me.GCFilter.Controls.Add(Me.BExpand)
        Me.GCFilter.Controls.Add(Me.DEUntil)
        Me.GCFilter.Controls.Add(Me.DEFrom)
        Me.GCFilter.Controls.Add(Me.LabelControl2)
        Me.GCFilter.Controls.Add(Me.LabelControl3)
        Me.GCFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.GCFilter.Location = New System.Drawing.Point(0, 0)
        Me.GCFilter.Name = "GCFilter"
        Me.GCFilter.Size = New System.Drawing.Size(754, 39)
        Me.GCFilter.TabIndex = 2
        '
        'SLEPackingStatus
        '
        Me.SLEPackingStatus.Location = New System.Drawing.Point(354, 9)
        Me.SLEPackingStatus.Name = "SLEPackingStatus"
        Me.SLEPackingStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEPackingStatus.Properties.ShowClearButton = False
        Me.SLEPackingStatus.Properties.View = Me.SearchLookUpEdit1View
        Me.SLEPackingStatus.Size = New System.Drawing.Size(156, 20)
        Me.SLEPackingStatus.TabIndex = 8897
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnIdPrepareStatus, Me.GridColumnPrepareStatus})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumnIdPrepareStatus
        '
        Me.GridColumnIdPrepareStatus.Caption = "Id Prepare Status"
        Me.GridColumnIdPrepareStatus.FieldName = "id_prepare_status"
        Me.GridColumnIdPrepareStatus.Name = "GridColumnIdPrepareStatus"
        Me.GridColumnIdPrepareStatus.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnPrepareStatus
        '
        Me.GridColumnPrepareStatus.Caption = "Status"
        Me.GridColumnPrepareStatus.FieldName = "prepare_status"
        Me.GridColumnPrepareStatus.Name = "GridColumnPrepareStatus"
        Me.GridColumnPrepareStatus.Visible = True
        Me.GridColumnPrepareStatus.VisibleIndex = 0
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(516, 9)
        Me.BtnView.LookAndFeel.SkinName = "Blue"
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(75, 20)
        Me.BtnView.TabIndex = 8896
        Me.BtnView.Text = "View"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 8899
        Me.LabelControl1.Text = "Status"
        '
        'BHide
        '
        Me.BHide.ImageIndex = 9
        Me.BHide.Location = New System.Drawing.Point(938, 14)
        Me.BHide.Name = "BHide"
        Me.BHide.Size = New System.Drawing.Size(104, 20)
        Me.BHide.TabIndex = 8898
        Me.BHide.Text = "Hide All Detail"
        Me.BHide.Visible = False
        '
        'BExpand
        '
        Me.BExpand.ImageIndex = 8
        Me.BExpand.Location = New System.Drawing.Point(835, 14)
        Me.BExpand.Name = "BExpand"
        Me.BExpand.Size = New System.Drawing.Size(99, 20)
        Me.BExpand.TabIndex = 8897
        Me.BExpand.Text = "Expand All Detail"
        Me.BExpand.Visible = False
        '
        'DEUntil
        '
        Me.DEUntil.EditValue = Nothing
        Me.DEUntil.Location = New System.Drawing.Point(202, 9)
        Me.DEUntil.Name = "DEUntil"
        Me.DEUntil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntil.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntil.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntil.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntil.Size = New System.Drawing.Size(111, 20)
        Me.DEUntil.TabIndex = 8895
        '
        'DEFrom
        '
        Me.DEFrom.EditValue = Nothing
        Me.DEFrom.Location = New System.Drawing.Point(58, 9)
        Me.DEFrom.Name = "DEFrom"
        Me.DEFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFrom.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFrom.Size = New System.Drawing.Size(111, 20)
        Me.DEFrom.TabIndex = 8894
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl2.TabIndex = 8893
        Me.LabelControl2.Text = "Until"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 8892
        Me.LabelControl3.Text = "From"
        '
        'GCSalesOrder
        '
        Me.GCSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesOrder.Location = New System.Drawing.Point(0, 39)
        Me.GCSalesOrder.MainView = Me.GVSalesOrder
        Me.GCSalesOrder.Name = "GCSalesOrder"
        Me.GCSalesOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar1})
        Me.GCSalesOrder.Size = New System.Drawing.Size(754, 349)
        Me.GCSalesOrder.TabIndex = 3
        Me.GCSalesOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesOrder, Me.GridView2})
        '
        'GVSalesOrder
        '
        Me.GVSalesOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnSalesTargetNumb, Me.GridColumnTo, Me.GridColumnSalesTargetDate, Me.GridColumnDSalesTargetNote, Me.GridColumnReportStatus, Me.GridColumn1, Me.GridColumn9, Me.GridColumnIdSalesOrder, Me.GridColumn1Category, Me.GridColumn10, Me.GridColumnReff, Me.GridColumn44})
        Me.GVSalesOrder.GridControl = Me.GCSalesOrder
        Me.GVSalesOrder.Name = "GVSalesOrder"
        Me.GVSalesOrder.OptionsBehavior.ReadOnly = True
        Me.GVSalesOrder.OptionsCustomization.AllowSort = False
        Me.GVSalesOrder.OptionsView.ShowGroupPanel = False
        Me.GVSalesOrder.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnIdSalesOrder, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumnSalesTargetNumb
        '
        Me.GridColumnSalesTargetNumb.Caption = "Number"
        Me.GridColumnSalesTargetNumb.FieldName = "sales_order_number"
        Me.GridColumnSalesTargetNumb.Name = "GridColumnSalesTargetNumb"
        Me.GridColumnSalesTargetNumb.Visible = True
        Me.GridColumnSalesTargetNumb.VisibleIndex = 0
        Me.GridColumnSalesTargetNumb.Width = 123
        '
        'GridColumnTo
        '
        Me.GridColumnTo.Caption = "Store/Destination"
        Me.GridColumnTo.FieldName = "store_name_to"
        Me.GridColumnTo.Name = "GridColumnTo"
        Me.GridColumnTo.Visible = True
        Me.GridColumnTo.VisibleIndex = 2
        Me.GridColumnTo.Width = 111
        '
        'GridColumnSalesTargetDate
        '
        Me.GridColumnSalesTargetDate.Caption = "Order Date"
        Me.GridColumnSalesTargetDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnSalesTargetDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnSalesTargetDate.FieldName = "sales_order_date"
        Me.GridColumnSalesTargetDate.Name = "GridColumnSalesTargetDate"
        Me.GridColumnSalesTargetDate.Visible = True
        Me.GridColumnSalesTargetDate.VisibleIndex = 5
        Me.GridColumnSalesTargetDate.Width = 111
        '
        'GridColumnDSalesTargetNote
        '
        Me.GridColumnDSalesTargetNote.Caption = "Note"
        Me.GridColumnDSalesTargetNote.FieldName = "sales_order_note"
        Me.GridColumnDSalesTargetNote.Name = "GridColumnDSalesTargetNote"
        Me.GridColumnDSalesTargetNote.Width = 111
        '
        'GridColumnReportStatus
        '
        Me.GridColumnReportStatus.Caption = "Status"
        Me.GridColumnReportStatus.FieldName = "report_status"
        Me.GridColumnReportStatus.Name = "GridColumnReportStatus"
        Me.GridColumnReportStatus.Width = 141
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "prepare_status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Service Level"
        Me.GridColumn9.ColumnEdit = Me.RepositoryItemProgressBar1
        Me.GridColumn9.FieldName = "so_completness"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 85
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.RepositoryItemProgressBar1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        Me.RepositoryItemProgressBar1.ShowTitle = True
        '
        'GridColumnIdSalesOrder
        '
        Me.GridColumnIdSalesOrder.Caption = "Id Sales Order"
        Me.GridColumnIdSalesOrder.FieldName = "id_sales_order"
        Me.GridColumnIdSalesOrder.Name = "GridColumnIdSalesOrder"
        Me.GridColumnIdSalesOrder.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn1Category
        '
        Me.GridColumn1Category.Caption = "Category"
        Me.GridColumn1Category.FieldName = "so_status"
        Me.GridColumn1Category.FieldNameSortGroup = "id_so_status"
        Me.GridColumn1Category.Name = "GridColumn1Category"
        Me.GridColumn1Category.Visible = True
        Me.GridColumn1Category.VisibleIndex = 4
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Warehouse"
        Me.GridColumn10.FieldName = "warehouse_name_to"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumnReff
        '
        Me.GridColumnReff.Caption = "Reff"
        Me.GridColumnReff.FieldName = "fg_so_reff_number"
        Me.GridColumnReff.Name = "GridColumnReff"
        Me.GridColumnReff.Visible = True
        Me.GridColumnReff.VisibleIndex = 1
        '
        'GridColumn44
        '
        Me.GridColumn44.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn44.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn44.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn44.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn44.Caption = "Created Process"
        Me.GridColumn44.FieldName = "created_process"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 6
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCSalesOrder
        Me.GridView2.Name = "GridView2"
        '
        'ViewMenu
        '
        Me.ViewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SMView, Me.ViewDetailOrderToolStripMenuItem, Me.UpdatePackingStatusToolStripMenuItem})
        Me.ViewMenu.Name = "ContextMenuStripYM"
        Me.ViewMenu.Size = New System.Drawing.Size(166, 70)
        '
        'SMView
        '
        Me.SMView.Name = "SMView"
        Me.SMView.Size = New System.Drawing.Size(165, 22)
        Me.SMView.Text = "View Detail"
        '
        'ViewDetailOrderToolStripMenuItem
        '
        Me.ViewDetailOrderToolStripMenuItem.Name = "ViewDetailOrderToolStripMenuItem"
        Me.ViewDetailOrderToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewDetailOrderToolStripMenuItem.Text = "View Detail Order"
        '
        'UpdatePackingStatusToolStripMenuItem
        '
        Me.UpdatePackingStatusToolStripMenuItem.Name = "UpdatePackingStatusToolStripMenuItem"
        Me.UpdatePackingStatusToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UpdatePackingStatusToolStripMenuItem.Text = "Update Status"
        '
        'XTCSvcLevel
        '
        Me.XTCSvcLevel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCSvcLevel.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTCSvcLevel.Location = New System.Drawing.Point(0, 0)
        Me.XTCSvcLevel.Name = "XTCSvcLevel"
        Me.XTCSvcLevel.SelectedTabPage = Me.XTPPrepareOrder
        Me.XTCSvcLevel.Size = New System.Drawing.Size(760, 416)
        Me.XTCSvcLevel.TabIndex = 4
        Me.XTCSvcLevel.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPPrepareOrder, Me.XTPReturnOrder, Me.XTPRec, Me.XTPDelOrder, Me.XTPReturn, Me.XTPReturnQC, Me.XTPTrf})
        '
        'XTPPrepareOrder
        '
        Me.XTPPrepareOrder.Controls.Add(Me.GCSalesOrder)
        Me.XTPPrepareOrder.Controls.Add(Me.GCFilter)
        Me.XTPPrepareOrder.Name = "XTPPrepareOrder"
        Me.XTPPrepareOrder.Size = New System.Drawing.Size(754, 388)
        Me.XTPPrepareOrder.Text = "Prepare Order"
        '
        'XTPReturnOrder
        '
        Me.XTPReturnOrder.Controls.Add(Me.GCSalesReturnOrder)
        Me.XTPReturnOrder.Controls.Add(Me.GCFilterRet)
        Me.XTPReturnOrder.Name = "XTPReturnOrder"
        Me.XTPReturnOrder.Size = New System.Drawing.Size(754, 388)
        Me.XTPReturnOrder.Text = "Return Order"
        '
        'GCSalesReturnOrder
        '
        Me.GCSalesReturnOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesReturnOrder.Location = New System.Drawing.Point(0, 39)
        Me.GCSalesReturnOrder.MainView = Me.GVSalesReturnOrder
        Me.GCSalesReturnOrder.Name = "GCSalesReturnOrder"
        Me.GCSalesReturnOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2})
        Me.GCSalesReturnOrder.Size = New System.Drawing.Size(754, 349)
        Me.GCSalesReturnOrder.TabIndex = 4
        Me.GCSalesReturnOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesReturnOrder, Me.GridView3})
        '
        'GVSalesReturnOrder
        '
        Me.GVSalesReturnOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumnEstDate, Me.GridColumn7, Me.GridColumn8, Me.GridColumnTimeRemaining, Me.GridColumnReturnQty, Me.GridColumnOrderQty, Me.GridColumn11, Me.GridColumnCurrDate, Me.GridColumn12, Me.GridColumnSvcLevel})
        Me.GVSalesReturnOrder.CustomizationFormBounds = New System.Drawing.Rectangle(805, 323, 210, 172)
        Me.GVSalesReturnOrder.GridControl = Me.GCSalesReturnOrder
        Me.GVSalesReturnOrder.Name = "GVSalesReturnOrder"
        Me.GVSalesReturnOrder.OptionsBehavior.ReadOnly = True
        Me.GVSalesReturnOrder.OptionsView.ShowGroupPanel = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Number"
        Me.GridColumn4.FieldName = "sales_return_order_number"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 83
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Store"
        Me.GridColumn5.FieldName = "store_name_to"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Created Date"
        Me.GridColumn6.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "sales_return_order_date"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumnEstDate
        '
        Me.GridColumnEstDate.Caption = "Estimate Return"
        Me.GridColumnEstDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnEstDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnEstDate.FieldName = "sales_return_order_est_date"
        Me.GridColumnEstDate.Name = "GridColumnEstDate"
        Me.GridColumnEstDate.Visible = True
        Me.GridColumnEstDate.VisibleIndex = 3
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Note"
        Me.GridColumn7.FieldName = "sales_return_order_note"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Created Return"
        Me.GridColumn8.FieldName = "created_return"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        '
        'GridColumnTimeRemaining
        '
        Me.GridColumnTimeRemaining.Caption = "Time Remaining"
        Me.GridColumnTimeRemaining.FieldName = "time_remaining"
        Me.GridColumnTimeRemaining.Name = "GridColumnTimeRemaining"
        '
        'GridColumnReturnQty
        '
        Me.GridColumnReturnQty.Caption = "Total Return Qty"
        Me.GridColumnReturnQty.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumnReturnQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnReturnQty.FieldName = "return_qty"
        Me.GridColumnReturnQty.Name = "GridColumnReturnQty"
        '
        'GridColumnOrderQty
        '
        Me.GridColumnOrderQty.Caption = "Total Return Order Qty"
        Me.GridColumnOrderQty.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumnOrderQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnOrderQty.FieldName = "order_qty"
        Me.GridColumnOrderQty.Name = "GridColumnOrderQty"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Status"
        Me.GridColumn11.FieldName = "report_status"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumnCurrDate
        '
        Me.GridColumnCurrDate.Caption = "Current Date"
        Me.GridColumnCurrDate.FieldName = "sales_return_order_date_current"
        Me.GridColumnCurrDate.Name = "GridColumnCurrDate"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Status"
        Me.GridColumn12.FieldName = "prepare_status"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        '
        'GridColumnSvcLevel
        '
        Me.GridColumnSvcLevel.Caption = "Service Level"
        Me.GridColumnSvcLevel.ColumnEdit = Me.RepositoryItemProgressBar2
        Me.GridColumnSvcLevel.FieldName = "svc_level"
        Me.GridColumnSvcLevel.Name = "GridColumnSvcLevel"
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        Me.RepositoryItemProgressBar2.ReadOnly = True
        Me.RepositoryItemProgressBar2.ShowTitle = True
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GCSalesReturnOrder
        Me.GridView3.Name = "GridView3"
        '
        'GCFilterRet
        '
        Me.GCFilterRet.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GCFilterRet.Controls.Add(Me.SLEPackingStatusRet)
        Me.GCFilterRet.Controls.Add(Me.BtnViewRet)
        Me.GCFilterRet.Controls.Add(Me.LabelControl4)
        Me.GCFilterRet.Controls.Add(Me.SimpleButton2)
        Me.GCFilterRet.Controls.Add(Me.SimpleButton3)
        Me.GCFilterRet.Controls.Add(Me.DEUntilRet)
        Me.GCFilterRet.Controls.Add(Me.DEFromRet)
        Me.GCFilterRet.Controls.Add(Me.LabelControl5)
        Me.GCFilterRet.Controls.Add(Me.LabelControl6)
        Me.GCFilterRet.Dock = System.Windows.Forms.DockStyle.Top
        Me.GCFilterRet.Location = New System.Drawing.Point(0, 0)
        Me.GCFilterRet.Name = "GCFilterRet"
        Me.GCFilterRet.Size = New System.Drawing.Size(754, 39)
        Me.GCFilterRet.TabIndex = 3
        '
        'SLEPackingStatusRet
        '
        Me.SLEPackingStatusRet.Location = New System.Drawing.Point(354, 9)
        Me.SLEPackingStatusRet.Name = "SLEPackingStatusRet"
        Me.SLEPackingStatusRet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEPackingStatusRet.Properties.ShowClearButton = False
        Me.SLEPackingStatusRet.Properties.View = Me.GridView1
        Me.SLEPackingStatusRet.Size = New System.Drawing.Size(156, 20)
        Me.SLEPackingStatusRet.TabIndex = 8897
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id Prepare Status"
        Me.GridColumn2.FieldName = "id_prepare_status"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Status"
        Me.GridColumn3.FieldName = "prepare_status"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'BtnViewRet
        '
        Me.BtnViewRet.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewRet.LookAndFeel.SkinName = "Blue"
        Me.BtnViewRet.Name = "BtnViewRet"
        Me.BtnViewRet.Size = New System.Drawing.Size(75, 20)
        Me.BtnViewRet.TabIndex = 8896
        Me.BtnViewRet.Text = "View"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl4.TabIndex = 8899
        Me.LabelControl4.Text = "Status"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageIndex = 9
        Me.SimpleButton2.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton2.TabIndex = 8898
        Me.SimpleButton2.Text = "Hide All Detail"
        Me.SimpleButton2.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.ImageIndex = 8
        Me.SimpleButton3.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton3.TabIndex = 8897
        Me.SimpleButton3.Text = "Expand All Detail"
        Me.SimpleButton3.Visible = False
        '
        'DEUntilRet
        '
        Me.DEUntilRet.EditValue = Nothing
        Me.DEUntilRet.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilRet.Name = "DEUntilRet"
        Me.DEUntilRet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilRet.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilRet.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilRet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilRet.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilRet.TabIndex = 8895
        '
        'DEFromRet
        '
        Me.DEFromRet.EditValue = Nothing
        Me.DEFromRet.Location = New System.Drawing.Point(58, 9)
        Me.DEFromRet.Name = "DEFromRet"
        Me.DEFromRet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromRet.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromRet.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromRet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromRet.Size = New System.Drawing.Size(111, 20)
        Me.DEFromRet.TabIndex = 8894
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl5.TabIndex = 8893
        Me.LabelControl5.Text = "Until"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 8892
        Me.LabelControl6.Text = "From"
        '
        'XTPRec
        '
        Me.XTPRec.Controls.Add(Me.GCPL)
        Me.XTPRec.Controls.Add(Me.GCFilterRec)
        Me.XTPRec.Name = "XTPRec"
        Me.XTPRec.Size = New System.Drawing.Size(754, 388)
        Me.XTPRec.Text = "Received Product"
        '
        'GCPL
        '
        Me.GCPL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCPL.Location = New System.Drawing.Point(0, 39)
        Me.GCPL.MainView = Me.GVPL
        Me.GCPL.Name = "GCPL"
        Me.GCPL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GCPL.Size = New System.Drawing.Size(754, 349)
        Me.GCPL.TabIndex = 4
        Me.GCPL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVPL})
        '
        'GVPL
        '
        Me.GVPL.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNo, Me.GridColumnIdPLSample, Me.GridColumnIdContactFrom, Me.GridColumnIdCompContactTo, Me.GridColumnIdReportStatus, Me.GridColumn15, Me.GridColumnPLNote, Me.GridColumnSeasno, Me.GridColumnPLNumber, Me.GridColumnSRNumber, Me.GridColumnFrom, Me.GridColumn16, Me.GridColumnPLDate, Me.GridColumnStatus, Me.GridColumnPLCategory, Me.GridColumnDesignMain, Me.GridColumnTotal, Me.GridColumnVendor, Me.GridColumn17, Me.GridColumnSelectRec, Me.GridColumnLastUpdate, Me.GridColumnLastUserRec})
        Me.GVPL.GridControl = Me.GCPL
        Me.GVPL.GroupCount = 1
        Me.GVPL.Name = "GVPL"
        Me.GVPL.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVPL.OptionsView.ShowFooter = True
        Me.GVPL.OptionsView.ShowGroupPanel = False
        Me.GVPL.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnSeasno, DevExpress.Data.ColumnSortOrder.Descending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnIdPLSample, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumnNo
        '
        Me.GridColumnNo.Caption = "No"
        Me.GridColumnNo.FieldName = "no"
        Me.GridColumnNo.Name = "GridColumnNo"
        Me.GridColumnNo.OptionsColumn.ShowInCustomizationForm = False
        Me.GridColumnNo.Width = 41
        '
        'GridColumnIdPLSample
        '
        Me.GridColumnIdPLSample.Caption = "Id PL Sample"
        Me.GridColumnIdPLSample.FieldName = "id_pl_prod_order_rec"
        Me.GridColumnIdPLSample.Name = "GridColumnIdPLSample"
        Me.GridColumnIdPLSample.OptionsColumn.AllowEdit = False
        Me.GridColumnIdPLSample.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdContactFrom
        '
        Me.GridColumnIdContactFrom.Caption = "GridColumnIdContacctFrom"
        Me.GridColumnIdContactFrom.FieldName = "id_comp_contact_from"
        Me.GridColumnIdContactFrom.Name = "GridColumnIdContactFrom"
        Me.GridColumnIdContactFrom.OptionsColumn.AllowEdit = False
        Me.GridColumnIdContactFrom.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdCompContactTo
        '
        Me.GridColumnIdCompContactTo.Caption = "GridColumnIdCompContactTo"
        Me.GridColumnIdCompContactTo.FieldName = "id_comp_contact_to"
        Me.GridColumnIdCompContactTo.Name = "GridColumnIdCompContactTo"
        Me.GridColumnIdCompContactTo.OptionsColumn.AllowEdit = False
        Me.GridColumnIdCompContactTo.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnIdReportStatus
        '
        Me.GridColumnIdReportStatus.Caption = "Id Report Status"
        Me.GridColumnIdReportStatus.FieldName = "id_report_status"
        Me.GridColumnIdReportStatus.Name = "GridColumnIdReportStatus"
        Me.GridColumnIdReportStatus.OptionsColumn.AllowEdit = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "GridColumn1"
        Me.GridColumn15.FieldName = "id_report_status"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        '
        'GridColumnPLNote
        '
        Me.GridColumnPLNote.Caption = "Note"
        Me.GridColumnPLNote.FieldName = "pl_prod_order_rec_note"
        Me.GridColumnPLNote.Name = "GridColumnPLNote"
        Me.GridColumnPLNote.OptionsColumn.AllowEdit = False
        Me.GridColumnPLNote.Width = 97
        '
        'GridColumnSeasno
        '
        Me.GridColumnSeasno.Caption = "Season"
        Me.GridColumnSeasno.FieldName = "season"
        Me.GridColumnSeasno.FieldNameSortGroup = "id_season"
        Me.GridColumnSeasno.Name = "GridColumnSeasno"
        Me.GridColumnSeasno.OptionsColumn.AllowEdit = False
        '
        'GridColumnPLNumber
        '
        Me.GridColumnPLNumber.Caption = "Number"
        Me.GridColumnPLNumber.FieldName = "pl_prod_order_rec_number"
        Me.GridColumnPLNumber.Name = "GridColumnPLNumber"
        Me.GridColumnPLNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnPLNumber.Visible = True
        Me.GridColumnPLNumber.VisibleIndex = 0
        Me.GridColumnPLNumber.Width = 69
        '
        'GridColumnSRNumber
        '
        Me.GridColumnSRNumber.Caption = "PL"
        Me.GridColumnSRNumber.FieldName = "pl_prod_order_number"
        Me.GridColumnSRNumber.Name = "GridColumnSRNumber"
        Me.GridColumnSRNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnSRNumber.Visible = True
        Me.GridColumnSRNumber.VisibleIndex = 1
        Me.GridColumnSRNumber.Width = 54
        '
        'GridColumnFrom
        '
        Me.GridColumnFrom.Caption = "From"
        Me.GridColumnFrom.FieldName = "comp_name_from"
        Me.GridColumnFrom.Name = "GridColumnFrom"
        Me.GridColumnFrom.OptionsColumn.AllowEdit = False
        Me.GridColumnFrom.Visible = True
        Me.GridColumnFrom.VisibleIndex = 5
        Me.GridColumnFrom.Width = 69
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "To"
        Me.GridColumn16.FieldName = "comp_name_to"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        Me.GridColumn16.Width = 69
        '
        'GridColumnPLDate
        '
        Me.GridColumnPLDate.Caption = "Created Date"
        Me.GridColumnPLDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnPLDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnPLDate.FieldName = "pl_prod_order_rec_date"
        Me.GridColumnPLDate.Name = "GridColumnPLDate"
        Me.GridColumnPLDate.OptionsColumn.AllowEdit = False
        Me.GridColumnPLDate.Visible = True
        Me.GridColumnPLDate.VisibleIndex = 9
        Me.GridColumnPLDate.Width = 69
        '
        'GridColumnStatus
        '
        Me.GridColumnStatus.Caption = "Status"
        Me.GridColumnStatus.FieldName = "report_status"
        Me.GridColumnStatus.Name = "GridColumnStatus"
        Me.GridColumnStatus.OptionsColumn.AllowEdit = False
        Me.GridColumnStatus.Visible = True
        Me.GridColumnStatus.VisibleIndex = 12
        Me.GridColumnStatus.Width = 70
        '
        'GridColumnPLCategory
        '
        Me.GridColumnPLCategory.Caption = "Category"
        Me.GridColumnPLCategory.FieldName = "pl_category"
        Me.GridColumnPLCategory.Name = "GridColumnPLCategory"
        Me.GridColumnPLCategory.OptionsColumn.AllowEdit = False
        Me.GridColumnPLCategory.Visible = True
        Me.GridColumnPLCategory.VisibleIndex = 7
        Me.GridColumnPLCategory.Width = 54
        '
        'GridColumnDesignMain
        '
        Me.GridColumnDesignMain.Caption = "Design"
        Me.GridColumnDesignMain.FieldName = "design_name"
        Me.GridColumnDesignMain.FieldNameSortGroup = "id_design"
        Me.GridColumnDesignMain.Name = "GridColumnDesignMain"
        Me.GridColumnDesignMain.OptionsColumn.AllowEdit = False
        Me.GridColumnDesignMain.Visible = True
        Me.GridColumnDesignMain.VisibleIndex = 3
        Me.GridColumnDesignMain.Width = 54
        '
        'GridColumnTotal
        '
        Me.GridColumnTotal.Caption = "Total"
        Me.GridColumnTotal.DisplayFormat.FormatString = "N0"
        Me.GridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnTotal.FieldName = "total_qty"
        Me.GridColumnTotal.Name = "GridColumnTotal"
        Me.GridColumnTotal.OptionsColumn.AllowEdit = False
        Me.GridColumnTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total_qty", "{0:n0}")})
        Me.GridColumnTotal.Visible = True
        Me.GridColumnTotal.VisibleIndex = 8
        Me.GridColumnTotal.Width = 54
        '
        'GridColumnVendor
        '
        Me.GridColumnVendor.Caption = "Vendor"
        Me.GridColumnVendor.FieldName = "vendor"
        Me.GridColumnVendor.Name = "GridColumnVendor"
        Me.GridColumnVendor.OptionsColumn.AllowEdit = False
        Me.GridColumnVendor.Visible = True
        Me.GridColumnVendor.VisibleIndex = 4
        Me.GridColumnVendor.Width = 54
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "PO"
        Me.GridColumn17.FieldName = "prod_order_number"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 2
        Me.GridColumn17.Width = 54
        '
        'GridColumnSelectRec
        '
        Me.GridColumnSelectRec.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnSelectRec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelectRec.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnSelectRec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelectRec.Caption = "Select"
        Me.GridColumnSelectRec.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumnSelectRec.FieldName = "is_select"
        Me.GridColumnSelectRec.Name = "GridColumnSelectRec"
        Me.GridColumnSelectRec.Visible = True
        Me.GridColumnSelectRec.VisibleIndex = 13
        Me.GridColumnSelectRec.Width = 54
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "No"
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Update"
        Me.GridColumnLastUpdate.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnLastUpdate.FieldName = "last_update"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.OptionsColumn.AllowEdit = False
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 10
        Me.GridColumnLastUpdate.Width = 71
        '
        'GridColumnLastUserRec
        '
        Me.GridColumnLastUserRec.Caption = "Updated By"
        Me.GridColumnLastUserRec.FieldName = "last_user"
        Me.GridColumnLastUserRec.Name = "GridColumnLastUserRec"
        Me.GridColumnLastUserRec.OptionsColumn.AllowEdit = False
        Me.GridColumnLastUserRec.Visible = True
        Me.GridColumnLastUserRec.VisibleIndex = 11
        Me.GridColumnLastUserRec.Width = 49
        '
        'GCFilterRec
        '
        Me.GCFilterRec.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GCFilterRec.Controls.Add(Me.BtnUpdateRec)
        Me.GCFilterRec.Controls.Add(Me.SLEStatusRec)
        Me.GCFilterRec.Controls.Add(Me.BtnViewRec)
        Me.GCFilterRec.Controls.Add(Me.LabelControl7)
        Me.GCFilterRec.Controls.Add(Me.SimpleButton4)
        Me.GCFilterRec.Controls.Add(Me.SimpleButton5)
        Me.GCFilterRec.Controls.Add(Me.DEUntilRec)
        Me.GCFilterRec.Controls.Add(Me.DEFromRec)
        Me.GCFilterRec.Controls.Add(Me.LabelControl8)
        Me.GCFilterRec.Controls.Add(Me.LabelControl9)
        Me.GCFilterRec.Dock = System.Windows.Forms.DockStyle.Top
        Me.GCFilterRec.Location = New System.Drawing.Point(0, 0)
        Me.GCFilterRec.Name = "GCFilterRec"
        Me.GCFilterRec.Size = New System.Drawing.Size(754, 39)
        Me.GCFilterRec.TabIndex = 3
        '
        'BtnUpdateRec
        '
        Me.BtnUpdateRec.Location = New System.Drawing.Point(574, 9)
        Me.BtnUpdateRec.LookAndFeel.SkinName = "Blue"
        Me.BtnUpdateRec.Name = "BtnUpdateRec"
        Me.BtnUpdateRec.Size = New System.Drawing.Size(84, 20)
        Me.BtnUpdateRec.TabIndex = 8900
        Me.BtnUpdateRec.Text = "Update Status"
        '
        'SLEStatusRec
        '
        Me.SLEStatusRec.Location = New System.Drawing.Point(354, 9)
        Me.SLEStatusRec.Name = "SLEStatusRec"
        Me.SLEStatusRec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEStatusRec.Properties.ShowClearButton = False
        Me.SLEStatusRec.Properties.View = Me.GridView4
        Me.SLEStatusRec.Size = New System.Drawing.Size(156, 20)
        Me.SLEStatusRec.TabIndex = 8897
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Id Report Status"
        Me.GridColumn13.FieldName = "id_report_status"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Status"
        Me.GridColumn14.FieldName = "report_status"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 0
        '
        'BtnViewRec
        '
        Me.BtnViewRec.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewRec.LookAndFeel.SkinName = "Blue"
        Me.BtnViewRec.Name = "BtnViewRec"
        Me.BtnViewRec.Size = New System.Drawing.Size(55, 20)
        Me.BtnViewRec.TabIndex = 8896
        Me.BtnViewRec.Text = "View"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl7.TabIndex = 8899
        Me.LabelControl7.Text = "Status"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.ImageIndex = 9
        Me.SimpleButton4.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton4.TabIndex = 8898
        Me.SimpleButton4.Text = "Hide All Detail"
        Me.SimpleButton4.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageIndex = 8
        Me.SimpleButton5.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton5.TabIndex = 8897
        Me.SimpleButton5.Text = "Expand All Detail"
        Me.SimpleButton5.Visible = False
        '
        'DEUntilRec
        '
        Me.DEUntilRec.EditValue = Nothing
        Me.DEUntilRec.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilRec.Name = "DEUntilRec"
        Me.DEUntilRec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilRec.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilRec.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilRec.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilRec.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilRec.TabIndex = 8895
        '
        'DEFromRec
        '
        Me.DEFromRec.EditValue = Nothing
        Me.DEFromRec.Location = New System.Drawing.Point(58, 9)
        Me.DEFromRec.Name = "DEFromRec"
        Me.DEFromRec.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromRec.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromRec.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromRec.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromRec.Size = New System.Drawing.Size(111, 20)
        Me.DEFromRec.TabIndex = 8894
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl8.TabIndex = 8893
        Me.LabelControl8.Text = "Until"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl9.TabIndex = 8892
        Me.LabelControl9.Text = "From"
        '
        'XTPDelOrder
        '
        Me.XTPDelOrder.Controls.Add(Me.GCSalesDelOrder)
        Me.XTPDelOrder.Controls.Add(Me.GroupControl1)
        Me.XTPDelOrder.Name = "XTPDelOrder"
        Me.XTPDelOrder.Size = New System.Drawing.Size(754, 388)
        Me.XTPDelOrder.Text = "Delivery"
        '
        'GCSalesDelOrder
        '
        Me.GCSalesDelOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesDelOrder.Location = New System.Drawing.Point(0, 39)
        Me.GCSalesDelOrder.MainView = Me.GVSalesDelOrder
        Me.GCSalesDelOrder.Name = "GCSalesDelOrder"
        Me.GCSalesDelOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.GCSalesDelOrder.Size = New System.Drawing.Size(754, 349)
        Me.GCSalesDelOrder.TabIndex = 5
        Me.GCSalesDelOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesDelOrder, Me.GridView6})
        '
        'GVSalesDelOrder
        '
        Me.GVSalesDelOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumnIdSalesDelOrder, Me.GridColumnWHName, Me.GridColumnCategory, Me.GridColumn26, Me.GridColumnUpdBy, Me.GridColumnSelect})
        Me.GVSalesDelOrder.GridControl = Me.GCSalesDelOrder
        Me.GVSalesDelOrder.Name = "GVSalesDelOrder"
        Me.GVSalesDelOrder.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSalesDelOrder.OptionsView.ShowGroupPanel = False
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Number"
        Me.GridColumn20.FieldName = "pl_sales_order_del_number"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 0
        Me.GridColumn20.Width = 83
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Store"
        Me.GridColumn21.FieldName = "store_name_to"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 2
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Created Date"
        Me.GridColumn22.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn22.FieldName = "pl_sales_order_del_date"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.AllowEdit = False
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Note"
        Me.GridColumn23.FieldName = "pl_sales_order_del_note"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.AllowEdit = False
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Status"
        Me.GridColumn24.FieldName = "report_status"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.AllowEdit = False
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 8
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Prepare Order"
        Me.GridColumn25.FieldName = "sales_order_number"
        Me.GridColumn25.FieldNameSortGroup = "id_pl_sales_order_del"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.AllowEdit = False
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 3
        '
        'GridColumnIdSalesDelOrder
        '
        Me.GridColumnIdSalesDelOrder.Caption = "Id Sales Del Order"
        Me.GridColumnIdSalesDelOrder.FieldName = "id_pl_sales_order_del"
        Me.GridColumnIdSalesDelOrder.Name = "GridColumnIdSalesDelOrder"
        Me.GridColumnIdSalesDelOrder.OptionsColumn.AllowEdit = False
        Me.GridColumnIdSalesDelOrder.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnWHName
        '
        Me.GridColumnWHName.Caption = "Warehouse"
        Me.GridColumnWHName.FieldName = "wh_name"
        Me.GridColumnWHName.FieldNameSortGroup = "id_wh"
        Me.GridColumnWHName.Name = "GridColumnWHName"
        Me.GridColumnWHName.OptionsColumn.AllowEdit = False
        Me.GridColumnWHName.Visible = True
        Me.GridColumnWHName.VisibleIndex = 1
        '
        'GridColumnCategory
        '
        Me.GridColumnCategory.Caption = "Category"
        Me.GridColumnCategory.FieldName = "so_status"
        Me.GridColumnCategory.FieldNameSortGroup = "id_so_status"
        Me.GridColumnCategory.Name = "GridColumnCategory"
        Me.GridColumnCategory.OptionsColumn.AllowEdit = False
        Me.GridColumnCategory.Visible = True
        Me.GridColumnCategory.VisibleIndex = 4
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Last Updated"
        Me.GridColumn26.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn26.FieldName = "last_update"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.AllowEdit = False
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 6
        '
        'GridColumnUpdBy
        '
        Me.GridColumnUpdBy.Caption = "Updated By"
        Me.GridColumnUpdBy.FieldName = "last_user"
        Me.GridColumnUpdBy.Name = "GridColumnUpdBy"
        Me.GridColumnUpdBy.OptionsColumn.AllowEdit = False
        Me.GridColumnUpdBy.Visible = True
        Me.GridColumnUpdBy.VisibleIndex = 7
        '
        'GridColumnSelect
        '
        Me.GridColumnSelect.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnSelect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelect.Caption = "Select"
        Me.GridColumnSelect.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.GridColumnSelect.FieldName = "is_select"
        Me.GridColumnSelect.Name = "GridColumnSelect"
        Me.GridColumnSelect.Visible = True
        Me.GridColumnSelect.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "No"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GCSalesDelOrder
        Me.GridView6.Name = "GridView6"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl1.Controls.Add(Me.BtnUpdateDO)
        Me.GroupControl1.Controls.Add(Me.SLEStatusDO)
        Me.GroupControl1.Controls.Add(Me.BtnViewDO)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.SimpleButton7)
        Me.GroupControl1.Controls.Add(Me.SimpleButton8)
        Me.GroupControl1.Controls.Add(Me.DEUntilDO)
        Me.GroupControl1.Controls.Add(Me.DEFromDO)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(754, 39)
        Me.GroupControl1.TabIndex = 4
        '
        'BtnUpdateDO
        '
        Me.BtnUpdateDO.Location = New System.Drawing.Point(574, 9)
        Me.BtnUpdateDO.LookAndFeel.SkinName = "Blue"
        Me.BtnUpdateDO.Name = "BtnUpdateDO"
        Me.BtnUpdateDO.Size = New System.Drawing.Size(84, 20)
        Me.BtnUpdateDO.TabIndex = 8900
        Me.BtnUpdateDO.Text = "Update Status"
        '
        'SLEStatusDO
        '
        Me.SLEStatusDO.Location = New System.Drawing.Point(354, 9)
        Me.SLEStatusDO.Name = "SLEStatusDO"
        Me.SLEStatusDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEStatusDO.Properties.ShowClearButton = False
        Me.SLEStatusDO.Properties.View = Me.GridView5
        Me.SLEStatusDO.Size = New System.Drawing.Size(156, 20)
        Me.SLEStatusDO.TabIndex = 8897
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Id Report Status"
        Me.GridColumn18.FieldName = "id_report_status"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Status"
        Me.GridColumn19.FieldName = "report_status"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        '
        'BtnViewDO
        '
        Me.BtnViewDO.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewDO.LookAndFeel.SkinName = "Blue"
        Me.BtnViewDO.Name = "BtnViewDO"
        Me.BtnViewDO.Size = New System.Drawing.Size(55, 20)
        Me.BtnViewDO.TabIndex = 8896
        Me.BtnViewDO.Text = "View"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 8899
        Me.LabelControl10.Text = "Status"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.ImageIndex = 9
        Me.SimpleButton7.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton7.TabIndex = 8898
        Me.SimpleButton7.Text = "Hide All Detail"
        Me.SimpleButton7.Visible = False
        '
        'SimpleButton8
        '
        Me.SimpleButton8.ImageIndex = 8
        Me.SimpleButton8.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton8.TabIndex = 8897
        Me.SimpleButton8.Text = "Expand All Detail"
        Me.SimpleButton8.Visible = False
        '
        'DEUntilDO
        '
        Me.DEUntilDO.EditValue = Nothing
        Me.DEUntilDO.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilDO.Name = "DEUntilDO"
        Me.DEUntilDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilDO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilDO.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilDO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilDO.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilDO.TabIndex = 8895
        '
        'DEFromDO
        '
        Me.DEFromDO.EditValue = Nothing
        Me.DEFromDO.Location = New System.Drawing.Point(58, 9)
        Me.DEFromDO.Name = "DEFromDO"
        Me.DEFromDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromDO.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromDO.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromDO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromDO.Size = New System.Drawing.Size(111, 20)
        Me.DEFromDO.TabIndex = 8894
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl11.TabIndex = 8893
        Me.LabelControl11.Text = "Until"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 8892
        Me.LabelControl12.Text = "From"
        '
        'XTPReturn
        '
        Me.XTPReturn.Controls.Add(Me.GCSalesReturn)
        Me.XTPReturn.Controls.Add(Me.GroupControl2)
        Me.XTPReturn.Name = "XTPReturn"
        Me.XTPReturn.Size = New System.Drawing.Size(754, 388)
        Me.XTPReturn.Text = "Return"
        '
        'GCSalesReturn
        '
        Me.GCSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesReturn.Location = New System.Drawing.Point(0, 39)
        Me.GCSalesReturn.MainView = Me.GVSalesReturn
        Me.GCSalesReturn.Name = "GCSalesReturn"
        Me.GCSalesReturn.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.GCSalesReturn.Size = New System.Drawing.Size(754, 349)
        Me.GCSalesReturn.TabIndex = 6
        Me.GCSalesReturn.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesReturn})
        '
        'GVSalesReturn
        '
        Me.GVSalesReturn.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnSalesReturnNumber, Me.GridColumnReturnOrderNumber, Me.GridColumnStore, Me.GridColumnCompNameTo, Me.GridColumnStoreRetNumber, Me.GridColumnCreatedDate, Me.GridColumn29, Me.GridColumn30, Me.GridColumnLastUser, Me.GridColumnSelReturn})
        Me.GVSalesReturn.GridControl = Me.GCSalesReturn
        Me.GVSalesReturn.Name = "GVSalesReturn"
        Me.GVSalesReturn.OptionsView.ShowGroupPanel = False
        '
        'GridColumnSalesReturnNumber
        '
        Me.GridColumnSalesReturnNumber.Caption = "Number"
        Me.GridColumnSalesReturnNumber.FieldName = "sales_return_number"
        Me.GridColumnSalesReturnNumber.Name = "GridColumnSalesReturnNumber"
        Me.GridColumnSalesReturnNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnSalesReturnNumber.Visible = True
        Me.GridColumnSalesReturnNumber.VisibleIndex = 0
        '
        'GridColumnReturnOrderNumber
        '
        Me.GridColumnReturnOrderNumber.Caption = "Return Order"
        Me.GridColumnReturnOrderNumber.FieldName = "sales_return_order_number"
        Me.GridColumnReturnOrderNumber.Name = "GridColumnReturnOrderNumber"
        Me.GridColumnReturnOrderNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnReturnOrderNumber.Visible = True
        Me.GridColumnReturnOrderNumber.VisibleIndex = 1
        '
        'GridColumnStore
        '
        Me.GridColumnStore.Caption = "From"
        Me.GridColumnStore.FieldName = "store_name_from"
        Me.GridColumnStore.Name = "GridColumnStore"
        Me.GridColumnStore.OptionsColumn.AllowEdit = False
        Me.GridColumnStore.Visible = True
        Me.GridColumnStore.VisibleIndex = 2
        '
        'GridColumnCompNameTo
        '
        Me.GridColumnCompNameTo.Caption = "To"
        Me.GridColumnCompNameTo.FieldName = "comp_name_to"
        Me.GridColumnCompNameTo.Name = "GridColumnCompNameTo"
        Me.GridColumnCompNameTo.OptionsColumn.AllowEdit = False
        Me.GridColumnCompNameTo.Visible = True
        Me.GridColumnCompNameTo.VisibleIndex = 3
        '
        'GridColumnStoreRetNumber
        '
        Me.GridColumnStoreRetNumber.Caption = "Store Return Number"
        Me.GridColumnStoreRetNumber.FieldName = "sales_return_store_number"
        Me.GridColumnStoreRetNumber.Name = "GridColumnStoreRetNumber"
        Me.GridColumnStoreRetNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnStoreRetNumber.Visible = True
        Me.GridColumnStoreRetNumber.VisibleIndex = 4
        '
        'GridColumnCreatedDate
        '
        Me.GridColumnCreatedDate.Caption = "Created Date"
        Me.GridColumnCreatedDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnCreatedDate.FieldName = "sales_return_date"
        Me.GridColumnCreatedDate.Name = "GridColumnCreatedDate"
        Me.GridColumnCreatedDate.OptionsColumn.AllowEdit = False
        Me.GridColumnCreatedDate.Visible = True
        Me.GridColumnCreatedDate.VisibleIndex = 5
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Status"
        Me.GridColumn29.FieldName = "report_status"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.AllowEdit = False
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 8
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Last Updated"
        Me.GridColumn30.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn30.FieldName = "last_update"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 6
        '
        'GridColumnLastUser
        '
        Me.GridColumnLastUser.Caption = "Updated By"
        Me.GridColumnLastUser.FieldName = "last_user"
        Me.GridColumnLastUser.Name = "GridColumnLastUser"
        Me.GridColumnLastUser.OptionsColumn.AllowEdit = False
        Me.GridColumnLastUser.Visible = True
        Me.GridColumnLastUser.VisibleIndex = 7
        '
        'GridColumnSelReturn
        '
        Me.GridColumnSelReturn.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnSelReturn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelReturn.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnSelReturn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelReturn.Caption = "Select"
        Me.GridColumnSelReturn.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumnSelReturn.FieldName = "is_select"
        Me.GridColumnSelReturn.Name = "GridColumnSelReturn"
        Me.GridColumnSelReturn.Visible = True
        Me.GridColumnSelReturn.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        Me.RepositoryItemCheckEdit3.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit3.ValueUnchecked = "No"
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl2.Controls.Add(Me.BtnUpdateReturn)
        Me.GroupControl2.Controls.Add(Me.SLEStatusReturn)
        Me.GroupControl2.Controls.Add(Me.BtnViewReturn)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.SimpleButton9)
        Me.GroupControl2.Controls.Add(Me.SimpleButton10)
        Me.GroupControl2.Controls.Add(Me.DEUntilReturn)
        Me.GroupControl2.Controls.Add(Me.DEFromReturn)
        Me.GroupControl2.Controls.Add(Me.LabelControl14)
        Me.GroupControl2.Controls.Add(Me.LabelControl15)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(754, 39)
        Me.GroupControl2.TabIndex = 5
        '
        'BtnUpdateReturn
        '
        Me.BtnUpdateReturn.Location = New System.Drawing.Point(574, 9)
        Me.BtnUpdateReturn.LookAndFeel.SkinName = "Blue"
        Me.BtnUpdateReturn.Name = "BtnUpdateReturn"
        Me.BtnUpdateReturn.Size = New System.Drawing.Size(84, 20)
        Me.BtnUpdateReturn.TabIndex = 8900
        Me.BtnUpdateReturn.Text = "Update Status"
        '
        'SLEStatusReturn
        '
        Me.SLEStatusReturn.Location = New System.Drawing.Point(354, 9)
        Me.SLEStatusReturn.Name = "SLEStatusReturn"
        Me.SLEStatusReturn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEStatusReturn.Properties.ShowClearButton = False
        Me.SLEStatusReturn.Properties.View = Me.GridView7
        Me.SLEStatusReturn.Size = New System.Drawing.Size(156, 20)
        Me.SLEStatusReturn.TabIndex = 8897
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn27, Me.GridColumn28})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Id Report Status"
        Me.GridColumn27.FieldName = "id_report_status"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Status"
        Me.GridColumn28.FieldName = "report_status"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        '
        'BtnViewReturn
        '
        Me.BtnViewReturn.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewReturn.LookAndFeel.SkinName = "Blue"
        Me.BtnViewReturn.Name = "BtnViewReturn"
        Me.BtnViewReturn.Size = New System.Drawing.Size(55, 20)
        Me.BtnViewReturn.TabIndex = 8896
        Me.BtnViewReturn.Text = "View"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl13.TabIndex = 8899
        Me.LabelControl13.Text = "Status"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.ImageIndex = 9
        Me.SimpleButton9.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton9.TabIndex = 8898
        Me.SimpleButton9.Text = "Hide All Detail"
        Me.SimpleButton9.Visible = False
        '
        'SimpleButton10
        '
        Me.SimpleButton10.ImageIndex = 8
        Me.SimpleButton10.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton10.TabIndex = 8897
        Me.SimpleButton10.Text = "Expand All Detail"
        Me.SimpleButton10.Visible = False
        '
        'DEUntilReturn
        '
        Me.DEUntilReturn.EditValue = Nothing
        Me.DEUntilReturn.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilReturn.Name = "DEUntilReturn"
        Me.DEUntilReturn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilReturn.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilReturn.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilReturn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilReturn.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilReturn.TabIndex = 8895
        '
        'DEFromReturn
        '
        Me.DEFromReturn.EditValue = Nothing
        Me.DEFromReturn.Location = New System.Drawing.Point(58, 9)
        Me.DEFromReturn.Name = "DEFromReturn"
        Me.DEFromReturn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromReturn.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromReturn.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromReturn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromReturn.Size = New System.Drawing.Size(111, 20)
        Me.DEFromReturn.TabIndex = 8894
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl14.TabIndex = 8893
        Me.LabelControl14.Text = "Until"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl15.TabIndex = 8892
        Me.LabelControl15.Text = "From"
        '
        'XTPReturnQC
        '
        Me.XTPReturnQC.Controls.Add(Me.GCSalesReturnQC)
        Me.XTPReturnQC.Controls.Add(Me.GroupControl3)
        Me.XTPReturnQC.Name = "XTPReturnQC"
        Me.XTPReturnQC.Size = New System.Drawing.Size(754, 388)
        Me.XTPReturnQC.Text = "Return QC"
        '
        'GCSalesReturnQC
        '
        Me.GCSalesReturnQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesReturnQC.Location = New System.Drawing.Point(0, 39)
        Me.GCSalesReturnQC.MainView = Me.GVSalesReturnQC
        Me.GCSalesReturnQC.Name = "GCSalesReturnQC"
        Me.GCSalesReturnQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4})
        Me.GCSalesReturnQC.Size = New System.Drawing.Size(754, 349)
        Me.GCSalesReturnQC.TabIndex = 7
        Me.GCSalesReturnQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesReturnQC})
        '
        'GVSalesReturnQC
        '
        Me.GVSalesReturnQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnSalesReturnQCNumber, Me.GridColumn33, Me.GridColumnStoreNameFrom, Me.GridColumn34, Me.GridColumnQCCategory, Me.GridColumn35, Me.GridColumnCompTo, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38})
        Me.GVSalesReturnQC.GridControl = Me.GCSalesReturnQC
        Me.GVSalesReturnQC.Name = "GVSalesReturnQC"
        Me.GVSalesReturnQC.OptionsView.ShowGroupPanel = False
        '
        'GridColumnSalesReturnQCNumber
        '
        Me.GridColumnSalesReturnQCNumber.Caption = "Number"
        Me.GridColumnSalesReturnQCNumber.FieldName = "sales_return_qc_number"
        Me.GridColumnSalesReturnQCNumber.Name = "GridColumnSalesReturnQCNumber"
        Me.GridColumnSalesReturnQCNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnSalesReturnQCNumber.Visible = True
        Me.GridColumnSalesReturnQCNumber.VisibleIndex = 0
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Return Number"
        Me.GridColumn33.FieldName = "sales_return_number"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.AllowEdit = False
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 1
        '
        'GridColumnStoreNameFrom
        '
        Me.GridColumnStoreNameFrom.Caption = "Return From"
        Me.GridColumnStoreNameFrom.FieldName = "store_name_from"
        Me.GridColumnStoreNameFrom.Name = "GridColumnStoreNameFrom"
        Me.GridColumnStoreNameFrom.OptionsColumn.AllowEdit = False
        Me.GridColumnStoreNameFrom.Visible = True
        Me.GridColumnStoreNameFrom.VisibleIndex = 2
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Created Date"
        Me.GridColumn34.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn34.FieldName = "sales_return_qc_date"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.AllowEdit = False
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 5
        '
        'GridColumnQCCategory
        '
        Me.GridColumnQCCategory.Caption = "QC Category"
        Me.GridColumnQCCategory.FieldName = "pl_category"
        Me.GridColumnQCCategory.Name = "GridColumnQCCategory"
        Me.GridColumnQCCategory.OptionsColumn.AllowEdit = False
        Me.GridColumnQCCategory.Visible = True
        Me.GridColumnQCCategory.VisibleIndex = 4
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Status"
        Me.GridColumn35.FieldName = "report_status"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.OptionsColumn.AllowEdit = False
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 8
        '
        'GridColumnCompTo
        '
        Me.GridColumnCompTo.Caption = "Destination"
        Me.GridColumnCompTo.FieldName = "comp_name_to"
        Me.GridColumnCompTo.Name = "GridColumnCompTo"
        Me.GridColumnCompTo.OptionsColumn.AllowEdit = False
        Me.GridColumnCompTo.Visible = True
        Me.GridColumnCompTo.VisibleIndex = 3
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Last Updated"
        Me.GridColumn36.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumn36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn36.FieldName = "last_update"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.OptionsColumn.AllowEdit = False
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 6
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Updated By"
        Me.GridColumn37.FieldName = "last_user"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.AllowEdit = False
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 7
        '
        'GridColumn38
        '
        Me.GridColumn38.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn38.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn38.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn38.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn38.Caption = "Select"
        Me.GridColumn38.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.GridColumn38.FieldName = "is_select"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 9
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        Me.RepositoryItemCheckEdit4.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit4.ValueUnchecked = "No"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl3.Controls.Add(Me.BtnUpdateReturnQC)
        Me.GroupControl3.Controls.Add(Me.SLEStatusReturnQC)
        Me.GroupControl3.Controls.Add(Me.BtnViewReturnQC)
        Me.GroupControl3.Controls.Add(Me.LabelControl16)
        Me.GroupControl3.Controls.Add(Me.SimpleButton11)
        Me.GroupControl3.Controls.Add(Me.SimpleButton12)
        Me.GroupControl3.Controls.Add(Me.DEUntilReturnQC)
        Me.GroupControl3.Controls.Add(Me.DEFromReturnQC)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(754, 39)
        Me.GroupControl3.TabIndex = 6
        '
        'BtnUpdateReturnQC
        '
        Me.BtnUpdateReturnQC.Location = New System.Drawing.Point(574, 9)
        Me.BtnUpdateReturnQC.LookAndFeel.SkinName = "Blue"
        Me.BtnUpdateReturnQC.Name = "BtnUpdateReturnQC"
        Me.BtnUpdateReturnQC.Size = New System.Drawing.Size(84, 20)
        Me.BtnUpdateReturnQC.TabIndex = 8900
        Me.BtnUpdateReturnQC.Text = "Update Status"
        '
        'SLEStatusReturnQC
        '
        Me.SLEStatusReturnQC.Location = New System.Drawing.Point(354, 9)
        Me.SLEStatusReturnQC.Name = "SLEStatusReturnQC"
        Me.SLEStatusReturnQC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEStatusReturnQC.Properties.ShowClearButton = False
        Me.SLEStatusReturnQC.Properties.View = Me.GridView8
        Me.SLEStatusReturnQC.Size = New System.Drawing.Size(156, 20)
        Me.SLEStatusReturnQC.TabIndex = 8897
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn32})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Id Report Status"
        Me.GridColumn31.FieldName = "id_report_status"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Status"
        Me.GridColumn32.FieldName = "report_status"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 0
        '
        'BtnViewReturnQC
        '
        Me.BtnViewReturnQC.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewReturnQC.LookAndFeel.SkinName = "Blue"
        Me.BtnViewReturnQC.Name = "BtnViewReturnQC"
        Me.BtnViewReturnQC.Size = New System.Drawing.Size(55, 20)
        Me.BtnViewReturnQC.TabIndex = 8896
        Me.BtnViewReturnQC.Text = "View"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl16.TabIndex = 8899
        Me.LabelControl16.Text = "Status"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.ImageIndex = 9
        Me.SimpleButton11.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton11.TabIndex = 8898
        Me.SimpleButton11.Text = "Hide All Detail"
        Me.SimpleButton11.Visible = False
        '
        'SimpleButton12
        '
        Me.SimpleButton12.ImageIndex = 8
        Me.SimpleButton12.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton12.TabIndex = 8897
        Me.SimpleButton12.Text = "Expand All Detail"
        Me.SimpleButton12.Visible = False
        '
        'DEUntilReturnQC
        '
        Me.DEUntilReturnQC.EditValue = Nothing
        Me.DEUntilReturnQC.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilReturnQC.Name = "DEUntilReturnQC"
        Me.DEUntilReturnQC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilReturnQC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilReturnQC.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilReturnQC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilReturnQC.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilReturnQC.TabIndex = 8895
        '
        'DEFromReturnQC
        '
        Me.DEFromReturnQC.EditValue = Nothing
        Me.DEFromReturnQC.Location = New System.Drawing.Point(58, 9)
        Me.DEFromReturnQC.Name = "DEFromReturnQC"
        Me.DEFromReturnQC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromReturnQC.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromReturnQC.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromReturnQC.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromReturnQC.Size = New System.Drawing.Size(111, 20)
        Me.DEFromReturnQC.TabIndex = 8894
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl17.TabIndex = 8893
        Me.LabelControl17.Text = "Until"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl18.TabIndex = 8892
        Me.LabelControl18.Text = "From"
        '
        'XTPTrf
        '
        Me.XTPTrf.Controls.Add(Me.GCFGTrf)
        Me.XTPTrf.Controls.Add(Me.GroupControl4)
        Me.XTPTrf.Name = "XTPTrf"
        Me.XTPTrf.Size = New System.Drawing.Size(754, 388)
        Me.XTPTrf.Text = "Transfer"
        '
        'GCFGTrf
        '
        Me.GCFGTrf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCFGTrf.Location = New System.Drawing.Point(0, 39)
        Me.GCFGTrf.MainView = Me.GVFGTrf
        Me.GCFGTrf.Name = "GCFGTrf"
        Me.GCFGTrf.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoTxtPrepOrder, Me.RepositoryItemCheckEdit5})
        Me.GCFGTrf.Size = New System.Drawing.Size(754, 349)
        Me.GCFGTrf.TabIndex = 8
        Me.GCFGTrf.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVFGTrf})
        '
        'GVFGTrf
        '
        Me.GVFGTrf.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnFGTrfNumber, Me.GridColumnCompNameFrom, Me.GridColumn41, Me.GridColumnFGTrfDate, Me.GridColumn42, Me.GridColumnPrepOrder, Me.GridColumnIdFgTrf, Me.GridColumn43, Me.GridColumnUpdatedBy, Me.GridColumnSelTrf})
        Me.GVFGTrf.GridControl = Me.GCFGTrf
        Me.GVFGTrf.Name = "GVFGTrf"
        Me.GVFGTrf.OptionsView.ShowGroupPanel = False
        '
        'GridColumnFGTrfNumber
        '
        Me.GridColumnFGTrfNumber.Caption = "Number"
        Me.GridColumnFGTrfNumber.FieldName = "fg_trf_number"
        Me.GridColumnFGTrfNumber.Name = "GridColumnFGTrfNumber"
        Me.GridColumnFGTrfNumber.OptionsColumn.AllowEdit = False
        Me.GridColumnFGTrfNumber.Visible = True
        Me.GridColumnFGTrfNumber.VisibleIndex = 0
        '
        'GridColumnCompNameFrom
        '
        Me.GridColumnCompNameFrom.Caption = "From"
        Me.GridColumnCompNameFrom.FieldName = "comp_name_from"
        Me.GridColumnCompNameFrom.Name = "GridColumnCompNameFrom"
        Me.GridColumnCompNameFrom.OptionsColumn.AllowEdit = False
        Me.GridColumnCompNameFrom.Visible = True
        Me.GridColumnCompNameFrom.VisibleIndex = 1
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "To"
        Me.GridColumn41.FieldName = "comp_name_to"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.AllowEdit = False
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 2
        '
        'GridColumnFGTrfDate
        '
        Me.GridColumnFGTrfDate.Caption = "Created Date"
        Me.GridColumnFGTrfDate.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumnFGTrfDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnFGTrfDate.FieldName = "fg_trf_date"
        Me.GridColumnFGTrfDate.Name = "GridColumnFGTrfDate"
        Me.GridColumnFGTrfDate.OptionsColumn.AllowEdit = False
        Me.GridColumnFGTrfDate.Visible = True
        Me.GridColumnFGTrfDate.VisibleIndex = 4
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Status"
        Me.GridColumn42.FieldName = "report_status"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.AllowEdit = False
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 7
        '
        'GridColumnPrepOrder
        '
        Me.GridColumnPrepOrder.Caption = "Prepare Order"
        Me.GridColumnPrepOrder.ColumnEdit = Me.RepoTxtPrepOrder
        Me.GridColumnPrepOrder.FieldName = "sales_order_number"
        Me.GridColumnPrepOrder.Name = "GridColumnPrepOrder"
        Me.GridColumnPrepOrder.OptionsColumn.AllowEdit = False
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
        Me.GridColumnIdFgTrf.OptionsColumn.AllowEdit = False
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Last Updated"
        Me.GridColumn43.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumn43.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn43.FieldName = "last_update"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.AllowEdit = False
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 5
        '
        'GridColumnUpdatedBy
        '
        Me.GridColumnUpdatedBy.Caption = "Updated By"
        Me.GridColumnUpdatedBy.FieldName = "last_user"
        Me.GridColumnUpdatedBy.Name = "GridColumnUpdatedBy"
        Me.GridColumnUpdatedBy.OptionsColumn.AllowEdit = False
        Me.GridColumnUpdatedBy.Visible = True
        Me.GridColumnUpdatedBy.VisibleIndex = 6
        '
        'GridColumnSelTrf
        '
        Me.GridColumnSelTrf.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnSelTrf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelTrf.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumnSelTrf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumnSelTrf.Caption = "Select"
        Me.GridColumnSelTrf.ColumnEdit = Me.RepositoryItemCheckEdit5
        Me.GridColumnSelTrf.FieldName = "is_select"
        Me.GridColumnSelTrf.Name = "GridColumnSelTrf"
        Me.GridColumnSelTrf.Visible = True
        Me.GridColumnSelTrf.VisibleIndex = 8
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        Me.RepositoryItemCheckEdit5.ValueChecked = "Yes"
        Me.RepositoryItemCheckEdit5.ValueUnchecked = "No"
        '
        'GroupControl4
        '
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl4.Controls.Add(Me.BtnUpdateTrf)
        Me.GroupControl4.Controls.Add(Me.SLEStatusTrf)
        Me.GroupControl4.Controls.Add(Me.BtnViewTrf)
        Me.GroupControl4.Controls.Add(Me.LabelControl19)
        Me.GroupControl4.Controls.Add(Me.SimpleButton13)
        Me.GroupControl4.Controls.Add(Me.SimpleButton14)
        Me.GroupControl4.Controls.Add(Me.DEUntilTrf)
        Me.GroupControl4.Controls.Add(Me.DEFromTrf)
        Me.GroupControl4.Controls.Add(Me.LabelControl20)
        Me.GroupControl4.Controls.Add(Me.LabelControl21)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(754, 39)
        Me.GroupControl4.TabIndex = 7
        '
        'BtnUpdateTrf
        '
        Me.BtnUpdateTrf.Location = New System.Drawing.Point(574, 9)
        Me.BtnUpdateTrf.LookAndFeel.SkinName = "Blue"
        Me.BtnUpdateTrf.Name = "BtnUpdateTrf"
        Me.BtnUpdateTrf.Size = New System.Drawing.Size(84, 20)
        Me.BtnUpdateTrf.TabIndex = 8900
        Me.BtnUpdateTrf.Text = "Update Status"
        '
        'SLEStatusTrf
        '
        Me.SLEStatusTrf.Location = New System.Drawing.Point(354, 9)
        Me.SLEStatusTrf.Name = "SLEStatusTrf"
        Me.SLEStatusTrf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEStatusTrf.Properties.ShowClearButton = False
        Me.SLEStatusTrf.Properties.View = Me.GridView9
        Me.SLEStatusTrf.Size = New System.Drawing.Size(156, 20)
        Me.SLEStatusTrf.TabIndex = 8897
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn39, Me.GridColumn40})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Id Report Status"
        Me.GridColumn39.FieldName = "id_report_status"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Status"
        Me.GridColumn40.FieldName = "report_status"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        '
        'BtnViewTrf
        '
        Me.BtnViewTrf.Location = New System.Drawing.Point(516, 9)
        Me.BtnViewTrf.LookAndFeel.SkinName = "Blue"
        Me.BtnViewTrf.Name = "BtnViewTrf"
        Me.BtnViewTrf.Size = New System.Drawing.Size(55, 20)
        Me.BtnViewTrf.TabIndex = 8896
        Me.BtnViewTrf.Text = "View"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(320, 12)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl19.TabIndex = 8899
        Me.LabelControl19.Text = "Status"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.ImageIndex = 9
        Me.SimpleButton13.Location = New System.Drawing.Point(938, 14)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(104, 20)
        Me.SimpleButton13.TabIndex = 8898
        Me.SimpleButton13.Text = "Hide All Detail"
        Me.SimpleButton13.Visible = False
        '
        'SimpleButton14
        '
        Me.SimpleButton14.ImageIndex = 8
        Me.SimpleButton14.Location = New System.Drawing.Point(835, 14)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(99, 20)
        Me.SimpleButton14.TabIndex = 8897
        Me.SimpleButton14.Text = "Expand All Detail"
        Me.SimpleButton14.Visible = False
        '
        'DEUntilTrf
        '
        Me.DEUntilTrf.EditValue = Nothing
        Me.DEUntilTrf.Location = New System.Drawing.Point(202, 9)
        Me.DEUntilTrf.Name = "DEUntilTrf"
        Me.DEUntilTrf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEUntilTrf.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEUntilTrf.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEUntilTrf.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEUntilTrf.Size = New System.Drawing.Size(111, 20)
        Me.DEUntilTrf.TabIndex = 8895
        '
        'DEFromTrf
        '
        Me.DEFromTrf.EditValue = Nothing
        Me.DEFromTrf.Location = New System.Drawing.Point(58, 9)
        Me.DEFromTrf.Name = "DEFromTrf"
        Me.DEFromTrf.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFromTrf.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DEFromTrf.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DEFromTrf.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DEFromTrf.Size = New System.Drawing.Size(111, 20)
        Me.DEFromTrf.TabIndex = 8894
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(175, 12)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl20.TabIndex = 8893
        Me.LabelControl20.Text = "Until"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(28, 12)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl21.TabIndex = 8892
        Me.LabelControl21.Text = "From"
        '
        'FormSalesOrderSvcLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 416)
        Me.Controls.Add(Me.XTCSvcLevel)
        Me.Name = "FormSalesOrderSvcLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finalize Status-Warehouse Dept"
        CType(Me.GCFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCFilter.ResumeLayout(False)
        Me.GCFilter.PerformLayout()
        CType(Me.SLEPackingStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntil.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewMenu.ResumeLayout(False)
        CType(Me.XTCSvcLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCSvcLevel.ResumeLayout(False)
        Me.XTPPrepareOrder.ResumeLayout(False)
        Me.XTPReturnOrder.ResumeLayout(False)
        CType(Me.GCSalesReturnOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesReturnOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCFilterRet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCFilterRet.ResumeLayout(False)
        Me.GCFilterRet.PerformLayout()
        CType(Me.SLEPackingStatusRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilRet.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromRet.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPRec.ResumeLayout(False)
        CType(Me.GCPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVPL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCFilterRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCFilterRec.ResumeLayout(False)
        Me.GCFilterRec.PerformLayout()
        CType(Me.SLEStatusRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilRec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromRec.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPDelOrder.ResumeLayout(False)
        CType(Me.GCSalesDelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesDelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SLEStatusDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromDO.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPReturn.ResumeLayout(False)
        CType(Me.GCSalesReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.SLEStatusReturn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilReturn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilReturn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromReturn.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromReturn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPReturnQC.ResumeLayout(False)
        CType(Me.GCSalesReturnQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesReturnQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.SLEStatusReturnQC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilReturnQC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilReturnQC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromReturnQC.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromReturnQC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPTrf.ResumeLayout(False)
        CType(Me.GCFGTrf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVFGTrf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoTxtPrepOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.SLEStatusTrf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilTrf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEUntilTrf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromTrf.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFromTrf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCFilter As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BHide As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BExpand As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntil As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SLEPackingStatus As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnIdPrepareStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrepareStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCSalesOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnSalesTargetNumb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSalesTargetDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDSalesTargetNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReportStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents GridColumnIdSalesOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReff As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ViewMenu As ContextMenuStrip
    Friend WithEvents SMView As ToolStripMenuItem
    Friend WithEvents ViewDetailOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatePackingStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XTCSvcLevel As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPPrepareOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPReturnOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCFilterRet As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SLEPackingStatusRet As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewRet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilRet As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromRet As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCSalesReturnOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesReturnOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnEstDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnTimeRemaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReturnQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnOrderQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCurrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSvcLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XTPRec As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCFilterRec As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SLEStatusRec As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewRec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilRec As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromRec As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCPL As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVPL As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdPLSample As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdContactFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdCompContactTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPLNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSRNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPLDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPLNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSeasno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPLCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDesignMain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnVendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdReportStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnUpdateRec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumnSelectRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLastUserRec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTPDelOrder As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnUpdateDO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLEStatusDO As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewDO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilDO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromDO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCSalesDelOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesDelOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdSalesDelOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnWHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XTPReturn As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnUpdateReturn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLEStatusReturn As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewReturn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilReturn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromReturn As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCSalesReturn As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesReturn As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnSalesReturnNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnReturnOrderNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompNameTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStoreRetNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLastUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSelReturn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XTPReturnQC As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnUpdateReturnQC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLEStatusReturnQC As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewReturnQC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilReturnQC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromReturnQC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCSalesReturnQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesReturnQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnSalesReturnQCNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnStoreNameFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnQCCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XTPTrf As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnUpdateTrf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLEStatusTrf As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnViewTrf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DEUntilTrf As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DEFromTrf As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCFGTrf As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVFGTrf As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnFGTrfNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCompNameFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFGTrfDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnPrepOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoTxtPrepOrder As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumnIdFgTrf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnSelTrf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
End Class
