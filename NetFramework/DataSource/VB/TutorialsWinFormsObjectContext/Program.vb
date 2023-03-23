Imports System.IO
Imports System.Reflection
Imports C1.Data.Entities
Imports System.Configuration
Imports System.Globalization

Public Class Program
    Public Shared ClientCache As EntityClientCache

    <STAThread()>
    Shared Sub Main()
        ' Specify where should Entity Framework look for the Northwind database.
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        Dim dbFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common", "Northwnd.mdf")
        If Not File.Exists(dbFile) Then
            Throw New Exception("Sample database Northwnd.mdf must be created in the Common folder. Run the CreateSampleDB utility to create the Northwind database")
        End If

        ' make sure both version 11 and version 12 or higher of SQLServer LocalDb are supported
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions")
        If key Is Nothing Then
            Throw New Exception("Microsoft SQL Server LocalDB is not installed.")
        End If
        Dim version As String = "v11.0"
        For Each subKeyName In key.GetSubKeyNames()
            Dim localDBVersion As Double = 0
            If Double.TryParse(subKeyName, NumberStyles.Number, CultureInfo.InvariantCulture, localDBVersion) And localDBVersion >= 12 Then
                version = "MSSQLLocalDB"
                Exit For
            End If
        Next
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connStr = config.ConnectionStrings.ConnectionStrings("NORTHWNDEntities")
        connStr.ConnectionString = connStr.ConnectionString.Replace("v11.0", version)
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

        ' Get a global ClientCache and save it in a static field
        ' so it is accessible from any class of the project.
        ClientCache = EntityClientCache.GetDefault(GetType(TutorialsWinForms.NORTHWNDEntities))

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Class