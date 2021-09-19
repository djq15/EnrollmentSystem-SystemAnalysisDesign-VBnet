Imports MySql.Data.MySqlClient


Public Class ACC1Frm


    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dbDataSet2 As New DataTable


    Dim str As String = "server=localhost;userid=root;password=ieti19;database=user_privileges"
    Dim con As New MySqlConnection(str)

    Dim con2 As New MySqlConnection




    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        L1.Text = "  --"
        L2.Text = "  --"
        L3.Text = "  --"
        L4.Text = "  --"
        L5.Text = "  --"
        L6.Text = "  --"
        L7.Text = "  --"
        L8.Text = "  --"
        L9.Text = "  --"
        L10.Text = "  --"
        L11.Text = "  --"
        L12.Text = "  --"
        L13.Text = "  --"
        L14.Text = "  --"
        L15.Text = "  --"
        L16.Text = "  --"
        L17.Text = "  --"
        L18.Text = "  --"
        L19.Text = "  --"
        L20.Text = "  --"
        L21.Text = "  --"
        L22.Text = "  --"
        L23.Text = "  --"
        L24.Text = "  --"
        L25.Text = "  --"
        L26.Text = "  --"
        L27.Text = "  --"
        L28.Text = "  --"
        L29.Text = "  --"
        L30.Text = "  --"
        L31.Text = "  --"
        L32.Text = "  --"
        L33.Text = "  --"
        L34.Text = "  --"
        L35.Text = "  --"
        L36.Text = "  --"
        L37.Text = "  --"
        L38.Text = "  --"
        L39.Text = "  --"
        L40.Text = "  --"
        L41.Text = "  --"
        L42.Text = "  --"

        ComboBox2.Items.Clear()
        Form1.Show()
        Me.Hide()
        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
        con.Close()
        Table1ToolStripMenuItem.Checked = False
        Table2ToolStripMenuItem.Checked = False
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        If Table1ToolStripMenuItem.Checked = True Then
            save_table1()
        ElseIf Table2ToolStripMenuItem.Checked = True Then
            save_table2()
        End If
    End Sub

    'savables

    Private Sub save_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try

            cmd = con.CreateCommand
            'cmd.CommandText = "insert into user_privileges.masterlist (Student_No, Status, Last_name, First_name, Middle_initial, Nickname, Gender, Date_of_birth, Age, Street, Province, Home_contact_No, Fathers_name, Fathers_contact_No, Fathers_email, Mothers_name, Mothers_contact_No, Mothers_email, Guardians_name, Relationship_with_student, Guardians_email, Guardians_contact_No, `Case`) values (@Student_No, @Status, @Last_name, @First_name, @Middle_initial, @Nickname, @Gender, @Date_of_birth, @Age, @Street, @Province, @Home_contact_No, @Fathers_name, @Fathers_contact_No, @Fathers_email, @Mothers_name, @Mothers_contact_No, @Mothers_email, @Guardians_name, @Relationship_with_student, @Guardians_email, @Guardians_contact_No, @Case);"
            cmd.CommandText = "insert into user_privileges.masterlist (Student_No, `Status`, Last_name, First_name, Middle_initial, Nickname, Gender, Date_of_birth, Age, Street, Province, Home_contact_No, Fathers_name, Fathers_contact_No, Fathers_email, Mothers_name, Mothers_contact_No, Mothers_email, Guardians_name, Relationship_with_student, Guardians_email, Guardians_contact_No, `Case`, One_on_one, RR_class, ABCs_class, Beginner_class, Skill_development_class, Sight_reading_class, Pre_Voc_class, Learning_center, BLC_class, Kinder_music_class, Group_class_SSDS, SpEd_class_SSDS, Antipolo_ABCs, Antipolo_elementary, Antipolo_high_school, Supervisor_Teacher_in_charge, Remarks) values (@Student_No, @Status, @Last_name, @First_name, @Middle_initial, @Nickname, @Gender, @Date_of_birth, @Age, @Street, @Province, @Home_contact_No, @Fathers_name, @Fathers_contact_No, @Fathers_email, @Mothers_name, @Mothers_contact_No, @Mothers_email, @Guardians_name, @Relationship_with_student, @Guardians_email, @Guardians_contact_No, @Case, @One_on_one, @RR_class, @ABCs_class, @Beginner_class, @Skill_development_class, @Sight_reading_class, @Pre_Voc_class, @Learning_center, @BLC_class, @Kinder_music_class, @Group_class_SSDS, @SpEd_class_SSDS, @Antipolo_ABCs, @Antipolo_elementary, @Antipolo_high_school, @Supervisor_Teacher_in_charge, @Remarks);"
            cmd.Parameters.AddWithValue("@Student_No", T1.Text)
            cmd.Parameters.AddWithValue("@Status", T2.Text)
            cmd.Parameters.AddWithValue("@Last_name", T3.Text)
            cmd.Parameters.AddWithValue("@First_name", T4.Text)
            cmd.Parameters.AddWithValue("@Middle_initial", T5.Text)
            cmd.Parameters.AddWithValue("@Nickname", T6.Text)
            cmd.Parameters.AddWithValue("@Gender", T7.Text)

            cmd.Parameters.AddWithValue("@Date_of_birth", T8.Text)
            cmd.Parameters.AddWithValue("@Age", T9.Text)
            cmd.Parameters.AddWithValue("@Street", T10.Text)
            cmd.Parameters.AddWithValue("@Province", T11.Text)
            cmd.Parameters.AddWithValue("@Home_contact_No", T12.Text)
            cmd.Parameters.AddWithValue("@Fathers_name", T13.Text)
            cmd.Parameters.AddWithValue("@Fathers_contact_No", T14.Text)

            cmd.Parameters.AddWithValue("@Fathers_email", T15.Text)
            cmd.Parameters.AddWithValue("@Mothers_name", T16.Text)
            cmd.Parameters.AddWithValue("@Mothers_contact_No", T17.Text)
            cmd.Parameters.AddWithValue("@Mothers_email", T18.Text)
            cmd.Parameters.AddWithValue("@Guardians_name", T19.Text)
            cmd.Parameters.AddWithValue("@Relationship_with_student", T20.Text)
            cmd.Parameters.AddWithValue("@Guardians_email", T21.Text)

            cmd.Parameters.AddWithValue("@Guardians_contact_No", T22.Text)
            cmd.Parameters.AddWithValue("@Case", T23.Text)
            cmd.Parameters.AddWithValue("@One_on_one", T24.Text)
            cmd.Parameters.AddWithValue("@RR_class", T25.Text)
            cmd.Parameters.AddWithValue("@ABCs_class", T26.Text)
            cmd.Parameters.AddWithValue("@Beginner_class", T27.Text)
            cmd.Parameters.AddWithValue("@Skill_development_class", T28.Text)

            cmd.Parameters.AddWithValue("@Sight_reading_class", T29.Text)
            cmd.Parameters.AddWithValue("@Pre_Voc_class", T30.Text)
            cmd.Parameters.AddWithValue("@Learning_center", T31.Text)
            cmd.Parameters.AddWithValue("@BLC_class", T32.Text)
            cmd.Parameters.AddWithValue("@Kinder_music_class", T33.Text)
            cmd.Parameters.AddWithValue("@Group_class_SSDS", T34.Text)
            cmd.Parameters.AddWithValue("@SpEd_class_SSDS", T35.Text)

            cmd.Parameters.AddWithValue("@Antipolo_ABCs", T36.Text)
            cmd.Parameters.AddWithValue("@Antipolo_elementary", T37.Text)
            cmd.Parameters.AddWithValue("@Antipolo_high_school", T38.Text)
            cmd.Parameters.AddWithValue("@Supervisor_Teacher_in_charge", T39.Text)
            cmd.Parameters.AddWithValue("@Remarks", T40.Text)

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


    Private Sub save_table2()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            T2.Text = Val(T2.Text)
            T3.Text = Val(T3.Text)
            T4.Text = Val(T4.Text)
            T5.Text = Val(T5.Text)
            T6.Text = Val(T6.Text)
            T7.Text = Val(T7.Text)

            cmd = con.CreateCommand
            cmd.CommandText = "insert into user_privileges.samplecalculation (Student_ID, Jan, Feb, Mar, Apr, May, Jun)values (@Student_ID,@Jan,@Feb,@Mar, @Apr, @May, @Jun);"
            cmd.Parameters.AddWithValue("@Student_ID", T1.Text)
            cmd.Parameters.AddWithValue("@Jan", T2.Text)
            cmd.Parameters.AddWithValue("@Feb", T3.Text)
            cmd.Parameters.AddWithValue("@Mar", T4.Text)
            cmd.Parameters.AddWithValue("@Apr", T5.Text)
            cmd.Parameters.AddWithValue("@May", T6.Text)
            cmd.Parameters.AddWithValue("@Jun", T7.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data saved")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
        load_table2()

    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Table1ToolStripMenuItem.Enabled = True
        Table1ToolStripMenuItem.Enabled = False
    End Sub

    'loadables
    Sub load_table()


        Dim query As String = "select * from user_privileges.masterlist"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T4.Clear()
        T5.Clear()
        T6.Clear()
        T7.Clear()
        T8.Clear()
        T9.Clear()
        T10.Clear()
        T11.Clear()
        T12.Clear()
        T13.Clear()
        T14.Clear()
        T15.Clear()
        T16.Clear()
        T17.Clear()
        T18.Clear()
        T19.Clear()
        T20.Clear()
        T21.Clear()
        T22.Clear()
        T23.Clear()
        T24.Clear()
        T25.Clear()
        T26.Clear()
        T27.Clear()
        T28.Clear()
        T29.Clear()
        T30.Clear()
        T31.Clear()
        T32.Clear()
        T33.Clear()
        T34.Clear()
        T35.Clear()
        T36.Clear()
        T37.Clear()
        T38.Clear()
        T39.Clear()
        T40.Clear()

    End Sub

    Sub load_table2()

        'con2 = New MySqlConnection
        'con2.ConnectionString = "server=localhost;userid=root;password=ieti19;database=user_privileges"

        Dim query As String = "SELECT * , (Jan + Feb + Mar + Apr + May + Jun) as Total,(Jan + Feb + Mar + Apr + May + Jun) / 6 as `Per Month Payment` FROM user_privileges.samplecalculation"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T4.Clear()
        T5.Clear()
        T6.Clear()
        T7.Clear()
        T8.Clear()
        T9.Clear()
        T10.Clear()
        T11.Clear()
        T12.Clear()
        T13.Clear()
        T14.Clear()
        T15.Clear()
        T16.Clear()
        T17.Clear()
        T18.Clear()
        T19.Clear()
        T20.Clear()
        T21.Clear()
        T22.Clear()
        T23.Clear()
        T24.Clear()
        T25.Clear()
        T26.Clear()
        T27.Clear()
        T28.Clear()
        T29.Clear()
        T30.Clear()
        T31.Clear()
        T32.Clear()
        T33.Clear()
        T34.Clear()
        T35.Clear()
        T36.Clear()
        T37.Clear()
        T38.Clear()
        T39.Clear()
        T40.Clear()

    End Sub



    'updatables

    Private Sub update_table1()
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update user_privileges.masterlist set Student_No=@Student_No, `Status`=@Status, Last_name=@Last_name, First_name=@First_name, Middle_initial=@Middle_initial, Nickname=@Nickname, Gender=@Gender, Date_of_birth=@Date_of_birth, Age=@Age, Street=@Street, Province=@Province, Home_contact_No=@Home_contact_No, Fathers_name=@Fathers_name, Fathers_contact_No=@Fathers_contact_No, Fathers_email=@Fathers_email, Mothers_name=@Mothers_name, Mothers_contact_No=@Mothers_contact_No, Mothers_email=@Mothers_email, Guardians_name=@Guardians_name, Relationship_with_student=@Relationship_with_student, Guardians_email=@Guardians_email, Guardians_contact_No=@Guardians_contact_No, `Case`=@Case, One_on_one=@One_on_one, RR_class=@RR_class, ABCs_class=@ABCs_class, Beginner_class=@Beginner_class, Skill_development_class=@Skill_development_class, Sight_reading_class=@Sight_reading_class, Pre_Voc_class=@Pre_Voc_class, Learning_center=@Learning_center, BLC_class=@BLC_class, Kinder_music_class=@Kinder_music_class, Group_class_SSDS=@Group_class_SSDS, SpEd_class_SSDS=@SpEd_class_SSDS, Antipolo_ABCs=@Antipolo_ABCs, Antipolo_elementary=@Antipolo_elementary, Antipolo_high_school=@Antipolo_high_school, Supervisor_Teacher_in_charge=@Supervisor_Teacher_in_charge, Remarks=@Remarks where Student_No=@Student_No"
            cmd.Parameters.AddWithValue("@Student_No", T1.Text)
            cmd.Parameters.AddWithValue("@Status", T2.Text)
            cmd.Parameters.AddWithValue("@Last_name", T3.Text)
            cmd.Parameters.AddWithValue("@First_name", T4.Text)
            cmd.Parameters.AddWithValue("@Middle_initial", T5.Text)
            cmd.Parameters.AddWithValue("@Nickname", T6.Text)
            cmd.Parameters.AddWithValue("@Gender", T7.Text)

            cmd.Parameters.AddWithValue("@Date_of_birth", T8.Text)
            cmd.Parameters.AddWithValue("@Age", T9.Text)
            cmd.Parameters.AddWithValue("@Street", T10.Text)
            cmd.Parameters.AddWithValue("@Province", T11.Text)
            cmd.Parameters.AddWithValue("@Home_contact_No", T12.Text)
            cmd.Parameters.AddWithValue("@Fathers_name", T13.Text)
            cmd.Parameters.AddWithValue("@Fathers_contact_No", T14.Text)

            cmd.Parameters.AddWithValue("@Fathers_email", T15.Text)
            cmd.Parameters.AddWithValue("@Mothers_name", T16.Text)
            cmd.Parameters.AddWithValue("@Mothers_contact_No", T17.Text)
            cmd.Parameters.AddWithValue("@Mothers_email", T18.Text)
            cmd.Parameters.AddWithValue("@Guardians_name", T19.Text)
            cmd.Parameters.AddWithValue("@Relationship_with_student", T20.Text)
            cmd.Parameters.AddWithValue("@Guardians_email", T21.Text)

            cmd.Parameters.AddWithValue("@Guardians_contact_No", T22.Text)
            cmd.Parameters.AddWithValue("@Case", T23.Text)
            cmd.Parameters.AddWithValue("@One_on_one", T24.Text)
            cmd.Parameters.AddWithValue("@RR_class", T25.Text)
            cmd.Parameters.AddWithValue("@ABCs_class", T26.Text)
            cmd.Parameters.AddWithValue("@Beginner_class", T27.Text)
            cmd.Parameters.AddWithValue("@Skill_development_class", T28.Text)

            cmd.Parameters.AddWithValue("@Sight_reading_class", T29.Text)
            cmd.Parameters.AddWithValue("@Pre_Voc_class", T30.Text)
            cmd.Parameters.AddWithValue("@Learning_center", T31.Text)
            cmd.Parameters.AddWithValue("@BLC_class", T32.Text)
            cmd.Parameters.AddWithValue("@Kinder_music_class", T33.Text)
            cmd.Parameters.AddWithValue("@Group_class_SSDS", T34.Text)
            cmd.Parameters.AddWithValue("@SpEd_class_SSDS", T35.Text)

            cmd.Parameters.AddWithValue("@Antipolo_ABCs", T36.Text)
            cmd.Parameters.AddWithValue("@Antipolo_elementary", T37.Text)
            cmd.Parameters.AddWithValue("@Antipolo_high_school", T38.Text)
            cmd.Parameters.AddWithValue("@Supervisor_Teacher_in_charge", T39.Text)
            cmd.Parameters.AddWithValue("@Remarks", T40.Text)
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

    Private Sub update_table2()
        Dim cmd As MySqlCommand
        con.Open()
        Try

            T2.Text = Val(T2.Text)
            T3.Text = Val(T3.Text)
            T4.Text = Val(T4.Text)
            T5.Text = Val(T5.Text)
            T6.Text = Val(T6.Text)
            T7.Text = Val(T7.Text)

            cmd = con.CreateCommand()
            cmd.CommandText = "update user_privileges.samplecalculation set Student_ID=@Student_ID, Jan=@Jan, Feb=@Feb, Mar=@Mar, Apr=@Apr, May=@May, Jun=@Jun where Student_ID=@Student_ID"
            cmd.Parameters.AddWithValue("@Student_ID", T1.Text)
            cmd.Parameters.AddWithValue("@Jan", T2.Text)
            cmd.Parameters.AddWithValue("@Feb", T3.Text)
            cmd.Parameters.AddWithValue("@Mar", T4.Text)
            cmd.Parameters.AddWithValue("@Apr", T5.Text)
            cmd.Parameters.AddWithValue("@May", T6.Text)
            cmd.Parameters.AddWithValue("@Jun", T7.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data updated")
            con.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()

        End Try
        load_table2()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Table1ToolStripMenuItem.Checked = True Then
            update_table1()
        ElseIf Table2ToolStripMenuItem.Checked = True Then
            update_table2()
        End If
    End Sub

    'deletables

    Private Sub delete_table1()
        Dim cmd As MySqlCommand
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from user_privileges.masterlist where Student_No=@Student_No"
            cmd.Parameters.AddWithValue("@Student_No", T1.Text)
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

    Private Sub delete_table2()
        Dim cmd As MySqlCommand
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from user_privileges.samplecalculation where Student_ID=@Student_ID"
            cmd.Parameters.AddWithValue("@Student_ID", T1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
        load_table2()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Table1ToolStripMenuItem.Checked = True Then
            delete_table1()
        ElseIf Table2ToolStripMenuItem.Checked = True Then
            delete_table2()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try


            'If ComboBox1.Text = "Chart1" Then

            'If Table1ToolStripMenuItem.Text = "Table 1" Then
            If Table1ToolStripMenuItem.Checked Then
                'Dim row As DataGridViewRow = DataGridView1.CurrentRow
                T1.Text = row.Cells("Student_No").Value.ToString
                T2.Text = row.Cells("Status").Value.ToString
                T3.Text = row.Cells("Last_Name").Value.ToString

                T4.Text = row.Cells("First_name").Value.ToString
                T5.Text = row.Cells("Middle_initial").Value.ToString
                T6.Text = row.Cells("Nickname").Value.ToString
                T7.Text = row.Cells("Gender").Value.ToString
                T8.Text = row.Cells("Date_of_birth").Value.ToString
                T9.Text = row.Cells("Age").Value.ToString
                T10.Text = row.Cells("Street").Value.ToString
                T11.Text = row.Cells("Province").Value.ToString
                T12.Text = row.Cells("Home_contact_No").Value.ToString
                T13.Text = row.Cells("Fathers_name").Value.ToString

                T14.Text = row.Cells("Fathers_contact_No").Value.ToString
                T15.Text = row.Cells("Fathers_email").Value.ToString
                T16.Text = row.Cells("Mothers_name").Value.ToString
                T17.Text = row.Cells("Mothers_contact_No").Value.ToString
                T18.Text = row.Cells("Mothers_email").Value.ToString
                T19.Text = row.Cells("Guardians_name").Value.ToString
                T20.Text = row.Cells("Relationship_with_student").Value.ToString
                T21.Text = row.Cells("Guardians_email").Value.ToString

                T22.Text = row.Cells("Guardians_contact_No").Value.ToString
                T23.Text = row.Cells("Case").Value.ToString
                T24.Text = row.Cells("One_on_one").Value.ToString
                T25.Text = row.Cells("RR_class").Value.ToString
                T26.Text = row.Cells("ABCs_class").Value.ToString
                T27.Text = row.Cells("Beginner_class").Value.ToString
                T28.Text = row.Cells("Skill_development_class").Value.ToString
                T29.Text = row.Cells("Sight_reading_class").Value.ToString
                T30.Text = row.Cells("Pre_Voc_class").Value.ToString
                T31.Text = row.Cells("Learning_center").Value.ToString

                T32.Text = row.Cells("BLC_class").Value.ToString
                T33.Text = row.Cells("Kinder_music_class").Value.ToString
                T34.Text = row.Cells("Group_class_SSDS").Value.ToString
                T35.Text = row.Cells("SpEd_class_SSDS").Value.ToString
                T36.Text = row.Cells("Antipolo_ABCs").Value.ToString
                T37.Text = row.Cells("Antipolo_elementary").Value.ToString
                T38.Text = row.Cells("Antipolo_high_school").Value.ToString
                T39.Text = row.Cells("Supervisor_Teacher_in_charge").Value.ToString
                T40.Text = row.Cells("Remarks").Value.ToString

                con.Close()


            ElseIf Table2ToolStripMenuItem.Checked Then
                'ElseIf Table2ToolStripMenuItem.Text.Equals("Table 2") Then
                'Dim row As DataGridViewRow = DataGridView1.CurrentRow


                T1.Text = row.Cells("Student_ID").Value.ToString
                T2.Text = row.Cells("Jan").Value.ToString
                T3.Text = row.Cells("Feb").Value.ToString
                T4.Text = row.Cells("Mar").Value.ToString
                T5.Text = row.Cells("Apr").Value.ToString
                T6.Text = row.Cells("May").Value.ToString
                T7.Text = row.Cells("Jun").Value.ToString

            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub





    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exit now?", "Exit now?", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True

        Else
            Application.ExitThread()

        End If

    End Sub


    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If Table1ToolStripMenuItem.Checked = True And ComboBox2.Text = "Student_No" Then
            'If ComboBox1.Text = "Chart1" And ComboBox2.Text = "Student_No" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet
            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.masterlist where Student_No like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table1ToolStripMenuItem.Checked = True And ComboBox2.Text = "Status" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.masterlist where Status like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Student_ID" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Student_ID like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Jan" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Jan like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Feb" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Feb like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Mar" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Mar like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Apr" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Apr like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "May" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where May like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

        ElseIf Table2ToolStripMenuItem.Checked = True And ComboBox2.Text = "Jun" Then
            Dim adapater As MySqlDataAdapter
            Dim ds As New DataSet

            con.Open()
            adapater = New MySqlDataAdapter("select * from user_privileges.samplecalculation where Jun like '" & TextBox8.Text & "%'", con)
            'adapater = New MySqlDataAdapter("select * from sql_store.customers where first_name Like '%{0}%'" & TextBox8.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        End If

    End Sub


    Private Sub Text1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        'Me.DataGridView1.Rows.Clear()
        'Dim bSource As New BindingSource
        'bSource = Nothing
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T4.Clear()
        T5.Clear()
        T6.Clear()
        T7.Clear()
        T8.Clear()
        T9.Clear()
        T10.Clear()
        T11.Clear()
        T12.Clear()
        T13.Clear()
        T14.Clear()
        T15.Clear()
        T16.Clear()
        T17.Clear()
        T18.Clear()
        T19.Clear()
        T20.Clear()
        T21.Clear()
        T22.Clear()
        T23.Clear()
        T24.Clear()
        T25.Clear()
        T26.Clear()
        T27.Clear()
        T28.Clear()
        T29.Clear()
        T30.Clear()
        T31.Clear()
        T32.Clear()
        T33.Clear()
        T34.Clear()
        T35.Clear()
        T36.Clear()
        T37.Clear()
        T38.Clear()
        T39.Clear()
        T40.Clear()
        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
    End Sub




    Private Sub Table1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Table1ToolStripMenuItem.Click
        Table2ToolStripMenuItem.Checked = False
        Table1ToolStripMenuItem.Checked = False
        Table1ToolStripMenuItem.Checked = True



        load_table()
        ComboBox2.Items.Clear()
        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Student_No")
        ComboBox2.Items.Add("Status")


    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
        DataGridView1.Columns.Clear()
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click

        Application.ExitThread()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        T1.Clear()
        T2.Clear()
        T3.Clear()
        T4.Clear()
        T5.Clear()
        T6.Clear()
        T7.Clear()
        T8.Clear()
        T9.Clear()
        T10.Clear()
        T11.Clear()
        T12.Clear()
        T13.Clear()
        T14.Clear()
        T15.Clear()
        T16.Clear()
        T17.Clear()
        T18.Clear()
        T19.Clear()
        T20.Clear()
        T21.Clear()
        T22.Clear()
        T23.Clear()
        T24.Clear()
        T25.Clear()
        T26.Clear()
        T27.Clear()
        T28.Clear()
        T29.Clear()
        T30.Clear()
        T31.Clear()
        T32.Clear()
        T33.Clear()
        T34.Clear()
        T35.Clear()
        T36.Clear()
        T37.Clear()
        T38.Clear()
        T39.Clear()
        T40.Clear()
        T41.Clear()
        T42.Clear()


    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        If Table1ToolStripMenuItem.Checked Then
            load_table()

        ElseIf Table2ToolStripMenuItem.Checked Then
            load_table2()

        End If
    End Sub

    Private Sub Table2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Table2ToolStripMenuItem.Click

        L1.Text = "Student_ID"
        L2.Text = "Jan"
        L3.Text = "Feb"
        L4.Text = "Mar"
        L5.Text = "Apr"
        L6.Text = "May"
        L7.Text = "Jun"

        L8.Text = "  --"
        L9.Text = "  --"
        L10.Text = "  --"
        L11.Text = "  --"
        L12.Text = "  --"
        L13.Text = "  --"
        L14.Text = "  --"
        L15.Text = "  --"
        L16.Text = "  --"
        L17.Text = "  --"
        L18.Text = "  --"
        L19.Text = "  --"
        L20.Text = "  --"
        L21.Text = "  --"
        L22.Text = "  --"
        L23.Text = "  --"
        L24.Text = "  --"
        L25.Text = "  --"
        L26.Text = "  --"
        L27.Text = "  --"
        L28.Text = "  --"
        L29.Text = "  --"
        L30.Text = "  --"
        L31.Text = "  --"
        L32.Text = "  --"
        L33.Text = "  --"
        L34.Text = "  --"
        L35.Text = "  --"
        L36.Text = "  --"
        L37.Text = "  --"
        L38.Text = "  --"
        L39.Text = "  --"
        L40.Text = "  --"
        L41.Text = "  --"
        L42.Text = "  --"

        Table1ToolStripMenuItem.Checked = False
        Table2ToolStripMenuItem.Checked = False
        Table2ToolStripMenuItem.Checked = True

        load_table2()
        ComboBox2.Items.Clear()
        ComboBox2.Text = "Choose one . . . "
        ComboBox2.Items.Add("Student_ID")
        ComboBox2.Items.Add("Jan")
        ComboBox2.Items.Add("Feb")
        ComboBox2.Items.Add("Mar")
        ComboBox2.Items.Add("Apr")
        ComboBox2.Items.Add("May")
        ComboBox2.Items.Add("Jun")


    End Sub


    Private Sub FormMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormMenuToolStripMenuItem.Click

    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If Table1ToolStripMenuItem.Checked Then
            Print1.Show()
            Me.Hide()


        ElseIf Table2ToolStripMenuItem.Checked Then
            Print2.Show()
            Me.Hide()

        End If
        Print1.LoadPrint1()
        Print2.LoadPrint2()
    End Sub
End Class