<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a_project
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
        Me.RprojectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_projectTableAdapter = New admin.sourceDataSetTableAdapters.r_projectTableAdapter()
        Me.LcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_customerTableAdapter = New admin.sourceDataSetTableAdapters.l_customerTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProjectaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.ProjectaddressDataGridViewTextBoxColumn, Me.StartdateDataGridViewTextBoxColumn, Me.FinishdateDataGridViewTextBoxColumn, Me.DurationDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RprojectBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(36, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(727, 346)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LcustomerBindingSource
        '
        Me.LcustomerBindingSource.DataMember = "l_customer"
        Me.LcustomerBindingSource.DataSource = Me.SourceDataSet
        '
        'L_customerTableAdapter
        '
        Me.L_customerTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.DataSource = Me.LcustomerBindingSource
        Me.CustomeridDataGridViewTextBoxColumn.DisplayMember = "customer_name"
        Me.CustomeridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        Me.CustomeridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomeridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CustomeridDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'ProjectaddressDataGridViewTextBoxColumn
        '
        Me.ProjectaddressDataGridViewTextBoxColumn.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.Name = "ProjectaddressDataGridViewTextBoxColumn"
        '
        'StartdateDataGridViewTextBoxColumn
        '
        Me.StartdateDataGridViewTextBoxColumn.DataPropertyName = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.HeaderText = "start_date"
        Me.StartdateDataGridViewTextBoxColumn.Name = "StartdateDataGridViewTextBoxColumn"
        '
        'FinishdateDataGridViewTextBoxColumn
        '
        Me.FinishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date"
        Me.FinishdateDataGridViewTextBoxColumn.HeaderText = "finish_date"
        Me.FinishdateDataGridViewTextBoxColumn.Name = "FinishdateDataGridViewTextBoxColumn"
        '
        'DurationDataGridViewTextBoxColumn
        '
        Me.DurationDataGridViewTextBoxColumn.DataPropertyName = "duration"
        Me.DurationDataGridViewTextBoxColumn.HeaderText = "duration"
        Me.DurationDataGridViewTextBoxColumn.Name = "DurationDataGridViewTextBoxColumn"
        Me.DurationDataGridViewTextBoxColumn.Visible = False
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "income"
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        Me.IncomeDataGridViewTextBoxColumn.Visible = False
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'ProfitDataGridViewTextBoxColumn
        '
        Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "profit"
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        '
        'a_project
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "a_project"
        Me.Text = "Project"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents RprojectBindingSource As BindingSource
    Friend WithEvents R_projectTableAdapter As sourceDataSetTableAdapters.r_projectTableAdapter
    Friend WithEvents LcustomerBindingSource As BindingSource
    Friend WithEvents L_customerTableAdapter As sourceDataSetTableAdapters.l_customerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinishdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
