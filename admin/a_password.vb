Imports System.Data.OleDb
Imports System.Configuration

Public Class a_password
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update_password()
    End Sub

    Public Sub update_password()
        Dim da As OleDbDataAdapter
        Dim ds As DataSet

        If new_password.Text <> confirm_password.Text Then
            MsgBox("New Password doesn't match")
            Return
        End If

        Try
            Dim sql_str As String = "SELECT * FROM l_user " &
            "WHERE user_name=" & Chr(34) & Trim(login.user_name.Text) & Chr(34) &
            " AND user_password=" & Chr(34) & current_password.Text & Chr(34)
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "l_user")
            If ds.Tables(0).Rows.Count <= 0 Then
                MsgBox("Current password incorrect")
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim cmdText As String = "UPDATE l_user SET user_password=" &
                    Chr(34) & new_password.Text & Chr(34) &
                    " WHERE ID=" & login.user_id.Text
        Dim cmd As OleDbCommand = New OleDbCommand(cmdText, cn)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message)
            Return
        End Try

        cn.Close()
        MsgBox("Password updated")

    End Sub

End Class