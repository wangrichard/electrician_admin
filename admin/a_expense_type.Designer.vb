<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_expense_type
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
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.LexpensetypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_expense_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_expense_typeTableAdapter()
        Me.LexpensecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_expense_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_expense_categoryTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpensecategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ExpensetypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LexpensecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ExpensecategoryidDataGridViewTextBoxColumn, Me.ExpensetypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LexpensetypeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(332, 381)
        Me.DataGridView1.TabIndex = 0
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
        'L_expense_typeTableAdapter
        '
        Me.L_expense_typeTableAdapter.ClearBeforeFill = True
        '
        'LexpensecategoryBindingSource
        '
        Me.LexpensecategoryBindingSource.DataMember = "l_expense_category"
        Me.LexpensecategoryBindingSource.DataSource = Me.SourceDataSet
        '
        'L_expense_categoryTableAdapter
        '
        Me.L_expense_categoryTableAdapter.ClearBeforeFill = True
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
        'ExpensetypeDataGridViewTextBoxColumn
        '
        Me.ExpensetypeDataGridViewTextBoxColumn.DataPropertyName = "expense_type"
        Me.ExpensetypeDataGridViewTextBoxColumn.HeaderText = "expense_type"
        Me.ExpensetypeDataGridViewTextBoxColumn.Name = "ExpensetypeDataGridViewTextBoxColumn"
        '
        'a_expense_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "a_expense_type"
        Me.Text = "a_expense_type"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexpensetypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LexpensecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents LexpensetypeBindingSource As BindingSource
    Friend WithEvents L_expense_typeTableAdapter As sourceDataSetTableAdapters.l_expense_typeTableAdapter
    Friend WithEvents LexpensecategoryBindingSource As BindingSource
    Friend WithEvents L_expense_categoryTableAdapter As sourceDataSetTableAdapters.l_expense_categoryTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpensecategoryidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ExpensetypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
