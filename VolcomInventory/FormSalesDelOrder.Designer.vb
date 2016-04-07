<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesDelOrder
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
        Me.XTCSalesDelOrder = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPListDel = New DevExpress.XtraTab.XtraTabPage()
        Me.GCSalesDelOrder = New DevExpress.XtraGrid.GridControl()
        Me.GVSalesDelOrder = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnIdSalesDelOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnWHName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLastUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnUpdBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ViewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SMPrePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMPrint = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.XTCSalesDelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCSalesDelOrder.SuspendLayout()
        Me.XTPListDel.SuspendLayout()
        CType(Me.GCSalesDelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSalesDelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTCSalesDelOrder
        '
        Me.XTCSalesDelOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCSalesDelOrder.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XTCSalesDelOrder.Location = New System.Drawing.Point(0, 0)
        Me.XTCSalesDelOrder.Name = "XTCSalesDelOrder"
        Me.XTCSalesDelOrder.SelectedTabPage = Me.XTPListDel
        Me.XTCSalesDelOrder.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.XTCSalesDelOrder.Size = New System.Drawing.Size(805, 490)
        Me.XTCSalesDelOrder.TabIndex = 0
        Me.XTCSalesDelOrder.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPListDel})
        '
        'XTPListDel
        '
        Me.XTPListDel.Controls.Add(Me.GCSalesDelOrder)
        Me.XTPListDel.Name = "XTPListDel"
        Me.XTPListDel.Size = New System.Drawing.Size(799, 484)
        Me.XTPListDel.Text = "List Delivery"
        '
        'GCSalesDelOrder
        '
        Me.GCSalesDelOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCSalesDelOrder.Location = New System.Drawing.Point(0, 0)
        Me.GCSalesDelOrder.MainView = Me.GVSalesDelOrder
        Me.GCSalesDelOrder.Name = "GCSalesDelOrder"
        Me.GCSalesDelOrder.Size = New System.Drawing.Size(799, 484)
        Me.GCSalesDelOrder.TabIndex = 2
        Me.GCSalesDelOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSalesDelOrder, Me.GridView3})
        '
        'GVSalesDelOrder
        '
        Me.GVSalesDelOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumnIdSalesDelOrder, Me.GridColumnWHName, Me.GridColumnCategory, Me.GridColumnLastUpdate, Me.GridColumnUpdBy})
        Me.GVSalesDelOrder.GridControl = Me.GCSalesDelOrder
        Me.GVSalesDelOrder.Name = "GVSalesDelOrder"
        Me.GVSalesDelOrder.OptionsBehavior.AutoExpandAllGroups = True
        Me.GVSalesDelOrder.OptionsBehavior.Editable = False
        Me.GVSalesDelOrder.OptionsBehavior.ReadOnly = True
        Me.GVSalesDelOrder.OptionsView.ShowGroupPanel = False
        Me.GVSalesDelOrder.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumnIdSalesDelOrder, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Number"
        Me.GridColumn1.FieldName = "pl_sales_order_del_number"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 83
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Store"
        Me.GridColumn2.FieldName = "store_name_to"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Created Date"
        Me.GridColumn3.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "pl_sales_order_del_date"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Note"
        Me.GridColumn4.FieldName = "pl_sales_order_del_note"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Status"
        Me.GridColumn5.FieldName = "report_status"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Prepare Order"
        Me.GridColumn8.FieldName = "sales_order_number"
        Me.GridColumn8.FieldNameSortGroup = "id_pl_sales_order_del"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'GridColumnIdSalesDelOrder
        '
        Me.GridColumnIdSalesDelOrder.Caption = "Id Sales Del Order"
        Me.GridColumnIdSalesDelOrder.FieldName = "id_pl_sales_order_del"
        Me.GridColumnIdSalesDelOrder.Name = "GridColumnIdSalesDelOrder"
        Me.GridColumnIdSalesDelOrder.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumnWHName
        '
        Me.GridColumnWHName.Caption = "Warehouse"
        Me.GridColumnWHName.FieldName = "wh_name"
        Me.GridColumnWHName.FieldNameSortGroup = "id_wh"
        Me.GridColumnWHName.Name = "GridColumnWHName"
        Me.GridColumnWHName.Visible = True
        Me.GridColumnWHName.VisibleIndex = 1
        '
        'GridColumnCategory
        '
        Me.GridColumnCategory.Caption = "Category"
        Me.GridColumnCategory.FieldName = "so_status"
        Me.GridColumnCategory.FieldNameSortGroup = "id_so_status"
        Me.GridColumnCategory.Name = "GridColumnCategory"
        Me.GridColumnCategory.Visible = True
        Me.GridColumnCategory.VisibleIndex = 4
        '
        'GridColumnLastUpdate
        '
        Me.GridColumnLastUpdate.Caption = "Last Updated"
        Me.GridColumnLastUpdate.DisplayFormat.FormatString = "dd MMMM yyyy'/'hh:mm tt"
        Me.GridColumnLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnLastUpdate.FieldName = "last_update"
        Me.GridColumnLastUpdate.Name = "GridColumnLastUpdate"
        Me.GridColumnLastUpdate.Visible = True
        Me.GridColumnLastUpdate.VisibleIndex = 6
        '
        'GridColumnUpdBy
        '
        Me.GridColumnUpdBy.Caption = "Updated By"
        Me.GridColumnUpdBy.FieldName = "last_user"
        Me.GridColumnUpdBy.Name = "GridColumnUpdBy"
        Me.GridColumnUpdBy.Visible = True
        Me.GridColumnUpdBy.VisibleIndex = 7
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GCSalesDelOrder
        Me.GridView3.Name = "GridView3"
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
        'FormSalesDelOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 490)
        Me.Controls.Add(Me.XTCSalesDelOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSalesDelOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery"
        CType(Me.XTCSalesDelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCSalesDelOrder.ResumeLayout(False)
        Me.XTPListDel.ResumeLayout(False)
        CType(Me.GCSalesDelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSalesDelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTCSalesDelOrder As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPListDel As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCSalesDelOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSalesDelOrder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnIdSalesDelOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnWHName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViewMenu As ContextMenuStrip
    Friend WithEvents SMPrePrint As ToolStripMenuItem
    Friend WithEvents SMPrint As ToolStripMenuItem
    Friend WithEvents GridColumnLastUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnUpdBy As DevExpress.XtraGrid.Columns.GridColumn
End Class
