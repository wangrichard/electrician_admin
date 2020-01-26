Imports System.Data.OleDb
Imports System.Configuration

Public Class main
    Dim cnstr As String = ConfigurationManager.ConnectionStrings("admin.My.MySettings.sourceConnectionString").ConnectionString
    Dim cn As OleDbConnection = New OleDbConnection(cnstr)

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        a_customer.TopMost = False
        a_customer.Show()

    End Sub

    Private Sub ProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectToolStripMenuItem.Click
        a_employee.TopMost = False
        a_employee.Show()

    End Sub

    Private Sub ProjectToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProjectToolStripMenuItem1.Click
        a_project.TopMost = False
        a_project.Show()

    End Sub

    Private Sub MaterialCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialCategoryToolStripMenuItem.Click
        a_material_category.TopMost = False
        a_material_category.Show()

    End Sub

    Private Sub MaterialTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialTypeToolStripMenuItem.Click
        a_material_type.TopMost = False
        a_material_type.Show()

    End Sub

    Private Sub ExpenseCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseCategoryToolStripMenuItem.Click
        a_expense_category.TopMost = False
        a_expense_category.Show()
    End Sub

    Private Sub ExpenseTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseTypeToolStripMenuItem.Click
        a_expense_type.TopMost = False
        a_expense_type.Show()
    End Sub

    Private Sub ManpowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManpowerToolStripMenuItem.Click
        i_manpower.TopMost = False
        i_manpower.Show()
    End Sub

    Private Sub MaterialInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialInToolStripMenuItem.Click
        i_material_in.TopMost = False
        i_material_in.Show()
    End Sub

    Private Sub MaterialOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialOutToolStripMenuItem.Click
        i_material_out.TopMost = False
        i_material_out.Show()
    End Sub

    Private Sub ExpenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseToolStripMenuItem.Click
        i_expense.TopMost = False
        i_expense.Show()
    End Sub

    Private Sub IncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeToolStripMenuItem.Click
        i_income.TopMost = False
        i_income.Show()
    End Sub

    Private Sub ProjectDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectDetailToolStripMenuItem.Click
        o_project_detail.TopMost = False
        o_project_detail.Show()
    End Sub

    Private Sub ProjectBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectBalanceToolStripMenuItem.Click
        o_project_balance.TopMost = False
        o_project_balance.Show()
    End Sub

    Private Sub MaterialBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialBalanceToolStripMenuItem.Click
        o_material_balance.TopMost = False
        o_material_balance.Show()
    End Sub

    Private Sub ManpowerBalanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManpowerBalanceToolStripMenuItem.Click
        o_manpower_effort.TopMost = False
        o_manpower_effort.Show()
    End Sub

    Private Sub MaterialOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaterialOutToolStripMenuItem1.Click
        o_material_detail.TopMost = False
        o_material_detail.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Items(0).Visible = True
        MenuStrip1.Items(1).Visible = True
        MenuStrip1.Items(2).Visible = False
        MenuStrip1.Items(3).Visible = False
        MenuStrip1.Items(4).Visible = False
        MenuStrip1.Items(5).Visible = False
        MenuStrip1.Items(6).Visible = False
        MenuStrip1.Items(7).Visible = True
        MenuStrip1.Items(8).Visible = True
        MenuStrip1.Items(9).Visible = True
        If login.user_group.Text = "1" Then
            MenuStrip1.Items(0).Visible = True
            MenuStrip1.Items(1).Visible = True
            MenuStrip1.Items(2).Visible = True
            MenuStrip1.Items(3).Visible = True
            MenuStrip1.Items(4).Visible = True
            MenuStrip1.Items(5).Visible = True
            MenuStrip1.Items(6).Visible = True
            MenuStrip1.Items(7).Visible = True
            MenuStrip1.Items(8).Visible = True
            MenuStrip1.Items(9).Visible = True
        End If
    End Sub

    Private Sub GlobalBalanceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GlobalBalanceToolStripMenuItem2.Click
        o_global_balance.TopMost = False
        o_global_balance.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        login.user_name.Text = ""
        login.user_password.Text = ""
        login.user_group.Text = ""

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({login}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

        login.Show()
    End Sub

    Private Sub UserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem1.Click
        a_user.TopMost = False
        a_user.Show()
    End Sub

    Private Sub PasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordToolStripMenuItem.Click
        a_password.TopMost = False
        a_password.Show()
    End Sub

    Private Sub BackupToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem1.Click
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({login}) _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

        Try
            Dim obj As New Microsoft.Office.Interop.Access.Dao.DBEngine()
            If System.IO.File.Exists(Application.StartupPath & "\source." & DateString & ".accdb") Then
                Kill(Application.StartupPath & "\source." & DateString & ".accdb")
            End If
            obj.CompactDatabase(Application.StartupPath & "\source.accdb",
                                Application.StartupPath & "\source." & DateString & ".accdb",,, ";pwd=2018Australia")
            FileCopy(Application.StartupPath & "\source." & DateString & ".accdb",
                    Application.StartupPath & "\source.accdb")
            MsgBox("Backup done!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({login}) _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = Application.StartupPath
        fd.Filter = "Data files (*.accdb)|source.*.accdb|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            If System.IO.File.Exists(strFileName) Then
                Try
                    FileCopy(strFileName, Application.StartupPath & "\source.accdb")
                    MsgBox("Restore done.")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If

    End Sub
End Class

