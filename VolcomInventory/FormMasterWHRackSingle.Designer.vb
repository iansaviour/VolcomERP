﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterWHRackSingle
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
        Me.MEDesription = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelSubTitle = New DevExpress.XtraEditors.LabelControl
        Me.LabelTitle = New DevExpress.XtraEditors.LabelControl
        Me.TxtRackName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TxtRackCode = New DevExpress.XtraEditors.TextEdit
        Me.LabelSeason = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton
        Me.EPWH = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.MEDesription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TxtRackName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRackCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.EPWH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEDesription
        '
        Me.MEDesription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MEDesription.Location = New System.Drawing.Point(103, 135)
        Me.MEDesription.Name = "MEDesription"
        Me.MEDesription.Size = New System.Drawing.Size(542, 100)
        Me.MEDesription.TabIndex = 41
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 137)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl2.TabIndex = 40
        Me.LabelControl2.Text = "Description"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Blue
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.LabelSubTitle)
        Me.PanelControl2.Controls.Add(Me.LabelTitle)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2007 Blue"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(657, 59)
        Me.PanelControl2.TabIndex = 39
        '
        'LabelSubTitle
        '
        Me.LabelSubTitle.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubTitle.Location = New System.Drawing.Point(12, 32)
        Me.LabelSubTitle.Name = "LabelSubTitle"
        Me.LabelSubTitle.Size = New System.Drawing.Size(145, 15)
        Me.LabelSubTitle.TabIndex = 30
        Me.LabelSubTitle.Text = "Warehouse / Locator : xxx "
        '
        'LabelTitle
        '
        Me.LabelTitle.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(11, 10)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(133, 23)
        Me.LabelTitle.TabIndex = 29
        Me.LabelTitle.Text = "Rack Description"
        '
        'TxtRackName
        '
        Me.TxtRackName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRackName.Location = New System.Drawing.Point(103, 103)
        Me.TxtRackName.Name = "TxtRackName"
        Me.TxtRackName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRackName.Properties.Appearance.Options.UseFont = True
        Me.TxtRackName.Properties.MaxLength = 50
        Me.TxtRackName.Size = New System.Drawing.Size(542, 22)
        Me.TxtRackName.TabIndex = 38
        Me.TxtRackName.ToolTip = "Max :  50 character."
        Me.TxtRackName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.TxtRackName.ToolTipTitle = "Information"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 15)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Rack Name"
        '
        'TxtRackCode
        '
        Me.TxtRackCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRackCode.Location = New System.Drawing.Point(103, 75)
        Me.TxtRackCode.Name = "TxtRackCode"
        Me.TxtRackCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRackCode.Properties.Appearance.Options.UseFont = True
        Me.TxtRackCode.Properties.MaxLength = 20
        Me.TxtRackCode.Size = New System.Drawing.Size(542, 22)
        Me.TxtRackCode.TabIndex = 35
        Me.TxtRackCode.ToolTip = "Max :  20 character."
        Me.TxtRackCode.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.TxtRackCode.ToolTipTitle = "Information"
        '
        'LabelSeason
        '
        Me.LabelSeason.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeason.Location = New System.Drawing.Point(12, 82)
        Me.LabelSeason.Name = "LabelSeason"
        Me.LabelSeason.Size = New System.Drawing.Size(56, 15)
        Me.LabelSeason.TabIndex = 36
        Me.LabelSeason.Text = "Rack Code"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnCancel)
        Me.PanelControl1.Controls.Add(Me.BtnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 262)
        Me.PanelControl1.LookAndFeel.SkinName = "Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(657, 40)
        Me.PanelControl1.TabIndex = 34
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancel.Location = New System.Drawing.Point(505, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 36)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSave.Location = New System.Drawing.Point(580, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 36)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        '
        'EPWH
        '
        Me.EPWH.ContainerControl = Me
        '
        'FormMasterWHRackSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 302)
        Me.Controls.Add(Me.MEDesription)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.TxtRackName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.TxtRackCode)
        Me.Controls.Add(Me.LabelSeason)
        Me.Controls.Add(Me.PanelControl1)
        Me.MinimizeBox = False
        Me.Name = "FormMasterWHRackSingle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rack"
        CType(Me.MEDesription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TxtRackName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRackCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.EPWH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEDesription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelSubTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRackName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRackCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelSeason As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EPWH As System.Windows.Forms.ErrorProvider
End Class
