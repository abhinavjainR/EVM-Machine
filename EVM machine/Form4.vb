Imports System.Data.SqlClient
Public Class Form4
    Dim connection As New SqlConnection("Data Source=LAPTOP-NAHTMPOH\REHAANJAINSQL;Initial Catalog=master;User ID=sa;Password=1234567re")
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        ProgressBar1.Update()
        If ProgressBar1.Value = 70 Then
            Me.Close()
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class