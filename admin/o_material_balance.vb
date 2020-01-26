Public Class o_material_balance
    Private Sub o_material_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.s_material_balance' table. You can move, or remove it, as needed.
        Me.S_material_balanceTableAdapter.Fill(Me.SourceDataSet.s_material_balance)

    End Sub
End Class