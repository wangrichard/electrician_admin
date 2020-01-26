Imports System.Data.OleDb

Public Class o_global_balance

    Private Sub o_global_balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SourceDataSet.r_expense' table. You can move, or remove it, as needed.
        Me.R_expenseTableAdapter.Fill(Me.SourceDataSet.r_expense)
        'TODO: This line of code loads data into the 'SourceDataSet.r_income' table. You can move, or remove it, as needed.
        Me.R_incomeTableAdapter.Fill(Me.SourceDataSet.r_income)

        from_date.Value = Date.Now.AddMonths(-1)

        query_profit()

    End Sub

    Private Sub query_profit()
        t_income.Text = vbNull
        t_expense.Text = vbNull
        t_profit.Text = vbNull

        Dim sql_str = "SELECT Sum(r_income.amount) AS income " &
                     "FROM r_income " &
                     "GROUP BY r_income.record_date " &
                     "HAVING r_income.record_date Between " &
                     Chr(35) & from_date.Value & Chr(35) & " And " & Chr(35) & to_date.Value & Chr(35)

        Me.R_incomeTableAdapter.Connection.Open()
        Me.R_incomeTableAdapter.Adapter.SelectCommand.CommandText = sql_str
        Dim rst As OleDbDataReader

        Try
            rst = Me.R_incomeTableAdapter.Adapter.SelectCommand.ExecuteReader()
            If rst.HasRows Then
                rst.Read()
                t_income.Text = rst.GetValue(0)
            Else
                t_income.Text = 0
            End If
            Me.R_incomeTableAdapter.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        sql_str = "SELECT Sum(r_expense.amount) AS expense " &
                     "FROM r_expense " &
                     "GROUP BY r_expense.record_date " &
                     "HAVING r_expense.record_date Between " &
               Chr(35) & from_date.Value & Chr(35) & " And " & Chr(35) & to_date.Value & Chr(35)

        Me.R_expenseTableAdapter.Adapter.SelectCommand.CommandText = sql_str

        Me.R_expenseTableAdapter.Connection.Open()

        Try
            rst = Me.R_expenseTableAdapter.Adapter.SelectCommand.ExecuteReader()
            If rst.HasRows Then
                rst.Read()
                t_expense.Text = rst.GetValue(0)
            Else
                t_expense.Text = 0
            End If
            Me.R_expenseTableAdapter.Connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        t_profit.Text = t_income.Text - t_expense.Text

    End Sub

    Private Sub to_date_ValueChanged(sender As Object, e As EventArgs) Handles to_date.ValueChanged
        query_profit()
    End Sub

    Private Sub from_date_ValueChanged(sender As Object, e As EventArgs) Handles from_date.ValueChanged
        query_profit()
    End Sub
End Class