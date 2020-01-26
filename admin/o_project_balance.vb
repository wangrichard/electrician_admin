Public Class o_project_balance
    Private Sub o_project_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.s_project_profit' table. You can move, or remove it, as needed.
        Me.S_project_profitTableAdapter.Fill(Me.SourceDataSet.s_project_profit)

    End Sub
End Class