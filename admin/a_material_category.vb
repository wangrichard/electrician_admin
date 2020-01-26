Public Class a_material_category
    Private Sub a_material_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_category' table. You can move, or remove it, as needed.
        Me.L_material_categoryTableAdapter.Fill(Me.SourceDataSet.l_material_category)

    End Sub

    Private Sub a_material_category_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_material_categoryTableAdapter.Update(Me.SourceDataSet.l_material_category)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class