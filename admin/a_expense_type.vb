Public Class a_expense_type
    Private Sub a_expense_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_expense_category' table. You can move, or remove it, as needed.
        Me.L_expense_categoryTableAdapter.Fill(Me.SourceDataSet.l_expense_category)
        LexpensecategoryBindingSource.Sort = "expense_category ASC"

        'TODO: This line of code loads data into the 'SourceDataSet.l_expense_type' table. You can move, or remove it, as needed.
        Me.L_expense_typeTableAdapter.Fill(Me.SourceDataSet.l_expense_type)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub a_expense_type_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_expense_typeTableAdapter.Update(Me.SourceDataSet.l_expense_type)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class