﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductPriceSingle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductPriceSingle))
        Me.EPProductPrice = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.CEIsPrint = New DevExpress.XtraEditors.CheckEdit
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.PictureSeason = New DevExpress.XtraEditors.PictureEdit
        Me.BSave = New DevExpress.XtraEditors.SimpleButton
        Me.TEPrice = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TEPriceName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LECurrency = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.EPProductPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEIsPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureSeason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPriceName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EPProductPrice
        '
        Me.EPProductPrice.ContainerControl = Me
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(157, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 15)
        Me.LabelControl3.TabIndex = 120
        Me.LabelControl3.Text = "Currency"
        '
        'CEIsPrint
        '
        Me.CEIsPrint.Location = New System.Drawing.Point(155, 161)
        Me.CEIsPrint.Name = "CEIsPrint"
        Me.CEIsPrint.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CEIsPrint.Properties.Appearance.Options.UseFont = True
        Me.CEIsPrint.Properties.Caption = "Set As Printed Barcode Price"
        Me.CEIsPrint.Size = New System.Drawing.Size(201, 20)
        Me.CEIsPrint.TabIndex = 118
        '
        'BCancel
        '
        Me.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancel.Location = New System.Drawing.Point(303, 205)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(86, 20)
        Me.BCancel.TabIndex = 114
        Me.BCancel.Text = "Cancel"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.PictureSeason)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(151, 245)
        Me.PanelControl2.TabIndex = 117
        '
        'PictureSeason
        '
        Me.PictureSeason.EditValue = CType(resources.GetObject("PictureSeason.EditValue"), Object)
        Me.PictureSeason.Location = New System.Drawing.Point(12, 105)
        Me.PictureSeason.Name = "PictureSeason"
        Me.PictureSeason.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureSeason.Properties.Appearance.Options.UseBackColor = True
        Me.PictureSeason.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureSeason.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureSeason.Size = New System.Drawing.Size(124, 113)
        Me.PictureSeason.TabIndex = 19
        '
        'BSave
        '
        Me.BSave.Location = New System.Drawing.Point(395, 205)
        Me.BSave.Name = "BSave"
        Me.BSave.Size = New System.Drawing.Size(86, 20)
        Me.BSave.TabIndex = 113
        Me.BSave.Text = "Save"
        '
        'TEPrice
        '
        Me.TEPrice.Location = New System.Drawing.Point(157, 132)
        Me.TEPrice.Name = "TEPrice"
        Me.TEPrice.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TEPrice.Properties.Appearance.Options.UseFont = True
        Me.TEPrice.Properties.Mask.EditMask = "N2"
        Me.TEPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TEPrice.Properties.Mask.SaveLiteral = False
        Me.TEPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TEPrice.Size = New System.Drawing.Size(232, 23)
        Me.TEPrice.TabIndex = 116
        Me.TEPrice.ToolTip = "Example : 65000"
        Me.TEPrice.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(157, 114)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 15)
        Me.LabelControl4.TabIndex = 115
        Me.LabelControl4.Text = "Price"
        '
        'TEPriceName
        '
        Me.TEPriceName.Location = New System.Drawing.Point(157, 38)
        Me.TEPriceName.Name = "TEPriceName"
        Me.TEPriceName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TEPriceName.Properties.Appearance.Options.UseFont = True
        Me.TEPriceName.Size = New System.Drawing.Size(324, 23)
        Me.TEPriceName.TabIndex = 112
        Me.TEPriceName.ToolTip = "Example : Price Estimation"
        Me.TEPriceName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(157, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl1.TabIndex = 111
        Me.LabelControl1.Text = "Price Name"
        '
        'LECurrency
        '
        Me.LECurrency.Location = New System.Drawing.Point(157, 88)
        Me.LECurrency.Name = "LECurrency"
        Me.LECurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LECurrency.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_currency", "Id Currency", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("currency", "Currency")})
        Me.LECurrency.Properties.NullText = ""
        Me.LECurrency.Properties.ShowFooter = False
        Me.LECurrency.Size = New System.Drawing.Size(160, 20)
        Me.LECurrency.TabIndex = 119
        '
        'FormProductPriceSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 245)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.CEIsPrint)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.TEPrice)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TEPriceName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LECurrency)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProductPriceSingle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Price"
        CType(Me.EPProductPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEIsPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureSeason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPriceName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LECurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EPProductPrice As System.Windows.Forms.ErrorProvider
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEIsPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureSeason As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPriceName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LECurrency As DevExpress.XtraEditors.LookUpEdit
End Class
