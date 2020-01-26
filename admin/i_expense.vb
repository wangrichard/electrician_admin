Public Class i_expense
    Private Sub i_expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_expense_type' table. You can move, or remove it, as needed.
        Me.L_expense_typeTableAdapter.Fill(Me.SourceDataSet.l_expense_type)
        LexpensetypeBindingSource.Sort = "expense_type ASC"

        'TODO: This line of code loads data into the 'SourceDataSet.l_expense_category' table. You can move, or remove it, as needed.
        Me.L_expense_categoryTableAdapter.Fill(Me.SourceDataSet.l_expense_category)
        LexpensecategoryBindingSource.Sort = "expense_category ASC"

        'TODO: This line of code loads data into the 'SourceDataSet.r_expense' table. You can move, or remove it, as needed.
        Me.R_expenseTableAdapter.Fill(Me.SourceDataSet.r_expense)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True

    End Sub

    Private Sub i_expense_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.R_expenseTableAdapter.Update(Me.SourceDataSet.r_expense)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        If IsNothing(DataGridView1.CurrentCell) Then Return

        Try
            If DataGridView1.CurrentCell.ColumnIndex = 2 Then
                Dim dv As New DataView(SourceDataSet.l_expense_type, "expense_category_id = " &
                                   DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value,
                                   "expense_type", DataViewRowState.CurrentRows)
                If dv.Count = 0 Then Return
                Dim cell As DataGridViewComboBoxCell = CType(DataGridView1.CurrentCell, DataGridViewComboBoxCell)
                cell.DataSource = dv
                cell.ValueMember = "ID"
                cell.DisplayMember = "expense_type"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 1 Then
            Dim cell As DataGridViewComboBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(2), DataGridViewComboBoxCell)
            cell.Value = DBNull.Value
        End If

        If e.ColumnIndex = 3 Then
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = DateTime.Today.Date
            End If
        End If

    End Sub
End Class