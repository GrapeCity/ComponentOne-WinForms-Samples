Imports System.Runtime.InteropServices

Friend Class Win32

    Friend Const CB_SHOWDROPDOWN As Int32 = &H14F

    <DllImport("USER32.DLL")> _
    Friend Shared Function MsgWaitForMultipleObjects( _
    ByVal nCount As Int32, ByVal pHandles As IntPtr, ByVal bWaitAll As Int16, _
    ByVal dwMilliseconds As Int32, ByVal dwWakeMask As Int32) As Int32
    End Function

    <DllImport("USER32.DLL", EntryPoint:="PostMessageW")> _
    Friend Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal wMsg As Int32, _
    ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

End Class
