''
'' This file is part of C1Report's C1dView sample.
''
'' This file contains settings persistence code.
''
''Copyright GrapeCity, Inc.
''
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports C1.C1Preview
Imports C1.Win.C1Preview

''' <summary>
''' Encapsulates preview settings which can be persisted together
''' as a single Settings.settings variable of type C1dView.C1dViewSettings.
''' </summary>
Public Class C1dViewSettings
#Region "Defaults and limits"
    Public Shared ReadOnly MinMainWindowSize As Size = New Size(200, 200)
#End Region

#Region "Settings"
    Public Property MainWindowBounds As Rectangle
    Public Property RecentDocuments As List(Of Pair(Of String, String))
#End Region

#If True Then
#Region "Methods"
    ''' <summary>
    ''' Loads the last saved settings into the preview.
    ''' </summary>
    ''' <param name="previewForm">The preview form.</param>
    Public Shared Sub Load(ByVal previewForm As C1dViewForm)

        Try
            Dim settings = My.MySettings.Default
            If (settings Is Nothing) Then
                Return
            End If
            If (settings.C1dViewSettings Is Nothing) Then
                Save(previewForm)
                Return
            End If
            Dim vs = settings.C1dViewSettings
            '' main window position:
            If (vs.MainWindowBounds.Width >= MinMainWindowSize.Width AndAlso _
                vs.MainWindowBounds.Height >= MinMainWindowSize.Height AndAlso _
                vs.MainWindowBounds.X >= 0 AndAlso _
                vs.MainWindowBounds.Y >= 0) Then
                previewForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                previewForm.Bounds = vs.MainWindowBounds
            End If
            '' recent documents:
            C1dViewForm.RecentDocuments.Clear()
            If (vs.RecentDocuments IsNot Nothing) Then
                C1dViewForm.RecentDocuments.AddRange(vs.RecentDocuments)
            End If
        Catch
            '' ignore settings errors, not much to do here.
        End Try
    End Sub

    ''' <summary>
    ''' Saves current settings.
    ''' </summary>
    ''' <param name="previewForm">The preview form.</param>
    Public Shared Sub Save(ByVal previewForm As C1dViewForm)

        Try

            Dim settings = My.MySettings.Default
            If (settings Is Nothing) Then
                Return
            End If
            If (settings.C1dViewSettings Is Nothing) Then
                settings.C1dViewSettings = New C1dViewSettings()
            End If
            Dim vs = settings.C1dViewSettings
            '' main window position:
            vs.MainWindowBounds = previewForm.Bounds
            '' recent documents:
            vs.RecentDocuments = New List(Of Pair(Of String, String))()
            vs.RecentDocuments.AddRange(C1dViewForm.RecentDocuments)
            ''
            settings.Save()

        Catch
            '' ignore settings errors, not much to do here.
        End Try
    End Sub
#End Region
#End If
End Class
