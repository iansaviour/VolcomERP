﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterOVHPrcSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterOVHPrcSingle))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdComp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCompNumber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCompName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCompAddress = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCompCat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PictureSeason = New DevExpress.XtraEditors.PictureEdit
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton
        Me.TxtPrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TxtPriceName = New DevExpress.XtraEditors.TextEdit
        Me.EPPrice = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColIdCompContact = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColCompContact = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SLEVendorContact = New DevExpress.XtraEditors.SearchLookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.SLEVendor = New DevExpress.XtraEditors.SearchLookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LECurrency = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureSeason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPriceName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLEVendorContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLEVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdComp, Me.ColCompNumber, Me.ColCompName, Me.ColCompAddress, Me.ColCompCat})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ColIdComp
        '
        Me.ColIdComp.Caption = "Id Company"
        Me.ColIdComp.FieldName = "id_comp"
        Me.ColIdComp.Name = "ColIdComp"
        '
        'ColCompNumber
        '
        Me.ColCompNumber.Caption = "Code"
        Me.ColCompNumber.FieldName = "comp_number"
        Me.ColCompNumber.Name = "ColCompNumber"
        Me.ColCompNumber.Visible = True
        Me.ColCompNumber.VisibleIndex = 0
        '
        'ColCompName
        '
        Me.ColCompName.Caption = "Company"
        Me.ColCompName.FieldName = "comp_name"
        Me.ColCompName.Name = "ColCompName"
        Me.ColCompName.Visible = True
        Me.ColCompName.VisibleIndex = 1
        '
        'ColCompAddress
        '
        Me.ColCompAddress.Caption = "Address"
        Me.ColCompAddress.FieldName = "address_primary"
        Me.ColCompAddress.Name = "ColCompAddress"
        Me.ColCompAddress.Visible = True
        Me.ColCompAddress.VisibleIndex = 2
        '
        'ColCompCat
        '
        Me.ColCompCat.Caption = "Category"
        Me.ColCompCat.FieldName = "comp_cat_name"
        Me.ColCompCat.Name = "ColCompCat"
        Me.ColCompCat.Visible = True
        Me.ColCompCat.VisibleIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.PictureSeason)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(153, 256)
        Me.PanelControl2.TabIndex = 122
        '
        'PictureSeason
        '
        Me.PictureSeason.EditValue = CType(resources.GetObject("PictureSeason.EditValue"), Object)
        Me.PictureSeason.Location = New System.Drawing.Point(12, 83)
        Me.PictureSeason.Name = "PictureSeason"
        Me.PictureSeason.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureSeason.Properties.Appearance.Options.UseBackColor = True
        Me.PictureSeason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureSeason.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureSeason.Size = New System.Drawing.Size(124, 113)
        Me.PictureSeason.TabIndex = 19
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(480, 216)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(86, 20)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Save"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(369, 173)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TxtPrice.Properties.Appearance.Options.UseFont = True
        Me.TxtPrice.Properties.Mask.EditMask = "N2"
        Me.TxtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtPrice.Properties.Mask.SaveLiteral = False
        Me.TxtPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TxtPrice.Size = New System.Drawing.Size(197, 23)
        Me.TxtPrice.TabIndex = 4
        Me.TxtPrice.ToolTip = "Example : 65000"
        Me.TxtPrice.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.TxtPrice.ToolTipTitle = "Info"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(369, 152)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 15)
        Me.LabelControl4.TabIndex = 121
        Me.LabelControl4.Text = "Price"
        '
        'TxtPriceName
        '
        Me.TxtPriceName.Location = New System.Drawing.Point(182, 123)
        Me.TxtPriceName.Name = "TxtPriceName"
        Me.TxtPriceName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TxtPriceName.Properties.Appearance.Options.UseFont = True
        Me.TxtPriceName.Properties.MaxLength = 50
        Me.TxtPriceName.Size = New System.Drawing.Size(384, 23)
        Me.TxtPriceName.TabIndex = 2
        Me.TxtPriceName.ToolTip = "Example : Price Estimation, Regular, etc. Max : 50 character."
        Me.TxtPriceName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.TxtPriceName.ToolTipTitle = "Info"
        '
        'EPPrice
        '
        Me.EPPrice.ContainerControl = Me
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(388, 216)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(86, 20)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColIdCompContact, Me.ColCompContact})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'ColIdCompContact
        '
        Me.ColIdCompContact.Caption = "Id Contact"
        Me.ColIdCompContact.FieldName = "id_comp_contact"
        Me.ColIdCompContact.Name = "ColIdCompContact"
        '
        'ColCompContact
        '
        Me.ColCompContact.Caption = "Contact Person"
        Me.ColCompContact.FieldName = "contact_person"
        Me.ColCompContact.Name = "ColCompContact"
        Me.ColCompContact.Visible = True
        Me.ColCompContact.VisibleIndex = 0
        '
        'SLEVendorContact
        '
        Me.SLEVendorContact.Location = New System.Drawing.Point(182, 76)
        Me.SLEVendorContact.Name = "SLEVendorContact"
        Me.SLEVendorContact.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEVendorContact.Properties.NullText = ""
        Me.SLEVendorContact.Properties.ShowFooter = False
        Me.SLEVendorContact.Properties.View = Me.GridView2
        Me.SLEVendorContact.Size = New System.Drawing.Size(384, 20)
        Me.SLEVendorContact.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(182, 102)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl1.TabIndex = 118
        Me.LabelControl1.Text = "Price Name"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(182, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 15)
        Me.LabelControl3.TabIndex = 120
        Me.LabelControl3.Text = "Contact"
        '
        'SLEVendor
        '
        Me.SLEVendor.Location = New System.Drawing.Point(182, 29)
        Me.SLEVendor.Name = "SLEVendor"
        Me.SLEVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLEVendor.Properties.NullText = ""
        Me.SLEVendor.Properties.ShowFooter = False
        Me.SLEVendor.Properties.View = Me.GridView1
        Me.SLEVendor.Size = New System.Drawing.Size(384, 20)
        Me.SLEVendor.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(182, 8)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 15)
        Me.LabelControl2.TabIndex = 119
        Me.LabelControl2.Text = "Vendor"
        '
        'LECurrency
        '
        Me.LECurrency.Location = New System.Drawing.Point(182, 174)
        Me.LECurrency.Name = "LECurrency"
        Me.LECurrency.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LECurrency.Properties.Appearance.Options.UseFont = True
        Me.LECurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LECurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_currency", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("currency", "Currency")})
        Me.LECurrency.Size = New System.Drawing.Size(181, 22)
        Me.LECurrency.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(182, 153)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl5.TabIndex = 124
        Me.LabelControl5.Text = "Currency"
        '
        'FormMasterOVHPrcSingle
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(595, 256)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LECurrency)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TxtPriceName)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.SLEVendorContact)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.SLEVendor)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMasterOVHPrcSingle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overhead Price"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureSeason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPriceName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLEVendorContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLEVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColIdComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCompCat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureSeason As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ColCompContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColIdCompContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtPriceName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EPPrice As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLEVendorContact As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SLEVendor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LECurrency As DevExpress.XtraEditors.LookUpEdit
End Class
