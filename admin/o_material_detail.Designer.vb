<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_material_detail
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
        Me.MaterialcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QmaterialdetailinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.Q_material_detail_inTableAdapter = New admin.sourceDataSetTableAdapters.q_material_detail_inTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaterialcategoryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QmaterialdetailoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Q_material_detail_outTableAdapter = New admin.sourceDataSetTableAdapters.q_material_detail_outTableAdapter()
        Me.cmb_material_category = New System.Windows.Forms.ComboBox()
        Me.LmaterialcategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_material_type = New System.Windows.Forms.ComboBox()
        Me.LmaterialtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.d_to_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d_from_date = New System.Windows.Forms.DateTimePicker()
        Me.L_material_categoryTableAdapter = New admin.sourceDataSetTableAdapters.l_material_categoryTableAdapter()
        Me.L_material_typeTableAdapter = New admin.sourceDataSetTableAdapters.l_material_typeTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QmaterialdetailinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QmaterialdetailoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialcategoryDataGridViewTextBoxColumn, Me.MaterialtypeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.MaterialcategoryidDataGridViewTextBoxColumn, Me.MaterialtypeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QmaterialdetailinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(48, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(597, 151)
        Me.DataGridView1.TabIndex = 0
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
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
        Me.RecorddateDataGridViewTextBoxColumn.Visible = False
        '
        'MaterialcategoryidDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DataPropertyName = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.HeaderText = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Name = "MaterialcategoryidDataGridViewTextBoxColumn"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Visible = False
        '
        'MaterialtypeidDataGridViewTextBoxColumn
        '
        Me.MaterialtypeidDataGridViewTextBoxColumn.DataPropertyName = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn.HeaderText = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Name = "MaterialtypeidDataGridViewTextBoxColumn"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Visible = False
        '
        'QmaterialdetailinBindingSource
        '
        Me.QmaterialdetailinBindingSource.DataMember = "q_material_detail_in"
        Me.QmaterialdetailinBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Q_material_detail_inTableAdapter
        '
        Me.Q_material_detail_inTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaterialcategoryDataGridViewTextBoxColumn1, Me.MaterialtypeDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.RecorddateDataGridViewTextBoxColumn1, Me.MaterialcategoryidDataGridViewTextBoxColumn1, Me.MaterialtypeidDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.QmaterialdetailoutBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(48, 307)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(597, 151)
        Me.DataGridView2.TabIndex = 1
        '
        'MaterialcategoryDataGridViewTextBoxColumn1
        '
        Me.MaterialcategoryDataGridViewTextBoxColumn1.DataPropertyName = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn1.HeaderText = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn1.Name = "MaterialcategoryDataGridViewTextBoxColumn1"
        '
        'MaterialtypeDataGridViewTextBoxColumn1
        '
        Me.MaterialtypeDataGridViewTextBoxColumn1.DataPropertyName = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn1.HeaderText = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn1.Name = "MaterialtypeDataGridViewTextBoxColumn1"
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        '
        'RecorddateDataGridViewTextBoxColumn1
        '
        Me.RecorddateDataGridViewTextBoxColumn1.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn1.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn1.Name = "RecorddateDataGridViewTextBoxColumn1"
        Me.RecorddateDataGridViewTextBoxColumn1.Visible = False
        '
        'MaterialcategoryidDataGridViewTextBoxColumn1
        '
        Me.MaterialcategoryidDataGridViewTextBoxColumn1.DataPropertyName = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn1.HeaderText = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn1.Name = "MaterialcategoryidDataGridViewTextBoxColumn1"
        Me.MaterialcategoryidDataGridViewTextBoxColumn1.Visible = False
        '
        'MaterialtypeidDataGridViewTextBoxColumn1
        '
        Me.MaterialtypeidDataGridViewTextBoxColumn1.DataPropertyName = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn1.HeaderText = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn1.Name = "MaterialtypeidDataGridViewTextBoxColumn1"
        Me.MaterialtypeidDataGridViewTextBoxColumn1.Visible = False
        '
        'QmaterialdetailoutBindingSource
        '
        Me.QmaterialdetailoutBindingSource.DataMember = "q_material_detail_out"
        Me.QmaterialdetailoutBindingSource.DataSource = Me.SourceDataSet
        '
        'Q_material_detail_outTableAdapter
        '
        Me.Q_material_detail_outTableAdapter.ClearBeforeFill = True
        '
        'cmb_material_category
        '
        Me.cmb_material_category.DataSource = Me.LmaterialcategoryBindingSource
        Me.cmb_material_category.DisplayMember = "material_category"
        Me.cmb_material_category.FormattingEnabled = True
        Me.cmb_material_category.Location = New System.Drawing.Point(48, 40)
        Me.cmb_material_category.Name = "cmb_material_category"
        Me.cmb_material_category.Size = New System.Drawing.Size(114, 21)
        Me.cmb_material_category.TabIndex = 2
        Me.cmb_material_category.ValueMember = "ID"
        '
        'LmaterialcategoryBindingSource
        '
        Me.LmaterialcategoryBindingSource.DataMember = "l_material_category"
        Me.LmaterialcategoryBindingSource.DataSource = Me.SourceDataSet
        '
        'cmb_material_type
        '
        Me.cmb_material_type.DataSource = Me.LmaterialtypeBindingSource
        Me.cmb_material_type.DisplayMember = "material_type"
        Me.cmb_material_type.FormattingEnabled = True
        Me.cmb_material_type.Location = New System.Drawing.Point(213, 40)
        Me.cmb_material_type.Name = "cmb_material_type"
        Me.cmb_material_type.Size = New System.Drawing.Size(112, 21)
        Me.cmb_material_type.TabIndex = 3
        Me.cmb_material_type.ValueMember = "ID"
        '
        'LmaterialtypeBindingSource
        '
        Me.LmaterialtypeBindingSource.DataMember = "l_material_type"
        Me.LmaterialtypeBindingSource.DataSource = Me.SourceDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Material Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Material Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(541, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "To Date"
        '
        'd_to_date
        '
        Me.d_to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d_to_date.Location = New System.Drawing.Point(544, 35)
        Me.d_to_date.Name = "d_to_date"
        Me.d_to_date.Size = New System.Drawing.Size(108, 20)
        Me.d_to_date.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "From Date"
        '
        'd_from_date
        '
        Me.d_from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d_from_date.Location = New System.Drawing.Point(374, 37)
        Me.d_from_date.Name = "d_from_date"
        Me.d_from_date.Size = New System.Drawing.Size(108, 20)
        Me.d_from_date.TabIndex = 14
        '
        'L_material_categoryTableAdapter
        '
        Me.L_material_categoryTableAdapter.ClearBeforeFill = True
        '
        'L_material_typeTableAdapter
        '
        Me.L_material_typeTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Material In"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Material Out"
        '
        'o_material_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 494)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.d_to_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.d_from_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_material_type)
        Me.Controls.Add(Me.cmb_material_category)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "o_material_detail"
        Me.Text = "Material Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QmaterialdetailinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QmaterialdetailoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialcategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LmaterialtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents QmaterialdetailinBindingSource As BindingSource
    Friend WithEvents Q_material_detail_inTableAdapter As sourceDataSetTableAdapters.q_material_detail_inTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents QmaterialdetailoutBindingSource As BindingSource
    Friend WithEvents Q_material_detail_outTableAdapter As sourceDataSetTableAdapters.q_material_detail_outTableAdapter
    Friend WithEvents cmb_material_category As ComboBox
    Friend WithEvents cmb_material_type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents d_to_date As DateTimePicker
    Friend WithEvents Label4 As Label
    Public WithEvents d_from_date As DateTimePicker
    Friend WithEvents LmaterialcategoryBindingSource As BindingSource
    Friend WithEvents L_material_categoryTableAdapter As sourceDataSetTableAdapters.l_material_categoryTableAdapter
    Friend WithEvents LmaterialtypeBindingSource As BindingSource
    Friend WithEvents L_material_typeTableAdapter As sourceDataSetTableAdapters.l_material_typeTableAdapter
    Friend WithEvents MaterialcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
