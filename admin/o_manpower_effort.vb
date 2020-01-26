Imports System.Data.OleDb
Imports System.Configuration

Public Class o_manpower_effort
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub o_manpower_effort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_employee' table. You can move, or remove it, as needed.
        Me.L_employeeTableAdapter.Fill(Me.SourceDataSet.l_employee)
        'TODO: This line of code loads data into the 'SourceDataSet.q_manpower_effort' table. You can move, or remove it, as needed.
        Me.Q_manpower_effortTableAdapter.Fill(Me.SourceDataSet.q_manpower_effort)

        Try
            If Me.SourceDataSet.q_manpower_effort.Rows.Count > 0 Then
                t_work_hour.Text = Me.SourceDataSet.q_manpower_effort.Compute("SUM(work_hours)", String.Empty)
                t_payment.Text = Me.SourceDataSet.q_manpower_effort.Compute("SUM(payment)", String.Empty)
            Else
                t_work_hour.Text = DBNull.Value.ToString
                t_payment.Text = DBNull.Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        d_from_date.Value = Date.Now.AddMonths(-1)

        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet
            Dim sql_str As String = "SELECT * FROM l_employee"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "l_employee")

            Dim row As DataRow = ds.Tables(0).NewRow
            row("ID") = -1
            row("name") = ""
            ds.Tables(0).Rows.InsertAt(row, 0)
            cmb_employee.DataSource = ds.Tables(0)
            cmb_employee.ValueMember = "ID"
            cmb_employee.DisplayMember = "name"
            cmb_employee.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_employee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employee.SelectedIndexChanged
        dynamic_ds()
    End Sub

    Public Sub dynamic_ds()

        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT * FROM q_manpower_effort "
            If Not IsNothing(cmb_employee.SelectedValue) Then
                sql_str = sql_str & "WHERE employee_id = " & cmb_employee.SelectedValue
                If Not IsDBNull(d_from_date.Value) And Not IsDBNull(d_to_date.Value) Then
                    sql_str = sql_str & " AND record_date BETWEEN " &
                         Chr(35) & d_from_date.Value & Chr(35) & " AND " &
                         Chr(35) & d_to_date.Value & Chr(35)
                End If
            Else
                If Not IsDBNull(d_from_date.Value) And Not IsDBNull(d_to_date.Value) Then
                    sql_str = sql_str & " WHERE record_date BETWEEN " &
                         Chr(35) & d_from_date.Value & Chr(35) & " AND " &
                         Chr(35) & d_to_date.Value & Chr(35)
                End If
            End If

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

    Private Sub d_to_date_ValueChanged(sender As Object, e As EventArgs) Handles d_to_date.ValueChanged
        dynamic_ds()
    End Sub

    Private Sub d_from_date_ValueChanged(sender As Object, e As EventArgs) Handles d_from_date.ValueChanged
        dynamic_ds()
    End Sub

End Class