Public Class a_employee
    Private Sub a_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_employee' table. You can move, or remove it, as needed.
        Me.L_employeeTableAdapter.Fill(Me.SourceDataSet.l_employee)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub a_employee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_employeeTableAdapter.Update(Me.SourceDataSet.l_employee)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class