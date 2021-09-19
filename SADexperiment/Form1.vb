Imports MySql.Data.MySqlClient

Public Class Form1

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=ieti19;database=user_privileges"
        Dim READER As MySqlDataReader

         Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from user_privileges.users where username='" & TextBox1.Text & "' and  password='" & TextBox2.Text & "' "

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            Dim it As String
            count = 0

            '--- TESTING because this works in PHP!!! ---
            'If READER.Read() Then
            'count = count + 1
            'it = READER.Item("tag")
            'End While
            'Else
            'MessageBox.Show("incorrect credentials")
            'End If
            '--- TESTING because this works in PHP!!! ---

            While READER.Read
                count = count + 1
                it = READER.Item("tag")
            End While


            If count = 1 And it = "admn" Then

                MessageBox.Show("first_name and last_name are correct")
                Form2.Show()
                Me.Hide()
            ElseIf count = 1 And it = "acc1" Then
                MessageBox.Show("first_name and last_name are correct")
                ACC1Frm.Show()
                Me.Hide()
            ElseIf count = 1 And it = "bsc1" Then
                MessageBox.Show("first_name and last_name are correct")
                BSC1.Show()
                Me.Hide()
            ElseIf count = 1 And it = "acc2" Then
                MessageBox.Show("first_name and last_name are correct")
                ACC2.Show()
                Me.Hide()
            ElseIf count = 1 And it = "bsc2" Then
                MessageBox.Show("first_name and last_name are correct")
                BSC2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("first_name and last_name are Duplicate")
            Else
                MessageBox.Show("first_name and last_name are not correct")

            End If

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
            TextBox1.Text = ""
            TextBox2.Text = ""

        End Try


    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Register.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=ieti19;database=user_privileges"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from user_privileges.users where username='" & TextBox1.Text & "' and  password='" & TextBox2.Text & "' "

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            Dim it As String
            count = 0
            While READER.Read
                count = count + 1
                it = READER.Item("tag")
                'MessageBox.Show(it)
                'MsgBox(it)
            End While
            If count = 1 And it = "admn" Then

                MessageBox.Show("first_name and last_name are correct")
                AdminManage.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("first_name and last_name are Duplicate")
            Else
                MessageBox.Show("first_name and last_name are not correct")

            End If
            'End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

            TextBox1.Text = ""
            TextBox2.Text = ""
        End Try
    End Sub
End Class
