Imports System.Data.OleDb
Imports System.Configuration

Public Class o_project_detail
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub o_project_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t_customer_name.Text = DBNull.Value.ToString
        t_start_date.Text = DBNull.Value.ToString
        t_profit.Text = DBNull.Value.ToString

        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet
            Dim sql_str As String = "SELECT * FROM r_project ORDER BY ID DESC"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "r_project")
            cmb_project.DataSource = ds.Tables(0)
            cmb_project.ValueMember = "ID"
            cmb_project.DisplayMember = "project_address"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        t_customer_name.Text = DBNull.Value.ToString
        t_start_date.Text = DBNull.Value.ToString
        t_profit.Text = DBNull.Value.ToString

        cmb_project.SelectedValue = -1

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_project.SelectedIndexChanged
        If IsNothing(cmb_project.SelectedValue) Then
            Return
        End If

        query_manpower()
        query_material()
        query_income()
        query_project()
    End Sub
    Public Sub query_manpower()
        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT * FROM q_manpower_effort "
            sql_str = sql_str & "WHERE project_id = " & cmb_project.SelectedValue
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "q_manpower_effort")
            DataGridView1.DataSource = ds.Tables(0)

            If ds.Tables(0).Rows.Count > 0 Then
                t_work_hour.Text = ds.Tables(0).Compute("SUM(work_hours)", String.Empty)
                t_payment.Text = ds.Tables(0).Compute("SUM(payment)", String.Empty)
            Else
                t_work_hour.Text = DBNull.Value.ToString
                t_payment.Text = DBNull.Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub query_material()
        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT * FROM q_material_out "
            sql_str = sql_str & "WHERE project_id = " & cmb_project.SelectedValue
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "q_material_out")
            DataGridView2.DataSource = ds.Tables(0)

            If ds.Tables(0).Rows.Count > 0 Then
                t_cost.Text = ds.Tables(0).Compute("SUM(cost)", String.Empty)
            Else
                t_cost.Text = DBNull.Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub query_income()
        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT * FROM q_income "
            sql_str = sql_str & "WHERE project_id = " & cmb_project.SelectedValue
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "q_income")
            DataGridView3.DataSource = ds.Tables(0)

            If ds.Tables(0).Rows.Count > 0 Then
                t_income.Text = ds.Tables(0).Compute("SUM(amount)", String.Empty)
            Else
                t_income.Text = DBNull.Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub query_project()
        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT * FROM s_project_profit "
            sql_str = sql_str & "WHERE project_id = " & cmb_project.SelectedValue
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "s_project_profit")

            If ds.Tables(0).Rows.Count > 0 Then
                t_customer_name.Text = ds.Tables(0).Rows(0).Item(1)
                t_start_date.Text = ds.Tables(0).Rows(0).Item(2)
                If IsDBNull(ds.Tables(0).Rows(0).Item(6)) Then
                    t_profit.Text = ""
                Else
                    t_profit.Text = ds.Tables(0).Rows(0).Item(6)
                End If
            Else
                t_customer_name.Text = DBNull.Value.ToString
                t_start_date.Text = DBNull.Value.ToString
                t_profit.Text = DBNull.Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class