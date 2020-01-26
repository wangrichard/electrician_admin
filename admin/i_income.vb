Public Class i_income
    Private Sub i_income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_income_type' table. You can move, or remove it, as needed.
        Me.L_income_typeTableAdapter.Fill(Me.SourceDataSet.l_income_type)
        'TODO: This line of code loads data into the 'SourceDataSet.r_project' table. You can move, or remove it, as needed.
        Me.R_projectTableAdapter.Fill(Me.SourceDataSet.r_project)
        RprojectBindingSource.Sort = "ID DESC"
        'TODO: This line of code loads data into the 'SourceDataSet.r_income' table. You can move, or remove it, as needed.
        Me.R_incomeTableAdapter.Fill(Me.SourceDataSet.r_income)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub i_income_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.R_incomeTableAdapter.Update(Me.SourceDataSet.r_income)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 3 Then
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = DateTime.Today.Date
            End If
        End If
    End Sub
End Class