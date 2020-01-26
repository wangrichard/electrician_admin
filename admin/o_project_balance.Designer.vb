<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class o_project_balance
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
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.SprojectprofitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.S_project_profitTableAdapter = New admin.sourceDataSetTableAdapters.s_project_profitTableAdapter()
        Me.ProjectaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManpowercostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SprojectprofitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectaddressDataGridViewTextBoxColumn, Me.CustomernameDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.ManpowercostDataGridViewTextBoxColumn, Me.MaterialcostDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SprojectprofitBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(754, 346)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SprojectprofitBindingSource
        '
        Me.SprojectprofitBindingSource.DataMember = "s_project_profit"
        Me.SprojectprofitBindingSource.DataSource = Me.SourceDataSet
        '
        'S_project_profitTableAdapter
        '
        Me.S_project_profitTableAdapter.ClearBeforeFill = True
        '
        'ProjectaddressDataGridViewTextBoxColumn
        '
        Me.ProjectaddressDataGridViewTextBoxColumn.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.Name = "ProjectaddressDataGridViewTextBoxColumn"
        '
        'CustomernameDataGridViewTextBoxColumn
        '
        Me.CustomernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.HeaderText = "customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.Name = "CustomernameDataGridViewTextBoxColumn"
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "income"
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        '
        'ManpowercostDataGridViewTextBoxColumn
        '
        Me.ManpowercostDataGridViewTextBoxColumn.DataPropertyName = "man_power_cost"
        Me.ManpowercostDataGridViewTextBoxColumn.HeaderText = "man_power_cost"
        Me.ManpowercostDataGridViewTextBoxColumn.Name = "ManpowercostDataGridViewTextBoxColumn"
        '
        'MaterialcostDataGridViewTextBoxColumn
        '
        Me.MaterialcostDataGridViewTextBoxColumn.DataPropertyName = "material_cost"
        Me.MaterialcostDataGridViewTextBoxColumn.HeaderText = "material_cost"
        Me.MaterialcostDataGridViewTextBoxColumn.Name = "MaterialcostDataGridViewTextBoxColumn"
        '
        'ProfitDataGridViewTextBoxColumn
        '
        Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "profit"
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        Me.ProfitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'o_project_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "o_project_balance"
        Me.Text = "Project Balance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SprojectprofitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents SprojectprofitBindingSource As BindingSource
    Friend WithEvents S_project_profitTableAdapter As sourceDataSetTableAdapters.s_project_profitTableAdapter
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManpowercostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
