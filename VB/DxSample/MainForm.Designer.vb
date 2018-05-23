Namespace DxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.orderBindingSource = New System.Windows.Forms.BindingSource()
			Me.customerBindingSource = New System.Windows.Forms.BindingSource()
			Me.barManager1 = New DevExpress.XtraBars.BarManager()
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.SaveButton = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			DirectCast(Me.orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' orderBindingSource
			' 
			Me.orderBindingSource.DataSource = GetType(DxSample.Service.Models.Order)
			' 
			' customerBindingSource
			' 
			Me.customerBindingSource.DataSource = GetType(DxSample.Service.Models.Customer)
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.SaveButton})
			Me.barManager1.MaxItemId = 1
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.SaveButton)})
			Me.bar1.Text = "Tools"
			' 
			' SaveButton
			' 
			Me.SaveButton.Caption = "Save"
			Me.SaveButton.Id = 0
			Me.SaveButton.Name = "SaveButton"
'			Me.SaveButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.SaveButton_ItemClick)
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(482, 34)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 253)
			Me.barDockControlBottom.Size = New System.Drawing.Size(482, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 219)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(482, 34)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 219)
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.customerBindingSource
			Me.repositoryItemLookUpEdit1.DisplayMember = "Name"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.ValueMember = "ID"
			' 
			' GridView
			' 
			Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colCustomerID})
			Me.GridView.GridControl = Me.gridControl1
			Me.GridView.Name = "GridView"
'			Me.GridView.RowDeleted += New DevExpress.Data.RowDeletedEventHandler(Me.GridView_RowDeleted)
'			Me.GridView.RowUpdated += New DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(Me.GridView_RowUpdated)
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colCustomerID
			' 
			Me.colCustomerID.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 1
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.orderBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 34)
			Me.gridControl1.MainView = Me.GridView
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(482, 219)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView})
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(482, 253)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "MainForm"
			Me.Text = "Main Form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load)
			DirectCast(Me.orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private orderBindingSource As System.Windows.Forms.BindingSource
		Private customerBindingSource As System.Windows.Forms.BindingSource
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private bar2 As DevExpress.XtraBars.Bar
		Private WithEvents SaveButton As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

