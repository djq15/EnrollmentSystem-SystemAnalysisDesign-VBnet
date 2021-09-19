Imports MySql.Data.MySqlClient


Public Class AdminManage

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dbDataSet2 As New DataTable

    Dim str As String = "server=localhost;userid=root;password=ieti19;database=user_privileges"
    Dim con As New MySqlConnection(str)

    Dim con2 As New MySqlConnection





    'loadables
    Sub load_table()

        'con2 = New MySqlConnection
        'con2.ConnectionString = "server=localhost;userid=root;password=ieti19;database=user_privileges"

        Dim query As String = "SELECT user_id, username, tag FROM user_privileges.users"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        T1.Clear()
        T2.Clear()
        T2.Clear()
        T3.Clear()
        ComboBox1.Text = "choose tag"

    End Sub


    'savables

    Private Sub save_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand
            cmd.CommandText = "insert into user_privileges.users (user_id, username, password, tag) values (@user_id, @username, @password, '" & ComboBox1.Text & "');"
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
        load_table()
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
        load_table()

    End Sub

    'updatables

    Private Sub update_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update user_privileges.users set user_id=@user_id, username=@username, tag='" & ComboBox1.Text & "' where user_id=@user_id"
            cmd.Parameters.AddWithValue("@user_id", T1.Text)
            cmd.Parameters.AddWithValue("@username", T2.Text)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated")
            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()

        End Try
        load_table()
    End Sub

    Private Sub update_pass()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update user_privileges.users set password=@password where user_id=@user_id"
            cmd.Parameters.AddWithValue("@user_id", T1.Text)
            cmd.Parameters.AddWithValue("@password", T3.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data updated")
            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()

        End Try
        load_table()


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()


    End Sub


    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
        con.Close()
        load_table()

        ComboBox1.Text = "choose tag"
        ComboBox1.Items.Add("admn")
        ComboBox1.Items.Add("acc1")
        ComboBox1.Items.Add("acc2")
        ComboBox1.Items.Add("bsc1")
        ComboBox1.Items.Add("bsc2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If T1.Text = "" Then
            MessageBox.Show("Please click and populate the user_id")

        ElseIf T2.Text = "" Then
            MessageBox.Show("Please provide username")
        ElseIf T3.Text = "" Then
            MessageBox.Show("Please provide password")
        Else
            save_table1()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If T1.Text = "" Then

            MessageBox.Show("Please provide the User ID")

        Else
            delete_table1()
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            T1.Text = row.Cells("user_id").Value.ToString
            T2.Text = row.Cells("username").Value.ToString
            'T3.Text = row.Cells("password").Value.ToString
            ComboBox1.Text = row.Cells("tag").Value.ToString
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Items.Clear()


        T1.Clear()
        T2.Clear()
        T3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If T1.Text = "" Then
            MessageBox.Show("Please click and populate the user_id")

        ElseIf T2.Text = "" Then
            MessageBox.Show("Please provide username")
        Else
            update_table1()
        End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If T1.Text = "" Then
            MessageBox.Show("Please click and populate the user_id")
        ElseIf T3.Text = "" Then
            MessageBox.Show("Please provide password")
        Else
            update_pass()
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class