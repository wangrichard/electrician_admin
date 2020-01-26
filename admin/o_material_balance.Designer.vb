<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_material_balance
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
        Me.SmaterialbalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.S_material_balanceTableAdapter = New admin.sourceDataSetTableAdapters.s_material_balanceTableAdapter()
        Me.MaterialcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialoutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialbalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmaterialbalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialcategoryDataGridViewTextBoxColumn, Me.MaterialtypeDataGridViewTextBoxColumn, Me.MaterialinDataGridViewTextBoxColumn, Me.MaterialoutDataGridViewTextBoxColumn, Me.MaterialbalanceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SmaterialbalanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(49, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(581, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SmaterialbalanceBindingSource
        '
        Me.SmaterialbalanceBindingSource.DataMember = "s_material_balance"
        Me.SmaterialbalanceBindingSource.DataSource = Me.SourceDataSet
        '
        'S_material_balanceTableAdapter
        '
        Me.S_material_balanceTableAdapter.ClearBeforeFill = True
        '
        'MaterialcategoryDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryDataGridViewTextBoxColumn.DataPropertyName = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.HeaderText = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.Name = "MaterialcategoryDataGridViewTextBoxColumn"
        '
        'MaterialtypeDataGridViewTextBoxColumn
        '
        Me.MaterialtypeDataGridViewTextBoxColumn.DataPropertyName = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.HeaderText = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.Name = "MaterialtypeDataGridViewTextBoxColumn"
        '
        'MaterialinDataGridViewTextBoxColumn
        '
        Me.MaterialinDataGridViewTextBoxColumn.DataPropertyName = "material_in"
        Me.MaterialinDataGridViewTextBoxColumn.HeaderText = "material_in"
        Me.MaterialinDataGridViewTextBoxColumn.Name = "MaterialinDataGridViewTextBoxColumn"
        '
        'MaterialoutDataGridViewTextBoxColumn
        '
        Me.MaterialoutDataGridViewTextBoxColumn.DataPropertyName = "material_out"
        Me.MaterialoutDataGridViewTextBoxColumn.HeaderText = "material_out"
        Me.MaterialoutDataGridViewTextBoxColumn.Name = "MaterialoutDataGridViewTextBoxColumn"
        '
        'MaterialbalanceDataGridViewTextBoxColumn
        '
        Me.MaterialbalanceDataGridViewTextBoxColumn.DataPropertyName = "material_balance"
        Me.MaterialbalanceDataGridViewTextBoxColumn.HeaderText = "material_balance"
        Me.MaterialbalanceDataGridViewTextBoxColumn.Name = "MaterialbalanceDataGridViewTextBoxColumn"
        Me.MaterialbalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'o_material_balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "o_material_balance"
        Me.Text = "Material Balance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmaterialbalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents SmaterialbalanceBindingSource As BindingSource
    Friend WithEvents S_material_balanceTableAdapter As sourceDataSetTableAdapters.s_material_balanceTableAdapter
    Friend WithEvents MaterialcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialbalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
