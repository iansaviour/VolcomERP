﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterArea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterArea))
        Me.LargeImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.XTCArea = New DevExpress.XtraTab.XtraTabControl
        Me.XTCountry = New DevExpress.XtraTab.XtraTabPage
        Me.GCCountry = New DevExpress.XtraGrid.GridControl
        Me.GVCountry = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id_country = New DevExpress.XtraGrid.Columns.GridColumn
        Me.country = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnCountryDisplayName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XTRegion = New DevExpress.XtraTab.XtraTabPage
        Me.GCRegion = New DevExpress.XtraGrid.GridControl
        Me.GVRegion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LCountry = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.XTState = New DevExpress.XtraTab.XtraTabPage
        Me.GCState = New DevExpress.XtraGrid.GridControl
        Me.GVState = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id_state = New DevExpress.XtraGrid.Columns.GridColumn
        Me.state = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LRegion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.XTCity = New DevExpress.XtraTab.XtraTabPage
        Me.GCCity = New DevExpress.XtraGrid.GridControl
        Me.GVCity = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id_city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.city = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LState = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTCArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCArea.SuspendLayout()
        Me.XTCountry.SuspendLayout()
        CType(Me.GCCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTRegion.SuspendLayout()
        CType(Me.GCRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.XTState.SuspendLayout()
        CType(Me.GCState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVState, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.XTCity.SuspendLayout()
        CType(Me.GCCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LargeImageCollection
        '
        Me.LargeImageCollection.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageCollection.ImageStream = CType(resources.GetObject("LargeImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImageCollection.Images.SetKeyName(0, "14-Safari_32x32.png")
        '
        'XTCArea
        '
        Me.XTCArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCArea.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTCArea.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XTCArea.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical
        Me.XTCArea.Images = Me.LargeImageCollection
        Me.XTCArea.Location = New System.Drawing.Point(0, 0)
        Me.XTCArea.Name = "XTCArea"
        Me.XTCArea.SelectedTabPage = Me.XTCountry
        Me.XTCArea.Size = New System.Drawing.Size(551, 365)
        Me.XTCArea.TabIndex = 9
        Me.XTCArea.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTCountry, Me.XTRegion, Me.XTState, Me.XTCity})
        '
        'XTCountry
        '
        Me.XTCountry.Controls.Add(Me.GCCountry)
        Me.XTCountry.ImageIndex = 0
        Me.XTCountry.Name = "XTCountry"
        Me.XTCountry.Size = New System.Drawing.Size(506, 359)
        Me.XTCountry.Text = "Country"
        '
        'GCCountry
        '
        Me.GCCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCountry.Location = New System.Drawing.Point(0, 0)
        Me.GCCountry.MainView = Me.GVCountry
        Me.GCCountry.Name = "GCCountry"
        Me.GCCountry.Size = New System.Drawing.Size(506, 359)
        Me.GCCountry.TabIndex = 8
        Me.GCCountry.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCountry})
        '
        'GVCountry
        '
        Me.GVCountry.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_country, Me.country, Me.GridColumnCountryDisplayName})
        Me.GVCountry.GridControl = Me.GCCountry
        Me.GVCountry.Name = "GVCountry"
        Me.GVCountry.OptionsBehavior.Editable = False
        Me.GVCountry.OptionsView.ShowGroupPanel = False
        '
        'id_country
        '
        Me.id_country.Caption = "ID"
        Me.id_country.FieldName = "id_country"
        Me.id_country.Name = "id_country"
        '
        'country
        '
        Me.country.Caption = "Country"
        Me.country.FieldName = "country"
        Me.country.Name = "country"
        Me.country.Visible = True
        Me.country.VisibleIndex = 0
        '
        'GridColumnCountryDisplayName
        '
        Me.GridColumnCountryDisplayName.Caption = "Display Name"
        Me.GridColumnCountryDisplayName.FieldName = "country_display_name"
        Me.GridColumnCountryDisplayName.Name = "GridColumnCountryDisplayName"
        Me.GridColumnCountryDisplayName.Visible = True
        Me.GridColumnCountryDisplayName.VisibleIndex = 1
        '
        'XTRegion
        '
        Me.XTRegion.Controls.Add(Me.GCRegion)
        Me.XTRegion.Controls.Add(Me.Panel1)
        Me.XTRegion.Name = "XTRegion"
        Me.XTRegion.Size = New System.Drawing.Size(506, 359)
        Me.XTRegion.Text = "Region"
        '
        'GCRegion
        '
        Me.GCRegion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCRegion.Location = New System.Drawing.Point(0, 42)
        Me.GCRegion.MainView = Me.GVRegion
        Me.GCRegion.Name = "GCRegion"
        Me.GCRegion.Size = New System.Drawing.Size(506, 317)
        Me.GCRegion.TabIndex = 11
        Me.GCRegion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRegion})
        '
        'GVRegion
        '
        Me.GVRegion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GVRegion.GridControl = Me.GCRegion
        Me.GVRegion.Name = "GVRegion"
        Me.GVRegion.OptionsBehavior.Editable = False
        Me.GVRegion.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "id_region"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Region"
        Me.GridColumn4.FieldName = "region"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LCountry)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 42)
        Me.Panel1.TabIndex = 10
        '
        'LCountry
        '
        Me.LCountry.AutoSize = True
        Me.LCountry.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCountry.Location = New System.Drawing.Point(90, 8)
        Me.LCountry.Name = "LCountry"
        Me.LCountry.Size = New System.Drawing.Size(18, 26)
        Me.LCountry.TabIndex = 1
        Me.LCountry.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Country : "
        '
        'XTState
        '
        Me.XTState.Controls.Add(Me.GCState)
        Me.XTState.Controls.Add(Me.Panel2)
        Me.XTState.Name = "XTState"
        Me.XTState.Size = New System.Drawing.Size(506, 359)
        Me.XTState.Text = "State"
        '
        'GCState
        '
        Me.GCState.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCState.Location = New System.Drawing.Point(0, 42)
        Me.GCState.MainView = Me.GVState
        Me.GCState.Name = "GCState"
        Me.GCState.Size = New System.Drawing.Size(506, 317)
        Me.GCState.TabIndex = 9
        Me.GCState.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVState})
        '
        'GVState
        '
        Me.GVState.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_state, Me.state})
        Me.GVState.GridControl = Me.GCState
        Me.GVState.Name = "GVState"
        Me.GVState.OptionsBehavior.Editable = False
        Me.GVState.OptionsView.ShowGroupPanel = False
        '
        'id_state
        '
        Me.id_state.Caption = "ID"
        Me.id_state.FieldName = "id_state"
        Me.id_state.Name = "id_state"
        '
        'state
        '
        Me.state.Caption = "State"
        Me.state.FieldName = "state"
        Me.state.Name = "state"
        Me.state.Visible = True
        Me.state.VisibleIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LRegion)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 42)
        Me.Panel2.TabIndex = 8
        '
        'LRegion
        '
        Me.LRegion.AutoSize = True
        Me.LRegion.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegion.Location = New System.Drawing.Point(82, 8)
        Me.LRegion.Name = "LRegion"
        Me.LRegion.Size = New System.Drawing.Size(18, 26)
        Me.LRegion.TabIndex = 1
        Me.LRegion.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Region : "
        '
        'XTCity
        '
        Me.XTCity.Controls.Add(Me.GCCity)
        Me.XTCity.Controls.Add(Me.Panel3)
        Me.XTCity.Name = "XTCity"
        Me.XTCity.Size = New System.Drawing.Size(506, 359)
        Me.XTCity.Text = "City"
        '
        'GCCity
        '
        Me.GCCity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCity.Location = New System.Drawing.Point(0, 42)
        Me.GCCity.MainView = Me.GVCity
        Me.GCCity.Name = "GCCity"
        Me.GCCity.Size = New System.Drawing.Size(506, 317)
        Me.GCCity.TabIndex = 10
        Me.GCCity.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCity})
        '
        'GVCity
        '
        Me.GVCity.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_city, Me.city})
        Me.GVCity.GridControl = Me.GCCity
        Me.GVCity.Name = "GVCity"
        Me.GVCity.OptionsBehavior.Editable = False
        Me.GVCity.OptionsView.ShowGroupPanel = False
        '
        'id_city
        '
        Me.id_city.Caption = "ID"
        Me.id_city.FieldName = "id_city"
        Me.id_city.Name = "id_city"
        '
        'city
        '
        Me.city.Caption = "City"
        Me.city.FieldName = "city"
        Me.city.Name = "city"
        Me.city.Visible = True
        Me.city.VisibleIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LState)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(506, 42)
        Me.Panel3.TabIndex = 9
        '
        'LState
        '
        Me.LState.AutoSize = True
        Me.LState.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LState.Location = New System.Drawing.Point(67, 8)
        Me.LState.Name = "LState"
        Me.LState.Size = New System.Drawing.Size(18, 26)
        Me.LState.TabIndex = 2
        Me.LState.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "State : "
        '
        'FormMasterArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 365)
        Me.Controls.Add(Me.XTCArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMasterArea"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area"
        CType(Me.LargeImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTCArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCArea.ResumeLayout(False)
        Me.XTCountry.ResumeLayout(False)
        CType(Me.GCCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTRegion.ResumeLayout(False)
        CType(Me.GCRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRegion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.XTState.ResumeLayout(False)
        CType(Me.GCState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVState, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.XTCity.ResumeLayout(False)
        CType(Me.GCCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents LargeImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents XTCArea As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTCountry As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCountry As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCountry As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_country As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents country As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XTRegion As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCRegion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRegion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LCountry As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents XTState As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCState As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVState As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_state As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents state As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LRegion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents XTCity As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCCity As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCity As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LState As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridColumnCountryDisplayName As DevExpress.XtraGrid.Columns.GridColumn
End Class
