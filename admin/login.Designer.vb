<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.user_name = New System.Windows.Forms.TextBox()
        Me.user_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.user_group = New System.Windows.Forms.TextBox()
        Me.user_id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'user_name
        '
        Me.user_name.Location = New System.Drawing.Point(215, 97)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(162, 20)
        Me.user_name.TabIndex = 0
        '
        'user_password
        '
        Me.user_password.Location = New System.Drawing.Point(215, 156)
        Me.user_password.Name = "user_password"
        Me.user_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.user_password.Size = New System.Drawing.Size(162, 20)
        Me.user_password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(233, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'user_group
        '
        Me.user_group.Location = New System.Drawing.Point(215, 44)
        Me.user_group.Name = "user_group"
        Me.user_group.Size = New System.Drawing.Size(162, 20)
        Me.user_group.TabIndex = 5
        Me.user_group.Visible = False
        '
        'user_id
        '
        Me.user_id.Location = New System.Drawing.Point(215, 12)
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(162, 20)
        Me.user_id.TabIndex = 6
        Me.user_id.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 305)
        Me.Controls.Add(Me.user_id)
        Me.Controls.Add(Me.user_group)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user_password)
        Me.Controls.Add(Me.user_name)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user_name As TextBox
    Friend WithEvents user_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents user_group As TextBox
    Friend WithEvents user_id As TextBox
End Class
