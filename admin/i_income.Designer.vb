<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class i_income
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
        Me.RincomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_incomeTableAdapter = New admin.sourceDataSetTableAdapters.r_incomeTableAdapter()
        Me.RprojectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_projectTableAdapter = New admin.sourceDataSetTableAdapters.r_projectTableAdapter()
        Me.LincometypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_income_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_income_typeTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IncometypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RincomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LincometypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn, Me.IncometypeidDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RincomeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(54, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(685, 333)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RincomeBindingSource
        '
        Me.RincomeBindingSource.DataMember = "r_income"
        Me.RincomeBindingSource.DataSource = Me.SourceDataSet
        '
        'R_incomeTableAdapter
        '
        Me.R_incomeTableAdapter.ClearBeforeFill = True
        '
        'RprojectBindingSource
        '
        Me.RprojectBindingSource.DataMember = "r_project"
        Me.RprojectBindingSource.DataSource = Me.SourceDataSet
        '
        'R_projectTableAdapter
        '
        Me.R_projectTableAdapter.ClearBeforeFill = True
        '
        'LincometypeBindingSource
        '
        Me.LincometypeBindingSource.DataMember = "l_income_type"
        Me.LincometypeBindingSource.DataSource = Me.SourceDataSet
        '
        'L_income_typeTableAdapter
        '
        Me.L_income_typeTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectidDataGridViewTextBoxColumn
        '
        Me.ProjectidDataGridViewTextBoxColumn.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.DataSource = Me.RprojectBindingSource
        Me.ProjectidDataGridViewTextBoxColumn.DisplayMember = "project_address"
        Me.ProjectidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ProjectidDataGridViewTextBoxColumn.HeaderText = "project"
        Me.ProjectidDataGridViewTextBoxColumn.Name = "ProjectidDataGridViewTextBoxColumn"
        Me.ProjectidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProjectidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProjectidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'IncometypeidDataGridViewTextBoxColumn
        '
        Me.IncometypeidDataGridViewTextBoxColumn.DataPropertyName = "income_type_id"
        Me.IncometypeidDataGridViewTextBoxColumn.DataSource = Me.LincometypeBindingSource
        Me.IncometypeidDataGridViewTextBoxColumn.DisplayMember = "income_type"
        Me.IncometypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.IncometypeidDataGridViewTextBoxColumn.HeaderText = "income_type"
        Me.IncometypeidDataGridViewTextBoxColumn.Name = "IncometypeidDataGridViewTextBoxColumn"
        Me.IncometypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IncometypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IncometypeidDataGridViewTextBoxColumn.ValueMember = "ID"
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
        'i_income
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "i_income"
        Me.Text = "i_income"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RincomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LincometypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents RincomeBindingSource As BindingSource
    Friend WithEvents R_incomeTableAdapter As sourceDataSetTableAdapters.r_incomeTableAdapter
    Friend WithEvents RprojectBindingSource As BindingSource
    Friend WithEvents R_projectTableAdapter As sourceDataSetTableAdapters.r_projectTableAdapter
    Friend WithEvents LincometypeBindingSource As BindingSource
    Friend WithEvents L_income_typeTableAdapter As sourceDataSetTableAdapters.l_income_typeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IncometypeidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
