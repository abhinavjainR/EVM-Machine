Imports System.Data.SqlClient
Public Class Form3
    Dim connection As New SqlConnection("Data Source=LAPTOP-NAHTMPOH\REHAANJAINSQL;Initial Catalog=master;User ID=sa;Password=1234567re")

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        ProgressBar1.Update()
        If ProgressBar1.Value = 50 Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class