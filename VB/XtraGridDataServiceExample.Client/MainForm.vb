Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports XtraGridDataServiceExample.Client.NorthwindGate
Imports System.Data.Services.Client
Imports System.Xml
Imports DevExpress.XtraGrid.Views.Base

Namespace XtraGridDataServiceExample.Client

    Public Partial Class MainForm
        Inherits XtraForm

        Private Context As NorthwindEntities

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            Context = New NorthwindEntities(New Uri("http://localhost:12691/NorthwindGate.svc/"))
            Context.IgnoreResourceNotFoundException = True
            Source.DataSource = Context.Products.ToList()
        End Sub

        Private Overloads Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Try
                Context.SaveChanges()
            Catch ex As DataServiceRequestException
                Dim doc As XmlDocument = New XmlDocument()
                doc.LoadXml(Enumerable.First(ex.Response).Error.Message)
                Dim errors As XmlNodeList = doc.GetElementsByTagName("internalexception")
                If errors.Count = 0 Then errors = doc.GetElementsByTagName("error")
                If XtraMessageBox.Show(Me, errors(0)("message").InnerText, "Dx Sample", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = DialogResult.Cancel Then e.Cancel = True
            End Try
        End Sub

        Private Sub OnRowUpdated(ByVal sender As Object, ByVal e As RowObjectEventArgs)
            Context.UpdateObject(e.Row)
        End Sub

        Private Sub OnEmbeddedNavigatorButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
            Select Case e.Button.ButtonType
                Case NavigatorButtonType.Append
                    e.Handled = True
                    Context.AddObject("Products", Source.AddNew())
                Case NavigatorButtonType.Remove
                    Context.DeleteObject(View.GetFocusedRow())
            End Select
        End Sub
    End Class
End Namespace
