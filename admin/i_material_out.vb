Imports System.Data.OleDb
Imports System.Configuration

Public Class i_material_out
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub i_material_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_type' table. You can move, or remove it, as needed.
        Me.L_material_typeTableAdapter.Fill(Me.SourceDataSet.l_material_type)
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_category' table. You can move, or remove it, as needed.
        Me.L_material_categoryTableAdapter.Fill(Me.SourceDataSet.l_material_category)
        'TODO: This line of code loads data into the 'SourceDataSet.r_project' table. You can move, or remove it, as needed.
        Me.R_projectTableAdapter.Fill(Me.SourceDataSet.r_project)
        RprojectBindingSource.Sort = "ID DESC"

        'TODO: This line of code loads data into the 'SourceDataSet.l_employee' table. You can move, or remove it, as needed.
        Me.L_employeeTableAdapter.Fill(Me.SourceDataSet.l_employee)
        'TODO: This line of code loads data into the 'SourceDataSet.r_material_out' table. You can move, or remove it, as needed.
        Me.R_material_outTableAdapter.Fill(Me.SourceDataSet.r_material_out)

        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1
        DataGridView1.Rows(DataGridView1.RowCount - 1).Selected = True
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        If IsNothing(DataGridView1.CurrentCell) Then Return

        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            Try
                Dim dv As New DataView(SourceDataSet.l_material_type, "material_category_id = " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value,
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

    Private Sub i_material_out_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.R_material_outTableAdapter.Update(Me.SourceDataSet.r_material_out)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'MsgBox("rowindex: " & e.RowIndex & " columnindex: " & e.ColumnIndex)
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = 2 Then
            Dim cell As DataGridViewComboBoxCell = CType(DataGridView1.Rows(e.RowIndex).Cells(3), DataGridViewComboBoxCell)
            cell.Value = DBNull.Value
        End If

        If e.ColumnIndex = 3 Then
            Try
                Dim da As OleDbDataAdapter
                Dim ds As DataSet
                Dim sql_str = "SELECT unit_price FROM l_material_type WHERE ID=" &
                    DataGridView1.Rows(e.RowIndex).Cells(3).Value

                da = New OleDbDataAdapter(sql_str, cn)
                ds = New DataSet
                da.Fill(ds, "l_material_type")
                If ds.Tables(0).Rows.Count > 0 Then
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value = ds.Tables(0).Rows(0).Item(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If e.ColumnIndex = 4 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(5).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value *
                    DataGridView1.Rows(e.RowIndex).Cells(5).Value
            End If
        End If

        If e.ColumnIndex = 5 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(4).Value) And
               Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(5).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(6).Value =
                    DataGridView1.Rows(e.RowIndex).Cells(4).Value *
                    DataGridView1.Rows(e.RowIndex).Cells(5).Value
            End If
            If IsDBNull(DataGridView1.Rows(e.RowIndex).Cells(7).Value) Then
                DataGridView1.Rows(e.RowIndex).Cells(7).Value = DateTime.Today.Date
            End If
        End If
    End Sub

End Class