<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a_user
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsergroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LgroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.LuserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_userTableAdapter = New admin.sourceDataSetTableAdapters.l_userTableAdapter()
        Me.L_groupTableAdapter = New admin.sourceDataSetTableAdapters.l_groupTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LgroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LuserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.UsergroupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LuserBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(66, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 162)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "user_name"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'UsergroupDataGridViewTextBoxColumn
        '
        Me.UsergroupDataGridViewTextBoxColumn.DataPropertyName = "user_group"
        Me.UsergroupDataGridViewTextBoxColumn.DataSource = Me.LgroupBindingSource
        Me.UsergroupDataGridViewTextBoxColumn.DisplayMember = "user_group"
        Me.UsergroupDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.UsergroupDataGridViewTextBoxColumn.HeaderText = "user_group"
        Me.UsergroupDataGridViewTextBoxColumn.Name = "UsergroupDataGridViewTextBoxColumn"
        Me.UsergroupDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsergroupDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UsergroupDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'LgroupBindingSource
        '
        Me.LgroupBindingSource.DataMember = "l_group"
        Me.LgroupBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LuserBindingSource
        '
        Me.LuserBindingSource.DataMember = "l_user"
        Me.LuserBindingSource.DataSource = Me.SourceDataSet
        '
        'L_userTableAdapter
        '
        Me.L_userTableAdapter.ClearBeforeFill = True
        '
        'L_groupTableAdapter
        '
        Me.L_groupTableAdapter.ClearBeforeFill = True
        '
        'a_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 252)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "a_user"
        Me.Text = "User Config"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LgroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LuserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents LuserBindingSource As BindingSource
    Friend WithEvents L_userTableAdapter As sourceDataSetTableAdapters.l_userTableAdapter
    Friend WithEvents LgroupBindingSource As BindingSource
    Friend WithEvents L_groupTableAdapter As sourceDataSetTableAdapters.l_groupTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsergroupDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
End Class
