Imports System.Data.SqlClient
Public Class Form1
    Dim connection As New SqlConnection("Data Source=LAPTOP-NAHTMPOH\REHAANJAINSQL;Initial Catalog=master;User ID=sa;Password=1234567re")


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label7.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")


        TextBox6.Text = Val(TextBox6.Text) + 1
        Label7.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Label1.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red

        Label6.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox6.Text & "'where Parties='" & Label7.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label5.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")

        TextBox4.Text = Val(TextBox4.Text) + 1
        Label5.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Label9.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red

        Label4.BackColor = Color.Red
        Label6.BackColor = Color.Red
        Label7.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button6.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox4.Text & "'where Parties='" & Label5.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label9.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")


        TextBox8.Text = Val(TextBox8.Text) + 1
        Label9.BackColor = Color.Green
        Button8.BackColor = Color.Green
        Label8.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red
        Label6.BackColor = Color.Red
        Label7.BackColor = Color.Red

        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button6.Enabled = False




        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox8.Text & "'where Parties='" & Label9.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label8.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")

        TextBox7.Text = Val(TextBox7.Text) + 1
        Label8.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Label9.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red
        Label6.BackColor = Color.Red

        Label7.BackColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox7.Text & "'where Parties='" & Label8.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label6.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")

        TextBox5.Text = Val(TextBox5.Text) + 1
        Label6.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Label9.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red

        Label5.BackColor = Color.Red
        Label7.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox5.Text & "'where Parties='" & Label6.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label2.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")

        TextBox1.Text = Val(TextBox1.Text) + 1
        Label2.BackColor = Color.Green
        Button1.BackColor = Color.Green
        Label9.BackColor = Color.Red

        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red
        Label6.BackColor = Color.Red
        Label7.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button6.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False


        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox1.Text & "'where Parties='" & Label2.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label3.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")


        TextBox2.Text = Val(TextBox2.Text) + 1
        Label3.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Label9.BackColor = Color.Red
        Label2.BackColor = Color.Red

        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red
        Label6.BackColor = Color.Red
        Label7.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button1.Enabled = False
        Button6.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox2.Text & "'where Parties='" & Label3.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim y As New SqlDataAdapter()
        y.SelectCommand = New SqlCommand()
        y.SelectCommand.Connection = connection
        y.SelectCommand.CommandText = "Select * from votes where Parties='" & Label4.Text & "'"
        y.SelectCommand.CommandType = CommandType.Text
        Dim z As DataSet = New DataSet()
        y.Fill(z, "v")
        TextBox1.DataBindings.Add("Text", z, "v.NumberOfVotes")

        TextBox3.Text = Val(TextBox3.Text) + 1
        Label4.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Label9.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red

        Label5.BackColor = Color.Red
        Label6.BackColor = Color.Red
        Label7.BackColor = Color.Red
        Label8.BackColor = Color.Red
        Button1.Enabled = False
        Button2.Enabled = False
        Button6.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False



        Try
            connection.Open()
            y.UpdateCommand = connection.CreateCommand
            y.UpdateCommand.CommandText = "update votes set NumberOfVotes = '" & TextBox3.Text & "'where Parties='" & Label4.Text & "'"
            y.UpdateCommand.ExecuteNonQuery()
            Timer1.Start()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)
        ProgressBar1.Update()
        If ProgressBar1.Value = 99 Then
            Me.Hide()
            Form4.Show()
        End If
    End Sub
End Class
