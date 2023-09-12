Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Namespace XtraGridDataServiceExample.Client

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call BonusSkins.Register()
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
