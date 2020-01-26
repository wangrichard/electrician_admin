<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class i_material_out
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
        Me.MaterialcategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LmaterialcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LmaterialtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RmaterialoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_material_outTableAdapter = New admin.sourceDataSetTableAdapters.r_material_outTableAdapter()
        Me.LemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_employeeTableAdapter = New admin.sourceDataSetTableAdapters.l_employeeTableAdapter()
        Me.R_projectTableAdapter = New admin.sourceDataSetTableAdapters.r_projectTableAdapter()
        Me.L_material_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_material_categoryTableAdapter()
        Me.L_material_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_material_typeTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RmaterialoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn, Me.MaterialcategoryidDataGridViewTextBoxColumn, Me.MaterialtypeidDataGridViewTextBoxColumn, Me.UnitpriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RmaterialoutBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(756, 352)
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
        'MaterialcategoryidDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DataPropertyName = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DataSource = Me.LmaterialcategoryBindingSource
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DisplayMember = "material_category"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.MaterialcategoryidDataGridViewTextBoxColumn.HeaderText = "material_category"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Name = "MaterialcategoryidDataGridViewTextBoxColumn"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MaterialcategoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MaterialcategoryidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'LmaterialcategoryBindingSource
        '
        Me.LmaterialcategoryBindingSource.DataMember = "l_material_category"
        Me.LmaterialcategoryBindingSource.DataSource = Me.SourceDataSet
        '
        'MaterialtypeidDataGridViewTextBoxColumn
        '
        Me.MaterialtypeidDataGridViewTextBoxColumn.DataPropertyName = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn.DataSource = Me.LmaterialtypeBindingSource
        Me.MaterialtypeidDataGridViewTextBoxColumn.DisplayMember = "material_type"
        Me.MaterialtypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.MaterialtypeidDataGridViewTextBoxColumn.HeaderText = "material_type"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Name = "MaterialtypeidDataGridViewTextBoxColumn"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MaterialtypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MaterialtypeidDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'LmaterialtypeBindingSource
        '
        Me.LmaterialtypeBindingSource.DataMember = "l_material_type"
        Me.LmaterialtypeBindingSource.DataSource = Me.SourceDataSet
        '
        'UnitpriceDataGridViewTextBoxColumn
        '
        Me.UnitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.Name = "UnitpriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
        '
        'RmaterialoutBindingSource
        '
        Me.RmaterialoutBindingSource.DataMember = "r_material_out"
        Me.RmaterialoutBindingSource.DataSource = Me.SourceDataSet
        '
        'R_material_outTableAdapter
        '
        Me.R_material_outTableAdapter.ClearBeforeFill = True
        '
        'LemployeeBindingSource
        '
        Me.LemployeeBindingSource.DataMember = "l_employee"
        Me.LemployeeBindingSource.DataSource = Me.SourceDataSet
        '
        'L_employeeTableAdapter
        '
        Me.L_employeeTableAdapter.ClearBeforeFill = True
        '
        'R_projectTableAdapter
        '
        Me.R_projectTableAdapter.ClearBeforeFill = True
        '
        'L_material_categoryTableAdapter
        '
        Me.L_material_categoryTableAdapter.ClearBeforeFill = True
        '
        'L_material_typeTableAdapter
        '
        Me.L_material_typeTableAdapter.ClearBeforeFill = True
        '
        'i_material_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "i_material_out"
        Me.Text = "i_material_out"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RmaterialoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents RmaterialoutBindingSource As BindingSource
    Friend WithEvents R_material_outTableAdapter As sourceDataSetTableAdapters.r_material_outTableAdapter
    Friend WithEvents LemployeeBindingSource As BindingSource
    Friend WithEvents L_employeeTableAdapter As sourceDataSetTableAdapters.l_employeeTableAdapter
    Friend WithEvents RprojectBindingSource As BindingSource
    Friend WithEvents R_projectTableAdapter As sourceDataSetTableAdapters.r_projectTableAdapter
    Friend WithEvents LmaterialcategoryBindingSource As BindingSource
    Friend WithEvents L_material_categoryTableAdapter As sourceDataSetTableAdapters.l_material_categoryTableAdapter
    Friend WithEvents LmaterialtypeBindingSource As BindingSource
    Friend WithEvents L_material_typeTableAdapter As sourceDataSetTableAdapters.l_material_typeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents MaterialcategoryidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents MaterialtypeidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents UnitpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
