Public Class a_project
    Private Sub a_project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_customer' table. You can move, or remove it, as needed.
        Me.L_customerTableAdapter.Fill(Me.SourceDataSet.l_customer)
        LcustomerBindingSource.Sort = "customer_name ASC"

        'TODO: This line of code loads data into the 'SourceDataSet.r_project' table. You can move, or remove it, as needed.
        Me.R_projectTableAdapter.Fill(Me.SourceDataSet.r_project)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True

    End Sub

    Private Sub a_project_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.R_projectTableAdapter.Update(Me.SourceDataSet.r_project)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class