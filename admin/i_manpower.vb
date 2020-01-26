Imports System.Data.OleDb
Imports System.Configuration

Public Class i_manpower
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub i_manpower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_employee' table. You can move, or remove it, as needed.
        Me.L_employeeTableAdapter.Fill(Me.SourceDataSet.l_employee)
        'TODO: This line of code loads data into the 'SourceDataSet.r_project' table. You can move, or remove it, as needed.
        Me.R_projectTableAdapter.Fill(Me.SourceDataSet.r_project)
        RprojectBindingSource.Sort = "ID DESC"

        'TODO: This line of code loads data into the 'SourceDataSet.r_manpower' table. You can move, or remove it, as needed.
        Me.R_manpowerTableAdapter.Fill(Me.SourceDataSet.r_manpower)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True

    End Sub

    Private Sub i_manpower_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            R_manpowerTableAdapter.Update(Me.SourceDataSet.r_manpower)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'MsgBox("rowindex: " & e.RowIndex & " columnindex: " & e.ColumnIndex)
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 2 Then
            Try
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim sql_str = "SELECT hourly_rate FROM l_employee WHERE ID=" &
                    DataGridView1.Rows(e.RowIndex).Cells(2).Value

                da = New OleDbDataAdapter(sql_str, cn)
                ds = New DataSet
                da.Fill(ds, "l_employee")
                If ds.Tables(0).Rows.Count > 0 Then
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value = ds.Tables(0).Rows(0).Item(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If e.ColumnIndex = 3 Then
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) Then Return

            Try
                Dim cmdText As String = "UPDATE l_employee SET hourly_rate=" &
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value &
                    " WHERE ID=" & DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Dim cmd As OleDbCommand = New OleDbCommand(cmdText, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message)
            End Try

            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(5).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value *
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value
            End If

        End If

        If e.ColumnIndex = 4 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(5).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value *
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value
            End If
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(6).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = DateTime.Today.Date
            End If
        End If
    End Sub

End Class