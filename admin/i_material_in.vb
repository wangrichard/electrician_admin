Imports System.Data.OleDb
Imports System.Configuration

Public Class i_material_in
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub i_material_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_type' table. You can move, or remove it, as needed.
        Me.L_material_typeTableAdapter.Fill(Me.SourceDataSet.l_material_type)
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_category' table. You can move, or remove it, as needed.
        Me.L_material_categoryTableAdapter.Fill(Me.SourceDataSet.l_material_category)
        'TODO: This line of code loads data into the 'SourceDataSet.r_material_in' table. You can move, or remove it, as needed.
        Me.R_material_inTableAdapter.Fill(Me.SourceDataSet.r_material_in)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True

    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        If IsNothing(DataGridView1.CurrentCell) Then Return

        If DataGridView1.CurrentCell.ColumnIndex = 2 Then
            Try
                Dim dv As New DataView(SourceDataSet.l_material_type, "material_category_id = " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value,
                                           "material_type", DataViewRowState.CurrentRows)
                If dv.Count = 0 Then Return
                Dim cell As DataGridViewComboBoxCell = CType(DataGridView1.CurrentCell, DataGridViewComboBoxCell)
                cell.DataSource = dv
                cell.ValueMember = "ID"
                cell.DisplayMember = "material_type"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub i_material_in_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.R_material_inTableAdapter.Update(Me.SourceDataSet.r_material_in)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 1 Then
            'Dim dv As New DataView(SourceDataSet.l_material_type, "material_category_id = " & DataGridView1.CurrentCell.Value,
            '                         "material_type", DataViewRowState.CurrentRows)
            'If dv.Count = 0 Then Return

            Dim cell As DataGridViewComboBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(2), DataGridViewComboBoxCell)
            cell.Value = DBNull.Value

            'cell.DataSource = dv
            'cell.ValueMember = "ID"
            'cell.DisplayMember = "material_type"
        End If

        If e.ColumnIndex = 2 Then
            Try
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim sql_str = "SELECT unit_price FROM l_material_type WHERE ID=" &
                    DataGridView1.Rows(e.RowIndex).Cells(2).Value

                da = New OleDbDataAdapter(sql_str, cn)
                ds = New DataSet
                da.Fill(ds, "l_material_type")
                If ds.Tables(0).Rows.Count > 0 Then
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value = ds.Tables(0).Rows(0).Item(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If e.ColumnIndex = 3 Then
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) Then
                Return
            End If

            Try
                Dim cmdText As String = "UPDATE l_material_type SET unit_price=" &
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value &
                    " WHERE ID=" & DataGridView1.Rows(e.RowIndex).Cells(2).Value
                Dim cmd As OleDbCommand = New OleDbCommand(cmdText, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message)
            End Try

            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(5).Value =
                DataGridView1.Rows(e.RowIndex).Cells(3).Value *
                DataGridView1.Rows(e.RowIndex).Cells(4).Value
            End If

        End If


        If e.ColumnIndex = 4 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(3).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(5).Value =
                DataGridView1.Rows(e.RowIndex).Cells(3).Value *
                DataGridView1.Rows(e.RowIndex).Cells(4).Value
            End If

            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(6).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = DateTime.Today.Date
            End If
        End If

    End Sub
End Class