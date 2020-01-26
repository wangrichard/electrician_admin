<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_material_type
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
        Me.LmaterialtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_material_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_material_typeTableAdapter()
        Me.LmaterialcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_material_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_material_categoryTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MaterialtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MaterialcategoryidDataGridViewTextBoxColumn, Me.MaterialtypeDataGridViewTextBoxColumn, Me.UnitpriceDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LmaterialtypeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(457, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LmaterialtypeBindingSource
        '
        Me.LmaterialtypeBindingSource.DataMember = "l_material_type"
        Me.LmaterialtypeBindingSource.DataSource = Me.SourceDataSet
        '
        'L_material_typeTableAdapter
        '
        Me.L_material_typeTableAdapter.ClearBeforeFill = True
        '
        'LmaterialcategoryBindingSource
        '
        Me.LmaterialcategoryBindingSource.DataMember = "l_material_category"
        Me.LmaterialcategoryBindingSource.DataSource = Me.SourceDataSet
        '
        'L_material_categoryTableAdapter
        '
        Me.L_material_categoryTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
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
        'MaterialtypeDataGridViewTextBoxColumn
        '
        Me.MaterialtypeDataGridViewTextBoxColumn.DataPropertyName = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.HeaderText = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.Name = "MaterialtypeDataGridViewTextBoxColumn"
        '
        'UnitpriceDataGridViewTextBoxColumn
        '
        Me.UnitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.Name = "UnitpriceDataGridViewTextBoxColumn"
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        '
        'a_material_type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 388)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "a_material_type"
        Me.Text = "Material Type"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents LmaterialtypeBindingSource As BindingSource
    Friend WithEvents L_material_typeTableAdapter As sourceDataSetTableAdapters.l_material_typeTableAdapter
    Friend WithEvents LmaterialcategoryBindingSource As BindingSource
    Friend WithEvents L_material_categoryTableAdapter As sourceDataSetTableAdapters.l_material_categoryTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents MaterialtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
