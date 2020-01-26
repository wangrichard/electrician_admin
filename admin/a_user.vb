Public Class a_user
    Private Sub a_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_group' table. You can move, or remove it, as needed.
        Me.L_groupTableAdapter.Fill(Me.SourceDataSet.l_group)

        LuserBindingSource.Filter = "ID<>1"

        'TODO: This line of code loads data into the 'SourceDataSet.l_user' table. You can move, or remove it, as needed.
        Me.L_userTableAdapter.Fill(Me.SourceDataSet.l_user)

        'DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)


    End Sub

    Private Sub a_user_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.L_userTableAdapter.Update(Me.SourceDataSet.l_user)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

End Class