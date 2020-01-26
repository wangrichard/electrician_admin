Imports System.Data.OleDb
Imports System.Configuration

Public Class login
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query_login()
    End Sub

    Public Sub query_login()
        Dim da As OleDbDataAdapter
        Dim ds As DataSet

        If Trim(user_name.Text) = "" Then
            MsgBox("Please enter user name.")
            Return
        End If

        Try
            Dim sql_str As String = "SELECT * FROM l_user " &
            "WHERE user_name=" & Chr(34) & Trim(user_name.Text) & Chr(34) &
            " AND user_password=" & Chr(34) & user_password.Text & Chr(34)
            da = New OleDbDataAdapter(sql_str, cn)
            ds = New DataSet
            da.Fill(ds, "l_user")

            If ds.Tables(0).Rows.Count > 0 Then
                user_group.Text = ds.Tables(0).Rows(0).Item(2)
                user_id.Text = ds.Tables(0).Rows(0).Item(0)
                Me.Hide()
                main.Show()
            Else
                MsgBox("Login fail")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToggleConfigEncryption("admin.exe")

        user_name.Text = ""
        user_password.Text = ""
        user_group.Text = ""
        user_id.Text = ""
    End Sub

    Shared Sub ToggleConfigEncryption(ByVal exeConfigName As String)
        ' Takes the executable file name without the
        ' .config extension.
        Try
            ' Open the configuration file and retrieve 
            ' the connectionStrings section.
            Dim config As Configuration = ConfigurationManager.
                OpenExeConfiguration(exeConfigName)

            Dim section As ConnectionStringsSection = DirectCast(
                config.GetSection("connectionStrings"),
                ConnectionStringsSection)

            If section.SectionInformation.IsProtected Then
                ' Remove encryption.
                section.SectionInformation.UnprotectSection()
            Else
                ' Encrypt the section.
                section.SectionInformation.ProtectSection(
                  "DataProtectionConfigurationProvider")
            End If

            ' Save the current configuration.
            config.Save()

            Console.WriteLine("Protected={0}",
            section.SectionInformation.IsProtected)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class