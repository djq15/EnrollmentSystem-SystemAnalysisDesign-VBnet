Imports MySql.Data.MySqlClient


Public Class Print2

    Private kon As New MySqlConnection("server=localhost;userid=root;password=ieti19;port=3306;database=user_privileges")

    Private Sub Print1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrint2()
    End Sub
    Public Sub LoadPrint2()
        Dim query As String = "SELECT * , (Jan + Feb + Mar + Apr + May + Jun) as Total,(Jan + Feb + Mar + Apr + May + Jun) / 6 as `Per Month Payment` FROM user_privileges.samplecalculation"
        Dim adpt As New MySqlDataAdapter(query, kon)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        kon.Close()
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        'sql = "select * from db_login.tb_login"
        'sql = "select * from db_login.tb_login where username='inc.'"
        sql = "select * from user_privileges.samplecalculation where Student_ID='" & TextBox1.Text & "'"

        Try
            kon.Open()
            cmd = New MySqlCommand(sql, kon)
            adp.SelectCommand = cmd
            adp.Fill(dt, "samplecalculation")
            'adp.Fill(dt, "Emp")
            Dim report As New CrystalReport2
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            kon.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            kon.Close()
        End Try
        kon.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        TextBox1.Text = row.Cells("Student_ID").Value.ToString
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadPrint2()
    End Sub
End Class