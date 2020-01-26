<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class i_manpower
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RprojectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HourlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RmanpowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_manpowerTableAdapter = New admin.sourceDataSetTableAdapters.r_manpowerTableAdapter()
        Me.R_projectTableAdapter = New admin.sourceDataSetTableAdapters.r_projectTableAdapter()
        Me.L_employeeTableAdapter = New admin.sourceDataSetTableAdapters.l_employeeTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmanpowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.WorkhoursDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RmanpowerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(37, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(705, 362)
        Me.DataGridView1.TabIndex = 0
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
        'RprojectBindingSource
        '
        Me.RprojectBindingSource.DataMember = "r_project"
        Me.RprojectBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.DataSource = Me.LemployeeBindingSource
        Me.EmployeeidDataGridViewTextBoxColumn.DisplayMember = "name"
        Me.EmployeeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmployeeidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'LemployeeBindingSource
        '
        Me.LemployeeBindingSource.DataMember = "l_employee"
        Me.LemployeeBindingSource.DataSource = Me.SourceDataSet
        '
        'HourlyrateDataGridViewTextBoxColumn
        '
        Me.HourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.HeaderText = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.Name = "HourlyrateDataGridViewTextBoxColumn"
        '
        'WorkhoursDataGridViewTextBoxColumn
        '
        Me.WorkhoursDataGridViewTextBoxColumn.DataPropertyName = "work_hours"
        Me.WorkhoursDataGridViewTextBoxColumn.HeaderText = "work_hours"
        Me.WorkhoursDataGridViewTextBoxColumn.Name = "WorkhoursDataGridViewTextBoxColumn"
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
        '
        'RmanpowerBindingSource
        '
        Me.RmanpowerBindingSource.DataMember = "r_manpower"
        Me.RmanpowerBindingSource.DataSource = Me.SourceDataSet
        '
        'R_manpowerTableAdapter
        '
        Me.R_manpowerTableAdapter.ClearBeforeFill = True
        '
        'R_projectTableAdapter
        '
        Me.R_projectTableAdapter.ClearBeforeFill = True
        '
        'L_employeeTableAdapter
        '
        Me.L_employeeTableAdapter.ClearBeforeFill = True
        '
        'i_manpower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "i_manpower"
        Me.Text = "Manpower"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmanpowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents RmanpowerBindingSource As BindingSource
    Friend WithEvents R_manpowerTableAdapter As sourceDataSetTableAdapters.r_manpowerTableAdapter
    Friend WithEvents RprojectBindingSource As BindingSource
    Friend WithEvents R_projectTableAdapter As sourceDataSetTableAdapters.r_projectTableAdapter
    Friend WithEvents LemployeeBindingSource As BindingSource
    Friend WithEvents L_employeeTableAdapter As sourceDataSetTableAdapters.l_employeeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents HourlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
