<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_global_balance
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
        Me.t_income = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_expense = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_profit = New System.Windows.Forms.TextBox()
        Me.from_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.to_date = New System.Windows.Forms.DateTimePicker()
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.R_incomeTableAdapter = New admin.sourceDataSetTableAdapters.r_incomeTableAdapter()
        Me.R_expenseTableAdapter = New admin.sourceDataSetTableAdapters.r_expenseTableAdapter()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_income
        '
        Me.t_income.Location = New System.Drawing.Point(324, 71)
        Me.t_income.Name = "t_income"
        Me.t_income.Size = New System.Drawing.Size(155, 20)
        Me.t_income.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Expense"
        '
        't_expense
        '
        Me.t_expense.Location = New System.Drawing.Point(324, 116)
        Me.t_expense.Name = "t_expense"
        Me.t_expense.Size = New System.Drawing.Size(155, 20)
        Me.t_expense.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Profit"
        '
        't_profit
        '
        Me.t_profit.Location = New System.Drawing.Point(325, 164)
        Me.t_profit.Name = "t_profit"
        Me.t_profit.Size = New System.Drawing.Size(155, 20)
        Me.t_profit.TabIndex = 4
        '
        'from_date
        '
        Me.from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from_date.Location = New System.Drawing.Point(212, 245)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(108, 20)
        Me.from_date.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "From Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "To Date"
        '
        'to_date
        '
        Me.to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.to_date.Location = New System.Drawing.Point(440, 243)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(108, 20)
        Me.to_date.TabIndex = 8
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'R_incomeTableAdapter
        '
        Me.R_incomeTableAdapter.ClearBeforeFill = True
        '
        'R_expenseTableAdapter
        '
        Me.R_expenseTableAdapter.ClearBeforeFill = True
        '
        'o_global_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 290)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.to_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.from_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_profit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_expense)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t_income)
        Me.Name = "o_global_balance"
        Me.Text = "Global Profit"
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t_income As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_expense As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents t_profit As TextBox
    Friend WithEvents from_date As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents to_date As DateTimePicker
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents R_incomeTableAdapter As sourceDataSetTableAdapters.r_incomeTableAdapter
    Friend WithEvents R_expenseTableAdapter As sourceDataSetTableAdapters.r_expenseTableAdapter
End Class
