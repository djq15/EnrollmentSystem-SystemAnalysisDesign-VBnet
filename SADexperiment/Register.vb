Imports MySql.Data.MySqlClient


Public Class Register

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dbDataSet2 As New DataTable

    Dim str As String = "server=localhost;userid=root;password=ieti19;database=user_privileges"
    Dim con As New MySqlConnection(str)

    Dim con2 As New MySqlConnection




    'savables

    Private Sub save_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand
            cmd.CommandText = "insert into user_privileges.users (user_id, username, password) values (user_id, @username, @password);"
            cmd.Parameters.AddWithValue("@user_id", T1.Text)
            cmd.Parameters.AddWithValue("@username", T2.Text)
            cmd.Parameters.AddWithValue("@password", T3.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub

    'deletables

    Private Sub delete_table1()
        Dim cmd As MySqlCommand
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from user_privileges.users where user_id=@user_id"
            cmd.Parameters.AddWithValue("@user_id", T1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


    End Sub

    'updatables

    Private Sub update_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update user_privileges.users set user_id=@user_id, username=@username, password=@password where user_id=@user_id"
            'cmd.CommandText = "update user_privileges.users set user_id=@user_id, username=@username, password=@password where user_id=@user_id"
            cmd.Parameters.AddWithValue("@user_id", T1.Text)
            cmd.Parameters.AddWithValue("@username", T2.Text)
            cmd.Parameters.AddWithValue("@password", T3.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated")
            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()

        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        T2.Enabled = True

        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()

        Button2.Enabled = True
        Button2.Enabled = False

        T1.Text = ""
        T2.Text = ""
        T3.Text = ""

        Form1.Show()
        Me.Hide()


    End Sub


    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T1.Enabled = True
        T1.Enabled = False

        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()

        Button2.Enabled = True
        Button2.Enabled = False

        T1.Text = ""
        T2.Text = ""
        T3.Text = ""


        con.Close()
        'load_table()


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
        T2.Enabled = True
        T1.Clear()
        T2.Clear()
        T3.Clear()

    End Sub
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If T1.Text = "" Then
            MessageBox.Show("User ID is empty, please click on the user database and try again")

        Else

            update_table1()
            load_table()
        End If

      
    End Sub

    Private Sub load_table()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=ieti19;database=user_privileges"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from user_privileges.users where username='" & T2.Text & "' and  password='" & T3.Text & "' "

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            Dim it As String

            Dim adpt As New MySqlDataAdapter(Query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables(0)

            count = 0
            While READER.Read
                count = count + 1
                it = READER.Item("tag")
                'MessageBox.Show(it)
                'MsgBox(it)
            End While

            If count = 1 Then



            ElseIf count > 1 Then

            Else


            End If
            'End While
            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()


        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=ieti19;database=user_privileges"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "select * from user_privileges.users where username='" & T2.Text & "' and  password='" & T3.Text & "' "

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            Dim it As String

            Dim adpt As New MySqlDataAdapter(Query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds, "Emp")
            DataGridView1.DataSource = ds.Tables(0)

            count = 0
            While READER.Read
                count = count + 1
                it = READER.Item("tag")
                'MessageBox.Show(it)
                'MsgBox(it)
            End While

            If count = 1 Then

                MessageBox.Show("Verified")
                T2.Enabled = False
                Button2.Enabled = True

            ElseIf count > 1 Then
                MessageBox.Show("first_name and last_name are Duplicate")
            Else
                MessageBox.Show("wrong username or password")

            End If
            'End While
            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()


        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        T1.Text = row.Cells("user_id").Value.ToString
        T2.Text = row.Cells("username").Value.ToString
        T3.Text = row.Cells("password").Value.ToString
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class