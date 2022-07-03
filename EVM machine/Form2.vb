Imports System.Data.SqlClient
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=LAPTOP-NAHTMPOH\REHAANJAINSQL;Initial Catalog=master;User ID=sa;Password=1234567re")
        Dim Command As New SqlCommand("Select * from LogIn where UserId= @userid and Password=@password", connection)

        Command.Parameters.Add("@userid", SqlDbType.VarChar).Value = TextBox1.Text
        Command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("UserId or password is Invalid")
        Else
            If CheckBox1.Checked = False Then
                MessageBox.Show("Please Accept Terms and conditions")
            ElseIf CheckBox1.Checked = True Then
                'MessageBox.Show("Login successfull")
                Timer1.Enabled = True
                ProgressBar1.Visible = True
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If ProgressBar1.Visible = True Then
        ProgressBar1.Increment(2)
        ProgressBar1.Update()
        ' End If
        If ProgressBar1.Value = 10 Then
            Label7.Visible = True
        End If
        If ProgressBar1.Value = 98 Then
            Form1.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class