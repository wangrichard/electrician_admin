Public Class a_material_type
    Private Sub a_material_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_category' table. You can move, or remove it, as needed.
        Me.L_material_categoryTableAdapter.Fill(Me.SourceDataSet.l_material_category)
        LmaterialcategoryBindingSource.Sort = "material_category ASC"

        'TODO: This line of code loads data into the 'SourceDataSet.l_material_type' table. You can move, or remove it, as needed.
        Me.L_material_typeTableAdapter.Fill(Me.SourceDataSet.l_material_type)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub a_material_type_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_material_typeTableAdapter.Update(Me.SourceDataSet.l_material_type)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
End Class