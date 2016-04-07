﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterRawMaterial
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
        Me.XTCMaterialType = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPRawMaterial = New DevExpress.XtraTab.XtraTabPage()
        Me.GCRawMat = New DevExpress.XtraGrid.GridControl()
        Me.GVRawMat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColumnIdRawMat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnMatCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColumnRawMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColumnMatDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCategoryMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColumnUOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XTPMaterialDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.GCMatDetail = New DevExpress.XtraGrid.GridControl()
        Me.GVMatDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColumnIdMatDet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnMatDetCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnMatDetName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnMatDetDisplayName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnMethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnLifetime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnDateCreated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelMatContent = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnImportFK = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XTCMaterialType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCMaterialType.SuspendLayout()
        Me.XTPRawMaterial.SuspendLayout()
        CType(Me.GCRawMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRawMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPMaterialDetail.SuspendLayout()
        CType(Me.GCMatDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVMatDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XTCMaterialType
        '
        Me.XTCMaterialType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCMaterialType.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XTCMaterialType.Location = New System.Drawing.Point(0, 0)
        Me.XTCMaterialType.LookAndFeel.SkinName = "Seven Classic"
        Me.XTCMaterialType.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XTCMaterialType.Name = "XTCMaterialType"
        Me.XTCMaterialType.SelectedTabPage = Me.XTPRawMaterial
        Me.XTCMaterialType.Size = New System.Drawing.Size(623, 308)
        Me.XTCMaterialType.TabIndex = 0
        Me.XTCMaterialType.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPRawMaterial, Me.XTPMaterialDetail})
        '
        'XTPRawMaterial
        '
        Me.XTPRawMaterial.Controls.Add(Me.GCRawMat)
        Me.XTPRawMaterial.Controls.Add(Me.PanelControl2)
        Me.XTPRawMaterial.Name = "XTPRawMaterial"
        Me.XTPRawMaterial.Size = New System.Drawing.Size(597, 305)
        Me.XTPRawMaterial.Text = "Sub Category"
        '
        'GCRawMat
        '
        Me.GCRawMat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCRawMat.Location = New System.Drawing.Point(0, 46)
        Me.GCRawMat.MainView = Me.GVRawMat
        Me.GCRawMat.Name = "GCRawMat"
        Me.GCRawMat.Size = New System.Drawing.Size(597, 259)
        Me.GCRawMat.TabIndex = 2
        Me.GCRawMat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRawMat, Me.GridView2})
        '
        'GVRawMat
        '
        Me.GVRawMat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColumnIdRawMat, Me.GridColumnMatCode, Me.ColumnRawMaterial, Me.ColumnMatDisplayName, Me.GridColumnCategoryMaterial, Me.ColumnUOM})
        Me.GVRawMat.GridControl = Me.GCRawMat
        Me.GVRawMat.Name = "GVRawMat"
        Me.GVRawMat.OptionsBehavior.Editable = False
        Me.GVRawMat.OptionsFind.AlwaysVisible = True
        Me.GVRawMat.OptionsView.ShowGroupPanel = False
        '
        'ColumnIdRawMat
        '
        Me.ColumnIdRawMat.Caption = "Id Raw Mat"
        Me.ColumnIdRawMat.FieldName = "id_mat"
        Me.ColumnIdRawMat.Name = "ColumnIdRawMat"
        '
        'GridColumnMatCode
        '
        Me.GridColumnMatCode.Caption = "Code"
        Me.GridColumnMatCode.FieldName = "mat_code"
        Me.GridColumnMatCode.Name = "GridColumnMatCode"
        Me.GridColumnMatCode.Visible = True
        Me.GridColumnMatCode.VisibleIndex = 0
        '
        'ColumnRawMaterial
        '
        Me.ColumnRawMaterial.Caption = "Material Name"
        Me.ColumnRawMaterial.FieldName = "mat_name"
        Me.ColumnRawMaterial.Name = "ColumnRawMaterial"
        Me.ColumnRawMaterial.Visible = True
        Me.ColumnRawMaterial.VisibleIndex = 1
        '
        'ColumnMatDisplayName
        '
        Me.ColumnMatDisplayName.Caption = "Material Display Name"
        Me.ColumnMatDisplayName.FieldName = "mat_display_name"
        Me.ColumnMatDisplayName.Name = "ColumnMatDisplayName"
        Me.ColumnMatDisplayName.Visible = True
        Me.ColumnMatDisplayName.VisibleIndex = 2
        '
        'GridColumnCategoryMaterial
        '
        Me.GridColumnCategoryMaterial.Caption = "Category"
        Me.GridColumnCategoryMaterial.FieldName = "mat_cat"
        Me.GridColumnCategoryMaterial.Name = "GridColumnCategoryMaterial"
        Me.GridColumnCategoryMaterial.Visible = True
        Me.GridColumnCategoryMaterial.VisibleIndex = 3
        '
        'ColumnUOM
        '
        Me.ColumnUOM.Caption = "UOM"
        Me.ColumnUOM.FieldName = "uom"
        Me.ColumnUOM.Name = "ColumnUOM"
        Me.ColumnUOM.Visible = True
        Me.ColumnUOM.VisibleIndex = 4
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCRawMat
        Me.GridView2.Name = "GridView2"
        '
        'XTPMaterialDetail
        '
        Me.XTPMaterialDetail.Controls.Add(Me.GCMatDetail)
        Me.XTPMaterialDetail.Controls.Add(Me.PanelControl1)
        Me.XTPMaterialDetail.Name = "XTPMaterialDetail"
        Me.XTPMaterialDetail.Size = New System.Drawing.Size(597, 305)
        Me.XTPMaterialDetail.Text = "Raw Material"
        '
        'GCMatDetail
        '
        Me.GCMatDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCMatDetail.Location = New System.Drawing.Point(0, 44)
        Me.GCMatDetail.MainView = Me.GVMatDetail
        Me.GCMatDetail.Name = "GCMatDetail"
        Me.GCMatDetail.Size = New System.Drawing.Size(597, 261)
        Me.GCMatDetail.TabIndex = 3
        Me.GCMatDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVMatDetail})
        '
        'GVMatDetail
        '
        Me.GVMatDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColumnIdMatDet, Me.GridColumnMatDetCode, Me.GridColumnMatDetName, Me.GridColumnMatDetDisplayName, Me.GridColumnMethod, Me.GridColumnLifetime, Me.GridColumnDateCreated})
        Me.GVMatDetail.GridControl = Me.GCMatDetail
        Me.GVMatDetail.Name = "GVMatDetail"
        Me.GVMatDetail.OptionsBehavior.Editable = False
        Me.GVMatDetail.OptionsFind.AlwaysVisible = True
        Me.GVMatDetail.OptionsView.ShowGroupPanel = False
        '
        'ColumnIdMatDet
        '
        Me.ColumnIdMatDet.Caption = "ID"
        Me.ColumnIdMatDet.FieldName = "id_mat_det"
        Me.ColumnIdMatDet.Name = "ColumnIdMatDet"
        '
        'GridColumnMatDetCode
        '
        Me.GridColumnMatDetCode.Caption = "Code"
        Me.GridColumnMatDetCode.FieldName = "mat_det_code"
        Me.GridColumnMatDetCode.Name = "GridColumnMatDetCode"
        Me.GridColumnMatDetCode.Visible = True
        Me.GridColumnMatDetCode.VisibleIndex = 0
        '
        'GridColumnMatDetName
        '
        Me.GridColumnMatDetName.Caption = "Name"
        Me.GridColumnMatDetName.FieldName = "mat_det_name"
        Me.GridColumnMatDetName.Name = "GridColumnMatDetName"
        Me.GridColumnMatDetName.Visible = True
        Me.GridColumnMatDetName.VisibleIndex = 1
        '
        'GridColumnMatDetDisplayName
        '
        Me.GridColumnMatDetDisplayName.Caption = "Display Name"
        Me.GridColumnMatDetDisplayName.FieldName = "mat_det_display_name"
        Me.GridColumnMatDetDisplayName.Name = "GridColumnMatDetDisplayName"
        Me.GridColumnMatDetDisplayName.Visible = True
        Me.GridColumnMatDetDisplayName.VisibleIndex = 2
        '
        'GridColumnMethod
        '
        Me.GridColumnMethod.Caption = "Method"
        Me.GridColumnMethod.FieldName = "method"
        Me.GridColumnMethod.Name = "GridColumnMethod"
        Me.GridColumnMethod.Visible = True
        Me.GridColumnMethod.VisibleIndex = 3
        '
        'GridColumnLifetime
        '
        Me.GridColumnLifetime.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumnLifetime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumnLifetime.Caption = "Lifetime (day)"
        Me.GridColumnLifetime.FieldName = "lifetime"
        Me.GridColumnLifetime.Name = "GridColumnLifetime"
        Me.GridColumnLifetime.Visible = True
        Me.GridColumnLifetime.VisibleIndex = 4
        '
        'GridColumnDateCreated
        '
        Me.GridColumnDateCreated.Caption = "Date Created"
        Me.GridColumnDateCreated.FieldName = "mat_det_date"
        Me.GridColumnDateCreated.Name = "GridColumnDateCreated"
        Me.GridColumnDateCreated.Visible = True
        Me.GridColumnDateCreated.VisibleIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelMatContent)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(597, 44)
        Me.PanelControl1.TabIndex = 2
        '
        'LabelMatContent
        '
        Me.LabelMatContent.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMatContent.Location = New System.Drawing.Point(147, 9)
        Me.LabelMatContent.Name = "LabelMatContent"
        Me.LabelMatContent.Size = New System.Drawing.Size(6, 26)
        Me.LabelMatContent.TabIndex = 6
        Me.LabelMatContent.Text = "-"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(11, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(134, 26)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Material Type : "
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BtnImportFK)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(597, 46)
        Me.PanelControl2.TabIndex = 3
        '
        'BtnImportFK
        '
        Me.BtnImportFK.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnImportFK.Location = New System.Drawing.Point(476, 2)
        Me.BtnImportFK.Name = "BtnImportFK"
        Me.BtnImportFK.Size = New System.Drawing.Size(119, 42)
        Me.BtnImportFK.TabIndex = 4
        Me.BtnImportFK.Text = "Import Excel"
        '
        'FormMasterRawMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 308)
        Me.Controls.Add(Me.XTCMaterialType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMasterRawMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raw Material"
        CType(Me.XTCMaterialType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCMaterialType.ResumeLayout(False)
        Me.XTPRawMaterial.ResumeLayout(False)
        CType(Me.GCRawMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRawMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPMaterialDetail.ResumeLayout(False)
        CType(Me.GCMatDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVMatDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTCMaterialType As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPRawMaterial As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPMaterialDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCRawMat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRawMat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColumnIdRawMat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColumnRawMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColumnUOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColumnMatDisplayName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelMatContent As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCMatDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVMatDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColumnIdMatDet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMatDetCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMatDetName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMatDetDisplayName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnLifetime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnDateCreated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMatCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCategoryMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnImportFK As DevExpress.XtraEditors.SimpleButton
End Class
