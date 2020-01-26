Public Class a_expense_category
    Private Sub a_expense_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_expense_category' table. You can move, or remove it, as needed.
        Me.L_expense_categoryTableAdapter.Fill(Me.SourceDataSet.l_expense_category)

    End Sub

    Private Sub a_expense_category_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_expense_categoryTableAdapter.Update(Me.SourceDataSet.l_expense_category)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class