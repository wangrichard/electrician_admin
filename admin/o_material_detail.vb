Imports System.Data.OleDb
Imports System.Configuration

Public Class o_material_detail
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub o_material_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_type' table. You can move, or remove it, as needed.
        Me.L_material_typeTableAdapter.Fill(Me.SourceDataSet.l_material_type)
        'TODO: This line of code loads data into the 'SourceDataSet.l_material_category' table. You can move, or remove it, as needed.
        Me.L_material_categoryTableAdapter.Fill(Me.SourceDataSet.l_material_category)
        'TODO: This line of code loads data into the 'SourceDataSet.q_material_detail_out' table. You can move, or remove it, as needed.
        Me.Q_material_detail_outTableAdapter.Fill(Me.SourceDataSet.q_material_detail_out)
        'TODO: This line of code loads data into the 'SourceDataSet.q_material_detail_in' table. You can move, or remove it, as needed.
        Me.Q_material_detail_inTableAdapter.Fill(Me.SourceDataSet.q_material_detail_in)

        d_from_date.Value = Date.Now.AddMonths(-1)

        query_cmb_material_category()
        query_cmb_material_type()

        query_material_in()
        query_material_out()
    End Sub

    Public Sub query_cmb_material_category()

        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet
            Dim sql_str As String = "SELECT * FROM l_material_category ORDER BY material_category ASC"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "l_material_category")

            Dim row As DataRow = ds.Tables(0).NewRow
            row("ID") = -1
            row("material_category") = ""
            ds.Tables(0).Rows.InsertAt(row, 0)
            cmb_material_category.DataSource = ds.Tables(0)
            cmb_material_category.ValueMember = "ID"
            cmb_material_category.DisplayMember = "material_category"
            cmb_material_category.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub query_cmb_material_type()

        Try
            Dim da As OleDbDataAdapter
            Dim ds As DataSet
            Dim sql_str As String = "SELECT ID, material_type " &
                  "FROM l_material_type WHERE material_category_id=" &
                  cmb_material_category.SelectedValue &
                  " ORDER BY material_type ASC"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "l_material_type")

            Dim row As DataRow = ds.Tables(0).NewRow
            row("ID") = -1
            row("material_type") = ""
            ds.Tables(0).Rows.InsertAt(row, 0)
            cmb_material_type.DataSource = ds.Tables(0)
            cmb_material_type.ValueMember = "ID"
            cmb_material_type.DisplayMember = "material_type"
            cmb_material_type.SelectedValue = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_material_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_material_category.SelectedIndexChanged
        query_cmb_material_type()

        query_material_in()
    End Sub

    Public Sub query_material_in()
        Try

            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT material_category, material_type, " &
                "Sum(quantity) AS quantity " &
                "FROM q_material_detail_in"

            If Not IsDBNull(d_from_date.Value) And Not IsDBNull(d_to_date.Value) Then
                sql_str = sql_str & " WHERE record_date BETWEEN " &
                         Chr(35) & d_from_date.Value & Chr(35) & " AND " &
                         Chr(35) & d_to_date.Value & Chr(35)
            End If

            If Not IsNothing(cmb_material_category.SelectedValue) Then
                If sql_str.Contains("WHERE") Then
                    sql_str = sql_str & " AND material_category_id=" & cmb_material_category.SelectedValue
                Else
                    sql_str = sql_str & " WHERE material_category_id=" & cmb_material_category.SelectedValue
                End If
            End If

            If Not IsNothing(cmb_material_type.SelectedValue) Then
                If sql_str.Contains("WHERE") Then
                    sql_str = sql_str & " AND material_type_id=" & cmb_material_type.SelectedValue
                Else
                    sql_str = sql_str & " WHERE material_type=_id" & cmb_material_type.SelectedValue
                End If
            End If

            sql_str = sql_str & " GROUP BY material_category, material_type"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "q_material_detail_in")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub query_material_out()
        Try

            Dim da As OleDbDataAdapter
            Dim ds As DataSet

            Dim sql_str As String = "SELECT material_category, material_type, " &
                "Sum(quantity) AS quantity " &
                "FROM q_material_detail_out"

            If Not IsDBNull(d_from_date.Value) And Not IsDBNull(d_to_date.Value) Then
                sql_str = sql_str & " WHERE record_date BETWEEN " &
                         Chr(35) & d_from_date.Value & Chr(35) & " AND " &
                         Chr(35) & d_to_date.Value & Chr(35)
            End If

            If Not IsNothing(cmb_material_category.SelectedValue) Then
                If sql_str.Contains("WHERE") Then
                    sql_str = sql_str & " AND material_category_id=" & cmb_material_category.SelectedValue
                Else
                    sql_str = sql_str & " WHERE material_category_id=" & cmb_material_category.SelectedValue
                End If
            End If

            If Not IsNothing(cmb_material_type.SelectedValue) Then
                If sql_str.Contains("WHERE") Then
                    sql_str = sql_str & " AND material_type_id=" & cmb_material_type.SelectedValue
                Else
                    sql_str = sql_str & " WHERE material_type=_id" & cmb_material_type.SelectedValue
                End If
            End If

            sql_str = sql_str & " GROUP BY material_category, material_type"

            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "q_material_detail_out")
            DataGridView2.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub d_from_date_ValueChanged(sender As Object, e As EventArgs) Handles d_from_date.ValueChanged
        query_material_in()
        query_material_out()
    End Sub

    Private Sub d_to_date_ValueChanged(sender As Object, e As EventArgs) Handles d_to_date.ValueChanged
        query_material_in()
        query_material_out()
    End Sub

    Private Sub cmb_material_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_material_type.SelectedIndexChanged
        query_material_in()
        query_material_out()
    End Sub
End Class