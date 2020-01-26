<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.current_password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confirm_password = New System.Windows.Forms.TextBox()
        Me.new_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'current_password
        '
        Me.current_password.Location = New System.Drawing.Point(318, 103)
        Me.current_password.Name = "current_password"
        Me.current_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.current_password.Size = New System.Drawing.Size(162, 20)
        Me.current_password.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "New Password"
        '
        'confirm_password
        '
        Me.confirm_password.Location = New System.Drawing.Point(318, 215)
        Me.confirm_password.Name = "confirm_password"
        Me.confirm_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirm_password.Size = New System.Drawing.Size(162, 20)
        Me.confirm_password.TabIndex = 7
        '
        'new_password
        '
        Me.new_password.Location = New System.Drawing.Point(318, 156)
        Me.new_password.Name = "new_password"
        Me.new_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.new_password.Size = New System.Drawing.Size(162, 20)
        Me.new_password.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Current Password"
        '
        'a_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.current_password)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.confirm_password)
        Me.Controls.Add(Me.new_password)
        Me.Name = "a_password"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents current_password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents confirm_password As TextBox
    Friend WithEvents new_password As TextBox
    Friend WithEvents Label3 As Label
End Class
