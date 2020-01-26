<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_material_category
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
        Me.LmaterialcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_material_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_material_categoryTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MaterialcategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LmaterialcategoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(233, 362)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MaterialcategoryDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryDataGridViewTextBoxColumn.DataPropertyName = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.HeaderText = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.Name = "MaterialcategoryDataGridViewTextBoxColumn"
        '
        'a_material_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 392)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "a_material_category"
        Me.Text = "Material Category"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents LmaterialcategoryBindingSource As BindingSource
    Friend WithEvents L_material_categoryTableAdapter As sourceDataSetTableAdapters.l_material_categoryTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
