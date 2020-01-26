Public Class a_customer
    Private Sub a_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_customer' table. You can move, or remove it, as needed.
        Me.L_customerTableAdapter.Fill(Me.SourceDataSet.l_customer)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub a_customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_customerTableAdapter.Update(Me.SourceDataSet.l_customer)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class