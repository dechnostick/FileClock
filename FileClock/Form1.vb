Imports System.Text
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim now As DateTime = DateTime.Now
        Dim dir As String = "只今の時刻："
        Dim newFile As String = dir & Path.DirectorySeparatorChar & now.ToString("HH時mm分.ss秒")
        If Not Directory.Exists(dir) Then
            Directory.CreateDirectory(dir)
        End If
        For Each f As String In Directory.GetFiles(dir)
            File.Move(f, newFile)
        Next
        File.WriteAllText(newFile, "", Encoding.GetEncoding("shift_jis"))
    End Sub
End Class
