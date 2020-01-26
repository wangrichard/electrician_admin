<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class i_expense
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LexpensecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.LexpensetypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RexpenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_expenseTableAdapter = New admin.sourceDataSetTableAdapters.r_expenseTableAdapter()
        Me.L_expense_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_expense_categoryTableAdapter()
        Me.L_expense_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_expense_typeTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpensecategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ExpensetypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexpensecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RexpenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ExpensecategoryidDataGridViewTextBoxColumn, Me.ExpensetypeidDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RexpenseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(49, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'LexpensecategoryBindingSource
        '
        Me.LexpensecategoryBindingSource.DataMember = "l_expense_category"
        Me.LexpensecategoryBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LexpensetypeBindingSource
        '
        Me.LexpensetypeBindingSource.DataMember = "l_expense_type"
        Me.LexpensetypeBindingSource.DataSource = Me.SourceDataSet
        '
        'RexpenseBindingSource
        '
        Me.RexpenseBindingSource.DataMember = "r_expense"
        Me.RexpenseBindingSource.DataSource = Me.SourceDataSet
        '
        'R_expenseTableAdapter
        '
        Me.R_expenseTableAdapter.ClearBeforeFill = True
        '
        'L_expense_categoryTableAdapter
        '
        Me.L_expense_categoryTableAdapter.ClearBeforeFill = True
        '
        'L_expense_typeTableAdapter
        '
        Me.L_expense_typeTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ExpensecategoryidDataGridViewTextBoxColumn
        '
        Me.ExpensecategoryidDataGridViewTextBoxColumn.DataPropertyName = "expense_category_id"
        Me.ExpensecategoryidDataGridViewTextBoxColumn.DataSource = Me.LexpensecategoryBindingSource
        Me.ExpensecategoryidDataGridViewTextBoxColumn.DisplayMember = "expense_category"
        Me.ExpensecategoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ExpensecategoryidDataGridViewTextBoxColumn.HeaderText = "expense_category"
        Me.ExpensecategoryidDataGridViewTextBoxColumn.Name = "ExpensecategoryidDataGridViewTextBoxColumn"
        Me.ExpensecategoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExpensecategoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ExpensecategoryidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'ExpensetypeidDataGridViewTextBoxColumn
        '
        Me.ExpensetypeidDataGridViewTextBoxColumn.DataPropertyName = "expense_type_id"
        Me.ExpensetypeidDataGridViewTextBoxColumn.DataSource = Me.LexpensetypeBindingSource
        Me.ExpensetypeidDataGridViewTextBoxColumn.DisplayMember = "expense_type"
        Me.ExpensetypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ExpensetypeidDataGridViewTextBoxColumn.HeaderText = "expense_type"
        Me.ExpensetypeidDataGridViewTextBoxColumn.Name = "ExpensetypeidDataGridViewTextBoxColumn"
        Me.ExpensetypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExpensetypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ExpensetypeidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        '
        'i_expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "i_expense"
        Me.Text = "i_expense"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexpensecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RexpenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents RexpenseBindingSource As BindingSource
    Friend WithEvents R_expenseTableAdapter As sourceDataSetTableAdapters.r_expenseTableAdapter
    Friend WithEvents LexpensecategoryBindingSource As BindingSource
    Friend WithEvents L_expense_categoryTableAdapter As sourceDataSetTableAdapters.l_expense_categoryTableAdapter
    Friend WithEvents LexpensetypeBindingSource As BindingSource
    Friend WithEvents L_expense_typeTableAdapter As sourceDataSetTableAdapters.l_expense_typeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpensecategoryidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ExpensetypeidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
