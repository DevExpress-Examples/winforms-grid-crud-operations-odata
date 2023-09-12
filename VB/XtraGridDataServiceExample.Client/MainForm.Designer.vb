Namespace XtraGridDataServiceExample.Client

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.Source = New System.Windows.Forms.BindingSource(Me.components)
            Me.View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Source), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.Source
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            AddHandler Me.gridControl1.EmbeddedNavigator.ButtonClick, New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(AddressOf Me.OnEmbeddedNavigatorButtonClick)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.View
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(423, 268)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.View})
            ' 
            ' Source
            ' 
            Me.Source.DataSource = GetType(XtraGridDataServiceExample.Client.NorthwindGate.Product)
            ' 
            ' View
            ' 
            Me.View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID, Me.colProductName, Me.colSupplierID, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            Me.View.GridControl = Me.gridControl1
            Me.View.Name = "View"
            AddHandler Me.View.RowUpdated, New DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(AddressOf Me.OnRowUpdated)
            ' 
            ' colProductID
            ' 
            Me.colProductID.Caption = "ProductID"
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "ProductName"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            ' 
            ' colSupplierID
            ' 
            Me.colSupplierID.Caption = "SupplierID"
            Me.colSupplierID.FieldName = "SupplierID"
            Me.colSupplierID.Name = "colSupplierID"
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.Caption = "CategoryID"
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.Caption = "QuantityPerUnit"
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 1
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "UnitPrice"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.Caption = "UnitsInStock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.Caption = "UnitsOnOrder"
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.Caption = "ReorderLevel"
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.Caption = "Discontinued"
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 3
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(423, 268)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "MainForm"
            Me.Text = "Dx Sample"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.OnFormClosing)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnFormLoad)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Source), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private View As DevExpress.XtraGrid.Views.Grid.GridView

        Private Source As System.Windows.Forms.BindingSource

        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colSupplierID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
